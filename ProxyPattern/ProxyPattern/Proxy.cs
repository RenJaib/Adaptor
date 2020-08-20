using ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Proxy:IListingData
    {
        private RealObject _realObject;

        public Proxy(RealObject realObject)
        {
            _realObject = realObject;
        }

        public string ListingAddress()
        {
            var agency = "Barfoot Listing";
            var realObject = _realObject.ListingAddress();

            return agency + ":"+ realObject;
        }
    }
}
