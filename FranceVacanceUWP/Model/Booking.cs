using System;

namespace FranceVacanceUWP.Model
{
    internal class Booking
    {
        public int BookingNr { get; set; }
        public Udlejer Udlejer { get; set; }
        public Lejer Kunde { get; set; }
        public Bolig Bolig { get; set; }
        public DateTime FraDato { get; set; }
        public DateTime TilDato { get; set; }

        public Booking()
        {
        }

        public Booking(int bookingNr, Udlejer udlejer, Lejer kunde, Bolig bolig,
            DateTime fraDato, DateTime tilDato)
        {
            BookingNr = bookingNr;
            Udlejer = udlejer;
            Kunde = kunde;
            Bolig = bolig;
            FraDato = fraDato;
            TilDato = tilDato;
        }

        public override string ToString()
        {
            return string.Format(
                $"Booking Nr: {BookingNr}, Udlejer: {Udlejer}, Kunde: {Kunde}, Bolig: {Bolig}, Fra: {FraDato}, Til: {TilDato}");
        }

        public void OpretBooking()
        {
            //associate en ny booking med en bolig, bruger og måske ejer ?
        }
    }
}