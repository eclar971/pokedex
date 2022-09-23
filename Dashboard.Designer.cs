namespace pokedex
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.scrollPokemon = new CustomControls.RJControls.RJButton();
            this.markCaught = new CustomControls.RJControls.RJButton();
            this.markSeen = new CustomControls.RJControls.RJButton();
            this.veiwStats = new CustomControls.RJControls.RJButton();
            this.editStats = new CustomControls.RJControls.RJButton();
            this.addPokemon = new CustomControls.RJControls.RJButton();
            this.removePokemon = new CustomControls.RJControls.RJButton();
            this.caughtScreen1 = new pokedex.caughtScreen();
            this.closeButton = new CustomControls.RJControls.RJButton();
            this.seenScreen1 = new pokedex.seenScreen();
            this.scollerSceen1 = new pokedex.scollerSceen();
            this.statsScreen1 = new pokedex.statsScreen();
            this.changeStatsScreen1 = new pokedex.changeStatsScreen();
            this.addPokemon1 = new pokedex.addPokemon();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.scrollPokemon);
            this.flowLayoutPanel1.Controls.Add(this.markCaught);
            this.flowLayoutPanel1.Controls.Add(this.markSeen);
            this.flowLayoutPanel1.Controls.Add(this.veiwStats);
            this.flowLayoutPanel1.Controls.Add(this.editStats);
            this.flowLayoutPanel1.Controls.Add(this.addPokemon);
            this.flowLayoutPanel1.Controls.Add(this.removePokemon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 124);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 338);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // scrollPokemon
            // 
            this.scrollPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scrollPokemon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scrollPokemon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.scrollPokemon.BorderRadius = 0;
            this.scrollPokemon.BorderSize = 0;
            this.scrollPokemon.FlatAppearance.BorderSize = 0;
            this.scrollPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrollPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollPokemon.ForeColor = System.Drawing.Color.White;
            this.scrollPokemon.Location = new System.Drawing.Point(3, 3);
            this.scrollPokemon.Name = "scrollPokemon";
            this.scrollPokemon.Size = new System.Drawing.Size(326, 70);
            this.scrollPokemon.TabIndex = 0;
            this.scrollPokemon.Text = "pokemon scroller";
            this.scrollPokemon.TextColor = System.Drawing.Color.White;
            this.scrollPokemon.UseVisualStyleBackColor = false;
            this.scrollPokemon.Click += new System.EventHandler(this.scrollPokemon_Click);
            // 
            // markCaught
            // 
            this.markCaught.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.markCaught.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.markCaught.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.markCaught.BorderRadius = 0;
            this.markCaught.BorderSize = 0;
            this.markCaught.FlatAppearance.BorderSize = 0;
            this.markCaught.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markCaught.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markCaught.ForeColor = System.Drawing.Color.White;
            this.markCaught.Location = new System.Drawing.Point(3, 79);
            this.markCaught.Name = "markCaught";
            this.markCaught.Size = new System.Drawing.Size(160, 70);
            this.markCaught.TabIndex = 1;
            this.markCaught.Text = "mark as caught";
            this.markCaught.TextColor = System.Drawing.Color.White;
            this.markCaught.UseVisualStyleBackColor = false;
            this.markCaught.Click += new System.EventHandler(this.markCaught_Click);
            // 
            // markSeen
            // 
            this.markSeen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.markSeen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.markSeen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.markSeen.BorderRadius = 0;
            this.markSeen.BorderSize = 0;
            this.markSeen.FlatAppearance.BorderSize = 0;
            this.markSeen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markSeen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markSeen.ForeColor = System.Drawing.Color.White;
            this.markSeen.Location = new System.Drawing.Point(169, 79);
            this.markSeen.Name = "markSeen";
            this.markSeen.Size = new System.Drawing.Size(160, 70);
            this.markSeen.TabIndex = 2;
            this.markSeen.Text = "mark as seen";
            this.markSeen.TextColor = System.Drawing.Color.White;
            this.markSeen.UseVisualStyleBackColor = false;
            this.markSeen.Click += new System.EventHandler(this.markSeen_Click);
            // 
            // veiwStats
            // 
            this.veiwStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.veiwStats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.veiwStats.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.veiwStats.BorderRadius = 0;
            this.veiwStats.BorderSize = 0;
            this.veiwStats.FlatAppearance.BorderSize = 0;
            this.veiwStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.veiwStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veiwStats.ForeColor = System.Drawing.Color.White;
            this.veiwStats.Location = new System.Drawing.Point(3, 155);
            this.veiwStats.Name = "veiwStats";
            this.veiwStats.Size = new System.Drawing.Size(160, 70);
            this.veiwStats.TabIndex = 3;
            this.veiwStats.Text = "view stats";
            this.veiwStats.TextColor = System.Drawing.Color.White;
            this.veiwStats.UseVisualStyleBackColor = false;
            this.veiwStats.Click += new System.EventHandler(this.veiwStats_Click);
            // 
            // editStats
            // 
            this.editStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editStats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editStats.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editStats.BorderRadius = 0;
            this.editStats.BorderSize = 0;
            this.editStats.FlatAppearance.BorderSize = 0;
            this.editStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStats.ForeColor = System.Drawing.Color.White;
            this.editStats.Location = new System.Drawing.Point(169, 155);
            this.editStats.Name = "editStats";
            this.editStats.Size = new System.Drawing.Size(160, 70);
            this.editStats.TabIndex = 4;
            this.editStats.Text = "edit stats";
            this.editStats.TextColor = System.Drawing.Color.White;
            this.editStats.UseVisualStyleBackColor = false;
            this.editStats.Click += new System.EventHandler(this.editStats_Click);
            // 
            // addPokemon
            // 
            this.addPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addPokemon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addPokemon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addPokemon.BorderRadius = 0;
            this.addPokemon.BorderSize = 0;
            this.addPokemon.FlatAppearance.BorderSize = 0;
            this.addPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPokemon.ForeColor = System.Drawing.Color.White;
            this.addPokemon.Location = new System.Drawing.Point(3, 231);
            this.addPokemon.Name = "addPokemon";
            this.addPokemon.Size = new System.Drawing.Size(160, 70);
            this.addPokemon.TabIndex = 5;
            this.addPokemon.Text = "add pokemon";
            this.addPokemon.TextColor = System.Drawing.Color.White;
            this.addPokemon.UseVisualStyleBackColor = false;
            this.addPokemon.Click += new System.EventHandler(this.addPokemon_Click);
            // 
            // removePokemon
            // 
            this.removePokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removePokemon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removePokemon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.removePokemon.BorderRadius = 0;
            this.removePokemon.BorderSize = 0;
            this.removePokemon.FlatAppearance.BorderSize = 0;
            this.removePokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePokemon.ForeColor = System.Drawing.Color.White;
            this.removePokemon.Location = new System.Drawing.Point(169, 231);
            this.removePokemon.Name = "removePokemon";
            this.removePokemon.Size = new System.Drawing.Size(160, 70);
            this.removePokemon.TabIndex = 6;
            this.removePokemon.Text = "remove pokemon";
            this.removePokemon.TextColor = System.Drawing.Color.White;
            this.removePokemon.UseVisualStyleBackColor = false;
            // 
            // caughtScreen1
            // 
            this.caughtScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.caughtScreen1.Location = new System.Drawing.Point(339, 5);
            this.caughtScreen1.Name = "caughtScreen1";
            this.caughtScreen1.Size = new System.Drawing.Size(430, 457);
            this.caughtScreen1.TabIndex = 7;
            this.caughtScreen1.Visible = false;
            this.caughtScreen1.Load += new System.EventHandler(this.caughtScreen1_Load);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.closeButton.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.closeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.closeButton.BorderRadius = 45;
            this.closeButton.BorderSize = 0;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(5, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(90, 90);
            this.closeButton.TabIndex = 2;
            this.closeButton.TextColor = System.Drawing.Color.White;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // seenScreen1
            // 
            this.seenScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seenScreen1.Location = new System.Drawing.Point(339, 5);
            this.seenScreen1.Name = "seenScreen1";
            this.seenScreen1.Size = new System.Drawing.Size(430, 457);
            this.seenScreen1.TabIndex = 7;
            this.seenScreen1.Visible = false;
            // 
            // scollerSceen1
            // 
            this.scollerSceen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scollerSceen1.Location = new System.Drawing.Point(339, 5);
            this.scollerSceen1.Name = "scollerSceen1";
            this.scollerSceen1.Size = new System.Drawing.Size(430, 457);
            this.scollerSceen1.TabIndex = 8;
            this.scollerSceen1.Visible = false;
            this.scollerSceen1.Load += new System.EventHandler(this.scollerSceen1_Load);
            // 
            // statsScreen1
            // 
            this.statsScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statsScreen1.Location = new System.Drawing.Point(339, 5);
            this.statsScreen1.Name = "statsScreen1";
            this.statsScreen1.Size = new System.Drawing.Size(430, 457);
            this.statsScreen1.TabIndex = 9;
            this.statsScreen1.Visible = false;
            // 
            // changeStatsScreen1
            // 
            this.changeStatsScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeStatsScreen1.Location = new System.Drawing.Point(339, 5);
            this.changeStatsScreen1.Name = "changeStatsScreen1";
            this.changeStatsScreen1.Size = new System.Drawing.Size(430, 457);
            this.changeStatsScreen1.TabIndex = 7;
            this.changeStatsScreen1.Visible = false;
            // 
            // addPokemon1
            // 
            this.addPokemon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addPokemon1.Location = new System.Drawing.Point(338, 5);
            this.addPokemon1.Name = "addPokemon1";
            this.addPokemon1.Size = new System.Drawing.Size(430, 457);
            this.addPokemon1.TabIndex = 10;
            this.addPokemon1.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.addPokemon1);
            this.Controls.Add(this.statsScreen1);
            this.Controls.Add(this.scollerSceen1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.caughtScreen1);
            this.Controls.Add(this.seenScreen1);
            this.Controls.Add(this.changeStatsScreen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJButton closeButton;
        private CustomControls.RJControls.RJButton scrollPokemon;
        private CustomControls.RJControls.RJButton markCaught;
        private CustomControls.RJControls.RJButton markSeen;
        private CustomControls.RJControls.RJButton veiwStats;
        private CustomControls.RJControls.RJButton editStats;
        private CustomControls.RJControls.RJButton addPokemon;
        private CustomControls.RJControls.RJButton removePokemon;
        private caughtScreen caughtScreen1;
        private seenScreen seenScreen1;
        private scollerSceen scollerSceen1;
        private statsScreen statsScreen1;
        private changeStatsScreen changeStatsScreen1;
        private addPokemon addPokemon1;
    }
}