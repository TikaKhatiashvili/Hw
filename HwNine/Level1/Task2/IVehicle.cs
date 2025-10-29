using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwNine.Level1.Task2;

public interface IVehicle
{
    public string Model { get; set; }

   public int Year { get; set; }

   void Start();
}
