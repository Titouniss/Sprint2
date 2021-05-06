using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoupGarou
{
    public partial class Plateforme : Form
    {
        public Plateforme()
        {
            InitializeComponent();
            Thread leTread = new Thread(new ThreadStart(CommunicationClient));
            leTread.Start();
        }
        public void CommunicationClient()
        {
            Server l = new Server(this,"127.0.0.1",2021);
            l.Run();
        }
            private void Plateforme_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tb_AdresseSOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bt_5_Click(object sender, EventArgs e)
        {

        }

        private void bt_2_Click(object sender, EventArgs e)
        {

        }

        private void bt__Click(object sender, EventArgs e)
        {

        }

        private void tb_Capacite_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_AdresseSRS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
