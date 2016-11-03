using System;
using System.Diagnostics;
using NUnit.Framework;

namespace SqliteTestsDroid
{
	[TestFixture]
	public class TestsSample
	{

		[SetUp]
		public void Setup() { }


		[TearDown]
		public void Tear() { }

		[Test]
		public void Pass()
		{
			Debug.WriteLine("test1");
			Assert.True(true);
		}

		[Test]
		public void Fail()
		{
			Assert.False(true);
		}

		[Test]
		[Ignore("another time")]
		public void Ignore()
		{
			Assert.True(false);
		}

		[Test]
		public void Inconclusive()
		{
			Assert.Inconclusive("Inconclusive");
		}
	}
}
