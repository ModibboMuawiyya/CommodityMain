using CommodityMain.DataAccess.EF.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace CommodityMain.DataAccess.EF.BaseRepos
{
    public class UnitOfWork : IUnitOfWork
	{
		/// <summary>
		/// This readonly variable creates the context of the database
		/// </summary>
		private readonly CommodityContext _dbContext;

		/// <summary>
		/// This constructor initializes the database
		/// </summary>
		public UnitOfWork(CommodityContext context)
		{
			_dbContext = context;
		}

		/// <summary>
		/// This method Returns the db context created from the constructor
		/// </summary>
		public DbContext Db
		{
			get { return _dbContext; }
		}

		private bool disposed = false;
		/// <summary>
		/// This method disposes the database
		/// </summary>
		public virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_dbContext.Dispose();
				}
			}

			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
