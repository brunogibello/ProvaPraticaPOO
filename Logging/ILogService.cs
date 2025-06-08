namespace ProvaPraticaPOO.Logging
{
    public interface ILogService
    {
        void LogInfo(string mensagem);
        void LogErro(string mensagem);
    }
}