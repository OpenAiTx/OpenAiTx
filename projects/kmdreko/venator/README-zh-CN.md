<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" height=170 srcset="docs/images/icon-dark.svg">
    <source media="(prefers-color-scheme: light)" height=170 srcset="docs/images/icon-light.svg">
    <img alt="venator logo" height=170 src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/icon-light.svg">
  </picture>
</p>

Venator 是一个用于记录、查看和过滤通过 Rust tracing crate 或使用 OpenTelemetry 进行检测的程序的日志和跨度的应用程序。  
它专为快速本地开发而设计。

<picture>
  <img alt="demo" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-demo.gif">
</picture>

## 安装

### 预编译二进制文件：

预编译的二进制文件可在 [发布页面](https://github.com/kmdreko/venator/releases) 获取，支持：  
- Windows (x64)  
- MacOS (Intel，苹果芯片)  

### 使用 Cargo：

使用 Cargo 从源代码编译和安装 `venator`（需要 Rust 1.76 或更高版本）：



```
cargo install venator-app
```

## 使用方法

### 使用 OpenTelemetry：

配置程序的 OpenTelemetry SDK，将日志和跟踪导出到
`127.0.0.1:8362`（Venator 的默认监听端口），并使用 `grpc` 或
`http/protobuf`。

### 使用 Rust Tracing：

在你的有埋点的程序中：

```toml
[dependencies]
venator = "1.1.0"
```

```rust
use venator::Venator;

Venator::default().install();
```

查看[文档](https://docs.rs/venator/latest/venator/)了解更多。

## 功能

事件可以按时间范围缩小查看，并通过属性、级别及其他属性进行过滤。记录表格可以包含自定义属性列。
图表显示每个条形中按级别的计数。

<picture>
  <img alt="事件屏幕截图" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-events.png">
</picture>

跨度同样可以按时间范围和过滤条件缩小查看。详情窗格可以显示所选事件和跨度的所有属性。
图表以层级方式显示跨度。

<picture>
  <img alt="跨度屏幕截图" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-spans.png">
</picture>

跟踪可以查看在单次执行中包含的事件和跨度。

<picture>
  <img alt="跟踪屏幕截图" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-traces.png">
</picture>




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---