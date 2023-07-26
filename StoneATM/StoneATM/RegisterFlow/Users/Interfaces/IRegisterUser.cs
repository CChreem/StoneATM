namespace StoneATM.Users.Interfaces
{
    public interface IRegisterUser
    {
        string SetName(string name);
        string SetCPF(string cpf);
        string SetPassword();
    }
}
