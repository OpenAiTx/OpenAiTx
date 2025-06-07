# GroceryApp Starter

简化的杂货应用模板，带来简洁明了的购物体验。🛒✨

如果你觉得本项目有价值，欢迎为仓库加星 ⭐。

## 设计

**点击下方图片查看 Figma 设计稿：**

[![Design Preview](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨环境要求

1. **开发环境：**
   - 安装有 Flutter SDK 的任意 IDE（如 VSCode、Android Studio、IntelliJ 等）

2. **知识基础：**
   - Dart 和 Flutter 的基础到中级知识
   - 了解 MVVM 架构
   - 熟悉 API 处理
   - 掌握使用 GetX 进行状态管理的基础

## 测试
* 你可以在这里下载适用于安卓设备的预发布版本 [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1)。
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## 安装步骤
* 首先在 `lib\constants\AppConstants` 中配置你的产品端点、凭证和参数。
* **或者**，也可以使用下方提供的免费端点（截至分享日期），以便顺利测试。
```dart
class AppConstants {
  // 用你自己的 API 基础 URL 替换 "YOUR_API_PREFIX"。
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //如有请填写

  // 测试时，可使用发布版本中的免费 API 基础 URL
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // 项目所有者全名
  static const String projectOwnerName = "FULL_NAME";
}
```

## 注意事项
* 如需使用你自己的 API 端点，请根据你的 API 文档，按照 MVVM 架构规范自定义逻辑层。
* 由于版权原因，预发布版本中的部分图片已被移除。

## 贡献

请 Fork 此仓库，并通过
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls) 贡献代码。

无论大小，任何贡献、主要功能、错误修复都非常欢迎和感谢，但都会经过仔细审核。


## 快速开始
本项目是一个 Flutter 应用的起始模板。

如果这是你的第一个 Flutter 项目，以下资源将助你快速上手：

- [实验室：编写你的第一个 Flutter 应用](https://flutter.io/docs/get-started/codelab)
- [Cookbook：实用 Flutter 示例](https://flutter.io/docs/cookbook)

## 访问量统计

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---