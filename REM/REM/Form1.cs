using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arch;

namespace REM
{
    public partial class Form1 : Form
    {
        Archivos obj = new Archivos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArch1_Click(object sender, EventArgs e)
        {
            obj.ESCRIBIRARCHIVO1(txtArch.Text);
        }

        private void btnArch2_Click(object sender, EventArgs e)
        {
            obj.ESCRIBIRARCHIVO2(txtArch.Text);
        }

        private void btnCombi_Click(object sender, EventArgs e)
        {
            obj.MOSTRAR_1(lvCombinar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            obj.GUARDAD(lvCombinar, txtGuardar.Text);
        }
    }
}
