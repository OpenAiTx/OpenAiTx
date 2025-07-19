<translate-content># ContentV: 限られた計算リソースでの効率的な動画生成モデルのトレーニング

<div align="center">
<p align="center">
  <a href="https://contentv.github.io">
    <img
      src="https://img.shields.io/badge/Gallery-Project Page-0A66C2?logo=googlechrome&logoColor=blue"
      alt="プロジェクトページ"
    />
  </a>
  <a href='https://arxiv.org/abs/2506.05343'>
    <img
      src="https://img.shields.io/badge/Tech Report-ArXiv-red?logo=arxiv&logoColor=red"
      alt="技術レポート"
    />
  </a>
  <a href="https://huggingface.co/ByteDance/ContentV-8B">
    <img 
        src="https://img.shields.io/badge/HuggingFace-Model-yellow?logo=huggingface&logoColor=yellow" 
        alt="モデル"
    />
  </a>
  <a href="https://github.com/bytedance/ContentV">
    <img 
        src="https://img.shields.io/badge/Code-GitHub-orange?logo=github&logoColor=white" 
        alt="コード"
    />
  </a>
  <a href="https://www.apache.org/licenses/LICENSE-2.0">
    <img
      src="https://img.shields.io/badge/License-Apache 2.0-5865F2?logo=apache&logoColor=purple"
      alt="ライセンス"
    />
  </a>
</p>
</div>

本プロジェクトでは、DiTベースの動画生成モデルのトレーニングを加速する効率的なフレームワーク*ContentV*を、以下の3つの主要な革新を通じて提案します：

- 事前学習済み画像生成モデルの再利用を最大化するミニマリストなアーキテクチャによる動画合成
- 効率向上のためにフローマッチングを活用した体系的なマルチステージトレーニング戦略
- 追加の人手アノテーションを必要とせず生成品質を向上させるコスト効率の良い人間フィードバックによる強化学習フレームワーク

当社のオープンソース8Bモデル（Stable Diffusion 3.5 LargeとWan-VAEに基づく）は、256×64GB NPUでわずか4週間のトレーニングで最先端の結果（VBenchで85.14）を達成しています。

<div align="center">
    <img src="https://raw.githubusercontent.com/bytedance/ContentV/main/./assets/demo.jpg" width="100%">
    <img src="https://raw.githubusercontent.com/bytedance/ContentV/main/./assets/arch.jpg" width="100%">
</div>

## ⚡ クイックスタート

#### 推奨PyTorchバージョン

- GPU: torch >= 2.3.1 (CUDA >= 12.2)

#### インストール
</translate-content>
```bash
git clone https://github.com/bytedance/ContentV.git
cd ContentV
pip3 install -r requirements.txt
```
#### T2V生成


```bash
## For GPU
python3 demo.py
```
## 📊 VBench

| モデル | 合計スコア | 品質スコア | セマンティックスコア | 人間の動作 | シーン | 動的度合い | 複数オブジェクト | 出現スタイル |
|----------------------|--------|-------|-------|-------|-------|-------|-------|-------|
| Wan2.1-14B           | 86.22  | 86.67 | 84.44 | 99.20 | 61.24 | 94.26 | 86.59 | 21.59 |
| **ContentV (Long)**  | 85.14  | 86.64 | 79.12 | 96.80 | 57.38 | 83.05 | 71.41 | 23.02 |
| Goku†                | 84.85  | 85.60 | 81.87 | 97.60 | 57.08 | 76.11 | 79.48 | 23.08 |
| Open-Sora 2.0        | 84.34  | 85.40 | 80.12 | 95.40 | 52.71 | 71.39 | 77.72 | 22.98 |
| Sora†                | 84.28  | 85.51 | 79.35 | 98.20 | 56.95 | 79.91 | 70.85 | 24.76 |
| **ContentV (Short)** | 84.11  | 86.23 | 75.61 | 89.60 | 44.02 | 79.26 | 74.58 | 21.21 |
| EasyAnimate 5.1      | 83.42  | 85.03 | 77.01 | 95.60 | 54.31 | 57.15 | 66.85 | 23.06 |
| Kling 1.6†           | 83.40  | 85.00 | 76.99 | 96.20 | 55.57 | 62.22 | 63.99 | 20.75 |
| HunyuanVideo         | 83.24  | 85.09 | 75.82 | 94.40 | 53.88 | 70.83 | 68.55 | 19.80 |
| CogVideoX-5B         | 81.61  | 82.75 | 77.04 | 99.40 | 53.20 | 70.97 | 62.11 | 24.91 |
| Pika-1.0†            | 80.69  | 82.92 | 71.77 | 86.20 | 49.83 | 47.50 | 43.08 | 22.26 |
| VideoCrafter-2.0     | 80.44  | 82.20 | 73.42 | 95.00 | 55.29 | 42.50 | 40.66 | 25.13 |
| AnimateDiff-V2       | 80.27  | 82.90 | 69.75 | 92.60 | 50.19 | 40.83 | 36.88 | 22.42 |
| OpenSora 1.2         | 79.23  | 80.71 | 73.30 | 85.80 | 42.47 | 47.22 | 58.41 | 23.89 |

## ✅ Todoリスト
- [x] 推論コードとチェックポイント
- [ ] RLHFのトレーニングコード

## 🧾 ライセンス
このコードリポジトリおよび一部のモデル重みは、[Apache 2.0 ライセンス](https://www.apache.org/licenses/LICENSE-2.0)の下でライセンスされています。ご注意ください：
- MM DiTは[Stable Diffusion 3.5 Large](https://huggingface.co/stabilityai/stable-diffusion-3.5-large)に由来し、ビデオサンプルでトレーニングされています。このStability AIモデルは[Stability AI Community License](https://stability.ai/community-license-agreement)の下でライセンスされており、著作権© Stability AI Ltd. 全著作権所有。
- [Wan2.1](https://huggingface.co/Wan-AI/Wan2.1-T2V-14B)のビデオVAEは[Apache 2.0 ライセンス](https://huggingface.co/Wan-AI/Wan2.1-T2V-14B/blob/main/LICENSE.txt)の下でライセンスされています。

## ❤️ 謝辞
* [Stable Diffusion 3.5 Large](https://huggingface.co/stabilityai/stable-diffusion-3.5-large)
* [Wan2.1](https://github.com/Wan-Video/Wan2.1)
* [Diffusers](https://github.com/huggingface/diffusers)
* [HuggingFace](https://huggingface.co)

## 🔗 引用


```bibtex
@article{contentv2025,
  title     = {ContentV: Efficient Training of Video Generation Models with Limited Compute},
  author    = {Bytedance Douyin Content Team},
  journal   = {arXiv preprint arXiv:2506.05343},
  year      = {2025}
  }
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---