using Entities.Concrete;
using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFAccountReconciliationDal : EfEntityRepositoryBase<AccountReconciliations,
        ContextDb>, IAccountReconciliationsDal
    {
    }
}
