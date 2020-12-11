using System;

namespace TodoList.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public Guid UsedGuid { get; set; }
    }
}