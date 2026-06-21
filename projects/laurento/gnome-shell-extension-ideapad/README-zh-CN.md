# gnome-shell-extension-ideapad
联想 IdeaPad 的 GNOME Shell 扩展

*目前该扩展仅提供一种简便且用户友好的方式来切换联想 IdeaPad 笔记本上可用的电池保护模式，并直观显示其当前状态。*

# 安装
只需从[官方 GNOME 扩展网站](https://extensions.gnome.org/extension/2992/ideapad/)安装该扩展（推荐）。或者，可以手动下载或克隆代码库到 `~/.local/share/gnome-shell/extensions/ideapad@laurento.frittella`

无论哪种方式，都需要进行一些额外步骤。请查看下面专门的章节。

如果您想查看代码，请注意 `master` 分支针对的是最新稳定版的 GNOME Shell。以往版本仍在专门分支支持（例如 `pre-43`）。

# 使用
该扩展在面板中添加了一个新条目 *切换保护模式*，并在状态菜单显示一个图标，以指示电池保护模式是否已启用。

如果您的笔记本型号支持，保护模式会限制电池充电至容量的 55-60%，以延长电池寿命。当笔记本大部分时间接入外部电源时，这一功能尤为有用。

| GNOME Shell < 43    | GNOME Shell >= 43      |
|---------------------|------------------------|
| ![](https://raw.githubusercontent.com/laurento/gnome-shell-extension-ideapad/master/screenshot.png) | ![](https://raw.githubusercontent.com/laurento/gnome-shell-extension-ideapad/master/screenshot-43.png) |

# 额外所需设置
您的桌面用户需要对一个通常由 root 用户拥有的特定 sysfs 文件具有读写权限。最简单的方式是使用 `sudo`。以下步骤已在 Debian 上测试，但应适用于任何现代 GNU/Linux 系统。如有疑问，请参考您的发行版文档。

* 根据您的发行版，这里需要使用组 `sudo`（如 Debian 和 Ubuntu）或 `wheel`（如 Arch 和 Fedora）。如有疑问，可在终端运行 `groups` 命令，查看输出中列出的组。

  将以下条目添加到系统 sudoers 配置中（例如 `/etc/sudoers.d/ideapad`）。**如果需要，请确保将** `%sudo` 替换为 `%wheel`。
  ~~~
  %sudo ALL=(ALL) NOPASSWD: /usr/bin/tee /sys/bus/platform/drivers/ideapad_acpi/VPC????\:??/conservation_mode
  ~~~

* 为确保 `ideapad_laptop` 内核模块在启动时自动加载，只需将其添加到文件 `/etc/modules`

总结和便于参考...
~~~
# 如果需要，别忘了将 %sudo 替换为 %wheel！
#
$ echo "%sudo ALL=(ALL) NOPASSWD: /usr/bin/tee /sys/bus/platform/drivers/ideapad_acpi/VPC????\:??/conservation_mode" | sudo tee /etc/sudoers.d/ideapad
$ echo "ideapad_laptop" | sudo tee -a /etc/modules
~~~

# 错误的电池估算显示
根据您使用的内核版本，可能仍存在一个小的美观问题。 但是，如果 GNOME 中持续显示的“估算中...”电池状态让您感到困扰，也有解决方案。

实际上，这个问题应该在 5.19 及以上内核中得到修复。 如果您使用的是较旧的内核，可以尝试应用[此处的补丁](https://git.kernel.org/pub/scm/linux/kernel/git/torvalds/linux.git/commit/?id=185d20694a8aceb4eda9fc1314cbaad0df0aab07)。感谢 Martino Fontana 指出此问题。

或者，您也可以使用我最初在[此 uPower 合并请求](https://gitlab.freedesktop.org/upower/upower/-/merge_requests/46)中建议的补丁。 但我个人建议采用内核补丁。 这是一个更干净的解决方案。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-21

---