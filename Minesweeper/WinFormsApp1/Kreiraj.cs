using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Kreiraj : Form
    {
        public Tabla PomniTabla { get; set; }

        public Kreiraj()
        {
            InitializeComponent();
        }

        private void btnSocujav_Click(object sender, EventArgs e)
        {
            int mini = Convert.ToInt32(numMini.Value);
            int kocki = Convert.ToInt32(numKocki.Value);

            PomniTabla = new Tabla(mini, kocki);

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void numMini_Validating(object sender, CancelEventArgs e)
        {
            int mini = Convert.ToInt32(numMini.Value);
            int kocki = Convert.ToInt32(numKocki.Value);
            kocki *= kocki;

            if (mini > kocki / 4)
            {
                e.Cancel = true;
                errorProviderMini.SetError(numMini, "Невалиден број на мини! Боројот на мини мора да биде помал од една четвртина од табалата!");
                numMini.Value = kocki / 4;
            }
            else
            {
                e.Cancel = false;
                errorProviderMini.SetError(numMini,"");
            }
        }
    }
}
