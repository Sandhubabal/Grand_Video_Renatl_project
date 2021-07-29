using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Video_Renatl_project
{
    class DatabaseFields
    {

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Ratting { get; set; }
        public string Year { get; set; }
        public string Copies { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Cost { get; set; }


        public int RentalId { get; set; }
        public string IssueDate { get; set; }
        public string ReturnDate { get; set; }

        public int Option { get; set; }

    }
}
