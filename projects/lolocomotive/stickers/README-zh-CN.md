# 贴纸

简单的安卓WhatsApp贴纸制作器，无广告。

[![](https://upload.wikimedia.org/wikipedia/commons/7/78/Google_Play_Store_badge_EN.svg)](https://play.google.com/store/apps/details?id=de.loicezt.stickers)

或者从最新的[GitHub Release](https://github.com/lolocomotive/stickers/releases)下载

## 功能

- 快速模式：分享图片到应用时自动添加到WhatsApp
- 编辑器
    - 随心裁剪你的贴纸
    - 添加不同大小、字体和颜色的文字
    - 使用不同颜色和画笔大小绘画，支持撤销/重做
    - 每个元素底层都有自己的图层，因此你可以在文字上方和下方绘画
- 导入/导出
    - 导出为`.zip`以分享或备份你的贴纸包
    - 从多种格式导入（自有的`.zip`格式，`.wastickers`，`.stickify`，添加更多格式不难，因为它们大多只是包含图片和简单清单的ZIP文件）
- 创建、编辑和删除多个贴纸包及其元数据（作者、标题、托盘图标等）

## 截图

| 首页                              | 贴纸包视图                         | 编辑器                                |
|-----------------------------------|-----------------------------------|---------------------------------------|
| ![home.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/home.png) | ![pack.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/pack.png) | ![editor.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/editor.png) |

## 构建

`flutter run` 应该可以正常工作，但如果你想构建应用的发布版本，
你需要：

<details>
<summary>使用你自己的签名密钥</summary>

在 `android/` 目录下创建 `key.properties` 文件，内容为


```properties
storeFile=path/to/keystore.jks
keyAlias=your key alias
storePassword=your store password
keyPassword=your key password
```
更多详情：https://docs.flutter.dev/deployment/android#sign-the-app

</details>

或

<details>
<summary>使用调试签名配置</summary>

在 `android/app/build.gradle` 大约第29行处


```
buildTypes {
  release {
    signingConfig signingConfigs.release
  }
}
```

将 `signingConfigs.release` 替换为 `signingConfigs.debug` 并移除

```
def keystoreProperties = new Properties()
def keystorePropertiesFile = rootProject.file("key.properties")
if (keystorePropertiesFile.exists()) {
    keystorePropertiesFile.withReader('UTF-8') { reader ->
        keystoreProperties.load(reader)
    }
}
```

and

```
signingConfigs {
    create("release") {
        keyAlias = keystoreProperties["keyAlias"]
        keyPassword = keystoreProperties["keyPassword"]
        storeFile = new File(keystoreProperties["storeFile"])
        storePassword = keystoreProperties["storePassword"]
    }
}
```

它*应该*能工作，只用于测试。
</details>

然后你只需要

```
flutter build apk
```

## 贡献

欢迎任何贡献（拉取请求、功能请求和错误报告）！
请注意，我将行宽设置为120而非80，因此在重新格式化整个
文件之前请小心。如果你使用vscode，请在`.vscode/settings.json`中添加以下内容。

```json
{
  "dart.lineLength": 120,
  "[dart]": {
    "editor.rulers": [
      120
    ]
  }
}
```
代码目前文档说明不多，提前向所有尝试阅读的人道歉。

## 待办事项

未来计划开发的一些功能

- [ ] 在主屏幕一次选择多个贴纸包
- [ ] 添加给文字加背景的选项
- [ ] 贴纸上的图像图层
- [ ] 从已有贴纸开始制作
- [ ] 从GIF创建动画贴纸
- [ ] 裁剪和旋转视频

## iOS 支持

我没有苹果设备，因此无法为iOS构建或测试应用。这个应用是Flutter开发的，应该大致能用。
如果你想添加iOS支持，欢迎参与！需要注意以下几点：

- 需要修改 `image_editor` 以支持iOS上的WEBP格式（我只在Android上添加了WEBP支持）
- `whatsapp_stickers_plus` 包可能无法使用（Android上也不行）
- 许多控件需要替换为对应的 `.adaptive` 版本，才能看起来像iOS应用






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---