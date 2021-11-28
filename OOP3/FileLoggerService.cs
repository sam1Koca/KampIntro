using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService 
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}

// İnterface içinde sadece İmza metotları olur. İçi dolu olamaz