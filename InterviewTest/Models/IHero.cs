using System;
using System.Collections.Generic;

namespace InterviewTest.Models
{
    public interface IHero:IEvolve
    {
        string name { get; set; }
        string power { get; set; }
        List<KeyValuePair<string, int>> stats { get; set; }
    }
}

