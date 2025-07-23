
# 3Dモデル遊び場

リアルタイムで手のジェスチャーと音声コマンドを使って3Dモデルを操作します。

threejs、mediapipeコンピュータビジョン、Web Speech API、rosebud AIで構築されたインタラクティブなウェブアプリ。

- 「ドラッグ」「回転」「スケール」「アニメート」と言って操作モードを変更
- 指をつまんで3Dモデルを操作
- ページに新しい3Dモデルをドラッグ＆ドロップしてインポート（GLB/GLTF形式）

[ビデオ](https://youtu.be/_I1E44Fp1Es?si=lR2otqR_-ZGdIGXT) | [ライブデモ](https://collidingscopes.github.io/3d-model-playground/)

## 必要条件

- WebGL対応の最新ウェブブラウザ
- カメラ／マイクへのアクセス権

## 技術

- 3Dレンダリングに**Three.js**
- 手の追跡とジェスチャー認識に**MediaPipe**
- 音声認識に**Web Speech API**
- 視覚フィードバックに**HTML5 Canvas**
- リアルタイムインタラクションに**JavaScript**

## 開発用セットアップ

```bash
# Clone this repository
git clone https://github.com/collidingScopes/3d-model-playground

# Navigate to the project directory
cd 3d-model-playground

# Serve with your preferred method (example using Python)
python -m http.server
```
ブラウザで `http://localhost:8000` にアクセスしてください。

## ライセンス

MITライセンス

## クレジット

- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Quaternius 3Dモデル - https://quaternius.com/

## 関連プロジェクト

いくつかのコンピュータビジョンプロジェクト（コード＋チュートリアル付き）をこちらで公開しています：
[Fun With Computer Vision](https://www.funwithcomputervision.com/)

生涯アクセスを購入すると、プロジェクトの全ファイルとチュートリアルを入手できます。定期的にコンテンツを追加しています :)

他のオープンソースプロジェクトも気に入っていただけるかもしれません：

- [Particular Drift](https://collidingScopes.github.io/particular-drift) - 写真を流れるパーティクルアニメーションに変換
- [Liquid Logo](https://collidingScopes.github.io/liquid-logo) - ロゴやアイコンを液体金属のアニメーションに変換
- [Video-to-ASCII](https://collidingScopes.github.io/ascii) - 動画をASCIIピクセルアートに変換

## 連絡先

- Instagram: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- Twitter/X: [@measure_plan](https://x.com/measure_plan)
- メール: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/3d-model-playground/main/mailto:stereodriftvisuals@gmail.com)
- GitHub: [collidingScopes](https://github.com/collidingScopes)

## 寄付

もし気に入っていただけたら、コーヒーをおごってください。

私の名前はアランで、コンピュータビジョンやゲームなどのオープンソースソフトウェアを作るのが好きです。深夜のコーディングセッション中にとても励みになります！

[![Buy Me A Coffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---