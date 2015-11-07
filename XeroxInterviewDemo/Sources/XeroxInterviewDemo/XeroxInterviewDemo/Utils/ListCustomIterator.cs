using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XeroxInterviewDemo.Utils
{
    public class ListCustomIterator<T>
        where T : ICollection<T>
    {
        private ICollection<T> _collection;
        private int _perPage;

        public ListCustomIterator(T collection, int perPage)
        {
            _collection = collection;
            _perPage = perPage;
        }




    }
}