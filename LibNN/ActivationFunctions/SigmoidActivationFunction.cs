/*
 * Author: Nikola Živković
 * Website: rubikscode.net
 * Year: 2018
 */

namespace LibNN.ActivationFunctions;

/// <summary>
/// Implementation of Sigmoid Activation Function.
/// </summary>
public class SigmoidActivationFunction : IActivationFunction
{
    private double _coeficient;

    public SigmoidActivationFunction(double coeficient)
    {
        _coeficient = coeficient;
    }

    public double CalculateOutput(double input) => 1 / (1 + Math.Exp(-input * _coeficient));
}
