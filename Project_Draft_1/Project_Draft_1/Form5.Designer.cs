namespace Project_Draft_1
{
    partial class Form5
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
            this.dataViewTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.QNmud = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameCmbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typeCmbx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSf = new System.Windows.Forms.Label();
            this.lblDp = new System.Windows.Forms.Label();
            this.lblTp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.CCrdbtn = new System.Windows.Forms.RadioButton();
            this.OBrdbtn = new System.Windows.Forms.RadioButton();
            this.CODrdBtn = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QNmud)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataViewTable
            // 
            this.dataViewTable.BackColor = System.Drawing.Color.Black;
            this.dataViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.dataViewTable.Font = new System.Drawing.Font("Tecnico", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataViewTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataViewTable.Location = new System.Drawing.Point(278, 156);
            this.dataViewTable.Name = "dataViewTable";
            this.dataViewTable.Size = new System.Drawing.Size(717, 501);
            this.dataViewTable.TabIndex = 0;
            this.dataViewTable.UseCompatibleStateImageBehavior = false;
            this.dataViewTable.View = System.Windows.Forms.View.Details;
            this.dataViewTable.SelectedIndexChanged += new System.EventHandler(this.DataViewTable_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BRAND";
            this.columnHeader1.Width = 233;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TYPE";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "QUANTITY";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PRICE";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TOTAL PRICE";
            this.columnHeader5.Width = 147;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.QNmud);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nameCmbx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.typeCmbx);
            this.panel1.Font = new System.Drawing.Font("Tecnico", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(278, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 138);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(598, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 97);
            this.button4.TabIndex = 13;
            this.button4.Text = "EDIT ITEM";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // QNmud
            // 
            this.QNmud.BackColor = System.Drawing.Color.DarkGray;
            this.QNmud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QNmud.Font = new System.Drawing.Font("Tecnico", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QNmud.Location = new System.Drawing.Point(479, 19);
            this.QNmud.Name = "QNmud";
            this.QNmud.Size = new System.Drawing.Size(68, 31);
            this.QNmud.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tecnico", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(370, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tecnico", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(20, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "BRAND";
            // 
            // nameCmbx
            // 
            this.nameCmbx.BackColor = System.Drawing.Color.DimGray;
            this.nameCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameCmbx.Font = new System.Drawing.Font("Tecnico", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCmbx.ForeColor = System.Drawing.Color.Black;
            this.nameCmbx.FormattingEnabled = true;
            this.nameCmbx.Location = new System.Drawing.Point(153, 75);
            this.nameCmbx.Name = "nameCmbx";
            this.nameCmbx.Size = new System.Drawing.Size(307, 34);
            this.nameCmbx.TabIndex = 9;
            this.nameCmbx.SelectedIndexChanged += new System.EventHandler(this.NameCmbx_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tecnico", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(20, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "CATEGORY";
            // 
            // typeCmbx
            // 
            this.typeCmbx.BackColor = System.Drawing.Color.DimGray;
            this.typeCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCmbx.Font = new System.Drawing.Font("Tecnico", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCmbx.FormattingEnabled = true;
            this.typeCmbx.Location = new System.Drawing.Point(154, 16);
            this.typeCmbx.Name = "typeCmbx";
            this.typeCmbx.Size = new System.Drawing.Size(210, 34);
            this.typeCmbx.TabIndex = 7;
            this.typeCmbx.SelectedIndexChanged += new System.EventHandler(this.TypeCmbx_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tecnico", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(50, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblSf);
            this.panel2.Controls.Add(this.lblDp);
            this.panel2.Controls.Add(this.lblTp);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.CCrdbtn);
            this.panel2.Controls.Add(this.OBrdbtn);
            this.panel2.Controls.Add(this.CODrdBtn);
            this.panel2.Font = new System.Drawing.Font("Tecnico", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(12, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 501);
            this.panel2.TabIndex = 2;
            // 
            // lblSf
            // 
            this.lblSf.AutoSize = true;
            this.lblSf.Font = new System.Drawing.Font("Tecnico", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSf.ForeColor = System.Drawing.Color.Lime;
            this.lblSf.Location = new System.Drawing.Point(48, 376);
            this.lblSf.Name = "lblSf";
            this.lblSf.Size = new System.Drawing.Size(136, 20);
            this.lblSf.TabIndex = 10;
            this.lblSf.Text = "Total Purchased";
            // 
            // lblDp
            // 
            this.lblDp.AutoSize = true;
            this.lblDp.Font = new System.Drawing.Font("Tecnico", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDp.ForeColor = System.Drawing.Color.Lime;
            this.lblDp.Location = new System.Drawing.Point(48, 309);
            this.lblDp.Name = "lblDp";
            this.lblDp.Size = new System.Drawing.Size(136, 20);
            this.lblDp.TabIndex = 9;
            this.lblDp.Text = "Total Purchased";
            // 
            // lblTp
            // 
            this.lblTp.AutoSize = true;
            this.lblTp.Font = new System.Drawing.Font("Tecnico", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTp.ForeColor = System.Drawing.Color.Lime;
            this.lblTp.Location = new System.Drawing.Point(48, 241);
            this.lblTp.Name = "lblTp";
            this.lblTp.Size = new System.Drawing.Size(136, 20);
            this.lblTp.TabIndex = 8;
            this.lblTp.Text = "Total Purchased";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(21, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Shipping Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(21, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discounted Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(21, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Purchased";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tecnico", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "MODE OF PAYMENT";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(36, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "DELIVER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // CCrdbtn
            // 
            this.CCrdbtn.AutoSize = true;
            this.CCrdbtn.ForeColor = System.Drawing.Color.Lime;
            this.CCrdbtn.Location = new System.Drawing.Point(25, 151);
            this.CCrdbtn.Name = "CCrdbtn";
            this.CCrdbtn.Size = new System.Drawing.Size(114, 24);
            this.CCrdbtn.TabIndex = 2;
            this.CCrdbtn.TabStop = true;
            this.CCrdbtn.Text = "Credit Card";
            this.CCrdbtn.UseVisualStyleBackColor = true;
            this.CCrdbtn.CheckedChanged += new System.EventHandler(this.CCrdbtn_CheckedChanged);
            // 
            // OBrdbtn
            // 
            this.OBrdbtn.AutoSize = true;
            this.OBrdbtn.ForeColor = System.Drawing.Color.Lime;
            this.OBrdbtn.Location = new System.Drawing.Point(25, 111);
            this.OBrdbtn.Name = "OBrdbtn";
            this.OBrdbtn.Size = new System.Drawing.Size(119, 24);
            this.OBrdbtn.TabIndex = 1;
            this.OBrdbtn.TabStop = true;
            this.OBrdbtn.Text = "Online Bank";
            this.OBrdbtn.UseVisualStyleBackColor = true;
            this.OBrdbtn.CheckedChanged += new System.EventHandler(this.OBrdbtn_CheckedChanged);
            // 
            // CODrdBtn
            // 
            this.CODrdBtn.AutoSize = true;
            this.CODrdBtn.ForeColor = System.Drawing.Color.Lime;
            this.CODrdBtn.Location = new System.Drawing.Point(25, 72);
            this.CODrdBtn.Name = "CODrdBtn";
            this.CODrdBtn.Size = new System.Drawing.Size(59, 24);
            this.CODrdBtn.TabIndex = 0;
            this.CODrdBtn.TabStop = true;
            this.CODrdBtn.Text = "COD";
            this.CODrdBtn.UseVisualStyleBackColor = true;
            this.CODrdBtn.CheckedChanged += new System.EventHandler(this.CODrdBtn_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(151, 667);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Discounts are only applicable for Premium Accounts";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1007, 689);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataViewTable);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QNmud)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dataViewTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton CCrdbtn;
        private System.Windows.Forms.RadioButton OBrdbtn;
        private System.Windows.Forms.RadioButton CODrdBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown QNmud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox nameCmbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typeCmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSf;
        private System.Windows.Forms.Label lblDp;
        private System.Windows.Forms.Label lblTp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}