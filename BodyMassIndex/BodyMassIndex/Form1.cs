using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    /// <summary>
    /// --------------------CLASS COMMENT--------------------
    /// Name:               Michael Leontieff-Smith
    /// Student ID:         N9455396
    /// 
    /// Name: Body Mass Index
    /// 
    /// Calculates the body mass index of the user using supplied 
    /// information then correlates that with predefined states such
    /// as under and overweight.
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
         // function parameter variables 
        const int WEIGHT = 0;
        const int HEIGHT = 1;
        const double INVALIDATED_OUTPUT = -1;
        const int STATES_COUNT = 4;
        // max values
        const double MIN_WEIGHT = 45;
        const double MIN_HEIGHT = 1.2;
        const double MAX_HEIGHT = 2.7;
        // BMI State maximums
        const double MAX_UNDERWEIGHT = 18.5;
        const double MAX_HEALTHY = 24.99;
        const double MAX_OVERWEIGHT = 29.99;
        // declare enum for naming BMI ranges, these form part of the output string
        enum state { Underweight, Healthy, Overweight, Obese}


        /// <summary>
        /// Calculates BMI using supplied values that have been converted to 
        /// doubles
        /// </summary>
        /// <param name="weight_input">double weight input</param>
        /// <param name="height_input">double height input </param>
        /// <returns>returns the double BMI value</returns>
        static double CalculateBMI(double weight_input, double height_input)
        {
            double bodyMI = 0;
            bodyMI = weight_input / (height_input * height_input);
            return bodyMI;
        }

        /// <summary>
        /// accepts BMI as parameter and returns appropriate enum
        /// </summary>
        /// <param name="bodyMI">calculated BMI</param>
        /// <returns>corresponding enum bassed on which range the BMI resides within</returns>
        static state CalculateStatus(double bodyMI)
        {
            if (bodyMI < MAX_UNDERWEIGHT)
            {
                return state.Underweight;
            }
            else if (bodyMI >= MAX_UNDERWEIGHT && bodyMI <= MAX_HEALTHY)
            {
                return state.Healthy;
            }
            else if (bodyMI > MAX_HEALTHY && bodyMI < MAX_OVERWEIGHT)
            {
                return state.Overweight;
            }
            else
            {
                return state.Obese;
            }
        }

        /// <summary>
        /// Converts the input to double and presents error if invalid data entered
        /// </summary>
        /// <param name="user_input">string input from textbox</param>
        /// <returns>user input converted to double</returns>
        static double ConvertInput(string user_input)
        {
            double validated_output;

                if (!double.TryParse(user_input, out validated_output))
                {
                    MessageBox.Show("Error! Please Enter Numeric Value");
                }
                else
                {
                    return validated_output; 
                }

            return INVALIDATED_OUTPUT;
        }

        /// <summary>
        /// Accepts the double-converted user input and checkes whether it's within bounds
        /// </summary>
        /// <param name="value">the double user value</param>
        /// <param name="type">used to check whether the value is for weight or height</param>
        /// <returns>true or false depending on whether it's valid or not for the respective boundary</returns>
        static bool VerifyBounds(double value, int type)
        {
            if (type == WEIGHT)
            {
                if (value >= MIN_WEIGHT)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Weight value below minimum of 45kg");
                }
            }
            // Height is the only other option
            else
            {
                if (value <= MAX_HEIGHT && value >= MIN_HEIGHT)
                {
                    return true;
                }
                else if (value > MAX_HEIGHT)
                {
                    MessageBox.Show("Height is above the max of 2.7m");
                }
                else
                {
                    MessageBox.Show("Height is below the minimum of 1.2m");
                }
            }
            return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// runs functions required to calculate input then formulate a string and
        /// display a textbox
        /// </summary>
        /// <param name="weight_input">verified within boundary weight double</param>
        /// <param name="height_input">verified within boundary height double</param>
        static void Output_BMI(double weight_input, double height_input)
        {
            double result;
            string BMIoutput;
            // calculate BMI
            result = CalculateBMI(weight_input, height_input);
            result = Math.Round(result, 2);
            // convert result to string for display
            BMIoutput = "Your BMI is '" + result.ToString() + "' indicating that you are " + CalculateStatus(result);
            MessageBox.Show(BMIoutput);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // doubles to store variables for parsing to BMI function
            double weight_input, height_input;

            // process input
            weight_input = ConvertInput(txtWeightInput.Text);
            height_input = ConvertInput(txtHeightInput.Text);


            // pass the verified double values to the verify bounds method
            if (weight_input != INVALIDATED_OUTPUT && height_input != INVALIDATED_OUTPUT)
            {

                if (!VerifyBounds(weight_input, WEIGHT) || !VerifyBounds(height_input, HEIGHT))
                {
                    rbCalcNo.Checked = false;
                    rbCalcYes.Checked = false;
                }
                else
                {
                    Output_BMI(weight_input, height_input);
                    rbCalcNo.Checked = false;
                    rbCalcYes.Checked = false;
                }
            }
            // Enable visibility of group box
            gbAnotherCalc.Visible = true;

            // Disable text fields and button
            txtHeightInput.Enabled = false;
            txtWeightInput.Enabled = false;
            btnCalculate.Enabled = false;

            // un-check 'yes' if already checked
            rbCalcYes.Checked = false;
        }

        private void rbCalcYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCalcYes.Checked)
            {
                // Clear text fields
                txtHeightInput.Text = string.Empty;
                txtWeightInput.Text = string.Empty;
                // Re-Enable text fields and button
                txtHeightInput.Enabled = true;
                txtWeightInput.Enabled = true;
                btnCalculate.Enabled = true;
                // Hide group box
                gbAnotherCalc.Visible = false;
            }
        }

        private void rbCalcNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCalcNo.Checked)
            {
                MessageBox.Show("That's all folks", "Exit Program");
                this.Close();
            }
            
        }
    }
}
