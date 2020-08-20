using ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class RealObject:IListingData
    {
        public string ListingAddress()
        {
            return "ListingNumber is 999999";
        }
    }
}
