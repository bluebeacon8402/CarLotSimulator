using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property - I did not do this - Bool instead.


            //Now that the Car class is created we can instanciate 3 new cars - DONE
            var Car1 = new Car() { Year = 1988, Make = "Nissan", Model = "Pathfinder", EngineNoise = true, HonkNoise = true, IsDriveable = true };
            var Car2 = new Car() { Year = 2000, Make = "Ford", Model = "Focus", EngineNoise = false, HonkNoise = false, IsDriveable = true };
            var Car3 = new Car() { Year = 2019, Make = "Chevy", Model = "Impalla", EngineNoise = true, HonkNoise = false, IsDriveable = true };
            //Set the properties for each of the cars - DONE

            //Call each of the methods for each car - DONE
            Car1.MakeEngineNoise();
            Car2.MakeEngineNoise();
            Car3.MakeEngineNoise();

            Car1.MakeHonkNoise();
            Car2.MakeHonkNoise();
            Car3.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
