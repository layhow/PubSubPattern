using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubPattern.Concrete
{
    public class User
    {
        /// <summary>
        /// Simple class to store the user input
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="nationality">nationality</param>
        public User(string name, string nationality)
        {
            this.Name = name;
            this.Nationality = nationality;
        }
        public string Name { get; set; }
        public string Nationality { get; set; }
    }
}
