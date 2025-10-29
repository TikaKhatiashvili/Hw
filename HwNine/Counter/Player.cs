using HwNine.Counter.Guns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwNine.Counter;

public class Player
{ 
    public string Name { get; set; }
    public decimal Money { get; private set; }
    public List<Weapon> Weapons { get; private set; }

    public Player(string name, decimal startingMoney)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or empty.", nameof(name));
        if (startingMoney < 0)
            throw new ArgumentException(nameof(startingMoney), "Money cannot be negative.");
     
        Name = name;
        Money = startingMoney;
        Weapons = new List<Weapon>();
    }
    public void BuyWeapon(Weapon weapon)
    {
      
        if (Money < weapon.Price)
            throw new InvalidOperationException("Not enough money to buy this weapon.");
        Money -= weapon.Price;
        Weapons.Add(weapon);
        Console.WriteLine($"{Name} bought {weapon.Name}");
    }
    // player უნდა შეეძლოს გასროლის გამოძახება
    public void UseWeapon(string weaponName)
    {
        var weapon = GetWeapon(weaponName);
        if (weapon == null)
            throw new InvalidOperationException($"{Name} does not own a weapon named {weaponName}");
        weapon.Shoot();
    }
    private Weapon? GetWeapon(string weaponName)
    {
       foreach (var item in Weapons)
        {
            if (weaponName.Trim().Equals(item.Name,StringComparison.OrdinalIgnoreCase))
            {
                return item;
            }
        }
        return null;    
    }
}
