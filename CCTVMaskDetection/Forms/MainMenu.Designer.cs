
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.camera1_consol = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.camera0_consol = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.controlPanel0 = new System.Windows.Forms.TableLayoutPanel();
            this.capture_record_box = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.record_select = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_path_box = new System.Windows.Forms.GroupBox();
            this.savePath = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.list_reset_label = new System.Windows.Forms.Label();
            this.camera_connect_label = new System.Windows.Forms.Label();
            this.modeChg1 = new System.Windows.Forms.GroupBox();
            this.chk_Ip1 = new System.Windows.Forms.RadioButton();
            this.chk_wc1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.camera1_addr = new System.Windows.Forms.TextBox();
            this.modeChg0 = new System.Windows.Forms.GroupBox();
            this.chk_Ip0 = new System.Windows.Forms.RadioButton();
            this.chk_wc0 = new System.Windows.Forms.RadioButton();
            this.camera0_addr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.camera_list_group = new System.Windows.Forms.GroupBox();
            this.camera_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.만든사람들ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cctvMonitor0 = new System.Windows.Forms.PictureBox();
            this.cctvMonitor1 = new System.Windows.Forms.PictureBox();
            this.log1_save = new System.Windows.Forms.Button();
            this.log1_clear = new System.Windows.Forms.Button();
            this.log0_save = new System.Windows.Forms.Button();
            this.log0_clear = new System.Windows.Forms.Button();
            this.camera0_select = new System.Windows.Forms.CheckBox();
            this.camera1_select = new System.Windows.Forms.CheckBox();
            this.capture_cbtn = new System.Windows.Forms.CheckBox();
            this.stop_cbtn = new System.Windows.Forms.CheckBox();
            this.record_cbtn = new System.Windows.Forms.CheckBox();
            this.path_btn = new System.Windows.Forms.Button();
            this.backup = new System.Windows.Forms.Button();
            this.list_reset = new System.Windows.Forms.Button();
            this.IOButton1 = new System.Windows.Forms.Button();
            this.addrSaveBtn_1 = new System.Windows.Forms.Button();
            this.camera_connect = new System.Windows.Forms.Button();
            this.IOButton0 = new System.Windows.Forms.Button();
            this.addrSaveBtn_0 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cctvPanel.SuspendLayout();
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
            this.camera_list_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
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
            this.splitContainer1.Size = new System.Drawing.Size(1918, 999);
            this.splitContainer1.SplitterDistance = 1489;
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
            this.cctvPanel.Size = new System.Drawing.Size(1489, 999);
            this.cctvPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.camera1_consol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(747, 501);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.44355F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.55645F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 496);
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
            this.camera1_consol.Size = new System.Drawing.Size(733, 395);
            this.camera1_consol.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.log1_save);
            this.panel2.Controls.Add(this.log1_clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 401);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 93);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "clear";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "save";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.Controls.Add(this.camera0_consol, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 501);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.44355F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.55645F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(738, 496);
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
            this.camera0_consol.Size = new System.Drawing.Size(732, 395);
            this.camera0_consol.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.log0_save);
            this.panel1.Controls.Add(this.log0_clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 401);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 93);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Clear";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "save";
            // 
            // controlPanel0
            // 
            this.controlPanel0.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.controlPanel0.ColumnCount = 1;
            this.controlPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel0.Controls.Add(this.capture_record_box, 0, 3);
            this.controlPanel0.Controls.Add(this.save_path_box, 0, 2);
            this.controlPanel0.Controls.Add(this.groupBox6, 0, 1);
            this.controlPanel0.Controls.Add(this.camera_list_group, 0, 0);
            this.controlPanel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel0.Location = new System.Drawing.Point(0, 0);
            this.controlPanel0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlPanel0.Name = "controlPanel0";
            this.controlPanel0.RowCount = 4;
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 563F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.controlPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.controlPanel0.Size = new System.Drawing.Size(424, 999);
            this.controlPanel0.TabIndex = 15;
            // 
            // capture_record_box
            // 
            this.capture_record_box.Controls.Add(this.camera0_select);
            this.capture_record_box.Controls.Add(this.label12);
            this.capture_record_box.Controls.Add(this.label11);
            this.capture_record_box.Controls.Add(this.camera1_select);
            this.capture_record_box.Controls.Add(this.record_select);
            this.capture_record_box.Controls.Add(this.label2);
            this.capture_record_box.Controls.Add(this.capture_cbtn);
            this.capture_record_box.Controls.Add(this.stop_cbtn);
            this.capture_record_box.Controls.Add(this.record_cbtn);
            this.capture_record_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capture_record_box.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.capture_record_box.Location = new System.Drawing.Point(3, 840);
            this.capture_record_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capture_record_box.Name = "capture_record_box";
            this.capture_record_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capture_record_box.Size = new System.Drawing.Size(418, 155);
            this.capture_record_box.TabIndex = 7;
            this.capture_record_box.TabStop = false;
            this.capture_record_box.Text = "캡쳐 및 녹화";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(263, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "화면 녹화";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(329, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "녹화 중지";
            // 
            // record_select
            // 
            this.record_select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.record_select.AutoSize = true;
            this.record_select.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.record_select.Location = new System.Drawing.Point(55, 113);
            this.record_select.Name = "record_select";
            this.record_select.Size = new System.Drawing.Size(57, 12);
            this.record_select.TabIndex = 6;
            this.record_select.Text = "화면 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(179, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "화면 캡쳐";
            // 
            // save_path_box
            // 
            this.save_path_box.BackColor = System.Drawing.SystemColors.Control;
            this.save_path_box.Controls.Add(this.path_btn);
            this.save_path_box.Controls.Add(this.savePath);
            this.save_path_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_path_box.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.save_path_box.Location = new System.Drawing.Point(3, 753);
            this.save_path_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_path_box.Name = "save_path_box";
            this.save_path_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_path_box.Size = new System.Drawing.Size(418, 79);
            this.save_path_box.TabIndex = 3;
            this.save_path_box.TabStop = false;
            this.save_path_box.Text = "저장 경로 설정";
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(20, 34);
            this.savePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(281, 21);
            this.savePath.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.list_reset_label);
            this.groupBox6.Controls.Add(this.camera_connect_label);
            this.groupBox6.Controls.Add(this.backup);
            this.groupBox6.Controls.Add(this.list_reset);
            this.groupBox6.Controls.Add(this.modeChg1);
            this.groupBox6.Controls.Add(this.camera_connect);
            this.groupBox6.Controls.Add(this.modeChg0);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 190);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(418, 555);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "장치 추가 및 연결";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "백업 버튼";
            // 
            // list_reset_label
            // 
            this.list_reset_label.AutoSize = true;
            this.list_reset_label.Location = new System.Drawing.Point(153, 124);
            this.list_reset_label.Name = "list_reset_label";
            this.list_reset_label.Size = new System.Drawing.Size(111, 18);
            this.list_reset_label.TabIndex = 26;
            this.list_reset_label.Text = "장치 목록 초기화 ";
            // 
            // camera_connect_label
            // 
            this.camera_connect_label.AutoSize = true;
            this.camera_connect_label.Location = new System.Drawing.Point(35, 124);
            this.camera_connect_label.Name = "camera_connect_label";
            this.camera_connect_label.Size = new System.Drawing.Size(77, 18);
            this.camera_connect_label.TabIndex = 26;
            this.camera_connect_label.Text = "카메라 연결";
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
            this.modeChg1.Location = new System.Drawing.Point(3, 376);
            this.modeChg1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg1.Name = "modeChg1";
            this.modeChg1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg1.Size = new System.Drawing.Size(420, 173);
            this.modeChg1.TabIndex = 21;
            this.modeChg1.TabStop = false;
            this.modeChg1.Text = "화면 #1";
            // 
            // chk_Ip1
            // 
            this.chk_Ip1.AutoSize = true;
            this.chk_Ip1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_Ip1.Location = new System.Drawing.Point(301, 34);
            this.chk_Ip1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Ip1.Name = "chk_Ip1";
            this.chk_Ip1.Size = new System.Drawing.Size(79, 16);
            this.chk_Ip1.TabIndex = 2;
            this.chk_Ip1.TabStop = true;
            this.chk_Ip1.Text = "IPCamera";
            this.chk_Ip1.UseVisualStyleBackColor = true;
            // 
            // chk_wc1
            // 
            this.chk_wc1.AutoSize = true;
            this.chk_wc1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_wc1.Location = new System.Drawing.Point(199, 34);
            this.chk_wc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_wc1.Name = "chk_wc1";
            this.chk_wc1.Size = new System.Drawing.Size(74, 16);
            this.chk_wc1.TabIndex = 1;
            this.chk_wc1.TabStop = true;
            this.chk_wc1.Text = "WebCam";
            this.chk_wc1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "주소 입력";
            // 
            // camera1_addr
            // 
            this.camera1_addr.Location = new System.Drawing.Point(80, 56);
            this.camera1_addr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera1_addr.Name = "camera1_addr";
            this.camera1_addr.Size = new System.Drawing.Size(300, 21);
            this.camera1_addr.TabIndex = 5;
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
            this.modeChg0.Location = new System.Drawing.Point(3, 190);
            this.modeChg0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg0.Name = "modeChg0";
            this.modeChg0.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeChg0.Size = new System.Drawing.Size(420, 172);
            this.modeChg0.TabIndex = 20;
            this.modeChg0.TabStop = false;
            this.modeChg0.Text = "화면 #0";
            // 
            // chk_Ip0
            // 
            this.chk_Ip0.AutoSize = true;
            this.chk_Ip0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_Ip0.Location = new System.Drawing.Point(301, 31);
            this.chk_Ip0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Ip0.Name = "chk_Ip0";
            this.chk_Ip0.Size = new System.Drawing.Size(79, 16);
            this.chk_Ip0.TabIndex = 1;
            this.chk_Ip0.TabStop = true;
            this.chk_Ip0.Text = "IPCamera";
            this.chk_Ip0.UseVisualStyleBackColor = true;
            // 
            // chk_wc0
            // 
            this.chk_wc0.AutoSize = true;
            this.chk_wc0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_wc0.Location = new System.Drawing.Point(199, 31);
            this.chk_wc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_wc0.Name = "chk_wc0";
            this.chk_wc0.Size = new System.Drawing.Size(74, 16);
            this.chk_wc0.TabIndex = 0;
            this.chk_wc0.TabStop = true;
            this.chk_wc0.Text = "WebCam";
            this.chk_wc0.UseVisualStyleBackColor = true;
            // 
            // camera0_addr
            // 
            this.camera0_addr.Location = new System.Drawing.Point(80, 55);
            this.camera0_addr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera0_addr.Name = "camera0_addr";
            this.camera0_addr.Size = new System.Drawing.Size(300, 21);
            this.camera0_addr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "주소 입력";
            // 
            // camera_list_group
            // 
            this.camera_list_group.Controls.Add(this.camera_list);
            this.camera_list_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera_list_group.Location = new System.Drawing.Point(3, 3);
            this.camera_list_group.Name = "camera_list_group";
            this.camera_list_group.Size = new System.Drawing.Size(418, 180);
            this.camera_list_group.TabIndex = 14;
            this.camera_list_group.TabStop = false;
            this.camera_list_group.Text = "장치 목록";
            // 
            // camera_list
            // 
            this.camera_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.camera_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera_list.HideSelection = false;
            this.camera_list.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.camera_list.Location = new System.Drawing.Point(3, 21);
            this.camera_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera_list.Name = "camera_list";
            this.camera_list.Size = new System.Drawing.Size(412, 156);
            this.camera_list.TabIndex = 22;
            this.camera_list.UseCompatibleStateImageBehavior = false;
            this.camera_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "스트림 주소";
            this.columnHeader1.Width = 265;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "연결 상태 ";
            this.columnHeader2.Width = 88;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1918, 24);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cctvMonitor0
            // 
            this.cctvMonitor0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cctvMonitor0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cctvMonitor0.Location = new System.Drawing.Point(3, 4);
            this.cctvMonitor0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cctvMonitor0.Name = "cctvMonitor0";
            this.cctvMonitor0.Size = new System.Drawing.Size(738, 491);
            this.cctvMonitor0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cctvMonitor0.TabIndex = 0;
            this.cctvMonitor0.TabStop = false;
            // 
            // cctvMonitor1
            // 
            this.cctvMonitor1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cctvMonitor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cctvMonitor1.Location = new System.Drawing.Point(747, 4);
            this.cctvMonitor1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cctvMonitor1.Name = "cctvMonitor1";
            this.cctvMonitor1.Size = new System.Drawing.Size(739, 491);
            this.cctvMonitor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cctvMonitor1.TabIndex = 1;
            this.cctvMonitor1.TabStop = false;
            // 
            // log1_save
            // 
            this.log1_save.AutoSize = true;
            this.log1_save.Image = global::CCTVMaskDetection.Properties.Resources.icons8_save_48;
            this.log1_save.Location = new System.Drawing.Point(642, 6);
            this.log1_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log1_save.Name = "log1_save";
            this.log1_save.Size = new System.Drawing.Size(60, 60);
            this.log1_save.TabIndex = 6;
            this.log1_save.UseVisualStyleBackColor = true;
            this.log1_save.Click += new System.EventHandler(this.log1_save_Click);
            // 
            // log1_clear
            // 
            this.log1_clear.AutoSize = true;
            this.log1_clear.Image = global::CCTVMaskDetection.Properties.Resources.icons8_refresh_32;
            this.log1_clear.Location = new System.Drawing.Point(566, 6);
            this.log1_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log1_clear.Name = "log1_clear";
            this.log1_clear.Size = new System.Drawing.Size(60, 60);
            this.log1_clear.TabIndex = 6;
            this.log1_clear.UseVisualStyleBackColor = true;
            this.log1_clear.Click += new System.EventHandler(this.log1_clear_Click);
            // 
            // log0_save
            // 
            this.log0_save.AutoSize = true;
            this.log0_save.Image = global::CCTVMaskDetection.Properties.Resources.icons8_save_48;
            this.log0_save.Location = new System.Drawing.Point(646, 4);
            this.log0_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log0_save.Name = "log0_save";
            this.log0_save.Size = new System.Drawing.Size(60, 60);
            this.log0_save.TabIndex = 5;
            this.log0_save.UseVisualStyleBackColor = true;
            this.log0_save.Click += new System.EventHandler(this.log0_save_Click);
            // 
            // log0_clear
            // 
            this.log0_clear.AutoSize = true;
            this.log0_clear.Image = global::CCTVMaskDetection.Properties.Resources.icons8_refresh_32;
            this.log0_clear.Location = new System.Drawing.Point(569, 4);
            this.log0_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log0_clear.Name = "log0_clear";
            this.log0_clear.Size = new System.Drawing.Size(60, 60);
            this.log0_clear.TabIndex = 7;
            this.log0_clear.UseVisualStyleBackColor = true;
            this.log0_clear.Click += new System.EventHandler(this.log0_clear_Click);
            // 
            // camera0_select
            // 
            this.camera0_select.Appearance = System.Windows.Forms.Appearance.Button;
            this.camera0_select.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.camera0_select.Location = new System.Drawing.Point(20, 41);
            this.camera0_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera0_select.Name = "camera0_select";
            this.camera0_select.Size = new System.Drawing.Size(60, 60);
            this.camera0_select.TabIndex = 8;
            this.camera0_select.UseVisualStyleBackColor = true;
            // 
            // camera1_select
            // 
            this.camera1_select.Appearance = System.Windows.Forms.Appearance.Button;
            this.camera1_select.Image = global::CCTVMaskDetection.Properties.Resources.icons8_bullet_camera_32;
            this.camera1_select.Location = new System.Drawing.Point(85, 41);
            this.camera1_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera1_select.Name = "camera1_select";
            this.camera1_select.Size = new System.Drawing.Size(60, 60);
            this.camera1_select.TabIndex = 7;
            this.camera1_select.UseVisualStyleBackColor = true;
            // 
            // capture_cbtn
            // 
            this.capture_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.capture_cbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.capture_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_screenshot_32;
            this.capture_cbtn.Location = new System.Drawing.Point(176, 41);
            this.capture_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capture_cbtn.Name = "capture_cbtn";
            this.capture_cbtn.Size = new System.Drawing.Size(60, 60);
            this.capture_cbtn.TabIndex = 8;
            this.capture_cbtn.UseVisualStyleBackColor = true;
            // 
            // stop_cbtn
            // 
            this.stop_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.stop_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_stop_squared_32;
            this.stop_cbtn.Location = new System.Drawing.Point(326, 41);
            this.stop_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stop_cbtn.Name = "stop_cbtn";
            this.stop_cbtn.Size = new System.Drawing.Size(60, 60);
            this.stop_cbtn.TabIndex = 10;
            this.stop_cbtn.UseVisualStyleBackColor = true;
            this.stop_cbtn.CheckedChanged += new System.EventHandler(this.stop_cbtn_CheckedChanged);
            // 
            // record_cbtn
            // 
            this.record_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.record_cbtn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_record_30;
            this.record_cbtn.Location = new System.Drawing.Point(260, 41);
            this.record_cbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.record_cbtn.Name = "record_cbtn";
            this.record_cbtn.Size = new System.Drawing.Size(60, 60);
            this.record_cbtn.TabIndex = 9;
            this.record_cbtn.UseVisualStyleBackColor = true;
            // 
            // path_btn
            // 
            this.path_btn.AutoSize = true;
            this.path_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.path_btn.Image = global::CCTVMaskDetection.Properties.Resources.icons8_find_and_replace_26;
            this.path_btn.Location = new System.Drawing.Point(311, 22);
            this.path_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path_btn.Name = "path_btn";
            this.path_btn.Size = new System.Drawing.Size(75, 40);
            this.path_btn.TabIndex = 2;
            this.path_btn.UseVisualStyleBackColor = true;
            this.path_btn.Click += new System.EventHandler(this.path_btn_Click);
            // 
            // backup
            // 
            this.backup.Image = global::CCTVMaskDetection.Properties.Resources.icons8_database_backup_32;
            this.backup.Location = new System.Drawing.Point(292, 40);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(100, 80);
            this.backup.TabIndex = 25;
            this.backup.UseVisualStyleBackColor = true;
            // 
            // list_reset
            // 
            this.list_reset.Image = global::CCTVMaskDetection.Properties.Resources.icons8_refresh_32;
            this.list_reset.Location = new System.Drawing.Point(156, 40);
            this.list_reset.Name = "list_reset";
            this.list_reset.Size = new System.Drawing.Size(100, 80);
            this.list_reset.TabIndex = 24;
            this.list_reset.UseVisualStyleBackColor = true;
            this.list_reset.Click += new System.EventHandler(this.list_reset_Click);
            // 
            // IOButton1
            // 
            this.IOButton1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IOButton1.Image = global::CCTVMaskDetection.Properties.Resources.icons8_shutdown_48__2_;
            this.IOButton1.Location = new System.Drawing.Point(283, 83);
            this.IOButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IOButton1.Name = "IOButton1";
            this.IOButton1.Size = new System.Drawing.Size(100, 80);
            this.IOButton1.TabIndex = 20;
            this.IOButton1.UseVisualStyleBackColor = true;
            this.IOButton1.Click += new System.EventHandler(this.IOButton1_Click);
            // 
            // addrSaveBtn_1
            // 
            this.addrSaveBtn_1.AutoSize = true;
            this.addrSaveBtn_1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addrSaveBtn_1.Image = global::CCTVMaskDetection.Properties.Resources.icons8_add_32;
            this.addrSaveBtn_1.Location = new System.Drawing.Point(178, 83);
            this.addrSaveBtn_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addrSaveBtn_1.Name = "addrSaveBtn_1";
            this.addrSaveBtn_1.Size = new System.Drawing.Size(100, 80);
            this.addrSaveBtn_1.TabIndex = 18;
            this.addrSaveBtn_1.UseVisualStyleBackColor = true;
            this.addrSaveBtn_1.Click += new System.EventHandler(this.addrSaveBtn_1_Click);
            // 
            // camera_connect
            // 
            this.camera_connect.Image = global::CCTVMaskDetection.Properties.Resources.icons8_disconnected_32;
            this.camera_connect.Location = new System.Drawing.Point(23, 40);
            this.camera_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camera_connect.Name = "camera_connect";
            this.camera_connect.Size = new System.Drawing.Size(100, 80);
            this.camera_connect.TabIndex = 23;
            this.camera_connect.UseVisualStyleBackColor = true;
            this.camera_connect.Click += new System.EventHandler(this.camera_connect_Click);
            // 
            // IOButton0
            // 
            this.IOButton0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IOButton0.Image = global::CCTVMaskDetection.Properties.Resources.icons8_shutdown_48__2_;
            this.IOButton0.Location = new System.Drawing.Point(283, 82);
            this.IOButton0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IOButton0.Name = "IOButton0";
            this.IOButton0.Size = new System.Drawing.Size(100, 80);
            this.IOButton0.TabIndex = 19;
            this.IOButton0.UseVisualStyleBackColor = true;
            this.IOButton0.Click += new System.EventHandler(this.IOButton0_Click);
            // 
            // addrSaveBtn_0
            // 
            this.addrSaveBtn_0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addrSaveBtn_0.Image = global::CCTVMaskDetection.Properties.Resources.icons8_add_32;
            this.addrSaveBtn_0.Location = new System.Drawing.Point(178, 82);
            this.addrSaveBtn_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addrSaveBtn_0.Name = "addrSaveBtn_0";
            this.addrSaveBtn_0.Size = new System.Drawing.Size(100, 80);
            this.addrSaveBtn_0.TabIndex = 19;
            this.addrSaveBtn_0.UseVisualStyleBackColor = true;
            this.addrSaveBtn_0.Click += new System.EventHandler(this.addrSaveBtn_0_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1918, 1023);
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
            this.groupBox6.PerformLayout();
            this.modeChg1.ResumeLayout(false);
            this.modeChg1.PerformLayout();
            this.modeChg0.ResumeLayout(false);
            this.modeChg0.PerformLayout();
            this.camera_list_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctvMonitor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button log0_save;
        private System.Windows.Forms.Button log1_clear;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox camera1_consol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button log1_save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox camera0_consol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button log0_clear;
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
        private System.Windows.Forms.ListView camera_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button camera_connect;
        private System.Windows.Forms.Button IOButton1;
        private System.Windows.Forms.Button list_reset;
        private System.Windows.Forms.Label record_select;
        private System.Windows.Forms.CheckBox camera0_select;
        private System.Windows.Forms.CheckBox camera1_select;
        private System.Windows.Forms.Button backup;
        private System.Windows.Forms.GroupBox camera_list_group;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label list_reset_label;
        private System.Windows.Forms.Label camera_connect_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}

