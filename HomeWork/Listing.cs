using HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HomeWork
{
    public class Listing
    {
        private IListingData _listingData;

        public Listing(IListingData listing)
        {
            _listingData = listing;
        }

        public void GetListingDetails()
        {
            Console.WriteLine($"listingNumber = {_listingData.ReturnListingNumber()}");
            Console.WriteLine($"ListingAddress = {_listingData.ReturnAddress()}");
            Console.WriteLine($"listingRegion = {_listingData.ReturnRegion()}");
        }

    }
}
