# notify

[![go.dev reference](https://img.shields.io/badge/go.dev-reference-007d9c?logo=go&logoColor=white&style=flat-square)](https://pkg.go.dev/github.com/esiqveland/notify?tab=doc)
[![Go Report Card](https://goreportcard.com/badge/github.com/esiqveland/notify)](https://goreportcard.com/report/github.com/esiqveland/notify)
![Build](https://github.com/esiqveland/notify/actions/workflows/go.yml/badge.svg?branch=master)

Notify 是一个用于与 freedesktop.org 定义的 dbus 通知服务交互的 Go 库：
https://specifications.freedesktop.org/notification/latest/

`notify` 可以通过 dbus 发送桌面通知，类似于 libnotify 的实现方式。

请注意，`notify` 仍在开发中，API 在 1.0 版本发布之前尚未确定。

非常欢迎更多的测试者 =)

依赖于：
 - [godbus](https://github.com/godbus/dbus)。

## 更新日志
- v0.11.2: 引入辅助函数 ExpireTimeoutSetByNotificationServer, ExpireTimeoutNever
- v0.11.1: 修复 Close() 过程中的竞态条件 #11
- v0.11.0: 以 BSD 许可证重新发布
- v0.10.0: 更严格的类型：[一些破坏性变更](https://github.com/esiqveland/notify/releases/tag/v0.10.0)
- v0.9.0: [一些破坏性变更](https://github.com/esiqveland/notify/releases/tag/v0.9.0)
- v0.2.1: dbus: gomod: 锁定到 dbus v5
- v0.2.0: `Notifier.Close()` 不再调用底层 `dbus.Conn` 的 `.Close()`

## 快速介绍
请参阅示例：[main.go](https://github.com/esiqveland/notify/blob/master/example/main.go)。

克隆仓库并进入 examples 文件夹：

``` go run main.go ```


## 待办事项

- [x] 添加回调支持，即 dbus 信号。
- [ ] 测试。我非常感兴趣于任何编写（有用）测试的想法。

## 另请参见

Gnome 通知规范 https://developer.gnome.org/notification-spec/。


## 贡献者
感谢用户 [emersion](https://github.com/emersion) 对接收信号提出的绝佳想法。

感谢 [Merovius](https://github.com/Merovius) 修复 Close() 过程中的竞态条件。

## 许可证

BSD 3-Clause



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---