namespace LAFitnessWeb.Client.Shared.AuthComponent.Register
{
    public partial class Register
    {
        root.Shared.UserRegister user = new root.Shared.UserRegister();

        [Inject] protected NavigationManager NavManager { get; set; }

        public void HandleRegister()
        {
            System.Console.WriteLine($"Adding user to database");
            NavManager.NavigateTo("page/login");
        }
    }
}