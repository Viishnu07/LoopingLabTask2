using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopingLabTask2
{
    public partial class Form1 : Form
    {
        List<double> userinput = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userinput.Add(double.Parse(textNum.Text.ToString()));

            textNum.Clear();
            textNum.Focus();

            if (userinput.Count == 5)
            {
                button1.Enabled = false;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < userinput.Count; i++)
            {
                listBox1.Items.Add(userinput.ElementAt(i));

            }
            lblAvg.Text = (userinput.Sum() / userinput.Count).ToString();

            userinput.Sort();

            lblBiggest.Text = userinput.Last().ToString();

            lblSmallest.Text = userinput.First().ToString();

        }
    }
}
