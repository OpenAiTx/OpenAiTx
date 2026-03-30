![image](https://user-images.githubusercontent.com/693717/210183526-1708c821-172e-4c71-9b02-2a9885654505.svg)

# QuickLook.Plugin.WebViewPlus

[QuickLook](https://github.com/QL-Win/QuickLook) 插件，用于通过 [WebViewPlus](https://github.com/mooflu/WebViewPlus) 预览各种文件类型。

## 试用

1. 访问 [Release 页面](https://github.com/mooflu/QuickLook.Plugin.WebViewPlus/releases) 并下载最新版本。
2. 确保 QuickLook 正在后台运行。进入下载文件夹，选中下载的 `.qlplugin` 文件，按下 <key>空格键</key>。
3. 在弹出窗口中点击“安装”按钮。
4. 重启 QuickLook。
5. 要配置通过 WebViewPlus 预览的文件类型，打开一个 html 文件，点击右下角的齿轮按钮。

## 开发

 1. 克隆此项目。别忘了更新子模块。
 2. 将 WebViewPlus web 应用复制到 `webApp` 文件夹，或设置插件配置项 `WebAppUrl` —— 参见 `WebpagePanel.cs`
 3. 在 `Debug` 配置中将 `Output path` 设置为类似 `..\QuickLook.upstream\Build\Debug\QuickLook.Plugin\QuickLook.Plugin.WebViewPlus\`
 4. 使用 `Debug` 配置构建插件项目
 5. 使用 `Debug` 配置构建并运行上游 QuickLook

 # 发布
 1. 使用 `Release` 配置构建项目。
 2. 运行 `Scripts\pack-zip.ps1`。
 3. 你应该会在项目目录中找到名为 `QuickLook.Plugin.WebViewPlus.qlplugin` 的文件。

## 许可

MIT 许可证。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---