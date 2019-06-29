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
<<<<<<< HEAD
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
=======
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
<<<<<<< HEAD
>>>>>>> parent of e3d2f13... New Update
=======
>>>>>>> parent of e3d2f13... New Update
		}
	}
}
