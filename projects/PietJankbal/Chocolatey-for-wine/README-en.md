
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Chocolatey package manager automatic installer in wine, convenient for quickly installing programs in wine (and subsequently finding bugs in wine ;) )  
Some bug workarounds are included, such as for Visual Studio Community 2022 and nodejs, see further below.  

During lock-down, out of boredom, I wrote a custom winetricks(.ps1) with verbs I find useful. Just run 'winetricks' to see them.
For some verbs, a full restart of wine is required (due to recent wine changes). You'll see a message box and the session will be terminated. Simply start powershell again and retry the verb. If this is done once, it won't be needed again for any verb.  

Example:  

'winetricks vs22_interactiveinstaller'  ( --> session will be ended)  

do 'wine powershell'  

do 'winetricks vs22_interactiveinstaller'  


(By the way, with 'winetricks vs22_interactive_installer' you can choose what to install via the Visual Studio 2022 installer; 'winetricks vs22_interactive_installer' now got me into the main program within ten minutes (selected Desktop development with C++)).

Install :
- Download and unzip the release zip-file and run 'wine ChoCinstaller_0.5c.751.exe' (takes about a minute to complete)

Optional:
- Run the installer like 'wine ChoCinstaller_0.5a.751.exe /s', then the install files (such as Powershell*.msi and dotnet48) are saved in
  MyDocuments and you won’t need to download them again if you create a new prefix)
Optional:
- Run the installer like 'wine ChoCinstaller_0.5a.751.exe /q' to prevent the automatic launch of the PowerShell window (so install only).

Optional:
- Check if everything went well: "choco install chromium" and "start chrome.exe (--no-sandbox is no longer needed as of wine-8.4)"

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
About PowerShell:

Tip: Chocolatey usually installs the latest version of a program, which might expose new wine bugs. You might have better luck with an older version of the software.  
Example:  

choco search --exact microsoft-edge --all (--> list all versions)  

choco install microsoft-edge --version --version='135.0.3179.98'

General info:

- 'wine powershell.exe' starts the PowerShell-Core console.

 
About ConEmu:

ConEmu console suffers from a few wine-bugs:
  - Ctrl^C to quit a program that doesn't return to the console doesn`t work. Use Shift^Ctrl^C instead.
  - Selecting text in the ConEmu window (for copy/paste) doesn't highlight the selection. Included is a very sad hack       against recent wine versions that works around this, so highlighting should just work now.
   
About winetricks(.ps1):

- If you don't call it ('winetricks' in powershell-console) , nothing gets downloaded so no overhead there. 
- A lot of verbs (like powershell 5.1) need a few essential files to extract stuff from msu packages. Installing these essential files requires first huge downloads , and  takes lots of time during 1st time usage. But after things are cached it goes quickly . For example if you might wanna try 'winetricks ps51' first, it will take about  approx. 15 minutes. Some other verbs might take 5 minutes on first time usage. But after you called a verb once this nuisance is gone.
- Files are cached in directory MyDocuments. If you call all verbs it'll take about 800 MB there.
- Hopefully some better 64-bit support for various verbs.
- Possibility to extract a file and (try) install from an msu file. Do 'winetricks install_dll_from_msu' to see how.
- A rudimentary Powershell 5.1.
- experimental dotnet481 installation, and dotnet35 (might be needed by apps not satisfied with current dotnet48 installation).
- Autotab-completion. Note: while using multiple verbs from command line they have to be seperated by a comma
  from now on (this is how powershell handles multiple arguments)
  So 'winetricks riched20 gdiplus' won't work anymore, use 'winetricks riched20,gdiplus' instead
- Some programs fail to install/run when you try them via Chocolatey due to wine-bugs. I added a few workarounds in winetricks for them, see below.
- Special verbs (winetricks vs19, vs22 and vs22_interactive_installer) to install working Visual Studio Community 2019 and 2022 (see screenshot, >10 mins to install and requires approx. 10GB!, after install start devenv.exe from directory c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Special verb to get access to various unix commands like grep,sed, file, less, curl etc. etc. (winetricks git.portable, Disclaimer: some commands do not yet work due to wine bugs
- Also included a few powershell scripts adapted from codesnippets found on the internet:
    - How to embed an exe in a powershell script via Invoke-ReflectivePEInjection (the exe won't show up in tasklist).
    - How to make fancy messageboxes
    - Convert a powershell script (ps1) into an exe.
    - And a few other
 
     
About system programs:

Feature is added to replace simple system programs like for example setx.exe by a function in
c:\\Program Files\Powershell\7\profile.ps1. Or add system programs that are missing like getmac.exe.
If programs fail because of insufficient mature or missing system programs one could write a 
function to return whatever the program expects. 
Like in profile.ps1 I added (amongst others) a wmic.exe that supports a bit more options,
and a basic setx.exe.
Or you could just manipulate the arguments passed to the system program. See profile.ps1 and choc_install.ps1.
No garantuee this works for more complex programs as well... 
 
Notes:

  - Do NOT use on an existing wineprefix, only on a freshly created new prefix! The installer simply installs dotnet48 itself and modifies registry keys.
    If you already have any dotnet version installed using the regular winetricks.sh, it will likely fail, and even if it succeeds, you'll probably end up with a broken prefix.
    If you need to install things with the regular winetricks.sh for programs, do NOT use any of the dotnet* verbs.
    BTW, the 'Arial' and 'd3dcompiler_47' verbs are already installed by default.
  - WINEARCH=win32 is _not_ supported!
  - Updating from a previous version is currently not (yet) supported, maybe later

Compile:
  - If you want to compile it yourself instead of downloading binaries: see the compilation instructions in mainv1.c and installer.c
  - Then copy choc_install.ps1 into the same directory
  - Then run 'wine ChoCinstaller_0.5a.735.exe'
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---