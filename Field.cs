using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Watering
{
    class Field
    {
        private Sensor _sensor;
        private Plant _plant;
        private double _area;
        private string _groundType;

        public Sensor GetSensor()
        {
            return _sensor;
        }
        public Plant GetPlant()
        {
            return _plant;
        }
        public double GetArea()
        {
            return _area;
        }
        public string GetGroundType()
        {
            return _groundType;
        }

        public void SetSensor(Sensor sensor)
        {
            _sensor = sensor;
        }
        public void SetPlant(Plant plant)
        {
            _plant = plant;
        }
        public void SetArea(double area)
        {
            _area = area;
        }
        public void SetGroundType(string groundType)
        {
            _groundType = groundType;
        }


    }
}
