using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
{
        private List<T> data;
        public Box()
        {
             Data = new List<T>();
        }

        public int Count =>  Data.Count;
        public List<T> Data { get; set; }

        public void Add(T element)
        {
            Data.Add(element);
        }
        public  T Remove()
        {
            var rem = Data.Last();
            Data.RemoveAt(Data.Count - 1);
            return rem;
            
        }

}
}
