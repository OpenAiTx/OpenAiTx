<translate-content># FormFactory: マルチモーダルフォーム記入エージェントのためのインタラクティブベンチマークスイート

![](https://raw.githubusercontent.com/formfactory-ai/formfactory/main/img/fig1v1_page_1.png)

<p align="center">
  <a href="https://arxiv.org/abs/2506.01520"><img src="https://img.shields.io/badge/arXiv-2506.01520-B31B1B.svg" alt="arXiv"></a>
  &nbsp;
  <a href="https://formfactory-ai.github.io/#demo-video" target="_blank"><img src="https://img.shields.io/badge/Demo-Video-orange.svg" alt="Video Demo"></a>
  &nbsp;
  <a href="https://formfactory-ai.github.io" target="_blank"><img src="https://img.shields.io/badge/Project_Page-Website-blue.svg" alt="Project Page"></a>
</p>

## 📖 概要
オンラインフォーム記入は、最も一般的でありながら最も手間のかかる日常作業の一つです。従来の自動化ツールは通常ルールベースのスクリプトであり、複雑かつ変化し続けるウェブレイアウトには対応が困難です。近年のマルチモーダル大規模言語モデル（**MLLMs**）の登場により、「ワンクリック」フォーム完了が可能な視覚言語エージェントの研究が始まっています。しかし、現行モデルはレイアウト理解やフィールドと値の整合性においてまだ不十分です。

**FormFactory** は、このギャップを埋めるために、高忠実度のベンチマークおよび実験プラットフォームをマルチモーダルフォーム記入エージェントに提供します。本プロジェクトは以下で構成されています：

1. 🌐 **ウェブフロントエンド** – 8つのドメイン（学術、ビジネス、金融、医療など）にわたる実世界のシナリオからの40以上の高忠実HTMLフォーム。
2. 🗄 **データセット** –
   • `data1/` は各フォームのJSON形式の**正解データ**（真のフィールド値）を含みます。
   • `data2/` は追加の文脈やプロンプトとして利用可能な**テキスト資料**を格納します。
   • `labeled-images/` はページの**スクリーンショット**と対応する**バウンディングボックス注釈**（フォルダA–Hごとに整理）を提供します。
3. ⚙️ **バックエンドサービス** – ページのレンダリング、送信の受け取り、結果の自動保存を行う軽量Flask API。
4. 📊 **評価スクリプト** – フィールドレベルおよびフォームレベルの正確性、レイアウト推論メトリクスなどを計算するユーティリティ。

---

## 🚀 クイックスタート

### 1  前提条件

- Python ≥ 3.8
- Flask == 2.3.*
- 追加の依存関係は以下でインストールしてください：</translate-content>
  ```bash
  pip install -r requirements.txt
  ```
### 2  リポジトリのクローン

```bash
git clone https://github.com/formfactory-ai/formfactory.git
cd formfactory
```
### 3  デモサーバーの起動

```bash
python app.py        # default: http://127.0.0.1:5000/
```
ブラウザでURLを開き、ダッシュボードから任意のフォームを選択して操作を開始してください。

---

## 🗂 ディレクトリ構成</translate-content>
```text
formfactory/
├─ app.py                # Flask back-end entry point
├─ templates/            # 40+ HTML form templates
├─ static/               # Stylesheets & front-end assets
├─ data/                 # Dataset root
│  ├─ data1/             # Gold answers in JSON format
│  ├─ data2/             # Supporting textual materials
│  └─ labeled-images/    # Screenshots + bbox annotations (A–H)
├─ submission/           # Auto-generated user/model submissions
└─ README.md             # This document
```
---

## ✨ 主な特徴
- **マルチドメイン対応** – 学術、ビジネス、芸術、技術、金融、医療、法律、製造業。
- **高忠実度ページ** – 視覚的理解とフィールドのローカライズをテストするリアルなレイアウト。
- **動的フィールド** – グループ、繰り返しセクション、カスケード依存など。
- **インタラクティブ評価** – サーバーを起動してモデルの挙動をリアルタイムで観察；結果は自動保存。
- **拡張が簡単** – HTMLテンプレートとJSON回答ファイルを提供するだけで新しいフォームを追加可能。

---

## 🧪 評価

![](https://raw.githubusercontent.com/formfactory-ai/formfactory/main/img/systemoverview_page_1.png)


```bash
# 📁 Navigate to evaluation directory
cd eval

# 🔄 Process data with model API
python batch_processor.py A11 json --filename Art_Exhibition_Submission_Form

# 📊 Evaluate model performance  
python evaluator.py --batch

# 📋 View detailed evaluation report
cat evaluation_results/batch_evaluation_*_report.txt
```
---

> [!NOTE]
>
> `model_call.py`でAPIコールを完成させ、`evaluator.py`で評価をカスタマイズしてください

## 📄 ライセンス
本プロジェクトは**MITライセンス**のもとで公開されています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

---

## 🔗 引用
研究でFormFactoryを使用する場合は、以下を引用してください：

```bibtex
@misc{li2025formfactoryinteractivebenchmarkingsuite,
  title        = {FormFactory: An Interactive Benchmarking Suite for Multimodal Form-Filling Agents},
  author       = {Bobo Li and Yuheng Wang and Hao Fei and Juncheng Li and Wei Ji and Mong-Li Lee and Wynne Hsu},
  year         = {2025},
  eprint       = {2506.01520},
  archivePrefix= {arXiv},
  primaryClass = {cs.CL},
  url          = {https://arxiv.org/abs/2506.01520}
}
```
楽しい研究を、そしてマルチモーダルフォーム入力エージェントを共に推進していきましょう！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---