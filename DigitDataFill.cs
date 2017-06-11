using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NN_Task
{
    public class DigitDataFill
    {
        public static bool With_Pca = false;
        public static int N = 30, M = 30;
        public static string trainPath = @"E:\1-2-3-4-materials\4th year materials\Nural Network\NN Phase 2\DataSet\Training\";
        public static string testPath = @"E:\1-2-3-4-materials\4th year materials\Nural Network\NN Phase 2\DataSet\Test\";

        #region img
        public static img[] _5 = new img[110];//100 for train 100 for test
        public static img[] _6 = new img[110];
        public static img[] _7 = new img[110];
        public static img[] _8 = new img[110];
        public static img[] _9 = new img[110];

        #endregion

        #region digits arrays

        public static double[,] Digit_5_Training = new double[100, 900];
        public static double[,] Digit_5_Testing = new double[10, 900];
        public static double[,] Digit_6_Training = new double[100, 900];
        public static double[,] Digit_6_Testing = new double[10, 900];
        public static double[,] Digit_7_Training = new double[100, 900];
        public static double[,] Digit_7_Testing = new double[10, 900];
        public static double[,] Digit_8_Training = new double[100, 900];
        public static double[,] Digit_8_Testing = new double[10, 900];
        public static double[,] Digit_9_Training = new double[100, 900];
        public static double[,] Digit_9_Testing = new double[10, 900];
        public static double[] SingleFile = new double[900];

        #endregion

        public static void init()
        {
            for (int i = 0; i < 110; i++)
            {
                _5[i] = new img(N, M);
                _6[i] = new img(N, M);
                _7[i] = new img(N, M);
                _8[i] = new img(N, M);
                _9[i] = new img(N, M);
            }

        }

        #region training
        public static void Fill_Training_data()
        {


            string s;// Read line by line from the files

            //================================================================ Fill digit 5

            #region 5
            int Mean;
            for (int i = 1; i <= 100; i++)
            {
                Mean = 0;
                FileStream FS = new FileStream(trainPath + @"5\" + i.ToString() + ".txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                int lineNum = 0;
                int indx = 0;
                while (SR.Peek() != -1)
                {
                    s = SR.ReadLine();
                    for (int y = 0; y < s.Length; y++)
                    {
                        if (s[y] != ' ')
                        {
                            //################################################################### PCA ISCO
                            if (With_Pca)
                                _5[i - 1].ImgVector[indx] = s[y] - '0';
                            //###################################################################

                            Digit_5_Training[i - 1, indx] = s[y] - '0';
                            Mean += (int)Digit_5_Training[i - 1, indx++];
                        }
                    }
                    lineNum++;
                }
                Normalize(Mean / (double)900.0, i - 1, ref Digit_5_Training);
                if (With_Pca)
                    Normalize(((double)Mean / (double)900.0), ref _5[i - 1].ImgVector);

            }
            #endregion

            //================================================================ Fill digit 6

            #region 6

            for (int i = 1; i <= 100; i++)
            {
                Mean = 0;
                FileStream FS = new FileStream(trainPath + @"6\" + i.ToString() + ".txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                int lineNum = 0, indx = 0;
                while (SR.Peek() != -1)
                {
                    s = SR.ReadLine();
                    for (int y = 0; y < s.Length; y++)
                    {
                        if (s[y] != ' ')
                        {
                            //################################################################### PCA ISCO
                            if (With_Pca)
                                _6[i - 1].ImgVector[indx] = s[y] - '0';
                            //###################################################################
                            Digit_6_Training[i - 1, indx] = s[y] - '0';
                            Mean += (int)Digit_6_Training[i - 1, indx++];
                        }
                    }
                    lineNum++;
                }
                Normalize(Mean / (double)900.0, i - 1, ref Digit_6_Training);
                if (With_Pca)

                    Normalize(((double)Mean / (double)900.0), ref _6[i - 1].ImgVector);
            }

            #endregion

            //================================================================ Fill digit 7

            #region 7
            for (int i = 1; i <= 100; i++)
            {
                Mean = 0;
                FileStream FS = new FileStream(trainPath + @"7\" + i.ToString() + ".txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                int lineNum = 0, indx = 0;
                while (SR.Peek() != -1)
                {
                    s = SR.ReadLine();
                    for (int y = 0; y < s.Length; y++)
                    {
                        if (s[y] != ' ')
                        {
                            //################################################################### PCA ISCO
                            if (With_Pca)
                                _7[i - 1].ImgVector[indx] = s[y] - '0';
                            //###################################################################
                            Digit_7_Training[i - 1, indx] = s[y] - '0';
                            Mean += (int)Digit_7_Training[i - 1, indx++];
                        }
                    }
                    lineNum++;
                }
                Normalize(Mean / (double)900.0, i - 1, ref Digit_7_Training);
                if (With_Pca)

                    Normalize(((double)Mean / (double)900.0), ref _7[i - 1].ImgVector);
            }
            #endregion

            //================================================================ Fill digit 8

            #region 8

            for (int i = 1; i <= 100; i++)
            {
                Mean = 0;
                FileStream FS = new FileStream(trainPath + @"8\" + i.ToString() + ".txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                int lineNum = 0, indx = 0;
                while (SR.Peek() != -1)
                {
                    s = SR.ReadLine();
                    for (int y = 0; y < s.Length; y++)
                    {
                        if (s[y] != ' ')
                        {
                            //################################################################### PCA ISCO
                            if (With_Pca)
                                _8[i - 1].ImgVector[indx] = s[y] - '0';
                            //###################################################################
                            Digit_8_Training[i - 1, indx] = s[y] - '0';
                            Mean += (int)Digit_8_Training[i - 1, indx++];
                        }
                    }
                    lineNum++;
                }
                Normalize(Mean / (double)900.0, i - 1, ref Digit_8_Training);
                if (With_Pca)

                    Normalize(((double)Mean / (double)900.0), ref _8[i - 1].ImgVector);
            }
            #endregion

            //================================================================ Fill digit 9
            #region 9

            for (int i = 1; i <= 100; i++)
            {
                Mean = 0;
                FileStream FS = new FileStream(trainPath + @"9\" + i.ToString() + ".txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                int lineNum = 0, indx = 0;
                while (SR.Peek() != -1)
                {
                    s = SR.ReadLine();
                    for (int y = 0; y < s.Length; y++)
                    {
                        if (s[y] != ' ')
                        {
                            //################################################################### PCA ISCO
                            if (With_Pca)
                                _9[i - 1].ImgVector[indx] = s[y] - '0';
                            //###################################################################
                            Digit_9_Training[i - 1, indx] = s[y] - '0';
                            Mean += (int)Digit_9_Training[i - 1, indx++];
                        }
                    }
                    lineNum++;
                }
                Normalize(Mean / (double)900.0, i - 1, ref Digit_9_Training);
                if (With_Pca)
                    Normalize(((double)Mean / (double)900.0), ref _9[i - 1].ImgVector);
            }
            #endregion

        }
        #endregion

        #region Testing
        //-----------------------------------------------------------------------
        public static void Fill_Testing_data()
        {
            string s;// Read line by line from the files

            #region _5
            //================================================================ Fill digit 5
            int Mean;
            for (int i = 1; i <= 10; i++)
            {
                Mean = 0;
                FileStream FS = new FileStream(testPath + @"5\" + i.ToString() + ".txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                int lineNum = 0, indx = 0;
                while (SR.Peek() != -1)
                {
                    s = SR.ReadLine();
                    for (int y = 0; y < s.Length; y++)
                    {
                        if (s[y] != ' ')
                        {
                            //################################################################### PCA ISCO
                            if (With_Pca)
                                _5[(i - 1) + 100].ImgVector[indx] = s[y] - '0';
                            //###################################################################
                            Digit_5_Testing[i - 1, indx] = s[y] - '0';
                            Mean += (int)Digit_5_Testing[i - 1, indx++];
                        }
                    }
                    lineNum++;
                }
                Normalize(Mean / 900.0, i - 1, ref Digit_5_Testing);
                if (With_Pca)
                    Normalize(((double)Mean / 900.0), ref _5[100 + (i - 1)].ImgVector);


            }
            #endregion


            //================================================================ Fill digit 6

            #region 6
            for (int i = 1; i <= 10; i++)
            {
                Mean = 0;
                FileStream FS = new FileStream(testPath + @"6\" + i.ToString() + ".txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                int lineNum = 0, indx = 0;
                while (SR.Peek() != -1)
                {
                    s = SR.ReadLine();
                    for (int y = 0; y < s.Length; y++)
                    {
                        if (s[y] != ' ')
                        {

                            //################################################################### PCA ISCO
                            if (With_Pca)
                                _6[(i - 1) + 100].ImgVector[indx] = s[y] - '0';
                            //###################################################################

                            Digit_6_Testing[i - 1, indx] = s[y] - '0';
                            Mean += (int)Digit_6_Testing[i - 1, indx++];
                        }
                    }
                    lineNum++;
                }
                Normalize(Mean / 900.0, i - 1, ref Digit_6_Testing);
                if (With_Pca)
                    Normalize(((double)Mean / 900.0), ref _6[100 + (i - 1)].ImgVector);
            }
            #endregion


            //================================================================ Fill digit 7

            #region 7
            for (int i = 1; i <= 10; i++)
            {
                Mean = 0;
                FileStream FS = new FileStream(testPath + @"7\" + i.ToString() + ".txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                int lineNum = 0, indx = 0;
                while (SR.Peek() != -1)
                {
                    s = SR.ReadLine();
                    for (int y = 0; y < s.Length; y++)
                    {
                        if (s[y] != ' ')
                        {

                            //################################################################### PCA ISCO
                            if (With_Pca)
                                _7[(i - 1) + 100].ImgVector[indx] = s[y] - '0';
                            //###################################################################

                            Digit_7_Testing[i - 1, indx] = s[y] - '0';
                            Mean += (int)Digit_7_Testing[i - 1, indx++];
                        }
                    }
                    lineNum++;
                }
                Normalize(Mean / 900.0, i - 1, ref Digit_7_Testing);
                if (With_Pca)
                    Normalize(((double)Mean / 900.0), ref _7[100 + (i - 1)].ImgVector);
            }
            #endregion

            //================================================================ Fill digit 8
            #region 8

            for (int i = 1; i <= 10; i++)
            {
                Mean = 0;
                FileStream FS = new FileStream(testPath + @"8\" + i.ToString() + ".txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                int lineNum = 0, indx = 0;
                while (SR.Peek() != -1)
                {
                    s = SR.ReadLine();
                    for (int y = 0; y < s.Length; y++)
                    {
                        if (s[y] != ' ')
                        {

                            //################################################################### PCA ISCO
                            if (With_Pca)
                                _8[(i - 1) + 100].ImgVector[indx] = s[y] - '0';
                            //###################################################################

                            Digit_8_Testing[i - 1, indx] = s[y] - '0';
                            Mean += (int)Digit_8_Testing[i - 1, indx++];
                        }
                    }
                    lineNum++;
                }
                Normalize(Mean / 900.0, i - 1, ref Digit_8_Testing);
                if (With_Pca)
                    Normalize(((double)Mean / 900.0), ref _8[100 + (i - 1)].ImgVector);
            }
            #endregion
            //================================================================ Fill digit 9

            #region 9

            for (int i = 1; i <= 10; i++)
            {
                Mean = 0;
                FileStream FS = new FileStream(testPath + @"9\" + i.ToString() + ".txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                int lineNum = 0, indx = 0;
                while (SR.Peek() != -1)
                {
                    s = SR.ReadLine();
                    for (int y = 0; y < s.Length; y++)
                    {
                        if (s[y] != ' ')
                        {
                            //################################################################### PCA ISCO
                            if (With_Pca)
                                _9[(i - 1) + 100].ImgVector[indx] = s[y] - '0';
                            //###################################################################

                            Digit_9_Testing[i - 1, indx] = s[y] - '0';
                            Mean += (int)Digit_9_Testing[i - 1, indx++];
                        }
                    }
                    lineNum++;
                }
                Normalize(Mean / 900.0, i - 1, ref Digit_9_Testing);
                if (With_Pca)
                    Normalize(((double)Mean / 900.0), ref _9[100 + (i - 1)].ImgVector);
            }
        }
        #endregion

        //-----------------------------------------------------------------------
        public static void fill_single_file(string path)
        {
            string s;// Read line by line from the files
            int Mean = 0;
            FileStream FS = new FileStream(path, FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            int lineNum = 0, indx = 0;
            while (SR.Peek() != -1)
            {
                s = SR.ReadLine();
                for (int y = 0; y < s.Length; y++)
                {
                    if (s[y] != ' ')
                    {
                        SingleFile[indx] = s[y] - '0';
                        Mean += (int)SingleFile[indx++];
                    }
                }
                lineNum++;
            }
            Normalize(Mean / 900.0, ref SingleFile);


        }
        #endregion

        #region Normalize
        //-----------------------------------------------------------------------
        private static void Normalize(double mean, int ind, ref double[,] arr)
        {

            for (int y = 0; y < 900; y++)
            {
                arr[ind, y] -= mean;
            }
        }
        private static void Normalize(double mean, ref double[] arr)
        {

            for (int y = 0; y < 900; y++)
            {
                arr[y] -= mean;
            }
        } // overload for 2d single file 
    }
    #endregion

}