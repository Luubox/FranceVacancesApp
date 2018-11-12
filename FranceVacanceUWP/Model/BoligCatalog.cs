using System.Collections.ObjectModel;
using FranceVacanceUWP.Persistency;

namespace FranceVacanceUWP.Model
{
    class BoligCatalog : PersistencyService
    {
        private BoligCatalog _instance = new BoligCatalog();

        public BoligCatalog Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Bolig> BoligListe { get; set; }

        private BoligCatalog()
        {
            //todo: get items from file
            BoligListe = new ObservableCollection<Bolig>(LoadBoligFromJsonAsync().Result);

            if (Bolig.Count == 0)
            {
                //Item item1 = new Item("978 - 1 - 4302 - 4233 - 8", "Pro C# 5.0 and the .NET 4.5 Framework", "Andrew Troelsen", 28);
                //Item item2 = new Item("0 - 13 - 148906 - 2", "Applying UML and Patterns", "Craig Larman", 28);
                //Items.Add(item1);
                //Items.Add(item2);

                //saves items to file
                SaveBoligAsJsonAsync(BoligListe);
            }
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