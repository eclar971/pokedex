namespace pokedex
{
    partial class search
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextinput = new CustomControls.RJControls.RJTextBox();
            this.searchData = new CustomControls.RJControls.RJButton();
            this.searchVeiw = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchVeiw)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.searchLabel);
            this.flowLayoutPanel1.Controls.Add(this.searchTextinput);
            this.flowLayoutPanel1.Controls.Add(this.searchData);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 61);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(3, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(242, 17);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Type the item you want to search for:";
            // 
            // searchTextinput
            // 
            this.searchTextinput.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchTextinput.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.searchTextinput.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.searchTextinput.BorderSize = 2;
            this.searchTextinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextinput.ForeColor = System.Drawing.Color.DimGray;
            this.searchTextinput.Location = new System.Drawing.Point(4, 21);
            this.searchTextinput.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextinput.Multiline = false;
            this.searchTextinput.Name = "searchTextinput";
            this.searchTextinput.Padding = new System.Windows.Forms.Padding(7);
            this.searchTextinput.PasswordChar = false;
            this.searchTextinput.Size = new System.Drawing.Size(192, 32);
            this.searchTextinput.TabIndex = 7;
            this.searchTextinput.Texts = "";
            this.searchTextinput.UnderlinedStyle = false;
            this.searchTextinput._TextChanged += new System.EventHandler(this.searchTextinput__TextChanged);
            // 
            // searchData
            // 
            this.searchData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchData.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchData.BorderRadius = 0;
            this.searchData.BorderSize = 0;
            this.searchData.FlatAppearance.BorderSize = 0;
            this.searchData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchData.ForeColor = System.Drawing.Color.White;
            this.searchData.Location = new System.Drawing.Point(203, 20);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(68, 33);
            this.searchData.TabIndex = 2;
            this.searchData.Text = "Search";
            this.searchData.TextColor = System.Drawing.Color.White;
            this.searchData.UseVisualStyleBackColor = false;
            this.searchData.Click += new System.EventHandler(this.searchData_Click);
            // 
            // searchVeiw
            // 
            this.searchVeiw.AllowUserToAddRows = false;
            this.searchVeiw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchVeiw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchVeiw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchVeiw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchVeiw.Location = new System.Drawing.Point(0, 59);
            this.searchVeiw.MultiSelect = false;
            this.searchVeiw.Name = "searchVeiw";
            this.searchVeiw.ReadOnly = true;
            this.searchVeiw.RowHeadersVisible = false;
            this.searchVeiw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.searchVeiw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.searchVeiw.ShowCellErrors = false;
            this.searchVeiw.ShowCellToolTips = false;
            this.searchVeiw.ShowEditingIcon = false;
            this.searchVeiw.ShowRowErrors = false;
            this.searchVeiw.Size = new System.Drawing.Size(284, 359);
            this.searchVeiw.TabIndex = 3;
            this.searchVeiw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(284, 418);
            this.Controls.Add(this.searchVeiw);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "search";
            this.Text = "search box";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchVeiw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label searchLabel;
        private CustomControls.RJControls.RJTextBox searchTextinput;
        private CustomControls.RJControls.RJButton searchData;
        private System.Windows.Forms.DataGridView searchVeiw;
    }
}