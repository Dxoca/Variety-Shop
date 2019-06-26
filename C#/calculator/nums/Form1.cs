using System;

using System.Windows.Forms;

namespace nums
{
    public partial class Form1 : Form
    {
        static double endnums = 0;//最后结果
        static String numfirst, numlast;//符号前后数字
        static String fuhao;//符号
        static int iffl = 1;//判断符号前后数字
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
  
        private void button11_Click(object sender, EventArgs e)
        {//加法
            fuhaobian("+");
        }

        private void button10_Click(object sender, EventArgs e)
        {//减法
            fuhaobian("-"); 
        }
        private void button15_Click(object sender, EventArgs e)
        {//乘法
            fuhaobian("*");
        }
        private void button14_Click(object sender, EventArgs e)
        {//欻=除法 
            fuhaobian("/");
        }
        private void button13_Click(object sender, EventArgs e)
        {//%
            fuhaobian("%");
        }

        private void button18_Click(object sender, EventArgs e)
        {//根号
            fuhaobian("√");
        }

        private void button17_Click(object sender, EventArgs e)
        {//sin
            fuhaobian("sin");
        }

        private void button16_Click(object sender, EventArgs e)
        {//cos
            fuhaobian("cos");
        }
        private void button21_Click(object sender, EventArgs e)
        {//归零
            iffl = 0;//前后判断制令
            numfirst = numlast = "0";//恢复
            richTextBox1.Text = "";
            endnums = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {//数字1
            richTextBox1.Text = richTextBox1.Text + "1";
            if (iffl == 1)
                numfirst = numfirst + "1";//符号之前
            else
                numlast = numlast + "1";//符号之前
        }//1 数字键盘
        private void button2_Click(object sender, EventArgs e)
        {//数字2
            richTextBox1.Text = richTextBox1.Text + "2";
            if (iffl == 1)//前面的数字
                numfirst = numfirst + "2";//符号之前
            else//后面的数字
                numlast = numlast + "2";//符号之前
        }
        private void button3_Click(object sender, EventArgs e)
        {//数字3
            richTextBox1.Text = richTextBox1.Text + "3";
            if (iffl == 1)//前面的数字
                numfirst = numfirst + "3";//符号之前
            else//后面的数字
                numlast = numlast + "3";//符号之前
        }
        private void button4_Click(object sender, EventArgs e)
        {//数字4
            richTextBox1.Text = richTextBox1.Text + "4";
            if (iffl == 1)//前面的数字
                numfirst = numfirst + "4";//符号之前
            else//后面的数字
                numlast = numlast + "4";//符号之前
        }
        private void button5_Click(object sender, EventArgs e)
        {//数字5
            richTextBox1.Text = richTextBox1.Text + "5";
            if (iffl == 1)//前面的数字
                numfirst = numfirst + "5";//符号之前
            else//后面的数字
                numlast = numlast + "5";//符号之前
        }
        private void button6_Click(object sender, EventArgs e)
        {//数字6
            richTextBox1.Text = richTextBox1.Text + "6";
            if (iffl == 1)//前面的数字
                numfirst = numfirst + "6";//符号之前
            else//后面的数字
                numlast = numlast + "6";//符号之前
        }
        private void button7_Click(object sender, EventArgs e)
        {//数字7
            richTextBox1.Text = richTextBox1.Text + "7";
            if (iffl == 1)//前面的数字
                numfirst = numfirst + "7";//符号之前
            else//后面的数字
                numlast = numlast + "7";//符号之前
        }
        private void button8_Click(object sender, EventArgs e)
        {//数字8
            richTextBox1.Text = richTextBox1.Text + "8";
            if (iffl == 1)//前面的数字
                numfirst = numfirst + "8";//符号之前
            else//后面的数字
                numlast = numlast + "8";//符号之前
        }
        private void button9_Click(object sender, EventArgs e)
        {//数字9
            richTextBox1.Text = richTextBox1.Text + "9";
            if (iffl == 1)//前面的数字
                numfirst = numfirst + "9";//符号之前
            else//后面的数字
                numlast = numlast + "9";//符号之前
        }
        private void button12_Click(object sender, EventArgs e)
        {//0
            richTextBox1.Text = richTextBox1.Text + "0";
            if (iffl == 1)//前面的数字
                numfirst = numfirst + "0";//符号之前
            else//后面的数字
                numlast = numlast + "0";//符号之前
        }//0

       
        private void button20_Click(object sender, EventArgs e)
        {//结果
            
            if (fuhao == "+")
            {
                endnums = double.Parse(numfirst) + double.Parse(numlast);
                finals();
            }
            if (fuhao == "-")
            {
                endnums = double.Parse(numfirst) - double.Parse(numlast);
                finals();
            }
            if (fuhao == "*")
            {
                endnums = double.Parse(numfirst) * double.Parse(numlast);
                finals();
            }
            if (fuhao == "/")
            {
                endnums = double.Parse(numfirst) / double.Parse(numlast);
                finals();
            }
            if (fuhao == "%")
            {
                endnums = double.Parse(numfirst) % double.Parse(numlast);
                finals();
            }
            if (fuhao == "√")
            {
                endnums = Math.Round(Math.Sqrt(double.Parse(numfirst)),5);
                finals();
            }

            if (fuhao == "sin")
            {
                endnums = Math.Round(Math.Sin(double.Parse(numfirst)), 5);
                finals();
            }

            if (fuhao == "cos")
            {
                endnums = Math.Round(Math.Cos(double.Parse(numfirst)), 5);
                finals();
            }
        }
        public void finals(){
            numfirst = endnums.ToString();//全部加到first
            richTextBox1.Text += "= " + endnums + "\n"+ endnums;
            numlast = "";//清空后面数
        }
        public void  fuhaobian(string x){
            iffl++;//开始保存 符号后面的数字 ==2
            fuhao = x;
            richTextBox1.Text +=" "+x+" ";
        }
}
}
