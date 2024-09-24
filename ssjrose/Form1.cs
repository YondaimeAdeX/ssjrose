using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssjrose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = radioButton2.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = radioButton3.Checked;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Visible = radioButton4.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("Ahmet Erkul Mesleki ve Teknik Anadolu Lisesi"),("Okulumuz"),(MessageBoxButtons.YesNoCancel),(MessageBoxIcon.Question));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba" + " " + textBox1.Text, "Selamlama", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string isim,soyisim;
            isim = textBox2.Text;
            soyisim = textBox3.Text;
            label4.Text = isim+" "+soyisim;
            soyisim = textBox3.Text;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ekleme İşlemi Başarılı", "Mesaj",MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silme İşlemi Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text);
            MessageBox.Show(textBox4.Text + " " + "Başarıyla Eklendi", "Bilgi");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox4.Text);
            listBox2.Items.Remove(textBox4.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
