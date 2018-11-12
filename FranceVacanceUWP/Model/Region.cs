namespace FranceVacanceUWP.Model
{
    internal class Region
    {
        public string Seværdigheder { get; set; }
        public string Valuta { get; set; }
        public string Info { get; set; }

        public Region()
        {
        }

        public Region(string seværdigheder, string valuta, string info)
        {
            Seværdigheder = seværdigheder;
            Valuta = valuta;
            Info = info;
        }

        public override string ToString()
        {
            return string.Format(
                $"Seværdigheder: {Seværdigheder}, Valuta: {Valuta}, Info: {Info}");
        }
    }
}