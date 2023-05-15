using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Currency
    {
        public string name;
        public float multiplier;

        public Currency(string name)
        {
            this.name = name;

            if (name == _ruble) { this.multiplier = _rubleMultiplier; }
            else if (name == _somoni) { this.multiplier = _somoniMultiplier; }
            else if (name == _yen) { this.multiplier = _yenMultiplier; }
        }
        private string _ruble { get; set; } = "RUB";
        private string _somoni { get; set; } = "TJS";
        private string _yen { get; set; } = "JPY";

        private float _yenMultiplier { get; set; } = 1.74f;
        private float _somoniMultiplier { get; set; } = 0.14136f;
        private float _rubleMultiplier { get; set; } = 1f;

        List<string> currencies = new List<string>();

       




    }
}
