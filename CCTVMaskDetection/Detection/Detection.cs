using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Dnn;
using Keras.Models;
using Keras.Applications.MobileNet;
using Numpy;
using Keras.PreProcessing.Image;
using System.IO;

namespace CCTVMaskDetection.Detection
{
    public partial class Detection
    {
        #region 1. 필드
        private Net _facenet = CvDnn.ReadNetFromCaffe(Program.PrototxtPath, Program.CaffemodelPath);
        private BaseModel _model = BaseModel.LoadModel(Program.MaskdetectorPath);
        private MobileNetV2 _mobilenetv2 = new MobileNetV2();
        //public string RTSPaddr = ""; // 실험에 사용한 IP카메라의 RTSP 프로토콜 주소
        #endregion
        #region 2. Getter Setter
        public Net Facenet { get => _facenet; set => _facenet = value; }
        public BaseModel Model { get => _model; set => _model = value; }
        public MobileNetV2 Mobilenetv2 { get => _mobilenetv2; set => _mobilenetv2 = value; }
        #endregion
        public (Mat, int, int) DetectMask(Mat frame, int mask, int nomask)
        {
            string timenow;
            Mat result = frame;
            int nomaskcnt = nomask;
            int maskcnt = mask;
            //우선 받아온 이미지 frame을 그대로 result로 복사
            Mat blob = CvDnn.BlobFromImage(result, 1, new OpenCvSharp.Size(300, 300), new OpenCvSharp.Scalar(104, 177, 123), false, false);
            Facenet.SetInput(blob, "data");
            Mat dets = Facenet.Forward();
            int w = result.Width;
            int h = result.Height;
            for (int i = 0; i < dets.Size(2); i++)
            {
                float confidence = dets.At<float>(0, 0, i, 2);
                if (confidence < 0.5) continue;
                int x1 = (int)(w * dets.At<float>(0, 0, i, 3)); // 특정 array element를 반환
                int y1 = (int)(h * dets.At<float>(0, 0, i, 4));
                int x2 = (int)(w * dets.At<float>(0, 0, i, 5));
                int y2 = (int)(h * dets.At<float>(0, 0, i, 6));

                try
                {
                    Mat face = result.SubMat(new Rect(x1, y1, x2 - x1, y2 - y1));
                    Mat face_input = new Mat(face.Size(), MatType.CV_8UC3);

                    Cv2.Resize(face, face_input, new Size(224, 224));
                    Cv2.CvtColor(face_input, face_input, ColorConversionCodes.BGR2RGB);

                    int width = face_input.Width;
                    int height = face_input.Height;

                    face_input = face_input.Reshape(1);
                    face_input.GetArray(out byte[] face_array);
                    NDarray X = np.array(face_array, dtype: np.uint8).reshape(width, height, 3);
                    X = Mobilenetv2.PreprocessInput(X);
                    X = np.expand_dims(X, axis: 0);

                    NDarray preds = Model.Predict(X);

                    preds = np.squeeze(preds);

                    var maxIndex = preds.argmax();
                    var max = maxIndex.ToString();

                    Console.WriteLine(preds);
                    float MaskRate = float.Parse(preds[0].ToString()) * 100;
                    float NoMaskRate = float.Parse(preds[1].ToString()) * 100;

                    Scalar color;
                    string label;
                    if (MaskRate > NoMaskRate)
                    {
                        color = new Scalar(0, 255, 0);
                        label = "Mask " + string.Format("{0:F2}", MaskRate) + "%";
                        maskcnt++;
                    }
                    else
                    {
                        color = new Scalar(0, 0, 255);
                        label = "No Mask " + string.Format("{0:F2}", NoMaskRate) + "%";
                        nomaskcnt++;
                    }
                    Cv2.Rectangle(result, new Rect(x1, y1, x2 - x1, y2 - y1), color, 2);
                    Size textSize = Cv2.GetTextSize("face", HersheyFonts.HersheySimplex, 0.5, 1, out var baseline);
                    Cv2.PutText(result, label, new Point(x1, y1), HersheyFonts.HersheySimplex, 0.5, color);
                }
                catch (OpenCVException E)
                {
                    Console.WriteLine(E.Message);
                    //return result;
                }
            }
            timenow = DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss");
            Cv2.PutText(result, timenow, new OpenCvSharp.Point(0, 20), HersheyFonts.HersheySimplex, 0.8, new OpenCvSharp.Scalar(0, 0, 0));
            return (result, maskcnt, nomaskcnt);
        }
    }
}
