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

        public class Convert���\�b�h�͐��𕶎���ɕϊ����� : FizzBussTest
        {
            [Theory]
            [InlineData(3, "Fizz")]
            [InlineData(6, "Fizz")]
            public void _3�̔{���̎��͐��̑����Fizz�ɕϊ�����(int ����, string ����)
            {
                FizzBuzz.Convert(����).Should().Be(����);
            }

            [Theory]
            [InlineData(5, "Buzz")]
            [InlineData(10, "Buzz")]
            public void _5�̔{���̎��͐��̑����Buzz�ɕϊ�����(int ����, string ����)
            {
                FizzBuzz.Convert(����).Should().Be(����);
            }

            [Theory]
            [InlineData(1, "1")]
            [InlineData(2, "2")]
            public void ���̑��̐��̎��͂��̂܂ܕ�����ɕϊ�����(int ����, string ����)
            {
                FizzBuzz.Convert(����).Should().Be(����);
            }
        }
    }
}
