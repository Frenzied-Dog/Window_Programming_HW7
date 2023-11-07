namespace hw7_11_3 {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            WordLabel2 = new Label();
            CnLabel2 = new Label();
            PartLabel2 = new Label();
            MarkCheckBox = new CheckBox();
            CheckBtn = new Button();
            NextBtn = new Button();
            SuspendLayout();
            // 
            // WordLabel2
            // 
            WordLabel2.AutoSize = true;
            WordLabel2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            WordLabel2.Location = new Point(90, 90);
            WordLabel2.Name = "WordLabel2";
            WordLabel2.Size = new Size(73, 30);
            WordLabel2.TabIndex = 0;
            WordLabel2.Text = "單字: ";
            // 
            // CnLabel2
            // 
            CnLabel2.AutoSize = true;
            CnLabel2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CnLabel2.Location = new Point(90, 210);
            CnLabel2.Name = "CnLabel2";
            CnLabel2.Size = new Size(73, 30);
            CnLabel2.TabIndex = 1;
            CnLabel2.Text = "中文: ";
            CnLabel2.Visible = false;
            // 
            // PartLabel2
            // 
            PartLabel2.AutoSize = true;
            PartLabel2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PartLabel2.Location = new Point(90, 330);
            PartLabel2.Name = "PartLabel2";
            PartLabel2.Size = new Size(73, 30);
            PartLabel2.TabIndex = 2;
            PartLabel2.Text = "詞性: ";
            PartLabel2.Visible = false;
            // 
            // MarkCheckBox
            // 
            MarkCheckBox.AutoSize = true;
            MarkCheckBox.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MarkCheckBox.Location = new Point(652, 260);
            MarkCheckBox.Name = "MarkCheckBox";
            MarkCheckBox.Size = new Size(67, 28);
            MarkCheckBox.TabIndex = 3;
            MarkCheckBox.Text = "標記";
            MarkCheckBox.UseVisualStyleBackColor = true;
            MarkCheckBox.CheckedChanged += MarkCheckBox_CheckedChanged;
            // 
            // CheckBtn
            // 
            CheckBtn.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBtn.Location = new Point(652, 345);
            CheckBtn.Name = "CheckBtn";
            CheckBtn.Size = new Size(120, 40);
            CheckBtn.TabIndex = 4;
            CheckBtn.Text = "查看";
            CheckBtn.UseVisualStyleBackColor = true;
            CheckBtn.Click += CheckBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NextBtn.Location = new Point(652, 409);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(120, 40);
            NextBtn.TabIndex = 4;
            NextBtn.Text = "下一個";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(NextBtn);
            Controls.Add(CheckBtn);
            Controls.Add(MarkCheckBox);
            Controls.Add(PartLabel2);
            Controls.Add(CnLabel2);
            Controls.Add(WordLabel2);
            Name = "Form2";
            Text = "單字測驗";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WordLabel2;
        private Label CnLabel2;
        private Label PartLabel2;
        private CheckBox MarkCheckBox;
        private Button CheckBtn;
        private Button NextBtn;
    }
}