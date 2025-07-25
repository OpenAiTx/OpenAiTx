<div align="right">
  <details>
    <summary >🌐 他の言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

クラシックな2048ゲームを強化したバージョンで、さらに楽しい機能が追加されています！これは私が余暇に作った小さなプロジェクトです。楽しんでいただければ幸いです！

## 🎯 ゲーム紹介

2048はシンプルで中毒性のある数字合成ゲームです。4x4のグリッド上で、上下左右にスワイプして同じ数字のタイルを合体させます。目標？2048に到達すること（もちろん、それ以上のスコアも目指せます）！

**遊び方：**
- 矢印キーまたはWASDキーでタイルを動かします。
- 同じ数字のタイルがぶつかると合体します。
- 各操作後、空いているマスにランダムで2か4が出現します。
- もう動かせなくなったらゲームオーバーです。

## ✨ 特別な機能

### 1. アンドゥ機能
- 間違って動かしてしまった？大丈夫！
- 「アンドゥ」ボタンを押すと1手前に戻せます。
- 最初から何度でもアンドゥ可能です。
- 指のミスでゲームが台無しになる心配はもうありません！

### 2. シークレットチートモード
- マジックシーケンスを入力：←←→→ →→←←（左、左、右、右、右、右、左、左）
- すべてのタイルが魔法のように128に変わります！
- これはちょっとしたイースターエッグです。
- 裏技は楽しいですが、やりすぎに注意！😉

## 🎯 デモ

🎯 ここでプレイ：[2048.765431.xyz](https://2048.765431.xyz/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 プロジェクト構成
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**ファイル説明:**
- `2048.py`: Flaskで書かれたバックエンドサーバーで、ゲームロジックとAPIリクエストを処理します。
- `script.js`: フロントエンドのゲームロジックで、移動、アニメーション、特別な機能を含みます。
- `styles.css`: ゲームのスタイルを担当し、全体が美しくレスポンシブに見えるようにします。
- `index.html`: すべてをまとめるメインページです。

## 🚀 はじめに

**方法1: リリースをダウンロード**
1. 最新のリリースをダウンロードします。
2. Python 3.xがインストールされていることを確認してください。
3. 依存関係をインストールします: `pip install flask`
4. 実行します: `python 2048.py`
5. ブラウザで次のURLにアクセスします: [http://localhost:9969](http://localhost:9969)

**方法2: GitHubからクローン**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 カスタマイズ

自分用にカスタマイズしたいですか？`styles.css`を調整して新しい外観にしたり、`script.js`をいじってゲームプレイを変更できます。すべてのコードには分かりやすいコメントが付いているので、簡単にハックできます！

## 📝 ライセンス

GPL-2.0 ライセンス

## 🤝 コントリビューション

まだまだ更新中！Issue や Pull Request は大歓迎です—一緒にこのゲームをもっと素晴らしいものにしましょう！


## 🙏 謝辞

このプロジェクトを支援してくださったスポンサーの皆様に感謝します：
- サーバーを提供してくれた [IDC.REST](https://idc.rest/)
- サーバーを提供してくれた [Serv00](https://www.serv00.com/)

---
_最終更新: 2025年6月_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---