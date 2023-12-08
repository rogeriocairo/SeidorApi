namespace SeidorApi.Core.InputModel;

public class LoginInputModel
{
    public LoginInputModel(string email, string senha)
    {        
        Senha = senha;
        Email = email;
    }  

    public string Senha { get; set; }

    public string Email { get; set; }
}
