# CarCopy
A LinqPad script for copying files in alphabetical order. I use it to copy music to a flash drive for my car, which makes sure the tracks play in the correct order.

## Usage

The destination path is hard-coded in the script, so you might want to change it for your purposes. Yes, it should probably be passed as an argument instead - I'll fix it later.

The script can be invoked directly if you have LinqPad's LPRun installed. For easy use, you can add a context menu item to invoke it for a folder by adding the following registry key:
```
[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Directory\shell\CopyToFlash\command]
@="\"C:\\Program Files (x86)\\LINQPad5\\LPRun.exe\" \"C:\\PathToThisRepo\\CarCopy.linq\" \"%1\""
```

## Future work

Pass the destination as a command line argument instead of hard-coding.

The script is designed to handle cases it will never face when used from the context menu. There will never be a list of sources, only one, and that functionality hasn't been tested, so may as well remove it.