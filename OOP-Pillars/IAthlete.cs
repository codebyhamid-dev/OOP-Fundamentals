using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pillars
{
    //Interfaces
    public interface IAthlete
    {
        string Sport { get; set; }
        string Team { get; set; }
        string GetAthleteInfo();
    }

}
