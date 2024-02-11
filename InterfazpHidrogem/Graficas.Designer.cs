namespace InterfazpHidrogem
{
    partial class frmGraficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraficas));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRegresar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmbGrado = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cmbEscala = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(94, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 346);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(157, 28);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(543, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.dgrmBarras_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AllowAnimations = true;
            this.btnRegresar.AllowMouseEffects = true;
            this.btnRegresar.AllowToggling = false;
            this.btnRegresar.AnimationSpeed = 200;
            this.btnRegresar.AutoGenerateColors = false;
            this.btnRegresar.AutoRoundBorders = false;
            this.btnRegresar.AutoSizeLeftIcon = true;
            this.btnRegresar.AutoSizeRightIcon = true;
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRegresar.ButtonText = "Regresar";
            this.btnRegresar.ButtonTextMarginLeft = 0;
            this.btnRegresar.ColorContrastOnClick = 45;
            this.btnRegresar.ColorContrastOnHover = 45;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRegresar.CustomizableEdges = borderEdges1;
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegresar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegresar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegresar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegresar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnRegresar.Font = new System.Drawing.Font("Dunkin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegresar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegresar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRegresar.IconMarginLeft = 11;
            this.btnRegresar.IconPadding = 10;
            this.btnRegresar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegresar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegresar.IconSize = 25;
            this.btnRegresar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresar.IdleBorderRadius = 20;
            this.btnRegresar.IdleBorderThickness = 1;
            this.btnRegresar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresar.IdleIconLeftImage = null;
            this.btnRegresar.IdleIconRightImage = null;
            this.btnRegresar.IndicateFocus = false;
            this.btnRegresar.Location = new System.Drawing.Point(899, 505);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegresar.OnDisabledState.BorderRadius = 20;
            this.btnRegresar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRegresar.OnDisabledState.BorderThickness = 1;
            this.btnRegresar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegresar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegresar.OnDisabledState.IconLeftImage = null;
            this.btnRegresar.OnDisabledState.IconRightImage = null;
            this.btnRegresar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRegresar.onHoverState.BorderRadius = 20;
            this.btnRegresar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRegresar.onHoverState.BorderThickness = 1;
            this.btnRegresar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRegresar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.onHoverState.IconLeftImage = null;
            this.btnRegresar.onHoverState.IconRightImage = null;
            this.btnRegresar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresar.OnIdleState.BorderRadius = 20;
            this.btnRegresar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRegresar.OnIdleState.BorderThickness = 1;
            this.btnRegresar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresar.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegresar.OnIdleState.IconLeftImage = null;
            this.btnRegresar.OnIdleState.IconRightImage = null;
            this.btnRegresar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRegresar.OnPressedState.BorderRadius = 20;
            this.btnRegresar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRegresar.OnPressedState.BorderThickness = 1;
            this.btnRegresar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRegresar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.OnPressedState.IconLeftImage = null;
            this.btnRegresar.OnPressedState.IconRightImage = null;
            this.btnRegresar.Size = new System.Drawing.Size(150, 39);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegresar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegresar.TextMarginLeft = 0;
            this.btnRegresar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegresar.UseDefaultRadiusAndThickness = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Dunkin", 14.25F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Purple;
            this.bunifuLabel1.Location = new System.Drawing.Point(417, 21);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(143, 29);
            this.bunifuLabel1.TabIndex = 9;
            this.bunifuLabel1.Text = "Estadisticas";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmbGrado
            // 
            this.cmbGrado.BackColor = System.Drawing.Color.Transparent;
            this.cmbGrado.BackgroundColor = System.Drawing.Color.White;
            this.cmbGrado.BorderColor = System.Drawing.Color.Silver;
            this.cmbGrado.BorderRadius = 1;
            this.cmbGrado.Color = System.Drawing.Color.Silver;
            this.cmbGrado.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbGrado.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbGrado.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbGrado.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbGrado.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbGrado.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbGrado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGrado.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrado.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbGrado.FillDropDown = true;
            this.cmbGrado.FillIndicator = false;
            this.cmbGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGrado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbGrado.ForeColor = System.Drawing.Color.Black;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Icon = null;
            this.cmbGrado.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbGrado.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbGrado.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbGrado.IndicatorThickness = 2;
            this.cmbGrado.IsDropdownOpened = false;
            this.cmbGrado.ItemBackColor = System.Drawing.Color.White;
            this.cmbGrado.ItemBorderColor = System.Drawing.Color.White;
            this.cmbGrado.ItemForeColor = System.Drawing.Color.Black;
            this.cmbGrado.ItemHeight = 26;
            this.cmbGrado.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbGrado.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbGrado.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cmbGrado.ItemTopMargin = 3;
            this.cmbGrado.Location = new System.Drawing.Point(185, 91);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(260, 32);
            this.cmbGrado.TabIndex = 0;
            this.cmbGrado.Text = null;
            this.cmbGrado.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbGrado.TextLeftMargin = 5;
            // 
            // cmbEscala
            // 
            this.cmbEscala.BackColor = System.Drawing.Color.Transparent;
            this.cmbEscala.BackgroundColor = System.Drawing.Color.White;
            this.cmbEscala.BorderColor = System.Drawing.Color.Silver;
            this.cmbEscala.BorderRadius = 1;
            this.cmbEscala.Color = System.Drawing.Color.Silver;
            this.cmbEscala.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbEscala.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbEscala.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbEscala.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbEscala.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbEscala.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbEscala.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEscala.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbEscala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEscala.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbEscala.FillDropDown = true;
            this.cmbEscala.FillIndicator = false;
            this.cmbEscala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEscala.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbEscala.ForeColor = System.Drawing.Color.Black;
            this.cmbEscala.FormattingEnabled = true;
            this.cmbEscala.Icon = null;
            this.cmbEscala.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbEscala.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbEscala.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbEscala.IndicatorThickness = 2;
            this.cmbEscala.IsDropdownOpened = false;
            this.cmbEscala.ItemBackColor = System.Drawing.Color.White;
            this.cmbEscala.ItemBorderColor = System.Drawing.Color.White;
            this.cmbEscala.ItemForeColor = System.Drawing.Color.Black;
            this.cmbEscala.ItemHeight = 26;
            this.cmbEscala.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbEscala.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbEscala.Items.AddRange(new object[] {
            "Repollo",
            "Normal"});
            this.cmbEscala.ItemTopMargin = 3;
            this.cmbEscala.Location = new System.Drawing.Point(487, 91);
            this.cmbEscala.Name = "cmbEscala";
            this.cmbEscala.Size = new System.Drawing.Size(260, 32);
            this.cmbEscala.TabIndex = 1;
            this.cmbEscala.Text = null;
            this.cmbEscala.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbEscala.TextLeftMargin = 5;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Dunkin", 12F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Purple;
            this.bunifuLabel2.Location = new System.Drawing.Point(271, 60);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(63, 25);
            this.bunifuLabel2.TabIndex = 10;
            this.bunifuLabel2.Text = "Grado";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Dunkin", 12F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Purple;
            this.bunifuLabel4.Location = new System.Drawing.Point(588, 60);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(63, 25);
            this.bunifuLabel4.TabIndex = 12;
            this.bunifuLabel4.Text = "Escala";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = true;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.AnimationSpeed = 200;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = false;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.LimeGreen;
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.ButtonText = "Mostrar";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges2;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Dunkin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton21.IconMarginLeft = 11;
            this.bunifuButton21.IconPadding = 10;
            this.bunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton21.IconSize = 25;
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton21.IdleBorderRadius = 20;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.bunifuButton21.IdleIconLeftImage = null;
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(800, 84);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 20;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.BorderRadius = 20;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.IconLeftImage = null;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton21.OnIdleState.BorderRadius = 20;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.LimeGreen;
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuButton21.OnIdleState.IconLeftImage = null;
            this.bunifuButton21.OnIdleState.IconRightImage = null;
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.BorderRadius = 20;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.IconLeftImage = null;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton21.TabIndex = 13;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            this.bunifuButton21.Click += new System.EventHandler(this.btnMostrarGrafica);
            // 
            // frmGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1093, 556);
            this.Controls.Add(this.bunifuButton21);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.cmbEscala);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panel1);
            this.Name = "frmGraficas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficas";
            this.Load += new System.EventHandler(this.Graficas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnRegresar;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDropdown cmbGrado;
        private Bunifu.UI.WinForms.BunifuDropdown cmbEscala;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}