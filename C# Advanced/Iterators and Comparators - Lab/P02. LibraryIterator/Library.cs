using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book>
        {
            private int _index = -1;
            private List<Book> books;
            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }
            public Book Current => this.books[_index];

            object IEnumerator.Current => Current;

            public void Dispose() { }
            public bool MoveNext()
            {
                _index++;
                return _index < this.books.Count;
            }

            public void Reset()
            {
                _index = -1;
            }
        }
    }
}
