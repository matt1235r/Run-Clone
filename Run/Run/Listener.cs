using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run
{
    public partial class Register : Form
    {

        KeyboardHook hook = new KeyboardHook();

        public Register()
        {
            InitializeComponent();

            hook.KeyPressed +=
             new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(2 | 8,
                Keys.R);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (Application.OpenForms.OfType<Run>().Count() == 1)
            {
                Application.OpenForms.OfType<Run>().First().BringToFront();
                Application.OpenForms.OfType<Run>().First().Activate();
            }
            else
            {
                Run run = new Run();
                run.ShowDialog();
                run.BringToFront();
                run.Activate();
            }
            
        }

    }
}
