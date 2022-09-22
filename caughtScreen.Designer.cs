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
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caughtPokemonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.caughtNickname);
            this.flowLayoutPanel1.Controls.Add(this.rjTextBox1);
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
    }
}
