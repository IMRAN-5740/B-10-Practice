using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationshipwithOOP.CarEngineModule
{
    public class Car
    {
        public Car()
        {
            Engine = new Engine();
        }

        //public Car(string modelNo, string color, string chasisNo)
        //{
        //    ModelNo = modelNo;
        //    Color = color;
        //    ChasisNo = chasisNo;
        //}
        public Car(Engine engine)
        {
            Engine = engine;

        }

        public string ModelNo { get; set; }
        public string Color { get; set; }
        public string ChasisNo { get; set; }
        private Engine Engine { get; set; }



        public string GetCarInformation()
        {
            string info = "\t\t\t Car Information \t\t\t\n";
            info+= "ModelNo\t\tColor\t\tChasisNo\n";

            info +=$"{ModelNo}\t\t{Color}\t\t{ChasisNo}\n";
            info += ".................................\n";
            info += $"{Engine.GetEngineInformation()}";
            return info;
        }
        public void Start()
        {
            Engine.Start();
        }
        public void Stop()
        {
            Engine.Stop();
        }
        public void Accelarate()
        {
            Engine.Accelarete();
        }

    }
}
