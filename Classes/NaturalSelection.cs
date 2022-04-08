using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NaturalSelection
{
    public Population population { get; set; }
    private float MutationRate { get; set; }
    private float MutationSpread { get; set; }

    

    public void StartPopulation(int size)
    {
        population = new Population(size);
    }

    public float FitnessFunction(Beetle beetle)
    {

        return 0;

    }

    public Beetle CrossoverBeetles(Beetle father, Beetle mother)
    {
        var rfather = father.Red;
        var green = father.Green / 2 + mother.Green / 2;
        var mblue = mother.Blue;
        return new Beetle(rfather, green, mblue);
    }

    public Beetle MutateBeetle(Beetle mutagen)
    {
        var random = new Random();
        var color = random.Next(0, 100);
        var mutationColor = random.Next(-50, 50);
        if(color <= 33)
        {
            var red = mutagen.Red + mutationColor;
            return new Beetle(red, mutagen.Green, mutagen.Blue);
        }
        if (color <= 66)
        {
            var green = mutagen.Green + mutationColor;
            return new Beetle(mutagen.Red, green, mutagen.Blue);
        }
        var blue = mutagen.Blue + mutationColor;
        return new Beetle(mutagen.Red, mutagen.Green, blue);

    }


}
