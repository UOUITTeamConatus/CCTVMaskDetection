
namespace CCTVMaskDetection
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cctvPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cctvMonitor1 = new System.Windows.Forms.PictureBox();
            this.cctvMonitor0 = new System.Windows.Forms.PictureBox();
            this.controlPanel0 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.screen2_cbtn = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.elapsedTime = new System.Windows.Forms.Label();
            this.capture_cbtn = new System.Windows.Forms.CheckBox();
            this.stop_cbtn = new System.Windows.Forms.CheckBox();
            this.screen1_cbtn = new System.Windows.Forms.CheckBox();
            this.record_cbtn = new System.Windows.Forms.CheckBox();
            this.logwrite_btn = new System.Windows.Forms.Button();
            this.logclear_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.path_btn = new System.Windows.Forms.Button();
            this.savePath = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connect_btn0 = new System.Windows.Forms.Button();
            this.camera2_add = new System.Windows.Forms.TextBox();
            this.camera1_add = new System.Windows.Forms.TextBox();
            this.controlPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.split_view = new System.Windows.Forms.Button();
            this.Full_view = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ON_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.connect_btn1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cctvPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor0)).BeginInit();
            this.controlPanel0.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.controlPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.cctvPanel);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.controlPanel0);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1902, 981);
            this.splitContainer1.SplitterDistance = 1421;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // cctvPanel
            // 
            this.cctvPanel.AutoSize = true;
            this.cctvPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cctvPanel.ColumnCount = 2;
            this.cctvPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cctvPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cctvPanel.Controls.Add(this.cctvMonitor0, 0, 0);
            this.cctvPanel.Controls.Add(this.cctvMonitor1, 1, 0);
            this.cctvPanel.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.cctvPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.cctvPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cctvPanel.Location = new System.Drawing.Point(0, 0);
            this.cctvPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cctvPanel.Name = "cctvPanel";
            this.cctvPanel.RowCount = 2;
            this.cctvPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cctvPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cctvPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.cctvPanel.Size = new System.Drawing.Size(1421, 981);
            this.cctvPanel.TabIndex = 0;
            // 
            // cctvMonitor1
            // 
            this.cctvMonitor1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cctvMonitor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cctvMonitor1.Location = new System.Drawing.Point(713, 4);
            this.cctvMonitor1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cctvMonitor1.Name = "cctvMonitor1";
            this.cctvMonitor1.Size = new System.Drawing.Size(705, 482);
            this.cctvMonitor1.TabIndex = 1;
            this.cctvMonitor1.TabStop = false;
            // 
            // cctvMonitor0
            // 
            this.cctvMonitor0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cctvMonitor0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cctvMonitor0.Location = new System.Drawing.Point(3, 4);
            this.cctvMonitor0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cctvMonitor0.Name = "cctvMonitor0";
            this.cctvMonitor0.Size = new System.Drawing.Size(704, 482);
            this.cctvMonitor0.TabIndex = 0;
            this.cctvMonitor0.TabStop = false;
            // 
            // controlPanel0
            // 
            this.controlPanel0.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.controlPanel0.ColumnCount = 1;
            this.controlPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel0.Controls.Add(this.groupBox5, 0, 3);
            this.controlPanel0.Controls.Add(this.groupBox2, 0, 2);
            this.controlPanel0.Controls.Add(this.groupBox6, 0, 1);
            this.controlPanel0.Controls.Add(this.controlPanel1, 0, 0);
            this.controlPanel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel0.Location = new System.Drawing.Point(0, 0);
            this.controlPanel0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlPanel0.Name = "controlPanel0";
            this.controlPanel0.RowCount = 4;
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 408F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.controlPanel0.Size = new System.Drawing.Size(476, 981);
            this.controlPanel0.TabIndex = 15;
            this.controlPanel0.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.screen2_cbtn);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.capture_cbtn);
            this.groupBox5.Controls.Add(this.stop_cbtn);
            this.groupBox5.Controls.Add(this.screen1_cbtn);
            this.groupBox5.Controls.Add(this.record_cbtn);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 602);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(470, 375);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "캡쳐 및 녹화";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(209, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "화면 녹화";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "녹화 중지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "화면 캡쳐";
            // 
            // screen2_cbtn
            // 
            this.screen2_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.screen2_cbtn.AutoCheck = false;
            this.screen2_cbtn.AutoSize = true;
            this.screen2_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.screen2_cbtn.Location = new System.Drawing.Point(162, 73);
            this.screen2_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.screen2_cbtn.Name = "screen2_cbtn";
            this.screen2_cbtn.Size = new System.Drawing.Size(38, 38);
            this.screen2_cbtn.TabIndex = 12;
            this.screen2_cbtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "화면 선택 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.elapsedTime);
            this.groupBox3.Location = new System.Drawing.Point(232, 51);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(152, 60);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "경과 시간";
            // 
            // elapsedTime
            // 
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTime.Location = new System.Drawing.Point(38, 28);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(88, 23);
            this.elapsedTime.TabIndex = 0;
            this.elapsedTime.Text = "00:00:00";
            // 
            // capture_cbtn
            // 
            this.capture_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.capture_cbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.capture_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_screenshot_32;
            this.capture_cbtn.Location = new System.Drawing.Point(107, 162);
            this.capture_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capture_cbtn.Name = "capture_cbtn";
            this.capture_cbtn.Size = new System.Drawing.Size(54, 51);
            this.capture_cbtn.TabIndex = 8;
            this.capture_cbtn.UseVisualStyleBackColor = true;
            // 
            // stop_cbtn
            // 
            this.stop_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.stop_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_stop_squared_32;
            this.stop_cbtn.Location = new System.Drawing.Point(330, 162);
            this.stop_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stop_cbtn.Name = "stop_cbtn";
            this.stop_cbtn.Size = new System.Drawing.Size(54, 51);
            this.stop_cbtn.TabIndex = 10;
            this.stop_cbtn.UseVisualStyleBackColor = true;
            // 
            // screen1_cbtn
            // 
            this.screen1_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.screen1_cbtn.AutoSize = true;
            this.screen1_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.screen1_cbtn.Location = new System.Drawing.Point(107, 73);
            this.screen1_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.screen1_cbtn.Name = "screen1_cbtn";
            this.screen1_cbtn.Size = new System.Drawing.Size(38, 38);
            this.screen1_cbtn.TabIndex = 3;
            this.screen1_cbtn.UseVisualStyleBackColor = true;
            // 
            // record_cbtn
            // 
            this.record_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.record_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_record_30;
            this.record_cbtn.Location = new System.Drawing.Point(213, 162);
            this.record_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.record_cbtn.Name = "record_cbtn";
            this.record_cbtn.Size = new System.Drawing.Size(54, 51);
            this.record_cbtn.TabIndex = 9;
            this.record_cbtn.UseVisualStyleBackColor = true;
            // 
            // logwrite_btn
            // 
            this.logwrite_btn.AutoSize = true;
            this.logwrite_btn.Location = new System.Drawing.Point(437, 21);
            this.logwrite_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logwrite_btn.Name = "logwrite_btn";
            this.logwrite_btn.Size = new System.Drawing.Size(86, 41);
            this.logwrite_btn.TabIndex = 5;
            this.logwrite_btn.Text = "내보내기";
            this.logwrite_btn.UseVisualStyleBackColor = true;
            // 
            // logclear_btn
            // 
            this.logclear_btn.AutoSize = true;
            this.logclear_btn.Location = new System.Drawing.Point(519, 21);
            this.logclear_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logclear_btn.Name = "logclear_btn";
            this.logclear_btn.Size = new System.Drawing.Size(86, 41);
            this.logclear_btn.TabIndex = 6;
            this.logclear_btn.Text = "Clear";
            this.logclear_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.path_btn);
            this.groupBox2.Controls.Add(this.savePath);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 511);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(470, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "저장 경로 설정";
            // 
            // path_btn
            // 
            this.path_btn.AutoSize = true;
            this.path_btn.Location = new System.Drawing.Point(332, 23);
            this.path_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path_btn.Name = "path_btn";
            this.path_btn.Size = new System.Drawing.Size(92, 41);
            this.path_btn.TabIndex = 2;
            this.path_btn.Text = "찾아보기..";
            this.path_btn.UseVisualStyleBackColor = true;
            this.path_btn.Click += new System.EventHandler(this.path_btn_Click);
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(20, 27);
            this.savePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(299, 30);
            this.savePath.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.connect_btn1);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.connect_btn0);
            this.groupBox6.Controls.Add(this.camera2_add);
            this.groupBox6.Controls.Add(this.camera1_add);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 103);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(470, 400);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "네트워크 스트림 장치 연결";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(18, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "예) IP 카메라 : rtsp://192.168.0.137/profile2/media.smp\r\n      webcam : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "화면 #2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "화면 #1";
            // 
            // connect_btn0
            // 
            this.connect_btn0.AutoSize = true;
            this.connect_btn0.Location = new System.Drawing.Point(312, 129);
            this.connect_btn0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connect_btn0.Name = "connect_btn0";
            this.connect_btn0.Size = new System.Drawing.Size(86, 41);
            this.connect_btn0.TabIndex = 11;
            this.connect_btn0.Text = "연결";
            this.connect_btn0.UseVisualStyleBackColor = true;
            // 
            // camera2_add
            // 
            this.camera2_add.Location = new System.Drawing.Point(96, 216);
            this.camera2_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera2_add.Name = "camera2_add";
            this.camera2_add.Size = new System.Drawing.Size(302, 30);
            this.camera2_add.TabIndex = 5;
            // 
            // camera1_add
            // 
            this.camera1_add.Location = new System.Drawing.Point(96, 91);
            this.camera1_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera1_add.Name = "camera1_add";
            this.camera1_add.Size = new System.Drawing.Size(302, 30);
            this.camera1_add.TabIndex = 3;
            // 
            // controlPanel1
            // 
            this.controlPanel1.ColumnCount = 2;
            this.controlPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.6817F));
            this.controlPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.3183F));
            this.controlPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.controlPanel1.Controls.Add(this.ON_btn, 1, 0);
            this.controlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel1.Location = new System.Drawing.Point(3, 4);
            this.controlPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.RowCount = 1;
            this.controlPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.controlPanel1.Size = new System.Drawing.Size(470, 91);
            this.controlPanel1.TabIndex = 14;
            this.controlPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.split_view);
            this.groupBox4.Controls.Add(this.Full_view);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(335, 83);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "화면 방식";
            // 
            // split_view
            // 
            this.split_view.BackColor = System.Drawing.SystemColors.Control;
            this.split_view.Image = global::CCTVMaskDetection.Properties.Resources.icons8_four_squares_50;
            this.split_view.Location = new System.Drawing.Point(248, 27);
            this.split_view.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.split_view.Name = "split_view";
            this.split_view.Size = new System.Drawing.Size(38, 39);
            this.split_view.TabIndex = 14;
            this.split_view.UseVisualStyleBackColor = false;
            this.split_view.Click += new System.EventHandler(this.split_view_Click);
            // 
            // Full_view
            // 
            this.Full_view.BackColor = System.Drawing.SystemColors.Control;
            this.Full_view.Image = global::CCTVMaskDetection.Properties.Resources.icons8_square_border_32;
            this.Full_view.Location = new System.Drawing.Point(101, 31);
            this.Full_view.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Full_view.Name = "Full_view";
            this.Full_view.Size = new System.Drawing.Size(37, 31);
            this.Full_view.TabIndex = 13;
            this.Full_view.UseVisualStyleBackColor = false;
            this.Full_view.Click += new System.EventHandler(this.Full_view_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "분할 화면";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "전체 화면";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ON_btn
            // 
            this.ON_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ON_btn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_power_off_button_32;
            this.ON_btn.Location = new System.Drawing.Point(344, 4);
            this.ON_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ON_btn.Name = "ON_btn";
            this.ON_btn.Size = new System.Drawing.Size(123, 83);
            this.ON_btn.TabIndex = 16;
            this.ON_btn.UseVisualStyleBackColor = true;
            this.ON_btn.Click += new System.EventHandler(this.ON_btn_Click);
            // 
            // connect_btn1
            // 
            this.connect_btn1.AutoSize = true;
            this.connect_btn1.Location = new System.Drawing.Point(312, 254);
            this.connect_btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connect_btn1.Name = "connect_btn1";
            this.connect_btn1.Size = new System.Drawing.Size(86, 41);
            this.connect_btn1.TabIndex = 17;
            this.connect_btn1.Text = "연결";
            this.connect_btn1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(713, 493);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 485);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(699, 382);
            this.textBox1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 493);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(704, 485);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(698, 382);
            this.textBox2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.logwrite_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 91);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.logclear_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 91);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(529, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(427, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "내보내기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1902, 981);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Conatus 방역관제CCTV시스템";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cctvPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor0)).EndInit();
            this.controlPanel0.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.controlPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button logwrite_btn;
        private System.Windows.Forms.Button logclear_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel cctvPanel;
        private System.Windows.Forms.PictureBox cctvMonitor1;
        private System.Windows.Forms.PictureBox cctvMonitor0;
        private System.Windows.Forms.TableLayoutPanel controlPanel0;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label elapsedTime;
        private System.Windows.Forms.CheckBox capture_cbtn;
        private System.Windows.Forms.CheckBox stop_cbtn;
        private System.Windows.Forms.CheckBox screen1_cbtn;
        private System.Windows.Forms.CheckBox record_cbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button path_btn;
        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect_btn0;
        private System.Windows.Forms.TextBox camera2_add;
        private System.Windows.Forms.TextBox camera1_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button split_view;
        private System.Windows.Forms.Button Full_view;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel controlPanel1;
        private System.Windows.Forms.Button ON_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox screen2_cbtn;
        private System.Windows.Forms.Button connect_btn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

