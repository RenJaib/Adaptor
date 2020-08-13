using HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HomeWork
{
    public class Listing
    {
        private IListing _listing;

        public Listing(IListing listing)
        {
            _listing = listing;
        }

        public void GetListingDetails()
        {
            Console.WriteLine($"listingNumber = {_listing.ReturnListingNumber()}");
            Console.WriteLine($"ListingAddress = {_listing.ReturnAddress()}");
            Console.WriteLine($"listingRegion = {_listing.ReturnRegion()}");
        }

    }
}
