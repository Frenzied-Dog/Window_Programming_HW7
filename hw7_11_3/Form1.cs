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

        List<Word> words = new();

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
                    string[] s = sr.ReadLine().Split(',');
                    words.Add(new Word(s[0], s[1], s[2]));
                }
                sr.Close();
                PrintWords();
            }
        }
    }
}