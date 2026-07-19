# notify

[![go.dev reference](https://img.shields.io/badge/go.dev-reference-007d9c?logo=go&logoColor=white&style=flat-square)](https://pkg.go.dev/github.com/esiqveland/notify?tab=doc)
[![Go Report Card](https://goreportcard.com/badge/github.com/esiqveland/notify)](https://goreportcard.com/report/github.com/esiqveland/notify)
![Build](https://github.com/esiqveland/notify/actions/workflows/go.yml/badge.svg?branch=master)

Notify は freedesktop.org によって定義された dbus 通知サービスと連携するための Go ライブラリです：
https://specifications.freedesktop.org/notification/latest/

`notify` は libnotify のように dbus 経由でデスクトップ通知を配信できます。

`notify` はまだ開発中であり、1.0 リリースまでは API が確定していないことにご注意ください。

より多くのテスターを歓迎します =)

依存関係：
 - [godbus](https://github.com/godbus/dbus)。

## 変更履歴
- v0.11.2: ヘルパー ExpireTimeoutSetByNotificationServer, ExpireTimeoutNever を導入
- v0.11.1: Close() 中の競合を修正 #11
- v0.11.0: BSD ライセンス下で再リリース
- v0.10.0: より厳密な型：[いくつかの破壊的変更](https://github.com/esiqveland/notify/releases/tag/v0.10.0)
- v0.9.0: [いくつかの破壊的変更](https://github.com/esiqveland/notify/releases/tag/v0.9.0)
- v0.2.1: dbus: gomod: dbus v5 に固定
- v0.2.0: `Notifier.Close()` はもはや基盤となる `dbus.Conn` の `.Close()` を呼び出さない

## クイックイントロ
例を参照：[main.go](https://github.com/esiqveland/notify/blob/master/example/main.go)。

リポジトリをクローンし、examples フォルダに移動：

``` go run main.go ```


## TODO

- [x] コールバックサポート（つまりdbusシグナル）を追加。
- [ ] テスト。役立つテストを書くためのアイデアを非常に求めています。

## 参照

Gnome通知仕様 https://developer.gnome.org/notification-spec/.


## 貢献者
シグナル受信に関する素晴らしいアイデアを提供してくれたユーザー [emersion](https://github.com/emersion) に感謝。

Close()中の競合状態を修正してくれた [Merovius](https://github.com/Merovius) に感謝。

## ライセンス

BSD 3-Clause



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---