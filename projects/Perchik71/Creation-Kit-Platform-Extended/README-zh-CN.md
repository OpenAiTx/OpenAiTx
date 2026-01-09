
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  贝塞斯达 Creation Kit 的一系列修改、增强和逆向工程资源。
</p>

# 描述
**CKPE** 是一个共享源代码的强大平台，对 **Bethesda** 的 Creation Kit 编辑器进行了大量修复和改进，支持如 **Skyrim Special Edition**、**Fallout 4**、**Starfield** 等游戏的编辑器，是 [SSE CKFixes](https://github.com/Nukem9/skyrimse-test)、[SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest)、[FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) 项目的继任者，同时也是 [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test)（作者 **perchik71** 的起点）项目的延续。  

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) 页面  

# 依赖项
[toml11](https://github.com/ToruNiina/toml11) 由 `ToruNiina` 等人开发  
[Zydis](https://github.com/zyantific/zydis.git) 由 `zyantifi` 等人开发  
[zipper](https://github.com/kuba--/zip.git) 由 `kuba--` 开发  
[libdeflate](https://github.com/ebiggers/libdeflate.git) 由 `ebiggers` 等人开发  
[xbyak](https://github.com/herumi/xbyak.git) 由 `herumi` 等人开发    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) 由 `microsoft` 开发  
[jDialogs](https://github.com/Perchik71/jDialogs.git) 由 `perchik71` *(递归)*

# 安装
### 全新安装
下载任意 [支持的游戏](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) 并安装 Creation Kit。  
下载适用于你的游戏的 [最新版本](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) **CKPE**。  
将所有内容解压到游戏目录下，确保 **ckpe_loader.exe** 与 **CreationKit.exe** 位于同一文件夹。  
### 更新
下载适用于你的游戏的 [最新版本](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) **CKPE**。  
将所有内容解压到游戏目录下，确保 **ckpe_loader.exe** 与 **CreationKit.exe** 位于同一文件夹。  
同意替换所有文件。  
### 编译
普通用户仅在需要访问尚未发布的新功能时才需使用此方法。  
在 **`Visual Studio 2022`** 或更高版本中打开项目。以 **`Release`** 或 **`Release-NoAVX2`** 模式编译项目。  
然后将你的编译输出移动到游戏目录下，确保 **ckpe_loader.exe** 与 **CreationKit.exe** 位于同一文件夹。  
如果提示你替换旧文件，请同意替换所有。  
### 自动化构建 (Beta)
下载适用于你的游戏的 [最新提交构建](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) **CKPE**。  
将所有内容解压到游戏目录下，确保 **ckpe_loader.exe** 与 **CreationKit.exe** 位于同一文件夹。  
可能出现错误。  

# 鸣谢
[Nukem9](https://github.com/Nukem9) （实验功能、哈希等，非常有用）  
[adzm](https://github.com/adzm) （非常感谢你的工作，你已经 [完成](https://github.com/adzm/win32-custom-menubar-aero-theme) 了我一直想自己做的事情）  
[yak3d](https://github.com/yak3d) （对工作流的贡献、开发及对最新 Starfield 的支持）  
[Dio-Kyrie](https://github.com/Dio-Kyrie) （对 readme 的设计贡献）  

# 许可协议
从 v0.6（提交 [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)）开始，项目采用 [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html) 许可。 <br />
早期版本由 [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) 许可 <br />
版权所有 © 2023-2025 aka perchik71。保留所有权利。<br />
文件 `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` 包含专有且未授权文件；`d3dcompiler\*.*` 下的文件同样如此。<br />
依赖项遵循各自的许可协议。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---