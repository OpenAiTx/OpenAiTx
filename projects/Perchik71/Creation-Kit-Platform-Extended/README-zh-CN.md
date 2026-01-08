<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  一个为 Bethesda Creation Kit 提供的修改、增强和逆向工程资源的集合。
</p>

# 描述
**CKPE** 是一个共享源代码的强大平台，对 Bethesda 的 Creation Kit 编辑器进行了大量修复和改进，支持诸如 **Skyrim 特别版**、**辐射 4**、**星空** 等游戏的编辑器，是 [SSE CKFixes](https://github.com/Nukem9/skyrimse-test)、[SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest)、[FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) 项目的继任者，同时也是 [SSE CK 1.5.73 的 Unicode 补丁](https://github.com/Perchik71/usse_test) 的延续，该补丁是作者 **perchik71** 的起点。

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) 页面

# 依赖
[toml11](https://github.com/ToruNiina/toml11) 由 `ToruNiina` 等人维护  
[Zydis](https://github.com/zyantific/zydis.git) 由 `zyantifi` 等人维护  
[zipper](https://github.com/kuba--/zip.git) 由 `kuba--` 维护  
[libdeflate](https://github.com/ebiggers/libdeflate.git) 由 `ebiggers` 等人维护  
[xbyak](https://github.com/herumi/xbyak.git) 由 `herumi` 等人维护  
[DirectXTex](https://github.com/microsoft/DirectXTex.git) 由 `microsoft` 维护  
[jDialogs](https://github.com/Perchik71/jDialogs.git) 由 `perchik71` 维护 *(递归)*

# 安装
### 全新安装
下载任意 [支持的游戏](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) 并安装 Creation Kit。  
下载适用于你的游戏的 **CKPE** [最新版本](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases)。  
将所有内容解压到游戏目录，使 **ckpe_loader.exe** 与 **CreationKit.exe** 位于同一文件夹中。
### 更新
下载适用于你的游戏的 **CKPE** [最新版本](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases)。  
将所有内容解压到游戏目录，使 **ckpe_loader.exe** 与 **CreationKit.exe** 位于同一文件夹中。  
同意替换所有文件。
### 编译
普通用户只需此方法即可访问尚未发布的最新功能。  
在 **`Visual Studio 2022`** 或更高版本中打开项目。以 **`Release`** 模式或 **`Release-NoAVX2`** 模式构建项目。  
然后将编译输出移至游戏目录，使 **ckpe_loader.exe** 与 **CreationKit.exe** 位于同一文件夹中。  
如果提示替换旧文件，请同意替换所有文件。
### 自动构建（测试版）
下载适用于你的游戏的 **CKPE** [最新提交构建](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions)。  
将所有内容解压到游戏目录，使 **ckpe_loader.exe** 与 **CreationKit.exe** 位于同一文件夹中。  
可能出现错误。

# 致谢
[Nukem9](https://github.com/Nukem9)（提供实验性功能、哈希等，非常有用）  
[adzm](https://github.com/adzm)（非常感谢你的工作，你完成了我长期想做的事情 [done](https://github.com/adzm/win32-custom-menubar-aero-theme)）  
[yak3d](https://github.com/yak3d)（为工作流的贡献和开发以及支持最新的 Starfield）  
[Dio-Kyrie](https://github.com/Dio-Kyrie)（为 README 的设计）  

# 许可协议
从 v0.6 版本开始（提交 [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)）项目采用 [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html) 许可。<br />
早期版本采用 [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) 许可。<br />
版权所有 © 2023-2025 aka perchik71。保留所有权利。<br />
文件 `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` 包含专有且未授权的文件；同样适用于 `d3dcompiler\*.*` 中的文件。<br />
依赖项遵循各自的许可协议。 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-08

---