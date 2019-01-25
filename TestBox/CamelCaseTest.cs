  using NUnit.Framework;
  using System;
  using Kata;
  
  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void BasicTests()
    {
       
       Assert.AreEqual("TestCase", "test case".CamelCase());
       Assert.AreEqual("CamelCaseMethod", "camel case method".CamelCase());
       Assert.AreEqual("SayHello", "say hello".CamelCase());
       Assert.AreEqual("CamelCaseWord", " camel case word".CamelCase());
       Assert.AreEqual("", "".CamelCase());
    }
  }
