using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RechatTool_GUI
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string input = CreateInputString();
			ExcuteCMD(input);

		}

		private string CreateInputString()
		{
			string url = vodURL.Text;
			int vodIndex = url.LastIndexOf('/');
			
			string vodID = url.Substring(vodIndex + 1);

			string command = "RechatTool.exe -D ";
			command += vodID;

			if (ovewriteVodID.IsChecked == true)
				command += " -o";

			//if (FileName.Text.Length > 0)
			//{
			//	command += " -p " + FileName.Text;
			//
			//	if (ovewritefileName.IsChecked == true)
			//		command += " -o";
			//
			//	if (showUserBadge.IsChecked == true)
			//		command += " -b";
			//}

			return command;
		}

		private void ExcuteCMD(string input)
		{
			ProcessStartInfo info = new ProcessStartInfo();
			Process process = new Process();

			info.FileName = "cmd.exe";
			info.CreateNoWindow = false;
			info.UseShellExecute = false;

			info.RedirectStandardInput = true;
			info.RedirectStandardOutput = true;
			info.RedirectStandardError = true;

			process.StartInfo = info;
			process.Start();

			process.StandardInput.Write(input + Environment.NewLine);
			process.StandardInput.Close();

			string result = process.StandardOutput.ReadToEnd();

			process.WaitForExit();
			MessageBox.Show(result);
			process.Close();

		}
	}
}
