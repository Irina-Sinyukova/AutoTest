// <copyright file="Func2Test.cs">Copyright ©  2022</copyright>
using System;
using AutoTest2;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoTest2.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для Func2</summary>
    [PexClass(typeof(Func2))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Func2Test
    {
        /// <summary>Тестовая заглушка для Fun(Double, Double, Double)</summary>
        [PexMethod]
        public double FunTest(
            [PexAssumeUnderTest]Func2 target,
            double a,
            double b,
            double x
        )
        {
            double result = target.Fun(a, b, x);
            return result;
            // TODO: добавление проверочных утверждений в метод Func2Test.FunTest(Func2, Double, Double, Double)
        }
    }
}
