<div align="right">
  <details>
    <summary >🌐 その他の言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">イタリア語</a>
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

クラシックな2048ゲームを強化したバージョンです。さらに楽しい機能が追加されています！これは私が空き時間に作った小さなプロジェクトです。ぜひ楽しんでください！

## 🎯 ゲーム紹介

2048は、シンプルながら中毒性のある数字合成ゲームです。4×4のグリッド上で、上下左右にスワイプして同じ数字のタイルを合成します。目標は2048に到達すること（でも、さらに高得点も目指せます）！

**遊び方：**
- 矢印キーまたはWASDキーでタイルを移動します。
- 同じ数字のタイルが衝突すると、一つに合体します。
- 各移動後、空いているマスにランダムで2または4が出現します。
- 移動できる手がなくなるとゲームオーバーです。

## ✨ 特別な機能

### 1. アンドゥ機能
- 間違えて動かしてしまった？ご安心を！
- 「アンドゥ」ボタンを押せば一手前に戻れます。
- 最初まで何度でもアンドゥ可能です。
- 指が滑ったせいでゲームを台無しにする心配はもうありません！

### 2. シークレットチートモード
- 魔法のコマンドを入力：←←→→ →→←←（左、左、右、右、右、右、左、左）
- すべてのタイルが一瞬で128に変身！
- これはイースターエッグで、ちょっとしたお楽しみです。
- 裏技のコツ：楽しいけど、やりすぎ注意！😉

## 🎯 デモ

🎯 : [ここでプレイ](http://2048.765431.xyz/)
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

自分だけのものにしたいですか？新しい外観にするには `styles.css` を調整したり、ゲームプレイを変更するには `script.js` を編集してください。すべてのコードには分かりやすいコメントが付いているので、簡単にカスタマイズできます！

## 📝 ライセンス

GPL-2.0 ライセンス

## 🤝 コントリビュート

まだ更新中です！Issue や Pull Request は大歓迎です—一緒にこのゲームをさらに素晴らしいものにしましょう！


## 🙏 謝辞

このプロジェクトをサポートしてくれている以下のスポンサーに感謝します：
- [Aurora Cloud](https://www.free-vps.net/) サーバー提供

---
_最終更新日: 2025年10月_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---