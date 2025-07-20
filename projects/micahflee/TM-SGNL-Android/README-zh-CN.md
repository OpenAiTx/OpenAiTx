# Signal Android

Signal 是一款简单、强大且安全的通讯软件。

Signal 使用您的手机数据连接（WiFi/3G/4G/5G）进行安全通信。每天都有数百万人免费且即时地使用 Signal 在世界任何地方进行交流。发送和接收高保真消息，参与高清语音/视频通话，并探索一系列不断增长的新功能，帮助您保持联系。Signal 的先进隐私保护技术始终开启，让您专注于与重要的人分享重要时刻。

目前可在 Play 商店和 [signal.org](https://signal.org/android/apk/) 获取。

<a href='https://play.google.com/store/apps/details?id=org.tm.archive&pcampaignid=MKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1'><img alt='Get it on Google Play' src='https://play.google.com/intl/en_us/badges/images/generic/en_badge_web_generic.png' height='80px'/></a>

## 贡献 Bug 报告
我们使用 GitHub 进行 Bug 跟踪。请先搜索现有问题以确认您的 Bug 是否已被记录，若未记录请新建一个问题！

https://github.com/signalapp/Signal-Android/issues

## 加入测试版
想体验最新功能并帮助测试吗？

您可以在这里订阅 Signal Android 测试版发布：
https://play.google.com/apps/testing/org.tm.archive

如果您喜欢安稳平和的生活，请继续使用正式版。

## 贡献代码

如果您是 Signal 代码库的新手，建议先浏览我们的问题列表，挑选一个简单的 Bug 修复（查看问题中的“easy”标签），以便熟悉项目。同时请查看 [CONTRIBUTING.md](https://github.com/signalapp/Signal-Android/blob/main/CONTRIBUTING.md)，它可能解答您的部分疑问。

对于较大的改动和新功能建议，请先在 [非官方社区论坛](https://community.signalusers.org) 提出，与更广泛的社区进行高层次讨论后再实现。

## 贡献想法
有关于 Signal 项目想要发表意见或参与讨论？请加入 [社区论坛](https://community.signalusers.org)。

帮助
====
## 支持
如需故障排查和提问，请访问我们的支持中心！

https://support.signal.org/

## 文档
寻找文档？请查看维基！

https://github.com/signalapp/Signal-Android/wiki

# 法律事项
## 加密声明

本发行版包含加密软件。您当前所在国家可能对加密软件的进口、持有、使用和/或向他国再出口有限制。
在使用任何加密软件前，请务必查阅您国家关于加密软件进口、持有、使用及再出口的法律、法规和政策，确认是否允许。
详见 <http://www.wassenaar.org/>。

美国商务部工业与安全局（BIS）将本软件归类为出口商品控制编号（ECCN）5D002.C.1，包含使用非对称算法执行加密功能的信息安全软件。
本发行方式符合“加密技术软件无限制许可例外（TSU）”（参见 BIS 出口管理条例第740.13节）条件，适用于对象代码和源代码的出口。

## 许可协议

版权所有 2013-2024 Signal Messenger, LLC

基于 GNU AGPLv3 许可：https://www.gnu.org/licenses/agpl-3.0.html

Google Play 及 Google Play 标志为 Google LLC 的商标。


//**TM_SA**//
Signal – 新基线
1.	从以下链接下载 Signal 官方开源版本：
      https://github.com/signalapp/Signal-Android

2.	按以下顺序重命名每个文件夹：
      a.	thoughtcrime  tm
      b.	securesms  archive
3.	使用“全部替换”功能（Ctrl +Shift + R）替换所有旧的包名引用
      a.	org.tm.archive -> org.tm.archive
4.	将我们的 archiver SDK 和 Common 库添加到新建的 “libs” 文件夹，并通过依赖编译它们。
5.	添加 archiver、intune、selfauthentication 文件夹，包含所有归档类及工具等（从 src->main->java->org 获取）
6.	在当前项目中搜索 “ArchiveLogger.Companion.sendArchiveLog”，将所有相关引用添加到更新后的项目中。
7.	添加启动器图标应用，并更改清单中的圆形图标路径
8.	将当前项目中的 proguard-event_bus 添加到更新后的项目。
9.	进入当前的 TeleMessage Signal 项目，使用 ctrl+alt+F 搜索：//**TM_SA**//

此字符串有数十处引用，请逐一处理搜索结果，替换或添加包含该字符串的代码（//**TM_SA**//），以便实现基线更新方法的连续性。


intune

1. 使用 //**TM_SA**// 添加依赖
2. 添加包含 aar 和 jar 的 MAMSDK 文件夹
3. 1. 在 intune 服务器注册应用
2. https://aad.portal.azure.com/#view/Microsoft_AAD_IAM/ActiveDirectoryMenuBlade/~/Overview
3. Azure Active Directory > 应用注册 > 新注册
3. 认证，添加平台 -> 添加 URI -> 包名。
4. 然后使用显示的查看按钮添加 auth-config 文件，放入 resource-> raw 文件夹
5. API 权限...

4. 1. https://aad.portal.azure.com/#view/Microsoft_AAD_IAM/ActiveDirectoryMenuBlade/~/RegisteredApps
2. 接着，应用配置策略 -> 创建应用配置策略 -> 管理应用 -> 设置 -> 添加值（managerID 等）
3. 然后，分配 -> 包含你想要的组或分配给所有人。

5. http://everythingaboutintune.com/2021/07/guide-for-integrating-intune-sdk-and-msal-to-lob-application/

https://www.youtube.com/watch?v=1AyGpcdDRkY&t=741s&ab_channel=EverythingAboutIntune
https://github.com/msintuneappsdk/Taskr-Sample-Intune-Android-App#readme
//**TM_SA**//


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---