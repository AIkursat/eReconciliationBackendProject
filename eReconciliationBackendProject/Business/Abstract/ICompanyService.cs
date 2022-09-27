using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IResult Add(Company company);
        IDataResult<List<Company>> GetList();
        IResult CompanyExist(Company company);
        IResult UserCompanyAdd(int userId, int companyId);
    }
}
