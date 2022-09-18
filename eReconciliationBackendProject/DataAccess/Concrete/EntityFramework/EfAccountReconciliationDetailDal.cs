using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAccountReconciliationDetailDal :
        EfEntityRepositoryBase<AccountReconciliationDetail, ContextDb>,
        IAccountReconciliationDetailDal
    {
            
    }
}
