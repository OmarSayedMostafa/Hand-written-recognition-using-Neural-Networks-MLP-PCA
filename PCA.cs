using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Task
{
    class PCA
    {
        /*this class for Reduce data set -
         * just call ---------
         * reduce_data(int PCA_Number, double learning_rate,int epoch) ---
         * the reduced data will be in static vars _5,_6,_7,_8,_9 
         * access this 2D arrayes after call reduce_data(int PCA_Number, double learning_rate,int epoch);
         * 
         * remember just call reduce data
         */

        public static int N = 30, M = 30, PCA_N;
        static double LR;//learning rate
        public static Neuron[] neurons;


        #region reduced data
        public static double[,] _5;

        public static double[,] _6;

        public static double[,] _7;

        public static double[,] _8;

        public static double[,] _9;
        #endregion

        public static void read_data()
        {
            DigitDataFill.init();
            DigitDataFill.Fill_Training_data();
            DigitDataFill.Fill_Testing_data();

        }


        public static void SetPCA(int PCA_Number, double learning_rate, int epoch)
        {
            LR = learning_rate;
            PCA_N = PCA_Number;
            Random rand = new Random();
            #region set data
            ///----------------------------------------------------
            neurons = new Neuron[PCA_Number];
            ///----------------------------------------------------
            for (int i = 0; i < PCA_Number; i++)
            {
                neurons[i] = new Neuron();
                neurons[i].Inputs = new double[N * M];
                neurons[i].Weights = new double[N * M];
                for (int z = 0; z < (N * M); z++)
                {
                    neurons[i].Weights[z] = (double)rand.NextDouble();
                }
            }
            ///----------------------------------------------------
            read_data();
            ///----------------------------------------------------
            #endregion


            for (int EP = 0; EP < epoch; EP++)
            {
                Console.WriteLine("###################### Epoch NUMBER : "+(EP+1).ToString()+"   ######################");
                #region 5 6 7 8 9

                #region 5
                Console.WriteLine("files 5");
                for (int i = 0; i < DigitDataFill._5.Length; i++)
                {
                    for (int k = 0; k < PCA_Number; k++)
                    {
                        neurons[k].Inputs = DigitDataFill._5[i].ImgVector;
                        neurons[k].calculate_output();
                        //updateWeights(k);
                    }
                    for (int k = 0; k < PCA_Number; k++)
                    {
                        //                    neurons[k].Inputs = DigitDataFill._5[i].ImgVector;
                        //neurons[k].calculate_output();
                        updateWeights(k);
                    }
                }
                #endregion


                #region 6
                Console.WriteLine("files 6");

                for (int i = 0; i < DigitDataFill._6.Length; i++)
                {
                    for (int k = 0; k < PCA_Number; k++)
                    {
                        neurons[k].Inputs = DigitDataFill._6[i].ImgVector;
                        neurons[k].calculate_output();
                        //updateWeights(k);
                    }
                    for (int k = 0; k < PCA_Number; k++)
                    {
                        //       neurons[k].Inputs = DigitDataFill._6[i].ImgVector;
                        //neurons[k].calculate_output();
                        updateWeights(k);
                    }
                }
                #endregion


                #region 7
                Console.WriteLine("files 7");

                for (int i = 0; i < DigitDataFill._7.Length; i++)
                {
                    for (int k = 0; k < PCA_Number; k++)
                    {
                        neurons[k].Inputs = DigitDataFill._7[i].ImgVector;
                        neurons[k].calculate_output();
                        // updateWeights(k);
                    }
                    for (int k = 0; k < PCA_Number; k++)
                    {
                        //                      neurons[k].Inputs = DigitDataFill._7[i].ImgVector;
                        //neurons[k].calculate_output();
                        updateWeights(k);
                    }
                }
                #endregion


                #region 8
                Console.WriteLine("files 8");

                for (int i = 0; i < DigitDataFill._8.Length; i++)
                {
                    for (int k = 0; k < PCA_Number; k++)
                    {
                        neurons[k].Inputs = DigitDataFill._8[i].ImgVector;
                        neurons[k].calculate_output();
                        //updateWeights(k);
                    }
                    for (int k = 0; k < PCA_Number; k++)
                    {
                        neurons[k].Inputs = DigitDataFill._8[i].ImgVector;
                        //neurons[k].calculate_output();
                        updateWeights(k);
                    }
                }
                #endregion


                #region 9
                Console.WriteLine("files 9");

                for (int i = 0; i < DigitDataFill._9.Length; i++)
                {
                    for (int k = 0; k < PCA_Number; k++)
                    {
                        neurons[k].Inputs = DigitDataFill._9[i].ImgVector;
                        neurons[k].calculate_output();
                        // updateWeights(k);
                    }
                    for (int k = 0; k < PCA_Number; k++)
                    {
                        //                        neurons[k].Inputs = DigitDataFill._9[i].ImgVector;
                        // neurons[k].calculate_output();
                        updateWeights(k);
                    }
                }
                #endregion

                #endregion
            }


        }


        public static void updateWeights(int k)
        {
            double sum = 0;
            for (int i = 0; i < neurons[k].Weights.Length; i++)
            {
                sum = 0;
                for (int j = 0; j <= k; j++)
                {
                    sum += neurons[j].output * neurons[j].Weights[i];
                }

                neurons[k].Weights[i] += LR * neurons[k].output * (neurons[k].Inputs[i] - sum);
            }
        }


        public static void reduce_data(int PCA_Number, double learning_rate, int epoch)
        {

            SetPCA(PCA_Number, learning_rate, epoch);


            #region data vector after reduced
            _5 = new double[DigitDataFill._5.Length, PCA_Number];


            _6 = new double[DigitDataFill._6.Length, PCA_Number];

            _7 = new double[DigitDataFill._7.Length, PCA_Number];

            _8 = new double[DigitDataFill._8.Length, PCA_Number];

            _9 = new double[DigitDataFill._9.Length, PCA_Number];

            #endregion


            #region 5
            for (int i = 0; i < DigitDataFill._5.Length; i++)
            {
                for (int k = 0; k < PCA_Number; k++)
                {
                    neurons[k].Inputs = DigitDataFill._5[i].ImgVector;
                    //_5[i, k] = neurons[k].calculate_output();
                    _5[i, k] = neurons[k].output;

                }
            }
            #endregion


            #region 6
            for (int i = 0; i < DigitDataFill._6.Length; i++)
            {
                for (int k = 0; k < PCA_Number; k++)
                {
                    neurons[k].Inputs = DigitDataFill._6[i].ImgVector;
                    neurons[k].calculate_output();
                    _6[i, k] = neurons[k].output;

                }
            }
            #endregion


            #region 7
            for (int i = 0; i < DigitDataFill._7.Length; i++)
            {
                for (int k = 0; k < PCA_Number; k++)
                {
                    neurons[k].Inputs = DigitDataFill._7[i].ImgVector;
                    neurons[k].calculate_output();
                    _7[i, k] = neurons[k].output;

                }
            }
            #endregion


            #region 8
            for (int i = 0; i < DigitDataFill._8.Length; i++)
            {
                for (int k = 0; k < PCA_Number; k++)
                {
                    neurons[k].Inputs = DigitDataFill._8[i].ImgVector;
                    neurons[k].calculate_output();
                    _8[i, k] = neurons[k].output;

                }
            }
            #endregion


            #region 9
            for (int i = 0; i < DigitDataFill._9.Length; i++)
            {
                for (int k = 0; k < PCA_Number; k++)
                {
                    neurons[k].Inputs = DigitDataFill._9[i].ImgVector;
                    neurons[k].calculate_output();
                    _9[i, k] = neurons[k].output;

                }
            }
            #endregion
        }
    }
}