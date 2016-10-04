using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test1MVC.Models;

namespace Test1MVC.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}