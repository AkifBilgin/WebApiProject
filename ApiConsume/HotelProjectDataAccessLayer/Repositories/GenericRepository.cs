using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		
		public void Add(T entity)
		{
			using (var context = new Context())
			{
				var addEntity = context.Entry(entity);
				addEntity.State = EntityState.Added;
				context.SaveChanges();
			}
			
		}

		public void Delete(T entity)
		{
			using (var context = new Context())
			{
				var addEntity = context.Entry(entity);
				addEntity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}

		public List<T> GetAll()
		{
			using (var context = new Context())
			{
				return context.Set<T>().AsNoTracking().ToList();	
			}
		}

		public T GetById(int id)
		{
			using (var context = new Context())
			{
				return context.Set<T>().Find(id);
			}
		}

		public void Update(T entity)
		{
			using (var context = new Context())
			{
				var addEntity = context.Entry(entity);
				addEntity.State = EntityState.Modified;
				context.SaveChanges();
			}
		}
	}
}
