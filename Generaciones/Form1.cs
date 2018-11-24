using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generaciones
{
    public partial class Form1 : Form
    {
        int total = 0, x=1;
        int countgeneracion = 0;
        int count = 0;
        int aux = 0;
        int gene = 2, genes=3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            count = 0;

            int totalGeneracion = Convert.ToInt32(txtGeneracion.Text);
            treeView1.Nodes.Add("Angel Muñoz");
            btnAgregarRaiz.Visible = false;
            txtRaiz.ReadOnly = true;

            count++;
            if (totalGeneracion > 0 && totalGeneracion < 11)
            {
                FR(treeView1.Nodes[0], aux, totalGeneracion);
            }
            else
            {
                MessageBox.Show("no cumple con los requisitos");
            }

            label3.Text = count.ToString();
        }
       
        public  void FR(TreeNode node,int aux,int totalGeneracion)
        {
            count++;
            aux++;
           
            node.Nodes.Add("daddy " + gene.ToString());
            comboBox1.Items.Add("daddy " + gene.ToString());

            gene++;
            if (aux < totalGeneracion)
            {
                FR(node.Nodes[0],aux,totalGeneracion);
                
            }
            
            node.Nodes.Add("Mommy " + gene.ToString());
            comboBox1.Items.Add("daddy " + gene.ToString());
            gene++;
            if (aux < totalGeneracion)
            {
                FR(node.Nodes[1], aux, totalGeneracion);
            }
            
            return;
        }

        private void btnAgregarRaiz_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(txtRaiz.Text);
            btnAgregarRaiz.Visible = false;
            txtRaiz.ReadOnly = true;
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void btnAgregarnodo_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string yourChildNode;
                yourChildNode = textBox1.Text.Trim();
                treeView1.SelectedNode.Nodes.Add(yourChildNode);
                treeView1.ExpandAll();
            }            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            {
                MessageBox.Show("" + treeView1.SelectedNode.Text);

                comboBox1.Text = treeView1.SelectedNode.Text;
            }
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int totalGeneracionTotal = Convert.ToInt32(txtGeneracion.Text);
           
            for (int i = 0; i < totalGeneracionTotal; i++)
            {
                total = x * 2;
                x = x * 2;
                countgeneracion = countgeneracion + total;
            }            
            txtTotal.Text = countgeneracion.ToString();
        }
    }
}
