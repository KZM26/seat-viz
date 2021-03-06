namespace SeatViz
{
    partial class FitNow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitNow));
            this.lblSeatFitment = new System.Windows.Forms.Label();
            this.btReturn = new System.Windows.Forms.Button();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblLenN = new System.Windows.Forms.Label();
            this.lblLen = new System.Windows.Forms.Label();
            this.lblWidthN = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnFreeze = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.tlpInfoAll = new System.Windows.Forms.TableLayoutPanel();
            this.tlpColourPressure = new System.Windows.Forms.TableLayoutPanel();
            this.lColour3 = new System.Windows.Forms.Label();
            this.lColour2 = new System.Windows.Forms.Label();
            this.pColour1 = new System.Windows.Forms.Panel();
            this.pColour2 = new System.Windows.Forms.Panel();
            this.pColour3 = new System.Windows.Forms.Panel();
            this.lColour1 = new System.Windows.Forms.Label();
            this.tlpUpper = new System.Windows.Forms.TableLayoutPanel();
            this.bt11 = new System.Windows.Forms.Button();
            this.bt10 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.tlpLower = new System.Windows.Forms.TableLayoutPanel();
            this.bt32 = new System.Windows.Forms.Button();
            this.bt31 = new System.Windows.Forms.Button();
            this.bt30 = new System.Windows.Forms.Button();
            this.bt29 = new System.Windows.Forms.Button();
            this.bt28 = new System.Windows.Forms.Button();
            this.bt27 = new System.Windows.Forms.Button();
            this.bt26 = new System.Windows.Forms.Button();
            this.bt25 = new System.Windows.Forms.Button();
            this.bt24 = new System.Windows.Forms.Button();
            this.bt23 = new System.Windows.Forms.Button();
            this.bt22 = new System.Windows.Forms.Button();
            this.bt21 = new System.Windows.Forms.Button();
            this.bt20 = new System.Windows.Forms.Button();
            this.bt19 = new System.Windows.Forms.Button();
            this.bt18 = new System.Windows.Forms.Button();
            this.bt17 = new System.Windows.Forms.Button();
            this.bt16 = new System.Windows.Forms.Button();
            this.bt15 = new System.Windows.Forms.Button();
            this.bt14 = new System.Windows.Forms.Button();
            this.bt13 = new System.Windows.Forms.Button();
            this.bt12 = new System.Windows.Forms.Button();
            this.tpnlCanvas = new SeatViz.TransparentPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tlpStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.pbCalibrate = new System.Windows.Forms.ProgressBar();
            this.tlpHeight = new System.Windows.Forms.TableLayoutPanel();
            this.cbHeight = new System.Windows.Forms.ComboBox();
            this.lblBC = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.tbCorrect = new System.Windows.Forms.TrackBar();
            this.tlpInfo.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpInfoAll.SuspendLayout();
            this.tlpColourPressure.SuspendLayout();
            this.tlpUpper.SuspendLayout();
            this.tlpLower.SuspendLayout();
            this.tlpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeatFitment
            // 
            this.lblSeatFitment.AutoSize = true;
            this.lblSeatFitment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatFitment.Location = new System.Drawing.Point(12, 12);
            this.lblSeatFitment.Name = "lblSeatFitment";
            this.lblSeatFitment.Size = new System.Drawing.Size(180, 33);
            this.lblSeatFitment.TabIndex = 1;
            this.lblSeatFitment.Text = "Seat Fitment";
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(1137, 12);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(201, 28);
            this.btReturn.TabIndex = 2;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // tlpInfo
            // 
            this.tlpInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpInfo.ColumnCount = 2;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Controls.Add(this.lblLenN, 1, 1);
            this.tlpInfo.Controls.Add(this.lblLen, 0, 1);
            this.tlpInfo.Controls.Add(this.lblWidthN, 1, 0);
            this.tlpInfo.Controls.Add(this.lblWidth, 0, 0);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(3, 300);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 3;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfo.Size = new System.Drawing.Size(281, 292);
            this.tlpInfo.TabIndex = 5;
            // 
            // lblLenN
            // 
            this.lblLenN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLenN.AutoSize = true;
            this.lblLenN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenN.Location = new System.Drawing.Point(168, 131);
            this.lblLenN.Name = "lblLenN";
            this.lblLenN.Size = new System.Drawing.Size(83, 29);
            this.lblLenN.TabIndex = 3;
            this.lblLenN.Text = "0.0 cm";
            // 
            // lblLen
            // 
            this.lblLen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLen.AutoSize = true;
            this.lblLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLen.Location = new System.Drawing.Point(28, 131);
            this.lblLen.Name = "lblLen";
            this.lblLen.Size = new System.Drawing.Size(86, 29);
            this.lblLen.TabIndex = 2;
            this.lblLen.Text = "Length";
            // 
            // lblWidthN
            // 
            this.lblWidthN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWidthN.AutoSize = true;
            this.lblWidthN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthN.Location = new System.Drawing.Point(168, 35);
            this.lblWidthN.Name = "lblWidthN";
            this.lblWidthN.Size = new System.Drawing.Size(83, 29);
            this.lblWidthN.TabIndex = 1;
            this.lblWidthN.Text = "0.0 cm";
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(34, 35);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(74, 29);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.BackColor = System.Drawing.Color.PeachPuff;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(64, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(213, 122);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnFreeze
            // 
            this.btnFreeze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFreeze.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFreeze.Enabled = false;
            this.btnFreeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreeze.Location = new System.Drawing.Point(64, 162);
            this.btnFreeze.Name = "btnFreeze";
            this.btnFreeze.Size = new System.Drawing.Size(213, 122);
            this.btnFreeze.TabIndex = 7;
            this.btnFreeze.Text = "Freeze";
            this.btnFreeze.UseVisualStyleBackColor = false;
            this.btnFreeze.Click += new System.EventHandler(this.btnFreeze_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(64, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(213, 122);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Controls.Add(this.btnConnect, 0, 0);
            this.tlpButtons.Controls.Add(this.btnSave, 0, 2);
            this.tlpButtons.Controls.Add(this.btnFreeze, 0, 1);
            this.tlpButtons.Controls.Add(this.btnCalibrate, 0, 3);
            this.tlpButtons.Location = new System.Drawing.Point(18, 74);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 4;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtons.Size = new System.Drawing.Size(341, 595);
            this.tlpButtons.TabIndex = 9;
            // 
            // btnCalibrate
            // 
            this.btnCalibrate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalibrate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalibrate.BackColor = System.Drawing.Color.Plum;
            this.btnCalibrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalibrate.Location = new System.Drawing.Point(64, 458);
            this.btnCalibrate.Name = "btnCalibrate";
            this.btnCalibrate.Size = new System.Drawing.Size(213, 122);
            this.btnCalibrate.TabIndex = 16;
            this.btnCalibrate.Text = "Calibrate";
            this.btnCalibrate.UseVisualStyleBackColor = false;
            this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click);
            // 
            // tlpInfoAll
            // 
            this.tlpInfoAll.ColumnCount = 1;
            this.tlpInfoAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfoAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInfoAll.Controls.Add(this.tlpInfo, 0, 1);
            this.tlpInfoAll.Controls.Add(this.tlpColourPressure, 0, 0);
            this.tlpInfoAll.Location = new System.Drawing.Point(1051, 74);
            this.tlpInfoAll.Name = "tlpInfoAll";
            this.tlpInfoAll.RowCount = 2;
            this.tlpInfoAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfoAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfoAll.Size = new System.Drawing.Size(287, 595);
            this.tlpInfoAll.TabIndex = 10;
            // 
            // tlpColourPressure
            // 
            this.tlpColourPressure.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpColourPressure.ColumnCount = 2;
            this.tlpColourPressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpColourPressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpColourPressure.Controls.Add(this.lColour3, 1, 2);
            this.tlpColourPressure.Controls.Add(this.lColour2, 1, 1);
            this.tlpColourPressure.Controls.Add(this.pColour1, 0, 0);
            this.tlpColourPressure.Controls.Add(this.pColour2, 0, 1);
            this.tlpColourPressure.Controls.Add(this.pColour3, 0, 2);
            this.tlpColourPressure.Controls.Add(this.lColour1, 1, 0);
            this.tlpColourPressure.Location = new System.Drawing.Point(3, 3);
            this.tlpColourPressure.Name = "tlpColourPressure";
            this.tlpColourPressure.RowCount = 3;
            this.tlpColourPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpColourPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpColourPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpColourPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpColourPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpColourPressure.Size = new System.Drawing.Size(281, 291);
            this.tlpColourPressure.TabIndex = 6;
            // 
            // lColour3
            // 
            this.lColour3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lColour3.AutoSize = true;
            this.lColour3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lColour3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lColour3.Location = new System.Drawing.Point(148, 212);
            this.lColour3.Margin = new System.Windows.Forms.Padding(0);
            this.lColour3.Name = "lColour3";
            this.lColour3.Size = new System.Drawing.Size(123, 58);
            this.lColour3.TabIndex = 7;
            this.lColour3.Text = "Below Threshold";
            // 
            // lColour2
            // 
            this.lColour2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lColour2.AutoSize = true;
            this.lColour2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lColour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lColour2.Location = new System.Drawing.Point(148, 130);
            this.lColour2.Margin = new System.Windows.Forms.Padding(0);
            this.lColour2.Name = "lColour2";
            this.lColour2.Size = new System.Drawing.Size(123, 29);
            this.lColour2.TabIndex = 6;
            this.lColour2.Text = "Threshold";
            // 
            // pColour1
            // 
            this.pColour1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pColour1.Location = new System.Drawing.Point(2, 2);
            this.pColour1.Margin = new System.Windows.Forms.Padding(0);
            this.pColour1.Name = "pColour1";
            this.pColour1.Size = new System.Drawing.Size(137, 94);
            this.pColour1.TabIndex = 0;
            // 
            // pColour2
            // 
            this.pColour2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pColour2.Location = new System.Drawing.Point(2, 98);
            this.pColour2.Margin = new System.Windows.Forms.Padding(0);
            this.pColour2.Name = "pColour2";
            this.pColour2.Size = new System.Drawing.Size(137, 94);
            this.pColour2.TabIndex = 1;
            // 
            // pColour3
            // 
            this.pColour3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pColour3.Location = new System.Drawing.Point(2, 194);
            this.pColour3.Margin = new System.Windows.Forms.Padding(0);
            this.pColour3.Name = "pColour3";
            this.pColour3.Size = new System.Drawing.Size(137, 95);
            this.pColour3.TabIndex = 2;
            // 
            // lColour1
            // 
            this.lColour1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lColour1.AutoSize = true;
            this.lColour1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lColour1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lColour1.Location = new System.Drawing.Point(148, 20);
            this.lColour1.Margin = new System.Windows.Forms.Padding(0);
            this.lColour1.Name = "lColour1";
            this.lColour1.Size = new System.Drawing.Size(123, 58);
            this.lColour1.TabIndex = 5;
            this.lColour1.Text = "Above Threshold";
            this.lColour1.Click += new System.EventHandler(this.lColour1_Click);
            // 
            // tlpUpper
            // 
            this.tlpUpper.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpUpper.ColumnCount = 2;
            this.tlpUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUpper.Controls.Add(this.bt11, 1, 5);
            this.tlpUpper.Controls.Add(this.bt10, 0, 5);
            this.tlpUpper.Controls.Add(this.bt9, 1, 4);
            this.tlpUpper.Controls.Add(this.bt8, 0, 4);
            this.tlpUpper.Controls.Add(this.bt7, 1, 3);
            this.tlpUpper.Controls.Add(this.bt6, 0, 3);
            this.tlpUpper.Controls.Add(this.bt5, 1, 2);
            this.tlpUpper.Controls.Add(this.bt4, 0, 2);
            this.tlpUpper.Controls.Add(this.bt3, 1, 1);
            this.tlpUpper.Controls.Add(this.bt2, 0, 1);
            this.tlpUpper.Controls.Add(this.bt1, 1, 0);
            this.tlpUpper.Controls.Add(this.bt0, 0, 0);
            this.tlpUpper.Location = new System.Drawing.Point(620, 77);
            this.tlpUpper.Name = "tlpUpper";
            this.tlpUpper.RowCount = 6;
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUpper.Size = new System.Drawing.Size(172, 294);
            this.tlpUpper.TabIndex = 11;
            // 
            // bt11
            // 
            this.bt11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt11.ForeColor = System.Drawing.Color.Transparent;
            this.bt11.Location = new System.Drawing.Point(108, 247);
            this.bt11.Name = "bt11";
            this.bt11.Size = new System.Drawing.Size(40, 40);
            this.bt11.TabIndex = 11;
            this.bt11.UseVisualStyleBackColor = true;
            // 
            // bt10
            // 
            this.bt10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt10.ForeColor = System.Drawing.Color.Transparent;
            this.bt10.Location = new System.Drawing.Point(23, 247);
            this.bt10.Name = "bt10";
            this.bt10.Size = new System.Drawing.Size(40, 40);
            this.bt10.TabIndex = 10;
            this.bt10.UseVisualStyleBackColor = true;
            // 
            // bt9
            // 
            this.bt9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt9.ForeColor = System.Drawing.Color.Transparent;
            this.bt9.Location = new System.Drawing.Point(108, 197);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(40, 40);
            this.bt9.TabIndex = 9;
            this.bt9.UseVisualStyleBackColor = true;
            // 
            // bt8
            // 
            this.bt8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt8.ForeColor = System.Drawing.Color.Transparent;
            this.bt8.Location = new System.Drawing.Point(23, 197);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(40, 40);
            this.bt8.TabIndex = 8;
            this.bt8.UseVisualStyleBackColor = true;
            // 
            // bt7
            // 
            this.bt7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt7.ForeColor = System.Drawing.Color.Transparent;
            this.bt7.Location = new System.Drawing.Point(108, 149);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(40, 40);
            this.bt7.TabIndex = 7;
            this.bt7.UseVisualStyleBackColor = true;
            // 
            // bt6
            // 
            this.bt6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt6.ForeColor = System.Drawing.Color.Transparent;
            this.bt6.Location = new System.Drawing.Point(23, 149);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(40, 40);
            this.bt6.TabIndex = 6;
            this.bt6.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt5.ForeColor = System.Drawing.Color.Transparent;
            this.bt5.Location = new System.Drawing.Point(108, 101);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(40, 40);
            this.bt5.TabIndex = 5;
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            this.bt4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt4.ForeColor = System.Drawing.Color.Transparent;
            this.bt4.Location = new System.Drawing.Point(23, 101);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(40, 40);
            this.bt4.TabIndex = 4;
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            this.bt3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt3.ForeColor = System.Drawing.Color.Transparent;
            this.bt3.Location = new System.Drawing.Point(108, 53);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(40, 40);
            this.bt3.TabIndex = 3;
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.bt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt2.ForeColor = System.Drawing.Color.Transparent;
            this.bt2.Location = new System.Drawing.Point(23, 53);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(40, 40);
            this.bt2.TabIndex = 2;
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // bt1
            // 
            this.bt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt1.ForeColor = System.Drawing.Color.Transparent;
            this.bt1.Location = new System.Drawing.Point(108, 5);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(40, 40);
            this.bt1.TabIndex = 1;
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // bt0
            // 
            this.bt0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt0.ForeColor = System.Drawing.Color.Transparent;
            this.bt0.Location = new System.Drawing.Point(23, 5);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(40, 40);
            this.bt0.TabIndex = 0;
            this.bt0.UseVisualStyleBackColor = true;
            // 
            // tlpLower
            // 
            this.tlpLower.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpLower.ColumnCount = 7;
            this.tlpLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpLower.Controls.Add(this.bt32, 6, 2);
            this.tlpLower.Controls.Add(this.bt31, 5, 2);
            this.tlpLower.Controls.Add(this.bt30, 4, 2);
            this.tlpLower.Controls.Add(this.bt29, 3, 2);
            this.tlpLower.Controls.Add(this.bt28, 2, 2);
            this.tlpLower.Controls.Add(this.bt27, 1, 2);
            this.tlpLower.Controls.Add(this.bt26, 0, 2);
            this.tlpLower.Controls.Add(this.bt25, 6, 1);
            this.tlpLower.Controls.Add(this.bt24, 5, 1);
            this.tlpLower.Controls.Add(this.bt23, 4, 1);
            this.tlpLower.Controls.Add(this.bt22, 3, 1);
            this.tlpLower.Controls.Add(this.bt21, 2, 1);
            this.tlpLower.Controls.Add(this.bt20, 1, 1);
            this.tlpLower.Controls.Add(this.bt19, 0, 1);
            this.tlpLower.Controls.Add(this.bt18, 6, 0);
            this.tlpLower.Controls.Add(this.bt17, 5, 0);
            this.tlpLower.Controls.Add(this.bt16, 4, 0);
            this.tlpLower.Controls.Add(this.bt15, 3, 0);
            this.tlpLower.Controls.Add(this.bt14, 2, 0);
            this.tlpLower.Controls.Add(this.bt13, 1, 0);
            this.tlpLower.Controls.Add(this.bt12, 0, 0);
            this.tlpLower.Location = new System.Drawing.Point(433, 370);
            this.tlpLower.Name = "tlpLower";
            this.tlpLower.RowCount = 3;
            this.tlpLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLower.Size = new System.Drawing.Size(554, 185);
            this.tlpLower.TabIndex = 12;
            // 
            // bt32
            // 
            this.bt32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt32.ForeColor = System.Drawing.Color.Transparent;
            this.bt32.Location = new System.Drawing.Point(491, 133);
            this.bt32.Name = "bt32";
            this.bt32.Size = new System.Drawing.Size(40, 40);
            this.bt32.TabIndex = 33;
            this.bt32.UseVisualStyleBackColor = true;
            // 
            // bt31
            // 
            this.bt31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt31.ForeColor = System.Drawing.Color.Transparent;
            this.bt31.Location = new System.Drawing.Point(410, 133);
            this.bt31.Name = "bt31";
            this.bt31.Size = new System.Drawing.Size(40, 40);
            this.bt31.TabIndex = 32;
            this.bt31.UseVisualStyleBackColor = true;
            // 
            // bt30
            // 
            this.bt30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt30.ForeColor = System.Drawing.Color.Transparent;
            this.bt30.Location = new System.Drawing.Point(332, 133);
            this.bt30.Name = "bt30";
            this.bt30.Size = new System.Drawing.Size(40, 40);
            this.bt30.TabIndex = 31;
            this.bt30.UseVisualStyleBackColor = true;
            // 
            // bt29
            // 
            this.bt29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt29.ForeColor = System.Drawing.Color.Transparent;
            this.bt29.Location = new System.Drawing.Point(254, 133);
            this.bt29.Name = "bt29";
            this.bt29.Size = new System.Drawing.Size(40, 40);
            this.bt29.TabIndex = 30;
            this.bt29.UseVisualStyleBackColor = true;
            // 
            // bt28
            // 
            this.bt28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt28.ForeColor = System.Drawing.Color.Transparent;
            this.bt28.Location = new System.Drawing.Point(176, 133);
            this.bt28.Name = "bt28";
            this.bt28.Size = new System.Drawing.Size(40, 40);
            this.bt28.TabIndex = 29;
            this.bt28.UseVisualStyleBackColor = true;
            // 
            // bt27
            // 
            this.bt27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt27.ForeColor = System.Drawing.Color.Transparent;
            this.bt27.Location = new System.Drawing.Point(98, 133);
            this.bt27.Name = "bt27";
            this.bt27.Size = new System.Drawing.Size(40, 40);
            this.bt27.TabIndex = 28;
            this.bt27.UseVisualStyleBackColor = true;
            // 
            // bt26
            // 
            this.bt26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt26.ForeColor = System.Drawing.Color.Transparent;
            this.bt26.Location = new System.Drawing.Point(20, 133);
            this.bt26.Name = "bt26";
            this.bt26.Size = new System.Drawing.Size(40, 40);
            this.bt26.TabIndex = 27;
            this.bt26.UseVisualStyleBackColor = true;
            // 
            // bt25
            // 
            this.bt25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt25.ForeColor = System.Drawing.Color.Transparent;
            this.bt25.Location = new System.Drawing.Point(491, 72);
            this.bt25.Name = "bt25";
            this.bt25.Size = new System.Drawing.Size(40, 40);
            this.bt25.TabIndex = 26;
            this.bt25.UseVisualStyleBackColor = true;
            // 
            // bt24
            // 
            this.bt24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt24.ForeColor = System.Drawing.Color.Transparent;
            this.bt24.Location = new System.Drawing.Point(410, 72);
            this.bt24.Name = "bt24";
            this.bt24.Size = new System.Drawing.Size(40, 40);
            this.bt24.TabIndex = 25;
            this.bt24.UseVisualStyleBackColor = true;
            // 
            // bt23
            // 
            this.bt23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt23.ForeColor = System.Drawing.Color.Transparent;
            this.bt23.Location = new System.Drawing.Point(332, 72);
            this.bt23.Name = "bt23";
            this.bt23.Size = new System.Drawing.Size(40, 40);
            this.bt23.TabIndex = 24;
            this.bt23.UseVisualStyleBackColor = true;
            // 
            // bt22
            // 
            this.bt22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt22.ForeColor = System.Drawing.Color.Transparent;
            this.bt22.Location = new System.Drawing.Point(254, 72);
            this.bt22.Name = "bt22";
            this.bt22.Size = new System.Drawing.Size(40, 40);
            this.bt22.TabIndex = 23;
            this.bt22.UseVisualStyleBackColor = true;
            // 
            // bt21
            // 
            this.bt21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt21.ForeColor = System.Drawing.Color.Transparent;
            this.bt21.Location = new System.Drawing.Point(176, 72);
            this.bt21.Name = "bt21";
            this.bt21.Size = new System.Drawing.Size(40, 40);
            this.bt21.TabIndex = 22;
            this.bt21.UseVisualStyleBackColor = true;
            // 
            // bt20
            // 
            this.bt20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt20.ForeColor = System.Drawing.Color.Transparent;
            this.bt20.Location = new System.Drawing.Point(98, 72);
            this.bt20.Name = "bt20";
            this.bt20.Size = new System.Drawing.Size(40, 40);
            this.bt20.TabIndex = 21;
            this.bt20.UseVisualStyleBackColor = true;
            // 
            // bt19
            // 
            this.bt19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt19.ForeColor = System.Drawing.Color.Transparent;
            this.bt19.Location = new System.Drawing.Point(20, 72);
            this.bt19.Name = "bt19";
            this.bt19.Size = new System.Drawing.Size(40, 40);
            this.bt19.TabIndex = 20;
            this.bt19.UseVisualStyleBackColor = true;
            // 
            // bt18
            // 
            this.bt18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt18.ForeColor = System.Drawing.Color.Transparent;
            this.bt18.Location = new System.Drawing.Point(491, 11);
            this.bt18.Name = "bt18";
            this.bt18.Size = new System.Drawing.Size(40, 40);
            this.bt18.TabIndex = 19;
            this.bt18.UseVisualStyleBackColor = true;
            // 
            // bt17
            // 
            this.bt17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt17.ForeColor = System.Drawing.Color.Transparent;
            this.bt17.Location = new System.Drawing.Point(410, 11);
            this.bt17.Name = "bt17";
            this.bt17.Size = new System.Drawing.Size(40, 40);
            this.bt17.TabIndex = 18;
            this.bt17.UseVisualStyleBackColor = true;
            // 
            // bt16
            // 
            this.bt16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt16.ForeColor = System.Drawing.Color.Transparent;
            this.bt16.Location = new System.Drawing.Point(332, 11);
            this.bt16.Name = "bt16";
            this.bt16.Size = new System.Drawing.Size(40, 40);
            this.bt16.TabIndex = 17;
            this.bt16.UseVisualStyleBackColor = true;
            // 
            // bt15
            // 
            this.bt15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt15.ForeColor = System.Drawing.Color.Transparent;
            this.bt15.Location = new System.Drawing.Point(254, 11);
            this.bt15.Name = "bt15";
            this.bt15.Size = new System.Drawing.Size(40, 40);
            this.bt15.TabIndex = 16;
            this.bt15.UseVisualStyleBackColor = true;
            // 
            // bt14
            // 
            this.bt14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt14.ForeColor = System.Drawing.Color.Transparent;
            this.bt14.Location = new System.Drawing.Point(176, 11);
            this.bt14.Name = "bt14";
            this.bt14.Size = new System.Drawing.Size(40, 40);
            this.bt14.TabIndex = 15;
            this.bt14.UseVisualStyleBackColor = true;
            // 
            // bt13
            // 
            this.bt13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt13.ForeColor = System.Drawing.Color.Transparent;
            this.bt13.Location = new System.Drawing.Point(98, 11);
            this.bt13.Name = "bt13";
            this.bt13.Size = new System.Drawing.Size(40, 40);
            this.bt13.TabIndex = 14;
            this.bt13.UseVisualStyleBackColor = true;
            // 
            // bt12
            // 
            this.bt12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt12.ForeColor = System.Drawing.Color.Transparent;
            this.bt12.Location = new System.Drawing.Point(20, 11);
            this.bt12.Name = "bt12";
            this.bt12.Size = new System.Drawing.Size(40, 40);
            this.bt12.TabIndex = 13;
            this.bt12.UseVisualStyleBackColor = true;
            // 
            // tpnlCanvas
            // 
            this.tpnlCanvas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tpnlCanvas.BackColor = System.Drawing.Color.Transparent;
            this.tpnlCanvas.Location = new System.Drawing.Point(433, 77);
            this.tpnlCanvas.Name = "tpnlCanvas";
            this.tpnlCanvas.Size = new System.Drawing.Size(554, 478);
            this.tpnlCanvas.TabIndex = 15;
            this.tpnlCanvas.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(10, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 33);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status";
            // 
            // tlpStatus
            // 
            this.tlpStatus.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpStatus.ColumnCount = 2;
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.93863F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.06137F));
            this.tlpStatus.Controls.Add(this.lblStatusText, 1, 0);
            this.tlpStatus.Controls.Add(this.lblStatus, 0, 0);
            this.tlpStatus.Location = new System.Drawing.Point(433, 12);
            this.tlpStatus.Name = "tlpStatus";
            this.tlpStatus.RowCount = 1;
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpStatus.Size = new System.Drawing.Size(554, 44);
            this.tlpStatus.TabIndex = 17;
            // 
            // lblStatusText
            // 
            this.lblStatusText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusText.Location = new System.Drawing.Point(335, 5);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(0, 33);
            this.lblStatusText.TabIndex = 17;
            // 
            // pbCalibrate
            // 
            this.pbCalibrate.Enabled = false;
            this.pbCalibrate.Location = new System.Drawing.Point(549, 53);
            this.pbCalibrate.Maximum = 66;
            this.pbCalibrate.Name = "pbCalibrate";
            this.pbCalibrate.Size = new System.Drawing.Size(438, 18);
            this.pbCalibrate.Step = 1;
            this.pbCalibrate.TabIndex = 18;
            this.pbCalibrate.Visible = false;
            // 
            // tlpHeight
            // 
            this.tlpHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHeight.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpHeight.ColumnCount = 7;
            this.tlpHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpHeight.Location = new System.Drawing.Point(433, 579);
            this.tlpHeight.Name = "tlpHeight";
            this.tlpHeight.RowCount = 10;
            this.tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeight.Size = new System.Drawing.Size(554, 83);
            this.tlpHeight.TabIndex = 19;
            this.tlpHeight.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpHeight_Paint);
            // 
            // cbHeight
            // 
            this.cbHeight.FormattingEnabled = true;
            this.cbHeight.Items.AddRange(new object[] {
            "R1",
            "R2",
            "R3"});
            this.cbHeight.Location = new System.Drawing.Point(1003, 579);
            this.cbHeight.Name = "cbHeight";
            this.cbHeight.Size = new System.Drawing.Size(31, 21);
            this.cbHeight.TabIndex = 21;
            this.cbHeight.Visible = false;
            this.cbHeight.SelectedIndexChanged += new System.EventHandler(this.cbHeight_SelectedIndexChanged);
            // 
            // lblBC
            // 
            this.lblBC.AutoSize = true;
            this.lblBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBC.Location = new System.Drawing.Point(365, 79);
            this.lblBC.Name = "lblBC";
            this.lblBC.Size = new System.Drawing.Size(70, 26);
            this.lblBC.TabIndex = 22;
            this.lblBC.Text = "label1";
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.Location = new System.Drawing.Point(365, 114);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(70, 26);
            this.lblVal.TabIndex = 23;
            this.lblVal.Text = "label1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(360, 150);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next Pin";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(360, 178);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 25;
            this.btnDebug.Text = "Pause Pin";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // tbCorrect
            // 
            this.tbCorrect.LargeChange = 2;
            this.tbCorrect.Location = new System.Drawing.Point(433, 555);
            this.tbCorrect.Maximum = 20;
            this.tbCorrect.Minimum = 1;
            this.tbCorrect.Name = "tbCorrect";
            this.tbCorrect.Size = new System.Drawing.Size(554, 45);
            this.tbCorrect.TabIndex = 26;
            this.tbCorrect.Value = 10;
            // 
            // FitNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.tbCorrect);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.lblBC);
            this.Controls.Add(this.cbHeight);
            this.Controls.Add(this.tlpHeight);
            this.Controls.Add(this.pbCalibrate);
            this.Controls.Add(this.tlpStatus);
            this.Controls.Add(this.tpnlCanvas);
            this.Controls.Add(this.tlpLower);
            this.Controls.Add(this.tlpUpper);
            this.Controls.Add(this.tlpInfoAll);
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.lblSeatFitment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FitNow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeatViz [Basic]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpInfoAll.ResumeLayout(false);
            this.tlpColourPressure.ResumeLayout(false);
            this.tlpColourPressure.PerformLayout();
            this.tlpUpper.ResumeLayout(false);
            this.tlpLower.ResumeLayout(false);
            this.tlpStatus.ResumeLayout(false);
            this.tlpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSeatFitment;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblLenN;
        private System.Windows.Forms.Label lblLen;
        private System.Windows.Forms.Label lblWidthN;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnFreeze;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.TableLayoutPanel tlpInfoAll;
        private System.Windows.Forms.TableLayoutPanel tlpUpper;
        private System.Windows.Forms.TableLayoutPanel tlpLower;
        private System.Windows.Forms.Button bt11;
        private System.Windows.Forms.Button bt10;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt32;
        private System.Windows.Forms.Button bt31;
        private System.Windows.Forms.Button bt30;
        private System.Windows.Forms.Button bt29;
        private System.Windows.Forms.Button bt28;
        private System.Windows.Forms.Button bt27;
        private System.Windows.Forms.Button bt26;
        private System.Windows.Forms.Button bt25;
        private System.Windows.Forms.Button bt24;
        private System.Windows.Forms.Button bt23;
        private System.Windows.Forms.Button bt22;
        private System.Windows.Forms.Button bt21;
        private System.Windows.Forms.Button bt20;
        private System.Windows.Forms.Button bt19;
        private System.Windows.Forms.Button bt18;
        private System.Windows.Forms.Button bt17;
        private System.Windows.Forms.Button bt16;
        private System.Windows.Forms.Button bt15;
        private System.Windows.Forms.Button bt14;
        private System.Windows.Forms.Button bt13;
        private System.Windows.Forms.Button bt12;
        private SeatViz.TransparentPanel tpnlCanvas;
        private System.Windows.Forms.TableLayoutPanel tlpColourPressure;
        private System.Windows.Forms.Panel pColour1;
        private System.Windows.Forms.Panel pColour2;
        private System.Windows.Forms.Panel pColour3;
        private System.Windows.Forms.Label lColour1;
        private System.Windows.Forms.Label lColour3;
        private System.Windows.Forms.Label lColour2;
        private System.Windows.Forms.Button btnCalibrate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TableLayoutPanel tlpStatus;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.ProgressBar pbCalibrate;
        private System.Windows.Forms.TableLayoutPanel tlpHeight;
        private System.Windows.Forms.ComboBox cbHeight;
        private System.Windows.Forms.Label lblBC;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.TrackBar tbCorrect;
    }
}