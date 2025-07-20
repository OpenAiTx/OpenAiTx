# Netflix 家庭账户验证终结 🚫

一个浏览器扩展，旨在通过根据页面上下文采用不同策略，绕过 Netflix 的家庭账户验证提示。

**支持：** `Chrome`（及基于 Chromium 的浏览器如 Edge） | `Firefox`

---

## 功能

*   **阻止 `/watch` 页面上的验证请求：** 在视频播放页面（`/watch/`）阻止与家庭验证相关的特定 GraphQL 网络请求。
*   **隐藏 `/browse`（及其他）页面上的验证弹窗：** 在除 `/watch/` 以外的页面（如主浏览页面）隐藏出现的家庭验证弹窗。
*   **目标：** 仅影响 `netflix.com` 域名。

---

## 安装（官方）

**Mozilla Firefox：** https://addons.mozilla.org/cs/firefox/addon/netflix-household-no-more/

**Google Chrome / Microsoft Edge / Chromium 浏览器：** 扩展尚未发布。

## 安装（本地开发/测试）

由于该扩展尚未在 Chrome 商店发布，您需要手动加载。

**Google Chrome / Microsoft Edge / Chromium 浏览器：**

1.  下载或克隆此仓库到本地。
2.  打开浏览器，访问 `chrome://extensions`（或 `edge://extensions`）。
3.  启用 **开发者模式**（通常位于右上角的开关）。
4.  点击 **加载已解压的扩展程序** 按钮。
5.  选择保存扩展文件的目录（包含 `manifest.json` 的文件夹）。
6.  扩展程序现在应已加载并生效。

**Mozilla Firefox：**

1.  下载或克隆此仓库到本地。
2.  打开 Firefox，访问 `about:debugging`。
3.  点击左侧边栏的 **此 Firefox**。
4.  点击 **加载临时附加组件...** 按钮。
5.  定位到保存扩展文件的目录。
6.  选择 **`manifest.json`** 文件。
7.  扩展程序现在应已加载并在当前浏览器会话中生效。
    *   **注意：** Firefox 的临时附加组件在关闭浏览器时会被移除。每次重启 Firefox 时需重新加载。

---

## 注意事项与已知问题

*   **Netflix 视频播放器界面不可见：** 若看不到视频播放器界面，请刷新页面，通常可以解决。
*   **Netflix 更新：** Netflix 经常更新其网站和内部 API。对 GraphQL 端点 URL、请求结构、页面结构（`/watch/` 路径）或弹窗的 CSS 选择器/HTML 结构的任何更改，可能会部分或完全导致此扩展失效。
*   **控制台错误：** 在 `/watch/` 页面时，浏览器开发者控制台中会出现网络错误（通常是 CORS 相关）。这是扩展成功阻止网络请求的预期副作用。虽然视觉上有些杂乱，但通常不会影响性能。
*   **脆弱的 CSS：** 弹窗隐藏依赖特定的 CSS 类名和 `data-uia` 属性，这些可能随时更改且无预警。

---

## 免责声明

*   本扩展与 Netflix 无任何官方关联或认可。
*   使用本扩展风险自负。开发者不承担任何责任。
*   修改第三方网站的网络请求或 DOM 可能违反其服务条款，请注意潜在后果。

---

## 许可协议

版权所有 [Amachi] - 保留所有权利。

仅授权下载并个人非商业用途使用本软件。未经版权所有者明确书面许可，严禁全部或部分转载、修改或商业使用本软件。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---