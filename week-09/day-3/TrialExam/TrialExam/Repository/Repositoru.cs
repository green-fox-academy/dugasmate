using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialExam.Models;
using TrialExam.ViewModel;

namespace TrialExam.Repository
{
    public class Repositoru : IRepositoru
    {
        private SpaceContext context;
        public Repositoru(SpaceContext context)
        {
            this.context = context;
        }

        public void Create(Planet input)
        {
            context.Add(input);
            context.SaveChanges(); ;
        }

        public void Move(int id)
        {
            Planet selectedPlanet = context.Planet.FirstOrDefault(x => x.Id == id);
            context.Spaceship.ToList()[0].Planet = selectedPlanet.Name;
            context.SaveChanges();
        }

        public SpaceContext Read()
        {
            return (context);

        }

        public void ToShip(int id)
        {
            Planet selectedPlanet = context.Planet.FirstOrDefault(x => x.Id == id);
            if (context.Spaceship.ToList()[0].MaxCapacity >= context.Spaceship.ToList()[0].Utilization + 5)
            {
                context.Spaceship.ToList()[0].Utilization += 5;
                selectedPlanet.Population -= 5;
                context.SaveChanges();
            }

        }

        public void ToPlanet(int id)
        {
            Planet selectedPlanet = context.Planet.FirstOrDefault(x => x.Id == id);
            if (context.Spaceship.ToList()[0].Utilization - 5 >= 0 )
            {

                selectedPlanet.Population += context.Spaceship.ToList()[0].Utilization;
                context.Spaceship.ToList()[0].Utilization -= context.Spaceship.ToList()[0].Utilization;
                context.SaveChanges();
            }

        }
    }
}
