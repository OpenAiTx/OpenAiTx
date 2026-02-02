<div align="center">
  <br/>
  <img src="https://raw.githubusercontent.com/therepanic/spotilyrics/master/logo.png" width="350" alt="Spotilyrics ロゴ"/>
  <p><i>コーディング中にVS Code内で同期されたSpotifyの歌詞を表示します。</i></p>
<p>
  <a href="https://marketplace.visualstudio.com/items?itemName=therepanic.spotilyrics"><img src="https://img.shields.io/badge/VS%20Code-Extension-blue?style=flat&logo=visualstudiocode" /></a>
  <a href="https://developer.spotify.com/documentation/web-api"><img src="https://img.shields.io/badge/Spotify-API-1DB954?style=flat&logo=spotify" /></a>
  <a href="https://lrclib.net"><img src="https://img.shields.io/badge/Lyrics-LRClib-orange?style=flat" /></a>
  <a href="https://news.ycombinator.com/item?id=45087905"><img src="https://img.shields.io/badge/Hacker%20News-Discuss-orange?style=flat&logo=ycombinator" /></a>
  <a href="https://unlicense.org/"><img src="https://img.shields.io/badge/License-Unlicensed-red?style=flat" /></a>
</p>
</div>

---

## ✨ 機能

- 📌 Spotifyの再生に合わせた**ライブ歌詞同期**。
- 🎨 アルバムカバーから自動でテーマカラーを設定（`colorthief`を使用）。
- 🖥️ 滑らかな**サイドパネル表示** – 左にコード、右に歌詞。
- 📱 **モバイルモード** – 再生前の行は黒、再生済みの行は白（Spotifyモバイルアプリ風）。
- 🔑 簡単な**一度きりのログイン**、自身のSpotifyクライアントIDを使用。
- 🚪 セッションをリセットするクイックログアウトコマンド。
- ⚡ 歌詞同期用の**最大トラックキャッシュサイズ**を設定可能。

---

## 📸 デモ

## <img src="https://raw.githubusercontent.com/therepanic/spotilyrics/master/demo.png"/>

## ⚡️ インストール

1. **VS Code**を開き → 拡張機能 → `spotilyrics`を検索、または[VS Codeマーケットプレイスからインストール](https://marketplace.visualstudio.com/items?itemName=therepanic.spotilyrics)。

2. コマンドを実行：

```
Show Spotify Lyrics via Spotilyrics
```

---

## 🔑 認証（ワンタイムセットアップ）

1. [Spotify Developer Dashboard](https://developer.spotify.com/dashboard) にアクセスします。
2. アプリを作成 → **Client ID** をコピーします。
3. **重要:** アプリの **Redirect URI** を `http://127.0.0.1:8000/callback` に設定してください。
4. `Show Spotify Lyrics via Spotilyrics` コマンドを実行します。
5. パネルに **Client ID** を貼り付けてログインします。
6. コーディング中に同期した歌詞をお楽しみください！🎶

> ℹ️ なぜ？ – Spotify APIのレート制限を尊重するため、自分のIDが必要です。

---

## ⌨️ コマンド

- `Show Spotify Lyrics via Spotilyrics` (`spotilyrics.lyrics`) – 同期歌詞パネルを開きます。
- `Toggle Mobile Mode` (`spotilyrics.toggleMobileMode`) – 通常モードとモバイルモードを切り替えます。
- `Logout from Spotilyrics` (`spotilyrics.logout`) – セッションをクリアし、必要に応じて再認証します。
- `Set Tracks Cache Max Size` (`spotilyrics.setTracksCacheMaxSize`) – 歌詞用にキャッシュする最大トラック数を設定します。

---

## ⚙️ 技術スタック

- [Spotify Web API](https://developer.spotify.com/documentation/web-api/)
- タイミング付き歌詞用 [LRClib](https://lrclib.net/)
- カバーに基づくテーマ用 [colorthief](https://lokeshdhakar.com/projects/color-thief/)
- TypeScript + VS Code WebView

---

## 📜 ライセンス

このプロジェクトは **Unlicensed** としてライセンスされています。  
自由に使用、改造、リミックスしてください – ただし保証はありません 😉

---
<div align="center">
<sub>therepanicによって❤️で作成されました。コードはハードに、バイブはもっとハードに🎧</sub>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-02

---