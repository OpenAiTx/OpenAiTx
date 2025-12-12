[![Contributors](https://img.shields.io/github/contributors/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/graphs/contributors)
[![Forks](https://img.shields.io/github/forks/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/metworks/members)
[![Stargazers](https://img.shields.io/github/stars/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/stargazers)
[![Issues](https://img.shields.io/github/issues/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/Wladefant/mshdabiola/Play_NotePad/issues)
[![License](https://img.shields.io/github/license/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/master/LICENSE)

# 记事本

[<img src="/images/ic_launcher-playstore.png" align="left"
width="200" hspace="10" vspace="10">](/images/ic_launcher-playstore.png)

记事本是一款多功能的笔记应用，允许您轻松捕捉和组织您的
想法、创意和任务。借助多种功能，Play Notepad 让您轻松掌控
笔记，保持有序。

Play NotePad 可在 Google Play 商店获得：

<p align="left">
<a href="https://play.google.com/store/apps/details?id=com.mshdabiola.playnotepad">
    <img alt="Get it on Google Play"
        height="70"
        src="https://play.google.com/intl/en_us/badges/images/generic/en_badge_web_generic.png" />
</a>

<a href="https://f-droid.org/packages/com.mshdabiola.playnotepad.foss/">
    <img alt="Get it on F-Droid"
        height="70"
        src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png" />
</a>

<a href="https://github.com/mshdabiola/NotePad/releases">
    <img alt="Get it on GitHub"
        height="70"
        src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/github_image.png" />
</a>  



<a href="https://github.com/mshdabiola/Play_NotePad">查看演示</a>
·
<a href="https://github.com/mshdabiola/Play_NotePad/issues">报告错误</a>
·
<a href="https://github.com/mshdabiola/Play_NotePad/issues">请求功能</a>
  </p>

## 关于该项目

[<img src="/images/screenshot1.png" align="left"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot1.png)
[<img src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot2.png" align="center"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot2.png)
[<img src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot3.png" align="center"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot3.png)

一些亮点功能：

- 懒人模式：帖子自动滚动，让你无需移动拇指即可享受精彩内容
- 轻松创建和编辑文本笔记。
- 拍照或从相册中选择照片附加到笔记。
- 手绘草图和图表，为笔记添加注释。
- 录制音频笔记，稍后播放。
- 将重要笔记置顶，方便访问。
- 创建清单，通过复选框跟踪任务。
- 使用标签组织笔记。
- 复制笔记，便于参考。
- 通过电子邮件或消息分享笔记。
- 设置提醒，永不忘记重要任务或事件。
- 删除不再需要的笔记。
- 通过归档旧的或已完成的任务保持笔记整洁。
- 为笔记添加颜色，使其更具视觉吸引力。
- 在笔记背景添加图片，个性化外观。
- 以列表或列格式查看笔记，便于阅读和编辑。
- 通过关键词、标签和类型搜索笔记。
- 离线使用应用，随时访问笔记。

## 构建工具

## 具有三个主要模块的清洁架构

[//]: # (<img src="/images/AndroidTemplate-CleanArchitecture.jpeg" alt="ArchiTecture logo"/>)

- 声明式 UI（使用 [Jetpack Compose](https://developer.android.com/jetpack/compose)）
    - Compose 导航 (
      支持 [Hilt](https://developer.android.com/jetpack/compose/libraries#hilt-navigation)
      及 Assisted Inject 示例)
- 数据层（用于数据库、API 和偏好设置代码）
- 领域层（用于业务逻辑和模型）
- AndroidApp（用于 UI 逻辑，采用 MVVM）
- 本版本引入了 [模块化](https://developer.android.com/topic/modularization)
- 版本管理 (
  使用 [版本目录](https://docs.gradle.org/current/userguide/platforms.html))
- 共享构建逻辑 (
  使用 [约定插件](https://docs.gradle.org/current/samples/sample_convention_plugins.html))
- 依赖注入（使用 [Hilt](http://google.github.io/hilt/)）
- 响应式编程 (
  使用 [Kotlin Flows](https://kotlinlang.org/docs/reference/coroutines/flow.html))
- Android 架构组件以便在配置变更时共享 ViewModels
- [启动屏幕](https://developer.android.com/develop/ui/views/launch/splash-screen) 支持
- Google Material 3 [材质设计](https://material.io/blog/android-material-theme-color) 库

- 边缘到边缘配置

[//]: # (## 测试)

[//]: # (- [Mockk]&#40;https://mockk.io/&#41; 库)

[//]: # (- 单元测试)

[//]: # (- 应用测试)

[//]: # (    - 测试使用示例)

[//]: # (- Activity 测试（使用 [Compose Testing]&#40;https://developer.android.com/jetpack/compose/testing&#41;）)

[//]: # (    - 测试中协程作用域的使用示例)


## 贡献

1. 贡献是让开源社区成为一个令人惊叹的学习、激励和创造之地的原因。您所做的任何贡献都被**高度赞赏**。

2. 无论您是帮助我们修复漏洞、改进文档，还是传播信息，我们都希望您成为 Gatsby 社区的一员！

3. 感谢您对贡献的兴趣！有许多方式可以为该项目做出贡献。从这里开始（Contributing.md 链接）

### 反馈

别忘了给项目点个星！再次感谢！

您可以使用 [Github Discussions](https://github.com/mshdabiola/Play_NotePad/discussions) 进行应用讨论或一般问题。在那里，您还可以提交功能请求（请先阅读如何提交功能请求的说明！），或者如果您是开发者，可以 Fork 本项目并创建拉取请求

1. Fork 项目
2. 创建您的功能分支（`git checkout -b feature/AmazingFeature`）
3. 提交您的更改（`git commit -m 'Add some AmazingFeature'`）
4. 推送到分支（`git push origin feature/AmazingFeature`）
5. 打开拉取请求

以下是您可以帮助的其他方式：

* [报告漏洞](https://github.com/mshdabiola/Play_NotePad/issues)

* [翻译应用](https://poeditor.com/join/project/rdWI3SpnSW)

## 开发

## 许可证

Play Notepad 采用 GNU 通用公共许可证（GPL-3.0）授权。您可以在 `LICENSE` 文件中找到许可证文本。

## 联系方式








mshdabiola - [@Mshdabiola](https://twitter.com/mshdabiola) - mshdabiola@gmail.com

## 致谢


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---