﻿namespace AnimationsIntroduction.WUA.ThemeAnimations
{
	using Windows.UI.Xaml;

	public sealed partial class DragOverThemeAnimationPage
	{

		public DragOverThemeAnimationPage()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Frame.GoBack();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			MyStoryboard.Begin();
		}
	}
}
