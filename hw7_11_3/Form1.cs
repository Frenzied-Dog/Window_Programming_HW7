namespace hw7_11_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        class Word {
            public string str, cn, part;
            public bool mark;
            public Word(string s, string c, string p) {
                str = s; cn = c; part = p;
                mark = false;
            }
        }

        enum Modes {
            NONE, NEWWORD, SEARCH
        }

        List<Word> words = new();
        Modes mode = Modes.NONE;

        void PrintWords() {
            Box.Text = "";
            foreach (Word w in words) {
                Box.Text += $"{w.str} {w.cn} {w.part}\r\n";
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
                PrintWords();
            }
        }

        private void WordsMenuItem_Click(object sender, EventArgs e) {
            if ((int)mode > 2) return;
            var item = (ToolStripMenuItem)sender;
            int tag = (int)item.Tag;
            if (!item.Checked) {
                if (tag == 0) {
                    mode = Modes.NEWWORD;
                    NewWordMenuItem.Checked = true;
                    SearchWordMenuItem.Checked = false;
                } else {
                    mode = Modes.SEARCH;
                    NewWordMenuItem.Checked = false;
                    SearchWordMenuItem.Checked = true;
                }
            } else {
                mode = Modes.NONE;
                item.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}