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

namespace ExpenseTracker
{
    public partial class Transactions : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public Transactions()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.LightBlue700, TextShade.WHITE);
        }

        private void Transactions_Load(object sender, EventArgs e)
        {

        }
    }
}
