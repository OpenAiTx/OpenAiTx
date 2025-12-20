<img height="80" width="80" src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/icon/rounded_logo.png"/>

# Jellyflut

一个用 Flutter 制作的 jellyfin 客户端

这是测试版，运行还算正常。

## :warning: 新闻

项目目前处于停滞状态。我现在没有太多时间和兴趣维护这个项目。Flutter 中的视频播放器问题太多。我还在寻找解决方案，但目前我会放缓此应用的开发。

我仍在寻找任何 PR，并会欣然接受。

## :gear: 功能

你可以：
- [x] 播放视频
- [x] 阅读书籍（epub/CBZ）
  - 目前 epub 功能较为有限，因为它只是一个解析器加上一个 HTML 查看器
  - 需要进一步完善
- [x] 听音乐
  - 在 Linux 上有问题（需要调查，或者为 Linux 使用其他包）
- [x] 查看照片
- [x] 使用 SQLite 进行日志记录和保存服务器 URL
- [x] 浏览所有文件
- [x] ~~最重要的待办事项：实现转码，目前我不知道如何检查文件是否可以直接播放，如果不能，如何告诉 jellyfin 发送正确的 URL~~ 它已经实现了（不多了，自 10.8.0 beta 3 以来就坏了）
  - 在 Windows 上不能正常工作（似乎由于 libvlc dll 和证书问题而损坏）
  - 在电脑上我手动添加了支持的编码。有些编码可能缺失，如果是这样，请创建一个 issue，我会检查是否可播放
- [x] 可从任何屏幕控制音乐
- [x] 从视频文件中提取和/或解析字幕
 - 只支持远程 srt，不能从 mkv 文件解析（VLC 除外）

## 已完成
  - [X] 添加断开连接按钮并良好处理
  - [X] 重新设计登录页面
  - [x] 过渡动画正常
  - [x] 异步加载详情
  - [x] 导航详情返回卡顿修复
  - [x] 响应式设计（进行中）
  - [x] 使用方向键导航（看起来没问题，但网页端主页仍然可以从屏幕外选择内容）
    - 仍需更多工作，但你现在可以导航80%的应用，已足够使用
  - [x] 支持多用户和多服务器
  - [x] 在调整大小时更好地处理数据，避免从API重新加载
    - 目前看起来相当不错，未来可能需要更多改进
  - [X] 主题（暗色/浅色）
  - [X] 本地化（英语、法语、德语）

## 待办事项
  - [ ] 始终重构所有内容
  - [ ] 添加单元测试
  - [ ] 纠正 jellyfin 中的 "transcodeReasons=0"
  - [ ] 修正所有 Flutter 相关问题，提高速度
  - [ ] 使 IPTV 达到网页版水平
    - 指南已可用
    - 可以播放 IPTV 频道
    - 仍需添加录制功能

## 界面展示

 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/home.png"/>

### 手机端

<div style="display: flex">
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_phone_1.png"/>
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_phone_2.png"/>
</div>

### 桌面端

<div style="display: flex">
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/details_desktop.png" height="360" />
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_desktop.png" height="360" />
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/music_details_desktop.png" height="360" />
</div>

## 快速开始

此应用应在任何平台上运行，但 IOS 和 MacOS 尚未测试。

### 如何测试？

```bash
  git clone https://github.com/Thomas-Sohier/jellyflut.git
  cd jellyflut
  flutter packages get
  flutter packages upgrade
  flutter run
```

### 如何构建？（安卓）

```bash
  flutter build apk --release
```

### 如何构建？（计算机，取决于平台）

特定于Linux，您需要安装依赖项

```bash
  # depend of your distro of course
  sudo apt-get update -y
  sudo apt-get install -y vlc libvlc-dev ninja-build clang libgtk-3-dev
```

```bash
  # enable desktop support at first (shouldn't be necessary but anyway)
  flutter config --enable-windows-desktop
  flutter config --enable-macos-desktop
  flutter config --enable-linux-desktop

  # build the app depending of your platform
  flutter build windows
  flutter build macos
  flutter build linux
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---