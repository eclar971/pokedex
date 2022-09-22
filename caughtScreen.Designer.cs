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
            this.caughtPokemonPic = new CustomControls.RJControls.RJCircularPictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.caughtPokemonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // caughtPokemonPic
            // 
            this.caughtPokemonPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.caughtPokemonPic.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.caughtPokemonPic.BorderColor2 = System.Drawing.Color.DeepSkyBlue;
            this.caughtPokemonPic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.caughtPokemonPic.BorderSize = 2;
            this.caughtPokemonPic.GradientAngle = 50F;
            this.caughtPokemonPic.Location = new System.Drawing.Point(74, 3);
            this.caughtPokemonPic.Name = "caughtPokemonPic";
            this.caughtPokemonPic.Size = new System.Drawing.Size(178, 178);
            this.caughtPokemonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caughtPokemonPic.TabIndex = 0;
            this.caughtPokemonPic.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 187);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(336, 251);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // caughtScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.caughtPokemonPic);
            this.Name = "caughtScreen";
            this.Size = new System.Drawing.Size(336, 438);
            ((System.ComponentModel.ISupportInitialize)(this.caughtPokemonPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox caughtPokemonPic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
