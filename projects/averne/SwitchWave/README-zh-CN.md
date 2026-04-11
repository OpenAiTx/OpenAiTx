# <img src="https://github.com/user-attachments/assets/b81b9503-948e-4cba-b0a1-f5f809588aad" width="48"> SwitchWave
一个为任天堂Switch硬件加速的媒体播放器，基于mpv和FFmpeg构建。

## 功能
- FFmpeg的自定义硬件加速后端，支持动态频率调节。可解码以下编码格式：
    - MPEG1/2/4
    - VC1
    - H.264/AVC（硬件不支持10位及以上）
    - H.265/HEVC（硬件不支持12位及以上）
    - VP8
    - VP9（硬件不支持10位及以上）
- mpv的自定义图形后端，使用[deko3d](https://github.com/devkitPro/deko3d)，支持：
    - 4k60fps播放
    - 直接渲染（更快的软件解码）
    - 自定义后期处理着色器
- mpv的自定义音频后端，使用任天堂原生API，支持最高5.1声道布局
- 通过HTTP/S、Samba、NFS或SFTP进行网络播放
- 支持使用[libusbhsfs](https://github.com/DarkMatterCore/libusbhsfs)的外部驱动器
- 丰富且响应迅速的用户界面，即使在负载下也能流畅运行

## 截图

<p float="center">
    <img src="https://github.com/user-attachments/assets/09aed446-148a-4276-8b07-336890c224a3" width="413" />
    <img src="https://github.com/user-attachments/assets/6e354511-47bc-4898-881c-348d5a9e6fbc" width="413" />
    <img src="https://github.com/user-attachments/assets/b86eb7c6-4229-46c6-8709-86d1a6ee8eed" width="413" />
    <img src="https://github.com/user-attachments/assets/70f4be3e-fa1e-434a-b76c-4fb6b671f80e" width="413" />
</p>

## 安装
- 下载[最新版本](https://github.com/averne/SwitchWave/releases/latest)，并解压到SD卡根目录（注意合并而非覆盖文件夹）
- 可以通过应用配置网络共享，也可以通过内置编辑器配置mpv设置（请参考[手册](https://mpv.io/manual/master/)）
- 大部分相关运行时参数可通过菜单在播放时动态调整，若无法调整，可使用控制台（[手册](https://mpv.io/manual/master/#console)）

## 构建

### Docker（推荐）
```sh
./build-docker.sh
```
这将自动构建工具链镜像并编译所有内容。输出文件将在 `build/` 中找到。

要使用 GIMP 3 而不是默认的 GIMP 2 进行构建：
```sh
GIMP_VERSION=3 ./build-docker.sh
```

### 手册
- 设置一个用于Switch自制软件开发的[devkitpro](https://devkitpro.org/wiki/devkitPro_pacman)环境。
- 安装以下软件包：`switch-bzip2`、`switch-dav1d`、`switch-freetype`、`switch-glm`、`switch-harfbuzz`、`switch-libarchive`、`switch-libass`、`switch-libfribidi`、`switch-libjpeg-turbo`、`switch-libpng`、`switch-libwebp`、`switch-curl`、`switch-libssh2`、`switch-mbedtls`、`switch-ntfs-3g` 和 `switch-lwext4`。此外，还需要以下构建依赖：`switch-pkg-config`、`dkp-meson-scripts`、`dkp-toolchain-vars`，以及 [GIMP](https://www.gimp.org/) (版本2或3)。
- 编译并安装GPL版本的[libusbhsfs](https://github.com/DarkMatterCore/libusbhsfs)。
- 编译并安装[libsmb2](misc/libsmb2/)和[libnfs](misc/libnfs/)。
- 配置、编译并安装FFmpeg：`make configure-ffmpeg && make build-ffmpeg -j$(nproc)`。
- 配置、编译并安装libuam：`make configure-uam && make build-uam`。
- 配置、编译并安装mpv：`make configure-mpv && make build-mpv`。
- 最后，编译主应用程序并构建发布版本：`make dist -j$(nproc)`。
- 输出文件将位于`build/`目录下。

## 致谢
- 感谢[Behemoth](https://github.com/HookedBehemoth)提供的截图按钮重写方法。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---