<a href="https://www.buymeacoffee.com/fredrikbur3" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


<p align="center">
  <img src="https://raw.githubusercontent.com/streamyfin/.github/refs/heads/main/streamyfin-github-banner.png" alt="Streamyfin" width="100%">
</p>

**Streamyfin 是一款由 Expo 构建的用户友好型 Jellyfin 视频流客户端。作为其他 Jellyfin 客户端的替代方案，旨在提供流畅且可靠的流媒体体验。我们希望它能成为您媒体流工具箱中的有价值补充。**

---

<p align="center">
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot1.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot3.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot2.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/jellyseerr.PNG" width="21%">
</p>


## 🌟 功能

- 🚀 **跳过片头/片尾支持**：让您在播放时快速跳过片头和片尾
- 🖼️ **Trickplay 图像**：寻址时章节预览的新黄金标准
- 📥 **下载媒体**：将媒体保存到本地，离线观看
- ⚙️ **设置管理**：通过我们的插件管理所有用户的应用配置
- 🤖 **Seerr（原 Jellyseerr）集成**：直接在应用中请求媒体
- 👁️ **会话视图**：查看服务器上所有当前活动的流媒体会话
- 📡 **Chromecast**：将媒体投射到任何支持 Chromecast 的设备

## 🧪 实验性功能

Streamyfin 提供了令人兴奋的实验性功能，如媒体下载和 Chromecast 支持。这些功能正在积极开发中，您的反馈和耐心将帮助我们不断完善。

### 📥 下载功能

下载通过使用 FFmpeg 将 HLS 流转换为设备上的视频文件来实现。这使您可以下载并观看任何可以流式传输的内容。转换过程由 Jellyfin 服务器在下载时实时处理。虽然这可能会花费更长时间，但它确保了与服务器可转码的任何文件的兼容性。

### 🧩 Streamyfin 插件

Streamyfin 的 Jellyfin 插件是一个安装在 Jellyfin 中的插件，用于保存客户端 Streamyfin 的所有设置。这样可以让你在所有用户之间同步设置，例如：

- 自动 Seerr 登录，无需用户输入
- 设置你偏好的默认语言
- 配置下载方式和搜索提供者
- 个性化你的主页
- 以及更多功能

