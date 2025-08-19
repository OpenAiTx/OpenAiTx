<div align="center">
    
<h1><a href="https://ieeexplore.ieee.org/document/10591792">Change-Agent: インタラクティブな包括的リモートセンシング変化解釈と解析に向けて</a></h1>

**[劉晨陽](https://chen-yang-liu.github.io/), [陳可言](https://kyanchen.github.io), [張昊天](https://scholar.google.com/citations?user=c7uR6NUAAAAJ), [齊子鵬](https://scholar.google.com/citations?user=KhMtmBsAAAAJ), [鄒正霞](https://scholar.google.com.hk/citations?hl=en&user=DzwoyZsAAAAJ), および [石振偉*✉](https://scholar.google.com.hk/citations?hl=en&user=kNhFWQIAAAAJ)**

<div align="center">
  <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/Change_Agent.png" width="400"/>
</div>
</div>

## このリポジトリに興味があれば :star: をシェアしてください

論文「**Change-Agent: インタラクティブな包括的リモートセンシング変化解釈と解析に向けて**」の公式PyTorch実装 [[IEEE](https://ieeexplore.ieee.org/document/10591792)]  ***(IEEE TGRS 2024 採択済)***

## 🥳ニュース

- 2024-06: コードを**公開**しました。
- 2024-03: 論文を**公開**しました。
- 🔥 私たちの調査報告「**リモートセンシング時系列ビジョン・言語モデル：包括的サーベイ**」: [Arxiv](https://arxiv.org/abs/2412.02573) || [Github](https://github.com/Chen-Yang-Liu/Awesome-RS-Temporal-VLM)** 🔥 

## 目次
- [LEVIR-MCI データセット](#LEVIR-MCI-dataset)
- [MCIモデルのトレーニング](#Training-of-the-multi-level-change-interpretation-model)
- [Change-Agentの構築](#Construction-of-Change-Agent)
- [引用](#Citation)

## LEVIR-MCI データセット 
- LEVIR_MCI データセットをダウンロード: [LEVIR-MCI](https://huggingface.co/datasets/lcybuaa/LEVIR-MCI/tree/main)（**現在利用可能！**）。
- 本データセットは、以前に構築した[LEVIR-CC データセット](https://github.com/Chen-Yang-Liu/RSICC)の拡張版です。2時点の画像および多様な変化検出マスクと記述文を含み、変化検出と変化説明のマルチタスク学習を探求するための重要なデータ基盤を提供します。
    <br>
    <div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/dataset.png" width="800"/>
    </div>
    <br>
## マルチレベル変化解釈モデルのトレーニング
MCIモデルの概要:
<br>
    <div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/MCI_model.png" width="800"/>
    </div>
<br>

### 準備
    
- **環境のインストール**:
    <details open>
    
    **ステップ1**: `Multi_change_env` という名前の仮想環境を作成し、アクティベートします。
    ```python
    conda create -n Multi_change_env python=3.9
    conda activate Multi_change_env
    ```
    
    **ステップ2**: リポジトリをダウンロードまたはクローンします。
    ```python
    git clone https://github.com/Chen-Yang-Liu/Change-Agent.git
    cd ./Change-Agent/Multi_change
    ```
    
    **ステップ3**：依存関係をインストールします。
    ```python
    pip install -r requirements.txt
    ```
    </details>

- **データセットのダウンロード**:
  <details open>
      
  リンク: [LEVIR-MCI](https://huggingface.co/datasets/lcybuaa/LEVIR-MCI/tree/main)。LEVIR-MCIのデータ構造は以下のように構成されています:

    ```
    ├─/DATA_PATH_ROOT/Levir-MCI-dataset/
            ├─LevirCCcaptions.json
            ├─images
                 ├─train
                 │  ├─A
                 │  ├─B
                 │  ├─label
                 ├─val
                 │  ├─A
                 │  ├─B
                 │  ├─label
                 ├─test
                 │  ├─A
                 │  ├─B
                 │  ├─label
    ```
    フォルダ``A``には前期の画像が含まれ、フォルダ``B``には後期の画像が含まれ、フォルダ``label``には変化検出マスクが含まれています。
    </details>

- **LEVIR-MCIの各画像ペアの説明のテキストファイルを抽出する**:

    ```
    python preprocess_data.py
    ```
    その後、`./data/LEVIR_MCI/` にいくつか生成されたファイルが見つかります。

### 訓練
上記のデータ準備を確実に行ってください。その後、以下のように訓練を開始します：
```python
python train.py --train_goal 2 --data_folder /DATA_PATH_ROOT/Levir-MCI-dataset/images --savepath ./models_ckpt/
```

### 評価
```python
python test.py --data_folder /DATA_PATH_ROOT/Levir-MCI-dataset/images --checkpoint {checkpoint_PATH}
```
モデルを5回トレーニングして平均スコアを取得することを推奨します。

### 推論
次のように推論を実行して開始します：
```python
python predict.py --imgA_path {imgA_path} --imgB_path {imgA_path} --mask_save_path ./CDmask.png
```
``predict.py``の``Change_Perception.define_args()``の``--checkpoint``を変更できます。  
そうすれば、自分のモデルを使用できます。もちろん、事前学習済みモデル``MCI_model.pth``もこちらからダウンロードできます：[[Hugging face](https://huggingface.co/lcybuaa/Change-Agent/tree/main)]。その後、`./models_ckpt/`に配置してください。  

## Change-Agentの構成  
<br>  
<div align="center">  
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/overview_agent.png" width="800"/>  
</div>  

- **エージェントのインストール**:

    ```python
    cd ./Change-Agent/lagent-main
    pip install -e .[all]
    ```
- **エージェントの実行**：

    ``Multi_change`` フォルダに移動します：
    ```python
    cd ./Change-Agent/Multi_change
    ```
    (1) エージェントCLIデモの実行:
    ```bash
    # You need to install streamlit first
    # pip install streamlit
    python try_chat.py
    ```
        
    (2) エージェントWebデモを実行：
    ```bash
    # You need to install streamlit first
    # pip install streamlit
    streamlit run react_web_demo.py
    ```
    <br>
    <div align="center">
          <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/web.png"/>
    </div>

## 引用
この論文が研究に役立った場合は、以下を引用してください：
```
@ARTICLE{Liu_Change_Agent,
  author={Liu, Chenyang and Chen, Keyan and Zhang, Haotian and Qi, Zipeng and Zou, Zhengxia and Shi, Zhenwei},
  journal={IEEE Transactions on Geoscience and Remote Sensing}, 
  title={Change-Agent: Toward Interactive Comprehensive Remote Sensing Change Interpretation and Analysis}, 
  year={2024},
  volume={},
  number={},
  pages={1-1},
  keywords={Remote sensing;Feature extraction;Semantics;Transformers;Roads;Earth;Task analysis;Interactive Change-Agent;change captioning;change detection;multi-task learning;large language model},
  doi={10.1109/TGRS.2024.3425815}}

```

## 謝辞
以下のリポジトリに感謝します：

[RSICCformer](https://github.com/Chen-Yang-Liu/RSICC); [Chg2Cap](https://github.com/ShizhenChang/Chg2Cap); [lagent](https://github.com/InternLM/lagent)

## ライセンス
本リポジトリは[MITライセンス](https://github.com/Chen-Yang-Liu/Change-Agent/blob/main/LICENSE.txt)の下で配布されています。コードは学術目的のみで使用可能です。

## お問い合わせ
ご不明点があれば❓、お気軽にご連絡ください 👬


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---