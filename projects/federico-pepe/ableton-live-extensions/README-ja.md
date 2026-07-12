# Ableton Live Extensions 実験

![Ableton Live Extensions](/images/Ableton-Extensions.png)

🖥️ [YouTubeでのイントロダクション動画を見る](https://www.youtube.com/watch?v=_izRiBGngGI)

*期待を壊せ。Liveを自分のものにしよう。*

Extensionsは、繰り返しの作業を自動化したり、新しいアイデアに輝きを与えたり混沌とさせたりできる強力なツールで、Liveの機能を拡張しワークフローを高速化する新しい方法です。

このリポジトリは、私が開発したいくつかのExtensionsを試したり、探求したり、編集したりできるコレクションです。ほとんどはSDKの機能を試すためのテストです。

Ableton Extensionsについてはこちらで詳しく読むことができます：

* [Ableton.com](https://www.ableton.com/en/live/extensions)
* [Extension SDK](https://ableton.github.io/extensions-sdk)
* [AbletonのDiscordに参加](https://discord.gg/ableton)してExtensionsについて話し合いましょう

## 必要条件

* Ableton Live Suite 12.4.5 ベータ版

## 免責事項

これらのExtensionsのほとんどは、コードの大部分を担当した*Claude Code*の助けを借りて作成しました。もしそれに不安があったり、その方法に賛同できない場合も、どうぞご心配なく。どちらにしても、時間を割いてチェックしてくれて本当にありがとうございます。

**Bird Game** Extensionの構築を助けてくれ、素晴らしい見た目に仕上げてくれた**Rain**と**Jackie**に大きな感謝を。Windows対応の**Doom**を作ってくれたGlau [@glaurossi](https://github.com/glaurossi)に感謝。**Freesound Sampler**はFreesoundのリード開発者Frederic Font Corbera [@ffont](https://github.com/ffont)のフィードバックを元に共同開発しています。

---

# Extensions

| 名前 | バージョン | 説明 | ダウンロード | ソース |
|---|---|---|---|---|
| Arrangement Helper | 0.0.8 | MIDIトラック上に名前付きで色分けされたセクションを作成し構造化されたアレンジを構築します。*⚠️ 現在の既知の制限事項はExtensionのREADMEファイルを必ず読んでください。* | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Arrangement-Helper-0.0.8.ablx) | [🏗️ ソース](extensions/arrangement-helper) |
| Basic Pitch ✨ | 1.0.3 | SpotifyのBasic Pitchニューラルネットワークを用いてオーディオクリップをMIDIに変換、完全オフライン対応（macOS & Windows） | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Basic-Pitch-1.0.3.ablx) | [🏗️ ソース](extensions/spotify-basic-pitch) |
| Bird Game | 1.1.0 | Flappy Birdに着想を得た遊び感覚のゲームで、プレイがMIDIクリップに変換されます（macOS & Windows） | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/bird-game-1.1.0.ablx) | [🏗️ ソース](extensions/bird-game) |
| Chord Progression Helper | 0.5.1 | 任意のキーからコード進行を作成し、それをMIDIクリップとして書き込みます | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Chord-Progression-Helper-0.5.1.ablx) | [🏗️ ソース](extensions/chord-progression-helper) |
| Chord Voicing Helper | 1.0.2 | MIDIクリップのコードを検出し、ボイシングの戦略を適用およびプレビューできます | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Chord-Voicing-Helper-1.0.2.ablx) | [🏗️ ソース](extensions/chord-voicings-helper) |
| ChromaFlux | 0.0.7 | 設定可能なモードと強度でInstrument Rackのパラメータをランダム化します | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/ChromaFlux-0.0.7.ablx) | [🏗️ ソース](extensions/chroma-flux) |
| Doom | 1.0.0 | Ableton Live（macOS & Windows）内でオリジナルのDOOMシェアウェア（1993）を完全にオフラインで実行 | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Doom-1.0.0.ablx) | [🏗️ ソース](extensions/doom) |
| Duplicate Track | 0.0.7 | クリップをコピーせずにトラックを複製 | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Duplicate-Track-0.0.7.ablx) | [🏗️ ソース](extensions/duplicate-track) |
| Freesound Sampler | 1.1.3 | Freesound.orgを検索し、サウンドを直接トラックにダウンロード | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Freesound-Sampler-1.1.3.ablx) | [🏗️ ソース](extensions/freesound-sampler) |
| Session to Arrangement Bridge | 0.0.8 | セッションビューのすべてのクリップをアレンジメントビューに完全な忠実度で転送。*⚠️ 拡張機能のREADMEファイルにある既知の制限を必ずお読みください。* | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Session-to-Arrangement-Bridge-0.0.8.ablx) | [🏗️ ソース](extensions/session-arrangement-bridge) |
| Snake | 0.0.7 | Live内でスネークをプレイし、ゲームプレイをMIDIクリップに変換 | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Snake-0.0.7.ablx) | [🏗️ ソース](extensions/snake) |
| Track Creator | 0.0.6 | シンプルなダイアログから一度に複数のオーディオまたはMIDIトラックを作成 | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Track-Creator-0.0.6.ablx) | [🏗️ ソース](extensions/track-creator) |
| Transpose Clips | 0.1.0 | Liveセット内のすべてのMIDIクリップを選択した半音数だけ移調 | [⬇️ ダウンロード](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Transpose-Clips-0.1.0.ablx) | [🏗️ ソース](extensions/transposer) |

