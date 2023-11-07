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
            SaveAsMenuItem = new ToolStripMenuItem();
            Separator2 = new ToolStripSeparator();
            ExitMenuItem = new ToolStripMenuItem();
            FuncMenuItem = new ToolStripMenuItem();
            NewWordMenuItem = new ToolStripMenuItem();
            SearchWordMenuItem = new ToolStripMenuItem();
            QuizMenuItem = new ToolStripMenuItem();
            CheckMenuItem = new ToolStripMenuItem();
            FontMenuItem = new ToolStripMenuItem();
            SwMarkMenuItem = new ToolStripMenuItem();
            ClrMarkMenuItem = new ToolStripMenuItem();
            FontDialog1 = new FontDialog();
            SFD = new SaveFileDialog();
            OFD = new OpenFileDialog();
            Box = new TextBox();
            PartComboBox = new ComboBox();
            WordTextBox = new TextBox();
            CnTextBox = new TextBox();
            WordLabel = new Label();
            CnLabel = new Label();
            PartLabel = new Label();
            WordCheckBox = new CheckBox();
            CnCheckBox = new CheckBox();
            PartCheckBox = new CheckBox();
            SN_Btn = new Button();
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
            FilesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewMenuItem, OpenMenuItem, Separator1, SaveMenuItem, SaveAsMenuItem, Separator2, ExitMenuItem });
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
            NewMenuItem.Click += NewMenuItem_Click;
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
            SaveMenuItem.Click += SaveMenuItem_Click;
            // 
            // SaveAsMenuItem
            // 
            SaveAsMenuItem.Name = "SaveAsMenuItem";
            SaveAsMenuItem.Size = new Size(185, 22);
            SaveAsMenuItem.Text = "另存新檔(&A)";
            SaveAsMenuItem.Click += SaveMenuItem_Click;
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
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // FuncMenuItem
            // 
            FuncMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewWordMenuItem, SearchWordMenuItem, QuizMenuItem });
            FuncMenuItem.Name = "FuncMenuItem";
            FuncMenuItem.Size = new Size(58, 20);
            FuncMenuItem.Text = "功能(&T)";
            // 
            // NewWordMenuItem
            // 
            NewWordMenuItem.Name = "NewWordMenuItem";
            NewWordMenuItem.Size = new Size(180, 22);
            NewWordMenuItem.Tag = "0";
            NewWordMenuItem.Text = "新增單字(&A)";
            NewWordMenuItem.Click += WordsMenuItem_Click;
            // 
            // SearchWordMenuItem
            // 
            SearchWordMenuItem.Name = "SearchWordMenuItem";
            SearchWordMenuItem.Size = new Size(180, 22);
            SearchWordMenuItem.Tag = "1";
            SearchWordMenuItem.Text = "搜尋單字(&S)";
            SearchWordMenuItem.Click += WordsMenuItem_Click;
            // 
            // QuizMenuItem
            // 
            QuizMenuItem.Name = "QuizMenuItem";
            QuizMenuItem.Size = new Size(180, 22);
            QuizMenuItem.Text = "單字測驗(&T)";
            QuizMenuItem.Click += QuizMenuItem_Click;
            // 
            // CheckMenuItem
            // 
            CheckMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontMenuItem, SwMarkMenuItem, ClrMarkMenuItem });
            CheckMenuItem.Name = "CheckMenuItem";
            CheckMenuItem.Size = new Size(63, 20);
            CheckMenuItem.Text = "檢視(&W)";
            // 
            // FontMenuItem
            // 
            FontMenuItem.Name = "FontMenuItem";
            FontMenuItem.Size = new Size(174, 22);
            FontMenuItem.Text = "字型大小(&F)";
            FontMenuItem.Click += FontMenuItem_Click;
            // 
            // SwMarkMenuItem
            // 
            SwMarkMenuItem.Name = "SwMarkMenuItem";
            SwMarkMenuItem.Size = new Size(174, 22);
            SwMarkMenuItem.Text = "只顯示標記單字(&V)";
            SwMarkMenuItem.Click += SwMarkMenuItem_Click;
            // 
            // ClrMarkMenuItem
            // 
            ClrMarkMenuItem.Name = "ClrMarkMenuItem";
            ClrMarkMenuItem.Size = new Size(174, 22);
            ClrMarkMenuItem.Text = "清除標記(&C)";
            ClrMarkMenuItem.Click += ClrMarkMenuItem_Click;
            // 
            // SFD
            // 
            SFD.DefaultExt = "txt";
            SFD.Filter = "ToDo files (*.todo)|*.todo|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            SFD.Title = "另存新檔";
            // 
            // OFD
            // 
            OFD.Filter = "ToDo files (*.todo)|*.todo|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            OFD.Title = "開啟文件";
            // 
            // Box
            // 
            Box.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Box.ForeColor = Color.Black;
            Box.ImeMode = ImeMode.NoControl;
            Box.Location = new Point(12, 27);
            Box.Multiline = true;
            Box.Name = "Box";
            Box.ReadOnly = true;
            Box.ScrollBars = ScrollBars.Both;
            Box.Size = new Size(760, 422);
            Box.TabIndex = 1;
            Box.WordWrap = false;
            // 
            // PartComboBox
            // 
            PartComboBox.FormattingEnabled = true;
            PartComboBox.Items.AddRange(new object[] { "n", "v", "adj", "adv", "prep", "conj", "phr", "abbr", "pron", "other" });
            PartComboBox.Location = new Point(645, 330);
            PartComboBox.Name = "PartComboBox";
            PartComboBox.Size = new Size(120, 23);
            PartComboBox.TabIndex = 2;
            PartComboBox.Visible = false;
            // 
            // WordTextBox
            // 
            WordTextBox.Location = new Point(645, 110);
            WordTextBox.Name = "WordTextBox";
            WordTextBox.Size = new Size(120, 23);
            WordTextBox.TabIndex = 3;
            WordTextBox.Visible = false;
            // 
            // CnTextBox
            // 
            CnTextBox.Location = new Point(645, 224);
            CnTextBox.Name = "CnTextBox";
            CnTextBox.Size = new Size(120, 23);
            CnTextBox.TabIndex = 4;
            CnTextBox.Visible = false;
            // 
            // WordLabel
            // 
            WordLabel.AutoSize = true;
            WordLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WordLabel.Location = new Point(645, 85);
            WordLabel.Name = "WordLabel";
            WordLabel.Size = new Size(41, 20);
            WordLabel.TabIndex = 5;
            WordLabel.Text = "單字";
            WordLabel.Visible = false;
            // 
            // CnLabel
            // 
            CnLabel.AutoSize = true;
            CnLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CnLabel.Location = new Point(645, 199);
            CnLabel.Name = "CnLabel";
            CnLabel.Size = new Size(41, 20);
            CnLabel.TabIndex = 6;
            CnLabel.Text = "中文";
            CnLabel.Visible = false;
            // 
            // PartLabel
            // 
            PartLabel.AutoSize = true;
            PartLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PartLabel.Location = new Point(645, 305);
            PartLabel.Name = "PartLabel";
            PartLabel.Size = new Size(41, 20);
            PartLabel.TabIndex = 7;
            PartLabel.Text = "詞性";
            PartLabel.Visible = false;
            // 
            // WordCheckBox
            // 
            WordCheckBox.AutoSize = true;
            WordCheckBox.Location = new Point(625, 115);
            WordCheckBox.Name = "WordCheckBox";
            WordCheckBox.Size = new Size(15, 14);
            WordCheckBox.TabIndex = 8;
            WordCheckBox.UseVisualStyleBackColor = true;
            WordCheckBox.Visible = false;
            // 
            // CnCheckBox
            // 
            CnCheckBox.AutoSize = true;
            CnCheckBox.Location = new Point(625, 229);
            CnCheckBox.Name = "CnCheckBox";
            CnCheckBox.Size = new Size(15, 14);
            CnCheckBox.TabIndex = 9;
            CnCheckBox.UseVisualStyleBackColor = true;
            CnCheckBox.Visible = false;
            // 
            // PartCheckBox
            // 
            PartCheckBox.AutoSize = true;
            PartCheckBox.Location = new Point(625, 335);
            PartCheckBox.Name = "PartCheckBox";
            PartCheckBox.Size = new Size(15, 14);
            PartCheckBox.TabIndex = 10;
            PartCheckBox.UseVisualStyleBackColor = true;
            PartCheckBox.Visible = false;
            // 
            // SN_Btn
            // 
            SN_Btn.Location = new Point(690, 420);
            SN_Btn.Name = "SN_Btn";
            SN_Btn.Size = new Size(75, 23);
            SN_Btn.TabIndex = 11;
            SN_Btn.Text = "搜尋";
            SN_Btn.UseVisualStyleBackColor = true;
            SN_Btn.Visible = false;
            SN_Btn.Click += SN_Btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(SN_Btn);
            Controls.Add(PartCheckBox);
            Controls.Add(CnCheckBox);
            Controls.Add(WordCheckBox);
            Controls.Add(PartLabel);
            Controls.Add(CnLabel);
            Controls.Add(WordLabel);
            Controls.Add(CnTextBox);
            Controls.Add(WordTextBox);
            Controls.Add(PartComboBox);
            Controls.Add(Box);
            Controls.Add(Menus);
            MainMenuStrip = Menus;
            Name = "Form1";
            Text = "Untitled";
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
        private ToolStripMenuItem SaveAsMenuItem;
        private ToolStripSeparator Separator2;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem FuncMenuItem;
        private ToolStripMenuItem NewWordMenuItem;
        private ToolStripMenuItem SearchWordMenuItem;
        private ToolStripMenuItem CheckMenuItem;
        private FontDialog FontDialog1;
        private SaveFileDialog SFD;
        private ToolStripMenuItem FontMenuItem;
        private ToolStripMenuItem SwMarkMenuItem;
        private ToolStripMenuItem ClrMarkMenuItem;
        private OpenFileDialog OFD;
        private TextBox Box;
        private ComboBox PartComboBox;
        private TextBox WordTextBox;
        private TextBox CnTextBox;
        private Label WordLabel;
        private Label CnLabel;
        private Label PartLabel;
        private CheckBox WordCheckBox;
        private CheckBox CnCheckBox;
        private CheckBox PartCheckBox;
        private Button SN_Btn;
        private ToolStripMenuItem QuizMenuItem;
    }
}