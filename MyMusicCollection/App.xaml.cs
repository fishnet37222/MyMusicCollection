// Copyright (c) 2024 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

using System.Windows;

namespace MyMusicCollection;

public partial class App
{
	protected override void RegisterTypes(IContainerRegistry containerRegistry)
	{
	}

	protected override Window CreateShell()
	{
		return Container.Resolve<MainWindow>();
	}
}
