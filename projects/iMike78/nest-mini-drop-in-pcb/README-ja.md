
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
これらはどちらも完全なオープンソースハードウェアプロジェクトであり、[Onju Voice](https://github.com/justLV/onju-voice)からいくつかのコンセプトのインスピレーションを得ていますが、PCB設計と仕様に関しては[Open Home Foundationのオープンボイスアシスタント標準およびHome Assistant Voice Preview Editionのリファレンス](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)に従うことを目指しています。

# プロジェクト範囲

このプロジェクトおよびリポジトリの目標（[Onju Voice](https://github.com/justLV/onju-voice)と類似していますが、完全なオープンソースハードウェアライセンスの下で運営）は、誰でも作成・製造・注文できるカスタムのGoogle Nest Mini（第2世代）用ドロップイン交換用PCB（プリント基板）とハードウェア回路図を設計することです。

これは主に、古いGoogle Nest Miniスマートスピーカーを[Home Assistantの音声操作](https://www.home-assistant.io/voice_control/)や[Music Assistant](https://www.music-assistant.io)のメディアプレイヤースピーカー出力用オープンソースハードウェアに改造・再利用したい人々を対象としています。（ただし、ハードウェアは人気のあるEspressif ESP32プラットフォームに基づいているため、他のファームウェアを使って他のアプリケーションでも使用できる可能性があります）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

ハードウェア設計は（[Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)と同様に）WiFi、BLE、[オンボードウェイクワード検出](https://www.home-assistant.io/voice_control/about_wake_word/)用のESP32-S3 SoC（ノーコード[ESPHomeファームウェア](https://esphome.io/)使用）＋高度なオーディオ処理用XMOS xCORE XU316チップ（ノイズ抑制、アコースティックエコーキャンセル、干渉キャンセル、オートゲインコントロールなどのローカルアルゴリズムによるマイククリーンアップオフロードのためのカスタムファームウェア）を統合します。

機能面では、[Home Assistant Voice Preview Edition（通称Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)リファレンス設計（Open Home FoundationがNabu Casaと共同で公開したオープンソースハードウェア設計）とほぼハードウェア互換になるように作られています。主な違いはGoogle Nest Miniの筐体と部品による制約に起因します（つまり、nest-mini-drop-in-pcbプロジェクトのハードウェア設計はGoogleの元ハードウェアと同じ物理的入力容量に限定されます）。

したがって、このプロジェクト/リポジトリの範囲はESPHomeファームウェアの新機能開発ではありません。もしそれを希望する場合は、Home Assistant Voice Preview Editionのファームウェア開発やESPHome本家の開発を参照してください。

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## コラボレーション募集

PCBレイアウト設計（特にPCB配線、グランドポア、ノイズに敏感なデジタル＋アナログレイアウト）の経験がある方は、**ぜひご協力ください**！新しいissueの作成、提案・要望の提出、既存issueへの意見・フィードバックの追加、またはリポジトリのフォークをお気軽にどうぞ。

コンセプト・アイデアについての詳細や議論への参加は、関連するHome Assistantコミュニティフォーラムスレッドもご覧ください：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 現在の状況

- ✅ 回路図完成
- ✅ 部品配置完了
- ✅ 配線完了
- ✅ グランドポア、シールド戦略、EMI対策完了
- ⚠️ 第1試作バッチで2箇所エラー発生 - 修正済み
- 🕓 第2試作バッチ待ち

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## 使用ツール

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC（フットプリント調達用）

## 既知のハードウェア仕様

- 4層PCB
- ESP32-S3R8 ベアチップ（WiFi、BLE、オンボードのウェイクワード検出用ESP32-S3）
- XMOS XU316-1024-QF60B-C24（XMOS XU316 xCORE DSPオーディオ処理用）
- デュアルSPIフラッシュ（ESP32とXMOSがそれぞれ専用のSPIフラッシュを持つ）
- デュアルI²Sバス（同時にI2Sインターフェース利用可、例：同時オーディオ出力と入力）
- MAX98357（スピーカー出力用、I2SクラスDモノラルオーディオアンプ）
- 2x MEMSマイク（デュアルMMICT390200012、マイク間隔68mm）
- 6x SK6812 RGB LED
- カスタムUSB-Cおよび14V電源入力（注意！USB-Cとバレルコネクタは同時接続不可）

---

> ⚠️ USB-C経由での書き込み時は、メインの14V電源入力を切断する必要があります。詳細は基板上のシルクスクリーン注意書きを参照してください。

## 参考文献

### Home Assistant Voice Preview Editionの各種リソース（PCB設計ファイル含む）
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE向けESPHomeファームウェア（同じESP32-S3 + XMOS XU316構成を使用）:

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP（XU316-1024-QF60B-C32）MCU ICチップ

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Preview Edition ハードウェア用の ESPHome プロジェクトの XMOS ファームウェア:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## ライセンス

このプロジェクトは [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)] でライセンスされています。
このハードウェアの改変版も同じライセンスで配布する必要があります。

☕ このプロジェクトをサポートしたい場合は、[Ko-fiでコーヒーを一杯ご馳走してください](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---