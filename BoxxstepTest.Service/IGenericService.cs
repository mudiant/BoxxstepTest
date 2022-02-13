using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxxstepTest.Service
{
    public interface IGenericService : IDisposable
    {        Task CompleteAsync();
    }
}
