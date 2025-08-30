![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/chrome-web-store/v/gnhhdgbaldcilmgcpfddgdbkhjohddkj.svg)
![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/chrome-web-store/users/gnhhdgbaldcilmgcpfddgdbkhjohddkj.svg)
![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/chrome-web-store/rating/gnhhdgbaldcilmgcpfddgdbkhjohddkj.svg)
![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/chrome-web-store/stars/gnhhdgbaldcilmgcpfddgdbkhjohddkj.svg)
![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/chrome-web-store/rating-count/gnhhdgbaldcilmgcpfddgdbkhjohddkj.svg)<br>
![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/badge/dynamic/json?label=microsoft%20edge%20add-on&query=%24.version&url=https%3A%2F%2Fmicrosoftedge.microsoft.com%2Faddons%2Fgetproductdetailsbycrxid%2Finjfmegnapmoakbmnmnecjabigpdjeme)
[![https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme](https://img.shields.io/badge/dynamic/json?label=users&query=%24.activeInstallCount&url=https%3A%2F%2Fmicrosoftedge.microsoft.com%2Faddons%2Fgetproductdetailsbycrxid%2Finjfmegnapmoakbmnmnecjabigpdjeme)](https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme)
[![https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme](https://img.shields.io/badge/dynamic/json?label=rating&query=%24.averageRating&suffix=%2F5&url=https%3A%2F%2Fmicrosoftedge.microsoft.com%2Faddons%2Fgetproductdetailsbycrxid%2Finjfmegnapmoakbmnmnecjabigpdjeme)](https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme)
[![https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme](https://img.shields.io/badge/dynamic/json?label=ratings&query=%24.ratingCount&url=https%3A%2F%2Fmicrosoftedge.microsoft.com%2Faddons%2Fgetproductdetailsbycrxid%2Finjfmegnapmoakbmnmnecjabigpdjeme)](https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme)

<!--评分徽章目前因[此处](https://github.com/badges/shields/issues/5475)和[此处](https://github.com/pandawing/node-chrome-web-store-item-property/issues/275#issuecomment-687801815)的问题而失效。-->

#### 由于谷歌的更改，项目已升级到 Manifest 版本 3，更新请见 https://github.com/june07/nimv3。

[![https://nim.june07.com](https://june07.github.io/image/smallPromoTile.png)](https://nim.june07.com) [![https://nim.june07.com](https://github.com/june07/nimv3/assets/11353590/e6f30f3f-4ae5-4831-bafa-392eaeff66fd)](https://nim.june07.com)

# NiM (Node.js --inspector 管理器)
###### 简化您的开发流程

* [Google Chrome 网上应用店]([http://bit.ly/2W8hQG9](https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj?utm_source=github&utm_medium=readme&utm_campaign=nim&utm_content=1)) （兼容任何 Chromium 浏览器：[Google Chrome](https://www.google.com/chrome/)、[Microsoft Edge](https://www.microsoftedgeinsider.com/en-us/)、[Opera](https://www.opera.com/)、[Vivaldi](https://vivaldi.com/)、[Brave](https://brave.com/)、[Epic](https://www.epicbrowser.com/) 等等...）
* [Microsoft Edge 插件商店](https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme) （兼容微软 Edge 浏览器 https://www.microsoftedgeinsider.com/en-us/）

    ***请注意***：安装此扩展需要您与我（仅我）共享您的电子邮件地址。您会收到相关提示，但这一直是且仍然是一个重大问题，因此我觉得有必要特别明确说明。如果您不愿意与我共享电子邮件地址（顺便说一句，我的邮箱是 667@june07.com），我恳请您自行克隆/分叉一份代码，修改您不满意的部分，或者使用其他替代方案（虽然没有 NiM 好，但我承认我有偏见）。同时欢迎您直接联系我交流。与 Facebook、Google、Amazon 这些您可能毫不犹豫共享邮箱的庞大公司不同，我真正关心选择使用我编写代码的用户（约占 99%）的顾虑并对代码负责。NiM 的隐私政策请见 https://june07.com/privacypolicy。非常感谢。

## 博客文章/更新：
* 我为何编写 NiM https://blog.june07.com/inspect-broke-my-workflow/
* 自定义 DevTools 功能：https://blog.june07.com/nim-custom-devtools-url/
## 比 `about::inspect (chrome://inspect/#devices)` 更简便

NiM 管理 Chrome DevTools 窗口/标签页的生命周期，让您有更多时间专注于重要的事情……调试代码。您无需再复制粘贴 DevTools 的 URL 或频繁开关标签页/窗口。

NiM 会自动检测在本地或远程运行带有 --inspect 选项的 node 时生成的 URL。NiM 提供自动打开和关闭 Chrome DevTools 标签页或窗口的选项。只需切换手动/自动设置，然后开始调试会话。点击“打开 DevTools”按钮或到达指定超时时间后，DevTools 将自动打开。如果设置为自动关闭，调试会话结束后，DevTools 标签页或窗口会自动关闭。

 * 管理和监控本地及远程调试会话
 * 手动或自动控制 DevTools 界面
 * 在新标签页或窗口中打开 DevTools
 * 启动时使 DevTools 获得焦点或非激活
 * 自定义 v8 Inspector 探测间隔时间
 * 自动保存设置
 * 调试由 [VSCode](https://imgur.com/download/PRMn9md) 启动的 node 进程
## 安装 / 使用 / 操作指南

简单基础……只需通过以下任意方式安装 Chrome 扩展程序：

1. 通过 Chrome 网上应用店安装：
    https://bit.ly/2W8hQG9 (https://chrome.google.com/webstore/detail/gnhhdgbaldcilmgcpfddgdbkhjohddkj)
2. 或者，直接从发布页面下载 .crx 文件，如下所示：

![https://media.giphy.com/media/xT0xenBpYPF2F0j2fe/giphy.gif](https://media.giphy.com/media/xT0xenBpYPF2F0j2fe/giphy.gif)



# 需要更多信息？
* NiM 安装后页面提供了一些帮助 [https://blog.june07.com/nim-install](https://blog.june07.com/nim-install/)
* 调试 NiM 本身 [https://blog.june07.com/debugging-nim/](https://blog.june07.com/debugging-nim/)

*注意：撰写本文时，v8 --inspect 选项相当新。详情请参见 https://nodejs.org/api/debugger.html#debugger_v8_inspector_integration_for_node_js 。*
#### 如果您喜欢使用 NIM，请[给我们五星好评和/或点赞。](https://chrome.google.com/webstore/detail/nim-node-inspector-manage/gnhhdgbaldcilmgcpfddgdbkhjohddkj/reviewshttps://chrome.google.com/webstore/detail/nim-node-inspector-manage/gnhhdgbaldcilmgcpfddgdbkhjohddkj/reviews)

欢迎并鼓励所有反馈。[给我们发邮件！](https://raw.githubusercontent.com/june07/NiM/master/mailto:667@june07.com)

<!--
[![IPv4 Lease](https://june07.github.io/image/EVERYTHING.jpg)](https://june07.com/blog/ipv4/?utm_source=NiM&utm_medium=options%20page&utm_campaign=ipv4&utm_content=2)
-->

<div style="display:flex; justify-content:center;">
  <a href="https://m.do.co/c/fe4184318b19" target="_blank" rel="noopener"><IMG border="0" alt="Digitalocean $100 Credit" src="https://june07.github.io/image/digitalocean-credit.png"></a>
</div>




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---