using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwNine.Level2.Task5;

interface ILogger
{
    void Log(string message);

    void LogWithTime(string message)
    {
        Console.WriteLine($"{DateTime.Now}: {message}");
    }
}