using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class Message
    {
        //Id should be unique
        // should be positive
        public int Id { get; set; }

        //should not be empty
        //should not be null
        //should be from 1 to 20 characters length
        public string Text { get; set; }
        //should be correct Date
        //if it is empty is equals to current date
        public DateTime Date { get; set; }
    }
}
