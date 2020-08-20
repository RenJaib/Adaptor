using System;

namespace HomeWork
{
    
    class Program
    {
        static void Main(string[] args)
        {
            RealEstateListing realEstate = new RealEstateListing()
            {
                ListingId = 32481,
                AddressNumberStreet = "128 Shortland Street",
                Suburub = "City Center",
                Region = "Auckland City"
            };

            var listing = new Listing(new RealEstateAdapter(realEstate));

            listing.GetListingDetails();

        }
    }
}
