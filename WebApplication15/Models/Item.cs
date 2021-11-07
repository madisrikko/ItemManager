using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication15.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        
        public string ProfilePicture { get; set; }
        public Item()
        {

        }

    }
}
