using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw7_11_3 {
    public partial class Form2 : Form {
        Random rnd = new Random();
        public List<Form1.Word> problem = new();
        int index;

        void SetWord(int n) {
            WordLabel2.Text = $"單字: {problem[n].attr[0]}";
            CnLabel2.Text = $"中文: {problem[n].attr[1]}";
            PartLabel2.Text = $"詞性: {problem[n].attr[2]}";
            MarkCheckBox.Checked = problem[n].mark;
        }

        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            problem = ((Form1)Owner).words;
            Font font = ((Form1)Owner).boxFont;
            WordLabel2.Font = font;
            CnLabel2.Font = font;
            PartLabel2.Font = font;
            index = rnd.Next(problem.Count);
            SetWord(index);
        }

        private void MarkCheckBox_CheckedChanged(object sender, EventArgs e) {
            problem[index].mark = MarkCheckBox.Checked;
        }

        private void CheckBtn_Click(object sender, EventArgs e) {
            CnLabel2.Visible = !CnLabel2.Visible;
            PartLabel2.Visible = !PartLabel2.Visible;
        }

        private void NextBtn_Click(object sender, EventArgs e) {
            CnLabel2.Visible = false;
            PartLabel2.Visible = false;
            index = rnd.Next(problem.Count);
            SetWord(index);
        }
    }
}
