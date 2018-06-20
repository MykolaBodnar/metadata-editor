using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metadata_Editor_2
{
    public partial class ResaultDialog : Form
    {
        public ResaultDialog(string name, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            InitializeComponent();

        }

       public string getData { get { return data; } }
        string name;
        string data;
        int x, y;
       

        private void button1_Click(object sender, EventArgs e)
        {
            data = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResaultDialog_Load(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
            Top = y;
            Left = x;
            this.Text = name;
            label1.Text =  label1.Text+name;
        }
    }
}
