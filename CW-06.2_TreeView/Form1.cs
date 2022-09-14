using System;
using System.Windows.Forms;
using System.IO;

namespace CW_06._2_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TreeNode nodeDrive;
            treeView1.ImageList = imageList1;
            treeView1.ImageIndex = 0;
            string[] drives = Environment.GetLogicalDrives();
            foreach (string str in drives)
            {
                nodeDrive = new TreeNode(str);
                treeView1.Nodes.Add(nodeDrive);
                nodeDrive.Expand();
                AddDirectories(nodeDrive);
            }
        }
        void AddDirectories(TreeNode node)
        {
            string strPath = node.FullPath;
            DirectoryInfo dirInfo = new DirectoryInfo(strPath);
            DirectoryInfo[] arrayDirInfo;
            try
            { arrayDirInfo = dirInfo.GetDirectories(); }
            catch
            { return; }
            foreach (DirectoryInfo dir in arrayDirInfo)
            {
                try
                {
                    string[] check_files = Directory.GetFiles(dir.FullName);
                    if (check_files.Length > 0)
                    {
                        TreeNode nodeDir = new TreeNode(dir.Name);
                        string[] file_names = Directory.GetFiles(dir.FullName);
                        foreach (string name in check_files)
                        {
                            TreeNode nd = new TreeNode(name);
                            if (file_names.Length > 0)
                                nodeDir.Nodes.Add(nd);
                        }
                        node.Nodes.Add(nodeDir);
                        AddDirectories(nodeDir);
                    }
                }
                catch 
                { continue; }
            }
        }
    }
}
