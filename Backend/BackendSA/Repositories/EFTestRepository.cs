using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendSA.Models;

namespace BackendSA.Repositories
{
    public class EFTestRepository : ITestRepository
    {
        private readonly SmartAssistantContext _smartAssistantContext;

        public EFTestRepository(SmartAssistantContext smartAssistantContext)
        {
            _smartAssistantContext = smartAssistantContext;
        }
        public Test GetSingle(int id)
        {
            return _smartAssistantContext.Test.FirstOrDefault(x => x.Id == id);
        }
    }
}
