# example_databinding (Part 2)

Example of data binding in Ironpython script.  
The library of C# is used.

## File

* `example_databinding_main.py`
  * Run this file.
* `example_databinding_view.xaml`
  * View of MVVM.
* `example_databinding_viewmodel.py`
  * ViewModel of MVVM.
* `MyUtil.sln`
  * A class that implements INotifyPropertyChanged and ICommand. 
  * `MyUtil` is a related folder.

## Notes on execution.

1. Open `MyUtil.sln`, and build.
1. Open `MyUtil_Ipy` folder with `Visual Studio Code` and execute it.
  * You need the `Python` extension created by Don Jayamanne.
1. Edit `python.pythonPath` in` settings.json` in the `.vscod` folder to the appropriate path.

```
"python.pythonPath": "C:/Program Files/IronPython 2.7/ipy.exe"
```
