using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.DataAccess.EF.Interfaces
{

	public interface IUnitOfWork : IDisposable
	{
		/// <summary>
		/// Return the database reference for this Unit Of Work
		/// </summary>
		DbContext Db { get; }
	}
}
