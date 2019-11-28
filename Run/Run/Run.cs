using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run
{
    public partial class Run : Form
    {
        public Run()
        {
            InitializeComponent();
        }

       

        private void Run_Load(object sender, EventArgs e)
        {
            const int margin = 10;
            int x = Screen.PrimaryScreen.WorkingArea.Left - margin + 20;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom -
                this.Height - margin;
            this.Location = new Point(x, y);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                comboBox.Text = openFileDialog.FileName;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.ExpandEnvironmentVariables(comboBox.Text);

                Process proc = new Process();
                proc.StartInfo.FileName = path;

                if (adminCheckBox.Checked)
                {                   
                    proc.StartInfo.Verb = "runas";                    
                }

                proc.Start();
                this.Close();
            }
            catch (OperationCanceledException)
            {
                this.Close();
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException)
                {
                    MessageBox.Show("ffffffff");
                }
                MessageBox.Show("Windows cannot find '" + comboBox.Text + "'. Make sure you've typed the name correctly, then try again.", comboBox.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox.Text.Length == 0)
            {
                okButton.Enabled = false;
            }
            else
            {
                okButton.Enabled = true;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                okButton.PerformClick();
            }
        }
    }
}
