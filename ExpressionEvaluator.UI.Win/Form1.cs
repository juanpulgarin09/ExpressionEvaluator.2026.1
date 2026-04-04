using ExpressionEvaluator.Core;

namespace ExpressionEvaluator.UI.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMinus = new Button();
            btnCloseParenthesis = new Button();
            btnDivide = new Button();
            btnPlus = new Button();
            btnOpenParenthesis = new Button();
            btnMultiply = new Button();
            btnPow = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnResult = new Button();
            btn0 = new Button();
            btnDot = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.Green;
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(9, 10);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(375, 31);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btn7
            // 
            btn7.Location = new Point(9, 47);
            btn7.Name = "btn7";
            btn7.Size = new Size(53, 47);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(127, 100);
            btn6.Name = "btn6";
            btn6.Size = new Size(53, 47);
            btn6.TabIndex = 2;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(68, 100);
            btn5.Name = "btn5";
            btn5.Size = new Size(53, 47);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(9, 100);
            btn4.Name = "btn4";
            btn4.Size = new Size(53, 47);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(127, 47);
            btn9.Name = "btn9";
            btn9.Size = new Size(53, 47);
            btn9.TabIndex = 5;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(68, 47);
            btn8.Name = "btn8";
            btn8.Size = new Size(53, 47);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(9, 153);
            btn1.Name = "btn1";
            btn1.Size = new Size(53, 47);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(68, 153);
            btn2.Name = "btn2";
            btn2.Size = new Size(53, 47);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(127, 153);
            btn3.Name = "btn3";
            btn3.Size = new Size(53, 47);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Location = new Point(245, 153);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(53, 47);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Location = new Point(245, 47);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(53, 47);
            btnCloseParenthesis.TabIndex = 11;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Location = new Point(245, 100);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(53, 47);
            btnDivide.TabIndex = 10;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Location = new Point(186, 153);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(53, 47);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Location = new Point(186, 47);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(53, 47);
            btnOpenParenthesis.TabIndex = 14;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Location = new Point(186, 100);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(53, 47);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Location = new Point(304, 153);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(81, 47);
            btnPow.TabIndex = 18;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Location = new Point(304, 47);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 47);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Location = new Point(304, 100);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 47);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.Location = new Point(186, 206);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(199, 47);
            btnResult.TabIndex = 19;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 206);
            btn0.Name = "btn0";
            btn0.Size = new Size(109, 47);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(127, 206);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(53, 47);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // Form1
            // 
            BackColor = Color.Black;
            ClientSize = new Size(392, 256);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnResult);
            Controls.Add(btnPow);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnPlus);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnDivide);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Functions Evaluator";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMinus;
        private Button btnCloseParenthesis;
        private Button btnDivide;
        private Button btnPlus;
        private Button btnOpenParenthesis;
        private Button btnMultiply;
        private Button btnPow;
        private Button btnDelete;
        private Button btnClear;
        private Button btnResult;
        private Button btn0;
        private Button btnDot;
        private TextBox textBox1;

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnCloseParenthesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += $"={Evaluator.Evaluate(txtDisplay.Text)}";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
