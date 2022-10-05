using System;

namespace Car
{
    class CarProgram
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(10.5, 50.5); // Create a mycar object

            //testing total set miles and fuel
            myCar.setTotalMiles(100);
            Console.WriteLine("Current mileage: " + myCar.getTotalMiles()
                + ", Current fuel: " + myCar.getFuel());

            //testing add fuel and display cost of fuel
            myCar.addFuel(22);
            Console.WriteLine("Current mileage: " + myCar.getTotalMiles()
                + ", Current fuel: " + myCar.getFuel());

            //testing driving 
            myCar.drive(30);
            Console.WriteLine("Current mileage: " + myCar.getTotalMiles()
                + ", Current fuel: " + myCar.getFuel());

            Console.ReadLine();
        }
    }
}
