using lab_02.Classes.Currency;
using lab_02.ExtensionMethods;
using lab_02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02.Classes
{
    public class CurrencyConverter : ICurrencyConverter
    {
        public ICurrency Convert<T>(ICurrency convertibleCurrency)
            where T : ICurrency, new()
        {
            ICurrency convertedCurrency = new T();
            double convertible = convertibleCurrency.Cash + convertedCurrency.Coins * Math.Pow(10, convertedCurrency.Coins.NumberCount());
            double dollarValue = convertible / convertibleCurrency.DollarCoefficient;
            double resValue = dollarValue * convertedCurrency.DollarCoefficient;
            int resCash = (int)resValue;
            double tmpCoins = Math.Round(resValue%1, 2);
            int resCoins = (int)(tmpCoins * Math.Pow(10, tmpCoins.ToString().Length));
            convertedCurrency.Cash = resCash;
            convertedCurrency.Coins = resCoins;
            return convertedCurrency;
        }
    }
}
