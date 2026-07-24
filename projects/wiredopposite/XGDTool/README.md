# XGDTool
<img src="https://github.com/wiredopposite/XGDTool/blob/master/resources/Screenshot.png" alt="App" width="700"/>

XGDTool is an OG Xbox and Xbox 360 disc utility, capable of converting discs to and from any mainstream format. It's available as a GUI or CLI app.

This program is still in initial testing. If you experience an issue, please report it in the Issues tab and help make this program better!

## Features
- Supports convertion between following formats:
    - ISO / XISO
    - Extracted files (Xex / Xbe / HDD Ready)
    - GoD / Games on Demand
    - CCI
    - CSO
    - ZAR
- Seamless conversion, e.g. you can directly extract a GoD image, convert an ISO to ZAR archive, or extracted directory to CCI archive, without writing any temporary files. The only format requiring temporary files is ZAR when provided as input.
- Image scrubbing ("Partial Scrub"), gets rid of random padding and trims the output file to the shortest length possible.
- Image reauthoring ("Full Scrub"), completely rewrites the structure of the disc for the smallest possible output file.
- Image authoring, takes your extracted files and creates a new image with them.
- Multithreaded compression for CCI and CSO formats.
- Batch processing, a folder full of different game formats can be batch converted to a single format.
- Automatically finds split files when only one part is provided as an input path, assuming they're named in this format: ```name.1.extension``` ```name.2.extension```.
- Option to select your target app/machine (Xemu, Xenia, OG Xbox, Xbox 360) and let XGDTool decide which settings to use.
- Attach XBE generation for OG Xbox.
- Online database lookup for accurate file naming (can be disabled).

## CLI Usage
```XGDTool.exe <output_format> <settings_flags> <input_path> <output_directory>```

or on Linux

```XGDTool <output_format> <settings_flags> <input_path> <output_directory>```

Settings flags and output directory are optional.

### Output format arguments (mutually exclusive)
- ```--extract```   Extracts all files to a directory
- ```--xiso```      Creates an Xiso image
- ```--god```       Creates a Games on Demand image/directory structure
- ```--cci```       Creates a CCI archive (automatically split if too large for Xbox)
- ```--cso```       Creates a CSO archive (automatically split if too large for Xbox)
- ```--zar```       Creates a ZAR archive
- ```--xbe```       Generates an attach XBE file, does not convert the input file
- ```--ogxbox```    Automatically choose format and settings for use with OG Xbox
- ```--xbox360```   Automatically choose format and settings for use with Xbox 360
- ```--xemu```      Automatically choose format and settings for use with Xemu
- ```--xenia```     Automatically choose format and settings for use with Xenia

Information:
- ```--list```      List contents of input file
- ```--version```   Print version information
- ```--help```      Print usage information

### Settings flags
These arguments can be stacked, though not all output formats will use them, in that case the option is ignored. If any conflicting settings are provided (e.g. full/partial scrub), the last one will be used. 
- ```--partial-scrub```  Scrubs and trims the output image, random padding data is removed.
- ```--full-scrub```     Completely reauthor the resulting image, this will produce the smallest file possible.
- ```--split```          Splits the resulting XISO file if it's too large for OG Xbox.
- ```--rename```         Patches the title field of resulting XBE files to one found in the database.
- ```--attach-xbe```     Generates an attach XBE file along with the output file.
- ```--am-patch```       Patches the "Allowed Media" field in resulting XBE files.
- ```--offline```        Disables online functionality.
- ```--debug```          Enable debug logging.
- ```--quiet```          Disable all logging except for warnings and errors.

## Build
By default this compiles as a GUI, configure Cmake with ```-DENABLE_GUI=OFF``` to compile for CLI. To compile for x86 there would need to be several changes made to the CmakeLists.txt and cmake/seutp_vcpkg.cmake files to accound for that.

### Windows
If you have Cmake and MSVC installed, things should be fairly simple. The project has been setup for Windows so that it will automatically download and build all dependancies with vcpkg inside the project directory by configuring with Cmake. This can take a while depending on your internet speeds and PC specs but only has to happen once.

Clone this repo and make a build directory

```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```

Configure as GUI: 
```
cmake -S .. -B . -G "Visual Studio 17 2022" -A x64
``` 
or as CLI: 
```
cmake -S .. -B . -DENABLE_GUI=OFF -G "Visual Studio 17 2022" -A x64
```

Build
```
cmake --build . --config Release
```

### Linux
This app has not yet been tested extensively for Linux, Linux also has some quirks with wxWidgets so the GUI doesn't look exactly as it should. It's been tested with Clang, in addition to Clang, Make, and Cmake, you'll need to install some other dependancies:
```
sudo apt update
sudo apt-get install pkg-config liblz4-dev libzstd-dev libssl-dev libcurl4-openssl-dev libwxgtk3.0-gtk3-dev
```
Clone this repo and make a build directory
```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```
Configure as GUI: 
```
cmake ..
``` 
or as CLI: 
```
cmake -DENABLE_GUI=OFF ..
```

Build
```
make
```
