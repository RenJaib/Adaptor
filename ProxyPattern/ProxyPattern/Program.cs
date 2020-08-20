using ProxyPattern.Interfaces;
using System;

namespace ProxyPattern
{
    public class Listing
    {
        private IListingData _ilistingData;

        public Listing(IListingData listingData)
        {
            _ilistingData = listingData;
        }

        public void GetListingNumber()
        {
            Console.WriteLine(_ilistingData.ListingAddress());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var listing = new Listing(new Proxy(new RealObject()));

            listing.GetListingNumber();
        }
    }
}
