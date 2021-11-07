using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication15.ViewModels
{
    public class ItemView
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public IFormFile ProfileImage { get; set; }

    }
}
