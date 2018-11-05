using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesApp.Model
{
    class Region
    {
        private string _seværdigheder;
        private string _valuta;
        private string _info;

        public Region(string seværdigheder, string valuta, string info)
        {
            _seværdigheder = seværdigheder;
            _valuta = valuta;
            _info = info;
        }
    }

}
