using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}