# Example of Databinding Part 2 (for 64bit)

Example of data binding in Ironpython script.  
The library of C# is used.

## File

* `example_databinding_main.py`
  * Run this file.
* `MyUtil.sln`
  * A class that implements INotifyPropertyChanged and ICommand.
  * `MyUtil` is a related folder.

## Notes on execution.

* Open `MyUtil.sln`, and build.
* Open `MyUtil_Ipy` folder with `Visual Studio Code` and execute it.
  * You need the `Python` extension created by Don Jayamanne.
* Edit `python.pythonPath` in` settings.json` in the `.vscod` folder to the appropriate path.

```
"python.pythonPath": "C:/IronPython27/ipy.exe"
```
