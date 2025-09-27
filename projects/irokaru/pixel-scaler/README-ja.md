<div align="center">  
  <a href="https://irokaru.github.io/pixel-scaler/">
    <img src="https://raw.githubusercontent.com/irokaru/pixel-scaler/master/./public/logo.png" width="33%" alt="Pixel Scaler ロゴ"/>
  </a>
  <p><b>ピクセルアートのアップスケーリングツール</b></p>

  <!-- Badges -->
  <p>
    <a href="https://github.com/irokaru/pixel-scaler/releases/latest"><img src="https://img.shields.io/github/v/release/irokaru/pixel-scaler.svg?style=for-the-badge" alt="最新リリース"/></a>
    <img src="https://img.shields.io/github/downloads/irokaru/pixel-scaler/total?style=for-the-badge" alt="ダウンロード数"/>
    <a href="https://app.codecov.io/gh/irokaru/pixel-scaler/tree/master"><img src="https://img.shields.io/codecov/c/github/irokaru/pixel-scaler?style=for-the-badge" alt="カバレッジ"/></a>
    <a href="https://x.com/IroKaru"><img src="https://img.shields.io/twitter/follow/irokaru?style=for-the-badge" alt="Xでフォロー"/></a>
  </p>
</div>

## 開発環境

* node (>= 22.x)
* rust (>=1.85.0)
  * (Tauri開発に必要)

## 開発用セットアップ（WSL）

依存関係をインストール：

```sh
npm ci
```

（オプション）Tauriを使用したい場合：

```sh
cargo install tauri-cli
sudo apt install -y libsoup2.4-dev javascriptcoregtk-4.1 libsoup-3.0 webkit2gtk-4.1 \
                    libjavascriptcoregtk-4.0-dev libwebkit2gtk-4.0-dev librsvg2-dev
```

## 利用可能なコマンド

| コマンド                 | 説明                                                       |
|-------------------------|------------------------------------------------------------|
| `npm run dev`           | Viteで開発サーバーを起動する                                |
| `npm run dev:tauri`     | Tauri開発サーバーを起動する                                |
| `npm run build`         | 本番用にプロジェクトをビルドする                            |
| `npm run build:tauri`   | tauriでプロジェクトをビルドする                            |
| `npm run preview`       | ビルド済みプロジェクトをプレビューする（事前に`npm run build`が必要） |
| `npm run test`          | テストを実行する                                           |
| `npm run test:watch`    | ウォッチモードでテストを実行する                           |
| `npm run test:coverage` | カバレッジ付きでテストを実行する                           |
| `npm run test:e2e`      | playwrightでテストを実行する                               |
| `npm run clean`         | 生成されたファイルを削除する                               |
| `npm run lint-staged`   | ステージされたファイルのリントを実行する                   |
| `npm run prepare`       | Gitフック用のHuskyをセットアップする                      |

## スケーリングライブラリ

* xBRjs (Copyright 2020 Josep del Rio)
  * https://github.com/joseprio/xBRjs


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-27

---