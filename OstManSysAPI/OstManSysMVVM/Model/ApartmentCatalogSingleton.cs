﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OstManSysMVVM.Persistency;

namespace OstManSysMVVM.Model
{
    public class ApartmentCatalogSingleton
    {
        private static ApartmentCatalogSingleton _instance = null;

        //public ApartmentCatalogSingleton GetInstance()
        //{
        //    if (_instance==null)
        //    {
        //        _instance = new ApartmentCatalogSingleton();
        //    }
        //    return _instance;
        //}
        public static ApartmentCatalogSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ApartmentCatalogSingleton();
                }
                return _instance;
            }
        }

        public ObservableCollection<Apartment> Apartments { get; set; }
        private ApartmentCatalogSingleton()
        {
            Apartments=new ObservableCollection<Apartment>(new PersistencyFacade().GetApartments());
        }
    }
}
