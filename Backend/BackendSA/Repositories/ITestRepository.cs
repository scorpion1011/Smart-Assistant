using BackendSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendSA.Repositories
{
    public interface ITestRepository
    {
        Test GetSingle(int id);
    }
}
