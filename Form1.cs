using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIghter__MP_HP_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                  }    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void deltamp_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lv = Convert.ToInt32(lvnow.Text);
            int hp = Convert.ToInt32(hpnow.Text);
            int i = Convert.ToInt32(intnow.Text);
            int hpy = Convert.ToInt32(hpmax.Text);
            int mp = Convert.ToInt32(mpnow.Text);
            int lvm = 200;
            int mpm = lv * 4 + 56;
            double c = 0.05;

            int dlv = lvm - lv;
            deltalv.Text = dlv.ToString();

            int dhp = hpy - hp;
            deltahp.Text = dhp.ToString();

            int hpg = dlv * 66;
            hpgain.Text = hpg.ToString();

            int hpn = dhp - hpg;
            hpneeded.Text = hpn.ToString();

            float mpn = hpn / 52*4 - (mp - mpm);
            mpneeded.Text = mpn.ToString("#0.0");

            float skillpointsn = hpn/ 52;
            skillpoints.Text = skillpointsn.ToString("#0.0");

            float dmp = i / 10;
            deltamp.Text = dmp.ToString();

            float ddlv = mpn / dmp;
            float flv = lv + ddlv;
            finallv.Text = flv.ToString("#0");

            double cost1 = (i - 4) * c;
            double cost2 = skillpointsn * c;
            double cost = cost1 + cost2;
            costs.Text = cost.ToString("#0.00");


        }
    }
}
