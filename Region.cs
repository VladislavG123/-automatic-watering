using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Watering
{
    class Region
    {
        private Field[] _fields;
        private string _name;

        public Field[] GetFields()
        {
            return _fields;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetFields(Field[] fields)
        {
            _fields = fields;
        }
        public void SetName(string name)
        {
            _name = name;
        }
    }
}
