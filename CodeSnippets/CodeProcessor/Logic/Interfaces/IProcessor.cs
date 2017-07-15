using CodeProcessor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProcessor.Logic.Interfaces
{
    public interface IProcessor
    {
        ProcessingResult Process(string input);
    }
}
