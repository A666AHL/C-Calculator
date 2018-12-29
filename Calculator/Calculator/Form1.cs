using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private string input_text = "";

        private void left_kuohao_Click(object sender, EventArgs e)
        {
            input.Text += "(";
            input_text += "(";
        }

        private void right_kuohao_Click(object sender, EventArgs e)
        {
            input.Text += ")";
            input_text += ")";
        }

        private void del_Click(object sender, EventArgs e)
        {
            int input_len = input.Text.Length;
            int input_text_len = input_text.Length;
            if(input.Text != "")
            {
                input.Text = input.Text.Remove(input_len - 1);
            }
            if(input_text != "")
            {
                input_text = input_text.Remove(input_text_len - 1);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            input.Text = "";
            input_text = "";
            output.Text = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            input.Text += "+";
            input_text += "+";
        }

        private void Jian_Click(object sender, EventArgs e)
        {
            input.Text += "-";
            input_text += "-";
        }

        private void Cheng_Click(object sender, EventArgs e)
        {
            input.Text += "×";
            input_text += "*";
        }

        private void Chu_Click(object sender, EventArgs e)
        {
            input.Text += "÷";
            input_text += "/";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            input.Text += "3";
            input_text += "3";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            input.Text += "2";
            input_text += "2";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            input.Text += "1";
            input_text += "1";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            input.Text += "4";
            input_text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            input.Text += "5";
            input_text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            input.Text += "6";
            input_text += "6";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            input.Text += ".";
            input_text += ".";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            input.Text += "7";
            input_text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            input.Text += "8";
            input_text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            input.Text += "9";
            input_text += "9";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(input_text);
            string output_text = input_text;
            if(output_text == "")
            {
                MessageBox.Show("请用Calculator上的按键进行输入");
            }
            //先将整个式子加上两个括号
            output_text += ")";
            output_text = output_text.Insert(0, "(");
            int output_text_len = output_text.Length;
            //算出这个式子最高有多少级括号，例如(1+(1+1))为两级
            //为了方便在这就不计算它的级数，因为我发现的级数最高为"("或”)"的个数
            //但这肯定在非特殊情况下多循环几次
            int jishu = 0;
            for(int i=0;i < output_text_len - 1;i++)
            {
                if(output_text[i] == '(')
                {
                    jishu++;
                }
            }
            for(int m = 0;m < jishu; m++)//需要循环最高级数次
            {
                //这个算法只是进行对最低级的括号进行计算
                for (int i = 0; i < output_text_len - 1; i++)
                {
                    if (output_text[i] == '(')
                    {
                        for (int j = i + 1; j < output_text_len; j++)
                        {
                            string shuxuebiaodashi = "";
                            if (output_text[j] == ')')
                            {
                                for (int k = i + 1; k <= j - 1; k++)
                                {
                                    shuxuebiaodashi += output_text[k];
                                }
                                //shuxuebiadashi是一个不带括号的数学表达式（字符串类型）
                                string Cal_result = Cal_shuxuebiaodashi(shuxuebiaodashi);
                                //将(num_qian*num_hou)删掉换成Cal_result
                                output_text = output_text.Insert(i, Cal_result);
                                output_text = output_text.Remove(i + Cal_result.Length, j - i + 1);
                                output_text_len = output_text_len - (j - i + 1) + Cal_result.Length;
                                i = i + Cal_result.Length - 1;
                                break;
                            }
                            else if (output_text[j] == '(')
                            {
                                break;
                            }
                        }
                    }
                }
            }
            output.Text = "=" + output_text;
        }
        //在这定义一个算法来进行对不带括号的数学表达式（字符串类型）进行计算
        private string Cal_shuxuebiaodashi(string shuxuebiadashi)
        {
            string math_str = shuxuebiadashi;
            int math_str_len = math_str.Length;
            //MessageBox.Show(shuxuebiadashi);//检查数学表达式是否传进来
            //MessageBox.Show(math_str_len.ToString());
            //对cos、sin、√进行计算
            for (int i = 0; i < math_str_len - 1; i++)
            {
                if (math_str[i] == 'i' || math_str[i] == 'o'||math_str[i] == '√')
                {
                    string num_hou = "";//记录运算符后面的数字
                    int zuihou = 0;//记录num_hou最后一个数字对应的index
                    //找num_hou
                    for (int j = i + 1; j < math_str_len; j++)
                    {
                        if (j == math_str_len - 1)
                        {
                            zuihou = math_str_len - 1;
                            for (int k = i + 1; k <= zuihou; k++)
                            {
                                num_hou += math_str[k];
                            }
                            break;
                        }
                        else if (math_str[j] == '*' || math_str[j] == '/' || math_str[j] == '+' || math_str[j] == '-')
                        {
                            zuihou = j - 1;
                            for (int k = i + 1; k <= zuihou; k++)
                            {
                                num_hou += math_str[k];
                            }
                            break;
                        }
                    }

                    string qianhou = "";
                    if (math_str[i] == 'o')
                    {
                        num_hou = num_hou.Remove(0, 1);
                        qianhou = Math.Cos(float.Parse(num_hou) * Math.PI / 180 ).ToString();
                        math_str = math_str.Insert(i-1,qianhou);
                        math_str = math_str.Remove(i - 1 + qianhou.Length, zuihou - i + 2);
                        math_str_len = math_str_len - (zuihou - i + 2) + qianhou.Length;
                        i = i + qianhou.Length - 2;//下次循环得从新的数的下一个字符开始；
                    }
                    else if(math_str[i] == 'i')
                    {
                        num_hou = num_hou.Remove(0, 1);
                        qianhou = Math.Sin(float.Parse(num_hou) * Math.PI / 180).ToString();
                        math_str = math_str.Insert(i - 1, qianhou);
                        math_str = math_str.Remove(i - 1 + qianhou.Length, zuihou - i + 2);
                        math_str_len = math_str_len - (zuihou - i + 2) + qianhou.Length;
                        i = i + qianhou.Length - 2;//下次循环得从新的数的下一个字符开始；
                    }
                    else if(math_str[i] == '√')
                    {
                        qianhou = Math.Sqrt(float.Parse(num_hou)).ToString();
                        math_str = math_str.Insert(i, qianhou);
                        math_str = math_str.Remove(i + qianhou.Length, zuihou - i + 1);
                        math_str_len = math_str_len - (zuihou - i + 1) + qianhou.Length;
                        i = i + qianhou.Length - 1;//下次循环得从新的数的下一个字符开始；
                    }
                }
            }
            //对平方进行计算
            for (int i=1;i<math_str_len;i++)
            {
                if (math_str[i] == '²')
                {
                    string num_qian = "";//记录运算符前面的数字
                    int zuiqian = 0;//记录num_qian第一个数字对应的index
                    //找num_qian
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            zuiqian = 0;
                            for (int k = zuiqian; k <= i - 1; k++)
                            {
                                num_qian += math_str[k];
                            }
                            break;
                        }
                        else if (math_str[j] == '*' || math_str[j] == '/' || math_str[j] == '+' || math_str[j] == '-')
                        {
                            zuiqian = j + 1;
                            for (int k = zuiqian; k <= i - 1; k++)
                            {
                                num_qian += math_str[k];
                            }
                            break;
                        }
                    }

                    //把num_qian²删掉换成qianhou
                    string qianhou = "";
                    qianhou = (float.Parse(num_qian) * float.Parse(num_qian)).ToString();
                    math_str = math_str.Insert(zuiqian, qianhou);
                    math_str = math_str.Remove(zuiqian + qianhou.Length, i - zuiqian + 1);
                    math_str_len = math_str_len - (i - zuiqian + 1) + qianhou.Length;
                    i = zuiqian + qianhou.Length - 1;//下次循环得从新的数的下一个字符开始；
                }
            }
            //对乘法和除法进行计算
            for(int i = 1;i < math_str_len - 1;i++)
            {
                if(math_str[i] == '*' || math_str[i] == '/')
                {
                    string num_hou = "";//记录运算符后面的数字
                    int zuihou = 0;//记录num_hou最后一个数字对应的index
                    //找num_hou
                    for (int j = i + 1; j < math_str_len; j++)
                    {
                        if (j == math_str_len - 1)
                        {
                            zuihou = math_str_len - 1;
                            for (int k = i + 1; k <= zuihou; k++)
                            {
                                num_hou += math_str[k];
                            }
                            break;
                        }
                        else if (math_str[j] == '*' || math_str[j] == '/' || math_str[j] == '+' || math_str[j] == '-')
                        {
                            zuihou = j - 1;
                            for (int k = i + 1; k <= zuihou; k++)
                            {
                                num_hou += math_str[k];
                            }
                            break;
                        }
                    }
                    string num_qian = "";//记录运算符前面的数字
                    int zuiqian = 0;//记录num_qian第一个数字对应的index
                    //找num_qian
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            zuiqian = 0;
                            for (int k = zuiqian; k <= i - 1; k++)
                            {
                                num_qian += math_str[k];
                            }
                            break;
                        }
                        else if (math_str[j] == '*' || math_str[j] == '/' || math_str[j] == '+' || math_str[j] == '-')
                        {
                            zuiqian = j + 1;
                            for (int k = zuiqian; k <= i - 1; k++)
                            {
                                num_qian += math_str[k];
                            }
                            break;
                        }
                    }
                    //把num_qian* num_hou或num_qian/ num_hou删掉换成qianhou
                    
                    string qianhou = "";
                    if (math_str[i] == '*')
                    { qianhou = (float.Parse(num_qian) * float.Parse(num_hou)).ToString(); }
                    if (math_str[i] == '/' && float.Parse(num_hou) != 0)
                    { qianhou = (float.Parse(num_qian) / float.Parse(num_hou)).ToString(); }
                    else if (math_str[i] == '/' && float.Parse(num_hou) == 0)
                    { MessageBox.Show("您的除数不能为0！"); }
                    math_str = math_str.Insert(zuiqian, qianhou);
                    math_str = math_str.Remove(zuiqian+qianhou.Length, zuihou - zuiqian+1);
                    math_str_len = math_str_len - (zuihou - zuiqian+1) + qianhou.Length;
                    i = zuiqian + qianhou.Length - 1;//下次循环得从新的数的下一个字符开始；
                }
            }
            //对加法和减法进行计算
            for (int i = 1; i < math_str_len - 1; i++)
            {
                if (math_str[i] == '+' || math_str[i] == '-')
                {
                    string num_hou = "";//记录运算符后面的数字
                    int zuihou = 0;//记录num_hou最后一个数字对应的index
                    //找num_hou
                    for (int j = i + 1; j < math_str_len; j++)
                    {
                        if (j == math_str_len - 1)
                        {
                            zuihou = math_str_len - 1;
                            for (int k = i + 1; k <= zuihou; k++)
                            {
                                num_hou += math_str[k];
                            }
                            break;
                        }
                        else if (math_str[j] == '+' || math_str[j] == '-')
                        {
                            zuihou = j - 1;
                            for (int k = i + 1; k <= zuihou; k++)
                            {
                                num_hou += math_str[k];
                            }
                            break;
                        }
                    }
                    string num_qian = "";//记录运算符后面的数字
                    int zuiqian = 0;//记录num_qian第一个数字对应的index
                    //找num_qian
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            zuiqian = 0;
                            for (int k = zuiqian; k <= i - 1; k++)
                            {
                                num_qian += math_str[k];
                            }
                            break;
                        }
                        else if (math_str[j] == '+' || math_str[j] == '-')
                        {
                            zuiqian = j + 1;
                            for (int k = zuiqian; k <= i - 1; k++)
                            {
                                num_qian += math_str[k];
                            }
                            break;
                        }
                    }
                    //把num_qian* num_hou或num_qian/ num_hou删掉换成qianhou

                    string qianhou = "";
                    if (math_str[i] == '+')
                    { qianhou = (float.Parse(num_qian) + float.Parse(num_hou)).ToString(); }
                    if (math_str[i] == '-')
                    { qianhou = (float.Parse(num_qian) - float.Parse(num_hou)).ToString(); }
                    math_str = math_str.Insert(zuiqian, qianhou);
                    math_str = math_str.Remove(zuiqian + qianhou.Length, zuihou - zuiqian + 1);
                    math_str_len = math_str_len - (zuihou - zuiqian + 1) + qianhou.Length;
                    i = zuiqian + qianhou.Length - 1;//下次循环得从新的数的下一个字符开始；
                }
            }
            //MessageBox.Show(math_str);
            return math_str;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            input.Text += "0";
            input_text += "0";
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            input.Text += "√";
            input_text += "√";
        }

        private void Show_Click(object sender, EventArgs e)
        {
            Sqrt.Visible = true;
            sin.Visible = true;
            cos.Visible = true;
            square.Visible = true;
        }

        private void sin_Click(object sender, EventArgs e)
        {
            input.Text += "sin";
            input_text += "sin";
        }

        private void cos_Click(object sender, EventArgs e)
        {
            input.Text += "cos";
            input_text += "cos";
        }

        private void square_Click(object sender, EventArgs e)
        {
            input.Text += "²";
            input_text += "²";
        }
    }
}
