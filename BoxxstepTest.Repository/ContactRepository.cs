using BoxxstepTest.Repository.Data;
using BoxxstepTest.Repository.Data.Models;
using BoxxstepTest.Repository.IRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxxstepTest.Repository
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(AppDbContext context) : base(context)
        {

        }

        public override async Task Upsert(Contact enity)
        {
            var contact = await dbSet.Where(x => x.Id == enity.Id).FirstOrDefaultAsync();
            if (contact == null) await Add(enity);
            else
            {
                contact.FirstName = enity.FirstName;
                contact.LastName = enity.LastName;
                contact.Relations = enity.Relations;
            }
        }
        public async Task<Contact> UpdateRelation(long contactId, long parentId)
        {
            var contact = await dbSet.Where(x => x.Id == contactId).FirstOrDefaultAsync();
            if (contact != null)
            {
                List<long> currentRelations = contact.Relations.Split(',').Select(long.Parse).ToList();
                currentRelations.Add(parentId);
                contact.Relations = string.Join(",", currentRelations.Select(n => n.ToString()).ToArray());
            }
            return contact;
        }
    }
}
