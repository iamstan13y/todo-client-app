﻿using Microsoft.UI.Xaml;

namespace Todo.Client.WinUI;

public partial class App : MauiWinUIApplication
{

	public App() => InitializeComponent();
	
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}