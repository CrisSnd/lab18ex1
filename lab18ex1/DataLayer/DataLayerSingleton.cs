using lab18ex1.Exceptions;
using lab18ex1.Models;
using Microsoft.EntityFrameworkCore;


namespace lab18ex1
{
    internal partial class DataLayerSingleton
	{

		#region Singleton

		private DataLayerSingleton()
		{

		}
		

		private static DataLayerSingleton instance;


		public static DataLayerSingleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new DataLayerSingleton();
				}
				return instance;
			}
		}
		#endregion

		public Autovehicul AdaugaAutovehicul(string nume, int producatorId )
		{
			using var ctx = new CarsDbContext();

			if(!ctx.Producatori.Any(p=>p.Id==producatorId))
			{
				throw new InvalidIdException($"Id producator invalid {producatorId}");
			}
					

			var autovehicul = new Autovehicul
			{
				Nume = nume,
				ProducatorId= producatorId
			};

			ctx.Add(autovehicul);
			ctx.SaveChanges();

			return autovehicul;
		}

		public Producator AdaugaProducator(string nume, string adresa)
		{

			using var ctx = new CarsDbContext();
			var producator = new Producator
			{
				Nume = nume,
				Adresa = adresa
			};

			ctx.Add(producator);
			ctx.SaveChanges();

			return producator;
		}	

		public Cheie AdaugaCheieLaAutovehicul(Guid codAcces, int autovehiculId)
		{
			using var ctx = new CarsDbContext();
			
			if (!ctx.Autovehicule.Any (a=>a.Id==autovehiculId))
			{
				throw new InvalidCastException($"Id autovehicul invalid {autovehiculId}");
			}

			var cheie = new Cheie
			{ CodAcces = codAcces,
			 AutovehiculId = autovehiculId	
			};

			
			ctx.Add (cheie);
			ctx.SaveChanges();

			return cheie;
		}
		public void StergeAutovehicul(int id)
		{
			using var ctx = new CarsDbContext();

			var autovehicul = ctx.Autovehicule.Include(a => a.Chei).FirstOrDefault(a => a.Id == id);
			if (autovehicul == null)
			{
				throw new InvalidCastException($"Id autovehicul invalid {id}");
			}

			autovehicul.Chei.ForEach(c =>
			{ c.AutovehiculId = null; });


			ctx.Remove (autovehicul);
			ctx.SaveChanges();
		}

		
     }


	
}
