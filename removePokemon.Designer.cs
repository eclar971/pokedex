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
            this.removeImg = new CustomControls.RJControls.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.removeImg)).BeginInit();
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
            this.deletePokemon.Click += new System.EventHandler(this.deletePokemon_Click);
            // 
            // removeImg
            // 
            this.removeImg.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.removeImg.BorderColor = System.Drawing.Color.RoyalBlue;
            this.removeImg.BorderColor2 = System.Drawing.Color.HotPink;
            this.removeImg.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.removeImg.BorderSize = 2;
            this.removeImg.GradientAngle = 50F;
            this.removeImg.Location = new System.Drawing.Point(60, 36);
            this.removeImg.Name = "removeImg";
            this.removeImg.Size = new System.Drawing.Size(310, 310);
            this.removeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removeImg.TabIndex = 2;
            this.removeImg.TabStop = false;
            // 
            // removePokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.deletePokemon);
            this.Controls.Add(this.removeImg);
            this.Name = "removePokemon";
            this.Size = new System.Drawing.Size(430, 457);
            this.Load += new System.EventHandler(this.removePokemon_Load);
            this.VisibleChanged += new System.EventHandler(this.remove_Visable);
            ((System.ComponentModel.ISupportInitialize)(this.removeImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton deletePokemon;
        private CustomControls.RJControls.RJCircularPictureBox removeImg;
    }
}
