# Startup-Roblox-Multi-Instance
Roblox Multi-Instance but for startup. See [Roblox Multi-Instance](https://github.com/MiningTcup/Roblox-Multi-Instance). Instructions in [release](https://github.com/MiningTcup/Startup-Roblox-Multi-Instance/releases/tag/v1.0). Note that antiviruses will ding this even more than the original because of the following code.
```c#
[DllImport("kernel32.dll")]
static extern IntPtr GetConsoleWindow();
[DllImport("user32.dll")]
static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
const int SW_HIDE = 0;
var handle = GetConsoleWindow();
ShowWindow(handle, SW_HIDE);
```
