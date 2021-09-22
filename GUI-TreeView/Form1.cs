﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuThemNut_Click(object sender, EventArgs e)
        {
            frmThemNut frm = new frmThemNut();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (tvDuLieu.SelectedNode == null) // muốn tạo nút gốc
                {
                    TreeNode root = new TreeNode(frm.txtGiaTri.Text);
                    tvDuLieu.Nodes.Add(root);
                }
                else // tạo nút con của selectednode
                {
                    TreeNode node = new TreeNode(frm.txtGiaTri.Text);
                    tvDuLieu.SelectedNode.Nodes.Add(node);
                    if (node.Level == 2)
                    {
                        node.ImageIndex = 2;
                        node.SelectedImageIndex = 2;
                    }
                }
            }
        }

        private void tvDuLieu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvDuLieu.SelectedNode = e.Node;
        }

        private void mnuSuaNut_Click(object sender, EventArgs e)
        {
            if (tvDuLieu.SelectedNode != null)
            {
                frmThemNut frm = new frmThemNut();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    tvDuLieu.SelectedNode.Text = frm.txtGiaTri.Text;
                }
            }
            else
            {
                return;
            }
            
        }

        private void mnuXoaNut_Click(object sender, EventArgs e)
        {
            if (tvDuLieu.SelectedNode !=null)
            {
                tvDuLieu.Nodes.Remove(tvDuLieu.SelectedNode);
            }
        }

        private void mnuMoRong_Click(object sender, EventArgs e)
        {
            if (tvDuLieu.SelectedNode !=null)
            {
                tvDuLieu.SelectedNode.ExpandAll();
            }
        }

        private void mnuThuGom_Click(object sender, EventArgs e)
        {
            if (tvDuLieu.SelectedNode !=null)
            {
                tvDuLieu.SelectedNode.Collapse();
            }
        }

        private void tvDuLieu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node !=null)
            {
                lblValue.Text = e.Node.Text;
            }
        }
    }
}
