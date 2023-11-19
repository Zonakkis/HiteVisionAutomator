using Automator.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Automator.Views
{
    public partial class ClassView : UserControl
    {
        public ClassView()
        {
            InitializeComponent();
        }

        public void Cell(object sender,DataGridCellEditEndedEventArgs args)
        {
           foreach(var item in (List<Class>)(ClassDataGrid.ItemsSource))
            {
                Trace.WriteLine(item.Name);
            }
        }
    }
}