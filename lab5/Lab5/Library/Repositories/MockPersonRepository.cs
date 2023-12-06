using Library.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class MockPersonRepository : IPersonRepository
    {
        private List<Person> data = new List<Person>;
        public void Create(Person item)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            return data;
        }

        public void Delete(int id)
        {
            data.RemoveAll(x => x.Id == id);
        }

        public IBookRepository Get(int id)
        {
            return data.Find(x => x.Id == id);
        }

        public void Update(Book item)
        {
            var index = data.FindIndex(x => x.Id == item.Id);

            if (index == -1)
            {
                data[index] = item;
            }
        }
    }
}
