using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Watering
{
    class Plant
    {
        private string _name;
        private int _optimalHumidity;

        public string GetName()
        {
            return _name;
        }
        public int GetOptimalHumidity()
        {
            return _optimalHumidity;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public void SetOptimalHumidity(int optimalHumidity)
        {
            _optimalHumidity = optimalHumidity;
        }
    }
}
