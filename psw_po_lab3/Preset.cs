using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psw_po_lab3
{
    class Preset
    {
        //Wiem że można inaczej, ale świadomie nie korzystam z automatycznej właśniwości Name.
        private string name;
        private double value;

        public string Name
        {
            get => name;
            private set => name = value;
        }

        public double Value
        {
            get => value;
            private set => this.value = Calculator.Clamp(0, 100, value);
        }

        public Preset(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
