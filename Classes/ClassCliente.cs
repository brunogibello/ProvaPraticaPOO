public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }

    public Cliente(int id, string nome, string email, string cpf)
    {
        Id = id;
        Nome = nome;
        Email = email;
        CPF = cpf;
    }
}
