using CleanArchitecture.Application;
using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Persistance
{
    public class DealerRepository : IRepository<Dealer>
    {
        public IEnumerable<Dealer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dealer GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}