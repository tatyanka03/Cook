using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COOKSIMULATION
{
    public partial class Form1 : Form
    {
      
        public int lvl = 1;
        public Form1()
        {

            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
        }
        private void Form1_Load(object sender,  EventArgs e)
        {
            this.progressBar1.Maximum = 100;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Развивайте свою карьеру и следите за показателями! при полном упадке вы проиграте :(. Желаем удачи!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.Clear();

            {
                
                if (progressBar1.Value >= 1 && progressBar2.Value >= 1)
                {
                    progressBar1.Value--;
                    progressBar2.Value--;
                }

                if (progressBar1.Value == 0 && progressBar2.Value == 0)
                {
                    MessageBox.Show("Вы голодны, либо переусерствовали!");
                    MessageBox.Show("Вы проиграли(");
                }



            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
