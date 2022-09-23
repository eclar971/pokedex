namespace pokedex
{
    partial class scollerSceen
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
            this.rightScroll = new FontAwesome.Sharp.IconButton();
            this.leftScroll = new FontAwesome.Sharp.IconButton();
            this.pokemonInfo = new System.Windows.Forms.Label();
            this.pokemonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rightScroll
            // 
            this.rightScroll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rightScroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightScroll.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.rightScroll.IconColor = System.Drawing.Color.Black;
            this.rightScroll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rightScroll.Location = new System.Drawing.Point(205, 355);
            this.rightScroll.Name = "rightScroll";
            this.rightScroll.Size = new System.Drawing.Size(90, 90);
            this.rightScroll.TabIndex = 10;
            this.rightScroll.UseVisualStyleBackColor = false;
            // 
            // leftScroll
            // 
            this.leftScroll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.leftScroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leftScroll.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.leftScroll.IconColor = System.Drawing.Color.Black;
            this.leftScroll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.leftScroll.Location = new System.Drawing.Point(109, 355);
            this.leftScroll.Name = "leftScroll";
            this.leftScroll.Size = new System.Drawing.Size(90, 90);
            this.leftScroll.TabIndex = 9;
            this.leftScroll.UseVisualStyleBackColor = false;
            // 
            // pokemonInfo
            // 
            this.pokemonInfo.AutoSize = true;
            this.pokemonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonInfo.ForeColor = System.Drawing.Color.White;
            this.pokemonInfo.Location = new System.Drawing.Point(3, 3);
            this.pokemonInfo.Name = "pokemonInfo";
            this.pokemonInfo.Size = new System.Drawing.Size(141, 17);
            this.pokemonInfo.TabIndex = 8;
            this.pokemonInfo.Text = "Pokemon Information";
            // 
            // pokemonImage
            // 
            this.pokemonImage.Location = new System.Drawing.Point(205, 3);
            this.pokemonImage.Name = "pokemonImage";
            this.pokemonImage.Size = new System.Drawing.Size(225, 337);
            this.pokemonImage.TabIndex = 7;
            this.pokemonImage.TabStop = false;
            // 
            // scollerSceen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.rightScroll);
            this.Controls.Add(this.leftScroll);
            this.Controls.Add(this.pokemonInfo);
            this.Controls.Add(this.pokemonImage);
            this.Name = "scollerSceen";
            this.Size = new System.Drawing.Size(430, 457);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton rightScroll;
        private FontAwesome.Sharp.IconButton leftScroll;
        private System.Windows.Forms.Label pokemonInfo;
        private System.Windows.Forms.PictureBox pokemonImage;
    }
}
