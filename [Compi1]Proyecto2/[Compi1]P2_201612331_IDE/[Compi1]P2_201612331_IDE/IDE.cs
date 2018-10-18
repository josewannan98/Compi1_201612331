using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Irony;

namespace _Compi1_P2_201612331_IDE
{
    public partial class IDE : Form
    {
        Form1 form;
        DateTime tiempo;
        public IDE(Form1 form)
        {
            this.form = form;
            InitializeComponent();
            Gramatica gramatica = new Gramatica();
            ironyFCTB1.Grammar = new Gramatica();
            tiempo = DateTime.Now;
            label6.Text = tiempo.ToString();
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
    }
}
