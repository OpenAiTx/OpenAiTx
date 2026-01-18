# ESP32 トランスパイラー

[![License](https://img.shields.io/github/license/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/blob/master/LICENSE)
[![Releases](https://img.shields.io/github/v/release/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/releases)
[![Go Report Card](https://goreportcard.com/badge/github.com/andygeiss/esp32)](https://goreportcard.com/report/github.com/andygeiss/esp32)
[![Maintainability](https://api.codeclimate.com/v1/badges/90bf72e5a7b538c9e50e/maintainability)](https://codeclimate.com/github/andygeiss/esp32-transpiler/maintainability)

## 目的

[Arduino IDE](https://www.arduino.cc/en/Main/Software)は使いやすいです。
しかし、より複雑なIoTプロジェクトでは保守性やテスト性の問題に直面しました。
コードの機能をテストする前に、ESP32をコンパイルしてフラッシュする作業を100％手動で行う必要がありました。

このソリューションはGolangをArduinoコードにトランスパイルし、ESP32ツールチェーンを使ってイメージにコンパイルできます。
これにより、100％手動で行う代わりに完全自動化されたテスト手法を利用できるようになりました。

**重要**:

トランスパイラーは[Golang言語仕様](https://golang.org/ref/spec)のごく一部のみをサポートしています。
現在の機能については[mapping](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/handlers/mapping.go)と[テスト](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/service_test.go)を参照してください。
Golangが自動的に「裏で」処理するため、C/C++のガベージコレクションを呼び出すこともできません。
Goの文字列はCの定数char配列にトランスパイルされ、スタック上で処理されます。

### 前提条件

1. 最新版の[Go](https://golang.org/dl/)をインストールしてください。
2. 最新版の[Just](https://github.com/casey/just)をインストールしてください。
3. `$HOME/bin`を`$PATH`に含めてください。

## インストール

リポジトリをクローンし、`esp32-transpiler`バイナリを`$HOME/bin`にインストールします:

    just install

## 使い方

GolangのソースファイルをArduinoスケッチファイルにトランスパイルします:

```bash
    esp32-transpiler -source my_source.go -target my_target.ino
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-18

---