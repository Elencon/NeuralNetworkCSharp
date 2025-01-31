﻿/*
 * Author: Nikola Živković
 * Website: rubikscode.net
 * Year: 2018
 */

using LibNN.ActivationFunctions;

namespace NN.Tests;

[TestClass]
public class SigmoidFunctionTest
{
    [Ignore]
    [TestMethod]
    public void CalculateOutput_InputPassed_CorrectOutput()
    {
        var sigmoidFuncion = new SigmoidActivationFunction(1);

        Assert.AreEqual(0.557247854598556, sigmoidFuncion.CalculateOutput(0.23));
    }
}
