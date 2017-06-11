using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NN_Task
{
    class BackProbagation
    {
        Random R = new Random();
        double MSE = double.MaxValue, threshould, a, learning_rate, epochs = 0;
        //DigitDataFill digits;
        bool sigmoid;// to know if sigmoid checkbox is checked or tanh 
        public BackProbagation(double threshould, double a, double learning_rate, bool sigmoid, string Single_file_Path)
        {
            //digits = new DigitDataFill();
            if (!DigitDataFill.With_Pca)
            {
                DigitDataFill.Fill_Training_data();
                DigitDataFill.Fill_Testing_data();

                if (Single_file_Path != "!")// if browser button is clicked
                    DigitDataFill.fill_single_file(Single_file_Path);
            }
            this.learning_rate = learning_rate;
            this.threshould = threshould;
            this.a = a;
            this.sigmoid = sigmoid;

        }
        
        public void StartLearning(ref List<List<Neuron>> Layers)
        {
            //================================================================================= add output layer of 5 Neurons
            List<Neuron> layer;
            layer = new List<Neuron>();
            for (int i = 0; i < 5; i++) layer.Add(new Neuron());
            Layers.Add(layer);
            //===================================================================================
            bool digit_5_firstPic = true;//====================== to randmoize (inputs + weights + bias) only in first pic in digit 4

            while (MSE > threshould && epochs < 100000)
            {
                MSE = 0;//==================== intialize with zero every epoch 
                epochs++;

                //===================================== Digit 5
                for (int y = 0; y < DigitDataFill.Digit_5_Training.GetLength(0); y++)
                {
                    forward(ref Layers, y, 5, digit_5_firstPic, true, false);
                    digit_5_firstPic = false;// 34an my3ml4 randmize tany 
                    backward(ref Layers, y, 5);
                    feed_forward(ref Layers, y);
                }
                //===================================== Digit 6
                for (int y = 0; y < DigitDataFill.Digit_6_Training.GetLength(0); y++)
                {
                    forward(ref Layers, y, 6, digit_5_firstPic, true, false);
                    backward(ref Layers, y, 6);
                    feed_forward(ref Layers, y);
                }
                //===================================== Digit 7
                for (int y = 0; y < DigitDataFill.Digit_7_Training.GetLength(0); y++)
                {
                    forward(ref Layers, y, 7, digit_5_firstPic, true, false);
                    backward(ref Layers, y, 7);
                    feed_forward(ref Layers, y);
                }
                //===================================== Digit 8
                for (int y = 0; y < DigitDataFill.Digit_8_Training.GetLength(0); y++)
                {
                    forward(ref Layers, y, 8, digit_5_firstPic, true, false);
                    backward(ref Layers, y, 8);
                    feed_forward(ref Layers, y);
                }
                //===================================== Digit 9
                for (int y = 0; y < DigitDataFill.Digit_9_Training.GetLength(0); y++)
                {
                    forward(ref Layers, y, 9, digit_5_firstPic, true, false);
                    backward(ref Layers, y, 9);
                    feed_forward(ref Layers, y);
                }
                //===================================== Calculate MSE
                Calculate_MSE(ref Layers);
                Console.WriteLine(epochs + "   " + MSE);
            }
        }

        public void forward(ref List<List<Neuron>> Layers, int y, int digit, bool digit_5_First_pic, bool training, bool singlFile)
        {
            //========================================================================== awl layer el awl lw7do
            for (int i = 0; i < Layers[0].Count; i++)
            {
                if (digit == 5 && digit_5_First_pic)// b3ml intialize b new f awl sora f awl digit bs
                {
                    Layers[0][i].Inputs = new double[900];// 34an el sora 30*30
                    Layers[0][i].Weights = new double[900];
                    Layers[0][i].Bias_weight = (double)R.NextDouble();
                }
                int indx = 0;

                for (int ii = 0; ii < ((!DigitDataFill.With_Pca)?900:PCA.PCA_N); ii++)
                {

                    if (training)// if it training 
                    {
                        if (digit == 5)
                            Layers[0][i].Inputs[indx] = (!DigitDataFill.With_Pca)?DigitDataFill.Digit_5_Training[y, ii]:(PCA._5[y,ii]);
                        else if (digit == 6)
                            Layers[0][i].Inputs[indx] = (!DigitDataFill.With_Pca) ? DigitDataFill.Digit_6_Training[y, ii] : (PCA._6[y, ii]);
                        else if (digit == 7)
                            Layers[0][i].Inputs[indx] = (!DigitDataFill.With_Pca) ? DigitDataFill.Digit_7_Training[y, ii] : (PCA._7[y, ii]);
                        else if (digit == 8)
                            Layers[0][i].Inputs[indx] = (!DigitDataFill.With_Pca) ? DigitDataFill.Digit_8_Training[y, ii] : (PCA._8[y, ii]) ;
                        else
                            Layers[0][i].Inputs[indx] = (!DigitDataFill.With_Pca) ? DigitDataFill.Digit_9_Training[y, ii] : (PCA._9[y, ii]); ;
                    }
                    else if (singlFile)
                        Layers[0][i].Inputs[indx] = DigitDataFill.SingleFile[ii];

                    else
                    {
                        if (digit == 5)
                            Layers[0][i].Inputs[indx] = (!DigitDataFill.With_Pca) ? DigitDataFill.Digit_5_Testing[y, ii] : (PCA._5[y+100, ii]);
                        else if (digit == 6)
                            Layers[0][i].Inputs[indx] = (!DigitDataFill.With_Pca) ? DigitDataFill.Digit_6_Testing[y, ii] : (PCA._6[y + 100, ii]);
                        else if (digit == 7)
                            Layers[0][i].Inputs[indx] = (!DigitDataFill.With_Pca) ? DigitDataFill.Digit_7_Testing[y, ii] : (PCA._7[y + 100, ii]);
                        else if (digit == 8)
                            Layers[0][i].Inputs[indx] = (!DigitDataFill.With_Pca) ? DigitDataFill.Digit_8_Testing[y, ii] : (PCA._8[y + 100, ii]);
                        else
                            Layers[0][i].Inputs[indx] = (!DigitDataFill.With_Pca) ? DigitDataFill.Digit_9_Testing[y, ii] : (PCA._9[y + 100, ii]);
                    }

                    if (digit == 5 && digit_5_First_pic)//// random f awl  pic bs
                        Layers[0][i].Weights[indx] = (double)R.NextDouble();

                    indx++;
                }

                if (sigmoid)
                    Layers[0][i].FillOutput_Sigmoid(a);
                else
                    Layers[0][i].FillOutput_tanh(a);

            }

            //===================================================================== ba2y el layers
            for (int i = 1; i < Layers.Count; i++)
            {
                for (int yy = 0; yy < Layers[i].Count; yy++)
                {
                    if (digit == 5 && digit_5_First_pic)
                    {
                        Layers[i][yy].Inputs = new double[Layers[i - 1].Count];
                        Layers[i][yy].Weights = new double[Layers[i - 1].Count];
                        Layers[i][yy].Bias_weight = (double)R.NextDouble();
                    }
                    for (int ii = 0; ii < Layers[i - 1].Count; ii++)// loop 3la el neurons ely f el layer ely ably 
                    {
                        Layers[i][yy].Inputs[ii] = Layers[i - 1][ii].output;
                        if (digit == 5 && digit_5_First_pic)
                            Layers[i][yy].Weights[ii] = (double)R.NextDouble();
                    }
                    if (sigmoid)
                        Layers[i][yy].FillOutput_Sigmoid(a);
                    else
                        Layers[i][yy].FillOutput_tanh(a);
                }
            }
        }

        public void backward(ref List<List<Neuron>> Layers, int y, int digit)
        {
            //=======================================================n7sb el error ll output el awl 
            for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
            {
                if (sigmoid)
                {
                    if (digit == 5 && i == 0) //==============(desired-output)*f'(v)
                        Layers[Layers.Count - 1][i].Error = (1.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].SigmoidDervative(a);
                    else if (digit == 6 && i == 1)
                        Layers[Layers.Count - 1][i].Error = (1.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].SigmoidDervative(a);
                    else if (digit == 7 && i == 2)
                        Layers[Layers.Count - 1][i].Error = (1.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].SigmoidDervative(a);
                    else if (digit == 8 && i == 3)
                        Layers[Layers.Count - 1][i].Error = (1.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].SigmoidDervative(a);
                    else if (digit == 9 && i == 4)
                        Layers[Layers.Count - 1][i].Error = (1.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].SigmoidDervative(a);
                    else
                        Layers[Layers.Count - 1][i].Error = (0.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].SigmoidDervative(a);
                }
                else
                {

                    if (digit == 5 && i == 0) //==============(desired-output)*f'(v)
                        Layers[Layers.Count - 1][i].Error = (1.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].TanhDervative();
                    else if (digit == 6 && i == 1)
                        Layers[Layers.Count - 1][i].Error = (1.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].TanhDervative();
                    else if (digit == 7 && i == 2)
                        Layers[Layers.Count - 1][i].Error = (1.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].TanhDervative();
                    else if (digit == 8 && i == 3)
                        Layers[Layers.Count - 1][i].Error = (1.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].TanhDervative();
                    else if (digit == 9 && i == 4)
                        Layers[Layers.Count - 1][i].Error = (1.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].TanhDervative();
                    else
                        Layers[Layers.Count - 1][i].Error = (0.0 - Layers[Layers.Count - 1][i].output) * Layers[Layers.Count - 1][i].TanhDervative();

                }
            }
            //========================================================ba2y el layers

            //calculate signal error for each neuron in each layer
            for (int i = Layers.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < Layers[i].Count; j++)
                {
                    Layers[i][j].Error = 0;
                    for (int k = 0; k < Layers[i + 1].Count; k++)
                    {
                        Layers[i][j].Error += (Layers[i + 1][k].Weights[j] * Layers[i + 1][k].Error);
                    }
                    if (sigmoid)
                        Layers[i][j].Error *= Layers[i][j].SigmoidDervative(a);
                    else
                        Layers[i][j].Error *= Layers[i][j].TanhDervative();

                }
            }
        }

        public void feed_forward(ref List<List<Neuron>> Layers, int y)
        {
            for (int i = 0; i < Layers.Count(); i++)
            {
                for (int j = 0; j < Layers[i].Count(); j++)
                {
                    Layers[i][j].Bias_weight += (learning_rate * Layers[i][j].Error);
                    for (int k = 0; k < Layers[i][j].Weights.Count(); k++)
                    {
                        Layers[i][j].Weights[k] += (learning_rate * Layers[i][j].Inputs[k] * Layers[i][j].Error);
                    }
                }
            }
        }

        public void Calculate_MSE(ref List<List<Neuron>> Layers)
        {
            double tmp;

            //================================================================================= Get MSE in digit 5 
            for (int y = 0; y < DigitDataFill.Digit_5_Training.GetLength(0); y++)
            {
                forward(ref Layers, y, 5, false, true, false);
                tmp = 0;

                for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
                {
                    if (i == 0)
                        tmp = (1.0 - Layers[Layers.Count - 1][i].output);
                    else
                        tmp = (0.0 - Layers[Layers.Count - 1][i].output);

                    MSE += (tmp * tmp) / (double)2.0;
                }
            }
            //================================================================================= Get MSE in digit 6

            for (int y = 0; y < DigitDataFill.Digit_6_Training.GetLength(0); y++)
            {
                forward(ref Layers, y, 6, false, true, false);
                tmp = 0;

                for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
                {
                    if (i == 1)
                        tmp = (1.0 - Layers[Layers.Count - 1][i].output);
                    else
                        tmp = (0.0 - Layers[Layers.Count - 1][i].output);

                    MSE += (tmp * tmp) / (double)2.0;
                }
            }
            //================================================================================= Get MSE in digit 7 

            for (int y = 0; y < DigitDataFill.Digit_7_Training.GetLength(0); y++)
            {
                forward(ref Layers, y, 7, false, true, false);
                tmp = 0;

                for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
                {
                    if (i == 2)
                        tmp = (1.0 - Layers[Layers.Count - 1][i].output);
                    else
                        tmp = (0.0 - Layers[Layers.Count - 1][i].output);

                    MSE += (tmp * tmp) / (double)2.0;
                }
            }
            //================================================================================= Get MSE in digit 8 

            for (int y = 0; y < DigitDataFill.Digit_8_Training.GetLength(0); y++)
            {
                forward(ref Layers, y, 8, false, true, false);

                tmp = 0;

                for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
                {
                    if (i == 3)
                        tmp = (1.0 - Layers[Layers.Count - 1][i].output);
                    else
                        tmp = (0.0 - Layers[Layers.Count - 1][i].output);

                    MSE += (tmp * tmp) / (double)2.0;
                }
            }

            //================================================================================= Get MSe in digit 9 

            for (int y = 0; y < DigitDataFill.Digit_9_Training.GetLength(0); y++)
            {
                forward(ref Layers, y, 9, false, true, false);
                tmp = 0;

                for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
                {
                    if (i == 4)
                        tmp = (1.0 - Layers[Layers.Count - 1][i].output);
                    else
                        tmp = (0.0 - Layers[Layers.Count - 1][i].output);

                    MSE += (tmp * tmp) / (double)2.0;
                }
            }

            // MSE /= (double)(5 * (DigitDataFill.Digit_9_Training.GetLength(0) + DigitDataFill.Digit_8_Training.GetLength(0) + DigitDataFill.Digit_7_Training.GetLength(0) + DigitDataFill.Digit_6_Training.GetLength(0) + DigitDataFill.Digit_5_Training.GetLength(0)));
        }

        public void StartTesting(ref List<List<Neuron>> Layers, ref Label accuracy_label, ref Label MSE_label, ref Label MisMatches_label)
        {
            double Matching_samples = 0;
            double tmp = 0, indx = 0;

            //================================================================================= Testing Digit 5
            for (int y = 0; y < DigitDataFill.Digit_5_Testing.GetLength(0); y++)
            {
                forward(ref Layers, y, 5, false, false, false);
                tmp = 0;
                indx = 0;

                for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
                {
                    if (Layers[Layers.Count - 1][i].output > tmp)// get max output and its index and map it as 1 
                    {
                        tmp = Layers[Layers.Count - 1][i].output;
                        indx = i;
                    }

                }
                if (indx == 0) Matching_samples++;
            }
            //================================================================================= Testing Digit 6 
            for (int y = 0; y < DigitDataFill.Digit_6_Testing.GetLength(0); y++)
            {
                forward(ref Layers, y, 6, false, false, false);
                tmp = 0;
                indx = 0;
                for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
                {
                    if (Layers[Layers.Count - 1][i].output > tmp)
                    {
                        tmp = Layers[Layers.Count - 1][i].output;
                        indx = i;
                    }
                }
                if (indx == 1) Matching_samples++;
            }
            //================================================================================= Testing digit 7
            for (int y = 0; y < DigitDataFill.Digit_7_Testing.GetLength(0); y++)
            {
                forward(ref Layers, y, 7, false, false, false);
                tmp = 0;
                indx = 0;
                for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
                {
                    if (Layers[Layers.Count - 1][i].output > tmp)
                    {
                        tmp = Layers[Layers.Count - 1][i].output;
                        indx = i;
                    }

                }
                if (indx == 2) Matching_samples++;
            }
            //================================================================================= Testing digit 8
            for (int y = 0; y < DigitDataFill.Digit_8_Testing.GetLength(0); y++)
            {
                forward(ref Layers, y, 8, false, false, false);
                tmp = 0;
                indx = 0;
                for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
                {
                    if (Layers[Layers.Count - 1][i].output > tmp)
                    {
                        tmp = Layers[Layers.Count - 1][i].output;
                        indx = i;
                    }
                }
                if (indx == 3) Matching_samples++;
            }
            //================================================================================= Testing digit 9 
            for (int y = 0; y < DigitDataFill.Digit_9_Testing.GetLength(0); y++)
            {
                forward(ref Layers, y, 9, false, false, false);
                tmp = 0;
                indx = 0;
                for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
                {
                    if (Layers[Layers.Count - 1][i].output > tmp)
                    {
                        tmp = Layers[Layers.Count - 1][i].output;
                        indx = i;
                    }

                }
                if (indx == 4) Matching_samples++;
            }
            //================================================= Build results
            double MisMatches_sambles = 50 - Matching_samples;
            MisMatches_label.Text = "Mismatching samples are " + MisMatches_sambles.ToString();
            Matching_samples /= 50.0;
            Matching_samples *= 100;
            accuracy_label.Text = "Accuracy IS " + Matching_samples.ToString() + " %";
            MSE_label.Text = "MSE IS " + MSE.ToString();
        }

        public void SingleTest(ref List<List<Neuron>> Layers, ref Label singleTest_Label)
        {
            forward(ref Layers, 0, 0, false, false, true);
            double tmp = 0;
            double indx = 0;

            for (int i = 0; i < Layers[Layers.Count - 1].Count; i++)
            {
                if (Layers[Layers.Count - 1][i].output > tmp)// get max output and its index and map it as 1 
                {
                    tmp = Layers[Layers.Count - 1][i].output;
                    indx = i;
                }

            }
            if (indx == 0) singleTest_Label.Text = "The Digit is 5";
            else if (indx == 1) singleTest_Label.Text = "The Digit is 6";
            else if (indx == 2) singleTest_Label.Text = "The Digit is 7";
            else if (indx == 3) singleTest_Label.Text = "The Digit is 8";
            else if (indx == 4) singleTest_Label.Text = "The Digit is 9";
        }
    }
}