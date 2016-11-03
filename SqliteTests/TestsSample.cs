using System;
using System.Diagnostics;
using System.Linq;
using GalaSoft.MvvmLight.Ioc;
using NUnit.Framework;
using SQLite;

namespace SqliteTestsDroid
{
	public class Fruit
	{
		[PrimaryKey, AutoIncrement]
		public int id { get; set; }
		public string name { get; set;}
	}


	[TestFixture]
	public class TestsSample
	{
		SQLiteConnection conn;

		[SetUp]
		public void Setup() {
			conn = SimpleIoc.Default.GetInstance<SQLiteConnection>();
			conn.CreateTable<Fruit>();
			conn.DeleteAll<Fruit>();
		}


		[TearDown]
		public void Tear() { }

		[Test]
		public void Pass()
		{
			Debug.WriteLine("test1");
			Assert.True(true);
		}

		[Test]
		public void TryConnect()
		{
			conn.Insert(new Fruit() { name = "Banana" });
			conn.Insert(new Fruit() { name = "Apple" });
			conn.Insert(new Fruit() { name = "Orange" });
			var fruit = conn.Table<Fruit>().OrderBy(f =>f.id).ToList();
			Assert.That(fruit.Count, Is.EqualTo(3));
		}
	}
}
