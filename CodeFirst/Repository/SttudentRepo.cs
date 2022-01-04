using CodeFirst.Data;
using CodeFirst.Interface;
using CodeFirst.Models;
using System;
using System.Linq;

namespace CodeFirst.Repository
{
    public class SttudentRepo : IStudent, IGeneric <Student>
    {
        private readonly ApplicationDBContext _applicationDBContext;
        public SttudentRepo(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;   
        }
        public void Add(Student item)
        {
            _applicationDBContext.Students.Add(item);
        }

        public int Count()
        {
            return _applicationDBContext.Students.ToList().Count();
        }

        public void Dispose()
        {
            _applicationDBContext?.Dispose();
            GC.SuppressFinalize(_applicationDBContext);
        }

        public void Remove(Student item)
        {
            _applicationDBContext.Students.Remove(item);
        }

        public object Remove(int? id)
        {
            throw new NotImplementedException();
        }

        public void Result(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
