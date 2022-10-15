using libCapacitatorCalc;
using System.Text.RegularExpressions;
using System.Xml.XPath;

namespace wfCapacitator
{
    public partial class Form1 : Form
    {
        private int whatTodo;

        private libValueService.ValueService vs = new();

        private Capacitator capacitator = new();
        public Form1()
        {
            InitializeComponent();
            //add the textShort of Postfactors to datasource of comboboxes and add the suffix 
            cbCapacity.DataSource = vs.PostFactors.Select(x => x.TextShort + "F").ToList();
            cbTau.DataSource = vs.PostFactors.Select(x => x.TextShort + "s").ToList();
            cbChargeTime.DataSource = vs.PostFactors.Select(x => x.TextShort + "s").ToList();
            cbCurrent.DataSource = vs.PostFactors.Select(x => x.TextShort + "A").ToList();
            cbResistance.DataSource = vs.PostFactors.Select(x => x.TextShort + "Ω").ToList();
            cbVoltage.DataSource = vs.PostFactors.Select(x => x.TextShort + "V").ToList();
        }

        private void clbToDo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //allow user to only check one item at a time
            for (int i = 0; i < clbToDo.Items.Count; ++i) if (i != e.Index) clbToDo.SetItemChecked(i, false);

            //change the availability of input into the different textboxes depending on the values needed for calculating
            switch (e.Index)
            {
                case 0:
                    tbCapacity.ReadOnly = true;
                    tbTau.ReadOnly = false;
                    tbCurrent.ReadOnly = true;
                    tbResistance.ReadOnly = false;
                    tbVoltage.ReadOnly = true;
                    break;

                case 1:
                    tbCapacity.ReadOnly = false;
                    tbTau.ReadOnly = true;
                    tbCurrent.ReadOnly = true;
                    tbResistance.ReadOnly = false;
                    tbVoltage.ReadOnly = true;
                    break;

                case 2:
                    tbCapacity.ReadOnly = false;
                    tbTau.ReadOnly = true;
                    tbCurrent.ReadOnly = true;
                    tbResistance.ReadOnly = false;
                    tbVoltage.ReadOnly = true;
                    break;

                case 3:
                    tbCapacity.ReadOnly = true;
                    tbTau.ReadOnly = true;
                    tbCurrent.ReadOnly = true;
                    tbResistance.ReadOnly = false;
                    tbVoltage.ReadOnly = false;
                    break;

                case 4:
                    tbCapacity.ReadOnly = false;
                    tbTau.ReadOnly = false;
                    tbCurrent.ReadOnly = false;
                    tbResistance.ReadOnly = true;
                    tbVoltage.ReadOnly = false;
                    break;

                case 5:
                    tbCapacity.ReadOnly = true;
                    tbTau.ReadOnly = true;
                    tbCurrent.ReadOnly = false;
                    tbResistance.ReadOnly = false;
                    tbVoltage.ReadOnly = true;
                    break;

                default:
                    break;
            }
            //set the value of variable determining what calculations to do
            whatTodo = e.Index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (whatTodo)
            {
                //Calculate the capacity from tau and resistance and display the charging time aswell
                case 0:
                    capacitator.preResistance = vs.GetDecimal(tbResistance.Text + cbResistance.SelectedValue.ToString().Replace('Ω', ' ').Trim());
                    capacitator.Tau = vs.GetDecimal(tbTau.Text + cbTau.SelectedValue.ToString().Replace('s', ' ').Trim());
                    capacitator.capacity = CapacitatorCalc.CalculateCapacity(capacitator.preResistance, capacitator.Tau);
                    capacitator.chargingTime = CapacitatorCalc.CalculateChargingTime(capacitator.preResistance, capacitator.capacity);
                    tbCapacity.Text = capacitator.capacity.ToString();
                    tbChargeTime.Text = capacitator.chargingTime.ToString();
                    break;

                //Calculate tau from capacity and resistance and display the charging time aswell
                case 1:
                    capacitator.preResistance = vs.GetDecimal(tbResistance.Text + cbResistance.SelectedValue.ToString().Replace('Ω', ' ').Trim());
                    capacitator.capacity = vs.GetDecimal(tbCapacity.Text + cbCapacity.SelectedValue.ToString().Replace('F', ' ').Trim());
                    capacitator.chargingTime = CapacitatorCalc.CalculateChargingTime(capacitator.preResistance, capacitator.capacity);
                    capacitator.Tau = CapacitatorCalc.CalculateTau(capacitator.preResistance, capacitator.capacity);
                    tbTau.Text = capacitator.Tau.ToString();
                    tbChargeTime.Text = capacitator.chargingTime.ToString();
                    break;

                //Calculate charging time from capacity and resistance and display tau aswell
                case 2:
                    capacitator.preResistance = vs.GetDecimal(tbResistance.Text + cbResistance.SelectedValue.ToString().Replace('Ω', ' ').Trim());
                    capacitator.capacity = vs.GetDecimal((tbCapacity.Text + cbCapacity.SelectedValue.ToString().Replace('F', ' ').Trim()));
                    capacitator.chargingTime = CapacitatorCalc.CalculateChargingTime(capacitator.preResistance, capacitator.capacity);
                    capacitator.Tau = CapacitatorCalc.CalculateTau(capacitator.preResistance, capacitator.capacity);
                    tbTau.Text = capacitator.Tau.ToString();
                    tbChargeTime.Text = capacitator.chargingTime.ToString();
                    break;

                //calculate the maximum current from resistance and voltage
                case 3:
                    capacitator.preResistance = vs.GetDecimal(tbResistance.Text + cbResistance.SelectedValue.ToString().Replace('Ω', ' ').Trim());
                    capacitator.supplyVoltage = vs.GetDecimal(tbVoltage.Text + cbVoltage.SelectedValue.ToString().Replace('V', ' ').Trim());
                    capacitator.maxCurrent = CapacitatorCalc.CalculateMaxCurrent(capacitator.supplyVoltage, capacitator.preResistance);
                    tbCurrent.Text = capacitator.maxCurrent.ToString();
                    break;

                //calculate the Resistance from either capacity and tau or current and voltage depending on the user input
                case 4:
                    try
                    {
                        if (!String.IsNullOrEmpty(tbTau.Text) && !String.IsNullOrEmpty(tbCapacity.Text))
                        {
                            capacitator.Tau = vs.GetDecimal(tbTau.Text + cbTau.SelectedValue.ToString().Replace('s', ' ').Trim());
                            capacitator.capacity = vs.GetDecimal(tbCapacity.Text + cbCapacity.SelectedValue.ToString().Replace('F', ' ').Trim());
                            capacitator.preResistance = CapacitatorCalc.CalculatePreResistance(capacitator.Tau, capacitator.capacity);
                        }
                        else
                        {
                            capacitator.maxCurrent = vs.GetDecimal(tbCurrent.Text + cbCurrent.SelectedValue.ToString().Replace('A', ' ').Trim());
                            capacitator.supplyVoltage = vs.GetDecimal(tbVoltage.Text + cbVoltage.SelectedValue.ToString().Replace('V', ' ').Trim());
                            capacitator.preResistance = CapacitatorCalc.CalculatePreResistance(capacitator.supplyVoltage, capacitator.maxCurrent);
                        }
                        tbResistance.Text = capacitator.preResistance.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please enter a value for either tau and capacity or current and voltage");
                    }
                    break;

                //calculate the suppy Voltage from resistance and current 
                case 5:
                    capacitator.preResistance = vs.GetDecimal(tbResistance.Text + cbResistance.SelectedValue.ToString().Replace('Ω', ' ').Trim());
                    capacitator.maxCurrent = vs.GetDecimal(tbCurrent.Text + cbCurrent.SelectedValue.ToString().Replace('A', ' ').Trim());
                    capacitator.supplyVoltage = CapacitatorCalc.CalculateSupplyVoltage(capacitator.preResistance, capacitator.maxCurrent);
                    tbVoltage.Text = capacitator.supplyVoltage.ToString();
                    break;

                default:
                    break;
            }
        }


        //the following methods replace any text input into the textboxes that is not a number with an empty string
        private void tbCapacity_TextChanged(object sender, EventArgs e)
        {
            tbCapacity.Text = Regex.Replace(tbCapacity.Text, "[^0-9]", "");
        }

        private void tbTau_TextChanged(object sender, EventArgs e)
        {
            tbTau.Text = Regex.Replace(tbTau.Text, "[^0-9]", "");
        }

        private void tbChargeTime_TextChanged(object sender, EventArgs e)
        {
            tbChargeTime.Text = Regex.Replace(tbChargeTime.Text, "[^0-9]", "");
        }

        private void tbCurrent_TextChanged(object sender, EventArgs e)
        {
            tbCurrent.Text = Regex.Replace(tbCurrent.Text, "[^0-9]", "");
        }

        private void tbResistance_TextChanged(object sender, EventArgs e)
        {
            tbResistance.Text = Regex.Replace(tbResistance.Text, "[^0-9]", "");
        }

        private void tbVoltage_TextChanged(object sender, EventArgs e)
        {
            tbVoltage.Text = Regex.Replace(tbVoltage.Text, "[^0-9]", "");
        }
    }
}