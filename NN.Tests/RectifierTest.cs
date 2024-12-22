/*
 * Author: Nikola Živković
 * Website: rubikscode.net
 * Year: 2018
 */

using LibNN.ActivationFunctions;

namespace NN.Tests;

[TestClass]
public class RectifierTest
{
    [TestMethod]
    public void CalculateOutput_InputLargerThanZeroPassed_CorrectOutput()
    {
        var rectifier = new RectifiedActivationFuncion();

        Assert.AreEqual(0.23, rectifier.CalculateOutput(0.23));
    }

    [TestMethod]
    public void CalculateOutput_InputSmallerThanZeroPassed_CorrectOutput()
    {
        var rectifier = new RectifiedActivationFuncion();

        Assert.AreEqual(0, rectifier.CalculateOutput(-0.23));
    }
}
