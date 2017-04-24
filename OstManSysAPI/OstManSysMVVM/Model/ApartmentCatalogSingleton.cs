using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OstManSysMVVM.Persistency;

namespace OstManSysMVVM.Model
{
    class ApartmentCatalogSingleton
    {
        private static ApartmentCatalogSingleton _instance = new ApartmentCatalogSingleton();

        public static ApartmentCatalogSingleton Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Apartment> Apartments { get; set; }
        private ApartmentCatalogSingleton()
        {
            Apartments=new ObservableCollection<Apartment>(new PersistencyFacade().GetApartments());
        }
    }
}
