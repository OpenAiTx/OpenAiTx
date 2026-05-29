# ChimpStackr

![GitHub all releases](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/latest/total) ![GitHub](https://img.shields.io/github/license/noah-peeters/ChimpStackr) ![GitHub commits since latest release (by date)](https://img.shields.io/github/commits-since/noah-peeters/ChimpStackr/latest)

<p align="center">
  <img src="https://raw.githubusercontent.com/noah-peeters/ChimpStackr/master/packaging/icons/chimpstackr_icon.png" width="200"/>
</p>

Windows、macOS、Linux向けのオープンソース焦点合成アプリケーション。

## 特徴

- **4つの合成アルゴリズム：** ラプラシアンピラミッド、加重平均、深度マップ、露出融合（HDR）
- **自動アライメント：** 平行移動のみ、または回転＋スケール補正（フォーカスブリージング）
- **16ビットパイプライン：** RAWから出力までのフルビット深度を保持
- **自動クロップ：** アライメントシフトによる黒い縁を除去
- **自動調整：** 画像解像度からパラメータを自動検出
- **GUI + CLI：** フルグラフィカルインターフェースとヘッドレスコマンドラインツール
- **クロスプラットフォーム：** Windows、macOS、Linuxのネイティブビルド
- **一時停止／再開／キャンセル：** 長時間の合成処理を制御
- **ビフォー／アフター比較：** 入力と出力を比較するスライダー表示
- **ドラッグ＆ドロップ：** 画像ファイルやフォルダを直接アプリにドロップ可能

## ダウンロード

事前ビルド済みパッケージは[リリース](https://github.com/noah-peeters/ChimpStackr/releases)ページで入手可能：

| プラットフォーム | ダウンロード | 備考 |
|---|---|---|
| **Windows** | `ChimpStackr-Windows.zip` | 解凍して`chimpstackr.exe`を実行 |
| **macOS** | `ChimpStackr-macOS.dmg` | DMGを開き、アプリケーションにドラッグ |
| **Linux** | `ChimpStackr-Linux-x86_64.AppImage` | `chmod +x`して実行 |

## CLIの使い方

CLIはGUIなしでのヘッドレス焦点合成を可能にします：

```bash
# Basic stack
chimpstackr-cli --input images/*.jpg --output result.tif

# Align + stack with auto parameters
chimpstackr-cli -i images/*.jpg -o result.tif --align --auto --auto-crop

# Full options
chimpstackr-cli -i images/*.jpg -o result.png \
  --align \
  --method laplacian \
  --rotation-scale \
  --kernel-size 6 \
  --pyramid-levels 8 \
  --auto-crop \
  --quality-report
```

**利用可能なメソッド:** `laplacian`（デフォルト）、`weighted_average`、`depth_map`

## スタッキングアルゴリズム

| メソッド | 適しているもの | 動作方法 |
|---|---|---|
| **ピラミッド** | 細かいディテール（髪の毛、毛先、エッジ） | ラプラシアンピラミッド分解、周波数帯ごとの最大コントラスト選択、局所トーンマッピング |
| **加重平均** | 滑らかな被写体、良好な色彩 | 適切な蓄積を伴うピクセルごとのコントラスト重み付け |
| **深度マップ** | 不透明な表面、最高の色忠実度 | エッジ認識バイラテラル平滑化を用いたマルチスケールシャープネス |
| **HDR** | 露出・照明が異なる場合 | Mertens露出融合（フォーカススタッキングには非対応） |

## ソースからのビルド

Python 3.9～3.13が必要です。

```bash
git clone https://github.com/noah-peeters/ChimpStackr.git
cd ChimpStackr
python -m venv .venv
source .venv/bin/activate  # or .venv\Scripts\activate on Windows
pip install -r requirements.txt

# Run GUI
python src/run.py

# Run CLI
python -m src.cli --help

# Run tests
pip install pytest
pytest tests/ -v
```

## パッケージング

ビルドはプラットフォーム固有の後処理を伴うPyInstallerを使用します。現在のプラットフォームでのみビルド可能です。

```bash
# Install build tools
pip install pyinstaller

# Build (creates dist/chimpstackr/ and dist/ChimpStackr.app on macOS)
pyinstaller chimpstackr.spec --noconfirm

# Or use the platform scripts:
./scripts/build_macos.sh        # macOS → .dmg
./scripts/build_linux.sh        # Linux → .AppImage
.\scripts\build_windows.ps1     # Windows → .zip or installer
```
CI/CDは、タグ付きリリース時にGitHub Actionsを通じてすべてのプラットフォームを自動的にビルドします。

## ギャラリー

以下のスタックは、約4倍の倍率でやや不安定なリグ上で撮影されたものです（各約150枚）、ChimpStackrでスタックし、[darktable](https://www.darktable.org/)で後処理されています。

![Bij_TranslationAlignment](https://user-images.githubusercontent.com/17707805/196990942-413ea35c-2abb-4bce-9807-3f3d6b3de3c5.jpg)
![Edited](https://user-images.githubusercontent.com/17707805/196991117-dc4f1c76-cc87-4ef1-92ee-9a7484c7ff07.jpg)
![Bewerkt](https://user-images.githubusercontent.com/17707805/196996295-9fb6c365-ef10-4ef5-b451-1a7269156e53.jpg)

## 参考文献

- フォーカススタッキングアルゴリズムの基礎：Wang, W., & Chang, F. (2011). A Multi-focus Image Fusion Method Based on Laplacian Pyramid. *Journal of Computers*, 6(12).
- DFT画像アライメントは以下より適用：[imreg_dft](https://github.com/matejak/imreg_dft)
- Mertensの露出融合：Mertens, T., Kautz, J., & Van Reeth, F. (2007). Exposure Fusion.
- Sum Modified Laplacianフォーカス測定：Nayar, S.K., & Nakagawa, Y. (1994).

## ライセンス

GPL-3.0 - 詳細は[LICENSE](LICENSE)をご覧ください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---