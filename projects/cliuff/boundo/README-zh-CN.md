<p align="center">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot1.png" width="270" alt="截图 1">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot2.png" width="270" alt="截图 2">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot3.png" width="270" alt="截图 3">
</p>

# Boundo 元应用：信息与管理

Boundo 元应用专注于您的应用及更多。  
查看手机上应用的信息，并将它们整理成类别。  
为 Android 爱好者设计，元应用可在 **Android** 和 **Wear OS** 上使用。

### 1. 开发
**1.1 要求**
- Android Studio `Meerkat`（AGP `8.9`）
- Java `17`，Kotlin `2.1.21`，Gradle `8.13`

**1.2 配置自动签名**
- **复制** 位于 `doconfig` 目录下名为 `custom.properties.template` 的文件，  
  **重命名** 为 `custom.properties` 并进行必要的**修改**

**1.3 构建通用 APK（包含应用 API 功能，发布版本）**
- 按第 1.2 节指定配置签名
- 从 [BundleTool Releases](https://github.com/google/bundletool/releases) 下载 BundleTool 二进制文件，  
  并保存到本项目的 `doconfig/bundletool.jar`
- 从命令行运行 Gradle 任务 `gradlew :app:genUniversalApks`
- 在本项目中查找 `app/build/outputs/app-universal-release.apks`

**1.4 构建 FOSS 版本（功能较少）**
- 按第 1.2 节指定配置签名
- 从 [BundleTool Releases](https://github.com/google/bundletool/releases) 下载 BundleTool 二进制文件，  
  并保存到本项目的 `doconfig/bundletool.jar`
- 从命令行运行 Gradle 任务 `gradlew :app:genFossApks`
- 在本项目中查找 `app/build/outputs/app-universal-foss.apks`

### 2. 下载
[<img alt='在 Google Play 获取' src='https://play.google.com/intl/en_us/badges/static/images/badges/en_badge_web_generic.png' height='100'/>](https://raw.githubusercontent.com/cliuff/boundo/main/
https://play.google.com/store/apps/details?id=com.madness.collision&pcampaignid=pcampaignidMKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---