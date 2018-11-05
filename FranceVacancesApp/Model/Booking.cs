using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesApp.Model
{
    class Booking
    {
        private int _bookingNr;
        private Udlejer _udlejer;
        private Lejer _kunde;
        private Bolig _bolig;
        private DateTime _fraDato;
        private DateTime _tilDato;

        public Booking(int bookingNr, Udlejer udlejer, Lejer kunde, Bolig bolig, DateTime fraDato, DateTime tilDato)
        {
            _bookingNr = bookingNr;
            _udlejer = udlejer;
            _kunde = kunde;
            _bolig = bolig;
            _fraDato = fraDato;
            _tilDato = tilDato;
        }

        public void OpretBooking()
        {
            //associate en ny booking med en bolig, bruger og måske ejer ?
        }
    }
}
