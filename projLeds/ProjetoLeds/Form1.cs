using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLeds
{
    public partial class Form1 : Form
    {
        private Leds leds;

        public Form1()
        {
            InitializeComponent();
            leds = new Leds();
            atualizaInterface();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLed1_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(1))
            {
                leds.apagar(1);
            }
            else
            {
                leds.acender(1);
            }
            atualizaInterface();
        }
        private void btnLed2_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(2))
            {
                leds.apagar(2);
            }
            else
            {
                leds.acender(2);
            }
            atualizaInterface();
        }

        private void btnLed3_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(3))
            {
                leds.apagar(3);
            }
            else
            {
                leds.acender(3);
            }
            atualizaInterface();
        }

        private void btnLed4_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(4))
            {
                leds.apagar(4);
            }
            else
            {
                leds.acender(4);
            }
            atualizaInterface();
        }

        private void btnLed5_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(5))
            {
                leds.apagar(5);
            }
            else
            {
                leds.acender(5);
            }
            atualizaInterface();
        }

        private void btnLed6_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(6))
            {
                leds.apagar(6);
            }
            else
            {
                leds.acender(6);
            }
            atualizaInterface();
        }

        private void btnLed7_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(7))
            {
                leds.apagar(7);
            }
            else
            {
                leds.acender(7);
            }
            atualizaInterface();
        }

        private void btnLed8_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(8))
            {
                leds.apagar(8);
            }
            else
            {
                leds.acender(8);
            }
            atualizaInterface();
        }
       
        private void atualizaInterface()
        {
           
            btnLed1.Text = (leds.getEstado(1) ? "Off" : "On");
            chkLed1.Checked = (leds.getEstado(1) ? true :false);

            btnLed2.Text = (leds.getEstado(2) ? "Off" : "On");
            chkLed2.Checked = (leds.getEstado(2) ? true : false);

            btnLed3.Text = (leds.getEstado(3) ? "Off" : "On");
            chkLed3.Checked = (leds.getEstado(3) ? true : false);

            btnLed4.Text = (leds.getEstado(4) ? "Off" : "On");
            chkLed4.Checked = (leds.getEstado(4) ? true : false);

            btnLed5.Text = (leds.getEstado(5) ? "Off" : "On");
            chkLed5.Checked = (leds.getEstado(5) ? true : false);

            btnLed6.Text = (leds.getEstado(6) ? "Off" : "On");
            chkLed6.Checked = (leds.getEstado(6) ? true : false);

            btnLed7.Text = (leds.getEstado(7) ? "Off" : "On");
            chkLed7.Checked = (leds.getEstado(7) ? true : false);

            btnLed8.Text = (leds.getEstado(8) ? "Off" : "On");
            chkLed8.Checked = (leds.getEstado(8) ? true : false);

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            int x;

            x = int.Parse(txtLed.Text);

            leds.getEstado(x);

            chkEstado.Checked = (leds.getEstado(x) ? true : false);
        }
    }
}
