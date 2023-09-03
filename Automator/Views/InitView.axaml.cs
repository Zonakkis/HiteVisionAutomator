using Automator.Models;
using Automator.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Dialogs;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using MsBox.Avalonia;
using MsBox.Avalonia.Dto;
using MsBox.Avalonia.Enums;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
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
        public async void Enter(object sender, RoutedEventArgs args)
        {
            
            Debug.WriteLine(Process.GetCurrentProcess().ProcessName);
            if(string.IsNullOrEmpty((string?)CameraPath.Content))
            {
                var box = MessageBoxManager
             .GetMessageBoxStandard("未选择", "展台路径未选择。",
                 ButtonEnum.Ok);
                await box.ShowAsync();
                return;
            }
            if (string.IsNullOrEmpty((string?)TouchPath.Content))
            {
                var box = MessageBoxManager
             .GetMessageBoxStandard("未选择", "白板路径未选择。",
                 ButtonEnum.Ok);
                await box.ShowAsync();
                return;
            }
            Storage.Save(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "Settings.json", ((InitViewModel)DataContext).Setting);
            Process p = new Process();
            p.StartInfo.FileName = $"{System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + Process.GetCurrentProcess().ProcessName}.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.Arguments = "Restart";
            p.Start();
            Environment.Exit(0);
        }
    }
}
