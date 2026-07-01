

<img width="1920" height="1080" alt="renut logo" src="https://github.com/user-attachments/assets/273bee28-755f-4494-920f-9333af72091e" />




Originally created with <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a>



DISCORD
--------------------------------------------
We have a discord, please join and direct any questions there. Myself or someone else will happily answer them.

https://discord.gg/D5Bz2ZsHdY



Credits
------------------------------------------------
<a href="https://github.com/rexglue/rexglue-sdk">Rexglue team</a> for creating Rexglue-SDK
<br>
the Rexglue SDK discord for helping with any info they have
<br>
SolarCookies for midasm hooks and future use of CRT functions and the reNut Launcher
<br>
ValcomDrifty for the renut logo
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
you, the player?
<br>
.


REQUIREMENTS
-------------------------------------------------------------------
US version of banjo-kazooie: nuts and bolts default.xex


HOW TO BUILD
------------------------------------------------------
NOTE: YOU MUST DELETE ALL INSTANCES OF .gitignore OTHERWISE WHATEVER YOU COMPILE WITH WONT SEE THE FILES IN THE AREAS THEY ARE IN.
<br>
NOTE: YOU MUST INSTALL <a href="https://git-scm.com/install/windows">GIT</a> BEFORE INSTALLING THE REXGLUE-SDK, OR BUILDING THIS REPO.
<br>
NOTE: NOTE: YOU MUST BUILD AND INSTALL THE MAIN REPO OF <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a> BEFORE CONTINUING


1. Clone the repository with ```git clone https://github.com/masterspike52/reNut.git```
2. Inside the assets folder you need to extract your banjo-kazooie: Nuts&Bolts iso's contents and the default.xex. I reccomend using <a href="https://consolemods.org/wiki/images/5/5f/XBOX360_ISO_Extract.zip">iso extract</a>. (I don't know what linux users use. I use Windows, however iso extract does work on linux through WINE.)
3. Inside your cloned git open a terminal and run ```rexglue migrate --app_root .``` This ensures that if anything with codegen changes on Rexglue, you can codegen properly.
   3b. You must then either delete your out folder, or if your on Windows you can open VS, right click your cmakelists.txt, and delete cache and reconfigure so you codegen with the version your using.
4. You can now open a terminal and run ```rexglue codegen renut_config.toml``` which will give you the ppc files to recompile in the generated folder.
5. If you're on Windows, you can open the project in VS, change the build type to `win-amd64-relwithdebinfo`, then build all.
   5b. If you're on Linux, and don't have access to VS, you will need to use a terminal and run ```cmake --preset linux-amd64-relwithdebinfo``` and then ```cmake --build --preset linux-amd64-relwithdebinfo```. (You can do this on Windows as well, just replace `linux` with `windows`.)
6. Once its compiled, you need to have the built exe in the same directory as the assets, otherwise the game won't open.

THERES A LINUX FORK
-------------------------------------------------
if you wish to build for linux please use this fork of <a href="https://github.com/etonedemid/reNut">reNut</a> made by etonedemid it requires using his fork of <a href="https://github.com/etonedemid/rexglue-sdk">rexlgue</a> and he has made a pr to rexglue so this stuff becomes part of main. 


IF YOU DONT WANT TO BUILD
--------------------------------------------
Building is mainly for those who either would rather build or want to help develop the game with myself and others. If you don't want to build;
* Go to https://goopie.xyz/ and download the goopie launcher 
* In the launcher select banjo-kazooie: nuts and bolts
* Click Select ISO and select your iso for banjo-kazooie: nuts and bolts (must be the north american release) and wait for extraction to finish
* After extraction is finished click the update button, the launcher will then download the latest release of the windows version of renut
* Click play




KNOWN ISSUES
-----------------------------------------------
1. Animations are a little jank (there's jitter, banjo's and others bones break, some of the animations are half done, and some other little ancillaries) but they do not inhibit gameplay, it's just funny to see happen.


MAKING AN ISSUE
--------------------------
The Issues tab is a place for things like crashes that happen in game that arent already noted, please refrain from making issues like "Game wont open" or "Have to use ISOs?".
You must use the crash template for any issues that pertain to crashes (I'll probably make other templates), for I don't need it flooded with mostly user error posts. Please join the discord and use the #help channel if you have an issue unrelated to a crash.
