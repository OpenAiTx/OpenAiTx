# AlphaEarth Foundations

Google DeepMindのAlphaEarth地理空間基盤モデルのPyTorch実装であり、地球の埋め込みを生成して世界的な環境モニタリングと解析に利用します。  
論文に付随して、2017年から2024年までのグローバル埋め込みデータセットがEarth Engineを通じて利用可能です。これらの埋め込みの目的は、再学習なしで多くの下流アプリケーションに対応可能な非常に汎用的な地理空間表現を提供することです。

> [!NOTE]
> このモデルは進行中の作業であり、実際には完全なデータセットで学習されていません。論文のアーキテクチャの一般的な基盤を提供するフレームワークにすぎません。コードはDeepMindの実際の実装（JAX）に比べて簡略化されています。

### 方法論の主な部分

- **連続時間サポート**：連続時間をサポートする最初のEO特徴化アプローチであり、時間的内挿および外挿が可能です。  
- **Space Time Precision (STP) アーキテクチャ**：空間（1/16L）、時間（1/8L）、精度（1/2L）のオペレーターを備えた多解像度エンコーダで、局所的表現を維持しつつ時間と空間を跨る長距離関係をモデル化します。  
- **フォン・ミーゼス・フィッシャー埋め込み**：単位球面S^63上に分布する64バイトの埋め込みで、非常にコンパクトな表現です。  


## アーキテクチャ

### Space Time Precision (STP) エンコーダ

STPエンコーダは、3つの同時オペレーターを通じて多時点・多ソースデータを処理します：  
- **空間オペレーター**：ViTに類似した空間的自己注意（1/16L解像度）  
- **時間オペレーター**：時間軸自己注意（1/8L解像度）  
- **精度オペレーター**：3x3畳み込み（1/2L解像度）  

### 教師-生徒-テキストフレームワーク

1. **教師ビデオ埋め込みモデル**：暗黙的デコーダを持つメインモデル  
2. **生徒ビデオ埋め込みモデル**：教師とパラメータを共有し、対比学習を行う  
3. **テキスト整合モデル**：テキストと画像の対比学習を可能にする  


## データソース

モデルは以下を含む多くのデータソースで学習されています：  
- **光学**：Sentinel-2、Landsat 8/9。*注：簡略化のため、私の実装はSentinel-2のみ対応していますが、新しいデータセットを学習に追加するのは比較的簡単です*  
- **レーダー**：Sentinel-1、PALSAR2  
- **LiDAR**：GEDI  
- **環境**：GLO-30、ERA5-Land、GRACE  
- **注釈/テキスト**：NLCD、Wikipedia  

## インストール

```bash
# Clone the repository
git clone https://github.com/brayden-zhang/alphaearth-foundations.git
cd alphaearth-foundations

# Install dependencies
uv pip install -r requirements.txt

# Install the package 
uv pip install -e .
```
トレーニングステップの実行方法：

```
python -m alphaearth.run_train
```

## 論文引用

```bibtex
@misc{brown2025alphaearthfoundationsembeddingfield,
      title={AlphaEarth Foundations: An embedding field model for accurate and efficient global mapping from sparse label data}, 
      author={Christopher F. Brown and Michal R. Kazmierski and Valerie J. Pasquarella and William J. Rucklidge and Masha Samsikova and Chenhui Zhang and Evan Shelhamer and Estefania Lahera and Olivia Wiles and Simon Ilyushchenko and Noel Gorelick and Lihui Lydia Zhang and Sophia Alj and Emily Schechter and Sean Askay and Oliver Guinan and Rebecca Moore and Alexis Boukouvalas and Pushmeet Kohli},
      year={2025},
      eprint={2507.22291},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2507.22291}, 
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-01

---