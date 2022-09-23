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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.name = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.flowLayoutPanel1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.name);
            this.flowLayoutPanel1.Controls.Add(this.rjTextBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(3, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 25);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rjTextBox1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(80, 4);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(335, 31);
            this.rjTextBox1.TabIndex = 1;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(54, 55);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(317, 317);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 2;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // removePokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.deletePokemon);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Name = "removePokemon";
            this.Size = new System.Drawing.Size(430, 457);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton deletePokemon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label name;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
    }
}
