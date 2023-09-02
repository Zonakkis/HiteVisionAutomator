using Avalonia.Controls;
using Avalonia.Dialogs;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Tmds.DBus.Protocol;

namespace Automator.Views
{
    public partial class InitView : UserControl
    {
        public InitView()
        {
            InitializeComponent();
        }
        public async void SelectCameraPath(object sender, RoutedEventArgs args)
        {
            var topLevel = TopLevel.GetTopLevel(this);

            // Start async operation to open the dialog.
            var files = await topLevel.StorageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions
            {
                Title = "选择路径",
                AllowMultiple = false
            });
            if (files.Count > 0)
            {
                string path = files[0].Path.ToString();
                CameraPath.Content = path.Substring(8, path.Length - 8);
            }
        }
        public async void SelectTouchPath(object sender, RoutedEventArgs args)
        {
            var topLevel = TopLevel.GetTopLevel(this);

            // Start async operation to open the dialog.
            var files = await topLevel.StorageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions
            {
                Title = "选择路径",
                AllowMultiple = false
            });
            if (files.Count > 0)
            {
                string path = files[0].Path.ToString();
                TouchPath.Content = path.Substring(8, path.Length - 8);
            }
        }
        public void Enter(object sender, RoutedEventArgs args)
        {
            //Assembly.LoadFile(Path.Combine((string)CameraPath.Content, "Newtonsoft.Json.dll"));
        }
    }
}
