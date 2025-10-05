# MiciMike Google Nest Mini用ドロップインPCB交換

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb)は、["Google Nest Mini"（バレルコネクタ充電ポートを備えたGoogleの第2世代スマートスピーカー）](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))のドロップインPCB交換品ですが、ESP32およびXMOSマイクロコントローラをベースにしたオープンソースファームウェアの実行を目的としています。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

ヒント！もし「Google Home Mini」（マイクロUSB充電ポートを備えたGoogleの第1世代スマートスピーカーハードウェア）用の類似のドロップインPCB交換品をお探しの場合は、姉妹プロジェクト https://github.com/iMike78/home-mini-v1-drop-in-pcb をご覧ください。

これらはどちらも完全なオープンソースハードウェアプロジェクトであり、[Onju Voice](https://github.com/justLV/onju-voice)からのコンセプトインスピレーションを受けつつ、[Open Home Foundationのオープンボイスアシスタント標準でHome Assistant Voice Preview Editionを参考にした](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)PCB設計と仕様に準拠することを目指しています。

# プロジェクトの範囲

このプロジェクトおよびリポジトリの目的（[Onju Voice](https://github.com/justLV/onju-voice)に似ていますが、完全オープンソースハードウェアライセンスの下で）は、Google Nest Mini（第2世代）のカスタムドロップイン交換用PCBとして、誰でも製作・製造依頼が可能なハードウェア回路図付きのドロップイン交換PCBを設計することです。

これは主に、古いGoogle Nest Miniスマートスピーカーを[Home Assistantの音声制御](https://www.home-assistant.io/voice_control/)および/または[Music Assistant](https://www.music-assistant.io)のメディアプレイヤースピーカー出力のためにオープンソースハードウェアに変換・再利用したい方を対象としています。（ただし、人気のEspressif ESP32プラットフォームをベースとしているため、他のファームウェアで他の用途に使うことも可能です。）

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

ハードウェア設計は（[Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)と同様に）WiFi、BLE、および[オンボードのウェイクワード検出](https://www.home-assistant.io/voice_control/about_wake_word/)用のESP32-S3 SoC（ノーコード[ESPHomeファームウェア](https://esphome.io/)使用）と、高度な音声処理用のXMOS xCORE XU316チップ（ノイズ抑制、アコースティックエコーキャンセレーション、干渉除去、自動ゲイン制御をローカル実行アルゴリズムで行うマイクロフォンクリーンアップオフロード用のカスタムファームウェア搭載）を統合します。

機能面では、ほぼ[Home Assistant Voice Preview Edition（Home Assistant Voice PE）](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)のリファレンス設計とハードウェア互換を目指しています（これはOpen Home FoundationとNabu Casaの協力によりオープンソースハードウェア設計として公開されています）。主な違いはGoogle Nest Miniの筐体や部品による制約（つまり、nest-mini-drop-in-pcbプロジェクトのハードウェア設計はGoogleの元のハードウェアと同様の物理的入力容量制限を受けること）によるものです。

したがって、このプロジェクト/リポジトリの範囲はESPHomeファームウェアの新機能/機能拡張の開発ではありませんので、それを望む場合はHome Assistant Voice Preview Editionのファームウェア開発および上流のESPHomeメインラインコードに取り組む必要があります：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 共同作業のお願い

PCBレイアウト設計の経験があり、特にPCB配線、グラウンドプレーン処理、ノイズに敏感なデジタル＋アナログレイアウトに詳しい方、**ぜひご協力ください**！新しいIssueの作成、提案・要望の送信、既存Issueへの意見・フィードバック追加、またはこのリポジトリのフォークも歓迎します。

コンセプトやアイデアについての詳細や関連議論に参加したい方は、以下のHome Assistantコミュニティフォーラムのスレッドをご参照ください：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 現在の状況

- ✅ 回路図完成
- ✅ 部品配置完了
- ✅ 配線完了
- ✅ グランドプレーン、シールド戦略、およびEMI対策完了
- ⚠️ 第1回テストバッチで2つのエラーが発生 - 修正済み
- 🕓 第2回テストバッチを待機中

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## 使用ツール

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC でフットプリントを調達

## 既知のハードウェア仕様

- 4層PCB
- ESP32-S3R8ベアチップ（WiFi、BLE、オンボードのウェイクワード検出用ESP32-S3）
- XMOS XU316-1024-QF60B-C32（XMOS XU316 xCORE DSPオーディオ処理）
- デュアルSPIフラッシュ
- デュアルI²Sバス（同時にI2Sインターフェースを使用可能、すなわち同時の音声出力と音声入力を実現）
- MAX98357スピーカー出力用（I2SクラスDモノラルオーディオアンプ）
- 2x MEMSマイクロフォン（MSM261DHP）
- SK6812 LED
- カスタムUSB-Cおよび14V電源入力

---

> ⚠️ USB-C経由でのフラッシュはメインの14V電源入力を切断する必要があります。詳細はPCBのシルクスクリーンの注意書きを参照してください。

## 参考資料

### Home Assistant Voice Preview Editionのリソース（PCB設計ファイル含む）
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE用ESPHomeファームウェア（同じESP32-S3 + XMOS XU316の組み合わせを使用）:

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU ICチップ

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Preview Editionハードウェア向けESPHomeプロジェクトのXMOSファームウェア：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## ライセンス

本プロジェクトは[CERNオープンハードウェアライセンス バージョン2 - 強い相互性 (CERN-OHL-S v2)]の下でライセンスされています。  
このハードウェアの改変版も同じライセンスの下で配布しなければなりません。

☕ このプロジェクトを支援したい場合は、[Ko-fiでコーヒーを買ってください](https://ko-fi.com/imike78)！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---