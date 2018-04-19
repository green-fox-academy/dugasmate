using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialExam.Models;
using TrialExam.ViewModel;

namespace TrialExam.Repository
{
    public interface IRepositoru
    {
        SpaceContext Read();
        void Create(Planet input);
        void Move(int id);
        void ToShip(int id);
        void ToPlanet (int id);
        
    }
}
