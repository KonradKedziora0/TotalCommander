using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            porgramStart();
            

        }
        private void porgramStart()
        {
            //left site
            l_textBoxPath.Text = "C:/";
            l_wBrowser.Url = new Uri(l_textBoxPath.Text);

            //right site
            r_textBoxPath.Text = "C:/";
            r_wBrowser.Url = new Uri(r_textBoxPath.Text);
        }

        //Left site
        //Open button
        private void l_Open()
        {
            l_removeHttps();
            if (Directory.Exists(l_textBoxPath.Text))
            {
                try
                {
                    l_wBrowser.Url = new Uri(l_textBoxPath.Text);
                    l_textBoxPath.Text = l_wBrowser.Url.ToString();
                }
                catch
                {
                    MessageBox.Show("Folder does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    l_textBoxPath.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Folder does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                l_textBoxPath.Text = @"C:/";
            }

        }
        private void l_btnOpen_Click(object sender, EventArgs e)
        {
            l_Open();
        }
        private void l_textBoxPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                l_Open();
            }
        }
        //Remove https from path texbox
        private void l_removeHttps()
        {
            if (l_textBoxPath.Text.Contains("https://") || l_textBoxPath.Text.Contains("http://"))
            {
                l_textBoxPath.Text = "";
            }
        }
        //Back button
        private void l_btnBack_Click(object sender, EventArgs e)
        {
            string l_path = l_textBoxPath.Text;
            int slash = l_path.LastIndexOf("/");
            if (slash >= 2)
            {
                l_path = l_path.Substring(0, slash + 1);
                l_textBoxPath.Text = (l_path);

                l_Open();
            }

        }
        //Change url in texbox when go to another folder
        private void l_wBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            l_textBoxPath.Text = l_wBrowser.Url.ToString();

            string l_pathWithout = l_textBoxPath.Text;
            l_pathWithout = l_pathWithout.Remove(0, 8);
            l_textBoxPath.Text = l_pathWithout;

        }
        //Create folder and delete folders or file
        private void l_textBoxNewFolder_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F7)
            {
                string path = l_wBrowser.Url.ToString();
                path = path.Remove(0, 8);
                l_textBoxPath.Text = path;

                if (Directory.Exists(path + "/" + l_textBoxNewFolder.Text)){
                    MessageBox.Show("The folder already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    l_textBoxNewFolder.Text = "";
                }
                else {
                    try
                    {
                        if (l_textBoxNewFolder != null)
                            Directory.CreateDirectory(path + "/" + l_textBoxNewFolder.Text);
                        l_textBoxNewFolder.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        l_textBoxNewFolder.Text = "";
                    }
                }
            }
        }
        private void l_textBoxDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                string path = l_wBrowser.Url.ToString();
                path = path.Remove(0, 8);
                l_textBoxPath.Text = path;

                if (File.Exists(path + "/" + l_textBoxDelete.Text))
                {
                    File.Delete(l_textBoxPath.Text + "/" + l_textBoxDelete.Text);
                }

                else if (Directory.Exists(path +"/"+ l_textBoxDelete.Text))
                {
                    try
                    {
                        Directory.Delete(l_textBoxPath.Text +"/"+l_textBoxDelete.Text, true);
                    }
                    catch { }
                }
                else
                {
                    MessageBox.Show("Folder or file does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                l_textBoxDelete.Text = "";
            }

        }
        private void l_moveFromLeft(object sender, EventArgs e)
        {
          
            File.Move(l_textBoxPath.Text, r_textBoxPath.Text);
        }

        //Right site
        //Open button
        private void r_Open()
        {
            r_removeHttps();
            if (Directory.Exists(r_textBoxPath.Text))
            {
                try
                {
                    r_wBrowser.Url = new Uri(r_textBoxPath.Text);
                    r_textBoxPath.Text =r_wBrowser.Url.ToString();
                }
                catch
                {
                    MessageBox.Show("Folder does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    r_textBoxPath.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Folder does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                r_textBoxPath.Text = @"C:/";
            }
        }
        private void r_btnOpen_Click(object sender, EventArgs e)
        {
            r_Open();
        }
        private void r_textBoxPath_KeyDown(object sender, KeyEventArgs e)
        {
            r_Open();
        }
        //Remove https from path texbox
        private void r_removeHttps()
        {
            if (r_textBoxPath.Text.Contains("https://") || r_textBoxPath.Text.Contains("http://"))
            {
                r_textBoxPath.Text = "";
            }
        }
        //Back button
        private void r_btnBack_Click(object sender, EventArgs e)
        {
            string r_path = r_textBoxPath.Text;
            int slash = r_path.LastIndexOf("/");
            if (slash >= 2)
            {
                r_path = r_path.Substring(0, slash + 1);
                r_textBoxPath.Text = (r_path);

                r_Open();
            }

        }
        //Change url in texbox when go to another folder
        private void r_wBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            r_textBoxPath.Text = r_wBrowser.Url.ToString();

            string r_pathWithout = r_textBoxPath.Text;
            r_pathWithout = r_pathWithout.Remove(0, 8);
            r_textBoxPath.Text = r_pathWithout;
        }
        //Create folder and delete folders or file
        private void r_textBoxNewFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                string path = r_wBrowser.Url.ToString();
                path = path.Remove(0, 8);
                r_textBoxPath.Text = path;
                if(Directory.Exists(path + "/" + r_textBoxNewFolder.Text))
                {
                    MessageBox.Show("The folder already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    r_textBoxNewFolder.Text = "";
                }
                try
                {
                    if (r_textBoxNewFolder != null)
                        Directory.CreateDirectory(path + "/" + r_textBoxNewFolder.Text);
                    r_textBoxNewFolder.Text = "";
                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    r_textBoxNewFolder.Text = "";
                }
            }
        }
        private void r_textBoxDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                string path = r_wBrowser.Url.ToString();
                path = path.Remove(0, 8);
                r_textBoxPath.Text = path;

                if (File.Exists(path + "/" + r_textBoxDelete.Text))
                {
                    File.Delete(r_textBoxPath.Text + "/" + r_textBoxDelete.Text);
                }

                else if (Directory.Exists(path +"/"+r_textBoxDelete.Text))
                {
                    try
                    {
                        Directory.Delete(l_textBoxPath.Text +"/"+ r_textBoxDelete.Text,true);
                    }
                    catch { }
                }
                else
                {
                    MessageBox.Show("Folder or file does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                r_textBoxDelete.Text = "";
            }
        }

       
    }
}
