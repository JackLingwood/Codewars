namespace VincentNamespace 
{
  using NUnit.Framework;
  using System;
  using Kata;
  
  [TestFixture]
  public class VincentTest
  {
    [Test]
    public void SimpleAddTest()
    {
        int result = Vincent.Add(1,2);
        Assert.AreEqual(3,result);
    } 

    [Test]
    public void SimpleSubtractTest()
      {
        int result = Vincent.Subtract(5,4);
        Assert.AreEqual(  1,result);
    } 

    [Test]
    public void SimpleSubtractTest2()
    {
        int result = Vincent.Subtract(10,3);
        Assert.AreEqual(7,result);
    } 

     [Test]
    public void SimpleSubtractTest3()
    {
        int result = Vincent.Subtract(11,1);
        Assert.AreEqual(10,result);
    } 

  }
}