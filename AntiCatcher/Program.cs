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
            UsrData.UsrInfo usr1 = new UsrData.UsrInfo();

            #region userInit
            usr1.FirstName = ("Andrey");
            usr1.LastName = ("Abramov");
            usr1.CarSign = ("а456кк777");
            usr1.PhoneNumber = ("+79314567432");
            #endregion

            List<UsrData.UsrInfo> UsrBd = new List<UsrData.UsrInfo>() { };

            UsrBd.Add(usr1);

            string comparison = Console.ReadLine();

            Logic.Compare comp1 = new Logic.Compare();

            comp1.CompareUsr(comparison, UsrBd);

            
            Console.ReadLine();
            
        }
    }
}
