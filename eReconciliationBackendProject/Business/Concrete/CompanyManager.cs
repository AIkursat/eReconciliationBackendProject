 using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company company)
        {
            if (company.Name.Length > 10)
            {
                _companyDal.Add(company);
                return new SuccessResult(Messages.AddedCompany);
            }
            return new ErrorResult("Şirket adı en az 10 karakter olmalıdır.");
        }

        public IResult CompanyExist(Company company)
        {
            var result = _companyDal.Get(c=> c.Name == company.Name && c.TaxDepartment == company.TaxDepartment && c.TaxIdNumber == c.TaxIdNumber
            && c.IdentityNumber == company.IdentityNumber);
            if (result!=null)
            {
                return new ErrorResult(Messages.CompanyAlreadtExists);
            }
            return new SuccessResult();
        }

        // Dependency Injection
        // User Authorization
        // Transaction
        // Log
        // Validation

        public IDataResult<List<Company>> GetList()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetList());
        }   
    }
}
