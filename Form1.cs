using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NN_Task
{
    public partial class Form1 : Form
    {
        #region initialize data
        List<List<Neuron>> Layers = new List<List<Neuron>>();// All layers without input layer
        List<Neuron> layer; // temp for earch layer 
        int LayerNum;
        string file;
        bool Browse_btn_clicked = false;
        #endregion


        #region form constructor
        public Form1()
        {
            InitializeComponent();
            groupBoxPCA.Hide();
            LayerNum = 1;
            file = "!";// intialization to check if it changed or not
        }
        #endregion


        #region buttons



        //Add layers
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (LayerNum > int.Parse(Hidden_layers_txt.Text))
            {
                MessageBox.Show("Layers Number is over");
                return;
            }
            layer = new List<Neuron>();
            for (int i = 0; i < int.Parse(Neurons_num_txt.Text); i++) layer.Add(new Neuron());
            Layers.Add(layer);
            LayerNum++;
            Neurons_layer_label.Text = "Neurons in layer " + LayerNum.ToString();

        }


        //Run 
        private void solve_btn_Click(object sender, EventArgs e)
        {
            #region PCA check
            if(checkBoxPCA.Checked==true)
            {
                DigitDataFill.With_Pca = true;
                PCA.reduce_data(int.Parse(textBoxPCANum.Text.ToString()),double.Parse(textBox1LR.Text.ToString()),int.Parse(textBoxEpochs.Text.ToString()));
                //Data Stored in PCA._5 PCA._6 PCA._7  PCA._8  PCA._9 
            }
            #endregion
                    
                BackProbagation obj = new BackProbagation(double.Parse(Threshold_txt.Text), double.Parse(a_txt.Text), double.Parse(Learning_Rate_txt.Text), Sigmoid_chk.Checked, file);
                obj.StartLearning(ref Layers);
                obj.StartTesting(ref Layers, ref Accuracy_label, ref MSE_label, ref Mismatchs_label);
                if (Browse_btn_clicked)
                    obj.SingleTest(ref Layers, ref Single_test_label);           
        }



        //browse
        private void Browse_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                Browse_btn_clicked = true;

            }
        }



        #endregion


        #region check box
        private void checkBoxPCA_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPCA.Checked==true)
            {
                groupBoxPCA.Show();
            }
            else
            {
                groupBoxPCA.Hide();
            }
        }
        #endregion

    }
}
