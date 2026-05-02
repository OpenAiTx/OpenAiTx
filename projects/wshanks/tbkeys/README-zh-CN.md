[![Contributor Covenant](https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg)](code_of_conduct.md)

# <a name="intro"></a>tbkeys

`tbkeys` 是 Thunderbird 的一个附加组件，使用 [Mousetrap](https://craig.is/killing/mice) 将按键序列绑定到自定义命令。

## 安装

- 从 [GitHub 发布页面](https://github.com/willsALMANJ/tbkeys/releases) 列出的某个版本中下载 tbkeys.xpi 文件。
- 在 Thunderbird 中打开附加组件管理器（工具 -> 附加组件）。
- 点击右上角的齿轮图标，选择“从文件安装附加组件...”，然后选择下载的 tbkeys.xpi 文件。
- 当发布新版本时，该附加组件会自动从 GitHub 发布页面更新。

该附加组件的 [tbkeys-lite](#tbkeys-lite) 版本也可以通过在 Thunderbird 附加组件管理器中搜索“tbkeys-lite”从 addons.thunderbird.net 安装，或者从[此页面](https://addons.thunderbird.net/en-US/thunderbird/addon/tbkeys-lite/)下载 xpi 文件并按照上述步骤安装。

## 默认按键绑定

主窗口的默认按键绑定模仿了 GMail 的按键绑定。

| 按键 | 功能                                               |
| --- | ------------------------------------------------- |
| c   | 撰写新邮件                                         |
| r   | 回复                                               |
| a   | 回复所有                                           |
| f   | 转发                                               |
| #   | 删除                                               |
| u   | 刷新邮件。如果消息标签页打开，则关闭它。           |
| j   | 下一条消息                                         |
| k   | 上一条消息                                         |
| o   | 打开消息                                           |
| x   | 归档消息                                           |

## 自定义按键绑定

要自定义按键绑定，请修改附加组件偏好设置面板中的“key bindings”条目，可以通过附加组件管理器中的该附加组件条目访问（Thunderbird 菜单中的“附加组件”）。
设置按键绑定时需要考虑以下几点：

- “key bindings”条目应为一个 JSON 对象，将按键绑定（使用 [Mousetrap 语法](https://craig.is/killing/mice)）映射到有效命令（参见[命令语法](#command-syntax)）部分。
- 偏好设置页面中有单独的字段用于设置 Thunderbird 主窗口和撰写窗口的按键绑定。
  按键绑定不会在其他窗口触发。
- 键绑定在文本输入字段中不会触发，除非第一个按键组合包含除 `shift` 以外的修饰键。
- 首选项页面不允许提交无效的 JSON，但除此之外不会对键绑定进行合理性检查。
- 这个[关于 Keyconfig 的旧维基页面](http://kb.mozillazine.org/Keyconfig_extension:_Thunderbird)也包含一些仍然有效的命令。
- 开发者工具箱（菜单中 工具->开发者工具->开发者工具箱）对于查看界面元素名称以调用函数非常有用。
- 定义一个按键序列（即连续多个按键），其中第一个按键组合与内置快捷键相同（例如 `ctrl+j ctrl+k`）是不支持的。
  可以将带修饰键的单个按键映射为覆盖内置快捷键，但不支持序列。

### 命令语法

可以为键绑定指定几种不同风格的命令。
它们是：

- **简单命令**：这些命令格式为 `cmd:<command_name>`，其中 `<command_name>` 是 Thunderbird 可以通过 `goDoCommand()` 执行的命令。
  大多数命令名称可以在 Thunderbird 源代码的[主命令集文件](https://hg.mozilla.org/comm-central/file/tip/mail/base/content/mainCommandSet.inc.xhtml)中找到。
- **简单函数调用**：这些命令格式为 `func:<func_name>`，其中 `<func_name>` 是 Thunderbird 窗口对象上定义的一个函数。
  该函数调用时不带任何参数。
- **自定义函数调用**：这些命令格式为 `tbkeys:<func_name>`，其中 `<func_name>` 是在 tbkeys 中编写的自定义函数名。
  目前，唯一可用的自定义函数是 `closeMessageAndRefresh`，它会关闭当前打开的标签页（如果不是第一个标签页），然后刷新所有账户。
  此行为模拟了 GMail 快捷键 `u` 的行为。
- **取消绑定**：这些条目仅包含文本 `unset`。
  当触发 `unset` 键绑定时，不会发生任何操作。
  这对于取消你不希望意外触发的内置 Thunderbird 键绑定非常有用。
- **MailExtension 消息**：这些命令格式为 `memsg:<extensionID>:<message>`，其中 `<extensionID>` 是要发送消息的 Thunderbird 扩展的 ID，`<message>` 是通过 `browser.runtime.sendMessage()` MailExtension API 发送给扩展的字符串消息。
  目前只支持字符串消息，因为 `tbkeys` 以字符串形式存储命令，但未来可能会放宽此限制。
- <a name="eval"></a>**Eval 命令**：这些条目可以包含任意 JavaScript 代码，tbkeys 在触发键绑定时会调用 `eval()` 执行。
  任何不匹配其他命令类型前缀的条目都被视为 eval 命令。
  **注意：** eval 命令在 tbkeys-lite 中不可用，功能上等同于 unset 命令。

## 常用键绑定

以下是一些常用键绑定的 eval 命令示例：

- **下一个标签页**：`window.document.getElementById('tabmail-tabs').advanceSelectedTab(1, true)`
- **上一个标签页**：`window.document.getElementById('tabmail-tabs').advanceSelectedTab(-1, true)`
- **关闭标签页**：`func:CloseTabOrWindow`
- **向下滚动消息列表**：`window.document.getElementById('threadTree').scrollByLines(1)`
- **向上滚动消息列表**：`window.document.getElementById('threadTree').scrollByLines(-1)`
- **向下滚动消息正文**：
  - v115+：`window.gTabmail.currentAboutMessage.getMessagePaneBrowser().contentWindow.scrollBy(0, 100)`
  - v102：`window.document.getElementById('messagepane').contentDocument.documentElement.getElementsByTagName('body')[0].scrollBy(0, 100)`
- **向上滚动消息正文**：
  - v115+：`window.gTabmail.currentAboutMessage.getMessagePaneBrowser().contentWindow.scrollBy(0, -100)`
  - v102：`window.document.getElementById('messagepane').contentDocument.documentElement.getElementsByTagName('body')[0].scrollBy(0, -100)`
- **创建新文件夹**：`window.goDoCommand('cmd_newFolder')`
- **订阅订阅源**：`window.openSubscriptionsDialog(window.GetSelectedMsgFolders()[0])`

## 取消默认快捷键绑定

首选项面板中的“取消单键”按钮可用于取消 Thunderbird 主窗口中默认的单键绑定。  
此功能会将 Thunderbird 默认的所有单键快捷键设置为 `unset`，除非它们当前已在 tbkeys 的首选项中设置（即不会覆盖 tbkeys 已有的单键快捷键设置）。

## <a name="tbkeys-lite"></a>tbkeys 与 tbkeys-lite

tbkeys-lite 是去除了执行任意 JavaScript 功能的 tbkeys 版本。

## 安全性、隐私及实现

安装前，Thunderbird 会提示扩展请求“对 Thunderbird 和您的计算机拥有完全、不受限制的访问权限”。  
请求此权限的原因是 tbkeys 必须将键盘监听器注入 Thunderbird 用户界面，以监听快捷键。  
为此，tbkeys 使用了早于 MailExtensions 的旧版 Thunderbird 扩展接口。  
该接口是 Thunderbird 68 之前所有扩展所使用的。  
提供更严格扩展控制的新 MailExtensions API 并不包含键盘快捷键 API。  
如果您希望 Thunderbird 增加键盘快捷键 API，请考虑为该项目贡献代码。  
或许可从 Thunderbird 问题跟踪中的[此工单](https://bugzilla.mozilla.org/show_bug.cgi?id=1591730)开始。

要进一步讨论与 tbkeys 相关的安全考虑，需先审视其实现。  
如[介绍](#intro)中所述，tbkeys 依赖 Mousetrap 库管理快捷键绑定。  
tbkeys 的主要逻辑在 [implementation.js](https://raw.githubusercontent.com/wshanks/tbkeys/main/addon/implementation.js)，这是一个[MailExtension 实验](https://developer.thunderbird.net/add-ons/mailextensions/experiments)。  
`implementation.js` 设置实验 API，允许 tbkeys 标准（作用域受限）MailExtension 调用该 API，将快捷键绑定到函数（包括解除绑定的空函数）和发送给其他扩展的消息。  
`implementation.js` 还将 Mousetrap 加载到每个 Thunderbird 窗口，调整 Mousetrap 捕获键事件的条件以适应 Thunderbird 特有的 UI 元素，并定义执行用户指定的快捷键绑定功能的函数。  
这就是 `implementation.js` 的全部功能。  
它不访问本地文件系统或任何邮件数据，也不访问网络。

tbkeys 支持的命令模式之一是 [eval](#eval)。  
该模式使用 `eval()` 在 `implementation.js` 中执行用户提供的任意代码，具有对 Thunderbird 内部的完全访问权限。  
如果不需要绑定任意代码，使用不支持 eval 命令的 [tbkeys-lite](#tbkeys-lite) 可能更安全。  
tbkeys-lite 版本发布在 [Thunderbird 附加组件页面](https://addons.thunderbird.net/en-US/thunderbird/addon/tbkeys-lite/)。  
那里发布的附加组件会经过独立的人工审核。  
在您与开发者之间有这道审核屏障，能提供额外一层安全保障。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-02

---