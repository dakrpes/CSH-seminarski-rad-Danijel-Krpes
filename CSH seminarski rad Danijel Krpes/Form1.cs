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
            ResultTextbox.Text = "";
        }

        private void MeasuringUnits_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            string[] inputParameters = InputTextbox.Text.ToString().Split(' ');
            List<double> values = new();
            List<string> measuringUnits = new();
            List<string> operators = new();
            double? result = 0;

            try
            {
                for (int i = 0; i < inputParameters.Length; i += 3)
                {
                    values.Add(double.Parse(inputParameters[i]));
                }

                for (int i = 1; i < inputParameters.Length; i += 3)
                {
                    measuringUnits.Add(inputParameters[i]);
                }

                for (int i = 2; i < inputParameters.Length; i += 3)
                {
                    operators.Add(inputParameters[i]);
                }

                result += ToMeters(measuringUnits.ElementAt(0), values.ElementAt(0));



                for (int i = 1; i < values.Count; i++)
                {
                    if (operators.ElementAt(i - 1).Count() > 1)
                        throw new ArgumentException();

                    if (operators.ElementAt(i - 1).Equals("+"))
                    {
                        result += ToMeters(measuringUnits.ElementAt(i), values.ElementAt(i));
                    }
                    else
                    {
                        result -= ToMeters(measuringUnits.ElementAt(i), values.ElementAt(i));
                    }
                }

                switch (MeasuringUnits.SelectedIndex)
                {
                    case 0:
                        result /= 1000;
                        ResultTextbox.Text = result.ToString() + " km";
                        break;
                    case 1:
                        ResultTextbox.Text = result.ToString() + " m";
                        break;
                    case 2:
                        result *= 100;
                        ResultTextbox.Text = result.ToString() + " cm";
                        break;
                    case 3:
                        result *= 1000;
                        ResultTextbox.Text = result.ToString() + " mm";
                        break;
                }
            }
            catch
            {
                InputTextbox.Text = "Invalid input. Clear inputs and please try again.";
                ResultTextbox.Text = "Error.";
                result = null;
            }
        }

        private double ToMeters(string unit, double value)
        {
            switch (unit)
            {
                case "km":
                    value *= 1000;
                    break;
                case "m":
                    break;
                case "cm":
                    value /= 100;
                    break;
                case "mm":
                    value /= 1000;
                    break;
            }
            return value;
        }
    }
}