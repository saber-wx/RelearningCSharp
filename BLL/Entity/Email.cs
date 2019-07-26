using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Email:Entity
    {
        public Email()
        {

        }
        public int Id { get; set; }
        public string Address { get; set; }
        public string ValidationCode { get; set; }
        public DateTime? HasValidated { get; set; }

        public int OwerId { get; set; }
        public User Ower { get; set; }

    }
}
