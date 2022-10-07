using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCapacitatorCalc
{
    public static class CapacitatorCalc
    {
        public static decimal CalculateCapacity(decimal preResistance, decimal tau) => tau / preResistance;

        public static decimal CalculateSupplyVoltage(decimal preResistance, decimal maxCurrent) => preResistance * maxCurrent;

        public static decimal CalculatePreResistance(decimal tau, decimal capacity ) => tau / capacity;

        public static decimal CalculateChargingTime(decimal preResistance, decimal capacity) => (preResistance * capacity) * 5;

        public static decimal CalculateMaxCurrent(decimal supplyVoltage, decimal preResistance) => supplyVoltage / preResistance;

        public static decimal CalculateTau(decimal preResistance, decimal capacity) => preResistance * capacity;

    }
}
