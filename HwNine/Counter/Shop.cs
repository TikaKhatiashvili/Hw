using HwNine.Counter.Guns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwNine.Counter;

public class Shop
{ 
    private List<Weapon> _weapons= new List<Weapon>();
    public Shop() 
    { 
        _weapons.Add(new Pistol("Glock-18", price : 500, ammo : 15));
        _weapons.Add(new Rifle("AK-47", price:2700, ammo: 30));
        _weapons.Add(new Shootgun("M3 Super 90", price: 1500, ammo : 8));
    }
    public void ShowWeapons()
    {
        Console.WriteLine("Available weapons in the shop:");
        foreach (var weapon in _weapons)
        {
            Console.WriteLine($"- {weapon.Name}: ${weapon.Price}, Ammo: {weapon.Ammo}");
        }
    }
    public Weapon? GetWeapon(string weaponName)
    {
        foreach (var item in _weapons)
        {
            if (weaponName.Trim().Equals(item.Name, StringComparison.OrdinalIgnoreCase))
            {
                return item;
            }
        }
        return null;
    }
}
