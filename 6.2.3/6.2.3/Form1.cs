using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2._3
{
    public partial class frmKuba : Form
    {
        public frmKuba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int eerste = int.Parse(txtBegin.Text);
                int eind = int.Parse(txtEind.Text);

                if (eerste >= eind)

                {
                    MessageBox.Show("Eerste getal kan niet groter zijn dan de laatste getal.");
                    txtBegin.Text = "";
                    txtEind.Text = "";
                    lbxAdvies.Items.Clear();
                }
                else
                {
                    if (rdbFor.Checked)
                    {
                        lbxAdvies.Items.Clear();
                        lbxAdvies.Items.Add("for (int i = " + eerste + "; " + "i < " + eind + "; i++)");
                        lbxAdvies.Items.Add("{");
                        lbxAdvies.Items.Add("}");
                    }

                    if (rdbWhile.Checked)
                    {
                        lbxAdvies.Items.Clear();
                        lbxAdvies.Items.Add("int i = " + eerste);
                        lbxAdvies.Items.Add("while ( i < " + eind + " )");
                        lbxAdvies.Items.Add("{");
                        lbxAdvies.Items.Add("i++");
                        lbxAdvies.Items.Add("}");
                    }
                }

            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden!");
            }
        }
    }
}
