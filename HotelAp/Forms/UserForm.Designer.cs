namespace HotelAp
{
    partial class UserForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btCountFreePlace = new System.Windows.Forms.Button();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.gbChooseDate = new System.Windows.Forms.GroupBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.gpRange = new System.Windows.Forms.GroupBox();
            this.btDrop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRangEnd = new System.Windows.Forms.TextBox();
            this.tbRangeStart = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheckAndBuy = new System.Windows.Forms.Button();
            this.lbChoosePassport = new System.Windows.Forms.Label();
            this.cbChoosePassrport = new System.Windows.Forms.ComboBox();
            this.dGVFreePlace = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сортироватьПоЦенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьПаспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПаспортToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКлубнуюКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClubCard = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dGVServices = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetService = new System.Windows.Forms.Button();
            this.gbFilters.SuspendLayout();
            this.gbChooseDate.SuspendLayout();
            this.gpRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFreePlace)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServices)).BeginInit();
            this.SuspendLayout();
            // 
            // btCountFreePlace
            // 
            this.btCountFreePlace.Location = new System.Drawing.Point(318, 192);
            this.btCountFreePlace.Margin = new System.Windows.Forms.Padding(2);
            this.btCountFreePlace.Name = "btCountFreePlace";
            this.btCountFreePlace.Size = new System.Drawing.Size(294, 38);
            this.btCountFreePlace.TabIndex = 29;
            this.btCountFreePlace.Text = "Подсчитать свободные места в гостинице на выбранную дату в фильтре";
            this.btCountFreePlace.UseVisualStyleBackColor = true;
            this.btCountFreePlace.Click += new System.EventHandler(this.btCountFreePlace_Click);
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.gbChooseDate);
            this.gbFilters.Controls.Add(this.gpRange);
            this.gbFilters.Location = new System.Drawing.Point(9, 38);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(2);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(2);
            this.gbFilters.Size = new System.Drawing.Size(304, 176);
            this.gbFilters.TabIndex = 28;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Фильтры";
            // 
            // gbChooseDate
            // 
            this.gbChooseDate.Controls.Add(this.dtStartDate);
            this.gbChooseDate.Controls.Add(this.dtEndDate);
            this.gbChooseDate.Location = new System.Drawing.Point(4, 24);
            this.gbChooseDate.Margin = new System.Windows.Forms.Padding(2);
            this.gbChooseDate.Name = "gbChooseDate";
            this.gbChooseDate.Padding = new System.Windows.Forms.Padding(2);
            this.gbChooseDate.Size = new System.Drawing.Size(292, 65);
            this.gbChooseDate.TabIndex = 3;
            this.gbChooseDate.TabStop = false;
            this.gbChooseDate.Text = "Выбрать даты";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(4, 28);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(138, 20);
            this.dtStartDate.TabIndex = 1;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(146, 28);
            this.dtEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(138, 20);
            this.dtEndDate.TabIndex = 2;
            this.dtEndDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            // 
            // gpRange
            // 
            this.gpRange.Controls.Add(this.btDrop);
            this.gpRange.Controls.Add(this.label7);
            this.gpRange.Controls.Add(this.label6);
            this.gpRange.Controls.Add(this.tbRangEnd);
            this.gpRange.Controls.Add(this.tbRangeStart);
            this.gpRange.Controls.Add(this.btSearch);
            this.gpRange.Location = new System.Drawing.Point(9, 94);
            this.gpRange.Margin = new System.Windows.Forms.Padding(2);
            this.gpRange.Name = "gpRange";
            this.gpRange.Padding = new System.Windows.Forms.Padding(2);
            this.gpRange.Size = new System.Drawing.Size(287, 73);
            this.gpRange.TabIndex = 14;
            this.gpRange.TabStop = false;
            this.gpRange.Text = "Поиск по диапозону(по цене):";
            // 
            // btDrop
            // 
            this.btDrop.Location = new System.Drawing.Point(162, 50);
            this.btDrop.Margin = new System.Windows.Forms.Padding(2);
            this.btDrop.Name = "btDrop";
            this.btDrop.Size = new System.Drawing.Size(56, 19);
            this.btDrop.TabIndex = 5;
            this.btDrop.Text = "Сброс";
            this.btDrop.UseVisualStyleBackColor = true;
            this.btDrop.Click += new System.EventHandler(this.btDrop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "По";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "С";
            // 
            // tbRangEnd
            // 
            this.tbRangEnd.Location = new System.Drawing.Point(146, 24);
            this.tbRangEnd.Margin = new System.Windows.Forms.Padding(2);
            this.tbRangEnd.Name = "tbRangEnd";
            this.tbRangEnd.Size = new System.Drawing.Size(76, 20);
            this.tbRangEnd.TabIndex = 2;
            this.tbRangEnd.TextChanged += new System.EventHandler(this.tbRangEnd_TextChanged);
            // 
            // tbRangeStart
            // 
            this.tbRangeStart.Location = new System.Drawing.Point(32, 24);
            this.tbRangeStart.Margin = new System.Windows.Forms.Padding(2);
            this.tbRangeStart.Name = "tbRangeStart";
            this.tbRangeStart.Size = new System.Drawing.Size(76, 20);
            this.tbRangeStart.TabIndex = 1;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(223, 50);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(56, 19);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "Поиск";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 25;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(880, 556);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 28);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheckAndBuy
            // 
            this.btnCheckAndBuy.Location = new System.Drawing.Point(729, 556);
            this.btnCheckAndBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckAndBuy.Name = "btnCheckAndBuy";
            this.btnCheckAndBuy.Size = new System.Drawing.Size(141, 28);
            this.btnCheckAndBuy.TabIndex = 23;
            this.btnCheckAndBuy.Text = "Проверить и купить";
            this.btnCheckAndBuy.UseVisualStyleBackColor = true;
            this.btnCheckAndBuy.Click += new System.EventHandler(this.btnCheckAndBuy_Click);
            // 
            // lbChoosePassport
            // 
            this.lbChoosePassport.AutoSize = true;
            this.lbChoosePassport.Location = new System.Drawing.Point(326, 52);
            this.lbChoosePassport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChoosePassport.Name = "lbChoosePassport";
            this.lbChoosePassport.Size = new System.Drawing.Size(119, 13);
            this.lbChoosePassport.TabIndex = 22;
            this.lbChoosePassport.Text = "Выберите постояльца";
            // 
            // cbChoosePassrport
            // 
            this.cbChoosePassrport.FormattingEnabled = true;
            this.cbChoosePassrport.Location = new System.Drawing.Point(328, 79);
            this.cbChoosePassrport.Margin = new System.Windows.Forms.Padding(2);
            this.cbChoosePassrport.Name = "cbChoosePassrport";
            this.cbChoosePassrport.Size = new System.Drawing.Size(143, 21);
            this.cbChoosePassrport.TabIndex = 7;
            this.cbChoosePassrport.SelectedIndexChanged += new System.EventHandler(this.cbChoosePassrport_SelectedIndexChanged);
            // 
            // dGVFreePlace
            // 
            this.dGVFreePlace.AllowUserToAddRows = false;
            this.dGVFreePlace.AllowUserToDeleteRows = false;
            this.dGVFreePlace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVFreePlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFreePlace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dGVFreePlace.ContextMenuStrip = this.contextMenuStrip1;
            this.dGVFreePlace.Location = new System.Drawing.Point(13, 20);
            this.dGVFreePlace.Margin = new System.Windows.Forms.Padding(2);
            this.dGVFreePlace.Name = "dGVFreePlace";
            this.dGVFreePlace.ReadOnly = true;
            this.dGVFreePlace.RowHeadersWidth = 51;
            this.dGVFreePlace.RowTemplate.Height = 24;
            this.dGVFreePlace.Size = new System.Drawing.Size(896, 269);
            this.dGVFreePlace.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер комнаты";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Тип комнаты";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 91;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Стоимость";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 87;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Скидка";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 69;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Конечная стоимость";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортироватьПоЦенеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 26);
            // 
            // сортироватьПоЦенеToolStripMenuItem
            // 
            this.сортироватьПоЦенеToolStripMenuItem.Name = "сортироватьПоЦенеToolStripMenuItem";
            this.сортироватьПоЦенеToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.сортироватьПоЦенеToolStripMenuItem.Text = "Сортировать по цене";
            this.сортироватьПоЦенеToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоЦенеToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПаспортToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // добавитьПаспортToolStripMenuItem
            // 
            this.добавитьПаспортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПаспортToolStripMenuItem1,
            this.добавитьКлубнуюКартуToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.добавитьПаспортToolStripMenuItem.Name = "добавитьПаспортToolStripMenuItem";
            this.добавитьПаспортToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.добавитьПаспортToolStripMenuItem.Text = "Докуметы";
            // 
            // добавитьПаспортToolStripMenuItem1
            // 
            this.добавитьПаспортToolStripMenuItem1.Name = "добавитьПаспортToolStripMenuItem1";
            this.добавитьПаспортToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.добавитьПаспортToolStripMenuItem1.Text = "Добавить паспорт";
            this.добавитьПаспортToolStripMenuItem1.Click += new System.EventHandler(this.добавитьПаспортToolStripMenuItem1_Click);
            // 
            // добавитьКлубнуюКартуToolStripMenuItem
            // 
            this.добавитьКлубнуюКартуToolStripMenuItem.Name = "добавитьКлубнуюКартуToolStripMenuItem";
            this.добавитьКлубнуюКартуToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.добавитьКлубнуюКартуToolStripMenuItem.Text = "Добавить клубную карту";
            this.добавитьКлубнуюКартуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлубнуюКартуToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.просмотрToolStripMenuItem.Text = "Справка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Клубная карта";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbClubCard
            // 
            this.tbClubCard.Location = new System.Drawing.Point(507, 80);
            this.tbClubCard.Name = "tbClubCard";
            this.tbClubCard.Size = new System.Drawing.Size(100, 20);
            this.tbClubCard.TabIndex = 31;
            this.tbClubCard.Text = "0";
            this.tbClubCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbClubCard_KeyDown);
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(332, 111);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(0, 13);
            this.lbSurname.TabIndex = 32;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(331, 132);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 13);
            this.lbName.TabIndex = 33;
            // 
            // lbSName
            // 
            this.lbSName.AutoSize = true;
            this.lbSName.Location = new System.Drawing.Point(331, 156);
            this.lbSName.Name = "lbSName";
            this.lbSName.Size = new System.Drawing.Size(0, 13);
            this.lbSName.TabIndex = 34;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 231);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 320);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGVFreePlace);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Свободные места";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGetService);
            this.tabPage2.Controls.Add(this.dGVServices);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Услуги";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dGVServices
            // 
            this.dGVServices.AllowUserToAddRows = false;
            this.dGVServices.AllowUserToDeleteRows = false;
            this.dGVServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dGVServices.ContextMenuStrip = this.contextMenuStrip1;
            this.dGVServices.Location = new System.Drawing.Point(1, 5);
            this.dGVServices.Margin = new System.Windows.Forms.Padding(2);
            this.dGVServices.Name = "dGVServices";
            this.dGVServices.ReadOnly = true;
            this.dGVServices.RowHeadersWidth = 51;
            this.dGVServices.RowTemplate.Height = 24;
            this.dGVServices.Size = new System.Drawing.Size(518, 269);
            this.dGVServices.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер услуги";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 94;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 87;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Скидка";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 69;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Конечная стоимость";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // btnGetService
            // 
            this.btnGetService.Location = new System.Drawing.Point(533, 6);
            this.btnGetService.Name = "btnGetService";
            this.btnGetService.Size = new System.Drawing.Size(127, 33);
            this.btnGetService.TabIndex = 22;
            this.btnGetService.Text = "Получить услугу";
            this.btnGetService.UseVisualStyleBackColor = true;
            this.btnGetService.Click += new System.EventHandler(this.btnGetService_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 595);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbSName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.tbClubCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCountFreePlace);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckAndBuy);
            this.Controls.Add(this.lbChoosePassport);
            this.Controls.Add(this.cbChoosePassrport);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.gbFilters.ResumeLayout(false);
            this.gbChooseDate.ResumeLayout(false);
            this.gpRange.ResumeLayout(false);
            this.gpRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFreePlace)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCountFreePlace;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.GroupBox gbChooseDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.GroupBox gpRange;
        private System.Windows.Forms.Button btDrop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRangEnd;
        private System.Windows.Forms.TextBox tbRangeStart;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheckAndBuy;
        private System.Windows.Forms.Label lbChoosePassport;
        private System.Windows.Forms.ComboBox cbChoosePassrport;
        private System.Windows.Forms.DataGridView dGVFreePlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьПаспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПаспортToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClubCard;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоЦенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлубнуюКартуToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dGVServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnGetService;
    }
}

