
namespace gameOfLife
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fastModeButton = new MaterialSkin.Controls.MaterialSwitch();
            this.sizeTracker = new System.Windows.Forms.TrackBar();
            this.changeEnvBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.sizeTrackerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.envConfBox = new System.Windows.Forms.GroupBox();
            this.customRulesBTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.customRulesSTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.customRulesSLabel = new MaterialSkin.Controls.MaterialLabel();
            this.customRulesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.newGenButton = new MaterialSkin.Controls.MaterialButton();
            this.autoGenerationButton = new MaterialSkin.Controls.MaterialButton();
            this.autoGenerationTimer = new System.Windows.Forms.Timer(this.components);
            this.randomizeCellsButton = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.killCellsButton = new MaterialSkin.Controls.MaterialButton();
            this.recordingButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTracker)).BeginInit();
            this.envConfBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 502);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // fastModeButton
            // 
            this.fastModeButton.AutoSize = true;
            this.fastModeButton.BackColor = System.Drawing.Color.Transparent;
            this.fastModeButton.Depth = 0;
            this.fastModeButton.Location = new System.Drawing.Point(140, 192);
            this.fastModeButton.Margin = new System.Windows.Forms.Padding(0);
            this.fastModeButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fastModeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.fastModeButton.Name = "fastModeButton";
            this.fastModeButton.Ripple = true;
            this.fastModeButton.Size = new System.Drawing.Size(133, 37);
            this.fastModeButton.TabIndex = 1;
            this.fastModeButton.Text = "Fast mode";
            this.fastModeButton.UseVisualStyleBackColor = false;
            this.fastModeButton.CheckedChanged += new System.EventHandler(this.fastModeButton_CheckedChanged);
            // 
            // sizeTracker
            // 
            this.sizeTracker.LargeChange = 1;
            this.sizeTracker.Location = new System.Drawing.Point(125, 30);
            this.sizeTracker.Maximum = 20;
            this.sizeTracker.Minimum = 4;
            this.sizeTracker.Name = "sizeTracker";
            this.sizeTracker.Size = new System.Drawing.Size(240, 45);
            this.sizeTracker.TabIndex = 4;
            this.sizeTracker.TickFrequency = 5;
            this.sizeTracker.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sizeTracker.Value = 4;
            // 
            // changeEnvBtn
            // 
            this.changeEnvBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeEnvBtn.Depth = 0;
            this.changeEnvBtn.DrawShadows = true;
            this.changeEnvBtn.HighEmphasis = true;
            this.changeEnvBtn.Icon = null;
            this.changeEnvBtn.Location = new System.Drawing.Point(134, 202);
            this.changeEnvBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changeEnvBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.changeEnvBtn.Name = "changeEnvBtn";
            this.changeEnvBtn.Size = new System.Drawing.Size(187, 36);
            this.changeEnvBtn.TabIndex = 5;
            this.changeEnvBtn.Text = "Change environment";
            this.changeEnvBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.changeEnvBtn.UseAccentColor = false;
            this.changeEnvBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(20, 30);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(99, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Cell array size";
            // 
            // sizeTrackerLabel
            // 
            this.sizeTrackerLabel.AutoSize = true;
            this.sizeTrackerLabel.Depth = 0;
            this.sizeTrackerLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sizeTrackerLabel.Location = new System.Drawing.Point(371, 30);
            this.sizeTrackerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.sizeTrackerLabel.Name = "sizeTrackerLabel";
            this.sizeTrackerLabel.Size = new System.Drawing.Size(5, 19);
            this.sizeTrackerLabel.TabIndex = 7;
            this.sizeTrackerLabel.Text = " ";
            // 
            // envConfBox
            // 
            this.envConfBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.envConfBox.Controls.Add(this.customRulesBTextBox);
            this.envConfBox.Controls.Add(this.customRulesSTextBox);
            this.envConfBox.Controls.Add(this.materialLabel2);
            this.envConfBox.Controls.Add(this.customRulesSLabel);
            this.envConfBox.Controls.Add(this.customRulesLabel);
            this.envConfBox.Controls.Add(this.changeEnvBtn);
            this.envConfBox.Controls.Add(this.sizeTrackerLabel);
            this.envConfBox.Controls.Add(this.materialLabel1);
            this.envConfBox.Controls.Add(this.sizeTracker);
            this.envConfBox.Location = new System.Drawing.Point(674, 81);
            this.envConfBox.Name = "envConfBox";
            this.envConfBox.Size = new System.Drawing.Size(417, 247);
            this.envConfBox.TabIndex = 8;
            this.envConfBox.TabStop = false;
            this.envConfBox.Text = "Environment configuration";
            // 
            // customRulesBTextBox
            // 
            this.customRulesBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customRulesBTextBox.Depth = 0;
            this.customRulesBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customRulesBTextBox.Location = new System.Drawing.Point(221, 104);
            this.customRulesBTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.customRulesBTextBox.MaxLength = 5;
            this.customRulesBTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.customRulesBTextBox.Multiline = false;
            this.customRulesBTextBox.Name = "customRulesBTextBox";
            this.customRulesBTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.customRulesBTextBox.Size = new System.Drawing.Size(68, 50);
            this.customRulesBTextBox.TabIndex = 12;
            this.customRulesBTextBox.Text = "3";
            // 
            // customRulesSTextBox
            // 
            this.customRulesSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customRulesSTextBox.Depth = 0;
            this.customRulesSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customRulesSTextBox.Location = new System.Drawing.Point(134, 104);
            this.customRulesSTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.customRulesSTextBox.MaxLength = 5;
            this.customRulesSTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.customRulesSTextBox.Multiline = false;
            this.customRulesSTextBox.Name = "customRulesSTextBox";
            this.customRulesSTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.customRulesSTextBox.Size = new System.Drawing.Size(68, 50);
            this.customRulesSTextBox.TabIndex = 11;
            this.customRulesSTextBox.Text = "23";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(206, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(11, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "B";
            // 
            // customRulesSLabel
            // 
            this.customRulesSLabel.AutoSize = true;
            this.customRulesSLabel.Depth = 0;
            this.customRulesSLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customRulesSLabel.Location = new System.Drawing.Point(119, 118);
            this.customRulesSLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.customRulesSLabel.Name = "customRulesSLabel";
            this.customRulesSLabel.Size = new System.Drawing.Size(11, 19);
            this.customRulesSLabel.TabIndex = 9;
            this.customRulesSLabel.Text = "S";
            // 
            // customRulesLabel
            // 
            this.customRulesLabel.AutoSize = true;
            this.customRulesLabel.Depth = 0;
            this.customRulesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customRulesLabel.Location = new System.Drawing.Point(13, 118);
            this.customRulesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.customRulesLabel.Name = "customRulesLabel";
            this.customRulesLabel.Size = new System.Drawing.Size(94, 19);
            this.customRulesLabel.TabIndex = 8;
            this.customRulesLabel.Text = "Custom rules";
            // 
            // newGenButton
            // 
            this.newGenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newGenButton.Depth = 0;
            this.newGenButton.DrawShadows = true;
            this.newGenButton.HighEmphasis = true;
            this.newGenButton.Icon = null;
            this.newGenButton.Location = new System.Drawing.Point(122, 102);
            this.newGenButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newGenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.newGenButton.Name = "newGenButton";
            this.newGenButton.Size = new System.Drawing.Size(147, 36);
            this.newGenButton.TabIndex = 9;
            this.newGenButton.Text = "New generation";
            this.newGenButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.newGenButton.UseAccentColor = false;
            this.newGenButton.UseVisualStyleBackColor = true;
            this.newGenButton.Click += new System.EventHandler(this.newGenButton_Click);
            // 
            // autoGenerationButton
            // 
            this.autoGenerationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.autoGenerationButton.Depth = 0;
            this.autoGenerationButton.DrawShadows = true;
            this.autoGenerationButton.HighEmphasis = true;
            this.autoGenerationButton.Icon = null;
            this.autoGenerationButton.Location = new System.Drawing.Point(77, 150);
            this.autoGenerationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.autoGenerationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoGenerationButton.Name = "autoGenerationButton";
            this.autoGenerationButton.Size = new System.Drawing.Size(192, 36);
            this.autoGenerationButton.TabIndex = 10;
            this.autoGenerationButton.Text = "Auto generation [OFF]";
            this.autoGenerationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.autoGenerationButton.UseAccentColor = false;
            this.autoGenerationButton.UseVisualStyleBackColor = true;
            this.autoGenerationButton.Click += new System.EventHandler(this.autoGenerationButton_Click);
            // 
            // autoGenerationTimer
            // 
            this.autoGenerationTimer.Interval = 50;
            this.autoGenerationTimer.Tick += new System.EventHandler(this.autoGenerationTimer_Tick);
            // 
            // randomizeCellsButton
            // 
            this.randomizeCellsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.randomizeCellsButton.Depth = 0;
            this.randomizeCellsButton.DrawShadows = true;
            this.randomizeCellsButton.HighEmphasis = true;
            this.randomizeCellsButton.Icon = null;
            this.randomizeCellsButton.Location = new System.Drawing.Point(117, 6);
            this.randomizeCellsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.randomizeCellsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.randomizeCellsButton.Name = "randomizeCellsButton";
            this.randomizeCellsButton.Size = new System.Drawing.Size(152, 36);
            this.randomizeCellsButton.TabIndex = 11;
            this.randomizeCellsButton.Text = "Randomize cells";
            this.randomizeCellsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.randomizeCellsButton.UseAccentColor = false;
            this.randomizeCellsButton.UseVisualStyleBackColor = true;
            this.randomizeCellsButton.Click += new System.EventHandler(this.randomizeCellsButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.Controls.Add(this.randomizeCellsButton);
            this.flowLayoutPanel1.Controls.Add(this.killCellsButton);
            this.flowLayoutPanel1.Controls.Add(this.newGenButton);
            this.flowLayoutPanel1.Controls.Add(this.autoGenerationButton);
            this.flowLayoutPanel1.Controls.Add(this.fastModeButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(818, 334);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 249);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // killCellsButton
            // 
            this.killCellsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.killCellsButton.Depth = 0;
            this.killCellsButton.DrawShadows = true;
            this.killCellsButton.HighEmphasis = true;
            this.killCellsButton.Icon = null;
            this.killCellsButton.Location = new System.Drawing.Point(142, 54);
            this.killCellsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.killCellsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.killCellsButton.Name = "killCellsButton";
            this.killCellsButton.Size = new System.Drawing.Size(127, 36);
            this.killCellsButton.TabIndex = 13;
            this.killCellsButton.Text = "Kill all cells";
            this.killCellsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.killCellsButton.UseAccentColor = false;
            this.killCellsButton.UseVisualStyleBackColor = true;
            this.killCellsButton.Click += new System.EventHandler(this.killCellsButton_Click);
            // 
            // recordingButton
            // 
            this.recordingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recordingButton.Depth = 0;
            this.recordingButton.DrawShadows = true;
            this.recordingButton.HighEmphasis = true;
            this.recordingButton.Icon = null;
            this.recordingButton.Location = new System.Drawing.Point(521, 547);
            this.recordingButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.recordingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.recordingButton.Name = "recordingButton";
            this.recordingButton.Size = new System.Drawing.Size(58, 36);
            this.recordingButton.TabIndex = 13;
            this.recordingButton.Text = "Recording [OFF]";
            this.recordingButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.recordingButton.UseAccentColor = false;
            this.recordingButton.UseVisualStyleBackColor = true;
            this.recordingButton.Click += new System.EventHandler(this.recordingButton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1100, 649);
            this.Controls.Add(this.recordingButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.envConfBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(1100, 649);
            this.MinimumSize = new System.Drawing.Size(1000, 649);
            this.Name = "main";
            this.Text = "Game of Life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.sizeTracker)).EndInit();
            this.envConfBox.ResumeLayout(false);
            this.envConfBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSwitch fastModeButton;
        private System.Windows.Forms.TrackBar sizeTracker;
        private MaterialSkin.Controls.MaterialButton changeEnvBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel sizeTrackerLabel;
        private System.Windows.Forms.GroupBox envConfBox;
        private MaterialSkin.Controls.MaterialButton newGenButton;
        private MaterialSkin.Controls.MaterialButton autoGenerationButton;
        private System.Windows.Forms.Timer autoGenerationTimer;
        private MaterialSkin.Controls.MaterialButton randomizeCellsButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel customRulesLabel;
        private MaterialSkin.Controls.MaterialLabel customRulesSLabel;
        private MaterialSkin.Controls.MaterialTextBox customRulesSTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox customRulesBTextBox;
        private MaterialSkin.Controls.MaterialButton killCellsButton;
        private MaterialSkin.Controls.MaterialButton recordingButton;
    }
}

