using NUnit.Framework;
using BM.Queue;
using FluentAssertions;
using System;

namespace BM.TDDKata.Queue.Test
{
    public class QueueTest
    {
        private IntegerQueue integerQueue;
        [SetUp]
        public void Setup()
        {
            integerQueue = new IntegerQueue();
        }

        [Test]
        public void NewQueue_IsEmpty()
        {
            Assert.IsTrue(integerQueue.IsEmpty());
            Assert.AreEqual(0, integerQueue.GetSize());
        }

        [Test]
        public void AfterOneEnQueue_IsNotEmpty()
        {
            integerQueue.EnQueue(0);
            Assert.IsFalse(integerQueue.IsEmpty());
            Assert.AreEqual(1, integerQueue.GetSize());
        }
        [Test]
        public void AfterTwoEnqueus_SizeIsTwo()
        {
            integerQueue.EnQueue(0);
            integerQueue.EnQueue(0);
            Assert.AreEqual(2, integerQueue.GetSize());
        }
        [Test]
        public void AfterOneEnqueueAndOneDequeue_SizeIsZero()
        {
            integerQueue.EnQueue(0);
            integerQueue.DeQueue();
            Assert.AreEqual(0, integerQueue.GetSize());
        }
        [Test]
        public void AfterEnqueueX_DequeuesX()
        {
            integerQueue.EnQueue(55);
            Assert.AreEqual(55, integerQueue.DeQueue());
        }

        [Test]
        public void AfterEnqueueXAndEnqueueY_DequeuesX()
        {
            integerQueue.EnQueue(55);
            integerQueue.EnQueue(66);
            Assert.AreEqual(55, integerQueue.DeQueue());
        }

        [Test]
        public void AfterThreeEnqueuesAndTwoDequeues_DequeusLastInteger()
        {
            integerQueue.EnQueue(22);
            integerQueue.EnQueue(33);
            integerQueue.EnQueue(44);
            integerQueue.DeQueue();
            integerQueue.DeQueue();
            Assert.AreEqual(44, integerQueue.DeQueue());
        }

        [Test]
        public void Dequeue_WhenQueueIsEmpty_ShouldThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => integerQueue.DeQueue());
        }

        [Test]
        public void AfterEnqueueX_PeeksXButNotRemoveX()
        {
            integerQueue.EnQueue(55);
            Assert.AreEqual(55, integerQueue.Peek());
            Assert.AreEqual(55, integerQueue.DeQueue());
        }
        [Test]
        public void EmptyQueueAndPeek_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => integerQueue.Peek());
        }


    }
}