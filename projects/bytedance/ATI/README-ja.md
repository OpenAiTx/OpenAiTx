
# ATI: 制御可能な映像生成のための任意軌道指示

<div align="center">
  
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2505.22944-b31b1b.svg)](https://arxiv.org/pdf/2505.22944)&nbsp;
[![project page](https://img.shields.io/badge/Project_page-ATI-green)](https://anytraj.github.io/)&nbsp;
<a href="https://huggingface.co/bytedance-research/ATI/"><img src="https://img.shields.io/static/v1?label=%F0%9F%A4%97%20Hugging%20Face&message=Model&color=orange"></a>
</div>


> [**ATI: 制御可能な映像生成のための任意軌道指示**](https://anytraj.github.io/)<br>
> [Angtian Wang](https://angtianwang.github.io/), [Haibin Huang](https://brotherhuang.github.io/), Jacob Zhiyuan Fang, [Yiding Yang](https://ihollywhy.github.io/), [Chongyang Ma](http://www.chongyangma.com/)
> <br>インテリジェントクリエイションチーム、ByteDance<br>

[![動画を見る](https://raw.githubusercontent.com/bytedance/ATI/main/assets/thumbnail.jpg)](https://youtu.be/76jjPT0f8Hs)

これはWan2.1 ATI（制御可能な映像生成のための任意軌道指示）のリポジトリです。物体、局所、カメラの動きを映像生成で統合する軌道ベースの動作制御フレームワークです。このリポジトリは[Wan2.1公式実装](https://github.com/Wan-Video/Wan2.1)に基づいています。

元のWan2.1と比較して、以下のファイルを追加しました:
- wan/modules/motion_patch.py          | 軌道指示カーネルモジュール
- wan/utils/motion.py                  | 推論データローダーユーティリティ
- tools/plot_user_inputs.py            | ユーザー入力軌道の可視化ツール
- tools/visualize_trajectory.py        | 生成映像の可視化ツール
- tools/trajectory_editor/             | インタラクティブ軌道エディター
- examples/                            | テスト例
- run_example.sh                       | 簡単起動スクリプト

以下のファイルを修正しました:
- wan/image2video.py                   | 軌道の読み込みと解析ブロック追加  #L256
- wan/configs/__init__.py              | ATIなどの設定
- generate.py                          | yaml形式推論例の読み込みエントリ追加

## コミュニティ作品
### ComfyUI
KijaiによるATI用ComfyUIノードの開発に感謝します:
[https://github.com/kijai/ComfyUI-WanVideoWrapper](https://github.com/kijai/ComfyUI-WanVideoWrapper)

FP8量子化Huggingfaceモデル: [https://huggingface.co/Kijai/WanVideo_comfy/blob/main/Wan2_1-I2V-ATI-14B_fp8_e4m3fn.safetensors](https://huggingface.co/Kijai/WanVideo_comfy/blob/main/Wan2_1-I2V-ATI-14B_fp8_e4m3fn.safetensors)

### ガイドライン
Benjiによるガイドライン: [https://www.youtube.com/watch?v=UM35z2L1XbI](https://www.youtube.com/watch?v=UM35z2L1XbI)

## インストール

ATIは公式Wan 2.1と同じ環境を必要とします。INSTALL.md（Wan2.1）の指示に従ってください。


```
git clone https://github.com/bytedance/ATI.git
cd ATI
```
パッケージをインストールする


```
pip install .
```
まず、Wan2.1の14Bオリジナルモデルをダウンロードする必要があります。


```
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./Wan2.1-I2V-14B-480P
```
次に、当社のhuggingfaceリポジトリからATI-Wanモデルをダウンロードしてください。


```
huggingface-cli download bytedance-research/ATI --local-dir ./Wan2.1-ATI-14B-480P
```
最終的に、VAE、T5、およびその他のチェックポイントを元のWan2.1フォルダからATIチェックポイントの場所にコピーします。


```
cp ./Wan2.1-I2V-14B-480P/Wan2.1_VAE.pth ./Wan2.1-ATI-14B-480P/
cp ./Wan2.1-I2V-14B-480P/models_t5_umt5-xxl-enc-bf16.pth ./Wan2.1-ATI-14B-480P/
cp ./Wan2.1-I2V-14B-480P/models_clip_open-clip-xlm-roberta-large-vit-huge-14.pth ./Wan2.1-ATI-14B-480P/
cp -r ./Wan2.1-I2V-14B-480P/xlm-roberta-large ./Wan2.1-ATI-14B-480P/
cp -r ./Wan2.1-I2V-14B-480P/google ./Wan2.1-ATI-14B-480P/
```

## Run

We provide a demo sript to run ATI.

```
bash run_example.sh -p examples/test.yaml -c ./Wan2.1-ATI-14B-480P -o samples
```
where `-p` は設定ファイルへのパス、`-c` はチェックポイントへのパス、`-o` は出力ディレクトリへのパス、`-g` は使用するGPUの数を定義します（指定しない場合、使用可能なすべてのGPUが使用されます。`1`を指定すると、シングルプロセスモードで実行されます）。

完了すると、以下のものが生成されます：
- 生の出力動画は `samples/outputs` にあります。
- 入力画像とユーザー指定の軌跡を示すものは `samples/images_tracks` にあります。
- 出力動画とユーザー指定の軌跡を示すものは `samples/outputs_vis` にあります。

期待される結果：


<table style="width: 100%; border-collapse: collapse; text-align: center; border: 1px solid #ccc;">
  <tr>
    <th style="text-align: center;">
      <strong>入力画像と軌跡</strong>
    </th>
    <th style="text-align: center;">
      <strong>生成された動画（軌跡重ね合わせ）</strong>
    </th>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/00.jpg" alt="Image 0" style="height: 240px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/00.gif" alt="Image 0" style="height: 240px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/01.jpg" alt="Image 1" style="height: 240px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/01.gif" alt="Image 1" style="height: 240px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/02.jpg" alt="Image 2" style="height: 160px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/02.gif" alt="Image 2" style="height: 160px;">
    </td>
  </tr>

  </tr>
  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/03.jpg" alt="Image 3" style="height: 220px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/03.gif" alt="Image 3" style="height: 220px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/04.jpg" alt="Image 4" style="height: 240px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/04.gif" alt="Image 4" style="height: 240px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/05.jpg" alt="Image 5" style="height: 160px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/05.gif" alt="Image 5" style="height: 160px;">
    </td>
  </tr>
</table>


## 独自の軌跡を作成する

ユーザーが画像上で軌跡を描画および編集できるインタラクティブなツールを提供しています。

1. まず実行してください：
```
cd tools/trajectory_editor
python3 app.py
```
then open this url [localhost:5000](http://localhost:5000/) in the browser. Note if you run the editor on the server, you need to replace `localhost` with the server's IP address.

2. Get the interface shown below, then click **Choose File** to open a local image.  
![Interface Screenshot](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor0.PNG)

3. Available trajectory functions:  
![Trajectory Functions](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor1.PNG)

   a. **Free Trajectory**: 画像上で直接マウスをクリックしてドラッグします。  
   b. **Circular (Camera Control)**:  
      - 画像上に円を配置し、フレーム0のサイズをドラッグで設定します。  
      - 円上にいくつか（3〜4推奨）のトラックポイントを配置します。  
      - 半径コントロールをドラッグしてズームイン／ズームアウト効果を実現します。  

   c. **Static Point**: 時間経過しても動かない固定点です。  

   *注意:* 動作速度を制御するためにボックス内の進捗バーに注目してください。  
   ![Progress Control](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor2.PNG)

4. **Trajectory Editing**: ここで軌跡を選択し、削除、編集、またはコピーします。編集モードでは、画像上で軌跡を直接ドラッグできます。選択された軌跡は色で強調表示されます。  
![Trajectory Editing](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor3.PNG)

5. **Camera Pan Control**: 水平方向（X）または垂直方向（Y）の速度（ピクセル／フレーム）を入力します。正のXは右方向、負のXは左方向に移動します。正のYは下方向、負のYは上方向に移動します。**Add to Selected**をクリックして現在の軌跡に適用、または**Add to All**をクリックしてすべての軌跡に適用します。選択されたポイントは既存の動きに加えて一定のパン動作を得ます。  
![Camera Pan Control](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor4.PNG)

6. **重要:** 編集後は必ず**Store Tracks**をクリックして保存してください。すべての軌跡を描画した後、各画像（各軌跡ではありません）を個別に保存する必要があります。  
![Store Tracks](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor5.PNG)

7. すべての編集が完了したら、**Trajectory Editor**内の`videos_example`フォルダを探してください。


## Citation
Please cite our paper if you find our work useful:
```
@article{wang2025ati,
  title={{ATI}: Any Trajectory Instruction for Controllable Video Generation},
  author={Wang, Angtian and Huang, Haibin and Fang, Zhiyuan and Yang, Yiding, and Ma, Chongyang}
  journal={arXiv preprint},
  volume={arXiv:2505.22944},
  year={2025}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---