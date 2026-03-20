# JustDubit: Joint Audio-Visual Diffusionによるビデオ吹き替え

[![Website](https://img.shields.io/badge/Project-Page-181717?logo=google-chrome)](https://justdubit.github.io)
[![Model](https://img.shields.io/badge/HuggingFace-Model-orange?logo=huggingface)](https://huggingface.co/justdubit/justdubit)
[![Dataset](https://img.shields.io/badge/HuggingFace-Dataset-blue?logo=huggingface)](https://huggingface.co/datasets/justdubit/audiovisual_translation_dub/settings)

## 📰 ニュース

- [2026/02/10] 🔥 コード、チェックポイント、データ公開
- [2026/01/29] 🔥 技術レポート公開


---

## 📄 要約

音声と映像を共同で生成するように事前学習された音声映像基盤モデルは、マルチモーダルな生成と編集を前例のないレベルでモデル化する能力を示し、下流タスクに新たな可能性を開いています。

これらのタスクの中で、ビデオ吹き替えはこのような事前知識から大きな恩恵を受ける可能性がありますが、既存の多くのソリューションは依然として複雑でタスク特化型のパイプラインに依存しており、現実世界の状況では苦戦しています。

本研究では、基盤となる音声映像拡散モデルを軽量なLoRAによってビデオ間吹き替えに適応させる単一モデルアプローチを提案します。LoRAは入力の音声映像を条件として、翻訳された音声と同期した顔の動きを同時に生成できるようにモデルを拡張します。

このLoRAの学習には、生成モデル自体を活用して同一話者の多言語ペア動画を合成します。具体的には、一つのクリップ内で言語が切り替わる多言語動画を生成し、各半分の顔と音声を他方の言語に合わせてインペイントします。

音声映像モデルの豊かな生成事前知識を活用することで、話者の個性やリップシンクを維持しつつ、複雑な動きや現実世界の動的環境に対しても堅牢な性能を実現します。既存の吹き替えパイプラインと比較して、我々の手法が高品質な吹き替え動画をより高い視覚的忠実性、リップシンク、堅牢性で生成することを示します。

---

## 🚀 クイックリンク

| リソース | 説明 |
|----------|-------------|
| [**推論パイプライン**](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-pipelines/README.md) | JustDubitパイプラインでビデオ吹き替えを実行 |
| [**トレーニングガイド**](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-trainer/README.md) | 独自のJustDubit LoRAをトレーニング |

---

## 📦 リポジトリ構成

```
just-dub-it/
├── packages/
│   ├── ltx-pipelines/     # Inference pipeline for video dubbing
│   │   └── README.md      # Pipeline usage guide
│   ├── ltx-trainer/       # Training tools for JustDubit LoRA
│   │   └── README.md      # Training guide
│   └── ltx-core/          # Core model components
└── README.md              # This file
```

---

## 🎬 推論

以下を参照してください：[Pipeline README](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-pipelines/README.md)：
- インストール手順
- モデルチェックポイントのダウンロード
- プロンプトフォーマットガイド
- CLI引数リファレンス

---

## 🏋️ トレーニング

以下を参照してください：[Trainer README](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-trainer/README.md)：
- データセットのダウンロードと準備
- 前処理パイプライン
- トレーニング構成
- マルチGPUトレーニング設定




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-20

---