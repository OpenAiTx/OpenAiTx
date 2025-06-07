[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: 化合物合成容易性を予測するディープラーニング駆動型ツール

人工知能技術の継続的な発展に伴い、ますます多くの深層生成モデルが分子の生成に利用されています。しかし、生成モデルによって新たに生成された多くの分子は、合成容易性の観点で大きな課題に直面することが多いです。

DeepSAは化合物の合成容易性を予測するために提案されたものであり、合成が困難な分子を識別する上で、はるかに高い早期エンリッチメント率を持っています。これにより、ユーザーは合成コストの低い分子を選択でき、創薬および開発の時間を短縮することができます。DeepSAはウェブサーバー（https://bailab.siais.shanghaitech.edu.cn/deepsa）でも利用可能です。<br/>

## 必要条件
依存関係は以下のコマンドでインストールできます：
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# GPUバージョンの場合
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### News 🔔 

* 2024-12、[AutoGluonがPython 3.8のサポートを2024年10月より停止](https://github.com/autogluon/autogluon/pull/4512)したため、DeepSAをPython 3.12にアップデートし、最新のAutoGluonに対応するように学習・推論スクリプトを更新しました。DeepSAへのご関心、誠にありがとうございます！

* 2023-7、DeepSA_v1.0をリリースしました。Issueでのフィードバックをお待ちしています！

## データ 
拡張されたトレーニングおよびテストデータセットは、https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing から簡単にダウンロードできます。

## 研究者向けの使用方法
独自のモデルをトレーニングしたい場合は、コマンドラインから以下のように実行できます。

実行方法：
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
提案されているモデルを使用したい場合は、

実行方法：
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## オンラインサーバー

事前学習済みモデルを専用サーバー（https://bailab.siais.shanghaitech.edu.cn/deepsa）にデプロイしており、バイオメディカル分野の研究者が研究活動でDeepSAを簡単に利用できるようになっています。

ユーザーは自身のSMILESまたはcsvファイルをサーバーにアップロードすると、すぐに予測結果を得ることができます。

## <span id="citelink">引用</span>
本リポジトリが研究に役立った場合、ぜひ以下の論文を引用してください：

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## お問い合わせ
ご質問がありましたら、Shihang Wang（Email: wangshh12022@shanghaitech.edu.cn）またはLin Wang（Email: wanglin3@shanghaitech.edu.cn）までご連絡ください。

Pull Requestも大歓迎です！

## 謝辞
上海科技大学のHPCプラットフォームのご支援に感謝いたします。<br/>
本研究にご注目いただき、誠にありがとうございます。

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---