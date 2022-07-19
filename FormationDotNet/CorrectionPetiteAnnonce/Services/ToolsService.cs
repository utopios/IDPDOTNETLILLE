namespace CorrectionPetiteAnnonce.Services
{
    public class ToolsService
    {
        public string Substruction(string chaine, int nb)
        {
            return chaine.Substring(0, nb);
        }
    }
}
