# Whispera

macOSネイティブアプリで、組み込みの音声入力をOpenAIのWhisperに置き換え、優れた文字起こし精度を実現します。音声、ローカルファイル、YouTube動画、ネットワークストリームを転写—すべてNeural Engine上でローカル処理されます。
<div align="center">
  
  ### [⬇️ 最新リリースをダウンロード](https://github.com/sapoepsilon/Whispera/releases/latest)
  
  [![GitHub release (latest by date)](https://img.shields.io/github/v/release/sapoepsilon/Whispera?style=for-the-badge&logo=github&color=0969da&labelColor=1f2328)](https://github.com/sapoepsilon/Whispera/releases/latest)
  
</div>

## デモ

<table>
  <tr>
    <th>音声からテキストフィールドへ</th>
    <th>ファイル/URLの文字起こし（タイムスタンプ付き）</th>
  </tr>
  <tr>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/1da72bbb-a1cf-46ee-a997-893f1939e626" controls>
        お使いのブラウザはvideoタグに対応していません。
      </video>
    </td>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/d573bef4-a3b2-49ac-a1fd-3c6735648fdc" controls>
        お使いのブラウザはvideoタグに対応していません。
      </video>
    </td>
  </tr>
</table>

## 機能

- **ライブ文字起こし**（ベータ）
- **音声からテキスト** - macOSのネイティブ音声入力をWhisperKit（Neural Engine上のOpenAI Whisperモデル）に置き換え、高精度を実現
- **ファイル文字起こし** - 音声・動画ファイル対応
- **ネットワークメディア文字起こし** - 動画や音楽のURLをストリーム再生し文字起こし
- **YouTube文字起こし**

すべての処理はローカルで実行されます。インターネットは初回のモデルダウンロード時のみ必要です。
## ロードマップ

- [x] 英語以外の多言語対応
  - **PR**: https://github.com/sapoepsilon/Whispera/pull/2
  - **リリース**: https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.3
- [x] リアルタイム翻訳機能
  - **PR**: https://github.com/sapoepsilon/Whispera/pull/17
  - **リリース**: https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.18
- [ ] 追加のカスタマイズオプション

## 使い方

設定済みのグローバルショートカットを使うだけで、macOS標準の音声入力の代わりにWhisperでの文字起こしを開始できます。

## 既知の問題

- Intel Macでは動作しません（[Issue 15](https://github.com/sapoepsilon/whispera/issues/15)参照）
- 自動インストールが機能しません。アプリをダウンロード後、手動で`/Applications`フォルダへドラッグ＆ドロップしてください
## 動作環境

- macOS 13.0以降
- Apple Silicon
- Intel Mac対応を検討中です

## クレジット

以下を使用して構築されています：
- [WhisperKit](https://github.com/argmaxinc/WhisperKit) - Apple Silicon向けオンデバイスWhisper文字起こし
- [YouTubeKit](https://github.com/alexeichhorn/YouTubeKit) - YouTubeコンテンツ抽出
- [swift-markdown-ui](https://github.com/gonzalezreal/swift-markdown-ui)


プライバシー重視のローカル文字起こしを実現したこれらのプロジェクトに感謝します。

## ライセンス

MITライセンス


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-31

---