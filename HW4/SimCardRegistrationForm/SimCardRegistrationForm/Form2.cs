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
    public partial class Form2 : Form
    {

        public Form2(MaskedTextBox mobile, TextBox fname, TextBox lname, RadioButton male, RadioButton female, TextBox status, DateTimePicker birthday, TextBox location, PictureBox picture)
        {
            InitializeComponent();
                   
            maskedTextBox1.Text = mobile.Text;
            textBox2.Text = fname.Text;
            textBox3.Text = lname.Text;
            radioButton1.Checked = male.Checked;
            radioButton2.Checked = female.Checked;
            textBox4.Text = status.Text;
            dateTimePicker1.Value = birthday.Value;
            textBox5.Text = location.Text;
            pictureBox1.Image = picture.Image;

        }
    }
}
