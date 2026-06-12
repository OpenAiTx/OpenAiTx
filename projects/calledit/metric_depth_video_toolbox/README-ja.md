# メトリック深度ビデオツールボックス（MDVToolbox）

メトリック3D深度ビデオの生成と操作のためのツール。

![gif_banner](https://github.com/user-attachments/assets/4d737bb3-6fb6-4135-b01e-b35528371d22)

_バナーは3d_view_depthfile.pyで作成_

## デモ

**ショーケースビデオ:** https://youtu.be/nEiUloZ591Q

**ムービー → 3D変換デモ**: https://www.youtube.com/watch?v=PLFjoNgkZDY

**サンプルステレオクリップ:**
https://github.com/calledit/metric_depth_video_toolbox/releases/tag/Showcase


## 機能

### メトリック深度ビデオ生成

複数の最先端モデルを使ってRGBビデオをメトリック深度ビデオに変換：

- Depth-Anythingシリーズ（`video_metric_convert.py`）および（`videoanythingmetric_video.py`）
- MoGe（`moge_video.py`）
- UniDepth（`unidepth_video.py`）
- UniK3D（`unik3d_video.py`）
- DepthPro（`depthpro_video.py`）
- DepthCrafter（`depthcrafter_video.py`）
- MVSAnywhere（`video_mvsa.py`）

### ステレオ / 3D変換

- 2Dムービー → 3D（`movie_2_3D.py`）
- 深度とRGBビデオからのステレオレンダリング（`stereo_rerender.py`）
- 視差補完＆拡散ベースのステレオインペインティング（`stereo_crafter_infill.py`）

### 可視化

- メトリック深度ビデオのリアルタイム3Dビューアー（`3d_view_depthfile.py`）
- 深度ビデオからの新規視点レンダリング（`3d_view_depthfile.py`）

### カメラトラッキング＆3D再構成

- 深度補助カメラトラッキング（`sam_track_video.py`）および（`align_3d_points.py`）
- 長期ポイントトラッキング（CoTracker3）（`track_points_in_video.py`）
- ポーズ抽出＆アライメントツール

### エクスポートツール

メトリック深度ビデオを他のツールで使用可能な標準フォーマットにエクスポート：（`convert_metric_depth_video_to_other_format.py`）

- `.ply` ポイントクラウド
- `.obj` メッシュ
- Blender `.blend` & Alembic `.abc` カメラトラック
- 8ビット / 16ビット深度マップ
- 三角測量に基づく深度の再スケーリング

### マスキング＆クリーンアップ

- 自動メイン被写体マスキング（`generate_video_mask.py`）
- 字幕／ロゴのインペインティング（`apply_inpainting.sh`）


## ドキュメンテーション

| トピック | リンク |
|---|---|
初心者ガイド | [`HOWTO.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO.md)  
ムービー → 3Dガイド | [`HOWTO_movie2_3d.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO_movie2_3d.md)  
フルツールリファレンス | [`USAGE.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/USAGE.md)  
GUIチュートリアル動画 | https://youtu.be/BE_aJCI7DHI  


## 深度ビデオフォーマット

MDVTは**RGBエンコードされた16ビットメトリック深度**を使用：

- **赤 + 緑** = 上位8ビット（視認性のため複製）
- **青色** = 下位8ビット  
- デフォルト範囲: **100メートル**  
- 解像度: **約1.5mmの深度精度**  

将来的な精度向上は、**24ビット深度**または**対数エンコード深度**を用いた長距離精度で行われます。  

---  

## インストール  

### Windows  
1. gitをインストール https://git-scm.com/downloads/win  
2. minicondaをインストール https://docs.conda.io/en/latest/  
3. スタートメニューからAnacondaプロンプト(miniconda)を開く  
4. 実行する
```batch
git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox
windows_installer.bat
```
5. `conda activate mdvt` を使用して conda をアクティベートし、ツールを使用します。いくつかのMLモデルはWindowsでサポートされていませんが、Sterecrafterやdepth anythingなどの最も重要なものはサポートされています。

### Ubuntu/Debian と OSX

```bash


git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox

# on linux
sudo apt-get install -y libgl1
./install_mdvtoolbox.sh

#Optional (only required for some tools)
./install_mdvtoolbox.sh -megasam
./install_mdvtoolbox.sh -geometrycrafter
./install_mdvtoolbox.sh -unik3d
./install_mdvtoolbox.sh -depthpro
./install_mdvtoolbox.sh -stereocrafter
./install_mdvtoolbox.sh -madpose
./install_mdvtoolbox.sh -unidepth
./install_mdvtoolbox.sh -moge
./install_mdvtoolbox.sh -promptda

# if using headless linux you need to start a virtual x11 server
apt-get install xvfb
Xvfb :2 &
export DISPLAY=:2

# OSX (OSX only supports post processing of depth videos not generation of them. As the ML models need CUDA)
# (open3d requires python3.11 on OSX (as of 2025)))
pip3.11 install open3d numpy opencv-python

```

### 要件
MLモデルを必要とするツールは、Cuda 12.4およびTorch 2.5.1をサポートするnvidia 3090カード搭載マシンで、[vast.ai](https://cloud.vast.ai/?ref_id=148636)の「template PyTorch (cuDNN Devel)」を使用してテストされています。

### 次のステップ
- 現在、新しい安定で精度の高い深度モデルを待っています。

### 貢献
歓迎します。スペルのような簡単なことでも構いません。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---