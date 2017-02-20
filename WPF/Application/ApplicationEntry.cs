using System;

namespace Ara.SchematicVisualizer
	{
	class ApplicationEntry
		{
		[STAThread]
		public static void Main(String[] args)
			{
			ApplicationSingleInstance singleinstanceapp = new ApplicationSingleInstance();
			singleinstanceapp.Run(args);
			}
		}
	}