namespace calculator {
    public partial class Calculator : Form {
        public Calculator() {
            // 初始化
            InitializeComponent();
        }

        private string def_operator = ""; // 运算符
        private double result = 0; // 运算结果
        private double number1 = 0; // 文本框中第一次操作数
        private double number2 = 0; // 文本框中第二次操作数
        private bool exist_value = false; // 文本框内容状态值

        /*
         * 常规按键（0~9，.）设置
         */
        // 0~9 键盘输入模板
        private void template_operand(string operand) {
            tbDisplay.Text += operand;
            exist_value = true;
        }

        private void bt1_Click(object sender, EventArgs e) {
            template_operand("1");
        }

        private void bt2_Click(object sender, EventArgs e) {
            template_operand("2");
        }

        private void bt3_Click(object sender, EventArgs e) {
            template_operand("3");
        }

        private void bt4_Click(object sender, EventArgs e) {
            template_operand("4");
        }

        private void bt5_Click(object sender, EventArgs e) {
            template_operand("5");
        }

        private void bt6_Click(object sender, EventArgs e) {
            template_operand("6");
        }

        private void bt7_Click(object sender, EventArgs e) {
            template_operand("7");
        }

        private void bt8_Click(object sender, EventArgs e) {
            template_operand("8");
        }

        private void bt9_Click(object sender, EventArgs e) {
            template_operand("9");
        }

        private void bt0_Click(object sender, EventArgs e) {
                template_operand("0");
        }

        // 小数点按键设置
        private void btPoint_Click(object sender, EventArgs e) {
            if (tbDisplay.Text == "") {
                tbError.Text = "不能以.开头！";
                tbDisplay.Text = "";
                exist_value = false;
            } else
                template_operand(".");
        }

        /*
         * 运算符设置
         */
        // 运算符模板
        private void tempate_operation(string def_operator) {
            if (exist_value) {
                number1 = double.Parse(tbDisplay.Text);
                this.def_operator = def_operator;
                tbDisplay.Text = "";
                exist_value = false;
            } else {
                tbError.Text = "操作数不能为空！";
            }
        }

        //
        // 运算符基本功能
        //
        private void btPlus_Click(object sender, EventArgs e) {
            tempate_operation("+");

        }
        private void btMinus_Click(object sender, EventArgs e) {
            tempate_operation("-");
        }
        private void btTimes_Click(object sender, EventArgs e) {
            tempate_operation("*");
        }
        private void btMultiplied_Click(object sender, EventArgs e) {
            tempate_operation("/");
        }
        private void btClear_Click(object sender, EventArgs e) {
            tbDisplay.Text = "";
        }

        //
        // 补充功能
        // 
        // 平方
        private void btSquare_Click(object sender, EventArgs e) {
            if (exist_value) {
                number1 = double.Parse(tbDisplay.Text);
                tbDisplay.Text = Convert.ToString(number1 * number1);
            } else
                tbError.Text = "操作数不能为空！";
        }

        // 三次方
        private void btCubic_Click(object sender, EventArgs e) {
            if (exist_value) {
                number1 = double.Parse(tbDisplay.Text);
                tbDisplay.Text = Convert.ToString(number1 * number1 * number1);
            } else
                tbError.Text = "操作数不能为空！";
        }

        // 倒数
        private void btBackword_Click(object sender, EventArgs e) {
            if (exist_value && tbDisplay.Text != "0") {
                number1 = double.Parse(tbDisplay.Text);
                tbDisplay.Text = Convert.ToString(1 / number1);
            } else if (tbDisplay.Text == "0") {
                tbError.Text = "除数不能为0！";
            } else
                tbError.Text = "操作数不能为空！";
        }

        // 阶乘实际运算
        private double factorial(double number) {
            double fact = 1.0;
            if ((number / 1) > 0)
                for (double k = 2.0; k <= number; ++k)
                    fact *= k;
            return fact;
        }

        // 阶乘
        private void btFactorial_Click(object sender, EventArgs e) {
            if (exist_value) {
                number1 = double.Parse(tbDisplay.Text);
                // 进行阶乘运算，舍弃小数点后数据
                tbDisplay.Text = Convert.ToString(factorial(Math.Truncate(number1)));
            } else
                tbError.Text = "操作数不能为空！";
        }

        // 自然对数
        private void btLn_Click(object sender, EventArgs e) {
            if (exist_value) {
                number1 = double.Parse(tbDisplay.Text);
                // Log函数默认以Math.E作为底
                tbDisplay.Text = Convert.ToString(Math.Log(number1));
            } else
                tbError.Text = "操作数不能为空！";
        }

        // 对数
        private void btLog_Click(object sender, EventArgs e) {
            if (exist_value) {
                number1 = double.Parse(tbDisplay.Text);
                tbError.Text = "请输入底数！";
                tbDisplay.Text = "";
                exist_value = false;
                def_operator = "log";
            } else
                tbError.Text = "操作数不能为空！";
        }

        // 取模
        private void btMod_Click(object sender, EventArgs e) {
            if (exist_value) {
                number1 = double.Parse(tbDisplay.Text);
                tbError.Text = "请输入模数！";
                tbDisplay.Text = "";
                exist_value = false;
                def_operator = "mod";
            } else
                tbError.Text = "操作数不能为空！";
        }

        // 开根号
        private void btSqrt_Click(object sender, EventArgs e) {
            if (exist_value) {
                number1 = double.Parse(tbDisplay.Text);
                tbDisplay.Text = Convert.ToString(Math.Sqrt(number1));
            } else
                tbError.Text = "操作数不能为空！";
        }

        // 运算符判断运算
        private void run() {
            switch (def_operator) {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0) {
                        tbError.Text = "除数不能为0！";
                        return;
                    } else {
                        result = number1 / number2;
                    }
                    break;
                case "log":
                    result = Math.Log(number1, number2);
                    break;
                case "mod":
                    result = number1 % number2;
                    break;
                default:
                    // 冗余，按键无法输入额外运算符
                    tbError.Text = "无效运算符！";
                    return;
            }
        }

        // 等号结果运算
        private void btEquals_Click(object sender, EventArgs e) {
            // 输入的第二个数就等于number2
            if (tbDisplay.Text.Trim() == "") {
                tbError.Text = "操作数不能为空！";
                return;
            }else 
                number2 = double.Parse(tbDisplay.Text);
            run();
            exist_value = true;
            tbDisplay.Text = Convert.ToString(result);
        }
    }
}
