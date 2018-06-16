using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// user add
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyUtil
{
    /// <summary> 
    /// A class that implements INotifyPropertyChanged. 
    /// <para>https://github.com/dokeep/csharp-bindablebase</para>
    /// </summary>
    ///
     
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            return SetProperty(ref field, value, null, propertyName);
        }

        protected virtual bool SetProperty<T>(ref T field, T value, Action onChanged, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
