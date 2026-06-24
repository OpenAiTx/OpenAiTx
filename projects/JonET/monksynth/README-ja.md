# MonkSynth

[![Build](https://github.com/JonET/monksynth/actions/workflows/build.yml/badge.svg)](https://github.com/JonET/monksynth/actions/workflows/build.yml)
[![Release](https://img.shields.io/github/v/release/JonET/monksynth?include_prereleases)](https://github.com/JonET/monksynth/releases)
[![License](https://img.shields.io/github/license/JonET/monksynth)](LICENSE)

モンクが詠唱するような音を出す単音ボーカルシンセサイザー。AudioNerdzによるクラシックなVSTプラグイン[Delay Lama](http://www.audionerdz.nl/)（2002年）に触発され、フォルマント波関数（FOF）合成を用いて構築。

**[最新リリースをダウンロード](https://github.com/JonET/monksynth/releases)** — Windows、macOS、Linux対応。

<img src="https://raw.githubusercontent.com/JonET/monksynth/main/docs/screenshot1.png" alt="MonkSynth running in Ableton Live 12 with the classic Delay Lama theme" width="600">

*Ableton Live 12上のMonkSynth v0.0.1-beta.1、元のDelay Lama DLLからインポートしたクラシックテーマ適用*

## 特徴

- リアルなボーカルフォルマントを生成するFOF合成エンジン
- ピッチと母音をリアルタイム制御するXYパッド
- 内蔵ステレオディレイエフェクト
- MIDI対応：ノートオン/オフ、ピッチホイール、CC1（ビブラート）、CC5（グライド）、CC7（ボリューム）、CC12（ディレイ）、CC13（ボイス）
- オートメーション可能な**ピッチベンド**パラメータ（±12セミトーン）。ハードウェアのピッチホイールは右クリック→ピッチベンドで母音（クラシック／Delay Lama互換、デフォルト）またはピッチへルーティング可能
- アタック、ディケイ、サスティン、リリース設定可能なADSRエンベロープ
- 最大10声のデチューンボイスとボイススプレッドを備えたユニゾンモード
- カスタムテーマ用の右クリックコンテキストメニューを持つテーマシステム
- 元のDelay Lama DLLからクラシックテーマをインポート可能
- 5つのファクトリープリセット
- VST3プラグインフォーマット（Windows、macOS、Linux）およびAudio Unit（macOS）

## ビルド

### 前提条件

- CMake 3.20以上
- C/C++コンパイラ（MSVC、GCC、またはClang）

### ビルド

```bash
cd cpp
cmake -B build
cmake --build build --config Release --target MonkSynth
```

VST3 SDKはCMakeによって自動的に取得されます。ビルドされたプラグインはシステムのVST3ディレクトリに配置されます。

### macOS Audio Unit

AUプラグインもビルドするには、[AudioUnit SDK](https://github.com/apple/AudioUnitSDK)をインストールし、以下のように設定してください。

```bash
cmake -B build -G Xcode -DSMTG_AUDIOUNIT_SDK_PATH=/path/to/AudioUnitSDK
cmake --build build --config Release --target MonkSynth-au
```

### DSP ユニットテスト

純粋な C 言語の DSP レイヤー（`dsp/`）には、ADSR エンベロープの境界、ノートスタック、ユニゾンデチューンの計算、ピッチベンドの伝播、ディレイラインのフィードバック安定性をテストする小さなユニットテストスイートがあります。テストはオプトイン方式で、通常のプラグインビルドには影響しません：

```bash
cd cpp
cmake -B build-tests -DMONKSYNTH_BUILD_TESTS=ON
cmake --build build-tests --config Release
ctest --test-dir build-tests --output-on-failure
```
CIは各リリースのパッケージング前にLinuxジョブ上でテストスイートを実行するため、DSPのリグレッションがあるとビルドがブロックされます。

## インストール

- **macOS:** `.pkg`インストーラーを実行 — VST3とAUプラグインの両方をインストール
- **Windows:** `.exe`インストーラーを実行 — VST3プラグインをインストール
- **Linux:** `MonkSynth.vst3`を抽出して`~/.vst3/`にコピー

### Linux互換性

Linuxビルドは各リリースで、以下のディストロファミリーの厳密なローダーセマンティクス（Bitwigスタイルの`dlopen(RTLD_NOW)`）で正常にロードされることを検証しています：

- Ubuntu 22.04 / 24.04 LTS（派生: Linux Mint, Pop!_OS, Elementary, KDE neon）
- Debian 12（派生: KX Studio, AV Linux, MX Linux）
- Fedora（最新）
- Arch Linux（派生: Manjaro, EndeavourOS, CachyOS）

リストにないディストリビューションでもおそらく動作します — これらはCIでスモークテストされ、共有ライブラリ欠如のようなバグを検出するためのもので、完全なサポート保証ではありません。プラグインはUbuntu 22.04（glibc 2.35）上でビルドされているため、glibc ≥ 2.35のディストロであれば互換性があります。他のディストロからの報告は[GitHub Issues](https://github.com/JonET/monksynth/issues)で歓迎します。

## テーマ

MonkSynthは組み込みのテーマを持たずに出荷されます。初回起動時にセットアップ画面が表示され、オリジナルのDelay Lama DLL（[audionerdz.nl](http://www.audionerdz.nl/download.htm)からフリーウェアとして入手可能）のクラシックルックをインポートできます。

また、プラグインGUIを右クリックしてカスタムテーマを読み込むことも可能です。テーマフォルダーには`theme.json`マニフェストと以下のPNGファイルの任意の組み合わせが含まれます（欠損ファイルは1x1のプレースホルダーにフォールバック）：

- `background.png` — メイン背景（360x510）
- `monk-strip.png` — アニメーションスプライトシート（5x6グリッド、311x311フレーム）
- `knob-left.png` / `knob-right.png` — ロータリーノブのフィルムストリップ（50x3000、60フレーム）
- `fader-down-large.png` / `fader-down-sm.png` / `fader-right-sm.png` — フェーダーハンドル
- `info.png` — インフォオーバーレイ（253x275）

**プラグインに同梱する新しいデフォルトテーマを募集しています。** 自信のあるテーマをデザインしたら、PRを開いてください — 次のリリースに寄稿テーマを含めたいです。右クリックメニューに「Open Themes Folder」があり、テーマの保存場所を開けます。

## 翻訳

プラグインUI（セットアップ画面、インフォオーバーレイ、右クリックメニュー、DLLインポーターのエラーメッセージ）は英語、日本語、韓国語で利用可能です。言語はOSのロケールから自動検出され、右クリック→Languageで上書き可能です。

**日本語と韓国語の翻訳は大規模言語モデルによる初期生成です。** ネイティブスピーカーによる寄稿を歓迎します — `cpp/src/strings_ja.h`または`cpp/src/strings_ko.h`の編集PRを開いてください。各文字列は`cpp/src/i18n.h`の`StringId`列挙体で索引付けされています；エントリは同じ順序で、わからないものは空文字列のままにして英語にフォールバックさせてください。


Parameter names (shown in your DAW's automation lanes) stay English on purpose — tutorials, presets, and community discussion all assume the English names.

## Code Signing Policy

Free code signing provided by [SignPath.io](https://about.signpath.io/), certificate by [SignPath Foundation](https://signpath.org/).

The Windows VST3 plugin and installer are signed as part of the release build in GitHub Actions. Signing requests are submitted to SignPath only for tagged releases built from this repository, and each request is manually approved in the SignPath UI before the certificate is applied.

| Privileged role | Signer |
|-----------------|--------|
| Author          | [Jonathan Taylor](https://github.com/JonET) |
| Reviewer        | [Jonathan Taylor](https://github.com/JonET) |
| Approver        | [Jonathan Taylor](https://github.com/JonET) |

### Privacy Policy

This program will not transfer any information to other networked systems unless specifically requested by the user or the person installing or operating it.

## Acknowledgments

- [Delay Lama](http://www.audionerdz.nl/) by AudioNerdz (2002) — このプロジェクトにインスピレーションを与えた愛されるフリーウェアVSTプラグイン
- Xavier Rodet (IRCAM) — フォルマント波形関数（FOF）合成技術
- [stb_image_write](https://github.com/nothings/stb) by Sean Barrett — シングルヘッダーの画像書き込みライブラリ（MIT / パブリックドメイン）
- [VST3 SDK](https://github.com/steinbergmedia/vst3sdk) by Steinberg — プラグインフレームワーク（MIT）
- [SignPath Foundation](https://signpath.org/) — オープンソースプロジェクト向けの無料Windowsコード署名サービス

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---