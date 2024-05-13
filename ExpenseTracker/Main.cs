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

        private Button clickedButton; // Store reference to clicked button
        private void ChangeButtonColor(object sender)
        {
            if (clickedButton != null)
            {
                clickedButton.BackColor = System.Drawing.Color.FromArgb(79, 112, 163); // Revert previous button
            }
            clickedButton = (Button)sender; // Store clicked button reference
            clickedButton.BackColor = System.Drawing.Color.FromArgb(62, 68, 121); // Set clicked color
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            dashboard1.Visible = true;
            category1.Visible = false;
            accounts1.Visible = false;
        }

        private void transactionsBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            dashboard1.Visible = false;
            category1.Visible = true;
            accounts1.Visible = false;
        }

        private void accountsBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            dashboard1.Visible = false;
            category1.Visible = false;
            accounts1.Visible = true;
        }

        private void MaterialForm_Load(object sender, EventArgs e)
        {
            dashboardBtn.PerformClick();
        }
    }
}
