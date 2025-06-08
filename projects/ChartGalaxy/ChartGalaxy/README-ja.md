![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/title.png)

## データセット
> 📦 **[👉 ChartGalaxyの完全なデータセットをHugging Faceで入手！👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

保存容量の制限により、代表的なサンプルのみを収録しています。  
このリポジトリは、論文「ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation」に関連するコードを含みます。

## 🔥 ニュース
**2025.5**:  🎉🎉 データセットの初版をリリースしました。1,151,087個の合成インフォグラフィックチャートと104,519個の実際のインフォグラフィックチャートを収録し、75種類のチャートタイプと330のバリエーションをカバーしています。

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/examples.png)

<!-- ## 🔔 News -->

## はじめに

### 概要

ChartGalaxyは、データテーブル付きの合成および実際のインフォグラフィックチャートを大量に収集したデータセットであり、インフォグラフィックチャートの理解、コード生成、チャート生成などの応用を支援します。本データセットは、既存のデータセットが主にシンプルなチャートに限定され、インフォグラフィックチャートの主要な特徴である多様なデザインスタイルやレイアウトを十分に捉えられていない課題を解決します。

### 統計情報

- **規模**: 1,255,606件のインフォグラフィックチャート（合成1,151,087件 + 実際104,519件）
- **内容**: 各インフォグラフィックチャートには生成に使用された表形式データが付随
- **チャートタイプ**: 75種類のチャートタイプ、330種類のバリエーション
- **レイアウトテンプレート**: 68種類のレイアウトテンプレート

### データ収集・生成

ChartGalaxyは以下のプロセスで構築されました：

1. **実際のインフォグラフィックチャートの収集**  
Pinterest、Visual Capitalist、Statista、Information is Beautifulなど、19の信頼性の高いチャート豊富なWebサイトからチャートを収集しました。

2. **合成インフォグラフィックチャートの生成**  
帰納的な構造化プロセスに従い、
   - 75種類のチャートタイプ（例：棒グラフ）および異なるビジュアル要素スタイルを表現する330種類のバリエーションを特定
   - 要素間の空間関係を定義する68種類のレイアウトテンプレートを抽出
   - これらのパターンに基づき合成チャートをプログラム的に生成

## 🎯 応用例

ChartGalaxyの有用性は、以下の3つの代表的な応用例で実証されています：

### 1. 🧠 インフォグラフィックチャートの理解

ChartGalaxyでファインチューニングすることで、基盤モデルのインフォグラフィックチャート理解性能が向上します。

### 2. 💻 インフォグラフィックチャートのコード生成

LVLMsによるインフォグラフィックチャートのコード生成を評価するベンチマークを提供します。  
このベンチマークは、生成されたD3.jsコードで描画されたチャートと正解チャートとの類似度を、2つの粒度（高レベル：全体的な視覚的類似度、低レベル：細粒度SVG要素ごとの平均類似度）で評価します。

#### 概要

ベンチマークは2つのレベルでチャートコード生成を評価します：
- **低レベル**: 生成SVGと参照SVGの要素ごとの類似度
- **高レベル**: 全体的な視覚的忠実度および機能性評価

#### インストール

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### 使い方

1. `code_generation_benchmark/configs/default_config.yaml`で設定を行います：
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # 評価するモデルのコメントアウトを外す
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. ベンチマークを実行します：
   ```bash
   python main.py
   ```

#### データ構成

`data_root_dir`内の各チャートフォルダには以下が含まれている必要があります：
- `chart.svg`: オリジナルのSVG形式チャート

システムが生成するファイル：
- `convert_chart.html`: 参照チャートのHTMLレンダリング
- `convert_chart.png`: 参照チャートのPNGスクリーンショット
- `convert_chart.json`: 参照チャートの要素構造
- モデルごとの出力を含むサブフォルダ

#### 結果

結果はモデルごとのサブフォルダに保存されます：
- 生成されたHTML/PNGレンダリング
- JSON形式の評価指標
- `log_dir`内の詳細ログ
  

### 3. 🖼️ サンプルベースのインフォグラフィックチャート生成

ユーザーが指定した表形式データを、与えられたサンプルチャートのレイアウトやビジュアルスタイルに合わせてインフォグラフィックチャートに変換するサンプルベース手法。ユーザースタディにより、この手法は忠実度、美しさ、創造性の面でGPT-Image-1を上回ることが示されています。

## お問い合わせ
- chartgalaxy@163.com

## 論文リンク

### 📌 メイン論文（本リポジトリ）

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### 関連論文

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 引用
ChartGalaxyを研究で利用する場合は、以下の情報を引用してください：
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---