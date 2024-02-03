using System;
using System.Reflection;
using VB = Microsoft.VisualBasic.ApplicationServices;

namespace Ara.SchematicVisualizer
{
  public class ApplicationSingleInstance : VB.WindowsFormsApplicationBase
  {
    private Application app;

    public ApplicationSingleInstance()
    {
      this.IsSingleInstance = true;
    }

    protected override bool OnStartup(VB.StartupEventArgs eventArgs)
		{
			app = new Application();
			var vmMain = new ViewModel.ApplicationViewModel();

			View.WindowMain winmain = new View.WindowMain()
				{
				// Title = "PFT v" + Assembly.GetExecutingAssembly().GetName().Version.ToString(),
				DataContext = vmMain
				};

			app.Run(winmain);
			return false;
		}

		protected override void OnStartupNextInstance(VB.StartupNextInstanceEventArgs eventArgs)
		{
			eventArgs.BringToForeground = true;
			app.MainWindow.Activate();
    }
  }
}
