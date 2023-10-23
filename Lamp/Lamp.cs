using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampClass;
class Lamp
{
    private bool isOn = false;

    public void switchLight()
    {
        isOn = !isOn;
    }

    //public void turnOn()
    //{
    //    isOn = true;
    //}
    //public void turnOff()
    //{
    //    isOn = false;
    //}

    public bool getState()
    {
        return isOn;
    }

    static void Main(string[] args)
    {
        Lamp l1 = new Lamp();

        Console.WriteLine("Lamp is on: " + l1.getState());

        l1.switchLight();
        Console.WriteLine("Lamp is on: " + l1.getState());
    }
}