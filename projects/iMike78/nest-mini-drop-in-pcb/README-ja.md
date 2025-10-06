
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

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb)は、["Google Nest Mini"（Googleの第2世代スマートスピーカー、バレル型コネクタ充電ポート付き）](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))のためのドロップインPCB交換基板です。ESP32およびXMOSマイクロコントローラをベースに、オープンソースファームウェアを実行できます。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

ヒント！「Google Home Mini」（Googleの第1世代スマートスピーカー、Micro-USB充電ポート付き）用の同様のドロップインPCB交換基板をお探しの場合は、姉妹プロジェクト https://github.com/iMike78/home-mini-v1-drop-in-pcb をご覧ください。

これらはどちらも完全なオープンソースハードウェアプロジェクトであり、[Onju Voice](https://github.com/justLV/onju-voice)のコンセプトの一部を参考にしつつ、PCB設計および仕様に関しては[Open Home Foundationのオープンボイスアシスタント標準とHome Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)を参照することを目指しています。

# プロジェクトの範囲

このプロジェクトおよびリポジトリの目標（[Onju Voice](https://github.com/justLV/onju-voice)に似ていますが、完全なオープンソースハードウェアライセンスの下で運営）は、誰でも作成・製造・注文できるハードウェア回路図付きのGoogle Nest Mini (第2世代)用カスタムドロップイン交換用PCB（プリント基板）を設計することです。

これは主に、古いGoogle Nest Miniスマートスピーカーを[Home Assistantの音声制御](https://www.home-assistant.io/voice_control/)や[Music Assistant](https://www.music-assistant.io)のメディアプレーヤースピーカー出力のためにオープンソースハードウェアに改造・再利用したい人を対象としています。（ただし、人気のあるEspressif ESP32プラットフォームをベースとしているため、他のアプリケーションやファームウェアでも利用可能です）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

ハードウェア設計は（[Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)と同様に）WiFi、BLE、および[オンボードウェイクワード検出](https://www.home-assistant.io/voice_control/about_wake_word/)（ノーコード[ESPHomeファームウェア](https://esphome.io/)を使用）用のESP32-S3 SoCと、高度な音声処理用XMOS xCORE XU316チップ（マイクのクリーニング処理をオフロードし、ノイズ抑制、音響エコーキャンセル、干渉除去、自動ゲイン制御のローカルアルゴリズムによる音声認識能力向上のためのカスタムファームウェア）を統合します。

機能面では、[Home Assistant Voice Preview Edition（Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)のリファレンス設計（Open Home FoundationがNabu Casaと協力して公開したオープンソースハードウェア設計）とほぼハードウェア互換となるように作られています。主な違いはGoogle Nest Miniの筐体と部品による制約が理由であり、（nest-mini-drop-in-pcbプロジェクトのハードウェア設計はGoogleのオリジナルハードウェアと同様の物理的な入力容量に制限されます）。

したがって、このプロジェクト／リポジトリの範囲はESPHomeファームウェアの新機能や機能開発ではありません。もしそれを望む場合は、Home Assistant Voice Preview Editionのファームウェア開発やESPHome本家コードに取り組む必要があります：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 協力のお願い

PCBレイアウト設計（特にPCB配線、グラウンドポア、ノイズに敏感なデジタル＋アナログレイアウト）の経験がある方、**ご協力いただけると大変ありがたいです**！新しいIssueの作成、提案・要望の投稿、既存Issueへのご意見・フィードバックの追加、またはリポジトリのフォークもご自由にどうぞ。

コンセプト／アイデアの詳細については、関連する議論やHome Assistantコミュニティフォーラムのスレッドもご参照・ご参加ください：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 現在の状況

- ✅ 回路図完成
- ✅ 部品配置完了
- ✅ 配線完了
- ✅ グラウンドポア、シールド戦略、EMI対策完了
- ⚠️ 第1回テストバッチで2つのエラーにより失敗 - 修正済み
- 🕓 第2回テストバッチ待ち

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## 使用ツール

- 🛠️ KiCad 9
- 🧰 フットプリントのソースとしてSnapEDA / LCSC

## 既知のハードウェア仕様

- 4層PCB
- ESP32-S3R8ベアチップ（WiFi、BLE、オンボードウェイクワード検出用ESP32-S3）
- XMOS XU316-1024-QF60B-C32（XMOS XU316 xCORE DSPオーディオ処理）
- デュアルSPIフラッシュ
- デュアルI²Sバス（同時にI2Sインターフェースを利用可能、つまり同時オーディオ出力と入力）
- MAX98357によるスピーカー出力（I2SクラスDモノオーディオアンプ）
- 2x MEMSマイク（MSM261DHP）
- SK6812 LED
- カスタムUSB-Cおよび14V電源入力

---

> ⚠️ USB-C経由でフラッシュする場合は、メインの14V電源入力を切断してください。詳細はPCBのシルクスクリーンノートを参照。

## 参考文献

### Home Assistant Voice Preview Editionのリソース（PCB設計ファイルを含む）
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/ja/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE用ESPHomeファームウェア（同じESP32-S3 + XMOS XU316構成を使用）:

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP（XU316-1024-QF60B-C32）MCU ICチップ

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Preview Editionハードウェア向けのESPHomeプロジェクトによるXMOSファームウェア:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## ライセンス

このプロジェクトは [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)] の下でライセンスされています。
このハードウェアの改変バージョンも同じライセンスで配布する必要があります。

☕ このプロジェクトを支援したい場合は、ぜひ [Ko-fiでコーヒーをおごってください](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---