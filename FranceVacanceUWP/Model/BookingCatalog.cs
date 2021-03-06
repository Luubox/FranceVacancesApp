﻿using System;
using System.Collections.ObjectModel;

namespace FranceVacanceUWP.Model
{
    class BookingCatalog
    {
        private static BookingCatalog _instance = new BookingCatalog();
        public static BookingCatalog Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Booking> BookingList { get; set; }

        public BookingCatalog()
        {
            BookingList = new ObservableCollection<Booking>();
            //TODO: get from somewhere?
        }

        public void Add(int bookingNr, Udlejer udlejer, Lejer kunde, Bolig bolig,
            DateTime fraDato, DateTime tilDato)
        {
            BookingList.Add(new Booking(bookingNr, udlejer, kunde, bolig, fraDato, tilDato));
        }
    }
}
