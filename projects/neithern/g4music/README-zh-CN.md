<img align="left" alt="Project logo" src="https://raw.githubusercontent.com/neithern/g4music/master/data/icons/hicolor/scalable/apps/app.svg" />

# Gapless
优雅地播放您的音乐。

<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/window.png" width="1134"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/albums.png" width="1134"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/playing.png" width="462"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/playlist.png" width="466"/>

Gapless（又名：G4Music）是一款基于GTK4编写的轻量级音乐播放器，专注于大型音乐收藏。

## 功能
- 支持大多数音乐文件类型、Samba及其他远程协议（依赖于GIO和GStreamer）。
- 快速加载并解析数千个音乐文件，仅需几秒钟，监控本地变化。
- 针对带有专辑封面的大型音乐收藏低内存使用（嵌入式和外部封面），无需存储缩略图缓存。
- 按专辑/艺术家/标题分组和排序，列表随机播放，全文搜索。
- 针对不同屏幕（桌面、平板、手机）提供流畅自适应界面。
- 高斯模糊封面作为背景，跟随GNOME的亮/暗模式。
- 支持创建和编辑播放列表，拖动封面更改顺序或添加到其他播放列表。
- 支持与其他应用的拖放操作。
- 支持音频峰值可视化。
- 支持无缝播放。
- 支持使用ReplayGain进行音量归一化。
- 支持指定音频输出设备。
- 支持MPRIS控制。

## 从Flathub安装
<a href="https://flathub.org/apps/com.github.neithern.g4music">
<img src="https://flathub.org/assets/badges/flathub-badge-en.png" width="240"/></a>

## 从Snapcraft安装（非官方）
<a href="https://snapcraft.io/g4music">
<img alt="Get it from the Snap Store" src="https://camo.githubusercontent.com/ab077b20ad9938c23fbdac223ab101df5ed27329bbadbe7f98bfd62d5808f0a7/68747470733a2f2f736e617063726166742e696f2f7374617469632f696d616765732f6261646765732f656e2f736e61702d73746f72652d626c61636b2e737667" data-canonical-src="https://snapcraft.io/static/images/badges/en/snap-store-black.svg" width="240" style="max-width: 100%;"> 

## FreeBSD依赖项

```bash
pkg install vala meson libadwaita gstreamer1-plugins-all gettext gtk4
```

## 如何构建 
它是用 Vala 编写的，代码简单且干净，第三方依赖很少：

1. 从 gitlab 克隆代码。
2. 安装 vala、gtk4、libadwaita、gstreamer 的开发包。
3. 在项目目录下运行：

    `meson setup build --buildtype=release`

    `meson install -C build`

## 更新日志
查看 [发布标签](https://gitlab.gnome.org/neithern/g4music/-/tags) 获取更新日志。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-05

---