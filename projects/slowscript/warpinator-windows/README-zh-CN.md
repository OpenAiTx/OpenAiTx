# Warpinator for Windows（非官方）

这是 Linux Mint 文件共享工具 [Warpinator](https://github.com/linuxmint/warpinator) 的非官方重写版本，适用于 Windows 7 及更高版本。

在 Linux、Windows 和 Android 设备之间传输文件

## ⚠️ 警告：假冒/恶意网站

`http://warpinator.com` 是一个假冒网站，可能具有恶意！

请**不要**从该网站下载或运行任何软件！

我们不知道是谁维护该网站。请参阅 [Linux Mint 团队的声明](https://github.com/linuxmint/warpinator?tab=readme-ov-file#%EF%B8%8F-warning-fakemalicious-website)。

## 下载
现已发布在 [Releases](https://github.com/slowscript/warpinator-windows/releases) 页面

或者可以通过 winget 安装：  
`winget install slowscript.Warpinator`

## 构建
需要 .NET SDK 4.7.2

使用 Visual Studio 构建

### 截图
![screenshot](https://raw.githubusercontent.com/slowscript/warpinator-windows/master/screenshot.png)

## 翻译
您需要一个较新的 Visual Studio 版本  
1）在 Resources 文件夹中创建一个新的资源文件，命名为 Strings.xx.resx，其中 xx 是您要翻译的语言代码  
2）复制 Strings.resx 中的整个表格并翻译其值。注释仅作上下文参考  
3）在设计器中打开 Controls\TransferPanel、Form1、SettingsForm 和 TransferFrom，对每个文件重复步骤 4-6  
4）选择顶层元素（整个窗口），在属性中将语言切换到您的目标语言  
5）选择带有文本的控件（按钮、标签、菜单），翻译它们的“Text”属性。无需翻译在运行时会被替换的明显占位符。可以通过简单运行应用程序（工具栏中的绿色播放箭头）验证。此外，TransferPanel 上的两个按钮被隐藏在另外两个按钮下面。  
6）您也可以移动和调整控件大小以适应新的字符串，且只会影响当前选择的语言  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-20

---