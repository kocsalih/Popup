using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popup
{
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name== "Form1")
                {
                    foreach (Control Formitem in item.Controls)
                    {
                        if (Formitem is TextBox)
                        {
                            ((TextBox)Formitem).Text = string.Empty;

                        }

                    }

                }
            }
            this.Close();
        }
    }
}
