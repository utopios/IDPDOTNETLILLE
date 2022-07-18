namespace CoursAspIOC.Services
{
    public class ServiceA
    {
        private RandomService _randomService;

        public ServiceA(RandomService randomService)
        {
            _randomService = randomService;
        }
        public string GetValue { get => _randomService.GetRandom(); }

    }
}
