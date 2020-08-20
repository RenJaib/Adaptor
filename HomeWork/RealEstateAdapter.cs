using HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class RealEstateAdapter:IListingData
    {
        private RealEstateListing _realEstateListing;

        public RealEstateAdapter(RealEstateListing realEstateListing)
        {
            _realEstateListing = realEstateListing;
        }
        
        public string ReturnListingNumber()
        {
            return _realEstateListing.ListingId.ToString();
        }

        public string ReturnAddress()
        {
            return _realEstateListing.AddressNumberStreet +" " + _realEstateListing.Suburub;
        }

        public string ReturnRegion()
        {
            return _realEstateListing.Region;
        }
    }
}
