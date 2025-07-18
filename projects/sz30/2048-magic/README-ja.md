[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

クラシックな2048ゲームの強化版で、さらに楽しい機能が満載！これは私が暇なときに作ったちょっとしたプロジェクトです—楽しんでいただければ幸いです！

## 🎯 ゲーム紹介

2048はシンプルでありながら中毒性のある数字合成ゲームです。4x4のグリッド上で、上下左右にスワイプして同じ数字のタイルを合成しましょう。目標は？2048に到達すること（でも、さらに高得点を狙って続けることもできます）！

**遊び方：**
- 矢印キーまたはWASDでタイルを動かします。
- 同じ数字のタイルが衝突すると、1つに合成されます。
- 各ターンの後、空いている場所に2か4がランダムに現れます。
- 動かせる手がなくなったらゲーム終了です。

## ✨ 特別機能

### 1. アンドゥ機能
- 間違った動きをしてしまった？心配無用！
- 「Undo」ボタンを押せば1手前に戻れます。
- 何度でもアンドゥ可能で、最初の状態まで戻れます。
- もう指のミスでゲームを台無しにしないで！

### 2. シークレットチートモード
- 魔法のシーケンスを入力：←←→→ →→←←（左、左、右、右、右、右、左、左）
- すべてのタイルが魔法のように128に変わります！
- これはイースターエッグで、遊び心のためのものです。
- プロのコツ：チートは楽しいけど、やりすぎないでね！😉

## 🎯 デモ

🎯 ここで遊べます: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---