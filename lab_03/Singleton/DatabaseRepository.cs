using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class DatabaseRepository
    {
        private static DatabaseRepository? _instance;
        private static object _lockRef = new Object();
        private DatabaseRepository()
        {
            Console.WriteLine("Initializing DatabaseRepository");
        }
        public static DatabaseRepository GetInstance()
        {
            if (DatabaseRepository._instance == null)
            {
                lock (_lockRef)
                {
                    if (DatabaseRepository._instance == null)
                    {
                        DatabaseRepository._instance = new DatabaseRepository();
                    }
                }
            }
            return _instance;
        }
    }
}
