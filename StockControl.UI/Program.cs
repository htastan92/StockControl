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

			builder.RegisterType<CategoryService>().As<ICategoryService>();
			builder.RegisterType<CustomerService>().As<ICustomerService>();
			builder.RegisterType<PersonelService>().As<IPersonelService>();
			builder.RegisterType<SaleService>().As<ISaleService>();
			builder.RegisterType<ShipmentService>().As<IShipmentService>();
			builder.RegisterType<StockService>().As<IStockService>();

			builder.RegisterType<FrmMain>().As<FrmMain>();
			builder.RegisterType<FrmRegister>().As<FrmRegister>();
			builder.RegisterType<FrmLogin>().As<FrmLogin>();
			builder.RegisterType<FrmSale>().As<FrmSale>();
			var container = builder.Build();

			using (var scope = container.BeginLifetimeScope())
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				var frm = scope.Resolve<FrmMain>();
				Application.Run(frm);
			}
		}
	}
}
