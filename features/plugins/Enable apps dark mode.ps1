###This script will enable app dark mode for all Windows 11 apps supporting this theme mode (including ThisIsWin11).
# Just some test...
Set-ItemProperty -Path HKCU:\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize -Name AppsUseLightTheme -Value 0 -Type Dword -Force
$dir = ls "$PsScriptRoot\..\"

[System.Windows.Forms.MessageBox]::Show("App dark mode has been enabled.`nThisIsWin11 requires a restart for the changes to take effect.","Dark mode",0)
If (!(Get-Process -Name ThisIsWin11.exe -ErrorAction SilentlyContinue))
{Stop-Process -Name "ThisIsWin11" -Force
}




