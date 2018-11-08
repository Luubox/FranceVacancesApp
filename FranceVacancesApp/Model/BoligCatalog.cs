using System.Collections.ObjectModel;

namespace FranceVacancesApp.Model
{
    internal class BoligCatalog
    {
        public static BoligCatalog Instance { get; } = new BoligCatalog();

        public ObservableCollection<Bolig> BoligListe { get; set; }

        private BoligCatalog()
        {
            BoligListe = new ObservableCollection<Bolig>();
            //todo: get data somewhere
        }

        public void Add(int antalPersoner, int antalSoveværelser, string type,
            int antalBadeværelser, int kvadratmeter, string adresse,
            double rating, bool husdyr, Udlejer owner)
        {
            BoligListe.Add(new Bolig(antalPersoner, antalSoveværelser, type,
                antalBadeværelser, kvadratmeter, adresse, rating, husdyr,
                owner));
        }
    }
}