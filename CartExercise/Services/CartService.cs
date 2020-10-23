using CartExercise.Model;
using CartExercise.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CartExercise.Services
{
    public class CartService
    {
        private Cart storeCart { get; set; }
        private TaxService taxService { get; set; }
        
        public CartService()
        {
            taxService = new TaxService();
            taxService.Init();
            
        }

        public void InitCart()
        {
            storeCart = new Cart();
        }

        public void AddProductToCart(CartProduct cp)
        {
            storeCart.CartProducts.Add(cp);
        }

        public List<string> GetCartProducts()
        {
            if(storeCart != null && storeCart.CartProducts != null)
            {
                return storeCart.CartProducts.Select(cp => cp.GetStringProductInfo).ToList();
            }
            //
            return new List<string>();
        }

        public List<string> GetCartSummary()
        {
            var ret = new List<string>();
            //
            ret.AddRange(GetCartProductsSummary());
            ret.Add(GetTaxSummary());
            ret.Add(GetTotalSummary());
            //
            return ret;
        }

        #region Utility Methods

        private double CalcTotalPrice()
        {
            return storeCart.CartProducts.Sum(p => p.Quantity * p.Product.Price.Value) + CalcTotalTaxes();
        }

        private double CalcTotalTaxes()
        {
            return storeCart.CartProducts.Sum(p => CalcTaxValueByProduct(p));
        }
        
        private double CalcTaxValueByProduct(CartProduct cp)
        {
            var taxesByProduct = taxService.GetTaxByProductType(cp.Product.Type, cp.Product.Imported);
            if(taxesByProduct != null)
            {
                return Helpers.Round(taxesByProduct.Sum(t => Helpers.Round(t.GetPercentageValue * cp.Product.Price.Value * cp.Quantity)));
            }
            //
            return 0;
        }

        private List<string> GetCartProductsSummary()
        {
            return storeCart.CartProducts.Select(p => p.Quantity.ToString() + " " + p.Product.Name + ": " + new PriceInfo(p.Product.Price.Value + CalcTaxValueByProduct(p)).GetFormattedStringValue).ToList();
        }

        private string GetTaxSummary()
        {
            return "Sales Taxes: " + new PriceInfo(CalcTotalTaxes()).GetFormattedStringValue;
        }

        private string GetTotalSummary()
        {
            return "Total: " + new PriceInfo(CalcTotalPrice()).GetFormattedStringValue;
        }

        #endregion

    }
}
