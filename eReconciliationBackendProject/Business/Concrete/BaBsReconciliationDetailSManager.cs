using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaBsReconciliationDetailSManager : IBaBsReconciliationDetailService
    {
        private readonly IBaBsReconciliationDal _baBsReconciliationDal;

        public BaBsReconciliationDetailSManager(IBaBsReconciliationDal baBsReconciliationDal)
        {
            _baBsReconciliationDal = baBsReconciliationDal;
        }
    }
}
