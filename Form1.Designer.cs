
namespace FileExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l_btnBack = new System.Windows.Forms.Button();
            this.l_textBoxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_btnOpen = new System.Windows.Forms.Button();
            this.l_wBrowser = new System.Windows.Forms.WebBrowser();
            this.r_wBrowser = new System.Windows.Forms.WebBrowser();
            this.r_btnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.r_textBoxPath = new System.Windows.Forms.TextBox();
            this.r_btnBack = new System.Windows.Forms.Button();
            this.l_textBoxNewFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_textBoxDelete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.r_textBoxDelete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.r_textBoxNewFolder = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_btnBack
            // 
            this.l_btnBack.Location = new System.Drawing.Point(13, 13);
            this.l_btnBack.Name = "l_btnBack";
            this.l_btnBack.Size = new System.Drawing.Size(34, 23);
            this.l_btnBack.TabIndex = 0;
            this.l_btnBack.Text = "<<<";
            this.l_btnBack.UseVisualStyleBackColor = true;
            this.l_btnBack.Click += new System.EventHandler(this.l_btnBack_Click);
            // 
            // l_textBoxPath
            // 
            this.l_textBoxPath.Location = new System.Drawing.Point(91, 15);
            this.l_textBoxPath.Name = "l_textBoxPath";
            this.l_textBoxPath.Size = new System.Drawing.Size(164, 20);
            this.l_textBoxPath.TabIndex = 1;
            this.l_textBoxPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.l_textBoxPath_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // l_btnOpen
            // 
            this.l_btnOpen.Location = new System.Drawing.Point(261, 15);
            this.l_btnOpen.Name = "l_btnOpen";
            this.l_btnOpen.Size = new System.Drawing.Size(44, 23);
            this.l_btnOpen.TabIndex = 3;
            this.l_btnOpen.Text = "Open";
            this.l_btnOpen.UseVisualStyleBackColor = true;
            this.l_btnOpen.Click += new System.EventHandler(this.l_btnOpen_Click);
            // 
            // l_wBrowser
            // 
            this.l_wBrowser.Location = new System.Drawing.Point(13, 43);
            this.l_wBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.l_wBrowser.Name = "l_wBrowser";
            this.l_wBrowser.Size = new System.Drawing.Size(292, 304);
            this.l_wBrowser.TabIndex = 4;
            this.l_wBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.l_wBrowser_Navigated);
            // 
            // r_wBrowser
            // 
            this.r_wBrowser.Location = new System.Drawing.Point(416, 43);
            this.r_wBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.r_wBrowser.Name = "r_wBrowser";
            this.r_wBrowser.Size = new System.Drawing.Size(292, 304);
            this.r_wBrowser.TabIndex = 9;
            this.r_wBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.r_wBrowser_Navigated);
            // 
            // r_btnOpen
            // 
            this.r_btnOpen.Location = new System.Drawing.Point(664, 15);
            this.r_btnOpen.Name = "r_btnOpen";
            this.r_btnOpen.Size = new System.Drawing.Size(44, 23);
            this.r_btnOpen.TabIndex = 8;
            this.r_btnOpen.Text = "Open";
            this.r_btnOpen.UseVisualStyleBackColor = true;
            this.r_btnOpen.Click += new System.EventHandler(this.r_btnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Path:";
            // 
            // r_textBoxPath
            // 
            this.r_textBoxPath.Location = new System.Drawing.Point(494, 15);
            this.r_textBoxPath.Name = "r_textBoxPath";
            this.r_textBoxPath.Size = new System.Drawing.Size(164, 20);
            this.r_textBoxPath.TabIndex = 6;
            this.r_textBoxPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.r_textBoxPath_KeyDown);
            // 
            // r_btnBack
            // 
            this.r_btnBack.Location = new System.Drawing.Point(416, 13);
            this.r_btnBack.Name = "r_btnBack";
            this.r_btnBack.Size = new System.Drawing.Size(34, 23);
            this.r_btnBack.TabIndex = 5;
            this.r_btnBack.Text = "<<<";
            this.r_btnBack.UseVisualStyleBackColor = true;
            this.r_btnBack.Click += new System.EventHandler(this.r_btnBack_Click);
            // 
            // l_textBoxNewFolder
            // 
            this.l_textBoxNewFolder.Location = new System.Drawing.Point(108, 353);
            this.l_textBoxNewFolder.Name = "l_textBoxNewFolder";
            this.l_textBoxNewFolder.Size = new System.Drawing.Size(169, 20);
            this.l_textBoxNewFolder.TabIndex = 10;
            this.l_textBoxNewFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.l_textBoxNewFolder_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "New folder name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name of delete file ";
            // 
            // l_textBoxDelete
            // 
            this.l_textBoxDelete.Location = new System.Drawing.Point(108, 379);
            this.l_textBoxDelete.Name = "l_textBoxDelete";
            this.l_textBoxDelete.Size = new System.Drawing.Size(169, 20);
            this.l_textBoxDelete.TabIndex = 12;
            this.l_textBoxDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.l_textBoxDelete_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "F7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "F8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "F8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "F7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Name of delete file";
            // 
            // r_textBoxDelete
            // 
            this.r_textBoxDelete.Location = new System.Drawing.Point(511, 382);
            this.r_textBoxDelete.Name = "r_textBoxDelete";
            this.r_textBoxDelete.Size = new System.Drawing.Size(169, 20);
            this.r_textBoxDelete.TabIndex = 18;
            this.r_textBoxDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.r_textBoxDelete_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "New folder name";
            // 
            // r_textBoxNewFolder
            // 
            this.r_textBoxNewFolder.Location = new System.Drawing.Point(511, 356);
            this.r_textBoxNewFolder.Name = "r_textBoxNewFolder";
            this.r_textBoxNewFolder.Size = new System.Drawing.Size(169, 20);
            this.r_textBoxNewFolder.TabIndex = 16;
            this.r_textBoxNewFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.r_textBoxNewFolder_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "(with extension)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(415, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "(with extension)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.r_textBoxDelete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.r_textBoxNewFolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l_textBoxDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_textBoxNewFolder);
            this.Controls.Add(this.r_wBrowser);
            this.Controls.Add(this.r_btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.r_textBoxPath);
            this.Controls.Add(this.r_btnBack);
            this.Controls.Add(this.l_wBrowser);
            this.Controls.Add(this.l_btnOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_textBoxPath);
            this.Controls.Add(this.l_btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button l_btnBack;
        private System.Windows.Forms.TextBox l_textBoxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button l_btnOpen;
        private System.Windows.Forms.WebBrowser l_wBrowser;
        private System.Windows.Forms.WebBrowser r_wBrowser;
        private System.Windows.Forms.Button r_btnOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox r_textBoxPath;
        private System.Windows.Forms.Button r_btnBack;
        private System.Windows.Forms.TextBox l_textBoxNewFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox l_textBoxDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox r_textBoxDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox r_textBoxNewFolder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

