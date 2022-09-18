using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class EFBaBsReconciliationDal :
        EfEntityRepositoryBase<BaBsReconciliation, ContextDb>, IBaBsReconciliationDal
    {
    }
}
