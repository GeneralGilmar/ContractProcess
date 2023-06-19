using Contratctprocess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratctprocess.Services
{
    class PaypalPayment : IServicePayment
    {
        public List<Installment> Payment(Contract contract, int number)
        {
            List<Installment> list = new List<Installment>();
            DateTime date = contract.DateContract;
            double part = contract.TotalValue / number*1.0;
            double parcel;
            for(int i=1; i <= number; i++)
            {
                parcel = part + part * 0.01 * i;
                parcel += parcel*0.02;
                date=date.AddMonths(1);
                list.Add(new Installment(date, parcel));
            }
            return list;
        }
    }
}
