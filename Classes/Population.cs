using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Population
{
    public Beetle[] myPopulation { get; set; }


    public Population(int size)
    {
        myPopulation = new Beetle[size];
        for(int index = 0; index < size; index++)
        {
            myPopulation[index] = GenerateRandomBeetle();
        }
    }

    private Beetle GenerateRandomBeetle()
    {
        Random rd = new Random();
        var red = (float) rd.Next(0, 255);
        var green = (float) rd.Next(0, 255);
        var blue = (float) rd.Next(0, 255);
        var beetle = new Beetle(red, green, blue);
        return beetle;
    }

    public bool SwapBeetle(Beetle newBeetle, int index)
    {
        if (index > myPopulation.Length - 1 || index < 0 || newBeetle == null) return false;
        myPopulation[index] = newBeetle;
        return true;
    }


}
