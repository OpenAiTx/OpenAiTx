# ESP32 转译器

[![许可证](https://img.shields.io/github/license/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/blob/master/LICENSE)
[![版本发布](https://img.shields.io/github/v/release/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/releases)
[![Go 报告卡](https://goreportcard.com/badge/github.com/andygeiss/esp32)](https://goreportcard.com/report/github.com/andygeiss/esp32)
[![可维护性](https://api.codeclimate.com/v1/badges/90bf72e5a7b538c9e50e/maintainability)](https://codeclimate.com/github/andygeiss/esp32-transpiler/maintainability)

## 目的

[Arduino IDE](https://www.arduino.cc/en/Main/Software) 易于使用。  
但在更复杂的物联网项目中，我遇到了可维护性和可测试性的问题。  
我需要先编译并烧录 ESP32，然后才能通过 100% 手动的方式测试代码功能。

该解决方案将 Golang 转译为 Arduino 代码，使用 ESP32 工具链编译成镜像。  
现在我可以使用全自动测试方法，而不是完全手动操作。

**重要**：

转译器只支持 [Golang 语言规范](https://golang.org/ref/spec) 的一小部分子集。  
请查看[mapping](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/handlers/mapping.go)和[测试](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/service_test.go)以了解当前功能。  
无法触发 C/C++ 的垃圾回收，因为 Golang 在“底层”自动处理。  
Go 字符串将被转译为 C 常量字符数组，可以在栈上处理。

### 先决条件

1. 安装最新版本的 [Go](https://golang.org/dl/)。  
2. 安装最新版本的 [Just](https://github.com/casey/just)。  
3. 将 `$HOME/bin` 包含到你的 `$PATH` 中。

## 安装

克隆仓库并将 `esp32-transpiler` 二进制文件安装到 `$HOME/bin`：

    just install

## 用法

将 Golang 源文件转译为 Arduino 草图文件：

```bash
    esp32-transpiler -source my_source.go -target my_target.ino
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-18

---