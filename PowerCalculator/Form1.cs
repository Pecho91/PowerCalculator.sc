namespace PowerCalculator
{
    public partial class form_PowerCalculator : Form
    {
        public form_PowerCalculator()
        {
            InitializeComponent();

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
             try
               {
                string resistanceStr = txt_Resistance.Text.ToString();
                string currentStr = txt_Current.Text.ToString();
                string voltageStr = txt_Voltage.Text.ToString();
                string powerStr = txt_Power.Text.ToString();

                // parse the values into appropriate data types, handling empty strings
                double resistance = Double.TryParse(resistanceStr, out double res) && !string.IsNullOrEmpty(resistanceStr) ? res : 0;
                double current = Double.TryParse(currentStr, out double cur) && !string.IsNullOrEmpty(currentStr) ? cur : 0;
                double voltage = Double.TryParse(voltageStr, out double vol) && !string.IsNullOrEmpty(voltageStr) ? vol : 0;
                double power = Double.TryParse(powerStr, out double pow) && !string.IsNullOrEmpty(powerStr) ? pow : 0;

                performCalculations(resistance, current, voltage, power);
                    
               }
               catch (FormatException)
               {
                   Console.WriteLine("**************error");
                   return;
               }
        }

        private void txt_Input_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;

            if (txtBox == null && !System.Text.RegularExpressions.Regex.IsMatch(txtBox.Text, @"^[0-9]*\.?[0-9]*$"))
            {

                int cursorPosition = txtBox.SelectionStart;

                // MessageBox.Show("Plase enter only numbers and a decimal point");
                txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1);

                txtBox.SelectionStart = cursorPosition;
                txtBox.SelectionLength = 0;

            }
        }

        private void performCalculations(double resistance, double current, double voltage, double power)
        {

            Calculations calc = new Calculations(resistance, current, voltage, power);

            if (resistance != 0 && current != 0 && voltage != 0 && power != 0)
            {
                // no empty
                calc.calculateCurrent(0);
                calc.calculatePower(0);
                txt_Current.Text = calc.current.ToString();
                txt_Power.Text = calc.power.ToString();
            }
            // empty (resistance)
            else if (resistance == 0 && current != 0 && voltage != 0 && power != 0)
            {
                calc.calculateResistance(0);
                calc.calculatePower(0);
                txt_Resistance.Text = calc.resistance.ToString();
                txt_Power.Text = calc.power.ToString();
            }
            // empty (current)
            else if (resistance != 0 && current == 0 && voltage != 0 && power != 0)
            {
                calc.calculateCurrent(0);
                calc.calculatePower(0);
                txt_Current.Text = calc.current.ToString();
                txt_Power.Text = calc.power.ToString();
            }
            // empty (voltage)
            else if (resistance != 0 && current != 0 && voltage == 0 && power != 0)
            {
                calc.calculateVoltage(0);
                calc.calculatePower(0);
                txt_Voltage.Text = calc.voltage.ToString();
                txt_Power.Text = calc.power.ToString();
            }
            // empty (power)
            else if (resistance != 0 && current != 0 && voltage != 0 && power == 0)
            {
                calc.calculatePower(0);
                calc.calculateResistance(0);
                txt_Power.Text = calc.power.ToString();
                txt_Resistance.Text = calc.resistance.ToString();
            }
            // empty (resistance, current)
            else if (resistance == 0 && current == 0 && voltage != 0 && power != 0)
            {
                calc.calculateResistance(2);
                calc.calculateCurrent(2);
                txt_Resistance.Text = calc.resistance.ToString();
                txt_Current.Text = calc.current.ToString();
            }
            // empty (current, voltage)
            else if (resistance != 0 && current == 0 && voltage == 0 && power != 0)
            {
                calc.calculateCurrent(1);
                calc.calculateVoltage(2);
                txt_Current.Text = calc.current.ToString();
                txt_Voltage.Text = calc.voltage.ToString();
            }
            // empty (voltage, power)
            else if (resistance != 0 && current != 0 && voltage == 0 && power == 0)
            {
                calc.calculateVoltage(0);
                calc.calculatePower(2);
                txt_Voltage.Text = calc.voltage.ToString();
                txt_Power.Text = calc.power.ToString();
            }
            // empty (resistance, power)
            else if (resistance == 0 && current != 0 && voltage != 0 && power == 0)
            {
                calc.calculateResistance(0);
                calc.calculatePower(0);
                txt_Resistance.Text = calc.resistance.ToString();
                txt_Power.Text = calc.power.ToString();
                
            }
            // empty (resistance, voltage)
            else if (resistance == 0 && current != 0 && voltage == 0 && power != 0)
            {
                calc.calculateResistance(1);
                calc.calculateVoltage(1);
                txt_Resistance.Text = calc.resistance.ToString();
                txt_Voltage.Text = calc.voltage.ToString();
            }
            // empty (current, power)
            else if (resistance != 0 && current == 0 && voltage != 0 && power == 0)
            {
                calc.calculateCurrent(0);
                calc.calculatePower(1);
                txt_Current.Text = calc.current.ToString();
                txt_Power.Text = calc.power.ToString();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Resistance.Text = "";
            txt_Current.Text = "";
            txt_Voltage.Text = "";
            txt_Power.Text = "";
        }
    }
}