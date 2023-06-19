using Contratctprocess.Entities;

namespace Contratctprocess.Services
{
     class PaymentService
    {

        public int Number { get; set; }

        IServicePayment _servicePayment;

        public PaymentService(int number, IServicePayment servicePayment)
        {
            Number = number;
            _servicePayment = servicePayment;
        }

        public void Processpayment(Contract contract)
        {

            List<Installment> installments = _servicePayment.Payment(contract, Number);

            foreach (Installment installment in installments)
            {
                contract.AddInstallment(installment);
            }

        }
    }
}
