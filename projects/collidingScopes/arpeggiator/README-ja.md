# ハンドジェスチャーアルペジエーター

手で操作するアルペジエーター、ドラムマシン、オーディオリアクティブビジュアライザー。手を上げて盛り上げよう！

threejs、mediapipeコンピュータビジョン、rosebud AI、tone.jsを使用して構築されたインタラクティブなWebアプリです。

- 手#1はアルペジオをコントロールします（手を上げてピッチを上げる、ピンチしてボリュームを変更）
- 手#2はドラムをコントロールします（異なる指を上げてパターンを変更）

[ビデオ](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [ライブデモ](https://collidingscopes.github.io/arpeggiator/) | [コード＆チュートリアル集](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## 必要環境

- WebGL対応の最新Webブラウザ
- 手のトラッキング用のカメラアクセス

## 使用技術

- **MediaPipe**：手のトラッキングとジェスチャー認識
- **Three.js**：オーディオリアクティブなビジュアル描画
- **Tone.js**：シンセサイザーサウンド
- **HTML5 Canvas**：ビジュアルフィードバック
- **JavaScript**：リアルタイムインタラクション
## 開発用セットアップ

```bash
# このリポジトリをクローン
git clone https://github.com/collidingScopes/arpeggiator

# プロジェクトディレクトリに移動
cd arpeggiator

# 任意の方法でサーブ（例：Pythonを使用）
python -m http.server
```

その後、ブラウザで `http://localhost:8000` にアクセスしてください。

## ライセンス

MITライセンス

## クレジット
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## 関連プロジェクト

いくつかのコンピュータビジョンプロジェクト（コード＋チュートリアル付き）をこちらで公開しています：
[Fun With Computer Vision](https://www.funwithcomputervision.com/)

生涯アクセス権を購入して、全てのプロジェクトファイルとチュートリアルを受け取ることができます。コンテンツは定期的に追加しています 🪬

他にも私のオープンソースプロジェクトを気に入っていただけるかもしれません：

- [3D Model Playground](https://collidingScopes.github.io/3d-model-playground) - 声と手のジェスチャーで3Dモデルを操作
- [Threejs hand tracking tutorial](https://collidingScopes.github.io/threejs-handtracking-101) - threejsとMediaPipeコンピュータビジョンによる基本的なハンドトラッキングのセットアップ
- [Particular Drift](https://collidingScopes.github.io/particular-drift) - 写真を流れるパーティクルアニメーションに変換
- [Video-to-ASCII](https://collidingScopes.github.io/ascii) - 動画をASCIIピクセルアートに変換
## お問い合わせ

- Instagram: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- Twitter/X: [@measure_plan](https://x.com/measure_plan)
- Email: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- GitHub: [collidingScopes](https://github.com/collidingScopes)

## 寄付について

このツールが役に立った場合は、ぜひコーヒーをご馳走してください。

私はアランと申します。コンピュータビジョンやゲームなどのオープンソースソフトウェアの開発を楽しんでいます。夜遅くまでのコーディングセッションの際に、非常にありがたいです！

[![Buy Me A Coffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---