namespace InventoryManager
{
    partial class Form1
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.currentItemLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.platformLbl = new System.Windows.Forms.Label();
            this.releaseYearLbl = new System.Windows.Forms.Label();
            this.typeSpecific1Lbl = new System.Windows.Forms.Label();
            this.typeSpecific2Lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTypeLbl = new System.Windows.Forms.Label();
            this.searchTitleLbl = new System.Windows.Forms.Label();
            this.searchTitleTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.currTitleTxt = new System.Windows.Forms.TextBox();
            this.currCostTxt = new System.Windows.Forms.TextBox();
            this.currReleasedTxt = new System.Windows.Forms.TextBox();
            this.currTypeSpecific1Txt = new System.Windows.Forms.TextBox();
            this.currTypeSpecific2Txt = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Search = new System.Windows.Forms.TabPage();
            this.searchPlatformComboBox = new System.Windows.Forms.ComboBox();
            this.Modify = new System.Windows.Forms.TabPage();
            this.infoGenreComboBox = new System.Windows.Forms.ComboBox();
            this.infoPlatformComboBox = new System.Windows.Forms.ComboBox();
            this.infoTypeComboBox = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.TabPage();
            this.addGenreComboBox = new System.Windows.Forms.ComboBox();
            this.addPlatformComboBox = new System.Windows.Forms.ComboBox();
            this.addTypeSpecific2Lbl = new System.Windows.Forms.Label();
            this.addTypeSpecific1Lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.addTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addTypeSpecific2Box = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.addTypeSpecific1Box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addReleasedBox = new System.Windows.Forms.TextBox();
            this.addCostBox = new System.Windows.Forms.TextBox();
            this.addTitleBox = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.TabPage();
            this.filterPlatformComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.filterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.filterTitleTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Search.SuspendLayout();
            this.Modify.SuspendLayout();
            this.Add.SuspendLayout();
            this.Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(103, 240);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(125, 58);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Get Item";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // currentItemLbl
            // 
            this.currentItemLbl.AutoSize = true;
            this.currentItemLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentItemLbl.ForeColor = System.Drawing.Color.Black;
            this.currentItemLbl.Location = new System.Drawing.Point(75, 15);
            this.currentItemLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentItemLbl.Name = "currentItemLbl";
            this.currentItemLbl.Size = new System.Drawing.Size(178, 33);
            this.currentItemLbl.TabIndex = 2;
            this.currentItemLbl.Text = "Modify Item";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.Location = new System.Drawing.Point(25, 73);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(55, 20);
            this.typeLbl.TabIndex = 6;
            this.typeLbl.Text = "Type:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(25, 102);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(55, 20);
            this.titleLbl.TabIndex = 7;
            this.titleLbl.Text = "Title: ";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLbl.Location = new System.Drawing.Point(25, 132);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(52, 20);
            this.costLbl.TabIndex = 8;
            this.costLbl.Text = "Cost:";
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLbl.Location = new System.Drawing.Point(25, 161);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(64, 20);
            this.genreLbl.TabIndex = 9;
            this.genreLbl.Text = "Genre:";
            // 
            // platformLbl
            // 
            this.platformLbl.AutoSize = true;
            this.platformLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLbl.Location = new System.Drawing.Point(25, 191);
            this.platformLbl.Name = "platformLbl";
            this.platformLbl.Size = new System.Drawing.Size(88, 20);
            this.platformLbl.TabIndex = 10;
            this.platformLbl.Text = "Platform: ";
            // 
            // releaseYearLbl
            // 
            this.releaseYearLbl.AutoSize = true;
            this.releaseYearLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseYearLbl.Location = new System.Drawing.Point(25, 220);
            this.releaseYearLbl.Name = "releaseYearLbl";
            this.releaseYearLbl.Size = new System.Drawing.Size(95, 20);
            this.releaseYearLbl.TabIndex = 11;
            this.releaseYearLbl.Text = "Released: ";
            // 
            // typeSpecific1Lbl
            // 
            this.typeSpecific1Lbl.AutoSize = true;
            this.typeSpecific1Lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeSpecific1Lbl.Location = new System.Drawing.Point(25, 250);
            this.typeSpecific1Lbl.Name = "typeSpecific1Lbl";
            this.typeSpecific1Lbl.Size = new System.Drawing.Size(56, 20);
            this.typeSpecific1Lbl.TabIndex = 12;
            this.typeSpecific1Lbl.Text = "Misc: ";
            // 
            // typeSpecific2Lbl
            // 
            this.typeSpecific2Lbl.AutoSize = true;
            this.typeSpecific2Lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeSpecific2Lbl.Location = new System.Drawing.Point(25, 282);
            this.typeSpecific2Lbl.Name = "typeSpecific2Lbl";
            this.typeSpecific2Lbl.Size = new System.Drawing.Size(56, 20);
            this.typeSpecific2Lbl.TabIndex = 13;
            this.typeSpecific2Lbl.Text = "Misc: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search";
            // 
            // searchTypeLbl
            // 
            this.searchTypeLbl.AutoSize = true;
            this.searchTypeLbl.BackColor = System.Drawing.Color.Transparent;
            this.searchTypeLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTypeLbl.Location = new System.Drawing.Point(20, 76);
            this.searchTypeLbl.Name = "searchTypeLbl";
            this.searchTypeLbl.Size = new System.Drawing.Size(95, 32);
            this.searchTypeLbl.TabIndex = 15;
            this.searchTypeLbl.Text = "Type: ";
            // 
            // searchTitleLbl
            // 
            this.searchTitleLbl.AutoSize = true;
            this.searchTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.searchTitleLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitleLbl.Location = new System.Drawing.Point(20, 128);
            this.searchTitleLbl.Name = "searchTitleLbl";
            this.searchTitleLbl.Size = new System.Drawing.Size(80, 32);
            this.searchTitleLbl.TabIndex = 17;
            this.searchTitleLbl.Text = "Title:";
            // 
            // searchTitleTxt
            // 
            this.searchTitleTxt.Location = new System.Drawing.Point(159, 133);
            this.searchTitleTxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchTitleTxt.Name = "searchTitleTxt";
            this.searchTitleTxt.Size = new System.Drawing.Size(141, 22);
            this.searchTitleTxt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Platform: ";
            // 
            // currTitleTxt
            // 
            this.currTitleTxt.Location = new System.Drawing.Point(127, 101);
            this.currTitleTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currTitleTxt.Name = "currTitleTxt";
            this.currTitleTxt.Size = new System.Drawing.Size(163, 22);
            this.currTitleTxt.TabIndex = 22;
            // 
            // currCostTxt
            // 
            this.currCostTxt.Location = new System.Drawing.Point(127, 130);
            this.currCostTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currCostTxt.Name = "currCostTxt";
            this.currCostTxt.Size = new System.Drawing.Size(163, 22);
            this.currCostTxt.TabIndex = 23;
            // 
            // currReleasedTxt
            // 
            this.currReleasedTxt.Location = new System.Drawing.Point(127, 219);
            this.currReleasedTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currReleasedTxt.Name = "currReleasedTxt";
            this.currReleasedTxt.Size = new System.Drawing.Size(163, 22);
            this.currReleasedTxt.TabIndex = 26;
            // 
            // currTypeSpecific1Txt
            // 
            this.currTypeSpecific1Txt.Location = new System.Drawing.Point(127, 249);
            this.currTypeSpecific1Txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currTypeSpecific1Txt.Name = "currTypeSpecific1Txt";
            this.currTypeSpecific1Txt.Size = new System.Drawing.Size(163, 22);
            this.currTypeSpecific1Txt.TabIndex = 27;
            // 
            // currTypeSpecific2Txt
            // 
            this.currTypeSpecific2Txt.Location = new System.Drawing.Point(127, 278);
            this.currTypeSpecific2Txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currTypeSpecific2Txt.Name = "currTypeSpecific2Txt";
            this.currTypeSpecific2Txt.Size = new System.Drawing.Size(163, 22);
            this.currTypeSpecific2Txt.TabIndex = 28;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(180, 325);
            this.delBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(124, 65);
            this.delBtn.TabIndex = 29;
            this.delBtn.Text = "Delete Item";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(33, 325);
            this.saveChangesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(125, 65);
            this.saveChangesBtn.TabIndex = 30;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.CausesValidation = false;
            this.searchTypeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Location = new System.Drawing.Point(159, 84);
            this.searchTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(141, 24);
            this.searchTypeComboBox.TabIndex = 49;
            this.searchTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.searchTypeComboBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Search);
            this.tabControl1.Controls.Add(this.Modify);
            this.tabControl1.Controls.Add(this.Add);
            this.tabControl1.Controls.Add(this.Filter);
            this.tabControl1.Location = new System.Drawing.Point(16, 111);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 485);
            this.tabControl1.TabIndex = 50;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.BackgroundImage = global::InventoryManager.Properties.Resources.tab2;
            this.Search.Controls.Add(this.searchPlatformComboBox);
            this.Search.Controls.Add(this.label1);
            this.Search.Controls.Add(this.searchTypeComboBox);
            this.Search.Controls.Add(this.searchBtn);
            this.Search.Controls.Add(this.searchTypeLbl);
            this.Search.Controls.Add(this.searchTitleTxt);
            this.Search.Controls.Add(this.searchTitleLbl);
            this.Search.Controls.Add(this.label6);
            this.Search.Location = new System.Drawing.Point(4, 25);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(4);
            this.Search.Size = new System.Drawing.Size(329, 456);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            // 
            // searchPlatformComboBox
            // 
            this.searchPlatformComboBox.CausesValidation = false;
            this.searchPlatformComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchPlatformComboBox.FormattingEnabled = true;
            this.searchPlatformComboBox.Location = new System.Drawing.Point(159, 186);
            this.searchPlatformComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchPlatformComboBox.Name = "searchPlatformComboBox";
            this.searchPlatformComboBox.Size = new System.Drawing.Size(141, 24);
            this.searchPlatformComboBox.TabIndex = 50;
            // 
            // Modify
            // 
            this.Modify.BackgroundImage = global::InventoryManager.Properties.Resources.tab2;
            this.Modify.Controls.Add(this.infoGenreComboBox);
            this.Modify.Controls.Add(this.infoPlatformComboBox);
            this.Modify.Controls.Add(this.infoTypeComboBox);
            this.Modify.Controls.Add(this.currentItemLbl);
            this.Modify.Controls.Add(this.typeLbl);
            this.Modify.Controls.Add(this.titleLbl);
            this.Modify.Controls.Add(this.costLbl);
            this.Modify.Controls.Add(this.genreLbl);
            this.Modify.Controls.Add(this.platformLbl);
            this.Modify.Controls.Add(this.releaseYearLbl);
            this.Modify.Controls.Add(this.typeSpecific1Lbl);
            this.Modify.Controls.Add(this.typeSpecific2Lbl);
            this.Modify.Controls.Add(this.currTitleTxt);
            this.Modify.Controls.Add(this.currCostTxt);
            this.Modify.Controls.Add(this.currReleasedTxt);
            this.Modify.Controls.Add(this.currTypeSpecific1Txt);
            this.Modify.Controls.Add(this.currTypeSpecific2Txt);
            this.Modify.Controls.Add(this.delBtn);
            this.Modify.Controls.Add(this.saveChangesBtn);
            this.Modify.Location = new System.Drawing.Point(4, 25);
            this.Modify.Margin = new System.Windows.Forms.Padding(4);
            this.Modify.Name = "Modify";
            this.Modify.Padding = new System.Windows.Forms.Padding(4);
            this.Modify.Size = new System.Drawing.Size(329, 456);
            this.Modify.TabIndex = 1;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            // 
            // infoGenreComboBox
            // 
            this.infoGenreComboBox.FormattingEnabled = true;
            this.infoGenreComboBox.Location = new System.Drawing.Point(127, 160);
            this.infoGenreComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoGenreComboBox.Name = "infoGenreComboBox";
            this.infoGenreComboBox.Size = new System.Drawing.Size(163, 24);
            this.infoGenreComboBox.TabIndex = 33;
            // 
            // infoPlatformComboBox
            // 
            this.infoPlatformComboBox.FormattingEnabled = true;
            this.infoPlatformComboBox.Location = new System.Drawing.Point(127, 190);
            this.infoPlatformComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoPlatformComboBox.Name = "infoPlatformComboBox";
            this.infoPlatformComboBox.Size = new System.Drawing.Size(163, 24);
            this.infoPlatformComboBox.TabIndex = 32;
            // 
            // infoTypeComboBox
            // 
            this.infoTypeComboBox.FormattingEnabled = true;
            this.infoTypeComboBox.Location = new System.Drawing.Point(127, 70);
            this.infoTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoTypeComboBox.Name = "infoTypeComboBox";
            this.infoTypeComboBox.Size = new System.Drawing.Size(163, 24);
            this.infoTypeComboBox.TabIndex = 31;
            this.infoTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.infoTypeComboBox_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.BackgroundImage = global::InventoryManager.Properties.Resources.tab2;
            this.Add.Controls.Add(this.addGenreComboBox);
            this.Add.Controls.Add(this.addPlatformComboBox);
            this.Add.Controls.Add(this.addTypeSpecific2Lbl);
            this.Add.Controls.Add(this.addTypeSpecific1Lbl);
            this.Add.Controls.Add(this.label2);
            this.Add.Controls.Add(this.label3);
            this.Add.Controls.Add(this.label4);
            this.Add.Controls.Add(this.label5);
            this.Add.Controls.Add(this.label7);
            this.Add.Controls.Add(this.label8);
            this.Add.Controls.Add(this.label18);
            this.Add.Controls.Add(this.addTypeComboBox);
            this.Add.Controls.Add(this.label11);
            this.Add.Controls.Add(this.addTypeSpecific2Box);
            this.Add.Controls.Add(this.addBtn);
            this.Add.Controls.Add(this.addTypeSpecific1Box);
            this.Add.Controls.Add(this.label10);
            this.Add.Controls.Add(this.addReleasedBox);
            this.Add.Controls.Add(this.addCostBox);
            this.Add.Controls.Add(this.addTitleBox);
            this.Add.Location = new System.Drawing.Point(4, 25);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(4);
            this.Add.Size = new System.Drawing.Size(329, 456);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add Item";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // addGenreComboBox
            // 
            this.addGenreComboBox.FormattingEnabled = true;
            this.addGenreComboBox.Location = new System.Drawing.Point(139, 179);
            this.addGenreComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.addGenreComboBox.Name = "addGenreComboBox";
            this.addGenreComboBox.Size = new System.Drawing.Size(164, 24);
            this.addGenreComboBox.TabIndex = 68;
            // 
            // addPlatformComboBox
            // 
            this.addPlatformComboBox.FormattingEnabled = true;
            this.addPlatformComboBox.Location = new System.Drawing.Point(139, 214);
            this.addPlatformComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.addPlatformComboBox.Name = "addPlatformComboBox";
            this.addPlatformComboBox.Size = new System.Drawing.Size(164, 24);
            this.addPlatformComboBox.TabIndex = 67;
            // 
            // addTypeSpecific2Lbl
            // 
            this.addTypeSpecific2Lbl.AutoSize = true;
            this.addTypeSpecific2Lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTypeSpecific2Lbl.Location = new System.Drawing.Point(21, 327);
            this.addTypeSpecific2Lbl.Name = "addTypeSpecific2Lbl";
            this.addTypeSpecific2Lbl.Size = new System.Drawing.Size(56, 20);
            this.addTypeSpecific2Lbl.TabIndex = 66;
            this.addTypeSpecific2Lbl.Text = "Misc: ";
            // 
            // addTypeSpecific1Lbl
            // 
            this.addTypeSpecific1Lbl.AutoSize = true;
            this.addTypeSpecific1Lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTypeSpecific1Lbl.Location = new System.Drawing.Point(20, 292);
            this.addTypeSpecific1Lbl.Name = "addTypeSpecific1Lbl";
            this.addTypeSpecific1Lbl.Size = new System.Drawing.Size(56, 20);
            this.addTypeSpecific1Lbl.TabIndex = 65;
            this.addTypeSpecific1Lbl.Text = "Misc: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Title: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Genre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Platform: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Released: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(99, 11);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 32);
            this.label18.TabIndex = 58;
            this.label18.Text = "Add Item";
            // 
            // addTypeComboBox
            // 
            this.addTypeComboBox.FormattingEnabled = true;
            this.addTypeComboBox.Location = new System.Drawing.Point(139, 66);
            this.addTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.addTypeComboBox.Name = "addTypeComboBox";
            this.addTypeComboBox.Size = new System.Drawing.Size(164, 24);
            this.addTypeComboBox.TabIndex = 50;
            this.addTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.addTypeComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 39);
            this.label11.TabIndex = 32;
            // 
            // addTypeSpecific2Box
            // 
            this.addTypeSpecific2Box.Location = new System.Drawing.Point(139, 325);
            this.addTypeSpecific2Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTypeSpecific2Box.Name = "addTypeSpecific2Box";
            this.addTypeSpecific2Box.Size = new System.Drawing.Size(164, 22);
            this.addTypeSpecific2Box.TabIndex = 48;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(114, 372);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(109, 65);
            this.addBtn.TabIndex = 31;
            this.addBtn.Text = "Add Item";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addTypeSpecific1Box
            // 
            this.addTypeSpecific1Box.Location = new System.Drawing.Point(139, 289);
            this.addTypeSpecific1Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTypeSpecific1Box.Name = "addTypeSpecific1Box";
            this.addTypeSpecific1Box.Size = new System.Drawing.Size(164, 22);
            this.addTypeSpecific1Box.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 33;
            // 
            // addReleasedBox
            // 
            this.addReleasedBox.Location = new System.Drawing.Point(139, 251);
            this.addReleasedBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addReleasedBox.Name = "addReleasedBox";
            this.addReleasedBox.Size = new System.Drawing.Size(164, 22);
            this.addReleasedBox.TabIndex = 46;
            // 
            // addCostBox
            // 
            this.addCostBox.Location = new System.Drawing.Point(139, 140);
            this.addCostBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCostBox.Name = "addCostBox";
            this.addCostBox.Size = new System.Drawing.Size(164, 22);
            this.addCostBox.TabIndex = 43;
            // 
            // addTitleBox
            // 
            this.addTitleBox.Location = new System.Drawing.Point(139, 103);
            this.addTitleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTitleBox.Name = "addTitleBox";
            this.addTitleBox.Size = new System.Drawing.Size(164, 22);
            this.addTitleBox.TabIndex = 42;
            // 
            // Filter
            // 
            this.Filter.BackgroundImage = global::InventoryManager.Properties.Resources.tab2;
            this.Filter.Controls.Add(this.filterPlatformComboBox);
            this.Filter.Controls.Add(this.label9);
            this.Filter.Controls.Add(this.filterTypeComboBox);
            this.Filter.Controls.Add(this.filterBtn);
            this.Filter.Controls.Add(this.label12);
            this.Filter.Controls.Add(this.filterTitleTxt);
            this.Filter.Controls.Add(this.label13);
            this.Filter.Controls.Add(this.label14);
            this.Filter.Location = new System.Drawing.Point(4, 25);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(329, 456);
            this.Filter.TabIndex = 3;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            // 
            // filterPlatformComboBox
            // 
            this.filterPlatformComboBox.CausesValidation = false;
            this.filterPlatformComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.filterPlatformComboBox.FormattingEnabled = true;
            this.filterPlatformComboBox.Location = new System.Drawing.Point(159, 186);
            this.filterPlatformComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterPlatformComboBox.Name = "filterPlatformComboBox";
            this.filterPlatformComboBox.Size = new System.Drawing.Size(141, 24);
            this.filterPlatformComboBox.TabIndex = 58;
            this.filterPlatformComboBox.SelectedIndexChanged += new System.EventHandler(this.filterPlatformComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 46);
            this.label9.TabIndex = 52;
            this.label9.Text = "Filter";
            // 
            // filterTypeComboBox
            // 
            this.filterTypeComboBox.CausesValidation = false;
            this.filterTypeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.filterTypeComboBox.FormattingEnabled = true;
            this.filterTypeComboBox.Location = new System.Drawing.Point(159, 84);
            this.filterTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterTypeComboBox.Name = "filterTypeComboBox";
            this.filterTypeComboBox.Size = new System.Drawing.Size(141, 24);
            this.filterTypeComboBox.TabIndex = 57;
            this.filterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.filterTypeComboBox_SelectedIndexChanged);
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(103, 255);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(125, 58);
            this.filterBtn.TabIndex = 51;
            this.filterBtn.Text = "Enable Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 32);
            this.label12.TabIndex = 53;
            this.label12.Text = "Type: ";
            // 
            // filterTitleTxt
            // 
            this.filterTitleTxt.Location = new System.Drawing.Point(159, 133);
            this.filterTitleTxt.Margin = new System.Windows.Forms.Padding(4);
            this.filterTitleTxt.Name = "filterTitleTxt";
            this.filterTitleTxt.Size = new System.Drawing.Size(141, 22);
            this.filterTitleTxt.TabIndex = 54;
            this.filterTitleTxt.TextChanged += new System.EventHandler(this.filterTitleTxt_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 32);
            this.label13.TabIndex = 55;
            this.label13.Text = "Title:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 28);
            this.label14.TabIndex = 56;
            this.label14.Text = "Platform: ";
            // 
            // itemListBox
            // 
            this.itemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.HorizontalScrollbar = true;
            this.itemListBox.ItemHeight = 16;
            this.itemListBox.Location = new System.Drawing.Point(359, 14);
            this.itemListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(597, 580);
            this.itemListBox.TabIndex = 51;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.Location = new System.Drawing.Point(219, 14);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(135, 90);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InventoryManager.Properties.Resources.invent3;
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 98);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(972, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Amazon Inventory Manager";
            this.tabControl1.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.Modify.ResumeLayout(false);
            this.Modify.PerformLayout();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label currentItemLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.Label platformLbl;
        private System.Windows.Forms.Label releaseYearLbl;
        private System.Windows.Forms.Label typeSpecific1Lbl;
        private System.Windows.Forms.Label typeSpecific2Lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchTypeLbl;
        private System.Windows.Forms.Label searchTitleLbl;
        private System.Windows.Forms.TextBox searchTitleTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox currTitleTxt;
        private System.Windows.Forms.TextBox currCostTxt;
        private System.Windows.Forms.TextBox currReleasedTxt;
        private System.Windows.Forms.TextBox currTypeSpecific1Txt;
        private System.Windows.Forms.TextBox currTypeSpecific2Txt;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TabPage Modify;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox addTypeSpecific2Box;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox addTypeSpecific1Box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox addReleasedBox;
        private System.Windows.Forms.TextBox addCostBox;
        private System.Windows.Forms.TextBox addTitleBox;
        private System.Windows.Forms.ComboBox addTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label addTypeSpecific1Lbl;
        private System.Windows.Forms.Label addTypeSpecific2Lbl;
        private System.Windows.Forms.ComboBox infoTypeComboBox;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox searchPlatformComboBox;
        private System.Windows.Forms.ComboBox infoPlatformComboBox;
        private System.Windows.Forms.ComboBox addPlatformComboBox;
        private System.Windows.Forms.ComboBox infoGenreComboBox;
        private System.Windows.Forms.ComboBox addGenreComboBox;
        private System.Windows.Forms.TabPage Filter;
        private System.Windows.Forms.ComboBox filterPlatformComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox filterTypeComboBox;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox filterTitleTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

