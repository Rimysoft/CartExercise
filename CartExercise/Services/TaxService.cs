using CartExercise.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CartExercise.Services
{
    public class TaxService
    {

        public List<Tax> TaxesRepository;

        public void Init()
        {
            var taxesRepoJson = File.ReadAllText("Assets/TaxesRepository.json");
            TaxesRepository = JsonConvert.DeserializeObject<List<Tax>>(taxesRepoJson);
        }

        public List<Tax> GetTaxByProductType(ProductType pt, bool isImportedProduct)
        {
            var ret = new List<Tax>();
            if(pt == ProductType.Other)
            {
                ret.Add(TaxesRepository.Where(x => x.Type == TaxType.Basic).FirstOrDefault());
            }
            if (isImportedProduct)
            {
                ret.Add(TaxesRepository.Where(x => x.Type == TaxType.ImportDuty).FirstOrDefault());
            }
            //
            return ret;
        }



    }
}
