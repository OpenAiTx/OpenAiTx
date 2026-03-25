# Open-PAV

OpenPAV（Open Production Automated Vehicle）は、生産型自動運転車（PAV）の**データ収集、行動モデリング、および性能評価**を支援するために設計されたオープンプラットフォームです。多様なデータセットとキャリブレーション済み車両モデルを統合し、PAVの動態やその影響を研究する研究者や開発者にとって不可欠なツールとなっています。本プロジェクトは研究コミュニティからの貢献を促進し、シミュレーションツールとシームレスに統合可能なモデルパラメータを提供します。詳細は[OpenPAVウェブサイト](https://openpav.github.io/OpenPAV)をご覧ください。

![Framework](https://raw.githubusercontent.com/OpenPAV/OpenPAV/main/./docs/images/Framework.png)

## データソースと貢献者

### オリジナルデータソース：

現在、データセットは7つの提供元から14のオープンソースデータセットを検証しており、それぞれが様々な運転条件やシナリオにおける自動運転車の行動に関する独自の洞察を提供しています。以下の通りです：

- **Argoverse 2 モーション予測データセット**。テキサス州オースティン、ミシガン州デトロイト、フロリダ州マイアミ、ペンシルベニア州ピッツバーグ、カリフォルニア州パロアルト、ワシントンD.C.でArgo AIとカーネギーメロン大学、ジョージア工科大学の研究者により収集。入手先 - [Argoverse 2 Motion Forecasting Dataset](https://www.argoverse.org/av2.html)。
- **CATSオープンデータセット**。フロリダ州タンパおよびウィスコンシン州マディソンでCATSラボが収集した3つのデータセット。入手先 - [CATS Lab](https://github.com/CATS-Lab)。
- **Central Ohio ACCデータセット**。オハイオ州でUCLAモビリティラボと交通研究センターが収集した2つのデータセット。入手先 - [Central Ohio向けADAS搭載単一車両データ](https://catalog.data.gov/dataset/advanced-driver-assistance-system-adas-equipped-single-vehicle-data-for-central-ohio)。
- **MircoSimACCデータセット**。フロリダ州のデルレイビーチ、ロクサハッチー、ボカラトン、パークランドの4都市でフロリダ大西洋大学の研究グループにより収集。入手先 - [microSIM-ACC](https://github.com/microSIM-ACC)。
- **OpenACCデータベース**。イタリア、スウェーデン、ハンガリーで欧州委員会の合同研究センターが収集した4つのデータセット。入手先 - [data.europa.eu](https://data.europa.eu/data/datasets/9702c950-c80f-4d2f-982f-44d06ea0009f?locale=en)。
- **バンダービルトACCデータセット**。テネシー州ナッシュビルでバンダービルト大学の研究グループにより収集。入手先 - [Adaptive Cruise Control Dataset](https://acc-dataset.github.io/)。
- **Waymoオープンデータセット**。カリフォルニア州サンフランシスコ、マウンテンビュー、ロサンゼルス、アリゾナ州フェニックス、ミシガン州デトロイト、ワシントン州シアトルの6都市でWaymoが収集した2つのデータセット。入手先 - [Waymo Motion Dataset](https://waymo.com/open/data/motion/)および[Waymoオープンデータセットから処理された車両軌跡データ](https://data.mendeley.com/datasets/wfn2c3437n/2)。

<img src="https://raw.githubusercontent.com/OpenPAV/OpenPAV/main/./docs/images/Dataset.png" alt="Major Components" width="600">

### 処理済みデータソース：

上記のデータセットからデータを整理し、すべてのデータが標準化されたフォーマットで表現される統一軌跡データセットULTra-AVを作成しました。入手先 - [自動運転車向け統一縦軌跡データセット](https://www.nature.com/articles/s41597-024-03795-y)および[ULTra-AV](https://github.com/CATS-Lab/Filed-Experiment-Data-ULTra-AV)。

## 新着情報

- **2026年3月：** 新インターフェースをリリースしました。
- **2024年11月：** プロジェクト初期起動、インストールおよびユーザーガイドを公開。

## 主要コンポーネント

Open-PAVは以下のコンポーネントで構成されています：

- **データ処理：** 生の自動運転車データ（LiDAR、画像、動画、軌跡）を入力として受け取り、同種のデータを統一フォーマットに変換し、予備的なデータクリーニングを行います。
- **行動モデリング：** 処理済みの自動運転車データを用いて、車両運動学モデルをキャリブレーションし、シミュレーション用にエクスポートします。ユーザーは自身の自動運転ソフトウェアスタックを直接入力し、このモジュール内で開発した自動運転システムをテストすることも可能です。
- **加速評価：** 指定された自動運転車モデルに特化した安全性重視の運転シナリオを生成し、その安全性能を評価するためのモジュールです。


## 貢献者

### 貢献グループ

[CATS Lab](https://catslab.engr.wisc.edu/)（PI: [Xiaopeng Li](https://catslab.engr.wisc.edu/staff/xiaopengli/)）

[CAT Lab](http://www.connectedandautonomoustransport.com/dr-zhengs-research.html)（PI: [Zuduo Zheng](https://civil.uq.edu.au/profile/857/zuduo-zheng)）

[SHINE Lab](https://sites.google.com/site/danjuechen/)（PI: Danjue Chen）

NextGen-ITS Lab（PI: David Kan）

### 技術的貢献者：

- [Hang Zhou](https://catslab.engr.wisc.edu/staff/zhou-hang/)、[Ke Ma](https://markmaaaaa.github.io/KeMa.github.io/)、Keke Long、Chengyuan Ma。

### 関連出版物：

- Zhou, H., Ma, K., Liang, S., Li, X., and Qu, X. (2024). *A unified longitudinal trajectory dataset for automated vehicle*. *Scientific Data*, 11, 1123.

### 謝辞：

本プロジェクトは、国立科学財団（NSF）による「[NSF CPS: Small: NSF-DST: Turning “Tragedy of the Commons (ToC)” into “Emergent Cooperative Behavior (ECB)” for Automated Vehicles at Intersections with Meta-Learning](https://www.nsf.gov/awardsearch/show-award?AWD_ID=2343167)」（番号 2343167）の一部支援を受けています。また、[IEEE Intelligent Transportation Systems Society (ITSS) Emerging Transportation Technology Testing (ET3) Technical Committee](https://ieee-itss.org/chapters-committees/emerging-transportation-technology-testing) の支援にも感謝いたします。

本作業を可能にしたすべてのデータセット提供者および貢献者の皆様にも心より感謝申し上げます。

## ライセンス

Open-PAV は [MIT ライセンス](LICENSE) の下で公開されています。詳細は LICENSE ファイルをご覧ください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-25

---