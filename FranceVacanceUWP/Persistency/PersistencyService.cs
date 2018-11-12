﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FranceVacanceUWP.Model;
using Newtonsoft.Json;

namespace FranceVacanceUWP.Persistency
{
    class PersistencyService
    {
        //TODO: locate/create storage folder
        //TODO: Await??!

        /// <summary>
        /// Konverterer listen af boliger til string via JsonConveter.
        /// Kalder asynkront Seralize på string variablen.
        /// </summary>
        /// <param name="b">Collection af Boliger</param>
        public static async void SaveBoligAsJsonAsync(ObservableCollection<Bolig> b)
        {
            string boliger = JsonConvert.SerializeObject(b);
            SeralizeBoligFileAsync(boliger, "Boliger");
        }

        /// <summary>
        /// Opretter liste af bolig objekter.
        /// Kalder asynkront Deserialize på lokal fil.
        /// Fylder listen med bolig objekter og returnerer listen
        /// </summary>
        /// <returns>Liste af bolig objekter</returns>
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

        /// <summary>
        /// Skriver string variablen til fil, opretter ny fil med fileName hvis den ikke eksisterer
        /// </summary>
        /// <param name="boligString">Liste af Boliger konverteret til string</param>
        /// <param name="fileName">Navnet på den lokale fil</param>
        public static async void SeralizeBoligFileAsync(string boligString, string fileName)
        {
            Windows.Storage.StorageFolder myStorageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

            Windows.Storage.StorageFile sampleFile = await myStorageFolder.CreateFileAsync(
                fileName, Windows.Storage.CreationCollisionOption.ReplaceExisting);

            await Windows.Storage.FileIO.WriteTextAsync(sampleFile, boligString);
        }

        /// <summary>
        /// Læser værdier fra fil, returnerer værdier som string.
        /// </summary>
        /// <param name="fileName">Navnet på den lokale fil</param>
        /// <returns></returns>
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
