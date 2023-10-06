namespace BiometricFingerprintAttendanceSystem
{
    partial class attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAttendance = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.drpDepartment = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtEmployeeName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtEmployeeNo = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnScan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.picFacial = new System.Windows.Forms.PictureBox();
            this.lblStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.progressImg = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.picCaptured = new System.Windows.Forms.PictureBox();
            this.btnCamera = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblEmp = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFacial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptured)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(30)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 56);
            this.panel1.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Kollektif", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(226, 29);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Employee Attendance";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel8.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel8.Location = new System.Drawing.Point(375, 231);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(164, 22);
            this.bunifuLabel8.TabIndex = 28;
            this.bunifuLabel8.Text = "Employee Department:";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel9.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel9.Location = new System.Drawing.Point(703, 162);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(121, 22);
            this.bunifuLabel9.TabIndex = 27;
            this.bunifuLabel9.Text = "Employee Name:";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.CursorType = null;
            this.bunifuLabel10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel10.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel10.Location = new System.Drawing.Point(375, 162);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(168, 22);
            this.bunifuLabel10.TabIndex = 26;
            this.bunifuLabel10.Text = "Employee no. Detected:";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnAttendance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttendance.BackgroundImage")));
            this.btnAttendance.ButtonText = "Confirm Attendance";
            this.btnAttendance.ButtonTextMarginLeft = 0;
            this.btnAttendance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAttendance.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAttendance.DisabledForecolor = System.Drawing.Color.White;
            this.btnAttendance.Enabled = false;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAttendance.IconPadding = 10;
            this.btnAttendance.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAttendance.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(179)))), ((int)(((byte)(84)))));
            this.btnAttendance.IdleBorderRadius = 15;
            this.btnAttendance.IdleBorderThickness = 0;
            this.btnAttendance.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(179)))), ((int)(((byte)(84)))));
            this.btnAttendance.IdleIconLeftImage = null;
            this.btnAttendance.IdleIconRightImage = null;
            this.btnAttendance.Location = new System.Drawing.Point(694, 250);
            this.btnAttendance.Name = "btnAttendance";
            stateProperties7.BorderColor = System.Drawing.Color.DimGray;
            stateProperties7.BorderRadius = 15;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.DimGray;
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.btnAttendance.onHoverState = stateProperties7;
            this.btnAttendance.Size = new System.Drawing.Size(295, 41);
            this.btnAttendance.TabIndex = 25;
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // drpDepartment
            // 
            this.drpDepartment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drpDepartment.BorderRadius = 1;
            this.drpDepartment.Color = System.Drawing.Color.DimGray;
            this.drpDepartment.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drpDepartment.DisabledColor = System.Drawing.Color.Gray;
            this.drpDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drpDepartment.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.drpDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDepartment.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drpDepartment.FillDropDown = false;
            this.drpDepartment.FillIndicator = false;
            this.drpDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drpDepartment.FormattingEnabled = true;
            this.drpDepartment.Icon = null;
            this.drpDepartment.IndicatorColor = System.Drawing.Color.DimGray;
            this.drpDepartment.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpDepartment.ItemBackColor = System.Drawing.Color.White;
            this.drpDepartment.ItemBorderColor = System.Drawing.Color.White;
            this.drpDepartment.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drpDepartment.ItemHeight = 26;
            this.drpDepartment.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.drpDepartment.Location = new System.Drawing.Point(375, 259);
            this.drpDepartment.Name = "drpDepartment";
            this.drpDepartment.Size = new System.Drawing.Size(295, 32);
            this.drpDepartment.TabIndex = 24;
            this.drpDepartment.Text = "Select Employee Department";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.AcceptsReturn = false;
            this.txtEmployeeName.AcceptsTab = false;
            this.txtEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmployeeName.BackgroundImage")));
            this.txtEmployeeName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtEmployeeName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtEmployeeName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtEmployeeName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtEmployeeName.BorderRadius = 1;
            this.txtEmployeeName.BorderThickness = 2;
            this.txtEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmployeeName.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.DefaultText = "";
            this.txtEmployeeName.FillColor = System.Drawing.Color.White;
            this.txtEmployeeName.HideSelection = true;
            this.txtEmployeeName.IconLeft = null;
            this.txtEmployeeName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtEmployeeName.IconPadding = 10;
            this.txtEmployeeName.IconRight = null;
            this.txtEmployeeName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtEmployeeName.Location = new System.Drawing.Point(694, 190);
            this.txtEmployeeName.MaxLength = 32767;
            this.txtEmployeeName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtEmployeeName.Modified = false;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.ReadOnly = false;
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.ShortcutsEnabled = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(295, 35);
            this.txtEmployeeName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtEmployeeName.TabIndex = 23;
            this.txtEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeName.TextMarginLeft = 5;
            this.txtEmployeeName.TextPlaceholder = "Enter Employee  Name";
            this.txtEmployeeName.UseSystemPasswordChar = false;
            // 
            // txtEmployeeNo
            // 
            this.txtEmployeeNo.AcceptsReturn = false;
            this.txtEmployeeNo.AcceptsTab = false;
            this.txtEmployeeNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmployeeNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmployeeNo.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmployeeNo.BackgroundImage")));
            this.txtEmployeeNo.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtEmployeeNo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtEmployeeNo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtEmployeeNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtEmployeeNo.BorderRadius = 1;
            this.txtEmployeeNo.BorderThickness = 2;
            this.txtEmployeeNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmployeeNo.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNo.DefaultText = "";
            this.txtEmployeeNo.FillColor = System.Drawing.Color.White;
            this.txtEmployeeNo.HideSelection = true;
            this.txtEmployeeNo.IconLeft = null;
            this.txtEmployeeNo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtEmployeeNo.IconPadding = 10;
            this.txtEmployeeNo.IconRight = null;
            this.txtEmployeeNo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtEmployeeNo.Location = new System.Drawing.Point(371, 190);
            this.txtEmployeeNo.MaxLength = 32767;
            this.txtEmployeeNo.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtEmployeeNo.Modified = false;
            this.txtEmployeeNo.Name = "txtEmployeeNo";
            this.txtEmployeeNo.PasswordChar = '\0';
            this.txtEmployeeNo.ReadOnly = true;
            this.txtEmployeeNo.SelectedText = "";
            this.txtEmployeeNo.SelectionLength = 0;
            this.txtEmployeeNo.SelectionStart = 0;
            this.txtEmployeeNo.ShortcutsEnabled = true;
            this.txtEmployeeNo.Size = new System.Drawing.Size(295, 35);
            this.txtEmployeeNo.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtEmployeeNo.TabIndex = 22;
            this.txtEmployeeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeNo.TextMarginLeft = 5;
            this.txtEmployeeNo.TextPlaceholder = "Enter Employee no.";
            this.txtEmployeeNo.UseSystemPasswordChar = false;
            this.txtEmployeeNo.Visible = false;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Transparent;
            this.btnScan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScan.BackgroundImage")));
            this.btnScan.ButtonText = "Detect Face";
            this.btnScan.ButtonTextMarginLeft = 0;
            this.btnScan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnScan.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnScan.DisabledForecolor = System.Drawing.Color.White;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnScan.IconPadding = 10;
            this.btnScan.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnScan.IdleBorderColor = System.Drawing.Color.Fuchsia;
            this.btnScan.IdleBorderRadius = 35;
            this.btnScan.IdleBorderThickness = 0;
            this.btnScan.IdleFillColor = System.Drawing.Color.Fuchsia;
            this.btnScan.IdleIconLeftImage = null;
            this.btnScan.IdleIconRightImage = null;
            this.btnScan.Location = new System.Drawing.Point(206, 290);
            this.btnScan.Name = "btnScan";
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties8.BorderRadius = 35;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.btnScan.onHoverState = stateProperties8;
            this.btnScan.Size = new System.Drawing.Size(140, 38);
            this.btnScan.TabIndex = 21;
            this.btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // picFacial
            // 
            this.picFacial.Image = ((System.Drawing.Image)(resources.GetObject("picFacial.Image")));
            this.picFacial.Location = new System.Drawing.Point(46, 126);
            this.picFacial.Name = "picFacial";
            this.picFacial.Size = new System.Drawing.Size(140, 145);
            this.picFacial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFacial.TabIndex = 20;
            this.picFacial.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = false;
            this.lblStatus.CursorType = null;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Magenta;
            this.lblStatus.Location = new System.Drawing.Point(139, 531);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(47, 22);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblStatus.Visible = false;
            // 
            // progressImg
            // 
            this.progressImg.Animation = 0;
            this.progressImg.AnimationStep = 10;
            this.progressImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressImg.BackgroundImage")));
            this.progressImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.progressImg.BorderRadius = 5;
            this.progressImg.BorderThickness = 2;
            this.progressImg.Location = new System.Drawing.Point(45, 276);
            this.progressImg.MaximumValue = 100;
            this.progressImg.MinimumValue = 0;
            this.progressImg.Name = "progressImg";
            this.progressImg.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.progressImg.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.progressImg.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.progressImg.Size = new System.Drawing.Size(140, 10);
            this.progressImg.TabIndex = 29;
            this.progressImg.Value = 0;
            // 
            // picCaptured
            // 
            this.picCaptured.Image = ((System.Drawing.Image)(resources.GetObject("picCaptured.Image")));
            this.picCaptured.Location = new System.Drawing.Point(206, 126);
            this.picCaptured.Name = "picCaptured";
            this.picCaptured.Size = new System.Drawing.Size(140, 145);
            this.picCaptured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCaptured.TabIndex = 31;
            this.picCaptured.TabStop = false;
            // 
            // btnCamera
            // 
            this.btnCamera.BackColor = System.Drawing.Color.Transparent;
            this.btnCamera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCamera.BackgroundImage")));
            this.btnCamera.ButtonText = "Open Camera";
            this.btnCamera.ButtonTextMarginLeft = 0;
            this.btnCamera.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCamera.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnCamera.DisabledForecolor = System.Drawing.Color.White;
            this.btnCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamera.ForeColor = System.Drawing.Color.White;
            this.btnCamera.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCamera.IconPadding = 10;
            this.btnCamera.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCamera.IdleBorderColor = System.Drawing.Color.Black;
            this.btnCamera.IdleBorderRadius = 35;
            this.btnCamera.IdleBorderThickness = 0;
            this.btnCamera.IdleFillColor = System.Drawing.Color.Black;
            this.btnCamera.IdleIconLeftImage = null;
            this.btnCamera.IdleIconRightImage = null;
            this.btnCamera.Location = new System.Drawing.Point(46, 290);
            this.btnCamera.Name = "btnCamera";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties9.BorderRadius = 35;
            stateProperties9.BorderThickness = 1;
            stateProperties9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties9.IconLeftImage = null;
            stateProperties9.IconRightImage = null;
            this.btnCamera.onHoverState = stateProperties9;
            this.btnCamera.Size = new System.Drawing.Size(140, 38);
            this.btnCamera.TabIndex = 32;
            this.btnCamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoEllipsis = false;
            this.lblEmp.CursorType = null;
            this.lblEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEmp.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmp.Location = new System.Drawing.Point(549, 157);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmp.Size = new System.Drawing.Size(58, 27);
            this.lblEmp.TabIndex = 33;
            this.lblEmp.Text = "00000";
            this.lblEmp.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblEmp.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1011, 565);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.picCaptured);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressImg);
            this.Controls.Add(this.bunifuLabel8);
            this.Controls.Add(this.bunifuLabel9);
            this.Controls.Add(this.bunifuLabel10);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.drpDepartment);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeNo);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.picFacial);
            this.Controls.Add(this.panel1);
            this.Name = "attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark Attendance";
            this.Load += new System.EventHandler(this.attendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFacial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAttendance;
        private Bunifu.UI.WinForms.BunifuDropdown drpDepartment;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtEmployeeName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtEmployeeNo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnScan;
        private System.Windows.Forms.PictureBox picFacial;
        private Bunifu.UI.WinForms.BunifuLabel lblStatus;
        private Bunifu.UI.Winforms.BunifuProgressBar progressImg;
        private System.Windows.Forms.PictureBox picCaptured;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCamera;
        private Bunifu.UI.WinForms.BunifuLabel lblEmp;
    }
}