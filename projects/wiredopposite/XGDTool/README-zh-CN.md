# XGDTool
<img src="https://github.com/wiredopposite/XGDTool/blob/master/resources/Screenshot.png" alt="App" width="700"/>

XGDTool 是一款适用于OG Xbox和Xbox 360光盘的实用工具，能够在各种主流格式之间进行光盘转换。它提供GUI和CLI两种应用形式。

此程序仍处于初步测试阶段。如果您遇到问题，请在Issues标签中报告，帮助我们改进本程序！

## 功能特性
- 支持以下格式之间的转换：
    - ISO / XISO
    - 提取文件（Xex / Xbe / HDD Ready）
    - GoD / 按需游戏下载
    - CCI
    - CSO
    - ZAR
- 无缝转换，例如，您可以直接提取GoD镜像，将ISO转换为ZAR档案，或将提取目录转换为CCI档案，无需写入任何临时文件。唯一需要临时文件的格式是作为输入的ZAR。
- 镜像清理（“部分清理”），去除随机填充并将输出文件修剪到最短长度。
- 镜像重构（“完全清理”），完全重写光盘结构以获得尽可能小的输出文件。
- 镜像制作，使用您的提取文件创建新的镜像。
- CCI和CSO格式的多线程压缩。
- 批量处理，可以将一个文件夹中不同游戏格式批量转换为单一格式。
- 当仅提供一个部分作为输入路径时，自动查找分割文件，假设文件命名格式为：```name.1.extension``` ```name.2.extension```。
- 可选择目标应用/设备（Xemu、Xenia、OG Xbox、Xbox 360），让XGDTool自动决定使用的设置。
- 支持OG Xbox的XBE生成。
- 在线数据库查询以获得准确的文件命名（可禁用）。

## CLI 使用方法
```XGDTool.exe <output_format> <settings_flags> <input_path> <output_directory>```

or on Linux

```XGDTool <output_format> <settings_flags> <input_path> <output_directory>```
设置标志和输出目录是可选的。

### 输出格式参数（互斥）
- ```--extract```   将所有文件提取到一个目录
- ```--xiso```      创建一个 Xiso 镜像
- ```--god```       创建一个按需游戏（Games on Demand）镜像/目录结构
- ```--cci```       创建一个 CCI 归档（如果文件对 Xbox 来说过大，则自动拆分）
- ```--cso```       创建一个 CSO 归档（如果文件对 Xbox 来说过大，则自动拆分）
- ```--zar```       创建一个 ZAR 归档
- ```--xbe```       生成附加的 XBE 文件，不转换输入文件
- ```--ogxbox```    自动选择格式和设置以用于原版 Xbox
- ```--xbox360```   自动选择格式和设置以用于 Xbox 360
- ```--xemu```      自动选择格式和设置以用于 Xemu
- ```--xenia```     自动选择格式和设置以用于 Xenia

信息：
- ```--list```      列出输入文件的内容
- ```--version```   打印版本信息
- ```--help```      打印使用说明

### 设置标志
这些参数可以叠加使用，尽管不是所有输出格式都会使用它们，在那种情况下该选项会被忽略。如果提供了冲突的设置（例如全擦除/部分擦除），将使用最后一个设置。
- ```--partial-scrub```  擦除并修剪输出镜像，移除随机填充数据。
- ```--full-scrub```     完全重新制作生成的镜像，这将产生尽可能小的文件。
- ```--split```          如果生成的 XISO 文件对原版 Xbox 过大，则拆分它。
- ```--rename```         修补生成的 XBE 文件的标题字段为数据库中找到的名称。
- ```--attach-xbe```     生成一个附加的 XBE 文件与输出文件一起。
- ```--am-patch```       修补生成的 XBE 文件中的“允许媒体”字段。
- ```--offline```        禁用在线功能。
- ```--debug```          启用调试日志。
- ```--quiet```          禁用除警告和错误之外的所有日志。

## 构建
默认情况下，此项目编译为 GUI，使用 Cmake 配置时加上 ```-DENABLE_GUI=OFF``` 可编译为 CLI。要编译为 x86，需要对 CmakeLists.txt 和 cmake/setup_vcpkg.cmake 文件做一些更改以适应。

### Windows
如果你安装了 Cmake 和 MSVC，流程应该相当简单。该项目已为 Windows 设置，配置 Cmake 后会自动下载并使用 vcpkg 在项目目录内构建所有依赖项。根据你的网络速度和电脑性能，这可能需要一些时间，但只需执行一次。

克隆此仓库并创建一个构建目录


```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```
配置为图形用户界面（GUI）：  

```
cmake -S .. -B . -G "Visual Studio 17 2022" -A x64
``` 
或作为命令行接口（CLI）： 
```
cmake -S .. -B . -DENABLE_GUI=OFF -G "Visual Studio 17 2022" -A x64
```

构建
```
cmake --build . --config Release
```

### Linux
此应用程序尚未在Linux上进行广泛测试，Linux在wxWidgets上也有一些怪癖，因此GUI看起来不会完全如预期。它已使用Clang进行了测试，除了Clang、Make和Cmake之外，您还需要安装一些其他依赖项：
```
sudo apt update
sudo apt-get install pkg-config liblz4-dev libzstd-dev libssl-dev libcurl4-openssl-dev libwxgtk3.0-gtk3-dev
```
克隆此仓库并创建一个构建目录
```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```
配置为图形用户界面：
```
cmake ..
``` 
或作为命令行界面（CLI）： 
```
cmake -DENABLE_GUI=OFF ..
```
构建

```
make
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---