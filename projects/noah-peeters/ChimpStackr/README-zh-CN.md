# ChimpStackr

![GitHub all releases](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/latest/total) ![GitHub](https://img.shields.io/github/license/noah-peeters/ChimpStackr) ![GitHub commits since latest release (by date)](https://img.shields.io/github/commits-since/noah-peeters/ChimpStackr/latest)

<p align="center">
  <img src="https://raw.githubusercontent.com/noah-peeters/ChimpStackr/master/packaging/icons/chimpstackr_icon.png" width="200"/>
</p>

面向 Windows、macOS 和 Linux 的开源焦点合成应用。

## 功能

- **4 种堆栈算法：** 拉普拉斯金字塔、加权平均、深度图、曝光融合（HDR）
- **自动对齐：** 仅平移或旋转 + 缩放校正（对焦呼吸）
- **16 位流程：** 从 RAW 到输出的全位深度保留
- **自动裁剪：** 去除对齐偏移产生的黑边
- **自动调优：** 根据图像分辨率自动检测参数
- **GUI + CLI：** 完整图形界面和无头命令行工具
- **跨平台：** Windows、macOS、Linux 原生构建
- **暂停/恢复/取消：** 控制长时间运行的堆栈
- **前后对比：** 滑块查看器比较输入与输出
- **拖放支持：** 直接将图像文件或文件夹拖入应用

## 下载

预构建包可在 [Releases](https://github.com/noah-peeters/ChimpStackr/releases) 页面获得：

| 平台 | 下载 | 说明 |
|---|---|---|
| **Windows** | `ChimpStackr-Windows.zip` | 解压并运行 `chimpstackr.exe` |
| **macOS** | `ChimpStackr-macOS.dmg` | 打开 DMG，拖动到应用程序 |
| **Linux** | `ChimpStackr-Linux-x86_64.AppImage` | 运行前执行 `chmod +x` |

## CLI 使用

CLI 允许无 GUI 的无头焦点合成：

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

**可用方法：** `laplacian`（默认）、`weighted_average`、`depth_map`

## 堆叠算法

| 方法 | 适用场景 | 工作原理 |
|---|---|---|
| **金字塔** | 细节丰富（头发、毛刺、边缘） | 拉普拉斯金字塔分解，每个频带最大对比度选择，局部色调映射 |
| **加权** | 平滑主体，良好色彩 | 每像素对比度加权与适当累积 |
| **深度图** | 不透明表面，最佳色彩保真度 | 多尺度锐度结合边缘感知双边平滑 |
| **HDR** | 变化曝光/光照 | Mertens曝光融合（非焦点堆叠） |

## 从源码构建

要求 Python 3.9-3.13。

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

## 打包

构建使用 PyInstaller 并进行特定平台的后处理。您只能为当前平台构建。

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

CI/CD 通过 GitHub Actions 在带标签的发布版本上自动构建所有平台。

## 画廊

以下堆栈是在大约4倍放大倍率下使用稍有抖动的设备拍摄的（每组约150张图像），使用 ChimpStackr 进行堆叠，并在 [darktable](https://www.darktable.org/) 中后期处理。

![Bij_TranslationAlignment](https://user-images.githubusercontent.com/17707805/196990942-413ea35c-2abb-4bce-9807-3f3d6b3de3c5.jpg)
![Edited](https://user-images.githubusercontent.com/17707805/196991117-dc4f1c76-cc87-4ef1-92ee-9a7484c7ff07.jpg)
![Bewerkt](https://user-images.githubusercontent.com/17707805/196996295-9fb6c365-ef10-4ef5-b451-1a7269156e53.jpg)

## 来源

- 基于以下论文的焦点堆叠算法：Wang, W., & Chang, F. (2011). 一种基于拉普拉斯金字塔的多焦点图像融合方法。*计算机学报*, 6(12)。
- DFT 图像对齐改编自：[imreg_dft](https://github.com/matejak/imreg_dft)
- Mertens 曝光融合：Mertens, T., Kautz, J., & Van Reeth, F. (2007). 曝光融合。
- 修正拉普拉斯和焦点测量：Nayar, S.K., & Nakagawa, Y. (1994)。

## 许可证

GPL-3.0 - 详情请见 [LICENSE](LICENSE)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---