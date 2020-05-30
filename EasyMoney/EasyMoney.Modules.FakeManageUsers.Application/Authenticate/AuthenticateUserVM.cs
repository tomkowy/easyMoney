namespace EasyMoney.Modules.FakeManageUsers.Application.Authenticate
{
    public class AuthenticateUserVM
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public AuthenticateUserVM(string name, string email, string token)
        {
            Name = name;
            Email = email;
            Token = token;
        }
    }
}
