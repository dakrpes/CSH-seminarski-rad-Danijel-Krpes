
namespace CSH_seminarski_rad_Danijel_Krpes
{
    partial class DistanceCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.MeasuringUnits = new System.Windows.Forms.ComboBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultsMeasuringUnitLabel = new System.Windows.Forms.Label();
            this.ClearInputButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InputInstructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(27, 76);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputTextbox.Size = new System.Drawing.Size(626, 27);
            this.InputTextbox.TabIndex = 0;
            // 
            // MeasuringUnits
            // 
            this.MeasuringUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MeasuringUnits.FormattingEnabled = true;
            this.MeasuringUnits.Location = new System.Drawing.Point(193, 127);
            this.MeasuringUnits.Name = "MeasuringUnits";
            this.MeasuringUnits.Size = new System.Drawing.Size(80, 28);
            this.MeasuringUnits.TabIndex = 1;
            this.MeasuringUnits.SelectionChangeCommitted += new System.EventHandler(this.MeasuringUnits_SelectionChangeCommitted);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Location = new System.Drawing.Point(27, 29);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(626, 20);
            this.InstructionsLabel.TabIndex = 2;
            this.InstructionsLabel.Text = "Insert distance and measuring unit for all values and mathematical operation betw" +
    "een them.  ";
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(85, 171);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.ReadOnly = true;
            this.ResultTextbox.Size = new System.Drawing.Size(568, 27);
            this.ResultTextbox.TabIndex = 3;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(27, 174);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(52, 20);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Result:";
            // 
            // ResultsMeasuringUnitLabel
            // 
            this.ResultsMeasuringUnitLabel.AutoSize = true;
            this.ResultsMeasuringUnitLabel.Location = new System.Drawing.Point(27, 130);
            this.ResultsMeasuringUnitLabel.Name = "ResultsMeasuringUnitLabel";
            this.ResultsMeasuringUnitLabel.Size = new System.Drawing.Size(160, 20);
            this.ResultsMeasuringUnitLabel.TabIndex = 5;
            this.ResultsMeasuringUnitLabel.Text = "Results measuring unit:";
            // 
            // ClearInputButton
            // 
            this.ClearInputButton.Location = new System.Drawing.Point(27, 220);
            this.ClearInputButton.Name = "ClearInputButton";
            this.ClearInputButton.Size = new System.Drawing.Size(104, 29);
            this.ClearInputButton.TabIndex = 6;
            this.ClearInputButton.Text = "Clear input";
            this.ClearInputButton.UseVisualStyleBackColor = true;
            this.ClearInputButton.Click += new System.EventHandler(this.ClearInputButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(559, 220);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 29);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InputInstructionsLabel
            // 
            this.InputInstructionsLabel.AutoSize = true;
            this.InputInstructionsLabel.Location = new System.Drawing.Point(27, 53);
            this.InputInstructionsLabel.Name = "InputInstructionsLabel";
            this.InputInstructionsLabel.Size = new System.Drawing.Size(575, 20);
            this.InputInstructionsLabel.TabIndex = 8;
            this.InputInstructionsLabel.Text = "Please insert blank space between each parameter. For example: 14 km - 5 km + 90 " +
    "m";
            // 
            // DistanceCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(682, 261);
            this.Controls.Add(this.InputInstructionsLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearInputButton);
            this.Controls.Add(this.ResultsMeasuringUnitLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.MeasuringUnits);
            this.Controls.Add(this.InputTextbox);
            this.Name = "DistanceCalculatorForm";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.ComboBox MeasuringUnits;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.TextBox ResultTextbox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ResultsMeasuringUnitLabel;
        private System.Windows.Forms.Button ClearInputButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label InputInstructionsLabel;
    }
}

