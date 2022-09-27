namespace pokedex
{
    partial class removePokemon
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
            this.deletePokemon = new CustomControls.RJControls.RJButton();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deletePokemon
            // 
            this.deletePokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deletePokemon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deletePokemon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deletePokemon.BorderRadius = 0;
            this.deletePokemon.BorderSize = 0;
            this.deletePokemon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deletePokemon.FlatAppearance.BorderSize = 0;
            this.deletePokemon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePokemon.ForeColor = System.Drawing.Color.White;
            this.deletePokemon.Location = new System.Drawing.Point(0, 378);
            this.deletePokemon.Name = "deletePokemon";
            this.deletePokemon.Size = new System.Drawing.Size(430, 79);
            this.deletePokemon.TabIndex = 0;
            this.deletePokemon.Text = "Delete";
            this.deletePokemon.TextColor = System.Drawing.Color.White;
            this.deletePokemon.UseVisualStyleBackColor = false;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(60, 36);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(310, 310);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 2;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // removePokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.deletePokemon);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Name = "removePokemon";
            this.Size = new System.Drawing.Size(430, 457);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton deletePokemon;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
    }
}
