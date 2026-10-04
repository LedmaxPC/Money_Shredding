using System;
using System.Windows.Forms;

namespace DesktopApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            maskedTextBox1.Mask = "";

            button1.Click -= button1_Click;
            button1.Click -= button1_Click_1;
            button1.Click += button1_Click_1;

            Gizlet();
        }

        private void Gizlet()
        {
            pictureBox1.Visible = label2.Visible = false;
            pictureBox2.Visible = label3.Visible = false;
            pictureBox3.Visible = label4.Visible = false;
            pictureBox4.Visible = label5.Visible = false;
            pictureBox5.Visible = label6.Visible = false;
            pictureBox6.Visible = label7.Visible = false;
            pictureBox7.Visible = label8.Visible = false;
            pictureBox8.Visible = label9.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Gizlet();

            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Məbləğ daxil edin", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int mebleg;

            if (!int.TryParse(maskedTextBox1.Text, out mebleg))
            {
                MessageBox.Show("Düzgün tam ədəd daxil edin", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mebleg <= 0)
            {
                MessageBox.Show("Mənfi və ya sıfır məbləğ xırdalanmaz", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mebleg == 1)
            {
                MessageBox.Show("1 manatdan kiçik əskinas olmadığı üçün xırdalamaq mümkün deyil", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qaliq = mebleg;

            // 500 manat
            if (mebleg > 500 && qaliq >= 500)
            {
                label9.Text = qaliq / 500 + " ədəd";
                qaliq = qaliq % 500;

                pictureBox8.Visible = true;
                label9.Visible = true;
            }

            // 200 manat
            if (mebleg > 200 && qaliq >= 200)
            {
                label8.Text = qaliq / 200 + " ədəd";
                qaliq = qaliq % 200;

                pictureBox7.Visible = true;
                label8.Visible = true;
            }

            // 100 manat
            if (mebleg > 100 && qaliq >= 100)
            {
                label7.Text = qaliq / 100 + " ədəd";
                qaliq = qaliq % 100;

                pictureBox6.Visible = true;
                label7.Visible = true;
            }

            // 50 manat
            if (mebleg > 50 && qaliq >= 50)
            {
                label6.Text = qaliq / 50 + " ədəd";
                qaliq = qaliq % 50;

                pictureBox5.Visible = true;
                label6.Visible = true;
            }

            // 20 manat
            if (mebleg > 20 && qaliq >= 20)
            {
                label5.Text = qaliq / 20 + " ədəd";
                qaliq = qaliq % 20;

                pictureBox4.Visible = true;
                label5.Visible = true;
            }

            // 10 manat
            if (mebleg > 10 && qaliq >= 10)
            {
                label4.Text = qaliq / 10 + " ədəd";
                qaliq = qaliq % 10;

                pictureBox3.Visible = true;
                label4.Visible = true;
            }

            // 5 manat
            if (mebleg > 5 && qaliq >= 5)
            {
                label3.Text = qaliq / 5 + " ədəd";
                qaliq = qaliq % 5;

                pictureBox2.Visible = true;
                label3.Visible = true;
            }

            // 1 manat
            if (qaliq > 0)
            {
                label2.Text = qaliq + " ədəd";

                pictureBox1.Visible = true;
                label2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox5_Click(object sender, EventArgs e) { }
        private void pictureBox6_Click(object sender, EventArgs e) { }
        private void pictureBox7_Click(object sender, EventArgs e) { }
        private void pictureBox8_Click(object sender, EventArgs e) { }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void maskedTextBox1_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
    }
}