✨ *最新の更新*

---

# 変更履歴

## 2026年6月28日

### Basic Pitch 1.0.3
- **不定進捗バー** — 転写中、進捗バーはフリーズする代わりに不定モードでアニメーションします。TF.jsのCPU推論は同期処理でNodeのシングルスレッドをブロックするため、推論終了まで固定パーセンテージは更新されませんでした。

## 2026年6月15日

### Freesound Sampler 1.1.3
- **インスパイアミー** — **Inspire Me**をクリックするとランダムな検索語が選ばれ、予期しないサウンドを即座に発見
- **OAuthログイン** - ワークフローを改善。APIキー入力欄を削除。

## 2026年6月12日

### Freesound Sampler 1.0.0
- **OAuthログイン** — 拡張機能から直接Freesoundアカウントでログイン可能に。APIキーの手動入力は不要
- **オリジナル品質ダウンロード** — ログイン時、サウンドはMP3プレビューではなくオリジナルフォーマット（WAV、FLAC、AIFFなど）でダウンロード
- **帰属ヘルパー** — 帰属表示で取り込んだサウンドを一覧表示し、クリエイター表記をワンクリックでコピー可能
- **高度な検索フィルター** — 音色の特徴（明るさ、暖かさ、粗さなど）、キー、BPM、長さ、ライセンスなどでフィルター可能

## 2026年6月9日

### Bird Game 1.1.0
- **Windows対応** — macOSとWindowsの両方で動作

### Doom 1.0.0
- **Windows対応** — macOSとWindowsの両方で動作（Glau [@glaurossi](https://github.com/glaurossi) に感謝）
- **完全オフライン** — すべてのゲーム資産をバンドル済み；インターネット接続不要

## 2026年6月7日

### Basic Pitch 1.0.0
- **Windows対応** — [@jwfeniello](https://github.com/jwfeniello) のおかげで完全クロスプラットフォーム対応（macOS & Windows）
- **バンドルモデル** — MLモデルは完全にローカルで動作；データはマシン外に出ない
- **安定性修正** — ホストクラッシュと圧縮オーディオサンプルの処理を修正

## 2026年6月1日

### 初の公開リリース
- **Bird Game 1.0.0** — あなたのランをMIDIクリップに変えるFlappy Bird風ゲーム
- **Doom** — Ableton Live内で動作するオリジナルDOOMシェアウェア（1993）、新SDKに移行
- **Arrangement Helper**, **Basic Pitch**, **Chord Progression Helper**, **Chord Voicing Helper**, **ChromaFlux**, **Duplicate Track**, **Freesound Sampler**, **Session to Arrangement Bridge**, **Snake**, **Track Creator**, **Transpose Clips** — 初の公開バージョン

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-12

---