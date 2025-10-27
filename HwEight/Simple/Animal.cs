using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwEight.Simple;

public abstract class Animal
{
    public string Name { get; set; }

    protected Animal(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Animal name cannot be empt!");

        Name = name;
    }

    public abstract void MakeSound();
}
