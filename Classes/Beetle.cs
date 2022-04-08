using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Beetle
{
    string ID { get; set; }
    public float Red { get; set; }
    public float Green { get; set; }
    public float Blue { get; set; }

    public Beetle(float r, float g, float b)
    {
        Red = r;
        if (Red < 0) Red = 0;
        if (Red > 255) Red = 255;

        Green = g;
        if (Green < 0) Green = 0;
        if (Green > 255) Green = 255;

        Blue = b;
        if (Green < 0) Blue = 0;
        if (Green > 255) Blue = 255;
    }

    public void SetID(string code)
    {
        ID = code;
    }

    public override string ToString()
    {
        return ID + " ; RGB:" +
            Red.ToString() + ", " +
            Green.ToString() + ", " + 
            Blue.ToString() + ";"; 
    }



}