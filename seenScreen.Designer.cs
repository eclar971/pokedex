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
            this.whereSeen = new CustomControls.RJControls.RJTextBox();
            this.isShinnyLabelSeen = new System.Windows.Forms.Label();
            this.isShinnySeen = new CustomControls.RJControls.RJTextBox();
            this.whenSeenLabel = new System.Windows.Forms.Label();
            this.whenSeen = new CustomControls.RJControls.RJTextBox();
            this.saveSeen = new CustomControls.RJControls.RJButton();
            this.seenPokemonPic = new CustomControls.RJControls.RJCircularPictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seenPokemonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.whereSeenLabel);
            this.flowLayoutPanel1.Controls.Add(this.whereSeen);
            this.flowLayoutPanel1.Controls.Add(this.isShinnyLabelSeen);
            this.flowLayoutPanel1.Controls.Add(this.isShinnySeen);
            this.flowLayoutPanel1.Controls.Add(this.whenSeenLabel);
            this.flowLayoutPanel1.Controls.Add(this.whenSeen);
            this.flowLayoutPanel1.Controls.Add(this.saveSeen);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 216);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            // whereSeen
            // 
            this.whereSeen.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.whereSeen.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.whereSeen.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.whereSeen.BorderSize = 2;
            this.whereSeen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whereSeen.ForeColor = System.Drawing.Color.DimGray;
            this.whereSeen.Location = new System.Drawing.Point(4, 21);
            this.whereSeen.Margin = new System.Windows.Forms.Padding(4);
            this.whereSeen.Multiline = false;
            this.whereSeen.Name = "whereSeen";
            this.whereSeen.Padding = new System.Windows.Forms.Padding(7);
            this.whereSeen.PasswordChar = false;
            this.whereSeen.Size = new System.Drawing.Size(250, 32);
            this.whereSeen.TabIndex = 3;
            this.whereSeen.Texts = "";
            this.whereSeen.UnderlinedStyle = false;
            this.whereSeen._TextChanged += new System.EventHandler(this.whereSeen__TextChanged);
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
            this.isShinnySeen._TextChanged += new System.EventHandler(this.isShinnySeen__TextChanged);
            // 
            // whenSeenLabel
            // 
            this.whenSeenLabel.AutoSize = true;
            this.whenSeenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whenSeenLabel.ForeColor = System.Drawing.Color.White;
            this.whenSeenLabel.Location = new System.Drawing.Point(3, 114);
            this.whenSeenLabel.Name = "whenSeenLabel";
            this.whenSeenLabel.Size = new System.Drawing.Size(244, 17);
            this.whenSeenLabel.TabIndex = 8;
            this.whenSeenLabel.Text = "enter when you saw it (MM/DD/YYYY)";
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
            this.whenSeen._TextChanged += new System.EventHandler(this.whenSeen__TextChanged);
            // 
            // saveSeen
            // 
            this.saveSeen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveSeen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveSeen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveSeen.BorderRadius = 0;
            this.saveSeen.BorderSize = 0;
            this.saveSeen.FlatAppearance.BorderSize = 0;
            this.saveSeen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveSeen.ForeColor = System.Drawing.Color.White;
            this.saveSeen.Location = new System.Drawing.Point(261, 134);
            this.saveSeen.Name = "saveSeen";
            this.saveSeen.Size = new System.Drawing.Size(150, 40);
            this.saveSeen.TabIndex = 10;
            this.saveSeen.Text = "Save";
            this.saveSeen.TextColor = System.Drawing.Color.White;
            this.saveSeen.UseVisualStyleBackColor = false;
            this.saveSeen.Click += new System.EventHandler(this.saveSeen_Click);
            // 
            // seenPokemonPic
            // 
            this.seenPokemonPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.seenPokemonPic.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.seenPokemonPic.BorderColor2 = System.Drawing.Color.DeepSkyBlue;
            this.seenPokemonPic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.seenPokemonPic.BorderSize = 2;
            this.seenPokemonPic.GradientAngle = 50F;
            this.seenPokemonPic.Location = new System.Drawing.Point(94, 3);
            this.seenPokemonPic.Name = "seenPokemonPic";
            this.seenPokemonPic.Size = new System.Drawing.Size(233, 233);
            this.seenPokemonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seenPokemonPic.TabIndex = 2;
            this.seenPokemonPic.TabStop = false;
            // 
            // seenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.seenPokemonPic);
            this.Name = "seenScreen";
            this.Size = new System.Drawing.Size(430, 457);
            this.Load += new System.EventHandler(this.seenScreen_Load);
            this.VisibleChanged += new System.EventHandler(this.seenScreen_Visble);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seenPokemonPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label whereSeenLabel;
        private CustomControls.RJControls.RJTextBox whereSeen;
        private System.Windows.Forms.Label isShinnyLabelSeen;
        private CustomControls.RJControls.RJTextBox isShinnySeen;
        private CustomControls.RJControls.RJCircularPictureBox seenPokemonPic;
        private System.Windows.Forms.Label whenSeenLabel;
        private CustomControls.RJControls.RJTextBox whenSeen;
        private CustomControls.RJControls.RJButton saveSeen;
    }
}
