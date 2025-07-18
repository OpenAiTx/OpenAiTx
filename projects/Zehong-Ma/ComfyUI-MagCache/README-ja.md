# ComfyUI-MagCache

## 🫖 はじめに  
Magnitude-aware Cache（MagCache）は、トレーニング不要のキャッシュ手法です。堅牢な**大きさの観測値**に基づいて時刻ステップ間のモデル出力の変動差を推定し、誤差モデリング機構と適応的キャッシュ戦略を用いて推論を加速します。MagCacheはビデオ拡散モデルや画像拡散モデルで効果的に動作します。詳細や結果については、[プロジェクトページ](https://zehong-ma.github.io/MagCache)および[コード](https://github.com/Zehong-Ma/MagCache)をご覧ください。

MagCacheは現在ComfyUIに統合されており、ComfyUIネイティブノードと互換性があります。ComfyUI-MagCacheは使いやすく、MagCacheノードをComfyUIネイティブノードに接続するだけでシームレスに使用できます。

## 🔥 最新情報  
- **プロジェクトを気に入ったら、最新情報を得るためにGitHubでスター⭐をお願いします。**
- [2025/6/30] 🔥 [Flux-Kontext](https://huggingface.co/black-forest-labs/FLUX.1-Kontext-dev)を2倍速でサポート。デモはこちらをご覧ください [here](https://github.com/user-attachments/assets/79d5f654-5828-442d-b1a1-9b754c17e457)。
- [2025/6/19] 🔥 [FramePack](https://github.com/lllyasviel/FramePack)をGradioデモ付きで[MagCache-FramePack](https://github.com/Zehong-Ma/MagCache)にてサポート。
- [2025/6/18] 👉 コミュニティから最適パラメータ設定を募集中。<br> 👉**設定を共有するには、この[ディスカッションissue](https://github.com/Zehong-Ma/ComfyUI-MagCache/issues/15)を開いてください！**
- [2025/6/17] 🔥 [Wan2.1-VACE-1.3B](https://github.com/ali-vilab/VACE)をサポートし、1.7倍の加速を達成。
- [2025/6/17] 🔥 MagCacheは[ComfyUI-WanVideoWrapper](https://github.com/kijai/ComfyUI-WanVideoWrapper)でサポートされています。@[kijai](https://github.com/kijai)に感謝。
- [2025/6/16] 🔥 [Chroma](https://huggingface.co/lodestones/Chroma)をサポート。コードベース提供に@[kabachuha](https://github.com/kabachuha)に感謝。
- [2025/6/10] 🔥 [Wan2.1](https://github.com/Wan-Video/Wan2.1) T2V＆I2V、[HunyuanVideo](https://github.com/Tencent/HunyuanVideo) T2V、[FLUX-dev](https://github.com/black-forest-labs/flux) T2Iをサポート。

## インストール
<!-- ComfyUI-Managerによるインストールが推奨されます。ノードリストでComfyUI-MagCacheを検索し、インストールをクリックしてください。 -->
### 手動インストール
1. comfyUIのcustom_nodesフォルダに移動、`ComfyUI/custom_nodes/`
2. git clone https://github.com/zehong-ma/ComfyUI-MagCache.git
3. ComfyUI-MagCacheフォルダに移動、`cd ComfyUI-MagCache/`
4. pip install -r requirements.txt
5. プロジェクトフォルダ `ComfyUI/` に移動し、`python main.py`を実行

## 使い方

### モデルウェイトのダウンロード
まずは以下リンクを参考にComfyUI形式のモデルウェイトを準備してください：
- [Wan2.1](https://comfyanonymous.github.io/ComfyUI_examples/wan/)
- [HunyuanVideo](https://comfyanonymous.github.io/ComfyUI_examples/hunyuan_video/)
- [FLUX](https://comfyanonymous.github.io/ComfyUI_examples/flux/)
- [Chroma](https://huggingface.co/lodestones/Chroma)

### MagCache

**コミュニティから最適パラメータ設定を募集中です。この[ディスカッションissue](https://github.com/Zehong-Ma/ComfyUI-MagCache/issues/15)を開いて設定を共有してください！**

MagCacheノードを使うには、`Load Diffusion Model`ノードまたはLoRAが必要な場合は`Load LoRA`ノードの後に`MagCache`ノードをワークフローに追加してください。一般的に、MagCacheは視覚的品質の許容範囲内で2倍から3倍の速度向上を実現します。以下の表は各モデルに推奨されるmagcache_thresh、retention_ratio、およびmagcache_Kを示しています：

<div align="center">

| モデル                       |   magcache_thresh |   retention_ratio |    magcache_K     |  
|:----------------------------:|:-----------------:|:-----------------:|:-----------------:|
| FLUX                         |        0.24       |         0.1       |         5         |
| FLUX-Kontext                 |        0.05       |         0.2       |         4         |
| Chroma                       |        0.10       |         0.25      |         2         |
| HunyuanVideo-T2V             |        0.24       |         0.2       |         6         |
| Wan2.1-T2V-1.3B              |        0.12       |         0.2       |         4         |
| Wan2.1-T2V-14B               |        0.24       |         0.2       |         6         |
| Wan2.1-I2V-480P-14B          |        0.24       |         0.2       |         6         |
| Wan2.1-I2V-720P-14B          |        0.24       |         0.2       |         6         |
| Wan2.1-VACE-1.3B             |        0.02       |         0.2       |         3         |

</div>

**MagCache適用後の画像やビデオの品質が低い場合は、`magcache_thresh`と`magcache_K`を減らしてください。** デフォルトパラメータは非常に高速（2倍〜3倍）推論向けに設定されており、場合によっては失敗することがあります。

デモワークフロー（[flux](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/flux.json)、[flux-kontext](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/flux_1_kontext_dev.json)、[chroma](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/chroma.json)、[hunyuanvideo](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/hunyuanvideo.json)、[wan2.1_t2v](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/wan2.1_t2v.json)、[wan2.1_i2v](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/wan2.1_i2v.json)、[wan2.1_vace](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/wan2.1_vace.json)）はexamplesフォルダに配置されています。ワークフロー[chroma_calibration](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/chroma_calibration.json)は、推論ステップ数が事前定義値と異なる場合に`mag_ratios`を較正するために使用します。  
**実験では、Wan2.1で生成された動画は[元の非量子化版](https://github.com/Wan-Video/Wan2.1)に比べて高品質とは言えません。**

### モデルのコンパイル
Compile Modelノードを使用するには、`Load Diffusion Model`ノードまたは`MagCache`ノードの後に`Compile Model`ノードをワークフローに追加してください。Compile Modelは`torch.compile`を用いてモデルをより効率的な中間表現（IR）にコンパイルし、バックエンドコンパイラを活用して最適化コードを生成することでモデル性能を強化します。このコンパイルは初回実行時に時間がかかる場合がありますが、一度コンパイルされると推論は非常に高速になります。  
<!-- 使用例は以下の通りです： -->
<!-- ![](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./assets/compile.png) -->

## 謝辞
[ComfyUI-TeaCache](https://github.com/welltop-cn/ComfyUI-TeaCache)、[ComfyUI](https://github.com/comfyanonymous/ComfyUI)、[ComfyUI-MagCache](https://github.com/wildminder/ComfyUI-MagCache)、[MagCache](https://github.com/Zehong-Ma/MagCache/)、[TeaCache](https://github.com/ali-vilab/TeaCache)、[HunyuanVideo](https://github.com/Tencent/HunyuanVideo)、[FLUX](https://github.com/black-forest-labs/flux)、[Chroma](https://huggingface.co/lodestones/Chroma)、および[Wan2.1](https://github.com/Wan-Video/Wan2.1)に感謝します。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---