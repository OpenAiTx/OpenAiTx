<div align="center">

# 直接微分可能なメッシュ訓練のための2D三角形スプラッティング

[Arxiv][1] | [プロジェクトページ][4]

盛 凱峰*, 周 正*, 彭 英良, 王 千偉 (*共同第一著者)

Amap, アリババグループ

</div>

## - プロジェクト概要

[2DTS][1]（直接微分可能なメッシュ訓練のための2D三角形スプラッティング）の公式実装

我々は、[3DGS][2]（3Dガウススプラッティング）から適応された微分可能な3D幾何表現である2DTSの完全な訓練パイプラインを提供します。これは、プリミティブをガウスから三角形に置き換えつつ、モデルの完全な微分可能性を保持します。
提案手法はエンドツーエンドの訓練パイプラインを通じて、高い視覚的忠実度を持つ三角形メッシュを生成可能です。

![demo_image](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./assets/demo_image.png)

我々の手法は、6000枚以上の画像を含むMatrixCityのような大規模データセットに適用可能です。こうしたデータセットは既存のメッシュ再構築手法にとって困難ですが、我々の手法は効率的に処理できます。
再構築されたメッシュは、Blenderのような最新のゲームエンジンで直接使用でき、リライティングや影のレンダリング、その他高度なレンダリング効果に利用可能です。以下の画像はMatrixCityデータセットから再構築されたメッシュのリライティング効果の例です：

![relighting_image](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./assets/relighting_image.png)

## - 要約

3Dガウスプリミティブを用いた微分可能レンダリングは、多視点画像から高忠実度3Dシーンを再構築する強力な手法として登場しました。
NeRFベース手法に比べて改善を提供しますが、この表現はメッシュベースのモデルに比べてレンダリング速度やリライティング、影のレンダリングといった高度なレンダリング効果において課題があります。
本論文では、3Dガウスプリミティブを2D三角形フェイスレットに置き換えた新しい手法2D Triangle Splatting（2DTS）を提案します。
この表現は連続的な体積モデリングの利点を保持しつつ、自然に離散的なメッシュ状構造を形成します。
三角形プリミティブにコンパクトネスパラメータを組み込むことで、フォトリアリスティックなメッシュの直接訓練を可能にします。
実験結果は、我々の三角形ベース手法がバニラバージョン（コンパクトネス調整なし）でも、最先端のガウスベース手法よりも高い忠実度を達成することを示しています。
さらに、我々のアプローチは既存のメッシュ再構築手法に比べて優れた視覚品質の再構築メッシュを生成します。

## - インストール

1. CUDA 12.4以上をインストール（環境変数`CUDA_HOME`をCUDAインストールパスに設定することを忘れずに）；
2. リポジトリをクローン：`git clone https://github.com/GaodeRender/diff_recon.git; cd diff_recon`；
3. Python 3.12で新しいconda環境を作成：`conda create -n 2dts python=3.12`；
   環境をアクティベート：`conda activate 2dts`；
4. 依存関係をインストール：`pip install -r requirements.txt --no-cache-dir`；
5. プロジェクトのルートディレクトリで`pip install . --no-cache-dir`を実行；

## - 使い方
### 訓練
以下のコマンドを実行して、Mip-NeRF 360、NerfSynthetic、Tanks and Temples、DeepBlending、またはMatrixCityデータセットのいずれかで2DTSモデルを訓練します：

```bash
python run_experiments.py --type {experiment_type} --dataset_path /path/to/dataset --num_workers 0
```
`experiment_type` は `MipNerf360`、`NerfSynthetic`、`NerfSynthetic_mesh`、`TanksAndBlending` または `MatrixCity_mesh` のいずれかです。

スクリプトは事前にデータセットをダウンロードする必要があり、データセットのパスはデータセットのルートディレクトリを指す必要があります。  
例えば、NerfSynthetic データセットでメッシュモデルをトレーニングしたい場合、データセットが `./data/nerf_synthetic` に保存されているとすると、次のコマンドを実行できます。
```bash
python run_experiments.py --type NerfSynthetic_mesh --dataset_path ./data/nerf_synthetic --num_workers 0
```
### ログ
トレーニングログは `./outputs` ディレクトリに保存されます。トレーニングプロセスの可視化にはTensorBoardを使用できます：

