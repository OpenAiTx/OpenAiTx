# Right Click Windows Magic

Right Click Windows Magic is a set of right-click (context) menu tools for admins, power users and other magic beings. If you consider yourself a wizard and would like to save yourself some time and headaches, this is the *right* set of context menu tools for you.

This little magic pack includes:
- option to add the old context menu back in Windows 11
- robocopy for copying and moving directories (much faster than regular copy)
- robocopy also works for copying/moving across network shares
- pasting from clipboard (with robocopy)
- SCP from/to
- opening CMD or powershell windows into folders or drives
- running scripts as Administrator for .ps1 scripts
- taking ownership of files, or directories with recursion (takeown && icacls)
- options to boot into Safe Mode
- option to Reboot to Recovery
- opening Control Panel from Desktop
- running programs with custom priority
- option to always open cmd as admin
- creating symbolic/hard links
- opening "God Mode"
- rebooting/shutting down in x seconds
- options to MoveTo / SendTo folder (from Windows 7)
- signing out from desktop background
- opening GodMode
- options to uninstall the changes you've made
- disabling UAC
- enabling Long Paths (paths over 260 characters)

You can also remove some right-click menu options, so that your menu doesn't become too cluttered:
- Pin to Quick access
- Pin to Start Screen
- Include in Library
- Send To
- Share
- Add to Windows Media Player
- Scan with Windows Defender

Other removals:
- "Version" tab inside explorer


TODO (magic takes time):
- takeown for files (.exe and other)
- directory junctions for multiple files/folders
- pwsh opened with admin priv
- adding other admin tools to right click in background
- your suggestions


![Magic examples](https://raw.githubusercontent.com/GChuf/RCWM/magic/img/RCWM.gif)


# Installation


To install the tools: download the latest zip file under releases ([here](https://github.com/GChuf/RCWM/releases/latest)), unzip it and run the install.cmd script __as administrator__ - after that, you'll only need the two most abused keys: __*Y*__ and __*N*__ (and maybe a few others).
If the user running RCWM commands does not have administrator privileges, some magic might not work properly.


# How does it work?

Magic, basically. Some spaghetti code as well.

Right now, the magic happens inside the Windows registry with some help of batch and PowerShell scripting.

The goal was to automate command line tools like robocopy, so that 1) everybody could use it, and 2) it would save some time for those who already know how to use it. While automating the tasks, I've accidentally discovered that I could automate much more than what I thought - and so now, you can select multiple folders to copy/move and paste them all into one folder, just like you can with the regular, slow, lazy Windows GUI copy.


# RoboCopy: Copy and Move items options

Copy/Paste & Move File/Directory both use robocopy to do the work. 
You have two options: you can copy multiple or single directories at a time.

__Single__:
The file/folder (directory path) to be copied (when you right-click "Copy") is written into the registry and __overwrites__ any previous folder paths stored there. If you specify a new folder to be copied, the old one (if existing) will be overwritten.

__Multiple__:
The list of the file/folder paths to be copied is __appended__ to the registry under *HKCU:\SOFTWARE\RCWM\{rcopy || rcmov}* keys. Then the script goes through a PowerShell loop to copy all of them.

By default, you can only select up to 15 folders to be copied (the default Windows limit for right-click options is 15, you can increase it to 31 or more in the install script - see the *MultipleInvokeMinimum.reg* file for more info). Recursive copying/moving is also never a problem (you can have as many subfolders as you like).
Use this option if you intend to use RoboCopy a lot. You can read the rcp.ps1 powershell file to understand how the script works.

Copy (multiple) versus Move (single):

![Single vs Multiple](https://raw.githubusercontent.com/GChuf/RCWM/magic/img/sm.gif)

# RoboCopy: other options

You can also paste folders that you selected with ctrl+c. The option is called "Paste from clipboard.
Additionally, you can also use the mirroring option (/MIR) to mirror a directory. This only works, if you mirror the directory somewhere, where a directory with the same name already exists.

# Known bugs

- TakeOwn won't work properly when right-clicking on very large amounts of folders (some folders' permissions won't be changed - so you need to do it twice)?
Changing ownership of large amounts of recursive folders works fine though.
- Run with Priority won't show the menu to choose with which priority to run a program - please report if this happens to you
- rmdir and robocopy sometimes need admin privileges (robocopy throws error 5) - if you experience this, takeown or always running cmd as admin will help

# Tests
RoboCopy is much faster for copying a large amount of small files.
RmDir (del and rd) is also faster than "standard" delete, and than robocopy's /MIR option when using an empty directory.


Test results on my machine on an SSD disk:
Folder info: 1.73GB / 12 089 files
- rcopy/normal copy: 43s/91s
- rmdir/normal delete: ~ 3s/4.5s

Results may vary based on your computer and disk - but wherever there are lots of small files, you should benefit.

# Safety

RCWM v2 had some issues due to ps2exe script, and its output being flagged by antivirus softwares.
I've moved away from ps2exe now.

All .exe files are checked and marked safe by virus total (files are used to save folder paths into registry under HKCU):

[rcwm-single.exe](https://www.virustotal.com/gui/url/3f1d93268323b721b956ac7a015e80a68768fedf34adbbb022b660c06b7f2efb?nocache=1)


[rcwm-multiple.exe](https://www.virustotal.com/gui/url/bcf252d68d68198eb304682dc070f0bed0b14fa159add7e6766c3c41b1feff86?nocache=1)

[RCWMInit.exe](https://www.virustotal.com/gui/url-analysis/u-13bb952212b2d23dce18713803085437b31180b593acb4f4f2d13753269e2db3-21bd70f1?nocache=1)

# Contributing

You can always create a PR or open a new issue, regarding bugs or suggestions.

# Support

The aim of the project is to make life easier for others.

Starring the project helps them find out about it.

If you want, you can buy me a ~~coffee~~ beer:

- paypal.me: paypal.me/gchuf

- btc: 16BRUTbKu3tSuS9SudCoP7qHreNs6sAp8d

- eth: 0x75240bb1d3fac69954e980ec53d1c93a2d140389

- ltc: LWtm2gXdr29HhaiaXytnaz799RwYbxhz2d

# Credits

The files for Booting into Safe mode and Running with Priority were heavily influenced by Shawn Brink at [tenforums.com](https://www.tenforums.com/tutorials/1977-windows-10-tutorial-index.html)

The TakeOwn.reg files for Taking Ownership were heavily influenced by Vishal Gupta at [AskVG.com](https://www.askvg.com/) & Shawn Brink.

The Reboot to Recovery option was found somewhere on the internet a while ago. Unfortunately, I cannot remember who the original author is.

The Run script as Administrator idea was found here: https://ss64.com/ps/syntax-elevate.html

I changed and adapted all those files, but their ideas and the initial implementations deserve the credit.

Everything else is my own work, with the help of the Internet.

# Downloads

![Downloads](https://img.shields.io/github/downloads/GChuf/RCWM/total?label=TotalDownloads)

![Downloads-Latest](https://img.shields.io/github/downloads/GChuf/RCWM/latest/total?label=LatestReleaseDownloads)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-02

---