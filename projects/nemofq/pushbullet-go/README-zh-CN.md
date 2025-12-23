# Pushbullet Go

[![Chrome Web Store Version](https://img.shields.io/chrome-web-store/v/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg) [![Chrome Web Store Users](https://img.shields.io/chrome-web-store/users/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg) [![Chrome Web Store Rating](https://img.shields.io/chrome-web-store/rating/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg)

> **注意 1**：由于 Chrome 网上应用店政策，扩展名称已更改为“Push Go”。
>
> **注意 2**：这是 Pushbullet API 的第三方开源客户端。与该服务无关联，亦未获其认可。

![Pushbullet Go](https://raw.githubusercontent.com/nemofq/pushbullet-go/main/screenshots/1_popup.png)

一个轻量级的 Pushbullet Chrome 扩展，允许您直接从浏览器接收和发送推送。

该扩展兼容 Manifest V3，是官方扩展不再可用时的替代方案。

[![](https://developer.chrome.com/static/docs/webstore/branding/image/UV4C4ybeBTsZt43U4xis.png)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg)

## 功能

需要一个 [Pushbullet](https://www.pushbullet.com/) 账户。功能包括：

- 接收和发送推送
- 通过粘贴、拖拽或上传推送文件/图片（由于 Chrome 限制，上传在独立窗口中进行）
- 通过右键菜单推送当前页面的 URL、选中文本或图片，并可选择设备/联系人
- 选择设备以控制推送目标
- 收到推送时显示通知，带打开链接和关闭按钮
- 自动在新标签页打开收到的链接（默认关闭，可在选项页启用）
- 本地存储最近 100 条推送（完整历史可在 Pushbullet 网站查看）
- （新增）按目标设备过滤显示和通知推送
- （新增）控制来自浏览器的推送通知（适用于多浏览器场景）
- （新增）通知镜像（需安装并启用 Pushbullet 安卓应用及 Push Go 设置）
- （新增）暗黑模式（默认跟随系统，或手动选择）
- （新增）支持 33 种语言的国际化
- （新增）未读计数
- （新增）弹出窗口快速分享当前标签页链接（默认关闭，可在选项页启用）
- （新增）通知时播放声音（可在选项页关闭）
- （新增）通知镜像端到端加密
- （新增）从镜像通知中提取验证码（点击弹出窗口复制）

## 安装
> **注意 3**：需 Chrome 116 及以上版本，以使用 `chrome.idle` API 维持与 Pushbullet WebSocket 服务器的连接。
### 推荐安装

直接从[Chrome 网上应用店](https://chromewebstore.google.com/detail/push-go/dghndapbehjdbhiffbckojkhoennbofg)安装，或：

### 手动安装

1. 从 `release/` 文件夹下载并解压扩展
2. 打开 Chrome 并导航至 `chrome://extensions/`
3. 在右上角启用“开发者模式”
4. 点击“加载已解压的扩展程序”，选择解压后的 `/src` 文件夹

## 设置

1. 点击扩展图标，选择“打开设置”
2. 通过 OAuth 认证或手动输入访问令牌（来自[Pushbullet 设置](https://www.pushbullet.com/#settings/account)）
3. 点击检索按钮，开始发送和接收推送！
4. 根据需要在选项页面自定义设置

## 权限

此扩展需要以下权限：
- **存储**：本地保存您的选项和推送历史
- **空闲**：保持连接以实时接收推送
- **通知**：显示推送通知
- **上下文菜单**：添加右键菜单选项以推送内容
- **活动标签页**：访问当前页面的 URL 和标题，用于上下文菜单和快捷键操作
- **主机访问**：与 Pushbullet API 服务器通信
- **离屏**：播放通知声音
- **身份**：完成 OAuth 过程

## 隐私

此扩展所有数据均存储在本地，不会传输任何信息到 Pushbullet API 之外。

## 许可

本项目使用[AGPL-3.0 许可](https://github.com/nemofq/pushbullet-go?tab=AGPL-3.0-1-ov-file)。如有功能请求或反馈，欢迎创建 issue 或提交 pull request。

## 还有一件事


如果你也是 iOS+Pushbullet 用户，可能会发现这些快捷指令很有用：

- [推送到 Pushbullet](https://www.icloud.com/shortcuts/5549bbb5b06e4f0a8ccb1b6fd33e853f)
- [Pushbullet 接收器](https://www.icloud.com/shortcuts/1f94913de21b41debe60ef43631afde2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---