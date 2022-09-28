using Business.Abstract;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MailManager : IMailService
    {
        public IResult SendMail(string mail, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
