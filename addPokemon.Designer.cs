namespace pokedex
{
    partial class addPokemon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.newNameBox = new CustomControls.RJControls.RJTextBox();
            this.newTypeLabel = new System.Windows.Forms.Label();
            this.newTypeBox = new CustomControls.RJControls.RJTextBox();
            this.newStats = new System.Windows.Forms.Label();
            this.newAttackLabel = new System.Windows.Forms.Label();
            this.newAttackBox = new CustomControls.RJControls.RJTextBox();
            this.newSpeedLabel = new System.Windows.Forms.Label();
            this.newSpeedBox = new CustomControls.RJControls.RJTextBox();
            this.newSpecialAttackLabel = new System.Windows.Forms.Label();
            this.newSpAttackBox = new CustomControls.RJControls.RJTextBox();
            this.newSpecialDefenseLabel = new System.Windows.Forms.Label();
            this.newSpDefBox = new CustomControls.RJControls.RJTextBox();
            this.newHpLabel = new System.Windows.Forms.Label();
            this.newHpBox = new CustomControls.RJControls.RJTextBox();
            this.newDefenseLabel = new System.Windows.Forms.Label();
            this.newDefBox = new CustomControls.RJControls.RJTextBox();
            this.createButton = new CustomControls.RJControls.RJButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.newNameBox);
            this.flowLayoutPanel1.Controls.Add(this.newTypeLabel);
            this.flowLayoutPanel1.Controls.Add(this.newTypeBox);
            this.flowLayoutPanel1.Controls.Add(this.newStats);
            this.flowLayoutPanel1.Controls.Add(this.newAttackLabel);
            this.flowLayoutPanel1.Controls.Add(this.newAttackBox);
            this.flowLayoutPanel1.Controls.Add(this.newSpeedLabel);
            this.flowLayoutPanel1.Controls.Add(this.newSpeedBox);
            this.flowLayoutPanel1.Controls.Add(this.newSpecialAttackLabel);
            this.flowLayoutPanel1.Controls.Add(this.newSpAttackBox);
            this.flowLayoutPanel1.Controls.Add(this.newSpecialDefenseLabel);
            this.flowLayoutPanel1.Controls.Add(this.newSpDefBox);
            this.flowLayoutPanel1.Controls.Add(this.newHpLabel);
            this.flowLayoutPanel1.Controls.Add(this.newHpBox);
            this.flowLayoutPanel1.Controls.Add(this.newDefenseLabel);
            this.flowLayoutPanel1.Controls.Add(this.newDefBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(427, 368);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNameLabel.ForeColor = System.Drawing.Color.White;
            this.newNameLabel.Location = new System.Drawing.Point(3, 0);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(70, 25);
            this.newNameLabel.TabIndex = 6;
            this.newNameLabel.Text = "Name:";
            // 
            // newNameBox
            // 
            this.newNameBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newNameBox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.newNameBox.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.newNameBox.BorderSize = 2;
            this.newNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNameBox.ForeColor = System.Drawing.Color.DimGray;
            this.newNameBox.Location = new System.Drawing.Point(80, 4);
            this.newNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.newNameBox.Multiline = false;
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Padding = new System.Windows.Forms.Padding(7);
            this.newNameBox.PasswordChar = false;
            this.newNameBox.Size = new System.Drawing.Size(126, 31);
            this.newNameBox.TabIndex = 0;
            this.newNameBox.Texts = "";
            this.newNameBox.UnderlinedStyle = false;
            this.newNameBox._TextChanged += new System.EventHandler(this.newNameBox__TextChanged);
            // 
            // newTypeLabel
            // 
            this.newTypeLabel.AutoSize = true;
            this.newTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTypeLabel.ForeColor = System.Drawing.Color.White;
            this.newTypeLabel.Location = new System.Drawing.Point(213, 0);
            this.newTypeLabel.Name = "newTypeLabel";
            this.newTypeLabel.Size = new System.Drawing.Size(63, 25);
            this.newTypeLabel.TabIndex = 7;
            this.newTypeLabel.Text = "Type:";
            // 
            // newTypeBox
            // 
            this.newTypeBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newTypeBox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.newTypeBox.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.newTypeBox.BorderSize = 2;
            this.newTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTypeBox.ForeColor = System.Drawing.Color.DimGray;
            this.newTypeBox.Location = new System.Drawing.Point(283, 4);
            this.newTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.newTypeBox.Multiline = false;
            this.newTypeBox.Name = "newTypeBox";
            this.newTypeBox.Padding = new System.Windows.Forms.Padding(7);
            this.newTypeBox.PasswordChar = false;
            this.newTypeBox.Size = new System.Drawing.Size(137, 31);
            this.newTypeBox.TabIndex = 1;
            this.newTypeBox.Texts = "";
            this.newTypeBox.UnderlinedStyle = false;
            this.newTypeBox._TextChanged += new System.EventHandler(this.newTypeBox__TextChanged);
            // 
            // newStats
            // 
            this.newStats.AutoSize = true;
            this.newStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStats.ForeColor = System.Drawing.Color.White;
            this.newStats.Location = new System.Drawing.Point(3, 39);
            this.newStats.Name = "newStats";
            this.newStats.Size = new System.Drawing.Size(393, 25);
            this.newStats.TabIndex = 8;
            this.newStats.Text = "Stats:                                                                  ";
            // 
            // newAttackLabel
            // 
            this.newAttackLabel.AutoSize = true;
            this.newAttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAttackLabel.ForeColor = System.Drawing.Color.White;
            this.newAttackLabel.Location = new System.Drawing.Point(3, 64);
            this.newAttackLabel.Name = "newAttackLabel";
            this.newAttackLabel.Size = new System.Drawing.Size(113, 25);
            this.newAttackLabel.TabIndex = 14;
            this.newAttackLabel.Text = "        Attack:";
            // 
            // newAttackBox
            // 
            this.newAttackBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newAttackBox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.newAttackBox.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.newAttackBox.BorderSize = 2;
            this.newAttackBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAttackBox.ForeColor = System.Drawing.Color.DimGray;
            this.newAttackBox.Location = new System.Drawing.Point(123, 68);
            this.newAttackBox.Margin = new System.Windows.Forms.Padding(4);
            this.newAttackBox.Multiline = false;
            this.newAttackBox.Name = "newAttackBox";
            this.newAttackBox.Padding = new System.Windows.Forms.Padding(7);
            this.newAttackBox.PasswordChar = false;
            this.newAttackBox.Size = new System.Drawing.Size(279, 31);
            this.newAttackBox.TabIndex = 2;
            this.newAttackBox.Texts = "";
            this.newAttackBox.UnderlinedStyle = false;
            this.newAttackBox._TextChanged += new System.EventHandler(this.newAttackBox__TextChanged);
            // 
            // newSpeedLabel
            // 
            this.newSpeedLabel.AutoSize = true;
            this.newSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.newSpeedLabel.Location = new System.Drawing.Point(3, 103);
            this.newSpeedLabel.Name = "newSpeedLabel";
            this.newSpeedLabel.Size = new System.Drawing.Size(116, 25);
            this.newSpeedLabel.TabIndex = 13;
            this.newSpeedLabel.Text = "        Speed:";
            // 
            // newSpeedBox
            // 
            this.newSpeedBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newSpeedBox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.newSpeedBox.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.newSpeedBox.BorderSize = 2;
            this.newSpeedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSpeedBox.ForeColor = System.Drawing.Color.DimGray;
            this.newSpeedBox.Location = new System.Drawing.Point(126, 107);
            this.newSpeedBox.Margin = new System.Windows.Forms.Padding(4);
            this.newSpeedBox.Multiline = false;
            this.newSpeedBox.Name = "newSpeedBox";
            this.newSpeedBox.Padding = new System.Windows.Forms.Padding(7);
            this.newSpeedBox.PasswordChar = false;
            this.newSpeedBox.Size = new System.Drawing.Size(276, 31);
            this.newSpeedBox.TabIndex = 3;
            this.newSpeedBox.Texts = "";
            this.newSpeedBox.UnderlinedStyle = false;
            this.newSpeedBox._TextChanged += new System.EventHandler(this.newSpeedBox__TextChanged);
            // 
            // newSpecialAttackLabel
            // 
            this.newSpecialAttackLabel.AutoSize = true;
            this.newSpecialAttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSpecialAttackLabel.ForeColor = System.Drawing.Color.White;
            this.newSpecialAttackLabel.Location = new System.Drawing.Point(3, 142);
            this.newSpecialAttackLabel.Name = "newSpecialAttackLabel";
            this.newSpecialAttackLabel.Size = new System.Drawing.Size(122, 25);
            this.newSpecialAttackLabel.TabIndex = 12;
            this.newSpecialAttackLabel.Text = "        Sp. Atk:";
            // 
            // newSpAttackBox
            // 
            this.newSpAttackBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newSpAttackBox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.newSpAttackBox.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.newSpAttackBox.BorderSize = 2;
            this.newSpAttackBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSpAttackBox.ForeColor = System.Drawing.Color.DimGray;
            this.newSpAttackBox.Location = new System.Drawing.Point(132, 146);
            this.newSpAttackBox.Margin = new System.Windows.Forms.Padding(4);
            this.newSpAttackBox.Multiline = false;
            this.newSpAttackBox.Name = "newSpAttackBox";
            this.newSpAttackBox.Padding = new System.Windows.Forms.Padding(7);
            this.newSpAttackBox.PasswordChar = false;
            this.newSpAttackBox.Size = new System.Drawing.Size(270, 31);
            this.newSpAttackBox.TabIndex = 4;
            this.newSpAttackBox.Texts = "";
            this.newSpAttackBox.UnderlinedStyle = false;
            this.newSpAttackBox._TextChanged += new System.EventHandler(this.newSpAttackBox__TextChanged);
            // 
            // newSpecialDefenseLabel
            // 
            this.newSpecialDefenseLabel.AutoSize = true;
            this.newSpecialDefenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSpecialDefenseLabel.ForeColor = System.Drawing.Color.White;
            this.newSpecialDefenseLabel.Location = new System.Drawing.Point(3, 181);
            this.newSpecialDefenseLabel.Name = "newSpecialDefenseLabel";
            this.newSpecialDefenseLabel.Size = new System.Drawing.Size(123, 25);
            this.newSpecialDefenseLabel.TabIndex = 10;
            this.newSpecialDefenseLabel.Text = "        Sp. Def:";
            // 
            // newSpDefBox
            // 
            this.newSpDefBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newSpDefBox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.newSpDefBox.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.newSpDefBox.BorderSize = 2;
            this.newSpDefBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSpDefBox.ForeColor = System.Drawing.Color.DimGray;
            this.newSpDefBox.Location = new System.Drawing.Point(133, 185);
            this.newSpDefBox.Margin = new System.Windows.Forms.Padding(4);
            this.newSpDefBox.Multiline = false;
            this.newSpDefBox.Name = "newSpDefBox";
            this.newSpDefBox.Padding = new System.Windows.Forms.Padding(7);
            this.newSpDefBox.PasswordChar = false;
            this.newSpDefBox.Size = new System.Drawing.Size(269, 31);
            this.newSpDefBox.TabIndex = 5;
            this.newSpDefBox.Texts = "";
            this.newSpDefBox.UnderlinedStyle = false;
            this.newSpDefBox._TextChanged += new System.EventHandler(this.newSpDefBox__TextChanged);
            // 
            // newHpLabel
            // 
            this.newHpLabel.AutoSize = true;
            this.newHpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHpLabel.ForeColor = System.Drawing.Color.White;
            this.newHpLabel.Location = new System.Drawing.Point(3, 220);
            this.newHpLabel.Name = "newHpLabel";
            this.newHpLabel.Size = new System.Drawing.Size(83, 25);
            this.newHpLabel.TabIndex = 11;
            this.newHpLabel.Text = "        Hp:";
            // 
            // newHpBox
            // 
            this.newHpBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newHpBox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.newHpBox.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.newHpBox.BorderSize = 2;
            this.newHpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHpBox.ForeColor = System.Drawing.Color.DimGray;
            this.newHpBox.Location = new System.Drawing.Point(93, 224);
            this.newHpBox.Margin = new System.Windows.Forms.Padding(4);
            this.newHpBox.Multiline = false;
            this.newHpBox.Name = "newHpBox";
            this.newHpBox.Padding = new System.Windows.Forms.Padding(7);
            this.newHpBox.PasswordChar = false;
            this.newHpBox.Size = new System.Drawing.Size(309, 31);
            this.newHpBox.TabIndex = 16;
            this.newHpBox.Texts = "";
            this.newHpBox.UnderlinedStyle = false;
            this.newHpBox._TextChanged += new System.EventHandler(this.newHpBox__TextChanged);
            // 
            // newDefenseLabel
            // 
            this.newDefenseLabel.AutoSize = true;
            this.newDefenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDefenseLabel.ForeColor = System.Drawing.Color.White;
            this.newDefenseLabel.Location = new System.Drawing.Point(3, 259);
            this.newDefenseLabel.Name = "newDefenseLabel";
            this.newDefenseLabel.Size = new System.Drawing.Size(131, 25);
            this.newDefenseLabel.TabIndex = 9;
            this.newDefenseLabel.Text = "        Defense:";
            // 
            // newDefBox
            // 
            this.newDefBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newDefBox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.newDefBox.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.newDefBox.BorderSize = 2;
            this.newDefBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDefBox.ForeColor = System.Drawing.Color.DimGray;
            this.newDefBox.Location = new System.Drawing.Point(141, 263);
            this.newDefBox.Margin = new System.Windows.Forms.Padding(4);
            this.newDefBox.Multiline = false;
            this.newDefBox.Name = "newDefBox";
            this.newDefBox.Padding = new System.Windows.Forms.Padding(7);
            this.newDefBox.PasswordChar = false;
            this.newDefBox.Size = new System.Drawing.Size(261, 31);
            this.newDefBox.TabIndex = 15;
            this.newDefBox.Texts = "";
            this.newDefBox.UnderlinedStyle = false;
            this.newDefBox._TextChanged += new System.EventHandler(this.newDefBox__TextChanged);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createButton.BorderRadius = 0;
            this.createButton.BorderSize = 0;
            this.createButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(0, 374);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(430, 83);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create Pokemon";
            this.createButton.TextColor = System.Drawing.Color.White;
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // addPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "addPokemon";
            this.Size = new System.Drawing.Size(430, 457);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJTextBox newNameBox;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.Label newTypeLabel;
        private CustomControls.RJControls.RJTextBox newTypeBox;
        private System.Windows.Forms.Label newStats;
        private CustomControls.RJControls.RJTextBox newAttackBox;
        private CustomControls.RJControls.RJTextBox newSpeedBox;
        private CustomControls.RJControls.RJTextBox newSpAttackBox;
        private CustomControls.RJControls.RJTextBox newSpDefBox;
        private System.Windows.Forms.Label newAttackLabel;
        private System.Windows.Forms.Label newSpeedLabel;
        private System.Windows.Forms.Label newSpecialAttackLabel;
        private System.Windows.Forms.Label newSpecialDefenseLabel;
        private System.Windows.Forms.Label newHpLabel;
        private CustomControls.RJControls.RJTextBox newHpBox;
        private System.Windows.Forms.Label newDefenseLabel;
        private CustomControls.RJControls.RJTextBox newDefBox;
        private CustomControls.RJControls.RJButton createButton;
    }
}
