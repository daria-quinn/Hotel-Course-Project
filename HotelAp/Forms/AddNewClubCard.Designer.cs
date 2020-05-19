namespace HotelAp.Forms
{
    partial class Add_New_Club_Card
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
            this.lbCardID = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.tbCardID = new System.Windows.Forms.TextBox();
            this.tbCardDiscount = new System.Windows.Forms.TextBox();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.btnCloseAddNewClubCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCardID
            // 
            this.lbCardID.AutoSize = true;
            this.lbCardID.Location = new System.Drawing.Point(28, 48);
            this.lbCardID.Name = "lbCardID";
            this.lbCardID.Size = new System.Drawing.Size(119, 13);
            this.lbCardID.TabIndex = 0;
            this.lbCardID.Text = "Номер клубной карты";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(28, 79);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(91, 13);
            this.lbDiscount.TabIndex = 1;
            this.lbDiscount.Text = "Скидка по карте";
            // 
            // tbCardID
            // 
            this.tbCardID.Location = new System.Drawing.Point(177, 48);
            this.tbCardID.Name = "tbCardID";
            this.tbCardID.Size = new System.Drawing.Size(136, 20);
            this.tbCardID.TabIndex = 2;
            // 
            // tbCardDiscount
            // 
            this.tbCardDiscount.Location = new System.Drawing.Point(177, 79);
            this.tbCardDiscount.Name = "tbCardDiscount";
            this.tbCardDiscount.Size = new System.Drawing.Size(136, 20);
            this.tbCardDiscount.TabIndex = 3;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(293, 135);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(75, 23);
            this.btnAddCard.TabIndex = 4;
            this.btnAddCard.Text = "Добавить";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // btnCloseAddNewClubCard
            // 
            this.btnCloseAddNewClubCard.Location = new System.Drawing.Point(374, 135);
            this.btnCloseAddNewClubCard.Name = "btnCloseAddNewClubCard";
            this.btnCloseAddNewClubCard.Size = new System.Drawing.Size(75, 23);
            this.btnCloseAddNewClubCard.TabIndex = 5;
            this.btnCloseAddNewClubCard.Text = "Закрыть";
            this.btnCloseAddNewClubCard.UseVisualStyleBackColor = true;
            this.btnCloseAddNewClubCard.Click += new System.EventHandler(this.btnCloseAddNewClubCard_Click);
            // 
            // Add_New_Club_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 181);
            this.Controls.Add(this.btnCloseAddNewClubCard);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.tbCardDiscount);
            this.Controls.Add(this.tbCardID);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbCardID);
            this.Name = "Add_New_Club_Card";
            this.Text = "Добавление новой клубной карты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCardID;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.TextBox tbCardID;
        private System.Windows.Forms.TextBox tbCardDiscount;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Button btnCloseAddNewClubCard;
    }
}