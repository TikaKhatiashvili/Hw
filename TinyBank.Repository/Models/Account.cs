using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyBank.Repository.Models;

public class Account
{
    public int Id { get; set; }            
    public string Iban { get; set; }     
    public string Currency { get; set; }     
    public decimal Balance { get; set; }     
    public int CustomerId { get; set; }    
    public string Destination { get; set; }
}
