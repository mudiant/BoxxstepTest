using BoxxstepTest.Repository.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxxstepTest.Service
{
    public interface IContactService : IGenericService
    {
        Task<IList<Contact>> GetContactList();
        Task SaveContact(Contact contact);
        void DeleteContact(long id);
        Task<Contact> UpdateRelation(long contactId, long parentId);
    }
}
