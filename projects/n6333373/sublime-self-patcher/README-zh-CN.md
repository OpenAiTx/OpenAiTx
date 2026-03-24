## Sublime 自我修补器

这是一个 Sublime Text 4 插件，可以修补 Sublime Text 和 Sublime Merge。

🔥 不需要任何第三方依赖。你唯一需要的是 Sublime Text。

## 支持的环境

| 标志 | 含义                                                                   |
| ---- | --------------------------------------------------------------------- |
| ✅   | 支持。                                                                |
| ⚠️   | 不稳定的修补模式。你可能需要频繁更新此插件。                          |
| ☠️   | 抱歉，我不使用它。                                                    |

|                   | Linux x64 | Windows x32 | Windows x64 | 其他   |
| ----------------- | --------- | ----------- | ----------- | ------ |
| **Sublime Text**  | ✅        | ✅          | ✅          | ☠️     |
| **Sublime Merge** | ✅⚠️      |             | ✅          | ☠️     |

如果你使用的是 Windows 7，则需要[安装 Service Pack 2](https://answers.microsoft.com/en-us/windows/forum/all/how-to-obtain-and-install-windows-7-sp2/c2c7009f-3a10-4199-9c89-48e1e883051e)。

## 下载

https://github.com/n6333373/sublime-self-patcher/archive/refs/heads/main.zip

## 安装

首先，你需要找到 `Packages` 目录。

- 如果你使用的是便携版 Sublime Text，则为 `Data/Packages`。
- 如果你使用的是已安装版本的 Sublime Text，
  - 在 Windows 上，目录是 `%appdata%\Sublime Text\Packages`。
  - 在 Linux 上，目录是 `$HOME/.config/sublime_text/Packages`。

现在，（如有必要解压）将下载的目录放入 `Packages` 目录中，
使目录结构如下所示：

```text
Packages/
└── SelfPatcher/
    ├── boot.py
    ├── ...
```
然后重新启动正在运行的 Sublime Text。

## 使用方法

### 修补自身（当前 Sublime Text）

- 如果您使用的是未注册的开发版本，启动时此插件应显示修补弹窗。
- 如果您使用的是稳定版本，可以从菜单中修补：`帮助 ⇒ 修补此应用程序`

### 修补外部 Sublime Text/Merge

如果您的应用程序安装在需要管理员/根权限写入的位置，
您可以使用此插件在临时目录中创建一个修补后的可执行文件。

点击菜单：`帮助 ⇒ 修补外部 Sublime Text/Merge`，然后选择 Sublime Text/Merge 的可执行文件。

## 问答

### 如何禁用 Sublime Text/Merge 自动更新？

此插件通常会持续支持未来版本的 Sublime Text/Merge。
但如果您想禁用应用程序自动更新，可以设置以下选项：


```jsonc
{
    "update_check": false, // this works only if you have registered
}
```

### 该插件存在可疑之处

我认为我没有做任何恶意行为，但你不必信任我。你可以

- 在虚拟机中进行修补，然后取出修补后的可执行文件。
- 自己动手操作。请参见 https://gist.github.com/maboloshi/feaa63c35f4c2baab24c9aaf9b3f4e47


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---