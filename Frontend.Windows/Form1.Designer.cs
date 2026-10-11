namespace Frontend.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClear = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDelete = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnResult = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            txtDisplay = new TextBox();
            btnPow = new Button();
            btn6 = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(317, 139);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 68);
            btnClear.TabIndex = 1;
            btnClear.Text = "AC";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = SystemColors.ActiveCaption;
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenParenthesis.Location = new Point(76, 66);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(69, 68);
            btnOpenParenthesis.TabIndex = 2;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = SystemColors.ActiveCaption;
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseParenthesis.Location = new Point(160, 66);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(69, 68);
            btnCloseParenthesis.TabIndex = 3;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDark;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(157, 139);
            btn9.Name = "btn9";
            btn9.Size = new Size(69, 68);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDark;
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(79, 139);
            btn8.Name = "btn8";
            btn8.Size = new Size(69, 68);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonShadow;
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(1, 139);
            btn7.Name = "btn7";
            btn7.Size = new Size(69, 68);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonShadow;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(79, 213);
            btn5.Name = "btn5";
            btn5.Size = new Size(69, 67);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDark;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(1, 213);
            btn4.Name = "btn4";
            btn4.Size = new Size(69, 67);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(235, 66);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 67);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ControlDark;
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(157, 360);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(69, 67);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDark;
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(1, 360);
            btn0.Name = "btn0";
            btn0.Size = new Size(144, 67);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDark;
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(157, 286);
            btn3.Name = "btn3";
            btn3.Size = new Size(69, 68);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDark;
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(79, 286);
            btn2.Name = "btn2";
            btn2.Size = new Size(69, 68);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDark;
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(1, 286);
            btn1.Name = "btn1";
            btn1.Size = new Size(69, 68);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 128, 255);
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(239, 360);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(147, 67);
            btnResult.TabIndex = 20;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ActiveCaption;
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(317, 213);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(69, 141);
            btnPlus.TabIndex = 19;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ActiveCaption;
            btnMinus.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(235, 213);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(69, 67);
            btnMinus.TabIndex = 18;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ActiveCaption;
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(235, 139);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(69, 68);
            btnMultiply.TabIndex = 17;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ActiveCaption;
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(1, 65);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(69, 68);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.CornflowerBlue;
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.WindowText;
            txtDisplay.Location = new Point(1, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(386, 47);
            txtDisplay.TabIndex = 21;
            // 
            // btnPow
            // 
            btnPow.BackColor = SystemColors.ActiveCaption;
            btnPow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPow.Location = new Point(235, 286);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(69, 68);
            btnPow.TabIndex = 22;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ButtonShadow;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(157, 213);
            btn6.Name = "btn6";
            btn6.Size = new Size(69, 67);
            btn6.TabIndex = 23;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(399, 438);
            Controls.Add(btn6);
            Controls.Add(btnPow);
            Controls.Add(txtDisplay);
            Controls.Add(btnResult);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnDelete);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnClear);
            Name = "Form1";
            Text = "Function Evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClear;
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn5;
        private Button btn4;
        private Button btnDelete;
        private Button btnDot;
        private Button btn0;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnResult;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private TextBox txtDisplay;
        private Button btnPow;
        private Button btn6;
    }
}
