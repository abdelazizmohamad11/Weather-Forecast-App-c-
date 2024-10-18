namespace weather_forecast
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bnfcity = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labnet = new System.Windows.Forms.Label();
            this.btndetectloc = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(349, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "DO A SEARCH FOR WEATHER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::weather_forecast.Properties.Resources.icons8_search_26px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(532, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::weather_forecast.Properties.Resources.icons8_Close_26px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 37);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bnfcity
            // 
            this.bnfcity.AcceptsReturn = true;
            this.bnfcity.AcceptsTab = true;
            this.bnfcity.AnimationSpeed = 200;
            this.bnfcity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bnfcity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bnfcity.BackColor = System.Drawing.Color.DarkGray;
            this.bnfcity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfcity.BackgroundImage")));
            this.bnfcity.BorderColorActive = System.Drawing.Color.Transparent;
            this.bnfcity.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bnfcity.BorderColorHover = System.Drawing.Color.Transparent;
            this.bnfcity.BorderColorIdle = System.Drawing.Color.Transparent;
            this.bnfcity.BorderRadius = 1;
            this.bnfcity.BorderThickness = 1;
            this.bnfcity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bnfcity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfcity.DefaultFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfcity.DefaultText = "";
            this.bnfcity.FillColor = System.Drawing.Color.Gray;
            this.bnfcity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnfcity.HideSelection = true;
            this.bnfcity.IconLeft = null;
            this.bnfcity.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfcity.IconPadding = 10;
            this.bnfcity.IconRight = null;
            this.bnfcity.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfcity.Lines = new string[0];
            this.bnfcity.Location = new System.Drawing.Point(344, 200);
            this.bnfcity.MaxLength = 32767;
            this.bnfcity.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnfcity.Modified = false;
            this.bnfcity.Multiline = false;
            this.bnfcity.Name = "bnfcity";
            stateProperties1.BorderColor = System.Drawing.Color.Transparent;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bnfcity.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bnfcity.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Transparent;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bnfcity.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.Color.Gray;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bnfcity.OnIdleState = stateProperties4;
            this.bnfcity.Padding = new System.Windows.Forms.Padding(3);
            this.bnfcity.PasswordChar = '\0';
            this.bnfcity.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bnfcity.PlaceholderText = "search";
            this.bnfcity.ReadOnly = false;
            this.bnfcity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bnfcity.SelectedText = "";
            this.bnfcity.SelectionLength = 0;
            this.bnfcity.SelectionStart = 0;
            this.bnfcity.ShortcutsEnabled = true;
            this.bnfcity.Size = new System.Drawing.Size(191, 45);
            this.bnfcity.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bnfcity.TabIndex = 8;
            this.bnfcity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnfcity.TextMarginBottom = 0;
            this.bnfcity.TextMarginLeft = 3;
            this.bnfcity.TextMarginTop = 0;
            this.bnfcity.TextPlaceholder = "search";
            this.bnfcity.UseSystemPasswordChar = false;
            this.bnfcity.WordWrap = true;
            this.bnfcity.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            this.bnfcity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bnfcity_KeyPress);
            this.bnfcity.Enter += new System.EventHandler(this.bnfcity_Enter);
            // 
            // labnet
            // 
            this.labnet.AutoSize = true;
            this.labnet.BackColor = System.Drawing.Color.Transparent;
            this.labnet.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labnet.Location = new System.Drawing.Point(193, 285);
            this.labnet.Name = "labnet";
            this.labnet.Size = new System.Drawing.Size(0, 22);
            this.labnet.TabIndex = 9;
            // 
            // btndetectloc
            // 
            this.btndetectloc.AllowAnimations = true;
            this.btndetectloc.AllowMouseEffects = true;
            this.btndetectloc.AllowToggling = false;
            this.btndetectloc.AnimationSpeed = 200;
            this.btndetectloc.AutoGenerateColors = false;
            this.btndetectloc.AutoRoundBorders = false;
            this.btndetectloc.AutoSizeLeftIcon = true;
            this.btndetectloc.AutoSizeRightIcon = true;
            this.btndetectloc.BackColor = System.Drawing.Color.Transparent;
            this.btndetectloc.BackColor1 = System.Drawing.Color.DimGray;
            this.btndetectloc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndetectloc.BackgroundImage")));
            this.btndetectloc.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btndetectloc.ButtonText = "Or Detect Nearest Location";
            this.btndetectloc.ButtonTextMarginLeft = 0;
            this.btndetectloc.ColorContrastOnClick = 45;
            this.btndetectloc.ColorContrastOnHover = 45;
            this.btndetectloc.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btndetectloc.CustomizableEdges = borderEdges1;
            this.btndetectloc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndetectloc.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btndetectloc.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btndetectloc.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btndetectloc.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btndetectloc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetectloc.ForeColor = System.Drawing.Color.White;
            this.btndetectloc.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndetectloc.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btndetectloc.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btndetectloc.IconMarginLeft = 11;
            this.btndetectloc.IconPadding = 10;
            this.btndetectloc.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndetectloc.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btndetectloc.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btndetectloc.IconSize = 25;
            this.btndetectloc.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btndetectloc.IdleBorderRadius = 3;
            this.btndetectloc.IdleBorderThickness = 1;
            this.btndetectloc.IdleFillColor = System.Drawing.Color.DimGray;
            this.btndetectloc.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btndetectloc.IdleIconLeftImage")));
            this.btndetectloc.IdleIconRightImage = null;
            this.btndetectloc.IndicateFocus = false;
            this.btndetectloc.Location = new System.Drawing.Point(344, 272);
            this.btndetectloc.Name = "btndetectloc";
            this.btndetectloc.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.btndetectloc.OnDisabledState.BorderRadius = 3;
            this.btndetectloc.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btndetectloc.OnDisabledState.BorderThickness = 1;
            this.btndetectloc.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btndetectloc.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btndetectloc.OnDisabledState.IconLeftImage = null;
            this.btndetectloc.OnDisabledState.IconRightImage = null;
            this.btndetectloc.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btndetectloc.onHoverState.BorderRadius = 3;
            this.btndetectloc.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btndetectloc.onHoverState.BorderThickness = 1;
            this.btndetectloc.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btndetectloc.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btndetectloc.onHoverState.IconLeftImage = null;
            this.btndetectloc.onHoverState.IconRightImage = null;
            this.btndetectloc.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btndetectloc.OnIdleState.BorderRadius = 3;
            this.btndetectloc.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btndetectloc.OnIdleState.BorderThickness = 1;
            this.btndetectloc.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btndetectloc.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btndetectloc.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btndetectloc.OnIdleState.IconLeftImage")));
            this.btndetectloc.OnIdleState.IconRightImage = null;
            this.btndetectloc.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btndetectloc.OnPressedState.BorderRadius = 3;
            this.btndetectloc.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btndetectloc.OnPressedState.BorderThickness = 1;
            this.btndetectloc.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btndetectloc.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btndetectloc.OnPressedState.IconLeftImage = null;
            this.btndetectloc.OnPressedState.IconRightImage = null;
            this.btndetectloc.Size = new System.Drawing.Size(283, 35);
            this.btndetectloc.TabIndex = 18;
            this.btndetectloc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndetectloc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btndetectloc.TextMarginLeft = 0;
            this.btndetectloc.TextPadding = new System.Windows.Forms.Padding(0);
            this.btndetectloc.UseDefaultRadiusAndThickness = true;
            this.btndetectloc.Click += new System.EventHandler(this.btndetectloc_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 562);
            this.Controls.Add(this.btndetectloc);
            this.Controls.Add(this.labnet);
            this.Controls.Add(this.bnfcity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.UI.WinForms.BunifuTextBox bnfcity;
        private System.Windows.Forms.Label labnet;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btndetectloc;
    }
}