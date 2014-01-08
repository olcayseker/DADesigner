using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DADesignerFormsGUI
{
    public partial class ShowXML : Form
    {
        public ShowXML()
        {
            InitializeComponent();
        }

        private void ShowXML_Load(object sender, EventArgs e)
        {

        }

        public string XMLText
        {
            set
            {
                rtbXML.Text = value;
            }
        }
    }
}
