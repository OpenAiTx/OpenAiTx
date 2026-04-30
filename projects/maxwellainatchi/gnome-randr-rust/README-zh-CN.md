# gnome-randr-rust

Gnome 在 Wayland 上的 `xrandr` 重新实现，特别针对不支持 `wlr-output-management-unstable-v1` 的系统（例如 Manjaro）。完全用 Rust 从头编写，追求性能和乐趣。这也是我的第一个 Rust 项目，欢迎任何建议！

> [!注意]  
> 我目前无法维护此项目，因为我不再有可用的 Linux 机器。如果有人有兴趣维护，请告诉我！
>
> 在 Gnome 48+ 上，试试随附的 [gdctl](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/doc/man/gdctl.rst) CLI，它很可能会保持更新。

（非 Gnome 合成器用户请参见 https://arewewaylandyet.com/ 上的显示配置链接）

## 安装

安装需要 `pkg-config` 和 `cargo`，它们是 Rust 工具链的一部分。[Cargo/Rust 安装说明](https://doc.rust-lang.org/cargo/getting-started/installation.html)。

安装此工具，请运行 `cargo install gnome-randr`。此外，还暴露了一个库供其他 Rust 程序使用。

## 方法

`gnome-randr-rust` 使用 `dbus` 对象 `org.gnome.Mutter.DisplayConfig`。详情见 https://wiki.gnome.org/Initiatives/Wayland/Gaps/DisplayConfig 的原始提案，尽管该规范有些过时（通过 Gnome shell 40.5 的 `dbus introspect` 检查）。Gnome 维护着不断演进的 XML 文件，见 [这里](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/data/dbus-interfaces/org.gnome.Mutter.DisplayConfig.xml)。

`GetCurrentState` 方法用于列出显示器信息，`ApplyMonitorsConfig` 用于修改当前配置。

## 灵感

该项目深受 `xrandr`（显而易见）以及 [`gnome-randr`](https://gitlab.com/Oschowa/gnome-randr/) 启发。不幸的是，`gnome-randr.py` 在我使用的 Gnome 版本（40.5）中尝试修改显示配置时似乎已失效。

`gnome-randr.py` 也比我用 Rust 重新实现的版本慢：在我的三显示器系统上，查询 Python 脚本大约需 30ms，而 Rust 实现约为 3ms（`xrandr` 大约 1.5ms，但由于 `xrandr` 桥接的限制，显示的信息有所不同）。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-30

---