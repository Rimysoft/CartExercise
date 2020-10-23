using System;
using System.Collections.Generic;
using System.Text;

namespace CartExercise.Model
{
    public class Cart
    {
        public List<CartProduct> CartProducts { get; set; }

        public Cart()
        {
            CartProducts = new List<CartProduct>();
        }
    }
}
