namespace calculator {
    partial class Calculator {
        private System.ComponentModel.IContainer components = null;
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
            tbDisplay = new TextBox();
            btPlus = new Button();
            btMultiplied = new Button();
            btTimes = new Button();
            btMinus = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btClear = new Button();
            bt1 = new Button();
            bt5 = new Button();
            bt6 = new Button();
            btEquals = new Button();
            bt4 = new Button();
            bt8 = new Button();
            bt9 = new Button();
            bt0 = new Button();
            bt7 = new Button();
            tbError = new TextBox();
            btBackword = new Button();
            btPoint = new Button();
            btFactorial = new Button();
            btLn = new Button();
            btLog = new Button();
            btSqrt = new Button();
            btSquare = new Button();
            btMod = new Button();
            btCubic = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(40, 32);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(440, 23);
            tbDisplay.TabIndex = 0;
            tbDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btPlus
            // 
            btPlus.Location = new Point(420, 149);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(60, 40);
            btPlus.TabIndex = 1;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // btMultiplied
            // 
            btMultiplied.Location = new Point(420, 384);
            btMultiplied.Name = "btMultiplied";
            btMultiplied.Size = new Size(60, 40);
            btMultiplied.TabIndex = 9;
            btMultiplied.Text = "/";
            btMultiplied.UseVisualStyleBackColor = true;
            btMultiplied.Click += btMultiplied_Click;
            // 
            // btTimes
            // 
            btTimes.Location = new Point(420, 306);
            btTimes.Name = "btTimes";
            btTimes.Size = new Size(60, 40);
            btTimes.TabIndex = 10;
            btTimes.Text = "X";
            btTimes.UseVisualStyleBackColor = true;
            btTimes.Click += btTimes_Click;
            // 
            // btMinus
            // 
            btMinus.Location = new Point(420, 228);
            btMinus.Name = "btMinus";
            btMinus.Size = new Size(60, 40);
            btMinus.TabIndex = 11;
            btMinus.Text = "-";
            btMinus.UseVisualStyleBackColor = true;
            btMinus.Click += btMinus_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(230, 224);
            bt2.Name = "bt2";
            bt2.Size = new Size(60, 40);
            bt2.TabIndex = 15;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(325, 224);
            bt3.Name = "bt3";
            bt3.Size = new Size(60, 40);
            bt3.TabIndex = 14;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(135, 463);
            btClear.Name = "btClear";
            btClear.Size = new Size(60, 40);
            btClear.TabIndex = 13;
            btClear.Text = "C";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(135, 224);
            bt1.Name = "bt1";
            bt1.Size = new Size(60, 40);
            bt1.TabIndex = 12;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt5
            // 
            bt5.Location = new Point(230, 306);
            bt5.Name = "bt5";
            bt5.Size = new Size(60, 40);
            bt5.TabIndex = 19;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click;
            // 
            // bt6
            // 
            bt6.Location = new Point(325, 306);
            bt6.Name = "bt6";
            bt6.Size = new Size(60, 40);
            bt6.TabIndex = 18;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += bt6_Click;
            // 
            // btEquals
            // 
            btEquals.Location = new Point(420, 462);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(60, 40);
            btEquals.TabIndex = 17;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = true;
            btEquals.Click += btEquals_Click;
            // 
            // bt4
            // 
            bt4.Location = new Point(135, 306);
            bt4.Name = "bt4";
            bt4.Size = new Size(60, 40);
            bt4.TabIndex = 16;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click;
            // 
            // bt8
            // 
            bt8.Location = new Point(230, 384);
            bt8.Name = "bt8";
            bt8.Size = new Size(60, 40);
            bt8.TabIndex = 23;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += bt8_Click;
            // 
            // bt9
            // 
            bt9.Location = new Point(325, 384);
            bt9.Name = "bt9";
            bt9.Size = new Size(60, 40);
            bt9.TabIndex = 22;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += bt9_Click;
            // 
            // bt0
            // 
            bt0.Location = new Point(230, 462);
            bt0.Name = "bt0";
            bt0.Size = new Size(60, 40);
            bt0.TabIndex = 21;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt7
            // 
            bt7.Location = new Point(135, 384);
            bt7.Name = "bt7";
            bt7.Size = new Size(60, 40);
            bt7.TabIndex = 20;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += bt7_Click;
            // 
            // tbError
            // 
            tbError.BackColor = SystemColors.Menu;
            tbError.Location = new Point(135, 90);
            tbError.Name = "tbError";
            tbError.Size = new Size(250, 23);
            tbError.TabIndex = 24;
            tbError.TextAlign = HorizontalAlignment.Center;
            // 
            // btBackword
            // 
            btBackword.Location = new Point(135, 149);
            btBackword.Name = "btBackword";
            btBackword.Size = new Size(60, 40);
            btBackword.TabIndex = 25;
            btBackword.Text = "1/x";
            btBackword.UseVisualStyleBackColor = true;
            btBackword.Click += btBackword_Click;
            // 
            // btPoint
            // 
            btPoint.Location = new Point(325, 462);
            btPoint.Name = "btPoint";
            btPoint.Size = new Size(60, 40);
            btPoint.TabIndex = 26;
            btPoint.Text = ".";
            btPoint.UseVisualStyleBackColor = true;
            btPoint.Click += btPoint_Click;
            // 
            // btFactorial
            // 
            btFactorial.Location = new Point(40, 149);
            btFactorial.Name = "btFactorial";
            btFactorial.Size = new Size(60, 40);
            btFactorial.TabIndex = 27;
            btFactorial.Text = "x!";
            btFactorial.UseVisualStyleBackColor = true;
            btFactorial.Click += btFactorial_Click;
            // 
            // btLn
            // 
            btLn.Location = new Point(40, 224);
            btLn.Name = "btLn";
            btLn.Size = new Size(60, 40);
            btLn.TabIndex = 28;
            btLn.Text = "ln";
            btLn.UseVisualStyleBackColor = true;
            btLn.Click += btLn_Click;
            // 
            // btLog
            // 
            btLog.Location = new Point(40, 306);
            btLog.Name = "btLog";
            btLog.Size = new Size(60, 40);
            btLog.TabIndex = 29;
            btLog.Text = "log";
            btLog.UseVisualStyleBackColor = true;
            btLog.Click += btLog_Click;
            // 
            // btSqrt
            // 
            btSqrt.Location = new Point(40, 463);
            btSqrt.Name = "btSqrt";
            btSqrt.Size = new Size(60, 40);
            btSqrt.TabIndex = 30;
            btSqrt.Text = "sqrt";
            btSqrt.UseVisualStyleBackColor = true;
            btSqrt.Click += btSqrt_Click;
            // 
            // btSquare
            // 
            btSquare.Location = new Point(325, 149);
            btSquare.Name = "btSquare";
            btSquare.Size = new Size(60, 40);
            btSquare.TabIndex = 31;
            btSquare.Text = "x^2";
            btSquare.UseVisualStyleBackColor = true;
            btSquare.Click += btSquare_Click;
            // 
            // btMod
            // 
            btMod.Location = new Point(40, 384);
            btMod.Name = "btMod";
            btMod.Size = new Size(60, 40);
            btMod.TabIndex = 32;
            btMod.Text = "Mod";
            btMod.UseVisualStyleBackColor = true;
            btMod.Click += btMod_Click;
            // 
            // btCubic
            // 
            btCubic.Location = new Point(230, 149);
            btCubic.Name = "btCubic";
            btCubic.Size = new Size(60, 40);
            btCubic.TabIndex = 33;
            btCubic.Text = "x^3";
            btCubic.UseVisualStyleBackColor = true;
            btCubic.Click += btCubic_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 525);
            Controls.Add(btCubic);
            Controls.Add(btMod);
            Controls.Add(btSquare);
            Controls.Add(btSqrt);
            Controls.Add(btLog);
            Controls.Add(btLn);
            Controls.Add(btFactorial);
            Controls.Add(btPoint);
            Controls.Add(btBackword);
            Controls.Add(tbError);
            Controls.Add(bt8);
            Controls.Add(bt9);
            Controls.Add(bt0);
            Controls.Add(bt7);
            Controls.Add(bt5);
            Controls.Add(bt6);
            Controls.Add(btEquals);
            Controls.Add(bt4);
            Controls.Add(bt2);
            Controls.Add(bt3);
            Controls.Add(btClear);
            Controls.Add(bt1);
            Controls.Add(btMinus);
            Controls.Add(btTimes);
            Controls.Add(btMultiplied);
            Controls.Add(btPlus);
            Controls.Add(tbDisplay);
            Name = "Calculator";
            Text = "Caculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisplay;
        private Button btPlus;
        private Button btMultiplied;
        private Button btTimes;
        private Button btMinus;
        private Button bt2;
        private Button bt3;
        private Button btClear;
        private Button bt1;
        private Button bt5;
        private Button bt6;
        private Button btEquals;
        private Button bt4;
        private Button bt8;
        private Button bt9;
        private Button bt0;
        private Button bt7;
        private TextBox tbError;
        private Button btBackword;
        private Button btPoint;
        private Button btFactorial;
        private Button btLn;
        private Button btLog;
        private Button btSqrt;
        private Button btSquare;
        private Button btMod;
        private Button btCubic;
    }
}
