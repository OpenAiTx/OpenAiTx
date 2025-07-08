# EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 論文](https://arxiv.org/abs/2506.05554)  |  [🎥 ホームページ](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 コード](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 ハイライト

- **🎯 極端な視点合成**: -90°から90°までのカメラ移動による高品質な4Dビデオを生成
- **🔧 デプス・ウォータタイトメッシュ**: 可視領域および遮蔽領域の両方をモデル化する新しい幾何表現
- **⚡ 軽量アーキテクチャ**: 14Bビデオ拡散バックボーンの1%（140M）の学習可能パラメータのみ
- **🎭 マルチビュー学習不要**: 革新的なマスキング戦略により高価なマルチビューデータセットが不要
- **🏆 最先端パフォーマンス**: 特に極端なカメラアングルで既存手法を上回る

## 🎬 デモ結果

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4Dは単眼ビデオを物理的に一貫した結果でカメラ操作可能な4D体験へと変換します。*

## 🏗️ フレームワーク概要

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

本フレームワークは以下の3つの主要コンポーネントで構成されています：

1. **🔺 デプス・ウォータタイトメッシュ構築**: 可視および遮蔽領域の両方を明示的にモデル化する堅牢な幾何事前情報を作成
2. **🎭 シミュレートマスキング戦略**: マルチビューデータセットなしで単眼ビデオから効果的な学習データを生成
3. **⚙️ 軽量LoRAアダプタ**: 事前学習済みビデオ拡散モデルに幾何情報を効率的に統合

## 🚀 クイックスタート

### インストール

```bash
# リポジトリをクローン
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# conda環境の作成
conda create -n ex4d python=3.10
conda activate ex4d
# PyTorch（2.x推奨）のインストール
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Nvdiffrastのインストール
pip install git+https://github.com/NVlabs/nvdiffrast.git
# 依存関係とdiffsynthのインストール
pip install -e .
# depthcrafter（深度推定用）のインストール（チェックポイント準備はDepthCrafterのインストール手順を参照）
git clone https://github.com/Tencent/DepthCrafter.git
```

### 学習済みモデルのダウンロード
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### 使用例
#### 1. DWメッシュ再構築
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. EX-4D生成（48GB VRAM必要）
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>入力ビデオ</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>出力ビデオ</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| 手法 | FID（Extreme）↓ | FVD（Extreme）↓ | VBench スコア ↑ |
|--------|-----------------|-----------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D（本研究）** | **55.42** | **823.61** | **0.450** | -->

### ユーザースタディ結果

- 参加者の**70.7%**がベースライン手法よりもEX-4Dを選択
- 物理的一貫性および極端視点での品質で優れた性能
- カメラアングルがより極端になるほど顕著な改善

## 🎯 応用例

- **🎮 ゲーム**: 2D映像から没入感のある3Dゲームシネマティクスを生成
- **🎬 映画制作**: ポストプロダクション用の新規カメラアングル生成
- **🥽 VR/AR**: フリービューポイントビデオ体験の創出
- **📱 ソーシャルメディア**: コンテンツ制作向けのダイナミックなカメラ動作生成
- **🏢 建築**: 複数視点からの空間可視化

<!-- ## 📈 ベンチマーク -->

<!-- ### 視点範囲評価

| 範囲 | 小（0°→30°） | 大（0°→60°） | 極端（0°→90°） | フル（-90°→90°） |
|-------|----------------|----------------|------------------|-----------------|
| FID スコア | 44.19 | 50.30 | 55.42 | - |
| 性能差 | +9.1% 向上 | +8.9% 向上 | +11.3% 向上 | +15.5% 向上 | -->

<!-- *各カテゴリで2番目に優れた手法との比較による性能差。* -->

## ⚠️ 制限事項

- **深度依存**: モノキュラー深度推定の品質に性能が依存
- **計算コスト**: 高解像度ビデオには多大な計算資源を必要とする
- **反射面**: 反射性や透明な素材の処理に課題

## 🔮 今後の課題
- [ ] リアルタイム推論の最適化（3DGS / 4DGS）
- [ ] より高解像度（1K, 2K）対応
- [ ] ニューラルメッシュリファインメント技術の導入

## 🙏 謝辞

[DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) プロジェクトに、基盤となる拡散フレームワークの提供に感謝いたします。

## 📚 引用

本研究が有用であれば、以下のように引用してください：

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---