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

        public class Convertメソッドは数を文字列に変換する : FizzBussTest
        {
            [Theory]
            [InlineData(3, "Fizz")]
            [InlineData(6, "Fizz")]
            public void _3の倍数の時は数の代わりにFizzに変換する(int 入力, string 結果)
            {
                FizzBuzz.Convert(入力).Should().Be(結果);
            }

            [Theory]
            [InlineData(5, "Buzz")]
            [InlineData(10, "Buzz")]
            public void _5の倍数の時は数の代わりにBuzzに変換する(int 入力, string 結果)
            {
                FizzBuzz.Convert(入力).Should().Be(結果);
            }

            [Theory]
            [InlineData(1, "1")]
            [InlineData(2, "2")]
            public void その他の数の時はそのまま文字列に変換する(int 入力, string 結果)
            {
                FizzBuzz.Convert(入力).Should().Be(結果);
            }
        }
    }
}
