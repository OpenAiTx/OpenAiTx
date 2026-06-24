
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

**ご注意！** 現在、「MiciMike Home Mini Drop-In PCB」（第1世代Google Home Mini用）のクラウドファンディングキャンペーンがCrowd Supplyで事前販売（プロジェクトの事前プレビューのみ）として開催中です。これが成功した場合は、新しいNest Mini（第2世代）向けの同様のキャンペーンも計画されているので、ぜひこちらをチェックし、可能であれば本プロジェクトを支援してください：

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

これらはいずれも完全なオープンソースハードウェアプロジェクトであり、[Onju Voice](https://github.com/justLV/onju-voice)からコンセプトのインスピレーションを受けつつ、[Open Home Foundationのオープンボイスアシスタント標準およびHome Assistant Voice Preview Editionを参考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)に基づきPCB設計と仕様を目指しています。

# プロジェクトスコープ

このプロジェクトおよびリポジトリの目的（[Onju Voice](https://github.com/justLV/onju-voice)と似ているが完全なオープンソースハードウェアライセンスの下で運営）は、誰でも製作・発注できるGoogle Nest Mini（第2世代）用のカスタムドロップイン交換用PCB（プリント基板）とハードウェア回路図を設計することです。

これは主に、古いGoogle Nest Miniスマートスピーカーを[Home Assistantの音声コントロール](https://www.home-assistant.io/voice_control/)や[Music Assistant](https://www.music-assistant.io)のメディアプレイヤースピーカー出力用のオープンソースハードウェアに再利用・転用したい方を対象としています（ただし、このハードウェアは人気のEspressif ESP32プラットフォームをベースとしているため、他のファームウェアを利用すれば他の用途にも利用可能です）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="First test PCB">

ハードウェア設計は（[Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)と同様に）WiFi、BLE、[オンボードウェイクワード検出](https://www.home-assistant.io/voice_control/about_wake_word/)用ESP32-S3 SoC（ノーコード[ESPHomeファームウェア](https://esphome.io/)使用）＋高度なオーディオ処理用XMOS xCORE XU316チップ（ノイズ抑制、残響除去、干渉除去、自動ゲイン制御のためのカスタムファームウェアを搭載し、より良い音声認識能力のためにローカルで動作するアルゴリズムによるマイク処理オフロード）を統合します。

機能面では、[Home Assistant Voice Preview Edition（通称 Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)リファレンスデザイン（Open Home FoundationがNabu Casaと共同でオープンソースハードウェア設計として公開）とほぼハードウェア互換に作られています。主な違いはGoogle Nest Miniの筐体およびコンポーネントによる制約によるものであり（つまり、nest-mini-drop-in-pcbプロジェクトのハードウェア設計はGoogle製オリジナルと同じ物理的入力容量に制限されます）。

したがって、このプロジェクト/リポジトリの範囲はESPHomeファームウェア向けの新機能・新機能開発ではありません。そのため、それを希望する場合はHome Assistant Voice Preview Editionのファームウェア開発やESPHome本家の開発に参加してください：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## コラボレーションのお願い

PCBレイアウト設計（特に配線、グランドポア、ノイズに敏感なデジタル＋アナログレイアウト）の経験がある方は、**ぜひご協力ください**！新しいIssueの作成、提案・要望の投稿、既存Issueへのフィードバックやこのリポジトリのフォークなど、気軽にご参加ください。

このコンセプトやアイデアについての詳細や議論への参加は、以下のHome Assistantコミュニティフォーラムスレッドもご覧ください：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 現在の進捗

- ✅ 回路図完成
- ✅ 部品配置完了
- ✅ 配線完了
- ✅ グランドポア、シールド戦略、EMI対策完了
- ⛔ 最初のテストバッチで2つのエラーが発生 - 修正済み
- ⚠️ 第2テストバッチは一部動作
- ✅ 次のバッチでXTAG4デバッグオプション追加

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## 使用したツール

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSCによるフットプリント調達

## 既知のハードウェア仕様

- 4層PCB
- ESP32-S3R8ベアチップ（WiFi、BLE、オンボードウェイクワード検出用ESP32-S3）
- XMOS XU316-1024-QF60B-C24（XMOS XU316 xCORE DSPオーディオ処理）
- 16MB SPIフラッシュ（ESP32-S3用）
- 4MB SPIフラッシュ（XMOS XU316用）
- デュアルI²Sバス（同時オーディオ入力・出力対応）
- TAS5805M（TAS5805MPWPR）DSP内蔵ステレオClass-Dアンプ（I2Sオーディオ、I2C制御）、モノラルBTLスピーカー出力に設定
- 3x MEMSマイク（MMICT390200012）を34mm半径の弧に配置 - 現ファームウェアは2マイク使用、ハードウェアは3マイクアレイに対応済み
- 6x SK6812 RGB LED
- カスタムUSB-Cおよび14V電源入力（注意！USB-Cとバレルコネクタは同時接続不可）
- MPR121静電容量式タッチコントローラー（ESP32-S3のネイティブタッチセンシングではなくタッチ入力に使用）

---

> ⚠️ USB-C経由での書き込み時は、メインの14V電源入力を切断してください。詳細はPCBのシルクスクリーン注記参照。

## 参考資料

### Home Assistant Voice Preview Edition関連リソース（PCB設計ファイル含む）
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/ja/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE用ESPHomeファームウェア（同じESP32-S3 + XMOS XU316組み合わせを使用）:

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) MCU ICチップ

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Preview Editionハードウェア用のESPHomeプロジェクトによるXMOSファームウェア:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## ライセンス

本プロジェクトは [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)] の下でライセンスされています。
このハードウェアの改変版も同じライセンスで配布する必要があります。

☕ 本プロジェクトを支援したい場合は、[Ko-fiでコーヒーをご馳走ください](https://ko-fi.com/imike78)！




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---