```bash
tensorboard --logdir ./outputs
```
### レンダリング
トレーニングされた三角スプラットやメッシュを視覚化するために、[Viser Viewer][3] に基づくインタラクティブなウェブビューワーを提供しています。
次のコマンドを実行してビューワーを起動できます：

```bash
python viser_viewer.py --config /path/to/config --dataset_path /path/to/dataset --scene {scene_name}
```
例えば、`NerfSynthetic_mesh` 実験を実行し、`ship` シーンを可視化したい場合、データセットが `./data/nerf_synthetic` に保存されているとすると、次のコマンドを実行できます:
```bash
python viser_viewer.py --config config/NerfSynthetic_VanillaTS_mesh.yaml --dataset_path ./data/nerf_synthetic --scene ship
```
Then, open your web browser and navigate to `http://localhost:8080` to view the rendered scene. If you are runing the viewer on a remote server, make sure to set up port forwarding or access the server's IP address directly.

## - 注意事項
私たちは2つの異なるトレーニング構成を提供しています：VanillaTS と VanillaTS_mesh。
- VanillaTS は元の 3DGS 手法をほぼ模倣しており、コンパクトネスパラメータが1.0に設定され、透明かつ拡散する三角形スプラットを生成します（詳細は[2DTS][1]を参照）。
- VanillaTS_mesh はトレーニングプロセスに不透明度の正則化とコンパクトネスの調整を追加し、トレーニング終了時にソリッドな三角メッシュを生成します。三角メッシュは出力ディレクトリに `.glb` ファイルとして保存されます。トレーニングプロセスで **back_culling** が **無効** の場合、**メッシュファイルには各三角形が<span style="color:red">二重に</span>含まれます**。前面と背面の両方のために一度ずつです。

拡散三角形とソリッド三角形の違いは以下の画像で視覚化されています：

![triangle_splatting](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./assets/triangle_splatting.png) 

## - TODO

1. 私たちの手法は密な点群の初期化を前提としています。[3DGS][2]で使用されているような濃密化プロセスは安定性の問題からデフォルトでオフになっています。新しい濃密化および初期化手法が模索されています。この分野での貢献は歓迎します。
2. 現在の実装では各三角形スプラットに対して単一の不透明度および色/光沢パラメータを使用しています。しかし、頂点ごとの色と不透明度をサポートするモデルへの拡張は自然であり、モデルの表現力を高めます。この拡張に取り組んでいます。

## - ライセンス

このリポジトリには**2つの異なるライセンス**の下にコードが含まれています：

- 🟥 **Gaussian Splatting Research License** — 元の [Gaussian Splatting][2] プロジェクトに由来するコンポーネントに適用：
  - `submodules/custom-gaussian-rasterization/`
  - `submodules/simple-knn/`
  - これらのコンポーネントは**非商用の研究利用のみ**ライセンスされています。
  - 詳細は [LICENSE.gausplat.md](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./LICENSE.gausplat.md) を参照してください。

- 🟩 **MIT License** — リポジトリのその他の部分に適用：
  - `src/diff_recon/`
  - `submodules/diff-triangle-rasterization-2D/`, `submodules/diff-triangle-rasterization-3D/` など。
  - 詳細は [LICENSE](./LICENSE) を参照してください。

このリポジトリを使用する際は、両方のライセンスに従うようにしてください。

## - 引用

もし私たちの研究が役立つと感じたら、ぜひ私たちの論文を引用してください：

```bibtex
@misc{sheng20252dtrianglesplattingdirect,
      title={2D Triangle Splatting for Direct Differentiable Mesh Training}, 
      author={Kaifeng Sheng and Zheng Zhou and Yingliang Peng and Qianwei Wang},
      year={2025},
      eprint={2506.18575},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.18575}, 
}
```
<!-- 参考文献 -->
[1]: https://arxiv.org/abs/2506.18575
[2]: https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/
[3]: https://github.com/nerfstudio-project/viser
[4]: https://gaoderender.github.io/triangle-splatting/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---