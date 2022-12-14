namespace pokedex
{
    partial class caughtScreen
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
            this.caughtNicknameLabel = new System.Windows.Forms.Label();
            this.whereCaughtLabel = new System.Windows.Forms.Label();
            this.isShinnyLabel = new System.Windows.Forms.Label();
            this.whenCaughtLabel = new System.Windows.Forms.Label();
            this.caughtNickname = new CustomControls.RJControls.RJTextBox();
            this.whereCaught = new CustomControls.RJControls.RJTextBox();
            this.isShinny = new CustomControls.RJControls.RJTextBox();
            this.whenCaught = new CustomControls.RJControls.RJTextBox();
            this.saveCaught = new CustomControls.RJControls.RJButton();
            this.caughtPokemonPic = new CustomControls.RJControls.RJCircularPictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caughtPokemonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.caughtNicknameLabel);
            this.flowLayoutPanel1.Controls.Add(this.caughtNickname);
            this.flowLayoutPanel1.Controls.Add(this.whereCaughtLabel);
            this.flowLayoutPanel1.Controls.Add(this.whereCaught);
            this.flowLayoutPanel1.Controls.Add(this.isShinnyLabel);
            this.flowLayoutPanel1.Controls.Add(this.isShinny);
            this.flowLayoutPanel1.Controls.Add(this.whenCaughtLabel);
            this.flowLayoutPanel1.Controls.Add(this.whenCaught);
            this.flowLayoutPanel1.Controls.Add(this.saveCaught);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 216);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // caughtNicknameLabel
            // 
            this.caughtNicknameLabel.AutoSize = true;
            this.caughtNicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caughtNicknameLabel.ForeColor = System.Drawing.Color.White;
            this.caughtNicknameLabel.Location = new System.Drawing.Point(3, 0);
            this.caughtNicknameLabel.Name = "caughtNicknameLabel";
            this.caughtNicknameLabel.Size = new System.Drawing.Size(164, 17);
            this.caughtNicknameLabel.TabIndex = 1;
            this.caughtNicknameLabel.Text = "Please enter a nickname";
            // 
            // whereCaughtLabel
            // 
            this.whereCaughtLabel.AutoSize = true;
            this.whereCaughtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whereCaughtLabel.ForeColor = System.Drawing.Color.White;
            this.whereCaughtLabel.Location = new System.Drawing.Point(3, 40);
            this.whereCaughtLabel.Name = "whereCaughtLabel";
            this.whereCaughtLabel.Size = new System.Drawing.Size(215, 17);
            this.whereCaughtLabel.TabIndex = 2;
            this.whereCaughtLabel.Text = "Please enter where you caught it";
            // 
            // isShinnyLabel
            // 
            this.isShinnyLabel.AutoSize = true;
            this.isShinnyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isShinnyLabel.ForeColor = System.Drawing.Color.White;
            this.isShinnyLabel.Location = new System.Drawing.Point(3, 97);
            this.isShinnyLabel.Name = "isShinnyLabel";
            this.isShinnyLabel.Size = new System.Drawing.Size(174, 17);
            this.isShinnyLabel.TabIndex = 4;
            this.isShinnyLabel.Text = "Enter whether shiny or not";
            // 
            // whenCaughtLabel
            // 
            this.whenCaughtLabel.AutoSize = true;
            this.whenCaughtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whenCaughtLabel.ForeColor = System.Drawing.Color.White;
            this.whenCaughtLabel.Location = new System.Drawing.Point(3, 154);
            this.whenCaughtLabel.Name = "whenCaughtLabel";
            this.whenCaughtLabel.Size = new System.Drawing.Size(263, 17);
            this.whenCaughtLabel.TabIndex = 6;
            this.whenCaughtLabel.Text = "enter when you caught it (MM/DD/YYYY)";
            // 
            // caughtNickname
            // 
            this.caughtNickname.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.caughtNickname.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.caughtNickname.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.caughtNickname.BorderSize = 2;
            this.caughtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caughtNickname.ForeColor = System.Drawing.Color.DimGray;
            this.caughtNickname.Location = new System.Drawing.Point(174, 4);
            this.caughtNickname.Margin = new System.Windows.Forms.Padding(4);
            this.caughtNickname.Multiline = false;
            this.caughtNickname.Name = "caughtNickname";
            this.caughtNickname.Padding = new System.Windows.Forms.Padding(7);
            this.caughtNickname.PasswordChar = false;
            this.caughtNickname.Size = new System.Drawing.Size(250, 32);
            this.caughtNickname.TabIndex = 0;
            this.caughtNickname.Texts = "";
            this.caughtNickname.UnderlinedStyle = false;
            this.caughtNickname._TextChanged += new System.EventHandler(this.caughtNickname__TextChanged);
            // 
            // whereCaught
            // 
            this.whereCaught.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.whereCaught.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.whereCaught.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.whereCaught.BorderSize = 2;
            this.whereCaught.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whereCaught.ForeColor = System.Drawing.Color.DimGray;
            this.whereCaught.Location = new System.Drawing.Point(4, 61);
            this.whereCaught.Margin = new System.Windows.Forms.Padding(4);
            this.whereCaught.Multiline = false;
            this.whereCaught.Name = "whereCaught";
            this.whereCaught.Padding = new System.Windows.Forms.Padding(7);
            this.whereCaught.PasswordChar = false;
            this.whereCaught.Size = new System.Drawing.Size(250, 32);
            this.whereCaught.TabIndex = 3;
            this.whereCaught.Texts = "";
            this.whereCaught.UnderlinedStyle = false;
            this.whereCaught._TextChanged += new System.EventHandler(this.whereCaught__TextChanged);
            // 
            // isShinny
            // 
            this.isShinny.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.isShinny.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.isShinny.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.isShinny.BorderSize = 2;
            this.isShinny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isShinny.ForeColor = System.Drawing.Color.DimGray;
            this.isShinny.Location = new System.Drawing.Point(4, 118);
            this.isShinny.Margin = new System.Windows.Forms.Padding(4);
            this.isShinny.Multiline = false;
            this.isShinny.Name = "isShinny";
            this.isShinny.Padding = new System.Windows.Forms.Padding(7);
            this.isShinny.PasswordChar = false;
            this.isShinny.Size = new System.Drawing.Size(250, 32);
            this.isShinny.TabIndex = 5;
            this.isShinny.Texts = "";
            this.isShinny.UnderlinedStyle = false;
            this.isShinny._TextChanged += new System.EventHandler(this.isShinny__TextChanged);
            // 
            // whenCaught
            // 
            this.whenCaught.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.whenCaught.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.whenCaught.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.whenCaught.BorderSize = 2;
            this.whenCaught.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whenCaught.ForeColor = System.Drawing.Color.DimGray;
            this.whenCaught.Location = new System.Drawing.Point(4, 175);
            this.whenCaught.Margin = new System.Windows.Forms.Padding(4);
            this.whenCaught.Multiline = false;
            this.whenCaught.Name = "whenCaught";
            this.whenCaught.Padding = new System.Windows.Forms.Padding(7);
            this.whenCaught.PasswordChar = false;
            this.whenCaught.Size = new System.Drawing.Size(250, 32);
            this.whenCaught.TabIndex = 7;
            this.whenCaught.Texts = "";
            this.whenCaught.UnderlinedStyle = false;
            this.whenCaught._TextChanged += new System.EventHandler(this.whenCaught__TextChanged);
            // 
            // saveCaught
            // 
            this.saveCaught.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveCaught.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveCaught.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveCaught.BorderRadius = 0;
            this.saveCaught.BorderSize = 0;
            this.saveCaught.FlatAppearance.BorderSize = 0;
            this.saveCaught.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveCaught.ForeColor = System.Drawing.Color.White;
            this.saveCaught.Location = new System.Drawing.Point(261, 174);
            this.saveCaught.Name = "saveCaught";
            this.saveCaught.Size = new System.Drawing.Size(150, 40);
            this.saveCaught.TabIndex = 2;
            this.saveCaught.Text = "Save";
            this.saveCaught.TextColor = System.Drawing.Color.White;
            this.saveCaught.UseVisualStyleBackColor = false;
            this.saveCaught.Click += new System.EventHandler(this.saveCaught_Click);
            // 
            // caughtPokemonPic
            // 
            this.caughtPokemonPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.caughtPokemonPic.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.caughtPokemonPic.BorderColor2 = System.Drawing.Color.DeepSkyBlue;
            this.caughtPokemonPic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.caughtPokemonPic.BorderSize = 2;
            this.caughtPokemonPic.GradientAngle = 50F;
            this.caughtPokemonPic.Location = new System.Drawing.Point(94, 3);
            this.caughtPokemonPic.Name = "caughtPokemonPic";
            this.caughtPokemonPic.Size = new System.Drawing.Size(233, 233);
            this.caughtPokemonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caughtPokemonPic.TabIndex = 0;
            this.caughtPokemonPic.TabStop = false;
            this.caughtPokemonPic.VisibleChanged += new System.EventHandler(this.caughtScreen_Visble);
            this.caughtPokemonPic.Click += new System.EventHandler(this.caughtPokemonPic_Click);
            // 
            // caughtScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.caughtPokemonPic);
            this.Name = "caughtScreen";
            this.Size = new System.Drawing.Size(430, 457);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caughtPokemonPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox caughtPokemonPic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label caughtNicknameLabel;
        private CustomControls.RJControls.RJTextBox caughtNickname;
        private System.Windows.Forms.Label whereCaughtLabel;
        private CustomControls.RJControls.RJTextBox whereCaught;
        private System.Windows.Forms.Label isShinnyLabel;
        private CustomControls.RJControls.RJTextBox isShinny;
        private System.Windows.Forms.Label whenCaughtLabel;
        private CustomControls.RJControls.RJTextBox whenCaught;
        private CustomControls.RJControls.RJButton saveCaught;
    }
}
