/*
 * Author: Nikola Živković
 * Website: rubikscode.net
 * Year: 2018
 */

using LibNN.Synapses;

namespace LibNN.InputFunctions;

/// <summary>
/// Implementation of Weighted Sum Function.
/// </summary>
public class WeightedSumFunction : IInputFunction
{
    public double CalculateInput(List<ISynapse> inputs)
    {
        return inputs.Select(x => x.Weight * x.GetOutput()).Sum();
    }
}
