using libCapacitatorCalc;

namespace caCapacitator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            libValueService.ValueService vs = new();
            Capacitator capacitator = new();
            capacitator.preResistance = vs.GetDecimal("10k");
            capacitator.Tau = vs.GetDecimal("100n");
            Console.WriteLine($"Capacity: {vs.GetDisplayValue(CapacitatorCalc.CalculateCapacity(capacitator.preResistance, CapacitatorCalc.CalculateChargingTime(capacitator.Tau)), 0)}F");

        }
    }
}