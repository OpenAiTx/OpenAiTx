<div align="center">
   <img src="https://i.imgur.com/BMpvtWP.png">
</div>

 AutoPlug-Client 是一个独立的、可执行的 Java 程序，具有多种执行模式：服务器包装器、命令行工具、后台服务。它的主要目的是自动更新与服务器相关的任何软件，并简化服务器维护。虽然所有服务器类型均兼容（包括 Steam 游戏服务器），但其大部分功能专门针对 Minecraft，该游戏被誉为全球最畅销游戏，并拥有极其庞大的模组社区。
 
## 链接

- 在 [AutoPlug-Releases](https://github.com/Osiris-Team/AutoPlug-Releases) 仓库下载稳定版/测试版。
- 关注 [AutoPlug-Client-Development](https://bit.ly/acprogress)，查看我们当前的开发进展。
- 通过 [捐赠](https://www.paypal.com/donate?hosted_button_id=JNXQCWF2TF9W4) 支持开发。
- 有问题或疑问？查看 [FAQ](/docs/FAQ.md) 和/或加入我们的 [Discord](https://discord.com/invite/GGNmtCC)，进行实时聊天/语音支持。

## 它能做什么？

- 自动更新自身、服务器软件、插件、模组和 JRE（Java 运行环境）
- 定时服务器重启
- 自动化、模块化备份创建
- 快速、异步、多线程任务执行
- 支持同步（共享）文件夹
- Web 面板用于启动、停止、重启服务器及查看最近更新结果摘要

高级版 [AutoPlug-Web](https://autoplug.one) 功能：

- [在线控制台](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/online-console.gif)
- [在线文件管理器](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/file-manager.gif)
- 员工访问权限
- 插件详情数据库

## 状态
稳定且功能完整，因此采用社区驱动开发，意味着主开发者将不再开发新功能，依赖他人提交的拉取请求，除非涉及安全问题和关键错误。

## 社区项目

- Docker 支持：https://github.com/lkkuma/AutoPlug-Client-Docker
- Pterodactly 面板支持：https://github.com/ImLunaUwU/PteroPlug

开发者： 


你也可以通过将 AutoPlug 作为依赖项添加到你的项目中来使用它，  
通过 [Maven/Gradle/Sbt/Leinigen](https://jitpack.io/#Osiris-Team/AutoPlug-Client/-SNAPSHOT)。一些有用的类例如  
AutoPlugConsole，它允许你以编程方式执行 AutoPlug 命令：  

```java
AutoPlugConsole.executeCommand(".check plugins");
AutoPlugConsole.executeCommand(".check server");
// etc...
```
## 贡献 ![Build test](https://github.com/Osiris-Team/AutoPlug-Client/workflows/build/badge.svg)

感谢您考虑贡献，社区💙这个！请记住以下事项：
- 如果您想做重大更改，请先创建一个问题，以便我们讨论。
- 请记住，重大更改也需要您编写测试。
- 您可以选择并处理任何未解决的问题。请让我们知道您正在处理它。
- 避免使用和编写静态方法/字段/类，以确保最小的内存使用。

初学者：

- [contribute-to-projects](https://www.jetbrains.com/help/idea/contribute-to-projects.html)
- [clone-a-project-from-github](https://blog.jetbrains.com/idea/2020/10/clone-a-project-from-github/)

赏金：

一些未解决的问题标有类似这样的标签/标注：`bounty: 15€`（查看[列表](https://github.com/Osiris-Team/AutoPlug-Client/labels/bounty%3A%2015%E2%82%AC)），这意味着第一个
创建拉取请求以修复/关闭该问题的人将获得赏金（15€）。请注意，您的代码必须至少有
一个测试来证明所实现的修复/功能是有效的。还要注意，付款仅通过 PayPal 进行，因此请确保
您提交拉取请求所用的 GitHub 公开页面中包含您的 PayPal 电子邮件地址。
通过提交带有赏金标签的问题，您同意这些条款。

详情：

- 使用 [Java](https://java.com/) 编写，基于 [JDK 8](https://www.oracle.com/java/technologies/javase/javase-jdk8-downloads.html)，在 [IntelliJ IDEA](https://www.jetbrains.com/idea/) 中开发
- 使用 [1JPM](https://github.com/Osiris-Team/1JPM) 构建，命令：`java ./src/main/java/JPM.java`
（如果您想直接运行，也可以在末尾添加 `andRun`）。

## 库

请注意此列表可能过时。请查看 [build.gradle](/build.gradle) 文件以获取我们当前的依赖项。
- [AutoPlug-Core](https://github.com/Osiris-Team/AutoPlug-Core) 包含所有 AutoPlug
  项目中频繁使用的代码，打包在一个 jar 中。
- [Dream-Yaml](https://github.com/Osiris-Team/Dream-Yaml) 用于处理 YAML 文件。
- [Better-Thread](https://github.com/Osiris-Team/Better-Thread) 支持显示“实时任务”。
- 控制台着色和任务显示使用了 [Jansi](https://github.com/fusesource/jansi) 和 [Jline](https://github.com/jline/jline3)。
- 使用 [Zip4j](https://github.com/srikanth-lingala/zip4j) 解压和处理 jar/zip 文件。
- 服务器重启由 [Quartz](http://www.quartz-scheduler.org/) 调度。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---