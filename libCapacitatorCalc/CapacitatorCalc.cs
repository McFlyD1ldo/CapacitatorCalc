using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCapacitatorCalc
{
    public static class CapacitatorCalc
    {
        public static decimal CalculateCapacity(decimal preResistance, decimal chargingTime)
        {
            return (chargingTime / 5) / preResistance;
        }

        public static decimal CalculateSupplyVoltage(decimal preResistance, decimal maxCurrent)
        {
            return preResistance * maxCurrent;
        }

        public static decimal CalculatePreResistance(decimal capacity, decimal chargingTime)
        {
            return (chargingTime / 5) / capacity;
        }

        public static decimal CalculateChargingTime(decimal preResistance, decimal capacity)
        {
            return (preResistance * capacity) * 5;
        }

        public static decimal Calculatet0ChargingCurrent(decimal supplyVoltage, decimal preResistance)
        {
            return supplyVoltage / preResistance;
        }
    
        public static decimal CalculateTau(decimal preResistance, decimal capacity)
        {
            return preResistance * capacity;
        }
    
    }
}
