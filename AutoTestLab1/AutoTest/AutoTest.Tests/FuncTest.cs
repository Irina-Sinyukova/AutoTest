// <copyright file="FuncTest.cs">Copyright ©  2022</copyright>
using System;
using AutoTest;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoTest.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для Func</summary>
    [PexClass(typeof(Func))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FuncTest
    {
        /// <summary>Тестовая заглушка для Fun(Double, Double, Double)</summary>
        [PexMethod]
        public double FunTest(
            [PexAssumeUnderTest]Func target,
            double a,
            double b,
            double x
        )
        {
            double result = target.Fun(a, b, x);
            return result;
            // TODO: добавление проверочных утверждений в метод FuncTest.FunTest(Func, Double, Double, Double)
        }
    }
}
