using PersonRepository.Interfaces;
using PersonRepository;
using System;
using System.Globalization;

namespace PersonValidator
{
    class Program
    {
        static void Main(string[] args)
        {
             var a = new ValidatorTest();
             var abm = new ABM();
             a.Validate(abm);
        }
    }
}