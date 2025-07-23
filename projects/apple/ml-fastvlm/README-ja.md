
# FastVLM: ビジョン言語モデルのための効率的なビジョンエンコーディング

これは公式リポジトリです
**[FastVLM: ビジョン言語モデルのための効率的なビジョンエンコーディング](https://www.arxiv.org/abs/2412.13303). (CVPR 2025)**

[//]: # (![FastViTHD Performance]&#40;docs/acc_vs_latency_qwen-2.png&#41;)
<p align="center">
<img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/acc_vs_latency_qwen-2.png" alt="Accuracy vs latency figure." width="400"/>
</p>

### ハイライト
* FastViTHDを紹介します。これは、高解像度画像のエンコード時間を大幅に短縮し、より少ないトークンを出力することを目的とした新しいハイブリッドビジョンエンコーダーです。  
* 最小バリアントは、85倍高速な最初のトークン生成時間（TTFT）と3.4倍小さいビジョンエンコーダーでLLaVA-OneVision-0.5Bを上回ります。
* Qwen2-7B LLMを使用した大きなバリアントは、単一の画像エンコーダーで7.9倍高速なTTFTを実現しながら、Cambrian-1-8Bなどの最新の研究成果を凌駕します。
* モバイルデバイス上でのモデル性能を示すデモiOSアプリ。

<table>
<tr>
    <td><img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/fastvlm-counting.gif" alt="FastVLM - Counting"></td>
    <td><img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/fastvlm-handwriting.gif" alt="FastVLM - Handwriting"></td>
    <td><img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/fastvlm-emoji.gif" alt="FastVLM - Emoji"></td>
</tr>
</table>

## はじめに
FastVLMのバリアントをトレーニングするためにLLaVAコードベースを使用しています。自身のバリアントをトレーニングまたはファインチューニングするには、
[LLaVA](https://github.com/haotian-liu/LLaVA)コードベースの指示に従ってください。  
当リポジトリではモデルで推論を行うための手順を提供しています。

### セットアップ

```bash
conda create -n fastvlm python=3.10
conda activate fastvlm
pip install -e .
```
### モデルズー
さまざまな評価の詳細については、当社の[論文](https://www.arxiv.org/abs/2412.13303)をご参照ください。

| モデル        | ステージ |                                            Pytorch チェックポイント（URL）                                             |
|:-------------|:-----:|:---------------------------------------------------------------------------------------------------------------:|
| FastVLM-0.5B |   2   | [fastvlm_0.5b_stage2](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_0.5b_stage2.zip) |
|              |   3   | [fastvlm_0.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_0.5b_stage3.zip) |
| FastVLM-1.5B |   2   | [fastvlm_1.5b_stage2](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_1.5b_stage2.zip) |
|              |   3   | [fastvlm_1.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_1.5b_stage3.zip)  |
| FastVLM-7B   |   2   | [fastvlm_7b_stage2](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_7b_stage2.zip)  |
|              |   3   | [fastvlm_7b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_7b_stage3.zip)  |

すべての事前学習済みチェックポイントをダウンロードするには、以下のコマンドを実行してください（接続状況によっては時間がかかる場合がありますので、待っている間に☕️を用意するのも良いでしょう）。


```bash
bash get_models.sh   # Files will be downloaded to `checkpoints` directory.
```
### 使用例
PyTorchチェックポイントの推論を実行するには、以下の指示に従ってください。

```bash
python predict.py --model-path /path/to/checkpoint-dir \
                  --image-file /path/to/image.png \
                  --prompt "Describe the image."
```
### Apple Siliconでの推論  
Apple Siliconで推論を実行するには、pytorchチェックポイントをApple Siliconで実行可能な形式にエクスポートする必要があります。詳細な手順とコードは[`model_export`](model_export/)サブフォルダにあります。  
詳細はそちらのREADMEをご覧ください。  

便宜上、Apple Silicon互換形式のモデルを3つ提供しています：[fastvlm_0.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_0.5b_stage3_llm.fp16.zip)、  
[fastvlm_1.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_1.5b_stage3_llm.int8.zip)、  
[fastvlm_7b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_7b_stage3_llm.int4.zip)。  
開発者の方は、[`model_export`](model_export/)の指示に従い、適切な量子化レベルで任意のモデルをエクスポートすることを推奨します。  

### Appleデバイスでの推論  
iPhone、iPad、MacなどのAppleデバイスで推論を実行するには、詳細について[`app`](app/)サブフォルダをご覧ください。  

## 引用  
このコードが役に立った場合は、以下の論文を引用してください：



```
@InProceedings{fastvlm2025,
  author = {Pavan Kumar Anasosalu Vasu, Fartash Faghri, Chun-Liang Li, Cem Koc, Nate True, Albert Antony, Gokul Santhanam, James Gabriel, Peter Grasch, Oncel Tuzel, Hadi Pouransari},
  title = {FastVLM: Efficient Vision Encoding for Vision Language Models},
  booktitle = {Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition (CVPR)},
  month = {June},
  year = {2025},
}
```
## 謝辞
当プロジェクトのコードベースは複数のオープンソースの貢献により構築されています。詳細は[ACKNOWLEDGEMENTS](ACKNOWLEDGEMENTS)をご参照ください。

## ライセンス
提供されたコードをご利用になる前にリポジトリの[LICENSE](LICENSE)を、
公開されているモデルについては[LICENSE_MODEL](LICENSE_MODEL)をご確認ください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---