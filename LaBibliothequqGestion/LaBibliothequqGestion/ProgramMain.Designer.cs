namespace LaBibliothequqGestion
{
    partial class ProgramMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramMain));
            this.AuthorTabPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AuthorsDataGridView = new System.Windows.Forms.DataGridView();
            this.Author_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_Firstame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AuthorAddButton = new System.Windows.Forms.Button();
            this.AuthorDeleteButton = new System.Windows.Forms.Button();
            this.UsertabTage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BookAddButton = new System.Windows.Forms.Button();
            this.BookDeleteButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.OrderTabPage = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.OrderConfirmButton = new System.Windows.Forms.Button();
            this.OrderDeleteButton = new System.Windows.Forms.Button();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_PagesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorTabPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.UsertabTage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.OrderTabPage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorTabPage
            // 
            this.AuthorTabPage.Controls.Add(this.groupBox4);
            this.AuthorTabPage.Controls.Add(this.groupBox1);
            this.AuthorTabPage.Location = new System.Drawing.Point(4, 25);
            this.AuthorTabPage.Name = "AuthorTabPage";
            this.AuthorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AuthorTabPage.Size = new System.Drawing.Size(1250, 499);
            this.AuthorTabPage.TabIndex = 1;
            this.AuthorTabPage.Text = "ავტორები";
            this.AuthorTabPage.UseVisualStyleBackColor = true;
            this.AuthorTabPage.Enter += new System.EventHandler(this.AuthorTabPage_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AuthorsDataGridView);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1244, 344);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // AuthorsDataGridView
            // 
            this.AuthorsDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AuthorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author_ID,
            this.Author_Firstame,
            this.Author_Lastname,
            this.Author_Birthdate});
            this.AuthorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.AuthorsDataGridView.Name = "AuthorsDataGridView";
            this.AuthorsDataGridView.RowTemplate.Height = 24;
            this.AuthorsDataGridView.Size = new System.Drawing.Size(1238, 323);
            this.AuthorsDataGridView.TabIndex = 0;
            this.AuthorsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorsDataGridView_RowEnter);
            // 
            // Author_ID
            // 
            this.Author_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author_ID.HeaderText = "ID";
            this.Author_ID.Name = "Author_ID";
            // 
            // Author_Firstame
            // 
            this.Author_Firstame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author_Firstame.HeaderText = "FirstName";
            this.Author_Firstame.Name = "Author_Firstame";
            // 
            // Author_Lastname
            // 
            this.Author_Lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author_Lastname.HeaderText = "LastName";
            this.Author_Lastname.Name = "Author_Lastname";
            // 
            // Author_Birthdate
            // 
            this.Author_Birthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author_Birthdate.HeaderText = "BirthDate";
            this.Author_Birthdate.Name = "Author_Birthdate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1244, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.AuthorAddButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.AuthorDeleteButton, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1238, 128);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // AuthorAddButton
            // 
            this.AuthorAddButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AuthorAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorAddButton.Location = new System.Drawing.Point(268, 39);
            this.AuthorAddButton.Name = "AuthorAddButton";
            this.AuthorAddButton.Size = new System.Drawing.Size(214, 49);
            this.AuthorAddButton.TabIndex = 0;
            this.AuthorAddButton.Text = "დამატება";
            this.AuthorAddButton.UseVisualStyleBackColor = false;
            this.AuthorAddButton.Click += new System.EventHandler(this.AuthorAddButton_Click);
            // 
            // AuthorDeleteButton
            // 
            this.AuthorDeleteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AuthorDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorDeleteButton.Location = new System.Drawing.Point(754, 39);
            this.AuthorDeleteButton.Name = "AuthorDeleteButton";
            this.AuthorDeleteButton.Size = new System.Drawing.Size(214, 49);
            this.AuthorDeleteButton.TabIndex = 1;
            this.AuthorDeleteButton.Text = "წაშლა";
            this.AuthorDeleteButton.UseVisualStyleBackColor = false;
            this.AuthorDeleteButton.Click += new System.EventHandler(this.AuthorDeleteButton_Click);
            // 
            // UsertabTage
            // 
            this.UsertabTage.Controls.Add(this.groupBox2);
            this.UsertabTage.Controls.Add(this.groupBox3);
            this.UsertabTage.Location = new System.Drawing.Point(4, 25);
            this.UsertabTage.Name = "UsertabTage";
            this.UsertabTage.Padding = new System.Windows.Forms.Padding(3);
            this.UsertabTage.Size = new System.Drawing.Size(1250, 499);
            this.UsertabTage.TabIndex = 0;
            this.UsertabTage.Tag = "+";
            this.UsertabTage.Text = "წიგნები";
            this.UsertabTage.UseVisualStyleBackColor = true;
            this.UsertabTage.Enter += new System.EventHandler(this.UsertabTage_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BooksDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1244, 344);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_ID,
            this.Book_Name,
            this.Book_Description,
            this.Book_PagesCount,
            this.Book_AuthorID,
            this.Book_FirstName,
            this.Book_LastName,
            this.Book_BirthDate});
            this.BooksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksDataGridView.Location = new System.Drawing.Point(3, 18);
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.RowTemplate.Height = 24;
            this.BooksDataGridView.Size = new System.Drawing.Size(1238, 323);
            this.BooksDataGridView.TabIndex = 0;
            this.BooksDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_RowEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(3, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1244, 149);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.BookAddButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BookDeleteButton, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1238, 128);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BookAddButton
            // 
            this.BookAddButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BookAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookAddButton.Location = new System.Drawing.Point(268, 39);
            this.BookAddButton.Name = "BookAddButton";
            this.BookAddButton.Size = new System.Drawing.Size(214, 49);
            this.BookAddButton.TabIndex = 0;
            this.BookAddButton.Text = "დამატება";
            this.BookAddButton.UseVisualStyleBackColor = false;
            this.BookAddButton.Click += new System.EventHandler(this.BookAddButton_Click);
            // 
            // BookDeleteButton
            // 
            this.BookDeleteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BookDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookDeleteButton.Location = new System.Drawing.Point(754, 39);
            this.BookDeleteButton.Name = "BookDeleteButton";
            this.BookDeleteButton.Size = new System.Drawing.Size(214, 49);
            this.BookDeleteButton.TabIndex = 1;
            this.BookDeleteButton.Text = "წაშლა";
            this.BookDeleteButton.UseVisualStyleBackColor = false;
            this.BookDeleteButton.Click += new System.EventHandler(this.BookDeleteButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.OrderTabPage);
            this.tabControl.Controls.Add(this.UsertabTage);
            this.tabControl.Controls.Add(this.AuthorTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1258, 528);
            this.tabControl.TabIndex = 0;
            // 
            // OrderTabPage
            // 
            this.OrderTabPage.Controls.Add(this.groupBox5);
            this.OrderTabPage.Controls.Add(this.groupBox7);
            this.OrderTabPage.Controls.Add(this.groupBox6);
            this.OrderTabPage.Location = new System.Drawing.Point(4, 25);
            this.OrderTabPage.Name = "OrderTabPage";
            this.OrderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTabPage.Size = new System.Drawing.Size(1250, 499);
            this.OrderTabPage.TabIndex = 2;
            this.OrderTabPage.Text = "შეკვეთები";
            this.OrderTabPage.UseVisualStyleBackColor = true;
            this.OrderTabPage.Enter += new System.EventHandler(this.OrderTabPage_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.OrderGridView);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1244, 195);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // OrderGridView
            // 
            this.OrderGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.OrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderGridView.Location = new System.Drawing.Point(3, 18);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowTemplate.Height = 24;
            this.OrderGridView.Size = new System.Drawing.Size(1238, 174);
            this.OrderGridView.TabIndex = 0;
            this.OrderGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGridView_RowEnter);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel4);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(3, 198);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1244, 149);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.SearchButton, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.UserComboBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1238, 128);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchButton.Location = new System.Drawing.Point(755, 39);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(214, 49);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "ძებნა";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UserComboBox
            // 
            this.UserComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(269, 52);
            this.UserComboBox.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(214, 24);
            this.UserComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "მომხმარებელი -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel3);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(3, 347);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1244, 149);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.OrderConfirmButton, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.OrderDeleteButton, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1238, 128);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // OrderConfirmButton
            // 
            this.OrderConfirmButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OrderConfirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderConfirmButton.Location = new System.Drawing.Point(268, 39);
            this.OrderConfirmButton.Name = "OrderConfirmButton";
            this.OrderConfirmButton.Size = new System.Drawing.Size(214, 49);
            this.OrderConfirmButton.TabIndex = 0;
            this.OrderConfirmButton.Text = "დადასტურება";
            this.OrderConfirmButton.UseVisualStyleBackColor = false;
            this.OrderConfirmButton.Click += new System.EventHandler(this.OrderConfirmButton_Click);
            // 
            // OrderDeleteButton
            // 
            this.OrderDeleteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OrderDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDeleteButton.Location = new System.Drawing.Point(754, 39);
            this.OrderDeleteButton.Name = "OrderDeleteButton";
            this.OrderDeleteButton.Size = new System.Drawing.Size(214, 49);
            this.OrderDeleteButton.TabIndex = 1;
            this.OrderDeleteButton.Text = "დასრულება";
            this.OrderDeleteButton.UseVisualStyleBackColor = false;
            this.OrderDeleteButton.Click += new System.EventHandler(this.OrderDeleteButton_Click);
            // 
            // Book_ID
            // 
            this.Book_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book_ID.DataPropertyName = "Book_ID";
            this.Book_ID.HeaderText = "ID";
            this.Book_ID.Name = "Book_ID";
            // 
            // Book_Name
            // 
            this.Book_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book_Name.DataPropertyName = "Name";
            this.Book_Name.HeaderText = "შიგნის სახელი";
            this.Book_Name.Name = "Book_Name";
            // 
            // Book_Description
            // 
            this.Book_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book_Description.DataPropertyName = "Description";
            this.Book_Description.HeaderText = "წიგნის აღწერა";
            this.Book_Description.Name = "Book_Description";
            // 
            // Book_PagesCount
            // 
            this.Book_PagesCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book_PagesCount.DataPropertyName = "PagesCount";
            this.Book_PagesCount.HeaderText = "გვერდების რაოდენობა";
            this.Book_PagesCount.Name = "Book_PagesCount";
            // 
            // Book_AuthorID
            // 
            this.Book_AuthorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book_AuthorID.DataPropertyName = "AuthorID";
            this.Book_AuthorID.HeaderText = "AuthorID";
            this.Book_AuthorID.Name = "Book_AuthorID";
            this.Book_AuthorID.Visible = false;
            // 
            // Book_FirstName
            // 
            this.Book_FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book_FirstName.HeaderText = "FirstName";
            this.Book_FirstName.Name = "Book_FirstName";
            this.Book_FirstName.Visible = false;
            // 
            // Book_LastName
            // 
            this.Book_LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book_LastName.HeaderText = "LastName";
            this.Book_LastName.Name = "Book_LastName";
            this.Book_LastName.Visible = false;
            // 
            // Book_BirthDate
            // 
            this.Book_BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book_BirthDate.HeaderText = "BirthDate";
            this.Book_BirthDate.Name = "Book_BirthDate";
            this.Book_BirthDate.Visible = false;
            // 
            // ProgramMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 528);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProgramMain";
            this.Text = "La Bibliotheque Gestion";
            this.AuthorTabPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.UsertabTage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.OrderTabPage.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage AuthorTabPage;
        private System.Windows.Forms.TabPage UsertabTage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BookAddButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BookDeleteButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView AuthorsDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AuthorAddButton;
        private System.Windows.Forms.Button AuthorDeleteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage OrderTabPage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button OrderConfirmButton;
        private System.Windows.Forms.Button OrderDeleteButton;
        private System.Windows.Forms.DataGridView BooksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_Firstame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_Birthdate;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_PagesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_BirthDate;
    }
}

