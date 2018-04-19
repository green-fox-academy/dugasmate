using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialExam.Models;

namespace TrialExam.ViewModel
{
    public class PlanetsAndSpaceship
    {
        public IEnumerable<Spaceship> uhajo  { get; set; } 
        public IEnumerable<Planet> Planets { get; set; }

    }
}
