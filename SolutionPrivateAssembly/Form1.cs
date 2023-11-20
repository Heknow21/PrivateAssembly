using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace SolutionPrivateAssembly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ComboBoxOperation.Items.Add("+");
            ComboBoxOperation.Items.Add("*");
            ComboBoxOperation.Items.Add("-");
            ComboBoxOperation.Items.Add("/");
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Add("Total: " + Environment.NewLine + "00000"); 
        }
        private void btn_Compute_Click(object sender, EventArgs e)
        {
            if (txtBox_number1.Text == "" && txtBox_number2.Text == "")
            {
                MessageBox.Show("Invalid number input");
            }

            else if (ComboBoxOperation.Text == "")
            {
                MessageBox.Show("Invalid operation input");
            }

            else
            {
               
                float number1 = (float)Convert.ToDouble(txtBox_number1.Text);
                float number2 = (float)Convert.ToDouble(txtBox_number2.Text);


       



                if (ComboBoxOperation.Text == "+")
                {
                    listView1.Items.Clear();
                    float computed = BasicCompute.Addition(number1, number2);
                    string end = computed.ToString();
                    listView1.Items.Add("Total: " + end);
                    
                }

                else if (ComboBoxOperation.Text == "-")
                {
                    listView1.Items.Clear();
                    float computed = BasicCompute.Subtraction(number1, number2);
                    string end = computed.ToString();
                    listView1.Items.Add("Total: " + end);
                    
                }

                else if (ComboBoxOperation.Text == "*")
                {
                    listView1.Items.Clear();
                    float computed = BasicCompute.Multiplication(number1, number2);
                    string end = computed.ToString();
                    listView1.Items.Add("Total: " + end);
                    
                }

                else if (ComboBoxOperation.Text == "/")
                {
                    listView1.Items.Clear();
                    float computed = BasicCompute.Division(number1, number2);
                    string end = computed.ToString();
                    listView1.Items.Add("Total: " + end);
                    
                }

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
 
