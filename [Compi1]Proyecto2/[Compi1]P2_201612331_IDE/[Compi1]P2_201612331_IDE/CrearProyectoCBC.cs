using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Compi1_P2_201612331_IDE
{
    public partial class CrearProyectoCBC : Form
    {
        String FolderName = @"C:\Users\jose_\Documents\LenguajeCBCProjects";
        Proyecto pro;
        public CrearProyectoCBC(Proyecto pros)
        {
            InitializeComponent();
           this. pro = pros;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = System.IO.Path.Combine(FolderName, textBox1.Text);

            if (System.IO.Directory.Exists(path))
            {
                MessageBox.Show("Nombre Invalido - EL proyecto " + textBox1.Text + ", ya fue creado anteriormente");
            }
            else
            {
                System.IO.Directory.CreateDirectory(path);
                this.pro.setPath(path);
                String Filename = textBox1.Text + ".cbc";
                String file = System.IO.Path.Combine(path, Filename);
                using (System.IO.FileStream fs = System.IO.File.Create(file))
                {
                    StreamWriter write = new StreamWriter(fs);
                    String iniciando = "/* \n * (@author) JW \n * (@Language) Lenguaje cbc \n * (@Fecha Creacion)" + DateTime.Today.ToString() + " \n */";
                    write.Write(iniciando);
                    write.Flush();
                    write.Close();
                    MessageBox.Show("Proyecto creado Exitosamente");
                }
                this.Close();

            }
        }
    }
}
