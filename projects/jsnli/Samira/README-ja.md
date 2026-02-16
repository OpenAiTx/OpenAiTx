# Samira

Linux向けのSteam実績管理ツール

![example](https://raw.githubusercontent.com/jsnli/Samira/master/./assets/screenshot.png)

## 説明
Samiraは、実績を解除したり統計情報を設定したりできるデスクトップアプリケーションです。  

## インストールと使用法
リリースは[こちら](https://github.com/jsnli/Samira/releases)で見つけることができます。

Steamが起動しており、ユーザーがログインしている必要があります。

Flatpakはサポートされていません。Steamはディストリビューションのパッケージマネージャーか公式の[Steamページ](https://store.steampowered.com/about/)のインストーラーからインストールしてください。

## ビルド

このプロジェクトをビルドするには、Tauriの[前提条件](https://tauri.app/start/prerequisites/)に加え、Rust、Node、npmが必要です。

リポジトリをクローンしてインストールしてください：
```
cd Samira && npm install
```
Tauriはライブラリ検索パスを自動的に設定しません。これはTauriの既知の問題であり、公式の修正が提供されるまでは自分で設定する必要があります：  

```
export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:/usr/lib/libsteam_api.so
```

The `libsteam_api.so` file is available in `/assets/`.

**Dev**
```
npm run tauri dev
```

**ビルド**
```
npm run tauri build
```

Archベースのディストリビューションでは、Tauriとlinuxdeployが誤った`strip`バイナリを使用するため、バンドルエラーが発生することがあります。回避策があります：
```
NO_STRIP=true npm run tauri build
```

## 貢献について
前身のプロジェクト同様、Samiraはオープンソースであり、貢献を歓迎しています。質問、プルリクエストの提出、問題提起はお気軽にどうぞ。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---