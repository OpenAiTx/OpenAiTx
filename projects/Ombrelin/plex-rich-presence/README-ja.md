> [!WARNING]  
>  **プロジェクトの状況**
> このプロジェクトはメンテナンスのみのモードです。私はもはやPLEXユーザーではないため、このプロジェクトの新機能には取り組みません。
> しかし、貢献のレビューや統合は引き続き行いますので、特定の機能を開発したい場合はPRを送ってください。

# Plex Rich Presence

Plex Rich Presenceは、現在のPLEXセッションをDiscordのリッチプレゼンスステータスに表示できるマルチプラットフォームの.NET 6 GUIアプリです。

<img src="https://github.com/Ombrelin/plex-rich-presence/blob/master/src/PlexRichPresence.UI.Avalonia/Assets/plex-rich-presence.png?raw=true" width="250" height="250">

バージョン2.1の新機能：

- リッチプレゼンスにメディアのサムネイルを動的に表示

バージョン2.0の新機能：

- 非管理者ユーザーをサポート
- サーバー選択をサポート
- CLI版
- PLEX SSOログイン

## リリースバージョン

WindowsおよびLinux用のリリースは[こちら](https://github.com/Ombrelin/plex-rich-presence/releases/latest)で入手可能です

## スクリーンショット

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/login.png)

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/server.png)

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/activity.png)

## ソースからのビルド＆実行

.NET 8+ SDKが必要です

```
cd src/PlexRichPresence.UI.Avalonia
dotnet run
```

## 使用ライブラリ

- AvaloniaUI
- .NET MVVM ツールキット
- Microsoft DI
- Moq
- PlexApi
- Discord RPC .NET
- FluentAssertions

## 特別な感謝

ロゴ提供：[@GrandKhan]

[Discord](https://discord.com/) と [PLEX メディアサーバー](https://plex.tv) に感謝します


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-01

---