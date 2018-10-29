using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace MakingLinqEasyTheBestOnLinq
{
    public class CarBrand : IDisposable
    {
        private List<CarBrand> _CarBrand;
        public CarBrand()
        {
            _CarBrand = new List<CarBrand>();

        }

        public List<CarBrand> GetAll()
        {
            _CarBrand.Clear();
            _CarBrand.Add(new CarBrand() { HostCountry = "Germany", Name = "Volvo" });
            _CarBrand.Add(new CarBrand() { HostCountry = "Germany", Name = "BMW" });
            _CarBrand.Add(new CarBrand() { HostCountry = "Germany", Name = "Volkswagem" });
            _CarBrand.Add(new CarBrand() { HostCountry = "USA", Name = "Ford" });
            _CarBrand.Add(new CarBrand() { HostCountry = "USA", Name = "Dodge" });
            _CarBrand.Add(new CarBrand() { HostCountry = "France", Name = "Citroen" });
            _CarBrand.Add(new CarBrand() { HostCountry = "France", Name = "Peugeot" });
            _CarBrand.Add(new CarBrand() { HostCountry = "USA", Name = "GM" });

            return _CarBrand;
        }

        /// <summary>
        /// return a List containing countries 
        /// </summary>
        /// <returns></returns>
        public List<string> GetCountries()
        {

            var result = from y in GetAll()
                         orderby y.HostCountry
                         group y by new { y.HostCountry }
                         into grp_result
                         select new { grp_result.Key.HostCountry };

            return result.Select(o => o.HostCountry).ToList(); ;
        }

        public string[,] GetDictionaryCountries()
        {
            var result = new string[GetAll().Count, 2];
            int i = 0;
            foreach (CarBrand cb in GetAll())
            {
                result[i, 0] = cb.HostCountry;
                result[i, 1] = cb.Name;
                i++;
            }

            return result;
        }

        bool disposed;

        /// <summary>
        /// Disposing instantiated objects
        /// </summary>
        /// <param name="disposing">True if the class is being dispose</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _CarBrand = null;
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string HostCountry { get; set; }

        public string Name { get; set; }
    }
}
