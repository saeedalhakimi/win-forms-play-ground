using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplayGround
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void checkTreeViewNodes(TreeNode node, Boolean isChecked)
        {
            foreach (TreeNode childNode in node.Nodes)
            {
                childNode.Checked = isChecked;
                if (childNode.Nodes.Count > 0 )
                {
                    this.checkTreeViewNodes(childNode, isChecked);
                }
            }
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            checkTreeViewNodes(e.Node, e.Node.Checked);
        }
    }
}

//private void PopulateTreeView()
//{
//    // Begin the update process of the TreeView control.
//    treeView1.BeginUpdate();
//    // Clear the TreeView control.
//    treeView1.Nodes.Clear();
//    // Create a new TreeNode object.
//    TreeNode rootNode;
//    // Create a new DirectoryInfo object.
//    DirectoryInfo info = new DirectoryInfo(@"C:\");
//    // Check if the directory exists.
//    if (info.Exists)
//    {
//        // Create a new TreeNode object with the name of the directory.
//        rootNode = new TreeNode(info.Name);
//        // Set the Tag property of the TreeNode object to the DirectoryInfo object.
//        rootNode.Tag = info;
//        // Call the GetDirectories method to get the subdirectories of the directory.
//        GetDirectories(info.GetDirectories(), rootNode);
//        // Add the TreeNode object to the TreeView control.
//        treeView1.Nodes.Add(rootNode);
//    }
//    // End the update process of the TreeView control.
//    treeView1.EndUpdate();
//}

//private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
//{
//    // Create a new TreeNode object.
//    TreeNode aNode;
//    // Create a new DirectoryInfo array.
//    DirectoryInfo[] subSubDirs;
//    // Loop through each subdirectory in the subdirectory array.
//    foreach (DirectoryInfo subDir in subDirs)
//    {
//        // Create a new TreeNode object with the name of the subdirectory.
//        aNode = new TreeNode(subDir.Name, 0, 0);
//        // Set the Tag property of the TreeNode object to the DirectoryInfo object.
//        aNode.Tag = subDir;
//        // Set the ImageKey property of the TreeNode object to "folder".
//        aNode.ImageKey = "folder";
//        try
//        {
//            // Call the GetDirectories method to get the subdirectories of the subdirectory.
//            subSubDirs = subDir.GetDirectories();
//            // Check if the subdirectory has any subdirectories.
//            if (subSubDirs.Length != 0)
//            {
//                // Call the GetDirectories method recursively.
//                GetDirectories(subSubDirs, aNode);
//            }
//        }
//        catch (UnauthorizedAccessException)
//        {
//            // Do nothing.
//        }
//        catch (DirectoryNotFoundException)
//        {
//            // Do nothing.
//        }
//        // Add the TreeNode object to the parent TreeNode object.
//        nodeToAddTo.Nodes.Add(aNode);
//    }
//}