# bevy_dev_console

`bevy_dev_console` 是一个受 Source 启发的开发者控制台插件，适用于 [Bevy 游戏引擎](https://github.com/bevyengine/bevy)。

![开发者控制台图片](https://raw.githubusercontent.com/doonv/bevy_dev_console/master/doc/console.png)

> [!WARNING]  
>
> `bevy_dev_console` 目前处于早期开发阶段。近期内可能会有破坏性更改（尤其是在使用内置命令解析器时）。因此，目前它仅作为 git 包提供。

## 功能

- 日志查看
  - 悬停查看任何日志消息中的隐藏数据。
- 专为 `bevy_dev_console` 构建的强大内置解析语言。([文档](https://github.com/doonv/bevy_dev_console/wiki/Built%E2%80%90in-Parser))
  - 计算
  - 变量
    - 使用简化版本的所有权和借用
  - 标准库（目前内容不多）
  - [自定义本地函数](https://github.com/doonv/bevy_dev_console/blob/master/examples/custom_functions.rs)（包括 `World` 访问！）
  - [多种类型](https://github.com/doonv/bevy_dev_console/wiki/Built%E2%80%90in-Parser#types)
  - 资源查看与修改
    - 枚举
    - 结构体
  - ~~实体查询~~ [*即将推出...*](https://github.com/doonv/bevy_dev_console/issues/3)（欢迎语法建议！）
  - ……更多！

## 使用方法

1. 添加 `bevy_dev_console` git 包。

    ```bash
    cargo add --git https://github.com/doonv/bevy_dev_console.git
    ```

2. 导入 `prelude`。

    ```rust
    use bevy_dev_console::prelude::*;
    ```
3. 添加插件。


    ```rust,no_run
    use bevy::{prelude::*, log::LogPlugin};
    use bevy_dev_console::prelude::*;

    App::new()
        .add_plugins((
            // Add the log plugin with the custom log layer
            DefaultPlugins.set(LogPlugin {
                custom_layer: custom_log_layer,
                ..default()
            }),
            // Add the dev console plugin itself.
            DevConsolePlugin,
        ))
        .run();
    ```

4. 就这些了！现在你可以按下键盘上的 `` ` `` / `~` 键，它应该会打开控制台！

## 可切换功能

**（默认）** `builtin-parser` 包含默认解析器。禁用它可以让你移除内置解析器并用你自己的替代（或者你也可以什么都不做，将控制台变成日志阅读器）。

## Bevy 兼容性

| bevy   | bevy_dev_console |
| ------ | ---------------- |
| 0.14.* | git (master)     |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-18

---