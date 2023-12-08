namespace SeidorApi.Core.InputModel;

public class LoginInputModel
{
    public LoginInputModel(string nome, string senha, string email)
    {
        Nome = nome;
        Senha = senha;
        Email = email;
    }

    public int Id { get; set; }

    public string Nome { get; set; }

    public string Senha { get; set; }

    public string Email { get; set; }
}
