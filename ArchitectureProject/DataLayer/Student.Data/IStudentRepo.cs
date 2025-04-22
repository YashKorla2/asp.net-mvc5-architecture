using DataLayer.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Student.Data
{
    public interface IStudentRepo : IRepository<global::DB.Core.Student>
    {
    }
}