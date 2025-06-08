public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }

    public Cliente(int id, string nome, string email, string cpf)
    {

        if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do cliente é obrigatório.");

        if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email é obrigatório.");

        if (string.IsNullOrWhiteSpace(cpf))
                throw new ArgumentException("CPF é obrigatório.");

        Id = id;
        Nome = nome;
        Email = email;
        CPF = cpf;
    }
}
