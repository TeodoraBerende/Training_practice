using BasicNET_part3;
using NUnit.Framework.Internal;

namespace TestProject
{
    /*
    It is recommended that programmers use async Task unit test methods in lieu of async void. 
    The reason is that it is difficult to retrieve the test results from the async void unit test methods in C#. 
    It should be noted that not all unit test frameworks support async unit tests that return void. 
    On the contrary, most of the unit test frameworks around provide support for async unit tests that return a Task instance.
    */

    [TestFixture]
    public class AsyncAwaitTests
    {
        [Test]
        public void SumAsyncTest()
        {
            var asyncAwait = new AsyncAwait();
            var sum = asyncAwait.SumAsync(3, 4);
            Assert.AreEqual(sum.Result, 7);
        }

        [Test]
        public async Task SumAsyncTest2()
        {
            var asyncAwait = new AsyncAwait();
            var sum = await asyncAwait.SumAsync(3, 4);
            Assert.AreEqual(sum, 7);
        }

        [Test]
        public void SomeMethodAsync()
        {
            var asyncAwait = new AsyncAwait();
            Assert.ThrowsAsync<Exception>(async () => await asyncAwait.SomeMethodAsync());
            
            Assert.DoesNotThrowAsync(async () => await asyncAwait.SomeMethodAsync());

        }
    }
}