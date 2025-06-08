using System;

namespace ProvaPraticaPOO.Logging
{
    public class ConsoleLogService : ILogService
    {
        public void LogInfo(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[INFO] {mensagem}");
            Console.ResetColor();
        }

        public void LogErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERRO] {mensagem}");
            Console.ResetColor();
        }
    }
}