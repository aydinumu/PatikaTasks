namespace BasicMVC
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();
			var app = builder.Build();

			app.MapControllerRoute
				(
				name: "Default",
				pattern: "{Controller=Home}/{Action=Index}"
				);

			app.Run();
		}
	}
}