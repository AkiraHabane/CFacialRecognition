namespace BiometricFingerprintAttendanceSystem
{
    partial class employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.btnCapture = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtEmployeeNo = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtEmployeeName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.drpDepartment = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.progressImg = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.lblStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.picCaptured = new System.Windows.Forms.PictureBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuProgressBar1 = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(734, 56);
            this.panel1.TabIndex = 0;
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
            this.bunifuLabel1.Size = new System.Drawing.Size(201, 29);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Add New Employee";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // picCamera
            // 
            this.picCamera.Image = ((System.Drawing.Image)(resources.GetObject("picCamera.Image")));
            this.picCamera.Location = new System.Drawing.Point(44, 171);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(140, 145);
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamera.TabIndex = 1;
            this.picCamera.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.Transparent;
            this.btnCapture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapture.BackgroundImage")));
            this.btnCapture.ButtonText = "Capture";
            this.btnCapture.ButtonTextMarginLeft = 0;
            this.btnCapture.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCapture.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnCapture.DisabledForecolor = System.Drawing.Color.White;
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCapture.IconPadding = 10;
            this.btnCapture.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCapture.IdleBorderColor = System.Drawing.Color.DimGray;
            this.btnCapture.IdleBorderRadius = 35;
            this.btnCapture.IdleBorderThickness = 0;
            this.btnCapture.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnCapture.IdleIconLeftImage = null;
            this.btnCapture.IdleIconRightImage = null;
            this.btnCapture.Location = new System.Drawing.Point(124, 342);
            this.btnCapture.Name = "btnCapture";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties3.BorderRadius = 35;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnCapture.onHoverState = stateProperties3;
            this.btnCapture.Size = new System.Drawing.Size(140, 40);
            this.btnCapture.TabIndex = 2;
            this.btnCapture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
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
            this.txtEmployeeNo.Location = new System.Drawing.Point(412, 156);
            this.txtEmployeeNo.MaxLength = 32767;
            this.txtEmployeeNo.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtEmployeeNo.Modified = false;
            this.txtEmployeeNo.Name = "txtEmployeeNo";
            this.txtEmployeeNo.PasswordChar = '\0';
            this.txtEmployeeNo.ReadOnly = false;
            this.txtEmployeeNo.SelectedText = "";
            this.txtEmployeeNo.SelectionLength = 0;
            this.txtEmployeeNo.SelectionStart = 0;
            this.txtEmployeeNo.ShortcutsEnabled = true;
            this.txtEmployeeNo.Size = new System.Drawing.Size(295, 35);
            this.txtEmployeeNo.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtEmployeeNo.TabIndex = 3;
            this.txtEmployeeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeNo.TextMarginLeft = 5;
            this.txtEmployeeNo.TextPlaceholder = "Enter Employee no.";
            this.txtEmployeeNo.UseSystemPasswordChar = false;
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
            this.txtEmployeeName.Location = new System.Drawing.Point(412, 234);
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
            this.txtEmployeeName.TabIndex = 4;
            this.txtEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeName.TextMarginLeft = 5;
            this.txtEmployeeName.TextPlaceholder = "Enter Employee  Name";
            this.txtEmployeeName.UseSystemPasswordChar = false;
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
            this.drpDepartment.Location = new System.Drawing.Point(412, 308);
            this.drpDepartment.Name = "drpDepartment";
            this.drpDepartment.Size = new System.Drawing.Size(295, 32);
            this.drpDepartment.TabIndex = 6;
            this.drpDepartment.Text = "Select Employee Department";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save Employee";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSave.DisabledForecolor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(179)))), ((int)(((byte)(84)))));
            this.btnSave.IdleBorderRadius = 15;
            this.btnSave.IdleBorderThickness = 0;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(179)))), ((int)(((byte)(84)))));
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.Location = new System.Drawing.Point(412, 361);
            this.btnSave.Name = "btnSave";
            stateProperties4.BorderColor = System.Drawing.Color.DimGray;
            stateProperties4.BorderRadius = 15;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.DimGray;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnSave.onHoverState = stateProperties4;
            this.btnSave.Size = new System.Drawing.Size(295, 41);
            this.btnSave.TabIndex = 7;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(412, 128);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(101, 22);
            this.bunifuLabel2.TabIndex = 8;
            this.bunifuLabel2.Text = "Employee no.:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(412, 209);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(121, 22);
            this.bunifuLabel3.TabIndex = 9;
            this.bunifuLabel3.Text = "Employee Name:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel4.Location = new System.Drawing.Point(412, 280);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(164, 22);
            this.bunifuLabel4.TabIndex = 10;
            this.bunifuLabel4.Text = "Employee Department:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // progressImg
            // 
            this.progressImg.Animation = 0;
            this.progressImg.AnimationStep = 10;
            this.progressImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressImg.BackgroundImage")));
            this.progressImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.progressImg.BorderRadius = 5;
            this.progressImg.BorderThickness = 2;
            this.progressImg.Location = new System.Drawing.Point(44, 316);
            this.progressImg.MaximumValue = 100;
            this.progressImg.MinimumValue = 0;
            this.progressImg.Name = "progressImg";
            this.progressImg.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.progressImg.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.progressImg.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.progressImg.Size = new System.Drawing.Size(140, 10);
            this.progressImg.TabIndex = 11;
            this.progressImg.Value = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = false;
            this.lblStatus.CursorType = null;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Magenta;
            this.lblStatus.Location = new System.Drawing.Point(166, 494);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(47, 22);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // picCaptured
            // 
            this.picCaptured.Image = ((System.Drawing.Image)(resources.GetObject("picCaptured.Image")));
            this.picCaptured.Location = new System.Drawing.Point(214, 171);
            this.picCaptured.Name = "picCaptured";
            this.picCaptured.Size = new System.Drawing.Size(140, 145);
            this.picCaptured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCaptured.TabIndex = 13;
            this.picCaptured.TabStop = false;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel5.Location = new System.Drawing.Point(90, 143);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(56, 22);
            this.bunifuLabel5.TabIndex = 14;
            this.bunifuLabel5.Text = "Camera";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bunifuLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel6.Location = new System.Drawing.Point(252, 143);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(67, 22);
            this.bunifuLabel6.TabIndex = 15;
            this.bunifuLabel6.Text = "Captured";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.Animation = 0;
            this.bunifuProgressBar1.AnimationStep = 10;
            this.bunifuProgressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBar1.BackgroundImage")));
            this.bunifuProgressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.BorderThickness = 2;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(214, 316);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.MinimumValue = 0;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.bunifuProgressBar1.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.bunifuProgressBar1.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(140, 10);
            this.bunifuProgressBar1.TabIndex = 16;
            this.bunifuProgressBar1.Value = 0;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(734, 528);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.picCaptured);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressImg);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.drpDepartment);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeNo);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox picCamera;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCapture;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtEmployeeNo;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtEmployeeName;
        private Bunifu.UI.WinForms.BunifuDropdown drpDepartment;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.Winforms.BunifuProgressBar progressImg;
        private Bunifu.UI.WinForms.BunifuLabel lblStatus;
        private System.Windows.Forms.PictureBox picCaptured;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.Winforms.BunifuProgressBar bunifuProgressBar1;
    }
}