namespace EasyMoney.Modules.FakeManageUsers.Application.GetUser
{
    public class GetUserQueryVM
    {
        public string Email { get; private set; }
        public bool Active { get; private set; }

        public GetUserQueryVM(string email, bool active)
        {
            Email = email;
            Active = active;
        }
    }
}
