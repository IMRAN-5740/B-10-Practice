using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationshipwithOOP.CarEngineModule
{
    public class Engine
    {
        public Engine()
        {

        }
        public Engine(string engineNo, string engineModel, int horsePower)
         {
            EngineNo = engineNo;
            EngineModel = engineModel;
            HorsePower = horsePower;
        }

        public string EngineNo { get; set; }
        public string EngineModel { get; set; }
        public int HorsePower { get; set; }

        private bool isStarted { get; set; }
        private bool isAccelarate { get; set; }

        public void Start()
        { 
            if(!isStarted)
            {
                isStarted=true;
            }
        }
        public void Stop()
        {
            if (isStarted)
            {
                isStarted = false;
            } 
        }
        public void Accelarete()
        {
            isAccelarate=true;
        }
        public string GetEngineInformation()
        {
            string info = "\t\t\tEngine Information\t\t\t\n";
             info += "EngineNo\t\tEngineModel\t\tHorsePower\n";
            info += $"{EngineNo}\t\t{EngineModel}\t\t{HorsePower}";
            return info;
        }
    }
}
