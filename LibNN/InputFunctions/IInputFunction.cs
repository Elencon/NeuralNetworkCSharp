/*
 * Author: Nikola Živković
 * Website: rubikscode.net
 * Year: 2018
 */

using LibNN.Synapses;

namespace LibNN.InputFunctions;

/// <summary>
/// Interface for Input Functions.
/// </summary>
public interface IInputFunction
{
    double CalculateInput(List<ISynapse> inputs);
}
