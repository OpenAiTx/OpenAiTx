# [arXiv] On-device Sora: モバイルデバイス向け拡散ベースのテキストから動画生成の実現

* コードは[Open-Sora](https://github.com/hpcaitech/Open-Sora)の実装を基にしています

**論文**: https://arxiv.org/abs/2502.04363

[arXiv] On-device Sora: モバイルデバイス向け拡散ベースのテキストから動画生成の実装コード。
参照ベースコード ->
Open-Sora : すべての人のための効率的な動画制作の民主化

## はじめに

このリポジトリは、*On-device Sora*のコードを提供しており、これは*On-device Sora: Enabling Diffusion-Based Text-to-Video Generation for Mobile Devices*という論文のオープンソース実装です。 


### On-Device Sora
*On-device Sora*は、Linear Proportional Leap (LPL)、Temporal Dimension Token Merging (TDTM)、およびConcurrent Inference with Dynamic Loading (CI-DL)を適用し、iPhone 15 Proで効率的な動画生成を可能にしています。

![On-Device_Sora](https://raw.githubusercontent.com/eai-lab/On-device-Sora/main/./Figures/overview.jpg)

### Open-Sora

[Open-Sora](https://github.com/hpcaitech/Open-Sora)は、On-Device Soraのベースラインモデルであり、テキスト入力に基づいて動画を生成可能なT2V拡散モデルのオープンソースプロジェクトです。

## 各モデルをOn-device Sora用のMLPackageに変換する方法

## パッケージ依存関係

### 依存関係
```
cd Device_conversion

conda create -n convert python=3.10

conda activate convert

pip install -r requirements/requirements-convert.txt

pip install -v .
```

## 変換

### T5 変換
```
cd t5
python3 export-t5.py
```

### STDiT カバリング
```
cd stdit3
python3 export-stdit3.py
```

### VAE変換
`export-vae-spatial.py`を実行すると、`Fatal Python error: PyEval_SaveThread`というエラーが発生することがあります。
このエラーを解決するには、VAEの各部分に対して1つのコードブロックのみを実行してください。残りはコメントアウトしてください。

```
cd vae

# for vae's temporal part
python3 export-vae-temporal.py

# for vae's spatial part
python3 export-vae-spatial.py
```

## 使い方

### 必須
* xcode用のMacデバイス
* アプリをビルドして起動するためのAppleアカウント
* iPhone: iPhone 15 pro以上
* iOSバージョン: 18以上
* すべてのMLPackage（T5、STDiT、VAE）

### 変換済みMLPackageのダウンロード（各モデルをMLPackageに変換したくない場合）

以下のリンクから変換済みモデルをダウンロードして使用できます。[[ダウンロード](https://drive.google.com/drive/folders/1L6pVi3KmyLygR_pvKofRL-21adKsEb4p?usp=sharing)]

### アプリの実行
* On-device/On-device-Sora.xcodeprojをクリックしてxcodeプロジェクトを実装
* TARGETS/Signing&Capabilitiesでチームを変更（None -> あなたのAppleアカウント）
* アプリを起動
### 実例のアーティファクト
![On-device-Sora-Example1](https://raw.githubusercontent.com/eai-lab/On-device-Sora/main/./Figures/On-device-Sora-Example1.gif)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-18

---