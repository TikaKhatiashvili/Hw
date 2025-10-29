using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwNine.Counter.Guns;

public class Shootgun : Weapon
{
    public Shootgun(string name, decimal price, int ammo) : base(name, price, ammo)
    {
    }

    public override void Shoot()
    {
        if (Ammo < 3)
            throw new InvalidOperationException($"{Name} has no bullets left");
        Ammo-=3;
        Console.WriteLine($"{Name} fires multiple bullets! (Ammo left : {Ammo})");
    }
}
