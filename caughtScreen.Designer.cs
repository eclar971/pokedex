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
            this.caughtNickname = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.caughtPokemonPic = new CustomControls.RJControls.RJCircularPictureBox();
            this.whereCaughtLabel = new System.Windows.Forms.Label();
            this.whereCaught = new CustomControls.RJControls.RJTextBox();
            this.isShinnyLabel = new System.Windows.Forms.Label();
            this.isShinny = new CustomControls.RJControls.RJTextBox();
            this.whenCaughtLabel = new System.Windows.Forms.Label();
            this.whenCaught = new CustomControls.RJControls.RJTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caughtPokemonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.caughtNickname);
            this.flowLayoutPanel1.Controls.Add(this.rjTextBox1);
            this.flowLayoutPanel1.Controls.Add(this.whereCaughtLabel);
            this.flowLayoutPanel1.Controls.Add(this.whereCaught);
            this.flowLayoutPanel1.Controls.Add(this.isShinnyLabel);
            this.flowLayoutPanel1.Controls.Add(this.isShinny);
            this.flowLayoutPanel1.Controls.Add(this.whenCaughtLabel);
            this.flowLayoutPanel1.Controls.Add(this.whenCaught);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 216);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // caughtNickname
            // 
            this.caughtNickname.AutoSize = true;
            this.caughtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caughtNickname.ForeColor = System.Drawing.Color.White;
            this.caughtNickname.Location = new System.Drawing.Point(3, 0);
            this.caughtNickname.Name = "caughtNickname";
            this.caughtNickname.Size = new System.Drawing.Size(164, 17);
            this.caughtNickname.TabIndex = 1;
            this.caughtNickname.Text = "Please enter a nickname";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rjTextBox1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(174, 4);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox1.TabIndex = 0;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
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
        private System.Windows.Forms.Label caughtNickname;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label whereCaughtLabel;
        private CustomControls.RJControls.RJTextBox whereCaught;
        private System.Windows.Forms.Label isShinnyLabel;
        private CustomControls.RJControls.RJTextBox isShinny;
        private System.Windows.Forms.Label whenCaughtLabel;
        private CustomControls.RJControls.RJTextBox whenCaught;
    }
}
