using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Arch
{
    public class Archivos
    {
        StreamWriter escritura = File.CreateText("Archivo1.txt");
        StreamWriter escritura2 = File.CreateText("Archivo2.txt");
        String linea, linea2;
        public void ESCRIBIRARCHIVO1(string doc)
        {
            escritura.WriteLine(doc);
            escritura.Close();
        }
        public void ESCRIBIRARCHIVO2(string doc)
        {
            escritura2.WriteLine(doc);
            escritura2.Close();
        }
        public void MOSTRAR_1(ListView lv)
        {
            StreamReader lectura = File.OpenText("Archivo1.txt");
            linea = lectura.ReadToEnd();
            StreamReader lectura2 = File.OpenText("Archivo2.txt");
            linea2 = lectura2.ReadToEnd();
            lv.Items.Add(linea);
            lv.Items.Add(linea2);
        }
        public void GUARDAD(ListView cmb, string c)
        {
            StreamWriter escritura3 = File.CreateText(c +".txt");
            escritura3.WriteLine(cmb.Text);
            escritura3.Close();
        }
    }
}
