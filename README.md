# Example of Databinding Part 2

Example of data binding in Ironpython script.  
The library of C# is used.

## File

* `MyUtil_Ipy` folder.
  * There are IronPython script files.
  * Run this `example_databinding_main.py` file.
* `MyUtil.sln`
  * A class that implements INotifyPropertyChanged and ICommand. 
  * `MyUtil` is a related folder.

## Notes on execution.

* Open `MyUtil.sln`, and build.
* Open `MyUtil_Ipy` folder with `Visual Studio Code` and execute it.
  * You need the `Python` extension created by Don Jayamanne.
* Edit `python.pythonPath` in` settings.json` in the `.vscod` folder to the appropriate path.

```
"python.pythonPath": "C:/Program Files/IronPython 2.7/ipy.exe"
```
