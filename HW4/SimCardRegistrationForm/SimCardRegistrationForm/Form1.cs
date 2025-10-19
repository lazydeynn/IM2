using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCardRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Form2 frm2 = new Form2(maskedTextBox1, textBox2, textBox3, radioButton1, radioButton2, textBox4, dateTimePicker1, textBox5, pictureBox1);
          frm2.Show();
          this.Hide();
          frm2.FormClosed += (s,args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select an Image";
            dialog.Filter = "Image Files | *.jpg;*.jpeg;*.png";
            DialogResult dr = dialog.ShowDialog();
            if(dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }         
        }       
    }
}
