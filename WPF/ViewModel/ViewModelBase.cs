using System;
using System.ComponentModel;

namespace Ara.SchematicVisualizer.ViewModel
	{
	public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
		{
		protected ViewModelBase()
			{
			}

		public virtual string DisplayName { get; protected set; }

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(String propertyname)
			{
			PropertyChangedEventHandler handler = this.PropertyChanged;

			if (handler != null)
				{
				var e = new PropertyChangedEventArgs(propertyname);
				handler(this, e);
				}
			}

		public void Dispose()
			{ this.OnDispose(); }

		protected virtual void OnDispose()
			{
			}
		}
	}
