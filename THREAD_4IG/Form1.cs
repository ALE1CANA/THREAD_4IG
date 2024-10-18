using System;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;
namespace THREAD_4IG
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Label[] lbltempo;
        private int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbltempo=new System.Windows.Forms.Label[100];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lbltempo[cont]=new System.Windows.Forms.Label();
            lbltempo[cont].Location=new Point((cont%10)*100,cont/10*100);
            lbltempo[cont].Font = new Font(FontFamily.Families[0], 36);
            lbltempo[cont].Size = new Size(100, 100);
            this.Controls.Add(lbltempo[cont]);
            lbltempo[cont].Text=NumericUpDown1.Value.ToString();
            int i = cont;
            Thread threadTimer = new Thread(() => timer(i));
            threadtimer.Start();
            cont++;
        }

        private void timer(int i)
        {
            int tempo = Convert.ToInt32(lbltempo[i].Text);

            while(tempo> 0) 
            {
                Thread.Sleep(1000);
                tempo--;
                this.Invoke(() =>
                {
                    MessageBox.Show("BOOM!");
                });
        }

    }
}
