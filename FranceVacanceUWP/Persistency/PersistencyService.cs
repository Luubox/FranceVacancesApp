using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FranceVacancesApp.Model;
using Newtonsoft.Json;

namespace FranceVacanceUWP.Persistency
{
    class PersistencyService
    {
        //TODO: locate/create storage folder

        public static async void SaveBoligAsJsonAsync(ObservableCollection<Bolig> b)
        {
            string boliger = JsonConvert.SerializeObject(b);
            SeralizeBoligFileAsync(boliger, "Boliger");
        }

        public static async Task<List<Bolig>> LoadBoligFromJsonAsync()
        {
            List<Bolig> boliger = new List<Bolig>();

            string result = await DeSerializeBoligFileAsync("Boliger");

            if (!String.IsNullOrWhiteSpace(result))
            {
                boliger = JsonConvert.DeserializeObject<List<Bolig>>(result);
            }
            return boliger;
        }

        public static async void SeralizeBoligFileAsync(string boligString, string fileName)
        {
            Windows.Storage.StorageFolder myStorageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

            Windows.Storage.StorageFile sampleFile = await myStorageFolder.CreateFileAsync(fileName, Windows.Storage.CreationCollisionOption.ReplaceExisting);

            await Windows.Storage.FileIO.WriteTextAsync(sampleFile, boligString);
        }

        public static async Task<string> DeSerializeBoligFileAsync(String fileName)
        {
            string fileString = null;

            Windows.Storage.StorageFolder myStorageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

            if (await myStorageFolder.TryGetItemAsync(fileName) != null)
            {
                Windows.Storage.StorageFile myStorageFile = await myStorageFolder.GetFileAsync(fileName);
                fileString = await Windows.Storage.FileIO.ReadTextAsync(myStorageFile);
            }
            return fileString;
        }
    }
}
