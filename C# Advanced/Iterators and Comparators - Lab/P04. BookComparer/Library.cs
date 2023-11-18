using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    internal class Library : IEnumerable<Book>
    {
        private List<Book> _books;
        public Library(params Book[] books)
        {
            _books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(_books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book>
        {
            private int _index = -1;
            private List<Book> books;
            public LibraryIterator(IEnumerable<Book> books)
            {
                this.books = books.ToList();
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
