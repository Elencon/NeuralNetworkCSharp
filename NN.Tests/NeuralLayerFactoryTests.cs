/*
 * Author: Nikola Živković
 * Website: rubikscode.net
 * Year: 2018
 */

using LibNN;
using LibNN.ActivationFunctions;
using LibNN.InputFunctions;

namespace NN.Tests;

[TestClass]
public class NeuralLayerFactoryTests
{
    [TestMethod]
    public void CreateNeuralLayer_NumberOfNeuronsPasses_CorrectLayerCreated()
    {
        var neuralLayerFactory = new NeuralLayerFactory();
        var neuralLayer = NeuralLayerFactory.CreateNeuralLayer(11, new StepActivationFunction(0.5), new WeightedSumFunction());

        Assert.AreEqual(11, neuralLayer.Neurons.Count);
    }
}
