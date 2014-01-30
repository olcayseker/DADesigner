using DADesignerCore.DesignerAPIManager;
using DADesignerCore.Entities;
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
    public partial class Form1 : Form
    {
        ClassTypeBuilder builder;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            builder = new ClassTypeBuilder(new CreateRootClass(), new CreateChildClass(), ManagementPackInitializer.ManagementPack);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //http://www.codeproject.com/Tips/680095/Test-if-a-TreeNode-was-actually-clicked
            if (e.Node.Bounds.Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                // Code to load project details and generate a tab
            }
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && treeView1.SelectedNode != null)//113
            {
                treeView1.LabelEdit = true;
                treeView1.SelectedNode.BeginEdit();
            }
        }

        //display nam değişecek
        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Label.Length > 0)
                {
                    if (e.Label.IndexOfAny(new char[] { '@', '.', ',', '!', ';' }) == -1)
                    {
                        // Stop editing without canceling the label change.
                        e.Node.EndEdit(false);

                        //api
                        
                        var classType= (ClassType)e.Node.Tag;
                        classType.DisplayName = e.Label;
                        ManagementPackInitializer.ManagementPack.RefreshLanguagePacksElement();
                    }
                    else
                    {
                        /* Cancel the label edit action, inform the user, and 
                           place the node in edit mode again. */
                        e.CancelEdit = true;
                        MessageBox.Show("Invalid tree node label.\n" +
                           "The invalid characters are: '@','.', ',', '!'",
                           "Node Label Edit");
                        e.Node.BeginEdit();
                    }
                }
                else
                {
                    /* Cancel the label edit action, inform the user, and 
                       place the node in edit mode again. */
                    e.CancelEdit = true;
                    MessageBox.Show("Invalid tree node label.\nThe label cannot be blank",
                       "Node Label Edit");
                    e.Node.BeginEdit();
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                //treeView1.SelectedNode.Tag = new ClassType();

                propertyGrid1.SelectedObject = treeView1.SelectedNode.Tag;
            }
        }

        private void addNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0)
            {
                TreeNode root = new TreeNode("root");
                treeView1.Nodes.Add(root);

                ClassType rootClass = new ClassType();
                rootClass.DisplayName = root.Text;
                rootClass.ID = root.Text;
                root.Tag = rootClass;
                builder.BuildRootClass(rootClass);

                return;
            }

            if (treeView1.SelectedNode == null)
                treeView1.SelectedNode = treeView1.Nodes[0];

            var childNode = treeView1.SelectedNode.Nodes.Add(string.Format("child{0}", treeView1.GetNodeCount(true)));
            ClassType childClass = new ClassType();
            
            childClass.ID= childClass.DisplayName = childNode.Text;
            childClass.Parent = treeView1.SelectedNode.Tag as ClassType;
            childClass.Parent.Child = childClass;
            childNode.Tag = childClass;
            childClass.SimpleName = childNode.Text;
            builder.BuildChildClass(childClass);

            treeView1.ExpandAll();
        }
             
        private void tsbShowXML_Click(object sender, EventArgs e)
        {
            ShowXML showxml = new ShowXML();
            showxml.XMLText = ManagementPackInitializer.ManagementPack.Element.ToString();
            showxml.ShowDialog();
            showxml.Dispose();
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

        }
    }
}