[Streamyfin 插件](https://github.com/streamyfin/jellyfin-plugin-streamyfin)

### 📡 Chromecast

Chromecast 支持目前正在开发中。视频投射功能已经可用，我们正在积极添加字幕支持和更多功能。

### 🔍 Jellysearch

[Jellysearch](https://gitlab.com/DomiStyle/jellysearch) 支持 Streamyfin

> 一个快速的 Jellyfin 全文搜索代理。与大多数 Jellyfin 客户端无缝集成。

## 🛣️ 路线图

查看我们的[路线图](https://github.com/users/fredrikburmester/projects/5)了解我们接下来的工作，我们始终欢迎反馈和建议。如果你有任何想法或功能请求，请告诉我们。

## 📥 下载 Streamyfin

<div style="display: flex; gap: 5px;">
  <a href="https://apps.apple.com/app/streamyfin/id6593660679?l=en-GB"><img height=50 alt="在 App Store 获取 Streamyfin" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Download_on_the_App_Store_Badge.png"/></a>
  <a href="https://play.google.com/store/apps/details?id=com.fredrikburmester.streamyfin"><img height=50 alt="在 Google Play 商店获取 Streamyfin" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Google_Play_Store_badge_EN.svg"/></a>
  <a href="https://github.com/streamyfin/streamyfin/releases/latest"><img height=50 alt="在 Github 获取 Streamyfin" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Download_on_Github_.png"/></a>
</div>

### 🧪 测试版体验

要访问 Streamyfin 测试版，你需要在 [Patreon](https://www.patreon.com/streamyfin) 订阅会员等级（或更高）。这将让你立即访问 Discord 上的 ⁠🧪-beta-releases 频道，并让我知道你已订阅。这里我会分享 APK 和 IPA。此方式不提供自动 TestFlight 访问权限，所以请通过私信（Cagemaster）发送你用于 Apple 的邮箱，以便我们手动添加你。

**注意**：任何积极贡献 Streamyfin 源代码的人都将自动获得测试版访问权限。

## 🚀 入门指南

### ⚙️ 先决条件

- 你的设备与 Jellyfin 服务器处于同一网络（用于本地连接）  
- 如果计划从本地网络外连接，确保 Jellyfin 服务器已启动并启用远程访问  
- 服务器版本为最新（旧版本可能导致兼容性问题）  
- 你拥有有效的 Jellyfin 用户账户，并可访问你想查看的媒体库  
- 如果使用**下载**或**Seerr 集成**等功能，确认 Jellyfin 服务器已安装并配置所需插件

## 🙌 贡献指南

我们欢迎任何提升 Streamyfin 的贡献。请先 fork 仓库并提交拉取请求。对于重大更改或新功能，请先打开 issue，讨论你的想法并确保与项目方向一致。

## 🌍 翻译

[![Crowdin 翻译状态](https://badges.crowdin.net/streamyfin/localized.svg)](https://crowdin.com/project/streamyfin)

Streamyfin 提供多语言版本，我们始终欢迎贡献者帮助让应用面向全球用户。  
你可以直接在我们的 [Crowdin 项目页面](https://crowdin.com/project/streamyfin) 贡献翻译。

### 👨‍💻 开发信息

1. 使用 node `>20`  
2. 安装依赖 `bun i && bun run submodule-reload`  
3. 确保已安装 xcode 和/或 android studio。（参考 expo 指南：https://docs.expo.dev/workflow/android-studio-emulator/）  
4. 在 VSCode 或你的 IDE 中安装 BiomeJS 插件（https://biomejs.dev/）  
4. 运行 `npm run prebuild`  
5. 通过运行 `npm run ios` 或 `npm run android` 创建 expo 开发构建。此操作将在你的电脑上打开模拟器并运行应用

电视版请在 npm 命令后加上 `:tv` 后缀。

`npm run prebuild:tv`  
`npm run ios:tv 或 npm run android:tv`

## 👋 联系我们

需要帮助或有任何问题？

- **Discord:** [加入我们的服务器](https://discord.gg/BuGG9ZNhaE)
- **GitHub 问题反馈:** [报告错误或请求功能](https://github.com/streamyfin/streamyfin/issues)  
- **电子邮件:** [developer@streamyfin.app](https://raw.githubusercontent.com/streamyfin/streamyfin/develop/mailto:developer@streamyfin.app)  


## ❓ 常见问题

1. 问：为什么我在 Streamyfin 中看不到我的库？  
   答：请确保您的服务器运行的是最新版本之一，且您至少有一个非纯音频库
2. 问：为什么我看不到我的音乐库？  
   答：我们目前不支持音乐，且近期不太可能支持音乐

## 📝 致谢

Streamyfin 由 [Fredrik Burmester](https://github.com/fredrikburmester) 开发，与 Jellyfin 无关联。该应用使用 Expo、React Native 及其他开源库构建。

## 🎖️ 核心开发者

感谢以下贡献者的重要贡献：

<div align="left">
<table>
  <tr>
    <td align="center">
      <a href="https://github.com/Alexk2309">
        <img src="https://github.com/Alexk2309.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Alexk2309</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/herrrta">
        <img src="https://github.com/herrrta.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@herrrta</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/lostb1t">
        <img src="https://github.com/lostb1t.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@lostb1t</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Simon-Eklundh">
        <img src="https://github.com/Simon-Eklundh.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Simon-Eklundh</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/topiga">
        <img src="https://github.com/topiga.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@topiga</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/lancechant">
        <img src="https://github.com/lancechant.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@lancechant</b></sub>
      </a>
    </td>
  </tr>
  <tr>
    <td align="center">
      <a href="https://github.com/simoncaron">
        <img src="https://github.com/simoncaron.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@simoncaron</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/jakequade">
        <img src="https://github.com/jakequade.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@jakequade</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Ryan0204">
        <img src="https://github.com/Ryan0204.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Ryan0204</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/retardgerman">
        <img src="https://github.com/retardgerman.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@retardgerman</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/whoopsi-daisy">
        <img src="https://github.com/whoopsi-daisy.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@whoopsi-daisy</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Gauvino">
        <img src="https://github.com/Gauvino.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Gauvino</b></sub>
      </a>
    </td>
  </tr>
</table>
</div>

## ✨ Acknowledgements

We would like to thank the Jellyfin team for their excellent software and support on Discord.

Special thanks to the official Jellyfin clients, which have served as an inspiration for Streamyfin.

We also thank all other developers who have contributed to Streamyfin, your efforts are greatly appreciated.

A special mention to the following people and projects for their contributions:

- [Reiverr](https://github.com/aleksilassila/reiverr) for invaluable help with understanding the Jellyfin API
- [Jellyfin TS SDK](https://github.com/jellyfin/jellyfin-sdk-typescript) for providing the TypeScript SDK
- [Seerr](https://github.com/seerr-team/seerr) for enabling API integration with their project


## ⭐ Star History

[![Star History Chart](https://api.star-history.com/svg?repos=streamyfin/streamyfin&type=Date)](https://star-history.com/#streamyfin/streamyfin&Date)

## 📄 License
Streamyfin 根据 Mozilla 公共许可证 2.0（MPL-2.0）授权。  
这意味着您可以自由使用、修改和分发此软件。MPL-2.0 是一种宽松的自由软件许可证，允许将软件与专有代码更灵活地结合使用。  
MPL-2.0 的要点：  

- 您可以将软件用于任何目的  
- 您可以修改软件并分发修改版本  
- 您必须包含原始版权和许可证声明  
- 您必须公开对涵盖文件所做的任何修改的源代码  
- 大型作品可以将 MPL 代码与其他许可证下的代码结合  
- MPL 许可的组件必须保持在 MPL 下，但大型作品可以采用不同许可证  
- 有关许可证全文，请参阅本存储库中的 LICENSE 文件  

## ⚠️ 免责声明  
Streamyfin 不推广、不支持或容忍任何形式的盗版。该应用仅用于播放您个人拥有和控制的媒体。它不提供或包含任何媒体内容。所有渠道严格禁止讨论、支持请求或提及盗版，以及任何与盗版相关的工具、软件或网站。  

## 🤝 赞助  
VPS 主机由 [Hexabyte](https://hexabyte.se/en/vps/?currency=eur) 和 [SweHosting](https://swehosting.se/en/#tj%C3%A4nster) 慷慨提供  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---