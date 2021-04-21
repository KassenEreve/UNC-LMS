using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class Singleton
    {
        public List<Laboratory> laboratories { get; set; } //chache 

        private static Singleton instance;
        //singleton
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public List<Laboratory> GetCachedAllLaboratory() //cached to memory for faster performance
        {
            var memoryCache = MemoryCache.Default;

            if (!memoryCache.Contains("laboratories"))
            {
                var expiration = DateTimeOffset.UtcNow.AddMinutes(5);
                var labs = LaboratoryHelper.GetAllLaboratories();

                memoryCache.Add("laboratories", labs, expiration);
            }

            return (List<Laboratory>)memoryCache.Get("laboratories", null);  //return a reference of the object // modifying this reference will reflect on the cached object

        }
    }
}
