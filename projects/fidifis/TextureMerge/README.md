# TextureMerge

[![GitHub latest release version](https://img.shields.io/github/v/release/Fidifis/TextureMerge.svg?style=flat)](https://github.com/Fidifis/TextureMerge/releases/latest)
[![Github All Releases download count](https://img.shields.io/github/downloads/Fidifis/TextureMerge/total.svg?style=flat)](https://github.com/Fidifis/TextureMerge/releases/latest)

[![Main](https://github.com/Fidifis/TextureMerge/actions/workflows/main.yml/badge.svg)](https://github.com/Fidifis/TextureMerge/actions/workflows/main.yml)
[![CodeQL](https://github.com/Fidifis/TextureMerge/actions/workflows/codeql.yml/badge.svg)](https://github.com/Fidifis/TextureMerge/actions/workflows/codeql.yml)

## Software to merge or pack textures into image channels, producing one image with up to four textures.

this program is ideal if you want to pack individual grayscale textures in one image.

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img1.jpg)

## Requirements
To run this program you need [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48) (installed by default on most windows computers)

## Usage
1. Download the software from [releases](https://github.com/Fidifis/TextureMerge/releases) \
*Install it using setup or extract the zip folder*
2. Open TextureMerge.exe
3. Click load under the color channel into which you want to insert texture.\
**You can also *drag and drop* files into the slots.**

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img2.jpg)

4. The Windows dialog appears. Select the texture and click open.

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img3.jpg)

5. Repeat for other textures. Empty channels will be black or you can change it to white (the alpha channel will not be added if no image provided).
6. When you are done click Merge.

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img4.jpg)

7. The Windows dialog appears. Enter a file name and click save.

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img5.jpg)


## You now have textures packed

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img6.jpg)


## Example of use in Unreal Engine
![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img7.jpg)

## Questions
If you have any questions, suggestions or something don't work, create [issue](https://github.com/Fidifis/TextureMerge/issues).
