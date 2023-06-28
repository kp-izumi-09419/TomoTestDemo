using System;
using System.Collections.Generic;

namespace TomoTestDemo.Core.Models
{
    public class Calculation : ICalculation
    {
        private const string _plus = "＋";
        private const string _minus = "－";
        private const string _multi = "×";
        private const string _divide = "÷";

        public IEnumerable<string> Symbols
        {
            get
            {
                return new string[]
                {
                    _plus,
                    _minus,
                    _multi,
                    _divide
                };
            }
        }

        public Calculation()
        {
        }

        public int Add(int left, int right) => left + right;

        public int Subtraction(int left, int right) => left - right;

        public int Run(string value, int left, int right)
        {
            switch (value)
            {
                case _plus:
                    return Add(left, right);

                case _minus:
                    return Subtraction(left, right);

                default:
                    throw new Exception();
            }
        }
    }

    public interface ICalculation
    {
        IEnumerable<string> Symbols { get; }

        int Add(int left, int right);

        int Subtraction(int left, int right);

        int Run(string value, int left, int right);
    }
}