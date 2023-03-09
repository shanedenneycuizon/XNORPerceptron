using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PerceptronAlgorithm_XNOR.XNORTruthTable;

namespace PerceptronAlgorithm_XNOR
{
    public class Perceptron
    {
        private double w1 = 0;
        private double w1new = 0;
        private double w2 = 0;
        private double w2new = 0;
        private double b = 0;
        private double bnew = 0;
        private double lr = 1;
        private int[] y_expected = { 1, -1, -1, 1 };
        private int[] y_output= { 0,0,0,0};
        int[,] Xnor_numbers = { {-1, -1,  1 },
                                {-1,  1, -1 },
                                { 1, -1, -1 },
                                { 1,  1,  1 }
                              };

        public Perceptron()
        {

        }
        public Perceptron(int w1, int w2, int b, double lr)
        {
            this.w1 = w1;
            this.w2 = w2;
            this.b = b;
            this.lr = lr;
        }
        public void setw1(int w1)
        {
            this.w1 = w1;
        }
        public void setw2(int w2)
        {
            this.w2 = w2;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public void setlr(double lr)
        {
            this.lr = lr;
        }

        public void Train()
        {
                for (int row = 0; row < 4; row++)
                {
                    int x1 = Xnor_numbers[row, 0];
                    int x2 = Xnor_numbers[row, 1];
                    int eo = Xnor_numbers[row, 2]; //expected output
                    Console.WriteLine(x1 + " " + x2 + " " + eo);
                    double tempy = (x1 * w1) + (x2 * w2);
                    Console.WriteLine("tempy:" + tempy);
                    if (tempy > 0)
                    {
                        y_output[row] = 1;
                    }
                    else
                    {
                        y_output[row] = -1;
                    }
                    if (y_output[row] != y_expected[row])
                    {
                        w1new = (w1) + (lr) * (eo) * (x1);
                        w1 = w1new;
                        w2new = w2 + ((lr) * (eo) * (x1));
                        w2 = w2new;
                    }
                    //bnew = b + ((lr) * (eo));
                    //b = bnew;
                }
            Console.WriteLine(y_output[0] + ", " + y_output[1] + ", " + y_output[2] + ", " + y_output[3]);
        }
        public int[] getOutput()
        {
            return y_output.ToArray();
        }
    }
}
