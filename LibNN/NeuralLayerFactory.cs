/*
 * Author: Nikola Živković
 * Website: rubikscode.net
 * Year: 2018
 */

using LibNN.ActivationFunctions;
using LibNN.InputFunctions;

namespace LibNN;

/// <summary>
/// Factory used to create layers.
/// </summary>
public class NeuralLayerFactory
{
    public static NeuralLayer CreateNeuralLayer(int numberOfNeurons, IActivationFunction activationFunction, IInputFunction inputFunction)
    {
        var layer = new NeuralLayer();

        for (int i = 0; i < numberOfNeurons; i++)
        {
            var neuron = new Neuron.Neuron(activationFunction, inputFunction);
            layer.Neurons.Add(neuron);
        }

        return layer;
    }
}
