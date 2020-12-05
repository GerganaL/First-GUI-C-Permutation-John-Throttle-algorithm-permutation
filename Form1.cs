using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermutationChars
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            int value;


            try
            {

                value = int.Parse(textBox1.Text);


                Permutation perm = new Permutation(textBox2.Text);
                if (!(value == textBox2.Text.Length))
                {
                    MessageBox.Show("Трябва да въведете N на брой символи", "This app GUI");
                }
                perm.n = value;
                perm.txtResult = txtResult;
                txtResult.Text = "";
                perm.createPermutation();
            }

            catch
            {



                MessageBox.Show("Моля въведете число!", "This app GUI");




            }

        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            try
            {

                value = int.Parse(textBox1.Text);

                string input = textBox2.Text;
                int length = input.Length;

                if (length == value)
                {

                }
                else {

                    MessageBox.Show("You must enter N count symbols!",  "app GUI");
                }

            }

            catch
            {


                MessageBox.Show("You must enter a numer!", "Permutation app GUI");



            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
