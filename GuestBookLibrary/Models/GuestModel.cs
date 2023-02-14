using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Models
{
    public class GuestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _lengthOfStayInDays;
        public int LengthOfStayInDays
        {
            get
            {
                if (_lengthOfStayInDays >= 0 && _lengthOfStayInDays < 91)
                {
                    return _lengthOfStayInDays;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Out of range for length of stay.");
                }
               ;
            }
            set
            {
                _lengthOfStayInDays = value;
            }
        }


        public string GuestInfo
        {
            get { return $"{FirstName} {LastName}: Staying for {LengthOfStayInDays} days."; }
        }


    }
}