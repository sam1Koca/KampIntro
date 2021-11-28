using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService // Sen aslında bir ILoggerService Alternatifisin.
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}

// İnterface içinde sadece İmza metotları olur. İçi dolu olamaz

// kısayol : aynı classı kopyala *farklı İsim - Ampul - Move type to ...cs - tıkla solutionda yeni class oluştursun ve ona atsın.