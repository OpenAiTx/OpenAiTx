# BiliAnalysis

[![Stars](https://img.shields.io/github/stars/mmyo456/BiliAnalysis?style=flat-square)](https://github.com/mmyo456/BiliAnalysis/stargazers)
[![License](https://img.shields.io/github/license/mmyo456/BiliAnalysis?style=flat-square)](https://github.com/mmyo456/BiliAnalysis/blob/main/LICENSE)
[![Release](https://img.shields.io/github/v/release/mmyo456/BiliAnalysis?style=flat-square)](https://github.com/mmyo456/BiliAnalysis/releases/latest)

**軽量 · シンプル · オープンソース · モジュール式**

Bilibiliの動画とライブの直接リンクを取得するTampermonkeyスクリプトおよびブラウザ拡張機能。

## 機能特長

- 動画とライブ配信の解析に対応
- ローカル解析とクラウド解析を提供
- 右クリックメニューから直接リンクを素早くコピー
- モジュール設計で必要に応じてインストール可能

## バージョン選択

| バージョン | 解析方式 | 説明 |
| :--- | :--- | :--- |
| **BiliCloudAnalysis** | クラウド（推奨） | 安定かつ信頼性が高く、1080P以上の解析問題を解決 |
| BiliAnalysis | ローカル | 高速だが、一部の高画質動画で失敗する可能性あり |
| BiliRoomAnalysis | ローカル | ライブ配信専用 |
| 右クリック解析プラグイン | ブラウザ拡張 | クラウド版と同様、Tampermonkey不要 |

## クイックインストール

### Tampermonkeyスクリプト

1. [Tampermonkey](https://www.tampermonkey.net/)をインストール
2. 下記リンクをクリックしてスクリプトをインストール

| スクリプト | GitHub | 国内ミラー |
| :--- | :--- | :--- |
| 動画クラウド解析（推奨） | [インストール](https://raw.githubusercontent.com/mmyo456/BiliAnalysis/main/BiliCloudAnalysis.user.js) | [インストール](https://raw.gitmirror.com/mmyo456/BiliAnalysis/main/BiliCloudAnalysis.user.js) |
| 動画クラウド解析1 | [インストール](https://raw.githubusercontent.com/mmyo456/BiliAnalysis/main/BiliCloudAnalysis_1.user.js) | [インストール](https://raw.gitmirror.com/mmyo456/BiliAnalysis/main/BiliCloudAnalysis_1.user.js) |
| ローカル解析 | [インストール](https://raw.githubusercontent.com/mmyo456/BiliAnalysis/main/BiliAnalysis.user.js) | [インストール](https://raw.gitmirror.com/mmyo456/BiliAnalysis/main/BiliAnalysis.user.js) |
| ライブ配信解析 | [インストール](https://raw.githubusercontent.com/mmyo456/BiliAnalysis/main/BiliRoomAnalysis.user.js) | [インストール](https://raw.gitmirror.com/mmyo456/BiliAnalysis/main/BiliRoomAnalysis.user.js) |

### ブラウザ拡張機能

1. `右クリック解析プラグイン.zip` をダウンロードして解凍する
2. ブラウザの拡張機能ページで「開発者モード」をオンにする
3. 解凍した拡張機能を読み込む
4. 詳細は [Edge 拡張機能の読み込みチュートリアル](https://learn.microsoft.com/zh-cn/microsoft-edge/extensions-chromium/getting-started/extension-sideloading) を参照
 
効果は以下の通り

<img src="https://github.com/mmyo456/BiliAnalysis/assets/70092715/27911680-9d0f-4f84-b849-22165381f6fa" alt="QQ截图20230909142830" width="400"> <br>

## 使い方

Bilibili の動画タイトル上で右クリックし、「動画解析」を選択すると直リンクを取得できます。

> **重要な注意事項**：クラウド解析は公共サーバーに依存しているため、乱用しないでください。VRChat ワールドやウェブサイトで使用する場合は、元の作者情報を保持してください。

## サポートプロジェクト

クラウド解析サービスはサーバーコストがかかります。役に立ったと思ったら、ぜひ [スポンサー支援](https://www.ouo.chat/sponsor) をお願いします。

## 謝辞

- [91VRChat](https://www.91vrchat.com/) - クラウド解析リソースとアイデアの提供
- [ouo.chat](https://ouo.chat/) - クラウド解析サービスリソースの提供
- [BiliBili-JX](https://github.com/gujimy/BiliBili-JX) - コード参考の提供

## Contributors 貢献者  
本プロジェクトに支援をいただいたすべての方に感謝します：  
<a href="https://github.com/mmyo456/BiliAnalysis/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=mmyo456/BiliAnalysis" />
</a>

## ライセンス

[MIT License](https://github.com/mmyo456/BiliAnalysis/blob/main/LICENSE)

## Star履歴

[![Star History Chart](https://api.star-history.com/svg?repos=mmyo456/BiliAnalysis&type=Date)](https://star-history.com/#mmyo456/BiliAnalysis&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-13

---