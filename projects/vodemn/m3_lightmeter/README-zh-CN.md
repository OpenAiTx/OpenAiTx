<img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/resources/social_preview.png" width="100%" />

![](https://github.com/vodemn/m3_lightmeter/actions/workflows/pr_check.yml/badge.svg)
![](https://github.com/vodemn/m3_lightmeter/actions/workflows/create_release.yml/badge.svg)

# 目录

- [目录](#table-of-contents)
- [背景故事](#backstory)
- [截图](#screenshots)
- [开发](#development)
- [支持](#support)
- [iOS 限制](#ios-limitations)

# 背景故事

不久前我开始开发 [Material Lightmeter](https://play.google.com/store/apps/details?id=com.vodemn.lightmeter&hl=en&gl=US) 应用。不幸的是，这个应用的最后一次更新是在创建此仓库之前近一年。因此，在阅读了 Google Play 上一条积极的评论：“这是一个出色的应用，只可惜不再更新”后，我决定更新它并将此应用开源。也许某人某时会决定为此项目贡献代码。

但由于现有仓库包含一些敏感数据，我之前因经验不足而推送了这些数据，因此我不得不创建一个新的仓库。如果创建新的仓库，为什么不从头重写这个应用呢？

废话不多说，呈现我的新 Lightmeter 应用，灵感来自 Material You（又名 M3）

# 截图

<p float="center">
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_metering-reflected.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_equipment-profiles.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_settings.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_timer.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/dark_metering-reflected.png" width="18.8%" />
</p>

# 开发

### 1. 安装 Flutter

要构建此应用，您需要安装 Flutter 3.24.5 稳定版。[如何安装](https://docs.flutter.dev/get-started/install)。

### 2. 项目设置

#### 恢复 git 忽略的文件：

对于 macOS，您只需运行以下脚本：

```console
sh scripts/setup_fork.sh
```


或者使用脚本中的内容手动创建文件。

#### 获取依赖

> 如果您使用的是 VSCode，可以这样打开工作区：_文件 -> 从文件打开工作区 -> m3_lightmeter.code-workspace_。否则，您需要在 iap 文件夹中运行 `flutter pub get` 命令。

然后，您可以通过运行以下命令获取所有必要的依赖并生成翻译文件：


```console
flutter pub get
flutter pub run intl_utils:generate
```
### 3. 构建

- 查看针对 Android 的 [构建 .apk](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/.github/workflows/build_apk.yml) 工作流
- 查看针对 iOS 的 [构建 .ipa](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/.github/workflows/build_ipa.yml) 工作流

# 支持

如需报告错误或建议新功能，请打开一个新的 [issue](https://github.com/vodemn/m3_lightmeter/issues)。如需为项目做贡献，欢迎提交 Pull Request，但需遵循此 [风格指南](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/doc/style_guide.md)。

如有其他问题，请通过 [电子邮件](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/mailto:contact.vodemn@gmail.com?subject="Lightmeter") 联系我。

# iOS 限制

以下是 Android 版本有而 iOS 版本没有的功能列表。

## 入射光测光

Apple 不提供用于读取环境光传感器照度流的 API。照度可以基于前置摄像头图像流计算，但这将是反射光。因此，iOS 上无法实现入射光测光。

## 音量按钮操作

此功能可以[实现](https://stackoverflow.com/questions/70161271/ios-override-hardware-volume-buttons-same-as-zello)，但应用会因违反[2.5.9](https://developer.apple.com/app-store/review/guidelines/#software-requirements)而被拒绝。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---