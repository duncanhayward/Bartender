using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCBartender.Models
{
    public class Drink_Menu : ApiController
    {
        
        public enum DrinkName
        {
            Beer, Vodka, Whiskey, Rum, Wine
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrinkID { set; get; }
        public DrinkName Cocktail{ set; get; }

        public virtual ICollection<DrinkName> Cocktails { get; set; }
    }
}