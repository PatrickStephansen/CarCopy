# CarCopy
A LinqPad script for copying files in alphabetical order. I use it to copy music to a flash drive for my car, which makes sure the tracks play in the correct order.

##Usage
The script can be invoked directly if you have LinqPad's LPRun installed. For easy use, you can add a context menu item to invoke it for a folder by adding the following registry key:
```
[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Directory\shell\CopyToFlash\command]
@="\"C:\\Program Files (x86)\\LINQPad5\\LPRun.exe\" \"C:\\PathToThisRepo\\CarCopy.linq\" \"%1\""
```