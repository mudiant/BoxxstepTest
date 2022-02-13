using BoxxstepTest.Repository;
using BoxxstepTest.Repository.Data;
using BoxxstepTest.Repository.Data.Models;
using BoxxstepTest.Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxxstepTest.Service
{
    public class ContactService : IContactService
    {
        private readonly AppDbContext _context;
        public IContactRepository contactRepository { get; private set; }
        //public IRelationRepository relationRepository { get; private set; }
        public ContactService(AppDbContext context)
        {
            _context = context;
            contactRepository = new ContactRepository(_context);
            //relationRepository = new RelationRepository(_context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<IList<Contact>> GetContactList()
        {
            return await contactRepository.GetList();
        }
        public async Task SaveContact(Contact contact)
        {
            await contactRepository.Upsert(contact);
        }
        public void DeleteContact(long id)
        {
            contactRepository.Delete(id);
        }
        public async Task<Contact> UpdateRelation(long contactId, long parentId)
        {
            return await contactRepository.UpdateRelation(contactId, parentId);
        }
    }

}
