using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Watering
{
    class Section
    {
        private Region[] _regions;
        private string _name;

        public Region[] GetFields()
        {
            return _regions;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetFields(Region[] regions)
        {
            _regions = regions;
        }
        public void SetName(string name)
        {
            _name = name;
        }
    }
}
