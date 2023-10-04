using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (odaberiCb.SelectedItem == "IT menadzment")
            {
                odabranoTb.Text = "Odabrali ste: IT menadzment";
            }
            if (odaberiCb.SelectedItem == "aplikativno programiranje")
            {
                odabranoTb.Text = "Odabrali ste: aplikativno programiranje";
            }
            if (odaberiCb.SelectedItem == "internet programiranje")
            {
                odabranoTb.Text = "Odabrali ste: internet programiranje";
            }
            if (odaberiCb.SelectedItem == "informacioni sistemi")
            {
                odabranoTb.Text = "Odabrali ste: informacioni sistemi";
            }

        }
    }
}
