# PleaseDontStopTheMusic

iOSのオーディオセッションの中断を防ぎ、複数の音声ソースを同時に再生できるようにするTweakです。

## ❤️ プロジェクトをサポートする

このプロジェクトが役に立った場合、開発支援として寄付を歓迎します。

### Litecoin
**ネットワーク:** Litecoin (LTC)  
**アドレス:** `ltc1qaz2zqcc5usl4ueg7w5m8kqcmvrfqurpn6wqyfa`

**Litecoin**ネットワークで送金していることを必ずご確認ください。

ご支援ありがとうございます！

---

## 概要

**PleaseDontStopTheMusic** はiOSの `AVAudioSession` にフックをかけてオーディオミキシングを可能にするTweakです。これにより、通常はシステムが現在再生中の音声（音楽、ポッドキャスト等）を一時停止し新しい音源だけを再生する動作が、他のアプリが音声再生を要求しても現在の音声を中断せず継続できるようになります。

## 機能

- **連続再生** - 他のアプリが音を鳴らしたい場合でも音声が途切れません。  
- **オーディオミキシング** - `MixWithOthers` オプションを使い複数の音声が同時に混ざって再生されます。  
- **ユニバーサル対応** - rootful、rootless、jailed環境すべてで動作します。  
- **軽量** - 最小限のオーバーヘッドで純粋にフックのみの実装です。

## 動作原理

このTweakは `AVAudioSession` の設定呼び出しを横取りし、**他のアプリがすでに音声を再生中の場合**（`isOtherAudioPlaying`）、新たに起動したアプリのセッションに `AVAudioSessionCategoryOptionMixWithOthers` オプションを付加します。これによりiOSは新しい音声を既存の再生に割り込ませず混ぜて再生するよう指示されます。

重要なのは、プライマリの音楽ソースとなるアプリに対してはミキシングを強制しないことです。`MixWithOthers` を選択したアプリはiOSから*副次的*な音源と見なされ、ロック画面やコントロールセンターの「再生中」トランスポートコントロールを失います。最初のプライマリアプリはそのまま扱われ、フルのロックスキップや一時停止操作が保持される一方で、後から起動したTikTokやゲームなどは静かに割り込む形でミックスされます。

### フック対象メソッド

- `setCategory:error:`  
- `setCategory:mode:options:error:`  
- `setCategory:mode:routeSharingPolicy:options:error:` *(TikTokや現在の多くのアプリが使う最新API)*
- `setCategory:withOptions:error:`
- `setActive:error:`
- `setActive:withOptions:error:`

`SoloAmbient` セッション（ミックスできない）は、別のアプリが再生中の場合に透明に `Ambient` に切り替わるため、音楽を消音しなくなります。

---

## インストールガイド

お使いのデバイス構成に該当する方法を以下から選んでください。

### 方法 1: 非脱獄（サイドローディング）
デバイスが脱獄されていない場合はこの方法を使用します。リリースからの `.dylib` をターゲットアプリの IPA ファイルに注入する必要があります。

1. **準備:** `PleaseDontStopTheMusic.dylib` ファイルを用意してください。
2. **ツール選択:** **Esign**、**Feather**、**Sideloadly** のようなサイドローディングツールを使用します。
3. **注入:** 対象のアプリ（例：RobloxをプレイしながらSpotifyの音楽を聴きたい場合、Robloxに注入）IPAをツールにインポートし、注入する `.dylib` を選択してアプリに署名します。
4. **インストール:** 生成された修正済みIPAをデバイスにインストールします。

### 方法 2: 脱獄済み
デバイスが脱獄されている場合はこの方法を使用します。

1. **リポジトリ追加:** https://repo.chariz.com/ を開き、好みのパッケージマネージャーに追加するボタンを押します（通常はデフォルトリポですが、なければ追加してください）
2. **インストール:** リポジトリ内を検索するか、「PleaseDontStopTheMusic」を検索して入手します。
3. **完了:** フックを適用するためにデバイスを **リスプリング** します。

---

問題や質問があれば、気軽にDiscordでDMしてください！dc: fuseegelee

```bash
make all
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-22

---