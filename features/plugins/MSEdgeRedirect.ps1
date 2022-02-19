###This will download and run a third-party utility with a GUI whichs allows you to redirect News, Search, Widgets, Weather and more to your default Browser.###
###Projects page: https://github.com/rcmaehl/MSEdgeRedirect###

(new-object net.webclient).DownloadFile('https://github.com/rcmaehl/MSEdgeRedirect/releases/download/0.6.1.0/MSEdgeRedirect.exe',"./MSEdgeRedirect.exe")
Start-Process -Filepath "./MSEdgeRedirect.exe"

###Requires -RunSilent