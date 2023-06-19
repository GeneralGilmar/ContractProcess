using Contratctprocess.Entities;
using Contratctprocess.Services;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int idContract=int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime date =DateTime.Parse(Console.ReadLine());

Console.Write("Contract value: ");
double totalValue= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Contract contract= new Contract(idContract,date,totalValue);
Console.Write("Enter number of installments: ");
int  number= int.Parse(Console.ReadLine());

PaymentService paymentService = new PaymentService(number, new PaypalPayment());

paymentService.Processpayment(contract);

Console.WriteLine(contract);