using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwNine.Counter.Guns;

public abstract class Weapon
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Ammo { get; protected set; }
    public Weapon(string name, decimal price, int ammo)
    {
        if(string.IsNullOrWhiteSpace(name))       
            throw new ArgumentException("Name cannot be null or empty.", nameof(name));
        
        if (price <= 0)     
            throw new ArgumentOutOfRangeException(nameof(price), "Price must be greater than zero.");
        
        Name = name;
        Price = price;
        Ammo = ammo;
    }
    public abstract void Shoot();
}
