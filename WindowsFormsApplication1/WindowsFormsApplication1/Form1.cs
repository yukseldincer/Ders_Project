using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = (sender as TreeView).SelectedNode;
            if (selectedNode!= null && selectedNode.Tag!=null)
            {
                MessageBox.Show(selectedNode.Tag.ToString());
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode node1 =new TreeNode();
            node1.Text = "Deneme2";
            node1.Tag = "dn2";
            treeView1.Nodes.Add(node1);
        }
    }
}
