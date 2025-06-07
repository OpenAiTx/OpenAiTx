# Microsoft PowerToys

![Microsoft PowerToys 的主形象](doc/images/overview/PT_hero_image.png)

[如何使用 PowerToys][usingPowerToys-docs-link] | [下载及发行说明][github-release-link] | [贡献 PowerToys](#contributing) | [最新动态](#whats-happening) | [路线图](#powertoys-roadmap)

## 关于

Microsoft PowerToys 是一组为高级用户设计的实用工具，可优化和简化 Windows 使用体验，提高生产力。关于 [PowerToys 概览和如何使用这些工具][usingPowerToys-docs-link]，或其他 [Windows 开发环境](https://learn.microsoft.com/windows/dev-environment/overview)的相关工具和资源，请访问 [learn.microsoft.com][usingPowerToys-docs-link]！

|              | 当前实用工具：      |              |
|--------------|--------------------|--------------|
| [高级粘贴](https://aka.ms/PowerToysOverview_AdvancedPaste) | [置顶显示](https://aka.ms/PowerToysOverview_AoT) | [PowerToys 唤醒](https://aka.ms/PowerToysOverview_Awake) |
| [取色器](https://aka.ms/PowerToysOverview_ColorPicker) | [命令未找到](https://aka.ms/PowerToysOverview_CmdNotFound) | [命令面板](https://aka.ms/PowerToysOverview_CmdPal) |
| [裁剪与锁定](https://aka.ms/PowerToysOverview_CropAndLock) | [环境变量](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones 分区管理](https://aka.ms/PowerToysOverview_FancyZones) |
| [文件资源管理器插件](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [文件锁定器](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts 文件编辑器](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [图片批量调整大小](https://aka.ms/PowerToysOverview_ImageResizer) | [键盘管理器](https://aka.ms/PowerToysOverview_KeyboardManager) | [鼠标工具](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [无边界鼠标](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [新建+](https://aka.ms/PowerToysOverview_NewPlus) | [以纯文本粘贴](https://aka.ms/PowerToysOverview_PastePlain) |
| [快速预览](https://aka.ms/PowerToysOverview_Peek) | [Power重命名](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run 启动器](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [快捷重音符](https://aka.ms/PowerToysOverview_QuickAccent) | [注册表预览](https://aka.ms/PowerToysOverview_RegistryPreview) | [屏幕标尺](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [快捷键指南](https://aka.ms/PowerToysOverview_ShortcutGuide) | [文本提取器](https://aka.ms/PowerToysOverview_TextExtractor) | [工作区](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt 屏幕放大](https://aka.ms/PowerToysOverview_ZoomIt) |

## 安装和运行 Microsoft PowerToys

### 系统要求

- Windows 11 或 Windows 10 2004 版（代号 20H1 / 构建号 19041）及以上版本。
- x64 或 ARM64 处理器
- 安装程序将安装以下内容：
   - [Microsoft Edge WebView2 运行时](https://go.microsoft.com/fwlink/p/?LinkId=2124703) 启动器。此操作将安装最新版本。

### 通过 GitHub 下载 EXE [推荐]

访问 [Microsoft PowerToys GitHub 发布页面][github-release-link]，点击底部的 `Assets` 显示本次发布的所有文件。请选择与您设备架构和安装范围相匹配的 PowerToys 安装程序。大多数情况下，选择 `x64` 并按用户安装即可。

<!-- 需要根据版本更新的内容 -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  描述   | 文件名 | sha256 哈希 |
|---------|--------|-------------|
| 按用户 - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| 按用户 - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| 全局 - x64         | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| 全局 - ARM64       | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

这是我们的首选安装方式。

### 通过 Microsoft Store

可在 [Microsoft Store 的 PowerToys 页面][microsoft-store-link] 进行安装。必须使用 [新版 Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/)，该商店适用于 Windows 11 和 Windows 10。

### 通过 WinGet
可通过 [WinGet][winget-link] 下载 PowerToys。使用 winget 更新 PowerToys 时会遵循当前 PowerToys 的安装范围。要安装 PowerToys，请在命令行/PowerShell 下运行以下命令：

#### 用户范围安装程序 [默认]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### 全局范围安装程序

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### 其他安装方式

还有 [社区驱动的安装方式](./doc/unofficialInstallMethods.md)，如 Chocolatey 和 Scoop。如需使用这些方式，请参考相应的安装说明。

## 第三方 Run 插件

社区还开发了 [第三方插件](./doc/thirdPartyRunPlugins.md)，它们不会随 PowerToys 一同分发。

## 贡献

本项目欢迎所有类型的贡献。除了代码功能和缺陷修复，还可以通过编写规范、设计、文档撰写和查找漏洞等方式提供帮助。我们很高兴与高级用户社区一起合作，开发一套工具，帮助大家更好地利用 Windows。

我们建议**在开始你希望贡献的功能之前**，请阅读我们的 [贡献者指南](CONTRIBUTING.md)。我们很乐意与你合作，找出最佳实现方式，在功能开发过程中提供指导和辅导，并帮助避免重复或无效的工作。

大多数贡献需要你同意一份 [贡献者许可协议 (CLA)][oss-CLA]，声明你授权我们使用你的贡献并且你有权这样做。

关于 PowerToys 开发的指导，请参阅 [开发者文档](/doc/devdocs)，了解详细的分解说明，包括如何设置你的电脑以便编译。

## 最新动态

### PowerToys 路线图

我们的 [优先级路线图][roadmap]，展示了核心团队当前关注的功能和工具。

### 0.91 - 2025年5月更新

本次版本重点是新功能、稳定性和自动化。

**✨亮点**

 - 我们大幅提升了命令面板（Command Palette）的性能并修复了大量 bug。新增功能包括：
 - 命令面板支持通过回退命令搜索任意文件。
 - 命令面板全局热键可设置为低级键盘钩子。
 - WebSearch 扩展新增打开 URL 的回退命令，支持用户直接从命令面板在浏览器中打开网址。
 - 你现在可以在 PT Run 和命令面板的日期和时间插件中自定义格式。感谢 [@htcfreek](https://github.com/htcfreek)！

### 高级粘贴

 - 修复了高级粘贴在某些英语语言标签（如 en-CA）下无法创建 OCR 引擎的问题，通过使用用户配置文件语言初始化 OCR 引擎。感谢 [@cryolithic](https://github.com/cryolithic)！

### 取色器

 - 修复了资源泄漏导致的卡顿或崩溃问题，正确释放 Graphics 对象。感谢 [@dcog989](https://github.com/dcog989)！
 - 修复了取色器在按 Backspace 键时退出的问题，确保仅在聚焦时关闭，并统一 Escape/Backspace 行为。感谢 [@PesBandi](https://github.com/PesBandi)！
 - 取色器增加了对 Oklab 和 Oklch 颜色格式的支持。感谢 [@lemonyte](https://github.com/lemonyte)！

### 命令未找到

 - 更新了 WinGet Command Not Found 脚本，仅在实验性特性实际存在时才启用。

### 命令面板

 - 更新了 bug 模板，包含命令面板模块。
 - 修复了 toast 窗口未按 DPI 缩放导致显示比例异常的问题。
 - 修复了当光标在位置 0 时，上/下键导航无法移动选择项问题，并实现类似 PT Run v1 的连续导航。感谢 [@davidegiacometti](https://github.com/davidegiacometti)！
 - 简化并提升时间和日期扩展代码的可读性。
 - 修复了命令大小写导致“定位鼠标指针”命令失败的问题，通过将命令调整为小写解决。
 - WebSearch 扩展增加了打开 URL 的回退命令，支持用户直接从命令面板在浏览器中打开网址。感谢 [@htcfreek](https://github.com/htcfreek)！
 - 增加设置项，可在 CmdPal 中启用/禁用系统托盘图标，并与 Windows 11 术语保持一致。感谢 [@davidegiacometti](https://github.com/davidegiacometti)！
 - 修复别名更新问题，设置新别名时自动移除旧别名。
 - 通过将 Exts 和 exts 迁移至新 ext 目录，解决了 GitHub 大小写冲突，保证平台间结构一致，防止路径碎片化。
 - 修复了“创建新扩展”命令生成空文件名的问题。
 - 全局热键支持设置为低级键盘钩子。
 - 支持 JUMBO 缩略图，可获取高分辨率图标。
 - 修复 CmdPal 在 MSAL 对话框打开时自动隐藏自身导致崩溃的问题，通过禁用时防止隐藏。
 - 页面加载时支持立即选中搜索文本。
 - 修复扩展设置页面重新打开时未能重新加载的问题，通过保存扩展设置时刷新设置表单。
 - 修复命令面板无法由 runner 启动的问题。
 - 重构并移植 PowerToys Run v1 计算器逻辑至命令面板，增加设置支持并优化回退行为。
 - 恢复列表项键盘快捷键支持。
 - 增强命令面板无障碍访问性，完善标签、动画、语言本地化，修复 a11y 相关问题。
 - 移植自定义格式支持到时间和日期插件，重排并优化设置，提升错误提示，修复极端情况下的崩溃，使功能更强大和易用。感谢 [@htcfreek](https://github.com/htcfreek)！
 - 系统命令增加回退项。
 - 修复 Windows 系统命令中“打开回收站”操作按键提示错误显示为“Empty”问题。感谢 [@jironemo](https://github.com/jironemo)！
 - 修复“更多命令”列表显示了不应出现命令的问题。感谢 [@davidegiacometti](https://github.com/davidegiacometti)！
 - 修复命令面板详细视图图标过大及文本对齐问题，使其与 Windows 搜索一致。
 - 修复标签过长时，空屏内容和命令栏命令显示被截断问题，确保布局与可见性正常。
 - 优化 CmdPal 的 WinGet 集成，修复已安装包的版本显示、支持带图标更新、将预览 winget API 迁移到稳定版。
 - 修复 ContentPage 命令未及时更新的问题，保证右键菜单变更时完全初始化。
 - 时间日期扩展支持回退查询，直接输入日期/时间无需提前选择命令。
 - 跨多个 CmdPal 项目文件引入 Common.Dotnet.AotCompatibility.props，增强 AoT 编译支持。
 - 修复 CmdPal 设置在 settings.json 缺少或未定义热键时因 HotKey 为 null 导致的崩溃。感谢 [@davidegiacometti](https://github.com/davidegiacometti)！
 - CmdPal 支持可过滤、嵌套右键菜单，并带搜索框以保持焦点行为。
 - 重构 CmdPal 类以提升 JSON 序列化性能，新增序列化上下文以优化性能和易维护性。
 - 支持提前编译（AoT）。
 - CmdPal 启动增加重试机制。
 - 从 CmdPal.Common 移除部分未使用文件，简化代码以便标记为 AoT 兼容。
 - 修复 SearchText 更新竞态条件导致输入框光标自动跳到行尾的问题，确保 SearchText 仅在实际变更后更新。
 - 回退命令支持搜索任意文件。
 - 清理 AoT 相关代码，防止测试时重复操作。
 - 通过扩展启动并行处理、增加超时，缩短 CmdPal 加载时间，防止异常扩展阻塞其他扩展。
 - 列表清空时自动关闭详情窗格，避免视觉状态不一致。
 - CmdPal 未找到匹配命令时支持取消回退命令，确保更干净的重载行为。
 - 修复 CmdPal 扩展模板中的泄漏问题，解决 ComServer 使用不当。
 - 禁止双击标题栏最大化 CmdPal 窗口，保证窗口行为一致。感谢 [@davidegiacometti](https://github.com/davidegiacometti)！
 - 修复设置界面窗口过小的问题，使窗口尺寸支持 DPI 感知并强制最小宽高，使用 WinUIEx 实现。
 - 通过隐藏窗口而非直接关闭，修复 CmdPal 白屏闪烁和一次性动画问题。
 - 启动时不再批量获取所有扩展设置，采用懒加载降低初始化开销。
 - 支持在 Adaptive Card 解析失败时保护 CmdPal 不崩溃。
 - CmdPal 用 URI 激活替代 shell:AppsFolder，提高稳定性。
 - 支持从 PowerToys 设置直接打开 CmdPal 设置。
 - CmdPal 支持实时观察并动态更新扩展详情，通过监听所选项属性变化实现。
 - CmdPal 扩展模板使用的工具包版本升级至 0.2.0。

### 图片批量调整大小

 - 修复删除图片调整大小预设时，误删其他预设的问题。

### 键盘管理器

 - 修复未指定左右时设置修饰键后卡键问题，通过记录按下的按键并发送正确按键修复。感谢 [@mantaionut](https://github.com/mantaionut)！

### Power重命名

 - 增强时间格式能力，支持 12 小时制及 AM/PM 格式。感谢 [@bitmap4](https://github.com/bitmap4)！

### PowerToys Run

 - “时间和日期”插件支持自定义格式，并改进无效输入格式的错误提示。感谢 [@htcfreek](https://github.com/htcfreek)！
 - 修复两个崩溃问题：一个是极早日期导致的 WFT 崩溃，另一个是极晚日期（如 31.12.9999）计算月周时崩溃，并重新排序 UI 设置。感谢 [@htcfreek](https://github.com/htcfreek)！
 - 修复命令大小写导致“定位鼠标指针”命令失败问题，通过调整命令为小写解决。
 - 插件“加载错误”和“初始化错误”消息中增加版本信息。感谢 [@htcfreek](https://github.com/htcfreek)！
 - 优化结果模型，支持阻止基于使用频率的排序，插件开发者可更灵活地控制排序行为。感谢 [@CoreyHayward](https://github.com/CoreyHayward) 和 [@htcfreek](https://github.com/htcfreek)！

### 快捷重音符

 - 更新 GetDefaultLetterKeyEPO 中的字母映射，将 VK_U 键的“ǔ”替换为“ŭ”，更准确反映世界语发音。感谢 [@OlegKharchevkin](https://github.com/OlegKharchevkin)！
 - 修复屏幕键盘下快捷重音符无法正常工作的问题。感谢 [@davidegiacometti](https://github.com/davidegiacometti)！

### 注册表预览

 - 增强注册表预览，支持粘贴注册表键和值无需手写文件头，并新增重置应用按钮。感谢 [@htcfreek](https://github.com/htcfreek)！

### 设置

 - 修复设置应用在任务栏偶尔显示空白图标的问题，延迟分配图标直到窗口激活。
 - 增加“新功能”窗口最大化功能，提升阅读体验。

### 工作区

 - 修复 Steam 游戏无法被捕获或正确启动的问题，通过更新窗口过滤和集成 Steam URL 协议处理。

### 文档

 - PowerToys Run 第三方插件文档新增 QuickNotes。感谢 [@ruslanlap](https://github.com/ruslanlap)！
 - PowerToys Run 第三方插件文档新增天气和番茄钟插件。感谢 [@ruslanlap](https://github.com/ruslanlap)！
 - PowerToys Run 第三方插件文档新增 Linear 插件。感谢 [@vednig](https://github.com/vednig)！
 - 修复文档文件排版问题，更新贡献者与团队成员信息。感谢 [@DanielEScherzer](https://github.com/DanielEScherzer) 和 [@RokyZevon](https://github.com/RokyZevon)！

### 开发

 - 更新 GitHub Action，安装 .NET 9 以支持 MSStore 发行。
 - 更新 bug_report.yml 中的版本占位符，防止问题报告中出现错误的 v0.70.0 版本号。
 - GitHub Action 中 actions/setup-dotnet 从 v3 升级到 v4，支持 MSStore 发行。
 - WinGet 配置文件新增 securityContext，允许从用户上下文调用并为提权资源单独弹出一次 UAC。感谢 [@mdanish-kh](https://github.com/mdanish-kh)！
 - 将日志文件扩展名从 .txt 改为 .log，支持正确的文件关联和工具兼容性，并为 Workspace 增加日志。感谢 [@benwa](https://github.com/benwa)！
 - 升级测试框架依赖，统一各组件包版本。
 - 升级依赖以修复安全漏洞。
 - 通过将 GitHub Actions 和 Docker 标签固定到不可变的完整提交，集成自动依赖安全漏洞扫描，增强代码库安全。感谢 [@Nick2bad4u](https://github.com/Nick2bad4u)！
 - Boost 依赖升级至新版本。
 - 工具包升级到最新版，抑制 AoT 相关警告。
 - 修复新添加文件未签名导致构建失败的问题。
 - 更新发布流程，防止发布私有符号长达 100 年。
 - 为 PowerRename 引入模糊测试提升可靠性，并补充文档指导如何扩展至其他 C++ 模块。
 - 为所有 .csproj 项目集中预创建生成文件夹，防止构建失败。
 - WinAppSDK 升级至最新 1.7 版。
 - PowerRename Fuzzing 项目 Boost 依赖升级至最新版本。
 - tsa.json 中 ADO 区域路径更新，解决 TSA 流水线因路径废弃导致的错误。
 - CmdPal 提前编译（AoT）支持已启动，基础工作进行中。
  
### 工具/通用

 - 支持通过生成包含系统和诊断信息的预填 GitHub 问题 URL，自动化提交 bug 报告。感谢 [@donlaci](https://github.com/donlaci)！
 - 增加本地构建安装包的脚本，确保 CmdPal 可在本地环境下启动。
 - 移除导出 PFX 逻辑，消除硬编码密码并解决 PSScriptAnalyzer 安全警告。
 - 增加 PowerShell 脚本和 CI 集成，强制 src 目录下所有 C# 项目一致引用 Common.Dotnet.CsWinRT.props。
   
### 0.92 版本计划内容

对于 [v0.92][github-next-release-work]，我们将重点推进以下工作：

 - 持续优化命令面板
 - 新的 UI 自动化测试
 - 安装程序升级
 - 键盘管理器编辑器 UI 升级
 - 稳定性提升 / bug 修复

## PowerToys 社区

PowerToys 团队非常感谢 [活跃而出色的社区][community-link] 的支持。你们的工作极其重要。没有你们的帮助，比如提交 bug、完善文档、指导设计或开发新功能，PowerToys 不会有今天的成就。我们想向大家致谢，并花时间表彰你们的贡献。每个月，你们都在直接推动 PowerToys 成为更好的软件。

## 行为准则

本项目已采纳 [Microsoft 开源行为准则][oss-conduct-code]。

## 隐私声明

应用会记录基础诊断数据（遥测）。关于隐私和我们收集的数据详情，请参阅我们的 [PowerToys 数据和隐私文档](https://aka.ms/powertoys-data-and-privacy-documentation)。

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---