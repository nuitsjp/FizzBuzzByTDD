using System;
using FizzBussByTdd;
using FluentAssertions;
using Xunit;

namespace FizzBussByTddTest
{
    public class FizzBussTest
    {
        protected readonly FizzBuzz FizzBuzz;

        public FizzBussTest()
        {
            FizzBuzz = new FizzBuzz();
        }

        public class Convertƒƒ\ƒbƒh‚Í”‚ğ•¶š—ñ‚É•ÏŠ·‚·‚é : FizzBussTest
        {
            [Theory]
            [InlineData(3, "Fizz")]
            [InlineData(6, "Fizz")]
            public void _3‚Ì”{”‚Ì‚Í”‚Ì‘ã‚í‚è‚ÉFizz‚É•ÏŠ·‚·‚é(int “ü—Í, string Œ‹‰Ê)
            {
                FizzBuzz.Convert(“ü—Í).Should().Be(Œ‹‰Ê);
            }

            [Theory]
            [InlineData(5, "Buzz")]
            [InlineData(10, "Buzz")]
            public void _5‚Ì”{”‚Ì‚Í”‚Ì‘ã‚í‚è‚ÉBuzz‚É•ÏŠ·‚·‚é(int “ü—Í, string Œ‹‰Ê)
            {
                FizzBuzz.Convert(“ü—Í).Should().Be(Œ‹‰Ê);
            }

            [Theory]
            [InlineData(1, "1")]
            [InlineData(2, "2")]
            public void ‚»‚Ì‘¼‚Ì”‚Ì‚Í‚»‚Ì‚Ü‚Ü•¶š—ñ‚É•ÏŠ·‚·‚é(int “ü—Í, string Œ‹‰Ê)
            {
                FizzBuzz.Convert(“ü—Í).Should().Be(Œ‹‰Ê);
            }
        }
    }
}
