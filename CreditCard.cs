
using static System.Console;
using System;

namespace HW_DelegatesAndDevelopments
{
    public class CreditCard
    {
        public string? cardNumber { get; set; }
        public string? FIO { get; set; }
        public string? validity { get; set; }
        public int? PIN { get; set; }
        public int? creditLimit { get; set; }
        public double? amontOfMoney { get; set; }

        public CreditCard(string? cardNumber, string? fIO, string? validity, int? pIN, int? creditLimit, int? amontOfMoney)
        {
            this.cardNumber = cardNumber;
            FIO = fIO;
            this.validity = validity;
            PIN = pIN;
            this.creditLimit = creditLimit;
            this.amontOfMoney = amontOfMoney;
        }

        public void WithdrawFunds()
        {
            double sum = 0;
            Write("Enter sum for withdraw funds:  ");
            sum = (float)Convert.ToDouble(ReadLine());
            if (IsUseCreditLimit())
            {
                WriteLine("Using a credit funds");
            }
            this.amontOfMoney -= sum;
        }
        public bool IsUseCreditLimit()
        {
            return this.creditLimit == this.amontOfMoney;
        }
        public void СrediFunds()
        {
            Write("Enter the amount to top up:  ");
            float sum = (float)Convert.ToDouble(ReadLine());
            this.amontOfMoney += sum;
        }
        public void ChangePin()
        {
            Write($"Enter new pin: ");
            int newPin = Convert.ToInt32(ReadLine());
            this.PIN = newPin;
        }

        public override string ToString()
        {
            return $"Card number -> {cardNumber}\n FIO -> {FIO}\n Card expiry date -> {validity}\n Amount of money -> {amontOfMoney}";

        }
    }
}
