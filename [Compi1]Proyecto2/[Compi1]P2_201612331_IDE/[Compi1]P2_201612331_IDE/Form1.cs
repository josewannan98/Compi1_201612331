using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _Compi1_P2_201612331_IDE
{
    public partial class Form1 : Form
    {
        public int progress;
      
        public Form1()
        {
            InitializeComponent();
            progress = 0;
           
            
        }
        private void Process()
        {
            if(progress == 0)
            {
                setTExt("Bienvenido...");
            }
            if(progress == 10)
            {
                setTExt("Restableciendo Configuraciones...");
            }
            if (progress == 20)
            {
                setTExt("Conectando con el Servidor...");
            }
            if (progress == 30)
            {
                setTExt("Acariciando a BLACKY...");
            }
            if (progress == 40)
            {
                setTExt("Revisando los capitulos de Anime...");
            }
            if (progress == 50)
            {
                setTExt("Leyendo el Manga de Fairy tail...");
            }
            if (progress == 60)
            {
                setTExt("Verificando Configuraciones...");
            }
            if (progress == 70)
            {
                setTExt("Estableciendo Registros...");
            }
            if (progress == 80)
            {
                setTExt("Obteniendo Inspiracion...");
            }
            if (progress == 90)
            {
                setTExt("Tomando Cafe, para iniciar...");
            }
            if (progress == 100)
            {
                setTExt("Iniciando...");
            }


        }
    

        private void Form1_Activated(object sender, EventArgs e)
        {
           
           
        }
        private void setTExt(String jk)
        {
            label1.Text = jk;        

        }
        private void aumentar()
        {
            if(progress==100)
            {
                
            }
            else
            {
                progressBar1.Value += 1;
                progress += 1;
            }
            
        }
        
        private  void timer1_Tick(object sender, EventArgs e)
        {
            if (progress != 100)
            {
                Process();
                aumentar();
            }
            else
            {
                IDE ide = new IDE(this);
                ide.Show();
                this.Hide();
                Console.WriteLine("adios");
                timer1.Stop();
               
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();           
            timer1.Tick += new EventHandler(timer1_Tick);  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
