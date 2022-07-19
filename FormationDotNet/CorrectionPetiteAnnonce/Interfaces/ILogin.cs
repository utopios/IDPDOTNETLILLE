namespace CorrectionPetiteAnnonce.Interfaces
{
    public interface ILogin
    {
        public bool Login(string username, string password);

        public bool IsLogged();
    }
}
