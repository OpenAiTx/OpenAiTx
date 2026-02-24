<h1 align="center">Master Duel コミュニティ日本語翻訳パッチ</h1>
<div align="center">

![GitHub releases](https://img.shields.io/github/v/release/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub license](https://img.shields.io/github/license/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub last commit](https://img.shields.io/github/last-commit/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub Gist last commit](https://img.shields.io/github/gist/last-commit/de53fb59b1c63a8be98539e04aba5d42?style=flat-square&label=metadata%20version)
![GitHub download count](https://img.shields.io/github/downloads/mikualpha/master-duel-chinese-switch/total?style=flat-square)

[元プロジェクトURL](https://gitee.com/fetiss/master-duel-chinese-switch) | [元リリースページ](https://www.bilibili.com/read/cv21869124) | [APIソース](https://ygocdb.com/)
  
</div>

2023年5月初旬のバージョンから、MDはキャッシュファイルの呼び出し方法を変更し、既存の翻訳パッチが無効になったため、元のプロジェクトをベースに修正を行いました。

本プロジェクトは作者 [@叶lf](https://space.bilibili.com/23834819) / [@Timelic](https://space.bilibili.com/8664322) の作業を基にしており、ここに感謝の意を表します！また、データ解析部分での支援をいただいた [@拓王神](https://space.bilibili.com/483116312) にも感謝します。

## 使用方法
[Releasesページ](https://github.com/mikualpha/master-duel-chinese-switch/releases)から`MDTR_vx.x.x.exe`をダウンロードし、本プロジェクトの[Wiki](https://github.com/mikualpha/master-duel-chinese-switch/wiki)ページを参照してください。

## プロジェクトについて
本プロジェクトは`AGPL-3.0`ライセンスのもとでオープンソース化されており、配布や改変の際は必ず[オープンソースライセンス](https://www.chinasona.org/gnu/agpl-3.0-cn.html)を遵守してください。本プロジェクトのReleaseページが唯一の正式配布元であり、公式グループは存在しません。第三者プラットフォームでの実行ファイル配布や購入、寄付、投げ銭などの課金入口も提供しておらず、マルウェア感染や詐欺にご注意ください。

エラーやクラッシュが発生した場合は`issue`を提出してください。**興味のある方はPRも歓迎します〜**

**本プロジェクトが役に立ったと感じたら`Star`をつけていただけると嬉しいです、ありがとうございます〜**

## 開発関連
本プロジェクトは `UnityPy` を使ってアンパックし、`flet` でUIを制作しています。コンパイル環境は`Python 3.10`です。

<div align="center">
  <img src="https://raw.githubusercontent.com/mikualpha/master-duel-chinese-switch/master/./images/display.png" width="400">
</div>

#### 準備

```
pip install -r requirements.txt
```

#### 开发

无界面

```
python3 index.py
```

flet インターフェース

```
flet run interface.py
```

#### 打包

PowerShell:

```
./release.ps1
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-24

---