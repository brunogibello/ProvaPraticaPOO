namespace ProvaPraticaPOO.Services.Descontos
{
    using ProvaPraticaPOO.Classes;

    public interface IDescontoStrategy
    {
        decimal CalcularDesconto(Pedido pedido);
    }
}