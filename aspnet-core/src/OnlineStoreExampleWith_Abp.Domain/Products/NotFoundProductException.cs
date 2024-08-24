using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace OnlineStoreExampleWith_Abp.Products
{
    public class NotFoundProductException : BusinessException
    {
        public NotFoundProductException(int id) : base(OnlineStoreExampleWith_AbpDomainErrorCodes.Product_Not_Found)
        {
            WithData("id", id);
        }
    }
}
