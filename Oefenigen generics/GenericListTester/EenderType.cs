using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListTester
{
    class EenderType<T>
    {
        public EenderType()
        {
            lijst = new List<T>();
        }
        public List<T> lijst;
        public void Add(T newItem)
        {
            lijst.Add(newItem);
        }
        public int Count()
        {
            return lijst.Count();
        }
        public void Remove(T toRemoveItem)
        {
            lijst.Remove(toRemoveItem);
        }
    }
}
