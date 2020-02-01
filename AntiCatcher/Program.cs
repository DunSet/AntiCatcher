using AntiCatcher.UsrData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AntiCatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            UsrInfo usr1 = new UsrInfo();

            #region userInit
            usr1.FirstName = ("Andrey");
            usr1.LastName = ("Abramov");
            usr1.CarSign = ("а456кк777");
            /*if (Regex.IsMatch(inputNumber, "^[а-я]\\d{3}[а-я]{3}\\d{3}$"))
                usr1.CarSign = inputNumber;
            else
                Console.WriteLine($"'{inputNumber}' is not a car sign.")*/ //ввод номера по шаблону
            usr1.PhoneNumber = ("+79314567432");
            #endregion

            List<UsrInfo> UsrBd = new List<UsrInfo>() { };

            UsrBd.Add(usr1);

            string comparison = Console.ReadLine();

            Logic.Compare comp1 = new Logic.Compare();

            comp1.CompareUsr(comparison, UsrBdы);

             
            
            Console.ReadLine();
            
        }
    }
}
