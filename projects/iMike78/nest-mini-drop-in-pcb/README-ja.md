
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Google Nest Mini用MiciMikeドロップインPCB交換

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb)は、[「Google Nest Mini」（バレルコネクタ充電ポートを備えたGoogleの第2世代スマートスピーカー）](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))用のドロップインPCB交換品ですが、オープンソースファームウェアを実行するためにESP32およびXMOSマイクロコントローラをベースにしています。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

ヒント！もし「Google Home Mini」（Micro-USB充電ポートを備えたGoogleの第1世代スマートスピーカーハードウェア）用の類似ドロップインPCB交換品をお探しの場合は、姉妹プロジェクト https://github.com/iMike78/home-mini-v1-drop-in-pcb をご覧ください。
**ご注意！** 「MiciMike Home Mini Drop-In PCB」（第1世代Google Home Mini向け）のクラウドファンディングキャンペーンがCrowd Supplyのプレローンチ段階（プロジェクトプレビューのみ）で掲載されています。これが成功した場合、Nest Mini向けにも同様のキャンペーンを計画する予定ですので、ぜひこちらをご覧ください：

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

これらはどちらも完全なオープンソースハードウェアプロジェクトであり、[Onju Voice](https://github.com/justLV/onju-voice)から着想を得つつ、[Open Home Foundationのオープン音声アシスタント標準とHome Assistant Voice Preview Editionを参考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)に、PCB設計および仕様に従うことを目指しています。

# プロジェクト範囲

本プロジェクトおよびリポジトリの目的（[Onju Voice](https://github.com/justLV/onju-voice)に類似しつつ、完全なオープンソースハードウェアライセンスの下で運営）は、誰でも作成・製造できる、またはワンストップPCBメーカーに注文できる、Google Nest Mini（第2世代）向けのカスタムドロップイン交換用PCB（プリント基板）をハードウェア回路図とともに設計することです。

これは主に、古いGoogle Nest Miniスマートスピーカーを[Home Assistantの音声コントロール](https://www.home-assistant.io/voice_control/)用オープンソースハードウェアや、[Music Assistant](https://www.music-assistant.io)のメディアプレーヤー用スピーカー出力として再利用・転用したい方向けです。（ただし、人気の高いEspressif ESP32プラットフォームを基盤としているため、他のアプリケーションやファームウェアでも利用可能な場合があります。）

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

ハードウェア設計は（[Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)同様）、WiFi、BLE、[オンボードウェイクワード検出](https://www.home-assistant.io/voice_control/about_wake_word/)（ノーコード[ESPHomeファームウェア](https://esphome.io/)使用）のためのESP32-S3 SoCと、高度な音声処理用XMOS xCORE XU316チップ（ノイズ抑制、アコースティックエコーキャンセル、干渉除去、自動ゲイン制御などの音声認識向けマイクロフォンクリーンアップをローカルで行うカスタムファームウェア搭載）を統合します。

機能面では、[Home Assistant Voice Preview Edition（Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)参照設計（Open Home FoundationがNabu Casaと共同でリリースしたオープンソースハードウェア設計）と主にハードウェア互換となるよう設計されています。主な違いはGoogle Nest Mini筐体やコンポーネントによる制約（すなわち、nest-mini-drop-in-pcbプロジェクトのハードウェア設計はGoogle純正ハードウェアと同等の物理的な容量入力に制限される）です。

したがって、本プロジェクト/リポジトリの範囲はESPHomeファームウェアの新機能や新機能開発ではありません。これを望む場合は、Home Assistant Voice Preview Editionのファームウェア開発や、上流のESPHomeメインラインコードに取り組む必要があります。

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## コラボレーションのお願い

PCBレイアウト設計（特にPCB配線、グラウンドポア、ノイズに敏感なデジタル＋アナログ設計）の経験がある方、**あなたのご協力を心よりお待ちしております**！新しいissueの作成、提案・要望の投稿、既存issueへの意見・フィードバック追加、またはリポジトリのフォークを歓迎します。

本コンセプトやアイデアの詳細については、以下のHome Assistantコミュニティフォーラムのスレッドもご覧になり、議論にご参加ください：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 現在の状況

- ✅ 回路図完成
- ✅ 部品配置完了
- ✅ 配線完了
- ✅ グラウンドポア・シールド戦略・EMI考慮完了
- ⚠️ 初回テストバッチは2つのエラーで失敗 - 修正済

- 🕓 第2回テストバッチを待機中

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## 使用ツール

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC フットプリント取得用

## 既知のハードウェア仕様

- 4層PCB
- ESP32-S3R8 ベアチップ（WiFi、BLE、オンボードウェイクワード検出用ESP32-S3）
- XMOS XU316-1024-QF60B-C24（XMOS XU316 xCORE DSPオーディオ処理）
- デュアルSPIフラッシュ（ESP32とXMOSが個別にSPIフラッシュを持つため）
- デュアルI²Sバス（I2Sインターフェースを同時に使用可能、例：同時オーディオ出力および入力）
- TAS5805M（TAS5805MPWPR）スピーカー出力用（I2SクラスDモノオーディオアンプ、I2C経由DSP設定）
- 2x MEMSマイクロフォン（デュアルMMICT390200012、マイク間隔68mm）
- 6x SK6812 RGB LED
- カスタムUSB-Cおよび14V電源入力（注意！USB-Cとバレルコネクタは同時に接続不可）

---

> ⚠️ USB-C経由でのフラッシュにはメイン14V電源入力の切断が必要です。詳細はPCBのシルクスクリーン注記を参照してください。

## 参考資料

### Home Assistant Voice Preview Editionリソース（PCB設計ファイル含む）
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE用ESPHomeファームウェア（同じESP32-S3 + XMOS XU316組み合わせを利用）:

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP（XU316-1024-QF60B-C32）MCU ICチップ

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai

#### Home Assistant Voice Preview Edition ハードウェア用 ESPHome プロジェクトからの XMOS ファームウェア：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## ライセンス

このプロジェクトは [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)] の下でライセンスされています。
このハードウェアの改変版も同じライセンスで配布する必要があります。

☕ このプロジェクトを応援したい場合は、[Ko-fi でコーヒーをご馳走してください](https://ko-fi.com/imike78)！




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---