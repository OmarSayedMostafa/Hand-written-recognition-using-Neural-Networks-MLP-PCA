namespace NN_Task
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hidden_layers_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Neurons_num_txt = new System.Windows.Forms.TextBox();
            this.Neurons_layer_label = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a_txt = new System.Windows.Forms.TextBox();
            this.Threshold_txt = new System.Windows.Forms.TextBox();
            this.Learning_Rate_txt = new System.Windows.Forms.TextBox();
            this.learn_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mismatchs_label = new System.Windows.Forms.Label();
            this.MSE_label = new System.Windows.Forms.Label();
            this.Accuracy_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tanh_chk = new System.Windows.Forms.CheckBox();
            this.Sigmoid_chk = new System.Windows.Forms.CheckBox();
            this.Browse_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Single_test_label = new System.Windows.Forms.Label();
            this.checkBoxPCA = new System.Windows.Forms.CheckBox();
            this.textBox1LR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEpochs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPCANum = new System.Windows.Forms.TextBox();
            this.groupBoxPCA = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPCA.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hidden_layers_txt
            // 
            this.Hidden_layers_txt.Location = new System.Drawing.Point(168, 87);
            this.Hidden_layers_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Hidden_layers_txt.Name = "Hidden_layers_txt";
            this.Hidden_layers_txt.Size = new System.Drawing.Size(132, 22);
            this.Hidden_layers_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hidden Layers";
            // 
            // Neurons_num_txt
            // 
            this.Neurons_num_txt.Location = new System.Drawing.Point(168, 139);
            this.Neurons_num_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Neurons_num_txt.Name = "Neurons_num_txt";
            this.Neurons_num_txt.Size = new System.Drawing.Size(132, 22);
            this.Neurons_num_txt.TabIndex = 7;
            // 
            // Neurons_layer_label
            // 
            this.Neurons_layer_label.AutoSize = true;
            this.Neurons_layer_label.Location = new System.Drawing.Point(29, 144);
            this.Neurons_layer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Neurons_layer_label.Name = "Neurons_layer_label";
            this.Neurons_layer_label.Size = new System.Drawing.Size(124, 17);
            this.Neurons_layer_label.TabIndex = 8;
            this.Neurons_layer_label.Text = "Neurons in layer 1";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(329, 138);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(100, 28);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "a (slop)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Learning rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Threshold";
            // 
            // a_txt
            // 
            this.a_txt.Location = new System.Drawing.Point(165, 283);
            this.a_txt.Margin = new System.Windows.Forms.Padding(4);
            this.a_txt.Name = "a_txt";
            this.a_txt.Size = new System.Drawing.Size(132, 22);
            this.a_txt.TabIndex = 13;
            // 
            // Threshold_txt
            // 
            this.Threshold_txt.Location = new System.Drawing.Point(165, 236);
            this.Threshold_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Threshold_txt.Name = "Threshold_txt";
            this.Threshold_txt.Size = new System.Drawing.Size(132, 22);
            this.Threshold_txt.TabIndex = 14;
            // 
            // Learning_Rate_txt
            // 
            this.Learning_Rate_txt.Location = new System.Drawing.Point(168, 188);
            this.Learning_Rate_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Learning_Rate_txt.Name = "Learning_Rate_txt";
            this.Learning_Rate_txt.Size = new System.Drawing.Size(132, 22);
            this.Learning_Rate_txt.TabIndex = 15;
            // 
            // learn_btn
            // 
            this.learn_btn.BackColor = System.Drawing.SystemColors.Control;
            this.learn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learn_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.learn_btn.Location = new System.Drawing.Point(1043, 413);
            this.learn_btn.Margin = new System.Windows.Forms.Padding(4);
            this.learn_btn.Name = "learn_btn";
            this.learn_btn.Size = new System.Drawing.Size(141, 55);
            this.learn_btn.TabIndex = 16;
            this.learn_btn.Text = "Run";
            this.learn_btn.UseVisualStyleBackColor = false;
            this.learn_btn.Click += new System.EventHandler(this.solve_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mismatchs_label);
            this.groupBox1.Controls.Add(this.MSE_label);
            this.groupBox1.Controls.Add(this.Accuracy_label);
            this.groupBox1.Location = new System.Drawing.Point(936, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(239, 142);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // Mismatchs_label
            // 
            this.Mismatchs_label.AutoSize = true;
            this.Mismatchs_label.Location = new System.Drawing.Point(9, 68);
            this.Mismatchs_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mismatchs_label.Name = "Mismatchs_label";
            this.Mismatchs_label.Size = new System.Drawing.Size(0, 17);
            this.Mismatchs_label.TabIndex = 6;
            // 
            // MSE_label
            // 
            this.MSE_label.AutoSize = true;
            this.MSE_label.Location = new System.Drawing.Point(9, 110);
            this.MSE_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MSE_label.Name = "MSE_label";
            this.MSE_label.Size = new System.Drawing.Size(0, 17);
            this.MSE_label.TabIndex = 5;
            // 
            // Accuracy_label
            // 
            this.Accuracy_label.AutoSize = true;
            this.Accuracy_label.Location = new System.Drawing.Point(64, 31);
            this.Accuracy_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Accuracy_label.Name = "Accuracy_label";
            this.Accuracy_label.Size = new System.Drawing.Size(0, 17);
            this.Accuracy_label.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tanh_chk);
            this.groupBox2.Controls.Add(this.Sigmoid_chk);
            this.groupBox2.Location = new System.Drawing.Point(333, 190);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(197, 94);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activation Function";
            // 
            // Tanh_chk
            // 
            this.Tanh_chk.AutoSize = true;
            this.Tanh_chk.Location = new System.Drawing.Point(8, 58);
            this.Tanh_chk.Margin = new System.Windows.Forms.Padding(4);
            this.Tanh_chk.Name = "Tanh_chk";
            this.Tanh_chk.Size = new System.Drawing.Size(63, 21);
            this.Tanh_chk.TabIndex = 1;
            this.Tanh_chk.Text = "Tanh";
            this.Tanh_chk.UseVisualStyleBackColor = true;
            // 
            // Sigmoid_chk
            // 
            this.Sigmoid_chk.AutoSize = true;
            this.Sigmoid_chk.Location = new System.Drawing.Point(8, 27);
            this.Sigmoid_chk.Margin = new System.Windows.Forms.Padding(4);
            this.Sigmoid_chk.Name = "Sigmoid_chk";
            this.Sigmoid_chk.Size = new System.Drawing.Size(80, 21);
            this.Sigmoid_chk.TabIndex = 0;
            this.Sigmoid_chk.Text = "Sigmoid";
            this.Sigmoid_chk.UseVisualStyleBackColor = true;
            // 
            // Browse_btn
            // 
            this.Browse_btn.Location = new System.Drawing.Point(936, 203);
            this.Browse_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(100, 28);
            this.Browse_btn.TabIndex = 19;
            this.Browse_btn.Text = "Browse";
            this.Browse_btn.UseVisualStyleBackColor = true;
            this.Browse_btn.Click += new System.EventHandler(this.Browse_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Single_test_label
            // 
            this.Single_test_label.AutoSize = true;
            this.Single_test_label.Location = new System.Drawing.Point(1072, 208);
            this.Single_test_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Single_test_label.Name = "Single_test_label";
            this.Single_test_label.Size = new System.Drawing.Size(0, 17);
            this.Single_test_label.TabIndex = 20;
            // 
            // checkBoxPCA
            // 
            this.checkBoxPCA.AutoSize = true;
            this.checkBoxPCA.Location = new System.Drawing.Point(572, 22);
            this.checkBoxPCA.Name = "checkBoxPCA";
            this.checkBoxPCA.Size = new System.Drawing.Size(57, 21);
            this.checkBoxPCA.TabIndex = 21;
            this.checkBoxPCA.Text = "PCA";
            this.checkBoxPCA.UseVisualStyleBackColor = true;
            this.checkBoxPCA.CheckedChanged += new System.EventHandler(this.checkBoxPCA_CheckedChanged);
            // 
            // textBox1LR
            // 
            this.textBox1LR.Location = new System.Drawing.Point(166, 151);
            this.textBox1LR.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1LR.Name = "textBox1LR";
            this.textBox1LR.Size = new System.Drawing.Size(60, 22);
            this.textBox1LR.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "PCA Learning rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Epochs";
            // 
            // textBoxEpochs
            // 
            this.textBoxEpochs.Location = new System.Drawing.Point(166, 102);
            this.textBoxEpochs.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEpochs.Name = "textBoxEpochs";
            this.textBoxEpochs.Size = new System.Drawing.Size(60, 22);
            this.textBoxEpochs.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "PCA Number";
            // 
            // textBoxPCANum
            // 
            this.textBoxPCANum.Location = new System.Drawing.Point(166, 62);
            this.textBoxPCANum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPCANum.Name = "textBoxPCANum";
            this.textBoxPCANum.Size = new System.Drawing.Size(60, 22);
            this.textBoxPCANum.TabIndex = 22;
            // 
            // groupBoxPCA
            // 
            this.groupBoxPCA.Controls.Add(this.label7);
            this.groupBoxPCA.Controls.Add(this.textBox1LR);
            this.groupBoxPCA.Controls.Add(this.textBoxPCANum);
            this.groupBoxPCA.Controls.Add(this.label5);
            this.groupBoxPCA.Controls.Add(this.textBoxEpochs);
            this.groupBoxPCA.Controls.Add(this.label6);
            this.groupBoxPCA.Location = new System.Drawing.Point(572, 71);
            this.groupBoxPCA.Name = "groupBoxPCA";
            this.groupBoxPCA.Size = new System.Drawing.Size(329, 213);
            this.groupBoxPCA.TabIndex = 28;
            this.groupBoxPCA.TabStop = false;
            this.groupBoxPCA.Text = "PCA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1197, 481);
            this.Controls.Add(this.groupBoxPCA);
            this.Controls.Add(this.checkBoxPCA);
            this.Controls.Add(this.Single_test_label);
            this.Controls.Add(this.Browse_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.learn_btn);
            this.Controls.Add(this.Learning_Rate_txt);
            this.Controls.Add(this.Threshold_txt);
            this.Controls.Add(this.a_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.Neurons_layer_label);
            this.Controls.Add(this.Neurons_num_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hidden_layers_txt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPCA.ResumeLayout(false);
            this.groupBoxPCA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Hidden_layers_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Neurons_num_txt;
        private System.Windows.Forms.Label Neurons_layer_label;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox a_txt;
        private System.Windows.Forms.TextBox Threshold_txt;
        private System.Windows.Forms.TextBox Learning_Rate_txt;
        private System.Windows.Forms.Button learn_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Accuracy_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Tanh_chk;
        private System.Windows.Forms.CheckBox Sigmoid_chk;
        private System.Windows.Forms.Label MSE_label;
        private System.Windows.Forms.Label Mismatchs_label;
        private System.Windows.Forms.Button Browse_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Single_test_label;
        private System.Windows.Forms.CheckBox checkBoxPCA;
        private System.Windows.Forms.TextBox textBox1LR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEpochs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPCANum;
        private System.Windows.Forms.GroupBox groupBoxPCA;
    }
}

