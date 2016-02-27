using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColorScope
{
    public class ConsoleColorScope : IDisposable
    {
        private readonly ConsoleColor previousColor;

        public ConsoleColorScope(ConsoleColor color)
        {
            this.previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
        }

        public void Dispose()
        {
            Console.ForegroundColor = this.previousColor;
        }
    }
}
