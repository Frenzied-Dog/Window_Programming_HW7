namespace hw7_11_3 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Menus = new MenuStrip();
            FilesMenuItem = new ToolStripMenuItem();
            NewMenuItem = new ToolStripMenuItem();
            OpenMenuItem = new ToolStripMenuItem();
            Separator1 = new ToolStripSeparator();
            SaveMenuItem = new ToolStripMenuItem();
            SaveNewMenuItem = new ToolStripMenuItem();
            Separator2 = new ToolStripSeparator();
            ExitMenuItem = new ToolStripMenuItem();
            FuncMenuItem = new ToolStripMenuItem();
            NewWordMenuItem = new ToolStripMenuItem();
            SearchWordMenuItem = new ToolStripMenuItem();
            CheckMenuItem = new ToolStripMenuItem();
            FontMenuItem = new ToolStripMenuItem();
            SwTagMenuItem = new ToolStripMenuItem();
            ClrTagMenuItem = new ToolStripMenuItem();
            FontDialog1 = new FontDialog();
            SFD = new SaveFileDialog();
            OFD = new OpenFileDialog();
            Box = new TextBox();
            PosComboBox = new ComboBox();
            WordTextBox = new TextBox();
            CnTextBox = new TextBox();
            WordLabel = new Label();
            CnLabel = new Label();
            PosLabel = new Label();
            WordCheckBox = new CheckBox();
            CnCheckBox = new CheckBox();
            PosCheckBox = new CheckBox();
            S_NBtn = new Button();
            Menus.SuspendLayout();
            SuspendLayout();
            // 
            // Menus
            // 
            Menus.Items.AddRange(new ToolStripItem[] { FilesMenuItem, FuncMenuItem, CheckMenuItem });
            Menus.Location = new Point(0, 0);
            Menus.Name = "Menus";
            Menus.Size = new Size(784, 24);
            Menus.TabIndex = 0;
            Menus.Text = "menuStrip1";
            // 
            // FilesMenuItem
            // 
            FilesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewMenuItem, OpenMenuItem, Separator1, SaveMenuItem, SaveNewMenuItem, Separator2, ExitMenuItem });
            FilesMenuItem.Name = "FilesMenuItem";
            FilesMenuItem.Size = new Size(57, 20);
            FilesMenuItem.Text = "檔案(&F)";
            // 
            // NewMenuItem
            // 
            NewMenuItem.Image = (Image)resources.GetObject("NewMenuItem.Image");
            NewMenuItem.ImageTransparentColor = Color.Magenta;
            NewMenuItem.Name = "NewMenuItem";
            NewMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            NewMenuItem.Size = new Size(185, 22);
            NewMenuItem.Text = "新增(&N)";
            // 
            // OpenMenuItem
            // 
            OpenMenuItem.Image = (Image)resources.GetObject("OpenMenuItem.Image");
            OpenMenuItem.ImageTransparentColor = Color.Magenta;
            OpenMenuItem.Name = "OpenMenuItem";
            OpenMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenMenuItem.Size = new Size(185, 22);
            OpenMenuItem.Text = "開啟舊檔(&O)";
            OpenMenuItem.Click += OpenMenuItem_Click;
            // 
            // Separator1
            // 
            Separator1.Name = "Separator1";
            Separator1.Size = new Size(182, 6);
            // 
            // SaveMenuItem
            // 
            SaveMenuItem.Image = (Image)resources.GetObject("SaveMenuItem.Image");
            SaveMenuItem.ImageTransparentColor = Color.Magenta;
            SaveMenuItem.Name = "SaveMenuItem";
            SaveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveMenuItem.Size = new Size(185, 22);
            SaveMenuItem.Text = "儲存(&S)";
            // 
            // SaveNewMenuItem
            // 
            SaveNewMenuItem.Name = "SaveNewMenuItem";
            SaveNewMenuItem.Size = new Size(185, 22);
            SaveNewMenuItem.Text = "另存新檔(&A)";
            // 
            // Separator2
            // 
            Separator2.Name = "Separator2";
            Separator2.Size = new Size(182, 6);
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(185, 22);
            ExitMenuItem.Text = "離開(&X)";
            // 
            // FuncMenuItem
            // 
            FuncMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewWordMenuItem, SearchWordMenuItem });
            FuncMenuItem.Name = "FuncMenuItem";
            FuncMenuItem.Size = new Size(58, 20);
            FuncMenuItem.Text = "功能(&T)";
            // 
            // NewWordMenuItem
            // 
            NewWordMenuItem.Name = "NewWordMenuItem";
            NewWordMenuItem.Size = new Size(138, 22);
            NewWordMenuItem.Text = "新增單字(&A)";
            // 
            // SearchWordMenuItem
            // 
            SearchWordMenuItem.Name = "SearchWordMenuItem";
            SearchWordMenuItem.Size = new Size(138, 22);
            SearchWordMenuItem.Text = "搜尋單字(&S)";
            // 
            // CheckMenuItem
            // 
            CheckMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontMenuItem, SwTagMenuItem, ClrTagMenuItem });
            CheckMenuItem.Name = "CheckMenuItem";
            CheckMenuItem.Size = new Size(63, 20);
            CheckMenuItem.Text = "檢視(&W)";
            // 
            // FontMenuItem
            // 
            FontMenuItem.Name = "FontMenuItem";
            FontMenuItem.Size = new Size(174, 22);
            FontMenuItem.Text = "字型大小(&F)";
            // 
            // SwTagMenuItem
            // 
            SwTagMenuItem.Name = "SwTagMenuItem";
            SwTagMenuItem.Size = new Size(174, 22);
            SwTagMenuItem.Text = "只顯示標記單字(&V)";
            // 
            // ClrTagMenuItem
            // 
            ClrTagMenuItem.Name = "ClrTagMenuItem";
            ClrTagMenuItem.Size = new Size(174, 22);
            ClrTagMenuItem.Text = "清除標記(&C)";
            // 
            // OFD
            // 
            OFD.Filter = "ToDo files (*.todo)|*.todo|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            OFD.Title = "開啟文件";
            // 
            // Box
            // 
            Box.Enabled = false;
            Box.Location = new Point(12, 27);
            Box.Multiline = true;
            Box.Name = "Box";
            Box.ScrollBars = ScrollBars.Both;
            Box.Size = new Size(590, 422);
            Box.TabIndex = 1;
            Box.WordWrap = false;
            // 
            // PosComboBox
            // 
            PosComboBox.FormattingEnabled = true;
            PosComboBox.Location = new Point(646, 365);
            PosComboBox.Name = "PosComboBox";
            PosComboBox.Size = new Size(121, 23);
            PosComboBox.TabIndex = 2;
            // 
            // WordTextBox
            // 
            WordTextBox.Location = new Point(646, 127);
            WordTextBox.Name = "WordTextBox";
            WordTextBox.Size = new Size(100, 23);
            WordTextBox.TabIndex = 3;
            // 
            // CnTextBox
            // 
            CnTextBox.Location = new Point(646, 258);
            CnTextBox.Name = "CnTextBox";
            CnTextBox.Size = new Size(100, 23);
            CnTextBox.TabIndex = 4;
            // 
            // WordLabel
            // 
            WordLabel.AutoSize = true;
            WordLabel.Location = new Point(646, 98);
            WordLabel.Name = "WordLabel";
            WordLabel.Size = new Size(31, 15);
            WordLabel.TabIndex = 5;
            WordLabel.Text = "單字";
            // 
            // CnLabel
            // 
            CnLabel.AutoSize = true;
            CnLabel.Location = new Point(646, 208);
            CnLabel.Name = "CnLabel";
            CnLabel.Size = new Size(31, 15);
            CnLabel.TabIndex = 6;
            CnLabel.Text = "中文";
            // 
            // PosLabel
            // 
            PosLabel.AutoSize = true;
            PosLabel.Location = new Point(646, 324);
            PosLabel.Name = "PosLabel";
            PosLabel.Size = new Size(31, 15);
            PosLabel.TabIndex = 7;
            PosLabel.Text = "詞性";
            // 
            // WordCheckBox
            // 
            WordCheckBox.AutoSize = true;
            WordCheckBox.Location = new Point(610, 132);
            WordCheckBox.Name = "WordCheckBox";
            WordCheckBox.Size = new Size(15, 14);
            WordCheckBox.TabIndex = 8;
            WordCheckBox.UseVisualStyleBackColor = true;
            // 
            // CnCheckBox
            // 
            CnCheckBox.AutoSize = true;
            CnCheckBox.Location = new Point(622, 245);
            CnCheckBox.Name = "CnCheckBox";
            CnCheckBox.Size = new Size(15, 14);
            CnCheckBox.TabIndex = 9;
            CnCheckBox.UseVisualStyleBackColor = true;
            // 
            // PosCheckBox
            // 
            PosCheckBox.AutoSize = true;
            PosCheckBox.Location = new Point(626, 365);
            PosCheckBox.Name = "PosCheckBox";
            PosCheckBox.Size = new Size(15, 14);
            PosCheckBox.TabIndex = 10;
            PosCheckBox.UseVisualStyleBackColor = true;
            // 
            // S_NBtn
            // 
            S_NBtn.Location = new Point(692, 416);
            S_NBtn.Name = "S_NBtn";
            S_NBtn.Size = new Size(75, 23);
            S_NBtn.TabIndex = 11;
            S_NBtn.Text = "搜尋";
            S_NBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(S_NBtn);
            Controls.Add(PosCheckBox);
            Controls.Add(CnCheckBox);
            Controls.Add(WordCheckBox);
            Controls.Add(PosLabel);
            Controls.Add(CnLabel);
            Controls.Add(WordLabel);
            Controls.Add(CnTextBox);
            Controls.Add(WordTextBox);
            Controls.Add(PosComboBox);
            Controls.Add(Box);
            Controls.Add(Menus);
            MainMenuStrip = Menus;
            Name = "Form1";
            Text = "Form1";
            Menus.ResumeLayout(false);
            Menus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menus;
        private ToolStripMenuItem FilesMenuItem;
        private ToolStripMenuItem NewMenuItem;
        private ToolStripMenuItem OpenMenuItem;
        private ToolStripSeparator Separator1;
        private ToolStripMenuItem SaveMenuItem;
        private ToolStripMenuItem SaveNewMenuItem;
        private ToolStripSeparator Separator2;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem FuncMenuItem;
        private ToolStripMenuItem NewWordMenuItem;
        private ToolStripMenuItem SearchWordMenuItem;
        private ToolStripMenuItem CheckMenuItem;
        private FontDialog FontDialog1;
        private SaveFileDialog SFD;
        private ToolStripMenuItem FontMenuItem;
        private ToolStripMenuItem SwTagMenuItem;
        private ToolStripMenuItem ClrTagMenuItem;
        private OpenFileDialog OFD;
        private TextBox Box;
        private ComboBox PosComboBox;
        private TextBox WordTextBox;
        private TextBox CnTextBox;
        private Label WordLabel;
        private Label CnLabel;
        private Label PosLabel;
        private CheckBox WordCheckBox;
        private CheckBox CnCheckBox;
        private CheckBox PosCheckBox;
        private Button S_NBtn;
    }
}