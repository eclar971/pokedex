namespace pokedex
{
    partial class statsScreen
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
            this.statsPic = new CustomControls.RJControls.RJCircularPictureBox();
            this.name = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.defense = new System.Windows.Forms.Label();
            this.specialDefense = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.attack = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.specialAttack = new System.Windows.Forms.Label();
            this.totalStats = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // statsPic
            // 
            this.statsPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.statsPic.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.statsPic.BorderColor2 = System.Drawing.Color.DeepSkyBlue;
            this.statsPic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.statsPic.BorderSize = 2;
            this.statsPic.GradientAngle = 50F;
            this.statsPic.Location = new System.Drawing.Point(0, 0);
            this.statsPic.Name = "statsPic";
            this.statsPic.Size = new System.Drawing.Size(217, 217);
            this.statsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statsPic.TabIndex = 0;
            this.statsPic.TabStop = false;
            this.statsPic.Click += new System.EventHandler(this.statsPic_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(223, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(114, 17);
            this.name.TabIndex = 1;
            this.name.Text = "Pokemon name: ";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.Color.White;
            this.number.Location = new System.Drawing.Point(230, 64);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(20, 17);
            this.number.TabIndex = 2;
            this.number.Text = "#:";
            // 
            // defense
            // 
            this.defense.AutoSize = true;
            this.defense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defense.ForeColor = System.Drawing.Color.White;
            this.defense.Location = new System.Drawing.Point(3, 305);
            this.defense.Name = "defense";
            this.defense.Size = new System.Drawing.Size(65, 17);
            this.defense.TabIndex = 3;
            this.defense.Text = "Defense:";
            // 
            // specialDefense
            // 
            this.specialDefense.AutoSize = true;
            this.specialDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialDefense.ForeColor = System.Drawing.Color.White;
            this.specialDefense.Location = new System.Drawing.Point(3, 378);
            this.specialDefense.Name = "specialDefense";
            this.specialDefense.Size = new System.Drawing.Size(59, 17);
            this.specialDefense.TabIndex = 4;
            this.specialDefense.Text = "Sp. Def:";
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp.ForeColor = System.Drawing.Color.White;
            this.hp.Location = new System.Drawing.Point(3, 230);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(30, 17);
            this.hp.TabIndex = 5;
            this.hp.Text = "Hp:";
            // 
            // attack
            // 
            this.attack.AutoSize = true;
            this.attack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attack.ForeColor = System.Drawing.Color.White;
            this.attack.Location = new System.Drawing.Point(230, 230);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(51, 17);
            this.attack.TabIndex = 8;
            this.attack.Text = "Attack:";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.ForeColor = System.Drawing.Color.White;
            this.speed.Location = new System.Drawing.Point(230, 378);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(53, 17);
            this.speed.TabIndex = 7;
            this.speed.Text = "Speed:";
            // 
            // specialAttack
            // 
            this.specialAttack.AutoSize = true;
            this.specialAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialAttack.ForeColor = System.Drawing.Color.White;
            this.specialAttack.Location = new System.Drawing.Point(230, 305);
            this.specialAttack.Name = "specialAttack";
            this.specialAttack.Size = new System.Drawing.Size(57, 17);
            this.specialAttack.TabIndex = 6;
            this.specialAttack.Text = "Sp. Atk:";
            // 
            // totalStats
            // 
            this.totalStats.AutoSize = true;
            this.totalStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStats.ForeColor = System.Drawing.Color.White;
            this.totalStats.Location = new System.Drawing.Point(182, 420);
            this.totalStats.Name = "totalStats";
            this.totalStats.Size = new System.Drawing.Size(78, 17);
            this.totalStats.TabIndex = 9;
            this.totalStats.Text = "Total stats:";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.Color.White;
            this.type.Location = new System.Drawing.Point(230, 121);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(44, 17);
            this.type.TabIndex = 10;
            this.type.Text = "Type:";
            // 
            // statsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.type);
            this.Controls.Add(this.totalStats);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.specialAttack);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.specialDefense);
            this.Controls.Add(this.defense);
            this.Controls.Add(this.number);
            this.Controls.Add(this.name);
            this.Controls.Add(this.statsPic);
            this.Name = "statsScreen";
            this.Size = new System.Drawing.Size(430, 457);
            this.Load += new System.EventHandler(this.statsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statsPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox statsPic;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label defense;
        private System.Windows.Forms.Label specialDefense;
        private System.Windows.Forms.Label hp;
        private System.Windows.Forms.Label attack;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label specialAttack;
        private System.Windows.Forms.Label totalStats;
        private System.Windows.Forms.Label type;
    }
}
