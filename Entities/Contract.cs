using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratctprocess.Entities
{
    class Contract
    {

        public int NumberContract { get; set; }
        public DateTime DateContract { get; set; }
        public Double TotalValue { get; set; }

        List<Installment> Installments { get; set; }=new List<Installment>();

        public Contract(int numberContract, DateTime dateContract, double totalValue)
        {
            NumberContract = numberContract;
            DateContract = dateContract;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Installment installment in Installments)
            {
                sb.AppendLine(installment.ToString());
                
            }
            return sb.ToString();
        }
    }
}
