using Autofac;
using StockControl.Data;
using StockControl.Data.Builders;
using StockControl.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl.UI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<ApplicationDbContext>().As<ApplicationDbContext>().SingleInstance();

			builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
			builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

			builder.RegisterType<CategoryBuilder>().As<ICategoryService>();
			builder.RegisterType<CustomerBuilder>().As<ICustomerService>();
			builder.RegisterType<PersonelBuilder>().As<IPersonelService>();
			builder.RegisterType<SaleBuilder>().As<ISaleService>();
			builder.RegisterType<ShipmentBuilder>().As<IShipmentService>();
			builder.RegisterType<StockBuilder>().As<IStockService>();
		}
	}
}
