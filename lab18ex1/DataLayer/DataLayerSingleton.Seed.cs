using lab18ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18ex1
{
    internal partial class DataLayerSingleton
    {
      
        public void Seed()
        {
          using  var carsDbContext = new CarsDbContext();
         
            var vw = new Producator { Nume="VW", Adresa="Volfenstein"};
           
            var polo = new Autovehicul
            {Nume="Polo",
            Producator=vw,
            CarteTehnica=new CarteTehnica
                {
                  AnFabricatie=1990,
                  CapacitateCilindrica=1395,
                  SerieSasiu=Guid.NewGuid().ToString() 
                }
            };

            var faiton = new Autovehicul
            {
                Nume = "Phaeton",
                Producator = vw,
                CarteTehnica = new CarteTehnica
                {
                    AnFabricatie =2010,
                    CapacitateCilindrica = 2593,
                    SerieSasiu = Guid.NewGuid().ToString()
                }
            };

            var jetta = new Autovehicul
            {
                Nume = "Jetta",
                Producator = vw,
                CarteTehnica = new CarteTehnica
                {
                    AnFabricatie = 2015,
                    CapacitateCilindrica = 1593,
                    SerieSasiu = Guid.NewGuid().ToString()
                }
            };



            carsDbContext.Add(faiton);
            carsDbContext.Add(jetta);
            carsDbContext.Add(polo);

            carsDbContext.SaveChanges();

        }
    }
}
