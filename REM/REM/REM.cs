using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Form;
using System.IO;

namespace REMEDIAL
{
    class Archivos
    {
        StreamWriter escritura = File.CreateText("Archivo1.txt");
        StreamWriter escritura = File.CreateText("Archivo2.txt");
        public void ESCRIBIRARCHIVO1(string doc)
        {
            escritura.WriteLine(doc);
            escritura.Close();
        }
        public void ESCRIBIRARCHIVO2(string doc)
        {
            escritura.WriteLine(doc);
            escritura.Close();
        }
        public void MOSTRAR(ListView lv)
        {
            StreamReader lectura = File.ReadAllLines("Archivo1.txt, Archivo2.txt");
            lisview.items.Add(lectura);
        }
    }
}
