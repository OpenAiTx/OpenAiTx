# Samira

一个适用于 Linux 的 Steam 成就管理器

![example](https://raw.githubusercontent.com/jsnli/Samira/master/./assets/screenshot.png)

## 描述
Samira 是一个桌面应用程序，允许您解锁成就和设置统计数据。  

## 安装与使用
发行版可在[此处](https://github.com/jsnli/Samira/releases)找到。

必须运行 Steam 并且用户必须已登录。

不支持 Flatpak。Steam 必须通过您的发行版包管理器安装，或通过官方[Steam 页面](https://store.steampowered.com/about/)的安装程序安装。

## 构建

构建此项目需要 Tauri 的[先决条件](https://tauri.app/start/prerequisites/)，以及 Rust、Node 和 npm。

克隆仓库并安装： 
```
cd Samira && npm install
```
Tauri 不会自动设置库搜索路径。这是 Tauri 中的一个已知问题，在官方修复之前，我们需要自己设置：

```
export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:/usr/lib/libsteam_api.so
```

The `libsteam_api.so` file is available in `/assets/`.

**Dev**
```
npm run tauri dev
```

**构建**
```
npm run tauri build
```

在基于 Arch 的发行版上，由于 Tauri 和 linuxdeploy 使用了错误的 `strip` 二进制文件，可能会发生打包错误。一个解决方法是：
```
NO_STRIP=true npm run tauri build
```

## 贡献
与其前身一样，Samira 是开源的，欢迎贡献。请随时提问、提交拉取请求和提出问题。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---