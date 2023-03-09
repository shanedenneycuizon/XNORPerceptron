using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PerceptronAlgorithm_XNOR.Perceptron;

namespace PerceptronAlgorithm_XNOR
{
    public partial class Form1 : Form
    {
        Perceptron p = new Perceptron();
        int[] output;
        public Form1()
        {
            InitializeComponent();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            p.setw1(Convert.ToInt32(w1.Text));
            p.setw2(Convert.ToInt32(w2.Text));
            p.setB(Convert.ToInt32(b.Text));
            p.setlr(Convert.ToDouble(lr.Text));
        }

        private void train_btn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < +100; i++)
            {
                p.Train();
            }
            output = p.getOutput();
            output_txt.Text = Convert.ToString(output[0])+"\n"+ Convert.ToString(output[1]) + "\n" + Convert.ToString(output[2]) + "\n" + Convert.ToString(output[3]);
        }
    }
}
