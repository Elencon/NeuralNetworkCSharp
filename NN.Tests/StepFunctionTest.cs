/*
 * Author: Nikola Živković
 * Website: rubikscode.net
 * Year: 2018
 */

using LibNN.ActivationFunctions;

namespace NN.Tests;

[TestClass]
public class MyTestClass
{
    [TestMethod]
    public void CalculateOutput_InputSmallerThanTreshold_ZeroReturned()
    {
        var stepFunction = new StepActivationFunction(111);

        Assert.AreEqual(0, stepFunction.CalculateOutput(110));
    }

    [TestMethod]
    public void CalculateOutput_InputLargerThanTreshold_OneReturned()
    {
        var stepFunction = new StepActivationFunction(111);

        Assert.AreEqual(1, stepFunction.CalculateOutput(112));
    }
}
