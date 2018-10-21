using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Irony;
using Irony.Parsing;

namespace _Compi1_P2_201612331_IDE
{
    public partial class IDE : Form
    {
        Form1 form;
        DateTime tiempo;
        Proyecto pro;
        List<archivo> archi = new List<archivo>();
        List<String> historial = new List<String>();
        public String Path = "";
        public IDE(Form1 form)
        {
            this.form = form;
            InitializeComponent();
            Gramatica gramatica = new Gramatica();
            ironyFCTB1.Grammar = new Gramatica();
            tiempo = DateTime.Now;
            label6.Text = tiempo.ToString();
            pro = new Proyecto();
            timer3.Enabled = true;
            timer3.Start();
            timer3.Tick += new EventHandler(timer3_Tick);
        }

        private void IDE_Load(object sender, EventArgs e)
        {
            lenguajeCbcToolStripMenuItem.PerformClick();
            notifyIcon3.ShowBalloonTip(5000);
        }

        private void IDE_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form.Close();
        }

        private void lenguajeCbcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gramatica gramatica = new Gramatica();
            ironyFCTB1.Grammar = new Gramatica();

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void ironyFCTB1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {

        }

        private void ironyFCTB1_TextChanging(object sender, FastColoredTextBoxNS.TextChangingEventArgs e)
        {
            lenguajeCbcToolStripMenuItem.PerformClick();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IDE_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo = DateTime.Now;
            label6.Text = tiempo.ToString();
        }

        private void ejecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Salida;
            historial.Add("Compilacion efectuada");
            Gramatica grammar = new Gramatica();
            LanguageData lenguaje = new LanguageData(grammar);
            Parser p = new Parser(lenguaje);
            ParseTree arbol = p.Parse(ironyFCTB1.Text);
            if (arbol != null)
            {
                if (arbol.ParserMessages.Count > 0)
                {
                    Salida = "Compilacion Cancelada, Errores no permiten su Compilacion Correcta \n";
                    for (int a = 0; a < arbol.ParserMessages.Count; a++)
                    {
                        Salida += "-[BLACKY RESPONSE]-> " + arbol.ParserMessages[a].Message + ", Linea: " + arbol.ParserMessages[a].Location.Line + " Columna: " + arbol.ParserMessages[a].Location.Column + "\n";
                    }
                    Salida += " Tiempo de Ejecucion: " + arbol.ParseTimeMilliseconds.ToString() + " millisegundos";
                    historial.Add(" Tiempo de Ejecucion: " + arbol.ParseTimeMilliseconds.ToString() + " millisegundos");

                }
                else
                {
                    Genarbol(arbol.Root);
                    GenerateGraph("Ejecucion.dot", @"C:\Users\jose_\Documents\release\bin\");
                    abrirJpg();
                    Salida = "Build Succes, Tiempo de Ejecucion: " + arbol.ParseTimeMilliseconds.ToString() + " millisegundos";
                    historial.Add(" Tiempo de Ejecucion: " + arbol.ParseTimeMilliseconds.ToString() + " millisegundos");

                }


            }
            else
            {
                Salida = "Error en la Compilacion";
                historial.Add(Salida);
            }
         
        }
        String graph;
        public void Genarbol(ParseTreeNode raiz)
        {
            System.IO.StreamWriter f = new System.IO.StreamWriter(@"C:\Users\jose_\Documents\release\bin\Ejecucion.dot");
            f.Write("digraph G{ \nrankdir=TB; \n node [shape = box, style=rounded]; \n");
            graph = "";
            Generar(raiz);
            f.Write(graph);
            f.Write("}");
            f.Close();

        }
        public void Generar(ParseTreeNode raiz)
        {
            graph = graph + "nodo" + raiz.GetHashCode() + "[label=\"" + raiz.ToString().Replace("\"", "\\\"") + " \", style =\"filled\", shape=\"circle\"]; \n";
            if (raiz.ChildNodes.Count > 0)
            {
                ParseTreeNode[] hijos = raiz.ChildNodes.ToArray();
                for (int i = 0; i < raiz.ChildNodes.Count; i++)
                {
                    Generar(hijos[i]);
                    graph = graph + "nodo" + raiz.GetHashCode() + "-> nodo" + hijos[i].GetHashCode() + "; \n";
                }
            }
        }
        private static void GenerateGraph(string fileName, string path)
        {
            try
            {
                var command = string.Format(@"C:\Users\jose_\Documents\release\bin\dot.exe -Tjpg {0} -o {1}", System.IO.Path.Combine(path, fileName), System.IO.Path.Combine(path, fileName.Replace(".dot", ".jpg")));
                var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command);
                var proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                proc.WaitForExit();



            }
            catch (Exception x)
            {

            }
        }
        private void abrirJpg()
        {
            try
            {
                var command = string.Format(@"C:\Users\jose_\Documents\release\bin\Ejecucion.jpg");
                var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command);
                var proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception x)
            {

            }
        }

        private void nuevoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearProyectoCBC nuevo = new CrearProyectoCBC(pro);
            nuevo.Show();

            timer2.Enabled = true;
            timer2.Start();
            timer2.Tick += new EventHandler(timer2_Tick);



        }
        private void timer2_Tick(object sender, EventArgs e)
        {
           if(pro.getPath()!="")
            {
                obtenerDirectorio();
                timer2.Stop();
            }
           
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            listView1.Clear();
            foreach(String ad in historial)
            {
                listView1.Items.Add(ad);

            }

        }
        private void obtenerDirectorio()
        {
            PopulateTreeView();
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(pro.getPath());
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                rootNode.ImageKey = "folder";
                historial.Add("Proyecto Creado con exito, " + info.Name);
                GetDirectories(info.GetDirectories(), rootNode);
                getFiles(info, rootNode);
                treeView1.Nodes.Add(rootNode);
                agregarcomboBox();
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                                                     
                }
                if(subDir.GetFiles().Length != 0)
                {
                    getFiles(subDir, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
                    
        }
        private void getFiles(DirectoryInfo dir, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            foreach (FileInfo file in dir.GetFiles())
            {
                aNode = new TreeNode(file.Name, 0, 0);
                aNode.Tag = file;
                aNode.ImageKey = "archivo";
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        private void agregarcomboBox()
        {
            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(pro.getPath());
             FileInfo[] archivos =  directory.GetFiles();

            foreach(FileInfo archivo in archivos)
            {
                StreamReader lector = new StreamReader(new FileStream(archivo.FullName,System.IO.FileMode.Open));
                String contenido = "";
                String recorrer = lector.ReadLine();
                while(recorrer!=null)
                {
                    contenido += recorrer;
                    recorrer = lector.ReadLine();
                    

                }
                archivo ars = new archivo();
                ars.ruta = archivo.FullName;
                ars.name = archivo.Name;
                ars.contenido = contenido;
                comboBox1.Items.Add(archivo.Name);
                archi.Add(ars);


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String arivo = comboBox1.SelectedItem.ToString();
            foreach(archivo ar in archi)
            {
                if(ar.name.Equals(arivo))
                {
                    ironyFCTB1.Text = ar.contenido;
                    label4.Text = ar.name;
                    Gramatica gramatica = new Gramatica();
                    ironyFCTB1.Grammar = new Gramatica();
                    historial.Add("Se abrio el Archivo, " + ar.name);
                }
            }

        }
    }
}
class archivo
{
    public String ruta { get; set; }
    public String name { get; set; }
    public String contenido { get; set; }
}
