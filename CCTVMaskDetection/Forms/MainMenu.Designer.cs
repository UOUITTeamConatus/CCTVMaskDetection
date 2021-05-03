
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
            this.camera1_consol = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.logclear_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.camera0_consol = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logwrite_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.controlPanel0 = new System.Windows.Forms.TableLayoutPanel();
            this.capture_record_box = new System.Windows.Forms.GroupBox();
            this.camera0_record = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.camera1_record = new System.Windows.Forms.CheckBox();
            this.record_select = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capture_cbtn = new System.Windows.Forms.CheckBox();
            this.stop_cbtn = new System.Windows.Forms.CheckBox();
            this.record_cbtn = new System.Windows.Forms.CheckBox();
            this.save_path_box = new System.Windows.Forms.GroupBox();
            this.path_btn = new System.Windows.Forms.Button();
            this.savePath = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.connect_delete = new System.Windows.Forms.Button();
            this.camera_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modeChg1 = new System.Windows.Forms.GroupBox();
            this.IOButton1 = new System.Windows.Forms.Button();
            this.chk_Ip1 = new System.Windows.Forms.RadioButton();
            this.chk_wc1 = new System.Windows.Forms.RadioButton();
            this.addrSaveBtn_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.camera1_addr = new System.Windows.Forms.TextBox();
            this.connect_check = new System.Windows.Forms.Button();
            this.modeChg0 = new System.Windows.Forms.GroupBox();
            this.IOButton0 = new System.Windows.Forms.Button();
            this.chk_Ip0 = new System.Windows.Forms.RadioButton();
            this.chk_wc0 = new System.Windows.Forms.RadioButton();
            this.addrSaveBtn_0 = new System.Windows.Forms.Button();
            this.camera0_addr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controlPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.screenSelect = new System.Windows.Forms.GroupBox();
            this.screen0_select_btn = new System.Windows.Forms.CheckBox();
            this.screen1_select_btn = new System.Windows.Forms.CheckBox();
            this.Power_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.만든사람들ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.capture_record_box.SuspendLayout();
            this.save_path_box.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.modeChg1.SuspendLayout();
            this.modeChg0.SuspendLayout();
            this.controlPanel1.SuspendLayout();
            this.screenSelect.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
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
            this.splitContainer1.Size = new System.Drawing.Size(1918, 1007);
            this.splitContainer1.SplitterDistance = 1429;
            this.splitContainer1.SplitterWidth = 5;
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
            this.cctvPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cctvPanel.Name = "cctvPanel";
            this.cctvPanel.RowCount = 2;
            this.cctvPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cctvPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cctvPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.cctvPanel.Size = new System.Drawing.Size(1429, 1007);
            this.cctvPanel.TabIndex = 0;
            // 
            // cctvMonitor0
            // 
            this.cctvMonitor0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cctvMonitor0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cctvMonitor0.Location = new System.Drawing.Point(3, 4);
            this.cctvMonitor0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cctvMonitor0.Name = "cctvMonitor0";
            this.cctvMonitor0.Size = new System.Drawing.Size(708, 495);
            this.cctvMonitor0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cctvMonitor0.TabIndex = 0;
            this.cctvMonitor0.TabStop = false;
            // 
            // cctvMonitor1
            // 
            this.cctvMonitor1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cctvMonitor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cctvMonitor1.Location = new System.Drawing.Point(717, 4);
            this.cctvMonitor1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cctvMonitor1.Name = "cctvMonitor1";
            this.cctvMonitor1.Size = new System.Drawing.Size(709, 495);
            this.cctvMonitor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cctvMonitor1.TabIndex = 1;
            this.cctvMonitor1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.camera1_consol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(717, 505);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 500);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // camera1_consol
            // 
            this.camera1_consol.BackColor = System.Drawing.SystemColors.InfoText;
            this.camera1_consol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera1_consol.ForeColor = System.Drawing.SystemColors.Window;
            this.camera1_consol.Location = new System.Drawing.Point(3, 2);
            this.camera1_consol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.camera1_consol.Multiline = true;
            this.camera1_consol.Name = "camera1_consol";
            this.camera1_consol.ReadOnly = true;
            this.camera1_consol.Size = new System.Drawing.Size(703, 396);
            this.camera1_consol.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.logclear_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 402);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 96);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(427, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "내보내기";
            this.button2.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.Controls.Add(this.camera0_consol, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 505);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(708, 500);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // camera0_consol
            // 
            this.camera0_consol.BackColor = System.Drawing.SystemColors.InfoText;
            this.camera0_consol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera0_consol.ForeColor = System.Drawing.SystemColors.Window;
            this.camera0_consol.Location = new System.Drawing.Point(3, 2);
            this.camera0_consol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.camera0_consol.Multiline = true;
            this.camera0_consol.Name = "camera0_consol";
            this.camera0_consol.ReadOnly = true;
            this.camera0_consol.Size = new System.Drawing.Size(702, 396);
            this.camera0_consol.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.logwrite_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 402);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 96);
            this.panel1.TabIndex = 1;
            // 
            // logwrite_btn
            // 
            this.logwrite_btn.AutoSize = true;
            this.logwrite_btn.Location = new System.Drawing.Point(437, 21);
            this.logwrite_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logwrite_btn.Name = "logwrite_btn";
            this.logwrite_btn.Size = new System.Drawing.Size(88, 41);
            this.logwrite_btn.TabIndex = 5;
            this.logwrite_btn.Text = "내보내기";
            this.logwrite_btn.UseVisualStyleBackColor = true;
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
            // controlPanel0
            // 
            this.controlPanel0.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.controlPanel0.ColumnCount = 1;
            this.controlPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel0.Controls.Add(this.capture_record_box, 0, 3);
            this.controlPanel0.Controls.Add(this.save_path_box, 0, 2);
            this.controlPanel0.Controls.Add(this.groupBox6, 0, 1);
            this.controlPanel0.Controls.Add(this.controlPanel1, 0, 0);
            this.controlPanel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel0.Location = new System.Drawing.Point(0, 0);
            this.controlPanel0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlPanel0.Name = "controlPanel0";
            this.controlPanel0.RowCount = 4;
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 644F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.controlPanel0.Size = new System.Drawing.Size(484, 1007);
            this.controlPanel0.TabIndex = 15;
            // 
            // capture_record_box
            // 
            this.capture_record_box.Controls.Add(this.camera0_record);
            this.capture_record_box.Controls.Add(this.label12);
            this.capture_record_box.Controls.Add(this.label11);
            this.capture_record_box.Controls.Add(this.camera1_record);
            this.capture_record_box.Controls.Add(this.record_select);
            this.capture_record_box.Controls.Add(this.label2);
            this.capture_record_box.Controls.Add(this.capture_cbtn);
            this.capture_record_box.Controls.Add(this.stop_cbtn);
            this.capture_record_box.Controls.Add(this.record_cbtn);
            this.capture_record_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capture_record_box.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.capture_record_box.Location = new System.Drawing.Point(3, 827);
            this.capture_record_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capture_record_box.Name = "capture_record_box";
            this.capture_record_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capture_record_box.Size = new System.Drawing.Size(478, 176);
            this.capture_record_box.TabIndex = 7;
            this.capture_record_box.TabStop = false;
            this.capture_record_box.Text = "캡쳐 및 녹화";
            // 
            // camera0_record
            // 
            this.camera0_record.Appearance = System.Windows.Forms.Appearance.Button;
            this.camera0_record.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.camera0_record.Location = new System.Drawing.Point(121, 43);
            this.camera0_record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera0_record.Name = "camera0_record";
            this.camera0_record.Size = new System.Drawing.Size(55, 55);
            this.camera0_record.TabIndex = 8;
            this.camera0_record.UseVisualStyleBackColor = true;
            this.camera0_record.CheckedChanged += new System.EventHandler(this.screen0_select_btn_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(269, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "화면 녹화";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(355, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "녹화 중지";
            // 
            // camera1_record
            // 
            this.camera1_record.Appearance = System.Windows.Forms.Appearance.Button;
            this.camera1_record.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.camera1_record.Location = new System.Drawing.Point(182, 43);
            this.camera1_record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera1_record.Name = "camera1_record";
            this.camera1_record.Size = new System.Drawing.Size(55, 55);
            this.camera1_record.TabIndex = 7;
            this.camera1_record.UseVisualStyleBackColor = true;
            this.camera1_record.CheckedChanged += new System.EventHandler(this.screen1_select_btn_CheckedChanged);
            // 
            // record_select
            // 
            this.record_select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.record_select.AutoSize = true;
            this.record_select.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.record_select.Location = new System.Drawing.Point(130, 113);
            this.record_select.Name = "record_select";
            this.record_select.Size = new System.Drawing.Size(107, 15);
            this.record_select.TabIndex = 6;
            this.record_select.Text = "녹화 화면 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "화면 캡쳐";
            // 
            // capture_cbtn
            // 
            this.capture_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.capture_cbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.capture_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_screenshot_32;
            this.capture_cbtn.Location = new System.Drawing.Point(21, 42);
            this.capture_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capture_cbtn.Name = "capture_cbtn";
            this.capture_cbtn.Size = new System.Drawing.Size(55, 55);
            this.capture_cbtn.TabIndex = 8;
            this.capture_cbtn.UseVisualStyleBackColor = true;
            // 
            // stop_cbtn
            // 
            this.stop_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.stop_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_stop_squared_32;
            this.stop_cbtn.Location = new System.Drawing.Point(358, 42);
            this.stop_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stop_cbtn.Name = "stop_cbtn";
            this.stop_cbtn.Size = new System.Drawing.Size(55, 55);
            this.stop_cbtn.TabIndex = 10;
            this.stop_cbtn.UseVisualStyleBackColor = true;
            this.stop_cbtn.CheckedChanged += new System.EventHandler(this.stop_cbtn_CheckedChanged);
            // 
            // record_cbtn
            // 
            this.record_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.record_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_record_30;
            this.record_cbtn.Location = new System.Drawing.Point(273, 42);
            this.record_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.record_cbtn.Name = "record_cbtn";
            this.record_cbtn.Size = new System.Drawing.Size(55, 55);
            this.record_cbtn.TabIndex = 9;
            this.record_cbtn.UseVisualStyleBackColor = true;
            // 
            // save_path_box
            // 
            this.save_path_box.BackColor = System.Drawing.SystemColors.Control;
            this.save_path_box.Controls.Add(this.path_btn);
            this.save_path_box.Controls.Add(this.savePath);
            this.save_path_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_path_box.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.save_path_box.Location = new System.Drawing.Point(3, 747);
            this.save_path_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_path_box.Name = "save_path_box";
            this.save_path_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_path_box.Size = new System.Drawing.Size(478, 72);
            this.save_path_box.TabIndex = 3;
            this.save_path_box.TabStop = false;
            this.save_path_box.Text = "저장 경로 설정";
            // 
            // path_btn
            // 
            this.path_btn.AutoSize = true;
            this.path_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.path_btn.Location = new System.Drawing.Point(331, 22);
            this.path_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path_btn.Name = "path_btn";
            this.path_btn.Size = new System.Drawing.Size(99, 41);
            this.path_btn.TabIndex = 2;
            this.path_btn.Text = "찾아보기..";
            this.path_btn.UseVisualStyleBackColor = true;
            this.path_btn.Click += new System.EventHandler(this.path_btn_Click);
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(21, 28);
            this.savePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(299, 25);
            this.savePath.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.connect_delete);
            this.groupBox6.Controls.Add(this.camera_list);
            this.groupBox6.Controls.Add(this.modeChg1);
            this.groupBox6.Controls.Add(this.connect_check);
            this.groupBox6.Controls.Add(this.modeChg0);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 103);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(478, 636);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "장치 연결";
            // 
            // connect_delete
            // 
            this.connect_delete.Location = new System.Drawing.Point(289, 189);
            this.connect_delete.Name = "connect_delete";
            this.connect_delete.Size = new System.Drawing.Size(124, 59);
            this.connect_delete.TabIndex = 24;
            this.connect_delete.Text = "장치 제거";
            this.connect_delete.UseVisualStyleBackColor = true;
            this.connect_delete.Click += new System.EventHandler(this.connect_delete_Click);
            // 
            // camera_list
            // 
            this.camera_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.camera_list.HideSelection = false;
            this.camera_list.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.camera_list.Location = new System.Drawing.Point(10, 31);
            this.camera_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera_list.Name = "camera_list";
            this.camera_list.Size = new System.Drawing.Size(454, 135);
            this.camera_list.TabIndex = 22;
            this.camera_list.UseCompatibleStateImageBehavior = false;
            this.camera_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "스트림 주소";
            this.columnHeader1.Width = 264;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "연결 상태 ";
            this.columnHeader2.Width = 154;
            // 
            // modeChg1
            // 
            this.modeChg1.Controls.Add(this.IOButton1);
            this.modeChg1.Controls.Add(this.chk_Ip1);
            this.modeChg1.Controls.Add(this.chk_wc1);
            this.modeChg1.Controls.Add(this.addrSaveBtn_1);
            this.modeChg1.Controls.Add(this.label3);
            this.modeChg1.Controls.Add(this.camera1_addr);
            this.modeChg1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modeChg1.Location = new System.Drawing.Point(16, 447);
            this.modeChg1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg1.Name = "modeChg1";
            this.modeChg1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg1.Size = new System.Drawing.Size(448, 156);
            this.modeChg1.TabIndex = 21;
            this.modeChg1.TabStop = false;
            this.modeChg1.Text = "화면 #1";
            // 
            // IOButton1
            // 
            this.IOButton1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IOButton1.Location = new System.Drawing.Point(347, 95);
            this.IOButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IOButton1.Name = "IOButton1";
            this.IOButton1.Size = new System.Drawing.Size(66, 40);
            this.IOButton1.TabIndex = 20;
            this.IOButton1.Text = "on";
            this.IOButton1.UseVisualStyleBackColor = true;
            this.IOButton1.Click += new System.EventHandler(this.IOButton1_Click);
            // 
            // chk_Ip1
            // 
            this.chk_Ip1.AutoSize = true;
            this.chk_Ip1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_Ip1.Location = new System.Drawing.Point(154, 28);
            this.chk_Ip1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Ip1.Name = "chk_Ip1";
            this.chk_Ip1.Size = new System.Drawing.Size(90, 19);
            this.chk_Ip1.TabIndex = 2;
            this.chk_Ip1.TabStop = true;
            this.chk_Ip1.Text = "IPCamera";
            this.chk_Ip1.UseVisualStyleBackColor = true;
            // 
            // chk_wc1
            // 
            this.chk_wc1.AutoSize = true;
            this.chk_wc1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_wc1.Location = new System.Drawing.Point(9, 28);
            this.chk_wc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_wc1.Name = "chk_wc1";
            this.chk_wc1.Size = new System.Drawing.Size(87, 19);
            this.chk_wc1.TabIndex = 1;
            this.chk_wc1.TabStop = true;
            this.chk_wc1.Text = "WebCam";
            this.chk_wc1.UseVisualStyleBackColor = true;
            // 
            // addrSaveBtn_1
            // 
            this.addrSaveBtn_1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addrSaveBtn_1.Location = new System.Drawing.Point(346, 62);
            this.addrSaveBtn_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addrSaveBtn_1.Name = "addrSaveBtn_1";
            this.addrSaveBtn_1.Size = new System.Drawing.Size(67, 28);
            this.addrSaveBtn_1.TabIndex = 18;
            this.addrSaveBtn_1.Text = "추가";
            this.addrSaveBtn_1.UseVisualStyleBackColor = true;
            this.addrSaveBtn_1.Click += new System.EventHandler(this.addrSaveBtn_1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "주소값";
            // 
            // camera1_addr
            // 
            this.camera1_addr.Location = new System.Drawing.Point(69, 62);
            this.camera1_addr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera1_addr.Name = "camera1_addr";
            this.camera1_addr.Size = new System.Drawing.Size(269, 25);
            this.camera1_addr.TabIndex = 5;
            // 
            // connect_check
            // 
            this.connect_check.Location = new System.Drawing.Point(57, 189);
            this.connect_check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connect_check.Name = "connect_check";
            this.connect_check.Size = new System.Drawing.Size(126, 59);
            this.connect_check.TabIndex = 23;
            this.connect_check.Text = "카메라 연결";
            this.connect_check.UseVisualStyleBackColor = true;
            this.connect_check.Click += new System.EventHandler(this.connect_check_Click);
            // 
            // modeChg0
            // 
            this.modeChg0.Controls.Add(this.IOButton0);
            this.modeChg0.Controls.Add(this.chk_Ip0);
            this.modeChg0.Controls.Add(this.chk_wc0);
            this.modeChg0.Controls.Add(this.addrSaveBtn_0);
            this.modeChg0.Controls.Add(this.camera0_addr);
            this.modeChg0.Controls.Add(this.label1);
            this.modeChg0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modeChg0.Location = new System.Drawing.Point(15, 268);
            this.modeChg0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg0.Name = "modeChg0";
            this.modeChg0.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg0.Size = new System.Drawing.Size(449, 158);
            this.modeChg0.TabIndex = 20;
            this.modeChg0.TabStop = false;
            this.modeChg0.Text = "화면 #0";
            // 
            // IOButton0
            // 
            this.IOButton0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IOButton0.Location = new System.Drawing.Point(347, 86);
            this.IOButton0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IOButton0.Name = "IOButton0";
            this.IOButton0.Size = new System.Drawing.Size(66, 40);
            this.IOButton0.TabIndex = 19;
            this.IOButton0.Text = "on";
            this.IOButton0.UseVisualStyleBackColor = true;
            this.IOButton0.Click += new System.EventHandler(this.IOButton0_Click);
            // 
            // chk_Ip0
            // 
            this.chk_Ip0.AutoSize = true;
            this.chk_Ip0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_Ip0.Location = new System.Drawing.Point(154, 25);
            this.chk_Ip0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Ip0.Name = "chk_Ip0";
            this.chk_Ip0.Size = new System.Drawing.Size(90, 19);
            this.chk_Ip0.TabIndex = 1;
            this.chk_Ip0.TabStop = true;
            this.chk_Ip0.Text = "IPCamera";
            this.chk_Ip0.UseVisualStyleBackColor = true;
            // 
            // chk_wc0
            // 
            this.chk_wc0.AutoSize = true;
            this.chk_wc0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_wc0.Location = new System.Drawing.Point(9, 25);
            this.chk_wc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_wc0.Name = "chk_wc0";
            this.chk_wc0.Size = new System.Drawing.Size(87, 19);
            this.chk_wc0.TabIndex = 0;
            this.chk_wc0.TabStop = true;
            this.chk_wc0.Text = "WebCam";
            this.chk_wc0.UseVisualStyleBackColor = true;
            // 
            // addrSaveBtn_0
            // 
            this.addrSaveBtn_0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addrSaveBtn_0.Location = new System.Drawing.Point(346, 55);
            this.addrSaveBtn_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addrSaveBtn_0.Name = "addrSaveBtn_0";
            this.addrSaveBtn_0.Size = new System.Drawing.Size(67, 29);
            this.addrSaveBtn_0.TabIndex = 19;
            this.addrSaveBtn_0.Text = "추가";
            this.addrSaveBtn_0.UseVisualStyleBackColor = true;
            this.addrSaveBtn_0.Click += new System.EventHandler(this.addrSaveBtn_0_Click);
            // 
            // camera0_addr
            // 
            this.camera0_addr.Location = new System.Drawing.Point(64, 54);
            this.camera0_addr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera0_addr.Name = "camera0_addr";
            this.camera0_addr.Size = new System.Drawing.Size(274, 25);
            this.camera0_addr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "주소값";
            // 
            // controlPanel1
            // 
            this.controlPanel1.ColumnCount = 2;
            this.controlPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.6817F));
            this.controlPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.3183F));
            this.controlPanel1.Controls.Add(this.screenSelect, 0, 0);
            this.controlPanel1.Controls.Add(this.Power_btn, 1, 0);
            this.controlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel1.Location = new System.Drawing.Point(3, 4);
            this.controlPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.RowCount = 1;
            this.controlPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.controlPanel1.Size = new System.Drawing.Size(478, 91);
            this.controlPanel1.TabIndex = 14;
            // 
            // screenSelect
            // 
            this.screenSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.screenSelect.Controls.Add(this.screen0_select_btn);
            this.screenSelect.Controls.Add(this.screen1_select_btn);
            this.screenSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenSelect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.screenSelect.Location = new System.Drawing.Point(3, 4);
            this.screenSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.screenSelect.Name = "screenSelect";
            this.screenSelect.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.screenSelect.Size = new System.Drawing.Size(341, 83);
            this.screenSelect.TabIndex = 12;
            this.screenSelect.TabStop = false;
            this.screenSelect.Text = "표시 화면";
            // 
            // screen0_select_btn
            // 
            this.screen0_select_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.screen0_select_btn.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.screen0_select_btn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.screen0_select_btn.Location = new System.Drawing.Point(82, 13);
            this.screen0_select_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.screen0_select_btn.Name = "screen0_select_btn";
            this.screen0_select_btn.Size = new System.Drawing.Size(70, 70);
            this.screen0_select_btn.TabIndex = 8;
            this.screen0_select_btn.Text = "화면1";
            this.screen0_select_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.screen0_select_btn.UseVisualStyleBackColor = true;
            this.screen0_select_btn.CheckedChanged += new System.EventHandler(this.screen0_select_btn_CheckedChanged);
            // 
            // screen1_select_btn
            // 
            this.screen1_select_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.screen1_select_btn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.screen1_select_btn.Location = new System.Drawing.Point(210, 13);
            this.screen1_select_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.screen1_select_btn.Name = "screen1_select_btn";
            this.screen1_select_btn.Size = new System.Drawing.Size(70, 70);
            this.screen1_select_btn.TabIndex = 7;
            this.screen1_select_btn.Text = "화면2";
            this.screen1_select_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.screen1_select_btn.UseVisualStyleBackColor = true;
            this.screen1_select_btn.CheckedChanged += new System.EventHandler(this.screen1_select_btn_CheckedChanged);
            // 
            // Power_btn
            // 
            this.Power_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Power_btn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_power_off_button_32;
            this.Power_btn.Location = new System.Drawing.Point(350, 4);
            this.Power_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Power_btn.Name = "Power_btn";
            this.Power_btn.Size = new System.Drawing.Size(125, 83);
            this.Power_btn.TabIndex = 16;
            this.Power_btn.UseVisualStyleBackColor = true;
            this.Power_btn.Click += new System.EventHandler(this.Power_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1918, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램종료ToolStripMenuItem,
            this.만든사람들ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 프로그램종료ToolStripMenuItem
            // 
            this.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem";
            this.프로그램종료ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.프로그램종료ToolStripMenuItem.Text = "프로그램종료";
            this.프로그램종료ToolStripMenuItem.Click += new System.EventHandler(this.프로그램종료ToolStripMenuItem_Click);
            // 
            // 만든사람들ToolStripMenuItem
            // 
            this.만든사람들ToolStripMenuItem.Name = "만든사람들ToolStripMenuItem";
            this.만든사람들ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.만든사람들ToolStripMenuItem.Text = "만든사람들";
            this.만든사람들ToolStripMenuItem.Click += new System.EventHandler(this.만든사람들ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1918, 1035);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1916, 1025);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Conatus 방역관제CCTV시스템";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.capture_record_box.ResumeLayout(false);
            this.capture_record_box.PerformLayout();
            this.save_path_box.ResumeLayout(false);
            this.save_path_box.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.modeChg1.ResumeLayout(false);
            this.modeChg1.PerformLayout();
            this.modeChg0.ResumeLayout(false);
            this.modeChg0.PerformLayout();
            this.controlPanel1.ResumeLayout(false);
            this.screenSelect.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button logwrite_btn;
        private System.Windows.Forms.Button logclear_btn;
        private System.Windows.Forms.TableLayoutPanel cctvPanel;
        private System.Windows.Forms.PictureBox cctvMonitor1;
        private System.Windows.Forms.PictureBox cctvMonitor0;
        private System.Windows.Forms.TableLayoutPanel controlPanel0;
        private System.Windows.Forms.GroupBox capture_record_box;
        private System.Windows.Forms.CheckBox capture_cbtn;
        private System.Windows.Forms.CheckBox stop_cbtn;
        private System.Windows.Forms.CheckBox record_cbtn;
        private System.Windows.Forms.GroupBox save_path_box;
        private System.Windows.Forms.Button path_btn;
        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox camera1_addr;
        private System.Windows.Forms.TextBox camera0_addr;
        private System.Windows.Forms.GroupBox screenSelect;
        private System.Windows.Forms.TableLayoutPanel controlPanel1;
        private System.Windows.Forms.Button Power_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox camera1_consol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox camera0_consol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 만든사람들ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button addrSaveBtn_0;
        private System.Windows.Forms.Button addrSaveBtn_1;
        private System.Windows.Forms.GroupBox modeChg1;
        private System.Windows.Forms.RadioButton chk_Ip1;
        private System.Windows.Forms.RadioButton chk_wc1;
        private System.Windows.Forms.GroupBox modeChg0;
        private System.Windows.Forms.RadioButton chk_Ip0;
        private System.Windows.Forms.RadioButton chk_wc0;
        private System.Windows.Forms.Button IOButton0;
        private System.Windows.Forms.CheckBox screen0_select_btn;
        private System.Windows.Forms.CheckBox screen1_select_btn;
        private System.Windows.Forms.ListView camera_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button connect_check;
        private System.Windows.Forms.Button IOButton1;
        private System.Windows.Forms.Button connect_delete;
        private System.Windows.Forms.Label record_select;
        private System.Windows.Forms.CheckBox camera0_record;
        private System.Windows.Forms.CheckBox camera1_record;
    }
}

