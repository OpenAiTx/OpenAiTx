# AudioStory: 大規模言語モデルを用いた長編ナラティブ音声生成

**[郭昱鑫<sup>1,2</sup>](https://scholar.google.com/citations?user=x_0spxgAAAAJ&hl=en),  
[王腾<sup>2,&#9993;</sup>](http://ttengwang.com/),  
[葛雨颖<sup>2</sup>](https://geyuying.github.io/),  
[马世杰<sup>1,2</sup>](https://mashijie1028.github.io/),  
[葛逸潇<sup>2</sup>](https://geyixiao.com/),  
[邹威<sup>1</sup>](https://people.ucas.ac.cn/~zouwei),  
[单颖<sup>2</sup>](https://scholar.google.com/citations?user=4oXBp9UAAAAJ&hl=en)**  
<br>  
<sup>1</sup>中国科学院自动化研究所  
<sup>2</sup>腾讯PCG ARC实验室  
<br>  


## 📖 リリース

[2025/8/28] 🔥🔥 推論コードを公開しました！

[2025/8/28] 🔥🔥 デモ動画を公開しました！



## 🔎 はじめに

![audiostory](https://raw.githubusercontent.com/TencentARC/AudioStory/main/audiostory.png)

✨ **TL; DR: 私たちは、映像の吹き替え、音声の継続、長編ナラティブ音声合成に対応可能な、統一された理解–生成フレームワークに基づく長編ナラティブ音声生成モデルを提案します。**

近年のテキストから音声への生成（TTA）は短い音声クリップの合成に優れている一方で、時間的整合性や構成的推論を要する長編ナラティブ音声の生成には課題があります。これに対処するため、我々は大規模言語モデル（LLM）とTTAシステムを統合し、構造化された長編音声ナラティブを生成する統一フレームワークAudioStoryを提案します。AudioStoryは高い指示理解・推論生成能力を有し、LLMを用いて複雑なナラティブクエリを時系列順のサブタスクに分解し、文脈的手がかりを付与することで、一貫したシーン遷移と感情トーンの整合性を実現します。AudioStoryの特徴は以下の二点です：

1) 分離型ブリッジ機構：AudioStoryはLLMとディフューザーの協調を二つの専門的コンポーネントに分解し、イベント内意味整合のためのブリッジクエリと、イベント間の一貫性維持のための整合性クエリを設けています。  
2) エンドツーエンド学習：指示理解と音声生成を単一のエンドツーエンドフレームワークで統合することで、モジュール型の学習パイプラインを不要とし、コンポーネント間の相乗効果を高めています。  
　さらに、多様なドメイン（アニメ風サウンドスケープや自然音ナラティブ等）を含むベンチマークAudioStory-10Kを構築しました。

豊富な実験により、AudioStoryは単一音声生成およびナラティブ音声生成の両面で優れており、従来のTTAベースラインを指示遵守能力と音質の両面で上回ることを示しています。




## ⭐ デモ

### 1. ビデオ吹き替え（トムとジェリー風）
> 吹き替えは、ビデオから抽出した視覚的なキャプションを用いて、トムとジェリーで訓練されたAudioStoryを使用して実現されています。

<table class="center">
  <td><video src="https://github.com/user-attachments/assets/f06b5999-6649-44d3-af38-63fdcecd833c"></video></td>
  <td><video src="https://github.com/user-attachments/assets/17727c2a-bfea-4252-9aa8-48fc9ac33500"></video></td>
  <td><video src="https://github.com/user-attachments/assets/09589d82-62c9-47a6-838a-5a62319f35e2"></video></td>
  <tr>
</table >


### 2. クロスドメインビデオ吹き替え（トムとジェリー風）

<table class="center">
    <td><video src="https://github.com/user-attachments/assets/e62d0c09-cdf0-4e51-b550-0a2c23f8d68d"></video></td>
    <td><video src="https://github.com/user-attachments/assets/736d22ca-6636-4ef0-99f3-768e4dfb112a"></video></td>
    <td><video src="https://github.com/user-attachments/assets/f2f7c94c-7f72-4cc0-8edc-290910980b04"></video></td>
  <tr>
  <td><video src="https://github.com/user-attachments/assets/d3e58dd4-31ae-4e32-aef1-03f1e649cb0c"></video></td>
  <td><video src="https://github.com/user-attachments/assets/4f68199f-e48a-4be7-b6dc-1acb8d377a6e"></video></td>
  <td><video src="https://github.com/user-attachments/assets/062236c3-1d26-4622-b843-cc0cd0c58053"></video></td>
	<tr>
  <td><video src="https://github.com/user-attachments/assets/8931f428-dd4d-430f-9927-068f2912dd36"></video></td>
  <td><video src="https://github.com/user-attachments/assets/ab7e46d5-f42c-472e-b66e-df786b658210"></video></td>      
  <td><video src="https://github.com/user-attachments/assets/9a0998ad-b5a4-42ac-bdaf-ceaf796fc586"></video></td>
  <tr>
</table >



### 3. テキストから長い音声へ（自然な音）

<table class="center">
  <td style="text-align:center;" width="480">指示:「ジェイク・シマブクロがスタジオで複雑なウクレレ曲を演奏し、拍手を受け、そのキャリアについてインタビューで語る様子を完全に表現した包括的な音声を作成してください。合計時間は49.9秒です。」</td>
  <td><video src="https://github.com/user-attachments/assets/461e8a34-4217-454e-87b3-e4285f36ec43"></video></td>
	<tr>
  <td style="text-align:center;" width="480">指示:「消防車がサイレンを鳴らしながら消防署を出発し、緊急出動を知らせて走り去る様子を完全に表現した包括的な音声を作成してください。合計時間は35.1秒です。」</td>
  <td><video src="https://github.com/user-attachments/assets/aac0243f-5d12-480e-9850-a7f6720e4f9c"></video></td>
	<tr>
     <td style="text-align:center;" width="480">指示：「入力された音声を理解し、その後の出来事を推測して、コーチが選手にバスケットボールのレッスンを行う続きの音声を生成してください。合計の長さは36.6秒です。」</td>    
    <td><video src="https://github.com/user-attachments/assets/c4ed306a-651e-43d6-aeea-ee159542418a"></video></td>
	<tr>
</table >




## 🔎 方法

![audiostory_framework](https://raw.githubusercontent.com/TencentARC/AudioStory/main/audiostory_framework.png)

効果的な指示追従型音声生成を実現するためには、入力された指示や音声ストリームを理解し、関連する音声のサブイベントを推論する能力が不可欠です。この目的のために、AudioStoryは統一された理解-生成フレームワーク（図）を採用しています。具体的には、テキスト指示や音声入力を与えられると、LLMはそれを解析し、文脈付きの構造化された音声サブイベントに分解します。推論されたサブイベントに基づいて、LLMは**交互推論生成**を行い、各音声クリップに対して順次キャプション、セマンティックトークン、残差トークンを生成します。これら二種類のトークンは融合され、DiTに渡され、LLMと音声ジェネレーターを効果的に橋渡しします。段階的な訓練を通じて、AudioStoryは強力な指示理解力と高品質な音声生成の両方を最終的に達成します。



## 🔩 インストール

### 依存関係

* Python >= 3.10（[Anaconda](https://www.anaconda.com/download/#linux)の使用を推奨）
* [PyTorch >=2.1.0](https://pytorch.org/)
* NVIDIA GPU + [CUDA](https://developer.nvidia.com/cuda-downloads)

### インストール

```
git clone https://github.com/TencentARC/AudioStory.git
cd AudioStory
conda create -n audiostory python=3.10 -y
conda activate audiostory
bash install_audiostory.sh
```



## 📊 Evaluation

### inference

```
python evaluate/inference.py --model_path /path/to/ckpt --guidance 4.0 --save_folder_name audiostory --total_duration 50
```
## 🔋 謝辞

連続デノイザーのコードベースを構築する際に、[SEED-X](https://github.com/AILab-CVC/SEED-X) と [TangoFlux](https://github.com/declare-lab/TangoFlux) を参照しました。素晴らしいプロジェクトに感謝します。



## 📆 TO DO

- [ ] Gradioデモのリリース。
- [ ] AudioStoryのチェックポイントのリリース。
- [ ] 3段階すべてのトレーニングコードのリリース。



## 📜 ライセンス

本リポジトリは [Apache 2 ライセンス](https://github.com/mashijie1028/Gen4Rep/blob/main/LICENSE) の下で提供されています。



## 📚 BibTeX




```
@misc{guo2025audiostory,
      title={AudioStory: Generating Long-Form Narrative Audio with Large Language Models}, 
      author={Yuxin Guo and Teng Wang and Yuying Ge and Shijie Ma and Yixiao Ge and Wei Zou and Ying Shan},
      year={2025},
      eprint={2508.20088},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2508.20088}, 
}
```
## 📧 お問い合わせ

ご質問がございましたら、お気軽にご連絡ください: guoyuxin2021@ia.ac.cn

ご意見交換や共同研究のご提案も歓迎いたします。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---