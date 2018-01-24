using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLabDll
{
    public class Book
    {

        private string _id;
        private string _name;
        private string _owner;
        private string _publisher;

        public Book(string id, string name, string owner, string publisher)
        {
            _id = id;
            _name = name;
            _owner = owner;
            _publisher = publisher;

        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Owner { get => _owner; set => _owner = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }

        public override string ToString()
        {
            return String.Format("|{0,5}|{1,5}|{2,5}|{3,5}|", this.Id, this.Name, this.Owner, this.Publisher); 
        }

    }
}
