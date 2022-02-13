using BoxxstepTest.Repository.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxxstepTest.Repository.IRepo
{
    public interface IContactRepository : IGenericRepository<Contact>
    {
        Task<Contact> UpdateRelation(long contactId, long parentId);
    }
}
