namespace HotelAp
{
    partial class DocumentAdd
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
            this.btClose = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.gbPassport = new System.Windows.Forms.GroupBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFullName = new System.Windows.Forms.GroupBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPassport.SuspendLayout();
            this.gbFullName.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(472, 176);
            this.btClose.Margin = new System.Windows.Forms.Padding(2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 19);
            this.btClose.TabIndex = 10;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(384, 176);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(84, 19);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Записать";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // gbPassport
            // 
            this.gbPassport.Controls.Add(this.tbPassport);
            this.gbPassport.Controls.Add(this.label4);
            this.gbPassport.Location = new System.Drawing.Point(269, 11);
            this.gbPassport.Margin = new System.Windows.Forms.Padding(2);
            this.gbPassport.Name = "gbPassport";
            this.gbPassport.Padding = new System.Windows.Forms.Padding(2);
            this.gbPassport.Size = new System.Drawing.Size(278, 136);
            this.gbPassport.TabIndex = 8;
            this.gbPassport.TabStop = false;
            this.gbPassport.Text = "Серия и номер";
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(115, 25);
            this.tbPassport.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(138, 20);
            this.tbPassport.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Серия и номер";
            // 
            // gbFullName
            // 
            this.gbFullName.Controls.Add(this.tbSecondName);
            this.gbFullName.Controls.Add(this.tbFirstName);
            this.gbFullName.Controls.Add(this.tbLastName);
            this.gbFullName.Controls.Add(this.label1);
            this.gbFullName.Controls.Add(this.label3);
            this.gbFullName.Controls.Add(this.label2);
            this.gbFullName.Location = new System.Drawing.Point(11, 11);
            this.gbFullName.Margin = new System.Windows.Forms.Padding(2);
            this.gbFullName.Name = "gbFullName";
            this.gbFullName.Padding = new System.Windows.Forms.Padding(2);
            this.gbFullName.Size = new System.Drawing.Size(254, 136);
            this.gbFullName.TabIndex = 7;
            this.gbFullName.TabStop = false;
            this.gbFullName.Text = "ФИО";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(73, 90);
            this.tbSecondName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(131, 20);
            this.tbSecondName.TabIndex = 5;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(73, 25);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(131, 20);
            this.tbFirstName.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(73, 58);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(131, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Очество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // DocumentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 209);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.gbPassport);
            this.Controls.Add(this.gbFullName);
            this.Name = "DocumentAdd";
            this.Text = "DocumentAdd";
            this.gbPassport.ResumeLayout(false);
            this.gbPassport.PerformLayout();
            this.gbFullName.ResumeLayout(false);
            this.gbFullName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox gbPassport;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbFullName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}