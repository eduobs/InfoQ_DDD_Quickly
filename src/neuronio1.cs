using System;

namespace NeuralNetwork
{
    class Neuron
        {
                private double[] weights;
                        private double bias;

                                public Neuron(int numInputs)
                                        {
                                                    weights = new double[numInputs];
                                                                Random rnd = new Random();

                                                                            for (int i = 0; i < numInputs; i++)
                                                                                        {
                                                                                                        weights[i] = rnd.NextDouble();
                                                                                                                    }

                                                                                                                                bias = rnd.NextDouble();
                                                                                                                                        }

                                                                                                                                                public double CalculateOutput(double[] inputs)
                                                                                                                                                        {
                                                                                                                                                                    double sum = 0;
                                                                                                                                                                                for (int i = 0; i < inputs.Length; i++)
                                                                                                                                                                                            {
                                                                                                                                                                                                            sum += inputs[i] * weights[i];
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    sum += bias;

                                                                                                                                                                                                                                                return Sigmoid(sum);
                                                                                                                                                                                                                                                        }

                                                                                                                                                                                                                                                                private double Sigmoid(double x)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                    return 1 / (1 + Math.Exp(-x));
                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                