using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool EngineNoise { get; set; }
        public bool HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()

        public void MakeEngineNoise()
        {
            if (EngineNoise == true)
            {
                Console.WriteLine("Vroom vroom");
            }
            else
            {
                Console.WriteLine("Put put");
            }
        }

        public void MakeHonkNoise()
        {
            if (HonkNoise == true)
            {
                Console.WriteLine("Awooga!");
            }
            else
            {
                Console.WriteLine("beep beep");
            }
        }
    }
}
