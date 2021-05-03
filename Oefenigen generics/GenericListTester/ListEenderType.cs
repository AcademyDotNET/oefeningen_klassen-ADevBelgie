using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListTester
{
    class ListEenderType<T>
    {
        public ListEenderType()
        {
            Lijst = new List<T>();
        }
        public List<T> Lijst { get; set; }
        public void Add(T newItem)
        {
            Lijst.Add(newItem);
        }
        public int Count()
        {
            return Lijst.Count();
        }
        public void Remove(T toRemoveItem)
        {
            Lijst.Remove(toRemoveItem);
        }
        public override string ToString()
        {
            string totalstring = "";
            foreach (var item in Lijst)
            {
                totalstring += $"{item.ToString()}\n";
            }
            return totalstring;
        }
    }
}
