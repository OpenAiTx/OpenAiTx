# Plasma6 着色器壁纸插件

**着色器壁纸** 是一个 Plasma6 壁纸插件，支持为 KDE 桌面提供动态的着色器驱动壁纸。

---

> **Plasma5 用户注意：**\
> 请参考 [Plasma5 分支](https://github.com/y4my4my4m/kde-shader-wallpaper/tree/plasma5) 以获得兼容性支持。

---

## 功能

- 运行自定义着色器作为桌面壁纸
- 简单的安装、升级和卸载
- 完全支持 Plasma6
- 持续开发，频繁更新功能和修复错误

### 备注

以下是一些适合 OLED 的友好着色器：
```
Grey_Liquid
HSV_to_RGB
RGB_Noise_in_Movement
Raymarching_Basic
VDJ.frag
Wiggle_Worm
```
---

## 安装

### 从源码安装

1. **克隆仓库：**

   ```bash
   git clone https://github.com/y4my4my4m/kde-shader-wallpaper.git
   ```

2. **移除任何之前的安装：**

   ```bash
   rm -rf ~/.local/share/plasma/wallpapers/online.knowmad.shaderwallpaper/
   ```

3. **安装软件包：**

   ```bash
   kpackagetool6 -t Plasma/Wallpaper -i kde-shader-wallpaper/package
   ```

### 升级

```bash
kpackagetool6 -t Plasma/Wallpaper --upgrade kde-shader-wallpaper/package
```

### 卸载

您可以通过 KDE 桌面设置卸载，或运行：

```bash
kpackagetool6 -t Plasma/Wallpaper --remove online.knowmad.shaderwallpaper
```

---

## 开发者指南

要创建自定义着色器或贡献代码，请阅读[开发者指南](https://raw.githubusercontent.com/y4my4my4m/kde-shader-wallpaper/master/README_DEV.md)。

---

## 仓库及支持

- **GitHub:** [y4my4my4m/kde-shader-wallpaper](https://github.com/y4my4my4m/kde-shader-wallpaper)
- **KDE 商店:** [Plasma6 版本](https://store.kde.org/p/2143912)
- **KDE 商店:** [Plasma5 版本](https://store.kde.org/p/1413010/)
- **Twitter (X):** [@y4my4my4m](https://twitter.com/y4my4my4m)

如有问题、拉取请求或一般咨询，请通过[GitHub Issues](https://github.com/y4my4my4m/kde-shader-wallpaper/issues)或Twitter联系。

---

## 注意事项

- 基于 GUI 的着色器自定义将在未来版本中回归。
- 由于着色器编译要求，Plasma6 版本当前不支持 Shadertoy.com 导入。
- 性能可能因硬件和着色器复杂度而异，但大多数着色器资源效率高。
- 编辑着色器文件后，请重启 KDE Wallpaper QtQuick 应用（`pkill plasmashell` 并重启）。

---

## 视频：

### v1.2 在 VirtualBox 中使用 iGPU（和 kvantum）：

[![ShaderWallpaperVideoPreviewV1.2](https://cdn-cf-east.streamable.com/image/1g7muc_first.jpg?Expires=1599641820&Signature=kBzPch9XeiD3AieRh4sXd84JdQIknV2KK1m~w7KtXcO-5LH~JCeG8Wngq2p45Z521BWfd2jxpaujTV3618h91u4EnBSzMDRskpxPuSQ4x9uihB0gQ7u4OZjfLt3g-dXLa69Vh6V8~NCDuqo6v3G24vlQND-GArKa~lDPQvnNj2qt-cOIuFLyO0cBwJG4MTu-9C2zOe2wjR2s-cj8IAi4PweeMpJqeKZepDpe9grl8Wry8s3ahP9hZfUyCBs53LnWsEbfe2Ze01j6Bo07gXXb5rAQXYvfI7WxIDX2S7L5f33OxxJNxa4v1Jeg-aAsrW9Ij-86b9qtfsjN1IE6wUOzpQ__&Key-Pair-Id=APKAIEYUVEN4EVB2OKEQ)](https://streamable.com/1g7muc)

### v1.0:
[![ShaderWallpaperVideoPreviewV1.0](https://cdn-cf-east.streamable.com/image/yeqam9.jpg?Expires=1599641220&Signature=NCZXLhg5owCeCiBx8wg7FIO2oOZ~6y9b-we72JE0icG9Cw649dYPPRqDzuOnXsvOEe0omZhhlckbcdLZg6QKbMm9R6UUkN3g-hs4Y8WAJcWIXrantAsWlg309a2vu-gIkHV06eOYczdC3BBzprRHLh8BuKGRQyIAvxLYyf25mWexhPVrZHvrXsl-PFWN1tH~LLL14vD1oaoysupJxnF26qLVv1nAGB-AzYn7GVAcnJmpOPUbKz~jl2Z6iWy1fgJYu~Dym5Hxphc21-XIOHSqXYjkZFDslyevRJVcfqAsnfOzsm3GwRmBQ8hYB5wO5lpp4DnAUuDjtzY9d5sB025U0Q__&Key-Pair-Id=APKAIEYUVEN4EVB2OKEQ)](https://streamable.com/yeqam9)

---

### Screenshots:

[![ShaderWallpaperPreviewImage](https://images.pling.com/img/00/00/58/32/49/1413010/ef67e0df43137d0d42b81afe700e83aa9cf2c911ab4619aa6ba072894a404c658546.png)](https://images.pling.com/img/00/00/58/32/49/1413010/ef67e0df43137d0d42b81afe700e83aa9cf2c911ab4619aa6ba072894a404c658546.png)

[![ShaderWallpaperPreviewImage2](https://images.pling.com/img/00/00/58/32/49/1413010/95ec8cf5ca97eac0504faa68b297355964a9c6d4e1e1e161609997356b9a6d75fe6d.png)](https://images.pling.com/img/00/00/58/32/49/1413010/95ec8cf5ca97eac0504faa68b297355964a9c6d4e1e1e161609997356b9a6d75fe6d.png)

[![ShaderWallpaperPreviewImage3](https://images.pling.com/img/00/00/58/32/49/1413010/67b57155b2a2a2cd63f6d5545af2f6da3f5298c081c5ab05a72f6c17aa56aee79afd.png)](https://images.pling.com/img/00/00/58/32/49/1413010/67b57155b2a2a2cd63f6d5545af2f6da3f5298c081c5ab05a72f6c17aa56aee79afd.png)

[![ShaderWallpaperPreviewImage4](https://images.pling.com/img/00/00/58/32/49/1413010/b5026604b9009c3541e25b98bbaa0450d17a52ceee878f8b44383bb5e3570c3f251d.png)](https://images.pling.com/img/00/00/58/32/49/1413010/b5026604b9009c3541e25b98bbaa0450d17a52ceee878f8b44383bb5e3570c3f251d.png)

---

## Donations:
[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I525V5R)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---