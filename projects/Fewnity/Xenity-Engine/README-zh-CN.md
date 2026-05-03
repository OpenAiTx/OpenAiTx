# Xenity 引擎

Xenity 引擎是一款基于游戏对象和组件的跨平台游戏引擎，支持 PlayStation Portable、PsVita、PS3 及 Windows。

[Xenity 脚本文档](https://fewnity.github.io/Xenity-Engine/script_api_reference/scripting_api_reference.html)

我计划开发一个新引擎，以解决本引擎的大部分重大问题。<br>
所以我可能不会为本引擎添加新功能。<br>
但仍欢迎提交拉取请求，新功能、重构、错误修复、优化或改进文档，任何都欢迎！
如果你想改进引擎，这里有[待办事项列表](https://github.com/Fewnity/Xenity-Engine/blob/crossplatform/TODO.md)。

![image](https://github.com/Fewnity/Xenity-Engine/assets/39272935/df59e12e-b989-4b0d-93b1-4f95fac7c91f)

![gif](https://github.com/user-attachments/assets/7568e868-e41c-4495-bde7-56bb7b6bc54d)

[游戏样例](https://fewnity.github.io/Xenity-Engine/game_project_samples/game_project_samples.html) 可供下载！

### 支持的平台：<br>
✔️ 支持<br>
🚧 开发中<br>

| 状态 | 平台 |
|-|-|
✔️ | Windows
✔️ | PlayStation Portable
✔️ | PlayStation Vita
✔️ | PlayStation 3
🚧 | Linux（界面有些小问题，缺少音频和构建系统）

功能：

- [X] 基础 2D
- [X] 基础 3D
- [X] 2D 音频
- [ ] 3D 音频
- [X] 天空盒
- [X] 场景
- [ ] 动画
- [X] 3D 物理
- [ ] 2D 物理
- [X] C++ 热重载

> [!WARNING]
> 引擎并不完美。因此在游戏开发过程中你可能会遇到以下问题：
> - 删除 Meta 文件会对你的项目产生影响。引用这些文件的变量将被清空。
> - 复制 Meta 文件会导致问题，每个 Meta 文件中都有一个唯一的文件 ID。
> - 音频在 44100Hz 下“正常”工作，但在 PS3 上需要使用 48000Hz 的音频。

> [!NOTE]
> 如果你想在编辑器中编译游戏，必须在“引擎设置”菜单（Window->Engine Settings）中设置 `Compiler path`。<br>
> `Compiler path` 默认是 `C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build`，如果你的 Visual Studio 安装路径/版本不同，请更改此路径。<br>
> 你可以为 PSP 构建设置“Build And Run”的 `PPSSPP location`。

## 如何使用编辑器
### 如何在编辑器中运行游戏
- 在“Game->Compile Game”中编译游戏
- 点击播放按钮
### 如何构建游戏
- 打开“File->Build Settings”中的构建设置菜单
- 选择平台
- 点击构建
（对于 PSP、PS3 和 PS Vita，你需要安装并配置 Docker Desktop）。

## Docker 设置
编译 PSP、PS3 和 PS Vita 游戏需要 Docker Desktop。<br>
下载 Docker Desktop：https://www.docker.com/products/docker-desktop/

然后在 Xenity 中完成 Docker 安装。进入“Window->Docker Configuration”，该过程可能需要几分钟，特别是如果你的电脑或网络较慢时。（编辑器将会卡顿）。

## 兼容文件
图片：`.png .jpg .bmp, .tga`

音频：`.wav .mp3`（请使用 44100Hz 音频，PS3 除外，必须使用 48000Hz 音频）

网格：`.obj .fbx`

字体：`.ttf`

## 如何在 Visual Studio 中编译引擎
- 设置项目 `Xenity_Engine_Executable` 为启动项目。
- 先编译 `Engine` 配置，然后编译 `Editor` 以生成所有 dll 文件。

## 引擎内部工作原理

当加载一个项目/游戏时，引擎会列出所有现有文件。每个文件都有一个唯一的 Id。  
像 `Texture`、`Audio Clip`、`Mesh Data` 等原本就是文件的类，继承自 `File Reference`，以便指向它们的文件。

一些类如 `Component`、`GameObject`、`Vector3` 等，继承自 `Reflective`。这允许在不知道基类的情况下访问它们的变量。  
这被 Inspector 用来查看和修改数据，也用于将它们的数据保存到/从文件加载。

## 联系方式  
如果需要帮助，可以打开 Issue 或联系我。

邮箱: `fewnity@gmail.com`<br>
Discord: `fewnity`

## 许可证

本仓库代码采用 MIT 许可证。

## 游戏主机 SDK

https://github.com/Fewnity/Xenity-Engine-SDK

## 使用的库
Stb（使用版本：stb_image 2.23（更新版本不支持 PSP），stb_image_resize 0.97，stb_image_write 1.16）：https://github.com/nothings/stb

drmp3 v0.6.40 & drwav v0.13.17：https://github.com/mackron/dr_libs

JSON for Modern C++ v3.11.3：https://github.com/nlohmann/json

GLM（为 PS2 稍作修改）：https://github.com/g-truc/glm

Bullet 2.82（稍作修改以修复编译）：https://code.google.com/archive/p/bullet/downloads

### Windows 特定：
Assimp (79d451b)：https://github.com/assimp/assimp/
<br>`cmake CMakeLists.txt -DASSIMP_BUILD_ZLIB=ON -DASSIMP_NO_EXPORT=ON -DASSIMP_BUILD_ALL_EXPORTERS_BY_DEFAULT=OFF -DASSIMP_BUILD_TESTS=OFF -DASSIMP_BUILD_ASSIMP_VIEW=OFF -DASSIMP_INJECT_DEBUG_POSTFIX=OFF -DASSIMP_INSTALL=OFF -DASSIMP_BUILD_ALL_IMPORTERS_BY_DEFAULT=OFF -DASSIMP_BUILD_OBJ_IMPORTER=ON -DASSIMP_BUILD_FBX_IMPORTER=ON -DCMAKE_BUILD_TYPE=Release`
`cmake --build . --config Release`

FreeType (v2.13.2)：https://github.com/ubawurinna/freetype-windows-binaries/

ImGui Docking 分支 (1.91.8 WIP): https://github.com/ocornut/imgui

SDL (3.2): https://github.com/libsdl-org/SDL

Glad v2.0.8 (gl 4.6 兼容模式): https://gen.glad.sh/

### PsVita 专用: 
VitaGL (029ddbe): (编译时启用 HAVE_GLSL_SUPPORT=1 标志，发布版为 NO_DEBUG=1，调试版为 HAVE_SHARK_LOG=1 LOG_ERRORS=2) https://github.com/Rinnegatamante/vitaGL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-03

---