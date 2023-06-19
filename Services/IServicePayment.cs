
using Contratctprocess.Entities;
namespace Contratctprocess.Services
{
     interface IServicePayment
    {
        public List<Installment> Payment(Contract contract, int number);

    }
}
