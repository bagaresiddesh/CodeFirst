using System;

namespace CodeFirst.Interface
{
    public interface IGeneric <T>: IDisposable where T : class
    {
        void Add(T item);
        void Remove(T item);
        int Count();
    }
}
