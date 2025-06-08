## 🚀 我为什么要开发此模块

*我注意到很多人要么在出售泄露的 keybox，要么花钱购买声称能通过强力 Play Integrity 的模块，但实际上只提供泄露的 keybox。于是我开发了这个模块，给你提供**真正的**、**可用的 keybox**，完全**免费**，没有隐藏收费，没有骗局，只有**真实访问权限**，还带有多项实用功能。🚫🔑*

<div align="center">
  <a href="https://github.com/MeowDump/Integrity-Box/releases" target="_blank">
    <img src="https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/download.png" alt="Download Button" width="600" />
  </a>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/catppuccin/catppuccin/main/assets/footers/gray0_ctp_on_line.svg?sanitize=true" alt="Catppuccin Footer" />
</p>

`点击展开`

<details>
<summary><strong>ℹ️ 模块信息</strong></summary>

> **本模块提供以下功能：**  

- ✅ 更新 `keybox.xml`  
- 🗽 根据你的 TEE 状态更新 `target.txt`  
- 🥷 切换 Shamiko 模式（通过模块开关）  
- 👻 切换 NoHello 模式（通过模块开关）  
- 🛠️ 在 **SusFS 路径**下添加所有自定义 ROM 检测包  
- ⛔ 默认禁用 EU 注入器  
- ⛔ 禁用 Pixel ROM 伪装  
- 🔐 伪装加密状态  
- 🔑 伪装 ROM release key  
- 😋 伪装 SE Linux 状态  
- 🕵️ 检测异常活动，帮助调试问题  
- 🎨 还有更多功能，详见 [WebUI](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/9.jpg)

</details>

<details>
<summary><strong>🗽 前置要求</strong></summary>

> 请确保在使用本模块前已安装以下**模块**：

- [**Play Integrity Fork**](https://github.com/osm0sis/PlayIntegrityFork/releases)
- [**Tricky Store**](https://github.com/5ec1cff/TrickyStore/releases)

</details>

<details>
<summary><strong>❓ 常见问题解答 (FAQ)</strong></summary>

<details>
<summary><strong>Meow Assistant 是恶意软件吗？</strong></summary>

### 🛡️ 应用签名与安全说明

早期版本应用使用的是**测试密钥**签名，这导致部分安全检测器将其标记为潜在有害应用。

从**模块 v3+**开始，应用已用**私有发布密钥**签名。  
🔒 虽然**功能没有变化**，但更换为正式密钥后，问题已解决，目前**没有再出现误报**。

### 🐾 Meow Assistant 的目的

**Meow Assistant** 致力于提升易用性和透明度。

它会在以下情况下提供**弹窗提示**：

- ✅ 当你点击 **WebView** 内任意选项时  
- ⚙️ 通过**操作按钮**执行任意脚本时

这有助于你及时了解当前被触发的操作，提升整体用户体验。

<img src="https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/meowassistant.png" alt="Meow Helper" width="100%">

</details>

</details>

<details>
<summary><strong>🔍 有问题？点此查看</strong></summary>

- 无法授予 APP root 权限？`禁用` IntegrityBox 模块，它会将 shamiko/nohello 切换为`黑名单模式`并取消 root 隐藏  
- [Shamiko](https://t.me/LSPosed/292) 不支持 magisk delta（kitsune mask）  
- [Shamiko](https://t.me/LSPosed/292) 仅支持 [Zygisk Next](https://github.com/Dr-TSNG/ZygiskNext/releases)  
- 如果 play integrity 没有通过，请正确隐藏 root。如果你用的是自定义 ROM，请确保已禁用内置 gms 伪装。怎么禁用？这取决于你的 ROM，加入你的 ROM 帮助群并询问`如何禁用`。  
- 如果官方 magisk 存在完整性问题，请切换到 [Magisk Alpha](https://t.me/magiskalpha/683)。  

</details>

<details>
<summary><strong>🔗 支持</strong></summary>

[![Support Group](https://ziadoua.github.io/m3-Markdown-Badges/badges/Telegram/telegram1.svg "Join our Telegram Group")](https://t.me/+NCWzd1G--UNmNDY1)  
[![PayPal Donate](https://ziadoua.github.io/m3-Markdown-Badges/badges/PayPal/paypal1.svg "Donate via PayPal")](https://paypal.me/TempMeow)

</details>

<details>
<summary><strong>🎨 预览</strong></summary>

1. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/1.png)  
2. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/2.png)  
3. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/3.png)  
4. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/4.png)  
5. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/5.gif)  
6. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/6.gif)  
7. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/7.gif)  
8. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/8.png)  
9. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/9.jpg)  
10. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/10.png)

</details>

<details>
<summary><strong>📊 项目统计</strong></summary>

[![GitHub Stars](https://m3-markdown-badges.vercel.app/stars/7/1/MeowDump/Integrity-Box)](https://github.com/MeowDump/Integrity-Box/stargazers)  
[![GitHub Issues](https://m3-markdown-badges.vercel.app/issues/1/1/MeowDump/Integrity-Box)](https://github.com/MeowDump/Integrity-Box/issues)  
[![GitHub Release](https://ziadoua.github.io/m3-Markdown-Badges/badges/Github/github3.svg)](https://github.com/MeowDump/Integrity-Box/releases)

</details>

_我最初是在记事本写的这段代码，平时不怎么活跃在 GitHub，主要是为了保持透明才上传到这里。欢迎随时查阅代码。_

`祝你调试愉快！`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---