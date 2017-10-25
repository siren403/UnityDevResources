using System;
using Zenject;
using NUnit.Framework;

namespace TDD.Exam03
{
    [TestFixture]
    public class Logger_Tests : ZenjectUnitTestFixture
    {

        [SetUp]
        public void Installs()
        {
            Container.Bind<Logger>().AsSingle();
            Container.Inject(this);
        }

        [Inject] private Logger _logger;

        [Test]
        public void _Initial_Values()
        {
            Assert.That(_logger.Log == "");
        }

        [Test]
        public void _First_Entry()
        {
            _logger.Write("foo");
            Assert.That(_logger.Log == "foo");
        }

        [Test]
        public void _Append()
        {
            _logger.Write("foo");
            _logger.Write("bar");

            Assert.That(_logger.Log == "foobar");
        }

        [Test]
        public void _Null_Value()
        {
            //전달한 함수에서 예상한 Exception이 발생하는지 검사
            Assert.Throws<ArgumentException>(() => _logger.Write(null));
        }

    }
}