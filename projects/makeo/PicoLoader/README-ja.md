# PicoLoader
これは、Nintendo GameCube用のODEベースのモッドチップで、ホームブリューを起動します。\
価格と機能は[PicoBoot](https://github.com/webhdx/PicoBoot)と非常に似ていますが、いくつかの利点があります。

サポートを受けたりモッドについて議論したりするには、[Discordサーバー](https://discord.gg/YtA9aU3BKZ)に参加してください！

## 仕組みは？
このモッドは、起動時にディスクドライブをエミュレートしてホームブリューアプリを実行し、その後ディスクドライブを再有効化します。\
これはFlippyDriveに似たフレックスPCBを使用して実現しています。
ただし、完全な光学ドライブエミュレーターではなく、PicoBootと同様にフラッシュから小さなホームブリューアプリ（例：[swiss](https://github.com/emukidid/swiss-gc)）を実行することのみ許可します。
SDカード上のファイルにアクセスするには、別途購入可能なSDGecko、SD2SP2、または同様のアダプターが必要です。

## 特徴
- オープンソース
- ディスクドライブを保持可能
- [オンラインコンバーター](https://makeo.github.io/PicoLoader/converter/)を使ってほとんどのホームブリューアプリを簡単に起動可能
- GameCubeに永久的な改造は不要
- ディスクドライブなしでインストール可能な[3Dプリントプラグ](https://github.com/makeo/PicoLoader/raw/refs/heads/main/mount/Drive_PlugV1.1.stl)
- 簡単に取り外せる
- クローンボードとの互換性向上のため200MHzでPicoを動作

#### はんだ付け版
- 安価で入手しやすい部品（Raspberry Pi Pico/Pico 2 + フレックスPCB + ダイオード）
- 入手容易
- GameCubeへの直接はんだ付け不要
- 簡単なはんだ付け作業
- 代替インストールオプション：[Panasonic Q](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#panasonic-q-install-option)、[ロープロファイル](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#low-profile-install-option)

#### はんだ付け不要版
- はんだ付け不要
- 交換可能なフレックスPCB
- PicoLoaderファームウェアと[Swiss](https://github.com/emukidid/swiss-gc)をプリプログラム済み
> [!TIP]
> はんだ付け不要版と通常版は[store.makstech.io](https://store.makstech.io/)で購入可能です。

## 今後の予定機能
*コオロギの鳴き声*

## インストール＆ドキュメント
> [!IMPORTANT]
> ウィキの[インストール手順](https://makeo.github.io/PicoLoader/)に従ってください。\
> 手順に従わない場合、取り付け中にフレックスPCBが破損する可能性があります。

📖[Wiki](https://github.com/makeo/PicoLoader/wiki/1.-Home)を見て始めましょう！

## ギャラリー

<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/9dbe6a59-c3cd-4a4b-9462-4ebc6618a6cf" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/87efdaf1-e2e6-4f9f-9bec-5a52d9c549fe" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/02900e41-325a-48d2-bb01-8081845d7696" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/9d39575d-f7d6-4cbe-b33c-1c6f40ef0f82" /></a>
</div>
<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/6027feaa-74c6-407d-be00-104c46bffad4" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/d55b692a-20f6-4cfc-925d-57860416c55e" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/2b155744-3261-40e2-8d08-9167f2aca5f7" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/85811813-3d21-497a-a214-eda23bb56491" /></a>
</div>

## スペシャルサンクス
- [silversteel](https://github.com/silverstee1) フレックスPCBとマウントの製作をはじめ、多大な協力をいただきました
- [TeamOffBroadway](https://github.com/OffBroadway) ドライブ信号をインターセプトするためのフレックスPCB使用の素晴らしいアイデアに感謝
- [Extrems](https://github.com/Extrems)、[emukidid](https://github.com/emukidid) およびSwiss開発に関わった皆様
- [novenary (9ary)](https://github.com/9ary) gekkobootのために

## 謝辞
[gbi.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi.hdr) および [gbi_disable_ipl.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi_disable_ipl.hdr) のソースはGPL-2.0のライセンスで提供されており、[こちら](https://github.com/makeo/cubeboot-tools)で入手可能です。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-17

---