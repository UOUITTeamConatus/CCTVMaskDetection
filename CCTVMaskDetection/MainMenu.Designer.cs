
namespace CCTVMaskDetection
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cctvPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cctvMonitor0 = new System.Windows.Forms.PictureBox();
            this.cctvMonitor1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.logclear_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logwrite_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.controlPanel0 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.screen2_cbtn = new System.Windows.Forms.CheckBox();
            this.captureSelect = new System.Windows.Forms.Label();
            this.capture_cbtn = new System.Windows.Forms.CheckBox();
            this.stop_cbtn = new System.Windows.Forms.CheckBox();
            this.screen1_cbtn = new System.Windows.Forms.CheckBox();
            this.record_cbtn = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.path_btn = new System.Windows.Forms.Button();
            this.savePath = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.modeChg1 = new System.Windows.Forms.GroupBox();
            this.IOButton1 = new System.Windows.Forms.Button();
            this.chk_Ip1 = new System.Windows.Forms.RadioButton();
            this.chk_wc1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pathSaveBtn_1 = new System.Windows.Forms.Button();
            this.camera2_add = new System.Windows.Forms.TextBox();
            this.modeChg0 = new System.Windows.Forms.GroupBox();
            this.IOButton0 = new System.Windows.Forms.Button();
            this.chk_Ip0 = new System.Windows.Forms.RadioButton();
            this.chk_wc0 = new System.Windows.Forms.RadioButton();
            this.pathSaveBtn_0 = new System.Windows.Forms.Button();
            this.camera1_add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.controlPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.screenSelect = new System.Windows.Forms.GroupBox();
            this.screen2 = new System.Windows.Forms.Label();
            this.screen1 = new System.Windows.Forms.Label();
            this.ON_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.만든사람들ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.screen1_select_btn = new System.Windows.Forms.CheckBox();
            this.screen0_select_btn = new System.Windows.Forms.CheckBox();
            this.elapsedTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cctvPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.controlPanel0.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.modeChg1.SuspendLayout();
            this.modeChg0.SuspendLayout();
            this.controlPanel1.SuspendLayout();
            this.screenSelect.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
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
            this.splitContainer1.Size = new System.Drawing.Size(1676, 797);
            this.splitContainer1.SplitterDistance = 1251;
            this.splitContainer1.TabIndex = 0;
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
            this.cctvPanel.Name = "cctvPanel";
            this.cctvPanel.RowCount = 2;
            this.cctvPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cctvPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cctvPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.cctvPanel.Size = new System.Drawing.Size(1251, 797);
            this.cctvPanel.TabIndex = 0;
            // 
            // cctvMonitor0
            // 
            this.cctvMonitor0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cctvMonitor0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cctvMonitor0.Location = new System.Drawing.Point(3, 3);
            this.cctvMonitor0.Name = "cctvMonitor0";
            this.cctvMonitor0.Size = new System.Drawing.Size(619, 392);
            this.cctvMonitor0.TabIndex = 0;
            this.cctvMonitor0.TabStop = false;
            // 
            // cctvMonitor1
            // 
            this.cctvMonitor1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cctvMonitor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cctvMonitor1.Location = new System.Drawing.Point(628, 3);
            this.cctvMonitor1.Name = "cctvMonitor1";
            this.cctvMonitor1.Size = new System.Drawing.Size(620, 392);
            this.cctvMonitor1.TabIndex = 1;
            this.cctvMonitor1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(628, 400);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 395);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(3, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(614, 312);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.logclear_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 318);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 75);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(374, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "내보내기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // logclear_btn
            // 
            this.logclear_btn.AutoSize = true;
            this.logclear_btn.Location = new System.Drawing.Point(454, 17);
            this.logclear_btn.Name = "logclear_btn";
            this.logclear_btn.Size = new System.Drawing.Size(75, 33);
            this.logclear_btn.TabIndex = 6;
            this.logclear_btn.Text = "Clear";
            this.logclear_btn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 400);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(619, 395);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(3, 2);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(613, 312);
            this.textBox2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.logwrite_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 75);
            this.panel1.TabIndex = 1;
            // 
            // logwrite_btn
            // 
            this.logwrite_btn.AutoSize = true;
            this.logwrite_btn.Location = new System.Drawing.Point(382, 17);
            this.logwrite_btn.Name = "logwrite_btn";
            this.logwrite_btn.Size = new System.Drawing.Size(75, 33);
            this.logwrite_btn.TabIndex = 5;
            this.logwrite_btn.Text = "내보내기";
            this.logwrite_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(463, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
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
            this.controlPanel0.Name = "controlPanel0";
            this.controlPanel0.RowCount = 4;
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.controlPanel0.Size = new System.Drawing.Size(421, 797);
            this.controlPanel0.TabIndex = 15;
            this.controlPanel0.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.screen2_cbtn);
            this.groupBox5.Controls.Add(this.captureSelect);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.capture_cbtn);
            this.groupBox5.Controls.Add(this.stop_cbtn);
            this.groupBox5.Controls.Add(this.screen1_cbtn);
            this.groupBox5.Controls.Add(this.record_cbtn);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 563);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 231);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "캡쳐 및 녹화";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(183, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "화면 녹화";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(285, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "녹화 중지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "화면 캡쳐";
            // 
            // screen2_cbtn
            // 
            this.screen2_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.screen2_cbtn.AutoCheck = false;
            this.screen2_cbtn.AutoSize = true;
            this.screen2_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.screen2_cbtn.Location = new System.Drawing.Point(186, 47);
            this.screen2_cbtn.Name = "screen2_cbtn";
            this.screen2_cbtn.Size = new System.Drawing.Size(38, 38);
            this.screen2_cbtn.TabIndex = 12;
            this.screen2_cbtn.UseVisualStyleBackColor = true;
            // 
            // captureSelect
            // 
            this.captureSelect.AutoSize = true;
            this.captureSelect.Location = new System.Drawing.Point(11, 47);
            this.captureSelect.Name = "captureSelect";
            this.captureSelect.Size = new System.Drawing.Size(102, 18);
            this.captureSelect.TabIndex = 11;
            this.captureSelect.Text = "캡쳐 화면 선택 :";
            // 
            // capture_cbtn
            // 
            this.capture_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.capture_cbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.capture_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_screenshot_32;
            this.capture_cbtn.Location = new System.Drawing.Point(94, 130);
            this.capture_cbtn.Name = "capture_cbtn";
            this.capture_cbtn.Size = new System.Drawing.Size(47, 41);
            this.capture_cbtn.TabIndex = 8;
            this.capture_cbtn.UseVisualStyleBackColor = true;
            // 
            // stop_cbtn
            // 
            this.stop_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.stop_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_stop_squared_32;
            this.stop_cbtn.Location = new System.Drawing.Point(289, 130);
            this.stop_cbtn.Name = "stop_cbtn";
            this.stop_cbtn.Size = new System.Drawing.Size(47, 41);
            this.stop_cbtn.TabIndex = 10;
            this.stop_cbtn.UseVisualStyleBackColor = true;
            // 
            // screen1_cbtn
            // 
            this.screen1_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.screen1_cbtn.AutoSize = true;
            this.screen1_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.screen1_cbtn.Location = new System.Drawing.Point(127, 47);
            this.screen1_cbtn.Name = "screen1_cbtn";
            this.screen1_cbtn.Size = new System.Drawing.Size(38, 38);
            this.screen1_cbtn.TabIndex = 3;
            this.screen1_cbtn.UseVisualStyleBackColor = true;
            // 
            // record_cbtn
            // 
            this.record_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.record_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_record_30;
            this.record_cbtn.Location = new System.Drawing.Point(186, 130);
            this.record_cbtn.Name = "record_cbtn";
            this.record_cbtn.Size = new System.Drawing.Size(47, 41);
            this.record_cbtn.TabIndex = 9;
            this.record_cbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.path_btn);
            this.groupBox2.Controls.Add(this.savePath);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "저장 경로 설정";
            // 
            // path_btn
            // 
            this.path_btn.AutoSize = true;
            this.path_btn.Location = new System.Drawing.Point(290, 18);
            this.path_btn.Name = "path_btn";
            this.path_btn.Size = new System.Drawing.Size(80, 33);
            this.path_btn.TabIndex = 2;
            this.path_btn.Text = "찾아보기..";
            this.path_btn.UseVisualStyleBackColor = true;
            this.path_btn.Click += new System.EventHandler(this.path_btn_Click);
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(18, 22);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(262, 26);
            this.savePath.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.modeChg1);
            this.groupBox6.Controls.Add(this.modeChg0);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(415, 393);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "네트워크 스트림 장치 연결";
            // 
            // modeChg1
            // 
            this.modeChg1.Controls.Add(this.IOButton1);
            this.modeChg1.Controls.Add(this.chk_Ip1);
            this.modeChg1.Controls.Add(this.chk_wc1);
            this.modeChg1.Controls.Add(this.label3);
            this.modeChg1.Controls.Add(this.pathSaveBtn_1);
            this.modeChg1.Controls.Add(this.camera2_add);
            this.modeChg1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeChg1.Location = new System.Drawing.Point(36, 243);
            this.modeChg1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg1.Name = "modeChg1";
            this.modeChg1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg1.Size = new System.Drawing.Size(330, 117);
            this.modeChg1.TabIndex = 21;
            this.modeChg1.TabStop = false;
            this.modeChg1.Text = "화면 #2";
            // 
            // IOButton1
            // 
            this.IOButton1.Location = new System.Drawing.Point(178, 79);
            this.IOButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IOButton1.Name = "IOButton1";
            this.IOButton1.Size = new System.Drawing.Size(83, 33);
            this.IOButton1.TabIndex = 20;
            this.IOButton1.Text = "ON";
            this.IOButton1.UseVisualStyleBackColor = true;
            this.IOButton1.Click += new System.EventHandler(this.connect_btn1_Click);
            // 
            // chk_Ip1
            // 
            this.chk_Ip1.AutoSize = true;
            this.chk_Ip1.Location = new System.Drawing.Point(135, 22);
            this.chk_Ip1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Ip1.Name = "chk_Ip1";
            this.chk_Ip1.Size = new System.Drawing.Size(86, 23);
            this.chk_Ip1.TabIndex = 2;
            this.chk_Ip1.TabStop = true;
            this.chk_Ip1.Text = "IPCamera";
            this.chk_Ip1.UseVisualStyleBackColor = true;
            // 
            // chk_wc1
            // 
            this.chk_wc1.AutoSize = true;
            this.chk_wc1.Location = new System.Drawing.Point(8, 22);
            this.chk_wc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_wc1.Name = "chk_wc1";
            this.chk_wc1.Size = new System.Drawing.Size(83, 23);
            this.chk_wc1.TabIndex = 1;
            this.chk_wc1.TabStop = true;
            this.chk_wc1.Text = "WebCam";
            this.chk_wc1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "주소값";
            // 
            // pathSaveBtn_1
            // 
            this.pathSaveBtn_1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathSaveBtn_1.Location = new System.Drawing.Point(78, 79);
            this.pathSaveBtn_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathSaveBtn_1.Name = "pathSaveBtn_1";
            this.pathSaveBtn_1.Size = new System.Drawing.Size(80, 33);
            this.pathSaveBtn_1.TabIndex = 19;
            this.pathSaveBtn_1.Text = "저장";
            this.pathSaveBtn_1.UseVisualStyleBackColor = true;
            this.pathSaveBtn_1.Click += new System.EventHandler(this.pathSaveBtn_1_Click);
            // 
            // camera2_add
            // 
            this.camera2_add.Location = new System.Drawing.Point(60, 50);
            this.camera2_add.Name = "camera2_add";
            this.camera2_add.Size = new System.Drawing.Size(265, 26);
            this.camera2_add.TabIndex = 5;
            // 
            // modeChg0
            // 
            this.modeChg0.Controls.Add(this.IOButton0);
            this.modeChg0.Controls.Add(this.chk_Ip0);
            this.modeChg0.Controls.Add(this.chk_wc0);
            this.modeChg0.Controls.Add(this.pathSaveBtn_0);
            this.modeChg0.Controls.Add(this.camera1_add);
            this.modeChg0.Controls.Add(this.label1);
            this.modeChg0.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeChg0.Location = new System.Drawing.Point(36, 104);
            this.modeChg0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg0.Name = "modeChg0";
            this.modeChg0.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg0.Size = new System.Drawing.Size(330, 108);
            this.modeChg0.TabIndex = 20;
            this.modeChg0.TabStop = false;
            this.modeChg0.Text = "화면 #1";
            // 
            // IOButton0
            // 
            this.IOButton0.Location = new System.Drawing.Point(184, 70);
            this.IOButton0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IOButton0.Name = "IOButton0";
            this.IOButton0.Size = new System.Drawing.Size(83, 33);
            this.IOButton0.TabIndex = 19;
            this.IOButton0.Text = "ON";
            this.IOButton0.UseVisualStyleBackColor = true;
            this.IOButton0.Click += new System.EventHandler(this.connect_btn0_Click);
            // 
            // chk_Ip0
            // 
            this.chk_Ip0.AutoSize = true;
            this.chk_Ip0.Location = new System.Drawing.Point(135, 20);
            this.chk_Ip0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Ip0.Name = "chk_Ip0";
            this.chk_Ip0.Size = new System.Drawing.Size(86, 23);
            this.chk_Ip0.TabIndex = 1;
            this.chk_Ip0.TabStop = true;
            this.chk_Ip0.Text = "IPCamera";
            this.chk_Ip0.UseVisualStyleBackColor = true;
            // 
            // chk_wc0
            // 
            this.chk_wc0.AutoSize = true;
            this.chk_wc0.Location = new System.Drawing.Point(8, 20);
            this.chk_wc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_wc0.Name = "chk_wc0";
            this.chk_wc0.Size = new System.Drawing.Size(83, 23);
            this.chk_wc0.TabIndex = 0;
            this.chk_wc0.TabStop = true;
            this.chk_wc0.Text = "WebCam";
            this.chk_wc0.UseVisualStyleBackColor = true;
            // 
            // pathSaveBtn_0
            // 
            this.pathSaveBtn_0.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathSaveBtn_0.Location = new System.Drawing.Point(83, 70);
            this.pathSaveBtn_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathSaveBtn_0.Name = "pathSaveBtn_0";
            this.pathSaveBtn_0.Size = new System.Drawing.Size(80, 33);
            this.pathSaveBtn_0.TabIndex = 18;
            this.pathSaveBtn_0.Text = "저장";
            this.pathSaveBtn_0.UseVisualStyleBackColor = true;
            this.pathSaveBtn_0.Click += new System.EventHandler(this.pathSaveBtn_0_Click);
            // 
            // camera1_add
            // 
            this.camera1_add.Location = new System.Drawing.Point(60, 43);
            this.camera1_add.Name = "camera1_add";
            this.camera1_add.Size = new System.Drawing.Size(265, 26);
            this.camera1_add.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "주소값";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(40, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "예) IP 카메라 : rtsp://192.168.0.137/profile2/media.smp\r\n      webcam : 0";
            // 
            // controlPanel1
            // 
            this.controlPanel1.ColumnCount = 2;
            this.controlPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.6817F));
            this.controlPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.3183F));
            this.controlPanel1.Controls.Add(this.screenSelect, 0, 0);
            this.controlPanel1.Controls.Add(this.ON_btn, 1, 0);
            this.controlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel1.Location = new System.Drawing.Point(3, 3);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.RowCount = 1;
            this.controlPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.controlPanel1.Size = new System.Drawing.Size(415, 73);
            this.controlPanel1.TabIndex = 14;
            this.controlPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // screenSelect
            // 
            this.screenSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.screenSelect.Controls.Add(this.screen0_select_btn);
            this.screenSelect.Controls.Add(this.screen1_select_btn);
            this.screenSelect.Controls.Add(this.screen2);
            this.screenSelect.Controls.Add(this.screen1);
            this.screenSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenSelect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenSelect.Location = new System.Drawing.Point(3, 3);
            this.screenSelect.Name = "screenSelect";
            this.screenSelect.Size = new System.Drawing.Size(295, 67);
            this.screenSelect.TabIndex = 12;
            this.screenSelect.TabStop = false;
            this.screenSelect.Text = "표시 화면";
            // 
            // screen2
            // 
            this.screen2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screen2.AutoSize = true;
            this.screen2.Location = new System.Drawing.Point(157, 28);
            this.screen2.Name = "screen2";
            this.screen2.Size = new System.Drawing.Size(47, 18);
            this.screen2.TabIndex = 6;
            this.screen2.Text = "화면 2";
            // 
            // screen1
            // 
            this.screen1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screen1.AutoSize = true;
            this.screen1.Location = new System.Drawing.Point(13, 28);
            this.screen1.Name = "screen1";
            this.screen1.Size = new System.Drawing.Size(47, 18);
            this.screen1.TabIndex = 5;
            this.screen1.Text = "화면 1";
            // 
            // ON_btn
            // 
            this.ON_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ON_btn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_power_off_button_32;
            this.ON_btn.Location = new System.Drawing.Point(304, 3);
            this.ON_btn.Name = "ON_btn";
            this.ON_btn.Size = new System.Drawing.Size(108, 67);
            this.ON_btn.TabIndex = 16;
            this.ON_btn.UseVisualStyleBackColor = true;
            this.ON_btn.Click += new System.EventHandler(this.ON_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1676, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램종료ToolStripMenuItem,
            this.만든사람들ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 프로그램종료ToolStripMenuItem
            // 
            this.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem";
            this.프로그램종료ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.프로그램종료ToolStripMenuItem.Text = "프로그램종료";
            this.프로그램종료ToolStripMenuItem.Click += new System.EventHandler(this.프로그램종료ToolStripMenuItem_Click);
            // 
            // 만든사람들ToolStripMenuItem
            // 
            this.만든사람들ToolStripMenuItem.Name = "만든사람들ToolStripMenuItem";
            this.만든사람들ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.만든사람들ToolStripMenuItem.Text = "만든사람들";
            this.만든사람들ToolStripMenuItem.Click += new System.EventHandler(this.만든사람들ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // screen1_select_btn
            // 
            this.screen1_select_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.screen1_select_btn.AutoSize = true;
            this.screen1_select_btn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.screen1_select_btn.Location = new System.Drawing.Point(210, 18);
            this.screen1_select_btn.Name = "screen1_select_btn";
            this.screen1_select_btn.Size = new System.Drawing.Size(38, 38);
            this.screen1_select_btn.TabIndex = 7;
            this.screen1_select_btn.UseVisualStyleBackColor = true;
            // 
            // screen0_select_btn
            // 
            this.screen0_select_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.screen0_select_btn.AutoSize = true;
            this.screen0_select_btn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.screen0_select_btn.Location = new System.Drawing.Point(84, 18);
            this.screen0_select_btn.Name = "screen0_select_btn";
            this.screen0_select_btn.Size = new System.Drawing.Size(38, 38);
            this.screen0_select_btn.TabIndex = 8;
            this.screen0_select_btn.UseVisualStyleBackColor = true;
            // 
            // elapsedTime
            // 
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTime.Location = new System.Drawing.Point(33, 22);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(70, 18);
            this.elapsedTime.TabIndex = 0;
            this.elapsedTime.Text = "00:00:00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.elapsedTime);
            this.groupBox3.Location = new System.Drawing.Point(257, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 48);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "경과 시간";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1676, 821);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1680, 830);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Conatus 방역관제CCTV시스템";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cctvPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.controlPanel0.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.modeChg1.ResumeLayout(false);
            this.modeChg1.PerformLayout();
            this.modeChg0.ResumeLayout(false);
            this.modeChg0.PerformLayout();
            this.controlPanel1.ResumeLayout(false);
            this.screenSelect.ResumeLayout(false);
            this.screenSelect.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox camera2_add;
        private System.Windows.Forms.TextBox camera1_add;
        private System.Windows.Forms.GroupBox screenSelect;
        private System.Windows.Forms.Label screen2;
        private System.Windows.Forms.Label screen1;
        private System.Windows.Forms.TableLayoutPanel controlPanel1;
        private System.Windows.Forms.Button ON_btn;
        private System.Windows.Forms.Label captureSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox screen2_cbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 만든사람들ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button pathSaveBtn_1;
        private System.Windows.Forms.Button pathSaveBtn_0;
        private System.Windows.Forms.GroupBox modeChg1;
        private System.Windows.Forms.RadioButton chk_Ip1;
        private System.Windows.Forms.RadioButton chk_wc1;
        private System.Windows.Forms.GroupBox modeChg0;
        private System.Windows.Forms.RadioButton chk_Ip0;
        private System.Windows.Forms.RadioButton chk_wc0;
        private System.Windows.Forms.Button IOButton1;
        private System.Windows.Forms.Button IOButton0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label elapsedTime;
        private System.Windows.Forms.CheckBox screen0_select_btn;
        private System.Windows.Forms.CheckBox screen1_select_btn;
    }
}

