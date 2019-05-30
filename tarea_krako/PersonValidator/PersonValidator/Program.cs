using PersonRepository.Interfaces;
using PersonRepository;

namespace PersonValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ValidatorTest();
            var abm = new ABM_Basic();
            a.Validate(abm);

        }
    }
}
