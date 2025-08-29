# MangaJaNai

[![Discord](https://img.shields.io/discord/1121653618173546546?label=Discord&logo=Discord&logoColor=white)](https://discord.gg/EeFfZUBvxj)

<a href="./mangajanaiv1demo.webp?raw=1"><img src="https://raw.githubusercontent.com/the-database/MangaJaNai/main/mangajanaiv1demo.webp"/></a>
<p align="center"><sup>（画像をクリックすると拡大します）</sup></p>

## 概要

MangaJaNaiは漫画用のアップスケーリングモデルのコレクションです。これらのモデルは主に高さが約1200pxから2048pxの日本語または英語のデジタル漫画画像のアップスケールに最適化されています。

最新情報の取得、プレリリースや実験的モデルのダウンロード、サポートや質問、アップスケール画像の共有、フィードバックの共有には[**JaNai Discordサーバー**](https://discord.gg/EeFfZUBvxj)に参加してください。日本語も対応しています。

## 使用方法

### MangaJaNaiConverterGuiによるアップスケーリング

手軽に利用したい場合は、[MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui)を使ってMangaJaNaiモデルで漫画をアップスケールしてください。

## MangaJaNaiモデル
漫画は非常に高解像度（10000px以上）で制作され、物理的な書籍では高品質に印刷されますが、公式のデジタル漫画はしばしば低解像度でJPEGやモアレのアーティファクトが多く含まれています。MangaJaNaiモデルの目的は、低品質な白黒デジタル漫画をアップスケールし、JPEGやモアレのアーティファクトを除去し、印刷された書籍版に近い結果を出すことです。

ほとんどの漫画はハーフトーンドットで制作されていますが、一部のデジタル版は劣化が激しくハーフトーンドットが見えなくなっています。MangaJaNaiモデルは元画像に無かったドットを生成しているように見えることがありますが、多くの場合、元の低品質ソース画像で見えなくなっていたドットを正しく復元しています。ハーフトーンが適切なサイズと頻度で生成されるように、7つの異なる画像高さに最適化された複数のMangaJaNaiモデルが訓練されました。これらの高さは日本でデジタルリリースされる漫画で最も一般的な画像サイズに対応しており、1200p、1300p、1400p、1500p、1600p、1920p、2048pです。[MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui)は入力画像の解像度に応じて最適なモデルを自動選択します。

## IllustrationJaNaiモデル
MangaJaNaiモデルは白黒漫画ページ専用のため、カバーやカラーページなど漫画のカラー画像用に補助的なIllustrationJaNaiモデルが訓練されました。これらのモデルはJPEGアーティファクトや低解像度の印刷ハーフトーンドットなどの一般的な画像アーティファクトを除去するよう訓練されており、デジタルアートの一般的なアップスケーリングモデルとしても優れています。[MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui)はカラー画像の場合自動でIllustrationJaNaiモデルを選択します。

## 関連プロジェクト

- [mpv-upscale-2x_animejanai](https://github.com/the-database/mpv-upscale-2x_animejanai): Real-ESRGANコンパクトモデルを使ったmpvでのリアルタイム4Kアニメアップスケーリング
- [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui): MangaJaNaiモデルによる漫画アップスケール用Windows GUI
- [traiNNer-redux](https://github.com/the-database/traiNNer-redux): アップスケーリングモデルのトレーニング用ソフトウェア

## 謝辞
- [422415](https://github.com/422415) にV1モデル開発中のデータセット準備と継続的なフィードバックで多大な支援をいただきました
- JaNai Discordサーバーの漫画リソース支援メンバー：
    - Alexandros
    - umzi
    - M7MedOo
    - Gnathonic
- ベータモデルに関する継続的なフィードバックを提供してくれたJaNai Discordサーバーのメンバー：
    - junmittens
    - SOUNDSPHERE BEST GAME
    - marv
    - Big_herooooo
    - avc1657
    - risho
- [traiNNer-redux](https://github.com/joeyballentine/traiNNer-redux)
- [Dataset Destroyer](https://github.com/Kim2091/helpful-scripts/tree/main/Dataset%20Destroyer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---