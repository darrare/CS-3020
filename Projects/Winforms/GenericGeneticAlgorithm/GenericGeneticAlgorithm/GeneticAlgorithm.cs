using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericGeneticAlgorithm.Problems;

namespace GenericGeneticAlgorithm
{
    class GeneticAlgorithm
    {
        //Random rand = new Random(8675309);
        //Random rand = new Random(1234);
        Random rand = new Random(10);

        public GeneticAlgorithm()
        {
            float[] weights = new float[100];
            float[] values = new float[100];
            for (int i = 0; i < 100; i++)
            {
                weights[i] = (float)(1 + rand.NextDouble() * 100);
                values[i] = (float)(1 + rand.NextDouble() * 20);
            }
            Knapsack knapsack = new Knapsack(500, weights, values);
            Population p = new Population(528, new object[] { 1.0f, 1.0f, 1.0f, 1.0f }, .5f);

            int index = 0;
            while(true)
            {
                p.CalculateFitness(knapsack.Fitness);
                p = p.RemoveUnworthy();
                if (p.CalculateConvergence() < .01f)
                {
                    break;
                }
                p.MatePopulation();
                //25% chance to select a node to mutate. 50% chance to actually mutate each gene. 25% maximum deviation from original
                p.Mutate(.25f, .5f, .25f);
                index++;
            }
            knapsack.SetKnapsackSolutionState(p.Chromosomes.Select(t => t.Genes).ToList());
            Console.WriteLine();
        }
    }
}
