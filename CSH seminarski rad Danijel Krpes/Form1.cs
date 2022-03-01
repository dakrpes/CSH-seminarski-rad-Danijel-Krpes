using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSH_seminarski_rad_Danijel_Krpes
{
    public partial class DistanceCalculatorForm : Form
    {
        public DistanceCalculatorForm()
        {
            InitializeComponent();

            MeasuringUnits.DropDownStyle = ComboBoxStyle.DropDown;
            MeasuringUnits.Items.Add("km");
            MeasuringUnits.Items.Add("m");
            MeasuringUnits.Items.Add("cm");
            MeasuringUnits.Items.Add("mm");
            this.Controls.Add(MeasuringUnits);

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearInputButton_Click(object sender, EventArgs e)
        {
            InputTextbox.Clear();
            MeasuringUnits.SelectedIndex = -1;
        }
    }
}
