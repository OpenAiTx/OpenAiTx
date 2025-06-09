# StyTr^2 : トランスフォーマーによる画像スタイル変換（CVPR2022）
*著者: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, Xingjia Pan, Weiming Dong, Chongyang Ma, Changsheng Xu*

本論文は、トランスフォーマーモデルに基づくバイアスのない画像スタイル変換を実現することを提案します。最先端の手法と比較して、スタイライズ効果を向上させることができます。
このリポジトリは [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576) の公式実装です。

## 結果の提示
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
いくつかの最先端アルゴリズムと比較して、我々の手法はコンテンツリークを回避する強力な能力を持ち、より優れた特徴表現能力を有します。<br>

## フレームワーク
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
我々のStyTr^2フレームワークの全体パイプラインです。コンテンツ画像とスタイル画像をパッチに分割し、線形射影によって画像系列を取得します。その後、CAPEが追加されたコンテンツ系列はコンテンツトランスフォーマーエンコーダに入力され、スタイル系列はスタイルトランスフォーマーエンコーダに入力されます。2つのトランスフォーマーエンコーダに続いて、マルチレイヤートランスフォーマーデコーダを用いて、スタイル系列に基づきコンテンツ系列をスタイライズします。最後に、プログレッシブアップサンプリングデコーダを使って高解像度のスタイライズ画像を得ます。

## 実験
### 必要環境
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### テスト
学習済みモデル: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
これらをダウンロードし、./experiments/ フォルダに配置してください <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### 学習
スタイルデータセットは [WIKIART](https://www.wikiart.org/) より収集したWikiArtです。<br>
コンテンツデータセットはCOCO2014です。<br>
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### 参考文献
本研究があなたの研究に役立つ場合、以下のBibTeXエントリを使用して論文を引用してください。ありがとうございます ^ . ^。論文リンク [pdf](https://arxiv.org/abs/2105.14576)<br> 
```
@inproceedings{deng2021stytr2,
      title={StyTr^2: Image Style Transfer with Transformers}, 
      author={Yingying Deng and Fan Tang and Weiming Dong and Chongyang Ma and Xingjia Pan and Lei Wang and Changsheng Xu},
      booktitle={IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
      year={2022},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---