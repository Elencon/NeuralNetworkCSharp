﻿/*
 * Author: Nikola Živković
 * Website: rubikscode.net
 * Year: 2018
 */

using LibNN;
using LibNN.Neuron;
using Moq;

namespace NN.Tests;

[TestClass]
public class NeuralLayerTest
{
    [TestMethod]
    public void ConnectLayers_ConnectingLayers_ConnectionsAdded()
    {
        var inputNeuron = new Mock<INeuron>();
        var outputNeuron = new Mock<INeuron>();

        inputNeuron.Setup(x => x.AddOutputNeuron(It.IsAny<INeuron>())).Verifiable();
        outputNeuron.Setup(x => x.AddInputNeuron(It.IsAny<INeuron>())).Verifiable();

        var inputNeuralLayer = new NeuralLayer();
        var outputNeuralLayer = new NeuralLayer();

        inputNeuralLayer.Neurons.Add(inputNeuron.Object);
        outputNeuralLayer.Neurons.Add(outputNeuron.Object);

        outputNeuralLayer.ConnectLayers(inputNeuralLayer);

        outputNeuron.Verify(x => x.AddInputNeuron(It.Is<INeuron>(n => n == inputNeuron.Object)));
    }
}
