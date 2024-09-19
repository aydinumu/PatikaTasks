/*
README:
In this project, an ASP.NET Core Empty application was structured following the MVC design pattern. The following elements were implemented:

1. Created 'Controllers', 'Models', 'Views', and 'wwwroot' folders to organize the application.
2. Configured the 'Program.cs' file to:
    - Enable MVC services using `builder.Services.AddControllersWithViews()`.
    - Configure routing for the application with `app.MapControllerRoute()`.
    - Set up a default route pointing to the 'HomeController' and its 'Index' action.
    - Prepare the app with `builder.Build()` and start the server with `app.Run()`.

Static file handling is yet to be configured for the 'wwwroot' folder.
*/

using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Empty
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			app.UseStaticFiles();
			app.MapControllerRoute(name: "Default",
								pattern: "{Controller=Home}/{action=Index}");

			app.Run();
		}
	}
}

//Controller
//A Controller handles user requests, processes them, and returns a response (like a View or JSON). It connects the View and the Model.

//Action
//An Action is a method inside a Controller that responds to a specific request, returning data or a View.

//Model
//The Model represents the application's data and business logic. It handles data interactions, often with a database.

//View
//A View is the UI, presenting data to the user. It uses Razor syntax to combine HTML with dynamic content from the Model.

//Razor
//Razor is a templating engine that allows embedding C# code into HTML, enabling dynamic web pages.

//RazorView
//A RazorView (.cshtml file) generates HTML by combining C# and HTML using Razor syntax.

//wwwroot
//The wwwroot folder contains static files like images, CSS, and JavaScript that are directly accessible by the browser.

//builder.Build()
//This method builds the app, setting up middleware and preparing it to handle requests.

//app.Run()
//app.Run() starts the web server, making the app listen for incoming HTTP requests.