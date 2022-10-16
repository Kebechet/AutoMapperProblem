using AutoMapper;

namespace ApiTest
{
    public sealed class TestingService
    {
        private readonly IMapper _mapper;
        public TestingService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public void Test()
        {
            var original = new TrainingSetDto()
            {
                CreationTime = DateTime.Now.TimeOfDay,
                Id = 948,
                RepCount = 10,
                TagIds = new List<long>() { 14 },
                TrainingExerciseId = 45,
                WeightLiftedKilograms = 10
            };
            var copy = _mapper.Map<TrainingSetDto>(original);

            var originalHashCode = original.GetHashCode();
            var copyHashCode = copy.GetHashCode();
            if (originalHashCode == copyHashCode)
            {
                throw new Exception("Copy was done by reference.");
            }
        }
    }
}