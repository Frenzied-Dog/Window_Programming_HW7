namespace hw7_11_3 {
    public partial class Form1 : Form {
        public class Word {
            public string[] attr;
            public bool mark;
            public Word(string s, string c, string p) {
                attr = new string[3];
                attr[0] = s; attr[1] = c; attr[2] = p;
                mark = false;
            }
        }

        enum Modes {
            NONE, NEWWORD, SEARCH
        }

        public List<Word> words = new();
        public Font boxFont;
        List<Word> searched = new();
        Modes mode = Modes.NONE;
        CheckBox[] cbs = new CheckBox[3];
        Control[] tbs = new Control[3];
        Control[] items = new Control[7];
        bool onlyMark = false;
        Form2 quizForm = new();

        public Form1() {
            InitializeComponent();
            quizForm.Owner = this;
            boxFont = Box.Font;
            cbs = new CheckBox[] { WordCheckBox, CnCheckBox, PartCheckBox };
            tbs = new Control[] { WordTextBox, CnTextBox, PartComboBox };
            items = new Control[] { SN_Btn, WordLabel, CnLabel, PartLabel };
        }

        void PrintWords() {
            Box.Text = "";
            if (mode == Modes.SEARCH) {
                foreach (Word w in searched) {
                    if (onlyMark && !w.mark) continue;
                    Box.Text += $"{w.attr[0]} {w.attr[1]} {w.attr[2]}\r\n";
                }
            } else {
                foreach (Word w in words) {
                    if (onlyMark && !w.mark) continue;
                    Box.Text += $"{w.attr[0]} {w.attr[1]} {w.attr[2]}\r\n";
                }
            }
        }

        private void OpenMenuItem_Click(object sender, EventArgs e) {
            if (OFD.ShowDialog() == DialogResult.OK) {
                words.Clear();
                // read file
                StreamReader sr = new StreamReader(OFD.FileName);
                // readLine until end of file
                while (!sr.EndOfStream) {
                    string[] s = sr.ReadLine().Split(' ');
                    words.Add(new Word(s[0], s[1], s[2]));
                }
                sr.Close();
                this.Text = OFD.SafeFileName;
                PrintWords();
            }
        }

        private void WordsMenuItem_Click(object sender, EventArgs e) {
            if ((int)mode > 2) return;
            var item = (ToolStripMenuItem)sender;
            int tag = Convert.ToInt32(item.Tag);
            if (!item.Checked) {
                if (tag == 0) {
                    mode = Modes.NEWWORD;
                    NewWordMenuItem.Checked = true;
                    SearchWordMenuItem.Checked = false;
                    SN_Btn.Text = "新增";
                    Box.Size = new Size(620, 422);
                    foreach (CheckBox i in cbs) i.Visible = false;
                } else if (tag == 1) {
                    mode = Modes.SEARCH;
                    NewWordMenuItem.Checked = false;
                    SearchWordMenuItem.Checked = true;
                    SN_Btn.Text = "搜尋";
                    Box.Size = new Size(590, 422);
                    foreach (CheckBox i in cbs) i.Visible = true;
                    foreach (CheckBox i in cbs) i.Checked = false;
                    searched = words.ToList();
                } else return;

                foreach (Control i in items) i.Visible = true;
                foreach (Control i in tbs) {
                    i.Visible = true;
                    i.Text = "";
                }
            } else {
                mode = Modes.NONE;
                item.Checked = false;
                Box.Size = new Size(760, 422);
                foreach (CheckBox i in cbs) i.Visible = false;
                foreach (Control i in items) i.Visible = false;
                foreach (Control i in tbs) {
                    i.Visible = false;
                    i.Text = "";
                }
            }
            PrintWords();
        }

        private void SN_Btn_Click(object sender, EventArgs e) {
            if (mode == Modes.NEWWORD) {
                foreach (Control i in tbs) {
                    if (i.Text == "") {
                        MessageBox.Show("請輸入完整資料");
                        return;
                    }
                }
                words.Add(new Word(WordTextBox.Text, CnTextBox.Text, PartComboBox.Text));
                foreach (Control i in tbs) i.Text = "";
            } else if (mode == Modes.SEARCH) {
                searched = words.ToList();
                for (int i = 0; i < 3; i++) {
                    if (cbs[i].Checked) {
                        searched = searched.FindAll(w => w.attr[i].Equals(tbs[i].Text));
                    } else {
                        tbs[i].Text = "";
                    }
                }
            } else return;

            PrintWords();
        }

        private void FontMenuItem_Click(object sender, EventArgs e) {
            if (FontDialog1.ShowDialog() == DialogResult.OK) {
                Box.Font = FontDialog1.Font;
                boxFont = Box.Font;
            }
        }

        private void NewMenuItem_Click(object sender, EventArgs e) {
            words.Clear();
            Box.Text = "";
            OFD.FileName = "";
            this.Text = "Untitled";
        }

        private void SaveMenuItem_Click(object sender, EventArgs e) {
            var item = (ToolStripMenuItem)sender;
            if (item.Name == "SaveMenuItem") {
                if (OFD.FileName == "" && SFD.ShowDialog() == DialogResult.OK) {
                    OFD.FileName = SFD.FileName;
                    this.Text = OFD.SafeFileName;
                } else if (OFD.FileName != "") {
                    SFD.FileName = OFD.FileName;
                } else return;
            } else if (item.Name == "SaveAsMenuItem") {
                if (SFD.ShowDialog() == DialogResult.OK) {
                    OFD.FileName = SFD.FileName;
                    this.Text = OFD.SafeFileName;
                }
            } else return;

            // write file
            StreamWriter sw = new(SFD.FileName);
            foreach (Word w in words) {
                sw.WriteLine($"{w.attr[0]} {w.attr[1]} {w.attr[2]}");
            }
            sw.Close();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void SwMarkMenuItem_Click(object sender, EventArgs e) {
            SwMarkMenuItem.Checked = !SwMarkMenuItem.Checked;
            onlyMark = !onlyMark;
            PrintWords();
        }

        private void ClrMarkMenuItem_Click(object sender, EventArgs e) {
            foreach (Word w in words) w.mark = false;
            PrintWords();
        }

        private void QuizMenuItem_Click(object sender, EventArgs e) {
            if (words.Count == 0) {
                MessageBox.Show("單字表為空!!");
                return;
            }
            this.Visible = false;
            quizForm.ShowDialog();
            mode = Modes.NONE;
            NewWordMenuItem.Checked = false;
            SearchWordMenuItem.Checked = false;
            Box.Size = new Size(760, 422);
            foreach (CheckBox i in cbs) i.Visible = false;
            foreach (Control i in items) i.Visible = false;
            foreach (Control i in tbs) {
                i.Visible = false;
                i.Text = "";
            }
            this.Visible = true;
        }
    }
}