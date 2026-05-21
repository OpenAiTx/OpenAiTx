# shimmer - 支持 sidebery 的迷人 Firefox userchrome（v2.37）
![STAR BUTTON](https://github.com/user-attachments/assets/227bfd9e-ce3a-4d76-b8b7-24ad55dc128a)[![ISSUE](https://github.com/user-attachments/assets/648d41c3-4812-47fd-9696-38d76a2a0a5a)](https://github.com/nuclearcodecat/shimmer/issues)[![MONEY BUTTON](https://github.com/user-attachments/assets/18d7f816-f784-46b2-97b1-89173f68e227)](https://ko-fi.com/nuclearcodecat)

查看[更新日志](https://raw.githubusercontent.com/nuclearcodecat/shimmer/main/CHANGELOG.md)了解变更历史

### 嗨，我认为这个项目基本完成了。我不打算添加新功能，因为我不想继续开发它，而且我现在专注于一些大型项目。shimmer 看起来很棒，我就保持这样。欢迎随时提出请求，但我不保证会添加。感谢所有的好评和星标 :333

## 演示
<!--
![sidebarcollapse](https://github.com/user-attachments/assets/be8cb062-19f6-40b5-b26d-6a4fe8ceff7b)
-->
![out](https://github.com/user-attachments/assets/41ca27e6-701b-4049-8e38-76bcb300cd85)


| 使用 sidebery                                                                                    | 原生标签页                                                                                                  |
|---------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------|
| ![y](https://github.com/user-attachments/assets/6c8ce4d2-a9a8-478c-b427-77417f6a27a5) | ![x](https://github.com/user-attachments/assets/7b523c33-bec6-482a-9f01-3e478e75902e) |
<!-- | ![lightsidebery](https://github.com/user-attachments/assets/dd26f273-438e-42be-b77a-5d0df96b70bf) | ![greennative](https://github.com/user-attachments/assets/a60e6432-c919-4766-8353-609f1296315d)              | -->



| 菜单                                                                                       | 弹出式地址栏                                                                             |
|---------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------|
| ![ctxmenu](https://github.com/user-attachments/assets/7da9bdff-d247-4680-ad20-70d12c886272) | ![urlbar](https://github.com/user-attachments/assets/8b328ecf-0297-4e8c-8cb6-8826040c7916) |

### 折叠侧边栏
如演示中所示

### 紧凑查找栏
![findbar](https://github.com/user-attachments/assets/198c5ec8-6e59-46fb-8624-0baa90506c86)

### 生活质量改进
![longtab](https://github.com/user-attachments/assets/6ab029f9-1b67-4545-a898-bd680bd40000)

### 紧凑的类似 macOS 的窗口控制按钮
![winctr](https://github.com/user-attachments/assets/934849bd-19ba-4617-8bfe-f5b41508a872)

## 功能
 - 折叠侧边栏
 - 弹出式地址栏（见演示动画图）
 - 支持自定义主题  
 - 浏览器/侧边栏圆角设计  
 - 精简的上下文菜单  
 - 细腻且不干扰的过渡效果  
 - 精简的查找栏  
 - 可设置将侧边栏移至右侧  
 - 支持配置属性自定义  
 - 兼容 Firefox 夜间版  
 - 与原生垂直标签页半兼容  
 - 浮动状态面板  

## 安装  
 - 从 GitHub 克隆或下载代码（绿色“code”按钮）并解压  
 - 如需，可从 Mozilla 附加组件下载 Sidebery  
 - 打开 Sidebery 设置，滚动到底部（帮助部分）  
 - 点击“导入插件数据”  
 - 从下载的压缩包中选择“sidebery.json”  
 - 保持开关默认，点击“导入”  
 - 进入 about:config  
 - 切换 `toolkit.legacyUserProfileCustomizations.stylesheets` 为 true  
 - 切换 `svg.context-properties.content.enabled` 为 true  
 - 切换 `sidebar.revamp` 为 false  
 - 打开 about:profiles，找到你的配置文件并打开根文件夹  
 - 如果不存在，创建一个 `chrome` 文件夹  
 - 将 `userChrome.css`、`userContent.css` 文件及 `assets` 文件夹移动到 `chrome` 目录  
 - 重新打开 Firefox  
 - 完成！:3  
 - 请务必不时访问此 GitHub 页面下载最新版本，详见本说明的“更新”部分  
 - 参见本说明的“自定义”部分了解自定义选项  

## 更新  
 不时检查此 GitHub 页面，查看是否有新版本。你的安装版本显示在新标签页设置菜单的关闭按钮旁（新标签页右下角）。  
### 如何更新：  
 按照安装说明操作，若系统提示，允许文件浏览器替换文件（记得更新 Sidebery 样式）  

## 自定义  
 在 `userChrome.css` 文件顶部，有可自定义的 CSS 变量，包括标签大小选项、圆角、某些项目间距等。在这些变量下方，还有右键菜单排除项。根据需要注释或取消注释以启用或禁用相应选项。  
  
 我还为你实现了一些可修改的自定义 `about:config` 布尔值  
 - `shimmer.disable-collapsing-sidebar` – 切换为 true 以禁用侧边栏折叠（不幸的是，这还需要注释掉部分 Sidebery 样式，这些样式在 Sidebery 设置的样式编辑器中有标记）
 - `shimmer.remove-winctr-buttons` – 切换为 true 以移除窗口控制按钮
 - `shimmer.remove-firefox-view-button` – 切换为 true 以移除 Firefox 视图按钮
 - `shimmer.disable-popover-transition` – 切换为 true 以移除地址栏的弹出过渡效果
 - `shimmer.disable-urlbar-background-transition` – 切换为 true 以移除地址栏背景在弹出动画期间的细微过渡效果
 - `shimmer.disable-popover-urlbar` – 切换为 true 以移除地址栏的弹出效果
 - `shimmer.native-vertical-tabs` – 切换为 true 使用 Firefox 的垂直标签页而非 Sidebery。使用*水平*标签页时不要切换为 true，否则标签页会消失
 - `shimmer.show-sidebar-header` – 切换为 true 以显示侧边栏头部
 - `shimmer.show-sidebar-header-close-button` - 即使启用头部，关闭按钮默认隐藏。切换为 true 使其重新显示
 - `shimmer.sidebar-right-side` – 如果在右侧使用 Sidebery，切换为 true。你必须先在 Firefox 中通过侧边栏头部移动侧边栏，并且必须在配置中重新启用头部
 - `shimmer.reverse-winctr-buttons-side` – 切换为 true 将窗口控制按钮移至左侧
 - `shimmer.taller-tabs` – 切换为 true 使标签页高度与默认 Firefox 标签页相同
 - `shimmer.shorter-navbar` – 切换为 true 使导航栏高度与未修改的 Firefox 相同（可能需要重启 Firefox）
 - `shimmer.disable-compact-winctr-buttons` – 切换为 true 使紧凑型窗口控制按钮恢复默认样式
 - `shimmer.dont-expand-selected-tab` – 切换为 true 禁用在打开多个标签页时激活标签页扩展效果
 - `shimmer.enable-theme-aware-wallpapers` – 切换为 true 使 Firefox 显示用户选择的壁纸。要更换壁纸，打开 chrome 目录，替换 walls 目录中的 *light* 和 *dark* 文件为你想要的图片，然后执行 `makewalls.sh`。请注意这是一个 bash 脚本。如果壁纸无法使用，尝试缩小图片，遗憾的是大文件会导致失败——安全大小限制小于 1MiB。

## 维护
 请记住，我不一定能在一天内修复由 Firefox 新版本引起的问题。如果你愿意创建拉取请求，欢迎这样做。如果发现任何问题，请在 GitHub 的“issues”标签页中报告。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---