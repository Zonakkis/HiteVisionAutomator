using Automator.Models;
using Automator.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Dialogs;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Platform.Storage;
using System;
using System.Diagnostics;
using Tmds.DBus.Protocol;


namespace Automator.Views
{
    public partial class MainView : UserControl
    {
        ClassViewModel classViewModel { get; set; }

        Button SelectedButton {  get; set; }
        public MainView()
        {
            InitializeComponent();
            //Trace.WriteLine(TuesdayButton.Background);
            SelectedButton = MondayButton;
        }
        public void ClassViewDataContextChanged(object sender, EventArgs args)
        {
            classViewModel = ((MainViewModel)((ContentControl)sender).DataContext).ClassView;
        }
        public void Monday(object sender, RoutedEventArgs args)
        {

            classViewModel.Day = 1;
            SelectedButton.Background = new SolidColorBrush(Color.FromArgb(51,0,0,0));
            MondayButton.Background = new SolidColorBrush(Colors.Cyan);
            SelectedButton = MondayButton;


        }
        public void Tuesday(object sender, RoutedEventArgs args)
        {
            
            classViewModel.Day = 2;
            SelectedButton.Background = new SolidColorBrush(Color.FromArgb(51, 0, 0, 0));
            TuesdayButton.Background = new SolidColorBrush(Colors.Cyan);
            SelectedButton = TuesdayButton;

        }
        public void Wednesday(object sender, RoutedEventArgs args)
        {

            classViewModel.Day = 3;
            SelectedButton.Background = new SolidColorBrush(Color.FromArgb(51, 0, 0, 0));
            WednesdayButton.Background = new SolidColorBrush(Colors.Cyan);
            SelectedButton = WednesdayButton;
        }

        public void Thursday(object sender, RoutedEventArgs args)
        {

            classViewModel.Day = 4;
            SelectedButton.Background = new SolidColorBrush(Color.FromArgb(51, 0, 0, 0));
            ThursdayButton.Background = new SolidColorBrush(Colors.Cyan);
            SelectedButton = ThursdayButton;
        }
        public void Friday(object sender, RoutedEventArgs args)
        {

            classViewModel.Day = 5;
            SelectedButton.Background = new SolidColorBrush(Color.FromArgb(51, 0, 0, 0));
            FridayButton.Background = new SolidColorBrush(Colors.Cyan);
            SelectedButton = FridayButton;
        }
        public void Saturday(object sender, RoutedEventArgs args)
        {

            classViewModel.Day = 6;
            SelectedButton.Background = new SolidColorBrush(Color.FromArgb(51, 0, 0, 0));
            SaturdayButton.Background = new SolidColorBrush(Colors.Cyan);
            SelectedButton = SaturdayButton;
        }

    }
}