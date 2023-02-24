using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Lab4_Blazor_Hybrid_App;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
