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
            MeasuringUnits.SelectedIndex = -1; //Default value (empty)
        }

        private void MeasuringUnits_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string[] inputParameters = InputTextbox.Text.ToString().Split(' ');
            List<int> values = new();
            List<string> measuringUnits = new();
            List<string> operators = new();

            for (int i = 0; i < inputParameters.Length; i += 3)
            {
                values.Add(int.Parse(inputParameters[i]));
            }

            for (int i = 1; i < inputParameters.Length; i += 3)
            {
                measuringUnits.Add(inputParameters[i]);
            }

            for (int i = 2; i < inputParameters.Length; i += 3)
            {
                operators.Add(inputParameters[i]);
            }

        }
    }
}


// 14 km + 79 m - 5 mm
/*0  14  
 *1  km
 *2  +
 *3  79
 *4  m
 *5  -
 *6  5
 *7  mm
 */
