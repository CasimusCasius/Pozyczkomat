using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pozyczkomat
{
    public partial class Form1 : Form
    {
        Guy Joe;
        Guy Bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            Joe = new Guy() { Cash = 50, Name = "Joe" };
            Bob = new Guy() { Name = "Bob", Cash = 100 };
            UpdateForm();
        }

        private void BtnGiveCash_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= Joe.RecieveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
            }
        }

        private void BtnRecieveCash_Click(object sender, EventArgs e)
        {
            bank += Bob.GiveCash(5);
            UpdateForm();
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = Joe.Name + " ma " + Joe.Cash + " zł";
            bobsCashLabel.Text = Bob.Name + " ma " + Bob.Cash + " zl";
            bankCashLabel.Text = "Bank ma " + bank + " zł";
        }

        private void JoeGivesToBob_Click(object sender, EventArgs e)
        {

        }

        private void BobGivesToJoe_Click(object sender, EventArgs e)
        {

        }
    }
}
