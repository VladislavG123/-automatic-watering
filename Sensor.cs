using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Watering
{
    class Sensor
    {
        private bool _isRain;
        private double _humidity;

        #region Getters and Setters
        public bool GetIsRain()
        {
            return _isRain;
        }
        public double GetHumidity()
        {
            return _humidity;
        }
        public void SetHumidity(double humidity)
        {
            _humidity = humidity;
        }
        public void SetIsRain(bool isRain)
        {
            _isRain = isRain;
        }
        #endregion
    }
}
