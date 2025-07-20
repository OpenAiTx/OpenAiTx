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


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

クラシックな2048ゲームを強化したバージョンで、さらに楽しい機能が追加されています！ちょっとした空き時間に作ったプロジェクトですが、あなたに楽しみをもたらせれば嬉しいです！

## 🎯 ゲーム紹介

2048はシンプルで中毒性のある数字合成ゲームです。4x4のグリッド上で、同じ数字のタイルを上下左右にスワイプして合成します。目標は？2048に到達すること！（でも、さらに高得点を目指して続けることもできます！）

**遊び方:**
- 矢印キーまたはWASDでタイルを動かします。
- 同じ数字のタイルがぶつかると、1つに合成されます。
- 移動ごとに、空いているマスにランダムで2または4が出現します。
- 動かせる場所がなくなるとゲームオーバーです。

## ✨ 特殊機能

### 1. アンドゥ機能
- 間違った操作をしてしまった？心配いりません！
- 「アンドゥ」ボタンを押せば1手戻せます。
- 最初まで何度でもアンドゥ可能です。
- 指のミスでゲームを台無しにしないでください！

### 2. シークレットチートモード
- 魔法のシーケンスを入力: ←←→→ →→←←（左、左、右、右、右、右、左、左）
- すべてのタイルが魔法のように128になります！
- これはイースターエッグです。お楽しみ用です。
- プロのヒント: チートは楽しいですが、やりすぎに注意！😉

## 🎯 デモ

🎯 ここでプレイ: [2048.765431.xyz](https://2048.765431.xyz/)
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
**ファイルの説明：**
- `2048.py`：Flaskで書かれたバックエンドサーバーで、ゲームロジックとAPIリクエストを処理します。
- `script.js`：フロントエンドのゲームロジックで、移動、アニメーション、特殊機能を含みます。
- `styles.css`：ゲームのスタイルで、すべてが見栄え良くレスポンシブになるようにします。
- `index.html`：すべてをまとめるメインページです。

## 🚀 はじめに

**方法1：リリースをダウンロード**
1. 最新のリリースをダウンロードします。
2. Python 3.x がインストールされていることを確認します。
3. 依存関係をインストール：`pip install flask`
4. 実行：`python 2048.py`
5. ブラウザを開き、次のURLにアクセス：[http://localhost:9969](http://localhost:9969)

**方法2：GitHubからクローン**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 カスタマイズ

自分だけのものにしたいですか？ `styles.css`を調整して新しい見た目にしたり、`script.js`を編集してゲームプレイを変更したりできます。すべてのコードに分かりやすいコメントがついているので、簡単にカスタマイズできます！

## 📝 ライセンス

GPL-2.0 ライセンス

## 🤝 コントリビュート

まだまだ更新中です！Issue や Pull Request は大歓迎です—一緒にこのゲームをさらに素晴らしいものにしましょう！


## 🙏 謝辞

このプロジェクトを支援してくださった以下のスポンサーに感謝します:
- [IDC.REST](https://idc.rest/) サーバーの提供
- [Serv00](https://www.serv00.com/) サーバーの提供

---
_最終更新日: 2025年6月_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---