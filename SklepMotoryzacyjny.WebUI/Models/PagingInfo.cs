using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Model widoku nie wchodzi w skład modelu domeny. Jest to tylko klasa ułatwiająca przekazywanie danych
//pomiędzy kontrolerem i widokiem
namespace SklepMotoryzacyjny.WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}