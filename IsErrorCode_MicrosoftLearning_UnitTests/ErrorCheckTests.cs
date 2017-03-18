namespace IsErrorCode_MicrosoftLearning_UnitTests
{
    using IsErrorCode_MicrosoftLearning;
    using IsErrorCode_MicrosoftLearning.Interfaces;
    using NUnit.Framework;
    
    public class ErrorCheckTests
    {
        public IErrorCheckable ErrorCheckClass { get; internal set; }

        [SetUp]
        public virtual void Init()
        {
            this.ErrorCheckClass = new ErrorCheck();
        }

        [TestFixture]
        public class IsErrorCodeTests : ErrorCheckTests
        {
            [Test]
            public void ErrorCodeId_1()
            {
                int errorCode = 1;
                var result = this.ErrorCheckClass.IsErrorCode(errorCode);

                Assert.IsFalse(result);
            }

            [Test]
            public void ErrorCodeId_5()
            {
                int errorCode = 5;
                var result = this.ErrorCheckClass.IsErrorCode(errorCode);

                Assert.IsFalse(result);
            }

            [Test]
            public void ErrorCodeId_9()
            {
                int errorCode = 9;
                var result = this.ErrorCheckClass.IsErrorCode(errorCode);

                Assert.IsFalse(result);
            }

            [Test]
            public void ErrorCodeId_2()
            {
                int errorCode = 2;
                var result = this.ErrorCheckClass.IsErrorCode(errorCode);

                Assert.IsFalse(result);
            }

            [Test]
            public void ErrorCodeId_0_to_100()
            {
                for (int i = 0; i < 100; i++)
                {
                    var result = this.ErrorCheckClass.IsErrorCode(i);

                    Assert.IsFalse(result);
                }
            }
        }
    }

    /// <summary>
    /// Run IsErrorCodeTests also for refactored version
    /// </summary>
    [TestFixture]
    public class ErrorCheckRefactoredTests : ErrorCheckTests.IsErrorCodeTests
    {
        [SetUp]
        public override void Init()
        {
            this.ErrorCheckClass = new ErrorCheckRefactored();
        }
    }
}
