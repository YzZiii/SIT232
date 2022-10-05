using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        private double fuelEfficiency;
        private double fuelLevel;
        private int mileage;

        double FUEL_COST = 1.385;
        double GALLONS_TO_LITRES = 4.546;

        public Car(double efficiency, double fuel)
        {
            this.fuelEfficiency =efficiency;
            this.fuelEfficiency = fuel;
            this.mileage = 0;
        }
        public double getFuel()
        {
            return this.fuelLevel;
        }

        public int getTotalMiles()
        {
            return this.mileage;
        }
        public void setTotalMiles(int miles)
        {
            this.mileage = miles;
        }

        public String printFuelCost()
        {
            return this.FUEL_COST.ToString("C");
        }

        public double calcCost(double fuelLitres)
        {
            return fuelLitres * this.FUEL_COST;
        }
        public void addFuel(double fuelLitres)
        {
            this.fuelLevel += fuelLevel;
            double fillCost = calcCost(fuelLitres);
            Console.WriteLine("Cost of fill: "
                + calcCost(fuelLitres).ToString("C"));
        }

        public double convertToLitres(double gallons)
        {
            return gallons * this.GALLONS_TO_LITRES;
        }
        public void drive(int milesTravelled)
        {
            this.mileage += milesTravelled;
            double gallonsUsed = milesTravelled / this.fuelEfficiency;
            double litresUsed = convertToLitres(gallonsUsed);
            this.fuelLevel -= litresUsed;
            double tripCost = calcCost(litresUsed);
            Console.WriteLine("Total cost of travelling "
                + milesTravelled + " miles - "
                + tripCost.ToString("C"));
        }
    }
}
