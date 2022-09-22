namespace pokedex
{
    partial class seenScreen
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
            this.whereSeenLabel = new System.Windows.Forms.Label();
            this.whereCaught = new CustomControls.RJControls.RJTextBox();
            this.isShinnyLabelSeen = new System.Windows.Forms.Label();
            this.isShinnySeen = new CustomControls.RJControls.RJTextBox();
            this.caughtPokemonPic = new CustomControls.RJControls.RJCircularPictureBox();
            this.whenSeenLabel = new System.Windows.Forms.Label();
            this.whenSeen = new CustomControls.RJControls.RJTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caughtPokemonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.whereSeenLabel);
            this.flowLayoutPanel1.Controls.Add(this.whereCaught);
            this.flowLayoutPanel1.Controls.Add(this.isShinnyLabelSeen);
            this.flowLayoutPanel1.Controls.Add(this.isShinnySeen);
            this.flowLayoutPanel1.Controls.Add(this.whenSeenLabel);
            this.flowLayoutPanel1.Controls.Add(this.whenSeen);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 216);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // whereSeenLabel
            // 
            this.whereSeenLabel.AutoSize = true;
            this.whereSeenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whereSeenLabel.ForeColor = System.Drawing.Color.White;
            this.whereSeenLabel.Location = new System.Drawing.Point(3, 0);
            this.whereSeenLabel.Name = "whereSeenLabel";
            this.whereSeenLabel.Size = new System.Drawing.Size(196, 17);
            this.whereSeenLabel.TabIndex = 2;
            this.whereSeenLabel.Text = "Please enter where you saw it";
            // 
            // whereCaught
            // 
            this.whereCaught.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.whereCaught.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.whereCaught.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.whereCaught.BorderSize = 2;
            this.whereCaught.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whereCaught.ForeColor = System.Drawing.Color.DimGray;
            this.whereCaught.Location = new System.Drawing.Point(4, 21);
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
            // isShinnyLabelSeen
            // 
            this.isShinnyLabelSeen.AutoSize = true;
            this.isShinnyLabelSeen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isShinnyLabelSeen.ForeColor = System.Drawing.Color.White;
            this.isShinnyLabelSeen.Location = new System.Drawing.Point(3, 57);
            this.isShinnyLabelSeen.Name = "isShinnyLabelSeen";
            this.isShinnyLabelSeen.Size = new System.Drawing.Size(174, 17);
            this.isShinnyLabelSeen.TabIndex = 4;
            this.isShinnyLabelSeen.Text = "Enter whether shiny or not";
            // 
            // isShinnySeen
            // 
            this.isShinnySeen.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.isShinnySeen.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.isShinnySeen.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.isShinnySeen.BorderSize = 2;
            this.isShinnySeen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isShinnySeen.ForeColor = System.Drawing.Color.DimGray;
            this.isShinnySeen.Location = new System.Drawing.Point(4, 78);
            this.isShinnySeen.Margin = new System.Windows.Forms.Padding(4);
            this.isShinnySeen.Multiline = false;
            this.isShinnySeen.Name = "isShinnySeen";
            this.isShinnySeen.Padding = new System.Windows.Forms.Padding(7);
            this.isShinnySeen.PasswordChar = false;
            this.isShinnySeen.Size = new System.Drawing.Size(250, 32);
            this.isShinnySeen.TabIndex = 5;
            this.isShinnySeen.Texts = "";
            this.isShinnySeen.UnderlinedStyle = false;
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
            this.caughtPokemonPic.TabIndex = 2;
            this.caughtPokemonPic.TabStop = false;
            // 
            // whenSeenLabel
            // 
            this.whenSeenLabel.AutoSize = true;
            this.whenSeenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whenSeenLabel.ForeColor = System.Drawing.Color.White;
            this.whenSeenLabel.Location = new System.Drawing.Point(3, 114);
            this.whenSeenLabel.Name = "whenSeenLabel";
            this.whenSeenLabel.Size = new System.Drawing.Size(251, 17);
            this.whenSeenLabel.TabIndex = 8;
            this.whenSeenLabel.Text = "enter when you seen it (MM/DD/YYYY)";
            // 
            // whenSeen
            // 
            this.whenSeen.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.whenSeen.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.whenSeen.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.whenSeen.BorderSize = 2;
            this.whenSeen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whenSeen.ForeColor = System.Drawing.Color.DimGray;
            this.whenSeen.Location = new System.Drawing.Point(4, 135);
            this.whenSeen.Margin = new System.Windows.Forms.Padding(4);
            this.whenSeen.Multiline = false;
            this.whenSeen.Name = "whenSeen";
            this.whenSeen.Padding = new System.Windows.Forms.Padding(7);
            this.whenSeen.PasswordChar = false;
            this.whenSeen.Size = new System.Drawing.Size(250, 32);
            this.whenSeen.TabIndex = 9;
            this.whenSeen.Texts = "";
            this.whenSeen.UnderlinedStyle = false;
            // 
            // seenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.caughtPokemonPic);
            this.Name = "seenScreen";
            this.Size = new System.Drawing.Size(430, 457);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caughtPokemonPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label whereSeenLabel;
        private CustomControls.RJControls.RJTextBox whereCaught;
        private System.Windows.Forms.Label isShinnyLabelSeen;
        private CustomControls.RJControls.RJTextBox isShinnySeen;
        private CustomControls.RJControls.RJCircularPictureBox caughtPokemonPic;
        private System.Windows.Forms.Label whenSeenLabel;
        private CustomControls.RJControls.RJTextBox whenSeen;
    }
}
