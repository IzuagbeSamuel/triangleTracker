using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;
namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void IsTriangle_NumbersFormAnEquilateral_True()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual(true, testTriangle.IsEquilateral(3, 3, 3));
    }

    [TestMethod]
    public void IsTriangle_NumbersFormAnIsosceles_True()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual(true, testTriangle.IsIsosceles(8, 6, 6));
    }

    [TestMethod]
    public void IsTriangle_NumbersFormAScalene_True()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual(true, testTriangle.IsScalene(2, 3, 4));
    }
  }
}