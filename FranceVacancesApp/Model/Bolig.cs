using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesApp.Model
{
    
    class Bolig
    {
        private int _antalPersoner;
        private int _antalSoveværelser;
        private String _type;
        private int _antalBadeværelser;
        private int _kvadratmeter;
        private String _adresse;
        private double _rating;
        private bool _husdyr;
        private Udlejer _owner;

        public Bolig(int antalPersoner, int antalSoveværelser, string type, int antalBadeværelser, int kvadratmeter, string adresse, double rating, bool husdyr, Udlejer owner)
        {
            _antalPersoner = antalPersoner;
            _antalSoveværelser = antalSoveværelser;
            _type = type;
            _antalBadeværelser = antalBadeværelser;
            _kvadratmeter = kvadratmeter;
            _adresse = adresse;
            _rating = rating;
            _husdyr = husdyr;
            _owner = owner;
        }

        public void checkAvailability()
        {
            // Tjek ledighed
        }

        public void createReservation()
        {
            // Opret reservation
        }

        public void editReservation()
        {
            //redigering af reservation: Slette, forlænge/forkorte reservationen
        }
    }
    
}
