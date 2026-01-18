# ESP32 Transpiler

[![License](https://img.shields.io/github/license/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/blob/master/LICENSE)
[![Releases](https://img.shields.io/github/v/release/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/releases)
[![Go Report Card](https://goreportcard.com/badge/github.com/andygeiss/esp32)](https://goreportcard.com/report/github.com/andygeiss/esp32)
[![Maintainability](https://api.codeclimate.com/v1/badges/90bf72e5a7b538c9e50e/maintainability)](https://codeclimate.com/github/andygeiss/esp32-transpiler/maintainability)

## Purpose

The [Arduino IDE](https://www.arduino.cc/en/Main/Software) is easy to use.
But I faced problems like maintainability and testability at more complicated IoT projects.
I needed to compile and flash the ESP32 before testing my code functionality by doing it 100% manually.

This solution transpiles Golang into Arduino code, which can be compiled to an image by using the ESP32 toolchain.
Now I am able to use a fully automated testing approach instead of doing it 100% manually.

**Important**:

The Transpiler only supports a small subset of the [Golang Language Specification](https://golang.org/ref/spec).
Look at the [mapping](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/handlers/mapping.go) and the [tests](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/service_test.go) to get the current functionality.
It is also not possible to trigger the C/C++ Garbage Collection, because Golang handles it automatically "under the hood".
Go strings will be transpiled to C constant char arrays, which could be handled on the stack.

### Prerequisites

1. Install the latest version of [Go](https://golang.org/dl/).
2. Install the latest version of [Just](https://github.com/casey/just).
3. Include `$HOME/bin` in your `$PATH`.

## Installation

Clone the repository and install the `esp32-transpiler` binary into `$HOME/bin`:

    just install

## Usage

Transpile a Golang source file into an Arduino sketch file:

```bash
    esp32-transpiler -source my_source.go -target my_target.ino
```
