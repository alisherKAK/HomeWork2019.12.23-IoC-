﻿using System.Collections.Generic;

namespace HomeWork2019._12._23_Ninject_.AbstractModels
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Delete(T item);
        void Delete(int id);
        void Update(T item);
        IEnumerable<T> GetAll();
    }
}
