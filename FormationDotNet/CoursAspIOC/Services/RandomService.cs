namespace CoursAspIOC.Services
{
    public class RandomService
    {
        private string val;
        public RandomService()
        {
            val = Guid.NewGuid().ToString();
        }
        public string GetRandom()
        {
            return val;
        }
    }
}
