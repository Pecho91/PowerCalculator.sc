using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerCalculator
{
    public class Calculations
    {
        public double resistance;
        public double current;
        public double voltage;
        public double power;   

        public Calculations(double resistance, double current, double voltage, double power)
        {
           
            this.resistance = resistance;
            this.current = current;
            this.voltage = voltage;
            this.power = power;
        }

        public void calculateResistance(int calcOption)
        {
            if (calcOption == 0)
            {
                resistance = voltage / current;
                
            }
            else if (calcOption == 1)
            {
                resistance = power / Math.Pow(current, 2);
            }
            else
            {
                resistance = Math.Pow(voltage, 2) / power;
            }
        }

        public void calculateCurrent(int calcOption)
        {
            if (calcOption == 0)
            {
                current = voltage / resistance;
            }
            else if(calcOption == 1)
            {
                current = Math.Sqrt(power / resistance);
            }
            else
            {
                current = power / voltage;
            }
        }

        public void calculateVoltage(int calcOption)
        {
            if(calcOption == 0)
            {
                voltage = resistance * current;
            }
            else if (calcOption == 1)
            {
                voltage = power / current;
            }
            else
            {
                voltage = Math.Sqrt(power * resistance);

            }
        }

        public void calculatePower(int calcOption)
        {
            if(calcOption == 0)
            {
                power = voltage * current;
            }
            else if(calcOption == 1)
            {
                power = Math.Pow(voltage, 2) / resistance;
            }
            else
            {
                power = Math.Pow(current, 2) * resistance;
            }
        }
    }
}
