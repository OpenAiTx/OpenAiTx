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

クラシックな2048ゲームがパワーアップ！さらに楽しい機能が追加されています。これは私の空き時間に作った小さなプロジェクトです――あなたにも楽しんでもらえたら嬉しいです！

## 🎯 ゲーム紹介

2048はシンプルなのに夢中になる数字パズルゲームです。4x4のマスで、上下左右にスワイプして同じ数字のタイルを合体させましょう。目標は？2048に到達すること（でも、もっと高得点を目指して続けてもOK！）

**遊び方:**
- 矢印キーまたはWASDキーでタイルを動かします。
- 同じ数字のタイルがぶつかると1つに合体します。
- 毎回の移動後、空いているマスにランダムで2か4が出現します。
- もう動かせなくなったらゲームオーバーです。

## ✨ 特別機能

### 1. アンドゥ機能
- 間違った操作をしても心配ありません！
- 「アンドゥ」ボタンを押せば1手前に戻れます。
- ゲーム開始まで好きなだけアンドゥ可能です。
- うっかりミスでゲームを台無しにすることはもうありません！

### 2. シークレットチートモード
- 秘密のコマンドを入力：←←→→ →→←←（左、左、右、右、 右、右、左、左）
- すべてのタイルが魔法のように128になります！
- これはイースターエッグ、お楽しみ用です。
- プロのヒント: チートは楽しいけど、やりすぎには注意！😉

## 🎯 デモ

🎯 ここでプレイ：[http://2048.ct8.pl](http://2048.ct8.pl:9969/)
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

自分好みにしたいですか？新しい見た目にするには `styles.css` を調整し、ゲームプレイを変えたいなら `script.js` に挑戦しましょう。すべてのコードには分かりやすいコメントが付いているので、簡単に改造できます！

## 📝 ライセンス

GPL-2.0 ライセンス

## 🤝 貢献

まだ更新中です！Issue や Pull Request は大歓迎です—一緒にこのゲームをもっと素晴らしいものにしましょう！


## 🙏 謝辞

本プロジェクトを支援してくれた以下のスポンサーに感謝します：
- [Serv00](https://www.serv00.com/) サーバーの提供

---
_最終更新日：2025年6月_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---