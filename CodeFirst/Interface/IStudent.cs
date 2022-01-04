using CodeFirst.Models;

namespace CodeFirst.Interface
{
    public interface IStudent:IGeneric<Student>
    {
        void Result(int id);
        object Remove(int? id);
    }
}
