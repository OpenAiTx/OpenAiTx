![HOTSTAR IPL 广告静音器](https://raw.githubusercontent.com/pea1bee/hotstar-ipl-ad-mute/main/chrome/128.png?raw=true) 
# Hotstar 广告静音器

这个小巧的浏览器扩展通过拦截 Hotstar 的广告跟踪像素，自动静音 Hotstar 直播体育赛事中的某些广告，如 IPL。它还通过广告标识动态判断静音时长，估算广告时长。

通过自动静音以下广告，为您的耳朵提供休息：**Parle Marie, Vimal Elaichi, Kamla Pasand, My11 Circle, Poker Baazi, Policy Bazaar**。

注意：我制作此浏览器插件仅供个人使用，未来可能会根据当前广告静音列表添加或移除静音广告。欢迎自由 Fork 本仓库添加自定义内容，或阅读自定义部分以添加您自己的广告静音列表。

---

## 安装

 **克隆** 此仓库到您的电脑 

   ```bash
   git clone https://github.com/pea1bee/hotstar-ipl-ad-mute
   ```
   （或者，您也可以在这里下载压缩包：https://github.com/pea1bee/hotstar-ipl-ad-mute/archive/refs/heads/main.zip）

## Google Chrome 安装

1. **打开 Chrome**，访问 `chrome://extensions/`
2. 在右上角启用 **开发者模式**（如果尚未启用）
3. 点击 **“加载已解压的扩展程序”**
4. 选择 `hotstar-ipl-ad-mute` 文件夹内的 `chrome` 文件夹
5. 在观看直播体育赛事时享受静音广告！

注意：对于其他基于 Chromium 的浏览器，如 **Microsoft Edge** 或 **Brave**，步骤相同。只需将网址改为 `edge://extensions/` 或 `brave://extensions/`

## Mozilla Firefox 安装
1. **打开 Firefox**，访问 `about:debugging` 
2. 点击 **此 Firefox**
3. 点击 **加载临时附加组件**
4. 选择 `hotstar-ipl-ad-mute/firefox` 文件夹中的 `manifest.json` 文件
5. 在观看直播体育赛事时享受静音广告！

注意：扩展程序安装后会一直存在，直到您移除它或重启 Firefox。

---

## 自定义


### 静音所有广告 
您可以在 `background.js` 中将 `MUTE_ALL_ADS` 变量设置为 `true`，以静音所有广告。

### 按广告 ID 静音
您可以通过修改 `background.js` 中的 `targetAdIds` 数组来自定义静音哪些广告。  
添加新的广告关键字：


```js
const targetAdIds = [
  "PARLE_MARIE",
  "KAMLA_PASAND",
  "DREAM11",
  // Add your own here
];
```
### 查找广告标识符的步骤（Google Chrome）：
1. **打开 Chrome**，进入扩展程序页面 `chrome://extensions/`
2. 找到并选择 `Hotstar IPL Ad Muter` 扩展。点击“详情”
3. 点击标有“检查视图”的部分
4. **在 IPL 直播期间**，查找控制台日志 `Ad detected:` 后跟的 `adName`
5. 将要静音的完整或唯一部分广告标识符添加到 `background.js` 中的 `targetAdIds` 数组

或者，您也可以打开浏览器开发者工具，在直播体育赛事期间的 **网络标签** 中查找以 `https://bifrost-api.hotstar.com/v1/events/track/ct_impression` 开头的 URL，并从 `adName` 查询参数中获取广告标识符。

---


## 注意事项
- 有时广播方会试图在下一场比赛开始前插入一个额外广告。如果广告被突然中断，直播画面可能会额外静音几秒钟，直到扩展程序取消静音标签页
- 如果 Hotstar 更改了当前的跟踪像素 URL，或更改了广告标识符中使用的格式或关键词，该扩展可能会失效

## 许可证

MIT © 2025



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---