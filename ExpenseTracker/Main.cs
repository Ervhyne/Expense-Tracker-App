using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Media;
using System.Windows;
using GemBox.Document.Drawing;

namespace ExpenseTracker
{
    public partial class MaterialForm : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public MaterialForm()
        { 
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey700, Accent.LightBlue700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
       
    }
}
