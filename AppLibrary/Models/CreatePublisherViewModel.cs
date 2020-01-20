using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class CreatePublisherViewModel
    {
        public Publisher Publisher { get; set; }
        public string Referer { get; set; }
    }
}
