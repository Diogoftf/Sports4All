﻿namespace Sports4All
{
    public class Address
    {
        public int AddressId { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public virtual Park Park { get; set; }
        public County County { get; set; }
        public int CountyId { get; set; }

    }
}
