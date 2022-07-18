namespace CoursAspIOC.Services
{
    public class ServiceB
    {
        private RandomService _randomService;

        public ServiceB(RandomService randomService)
        {
            _randomService = randomService;
        }

        public string GetValue { get => _randomService.GetRandom(); }
    }
}
