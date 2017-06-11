using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Task
{
    public class img
    {
        int N, M;//Dimensional of each element(image)
        public double []ImgVector;//image vector length of M*N
        //----------------------------------------------------------
        public img(int n,int m)
        {
            this.M = m;
            this.N = n;
            ImgVector = new double[N * M];
        }
        //----------------------------------------------------------
    }
}
