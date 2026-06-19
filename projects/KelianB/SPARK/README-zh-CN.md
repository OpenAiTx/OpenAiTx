<p align="center">
    <h1 align="center">SPARK：自监督个性化实时单目人脸捕捉</h1>
    <p align="center">
        <a href="mailto://kelian.baert@gmail.com"><strong>Kelian Baert</strong></a>
        ·
        <a href="https://sbharadwajj.github.io/"><strong>Shrisha Bharadwaj</strong></a>
        ·
        <a href="https://www.linkedin.com/in/fabien-castan/"><strong>Fabien Castan</strong></a>
        ·
        <a href="https://www.linkedin.com/in/benoitmaujean/"><strong>Benoit Maujean</strong></a>
        ·
        <a href="https://people.irisa.fr/Marc.Christie/"><strong>Marc Christie</strong></a>
        ·
        <a href="https://vabrevaya.github.io/"><strong>Victoria Fernandez Abrevaya</strong></a>
        ·
        <a href="https://boukhayma.github.io/"><strong>Adnane Boukhayma</strong></a>
    </p>
    <p align="center">
        <a href="https://technicolor.com">Technicolor</a> | <a href="https://is.mpg.de/">马克斯·普朗克研究所</a> | <a href="https://www.inria.fr/en/inria-centre-rennes-university">INRIA 雷恩</a>
        <br>
        <strong>SIGGRAPH Asia 2024 会议论文</strong>
    </p>
    <p align="center">
        <a href="https://kelianb.github.io/SPARK/" style="padding-left: 0.5rem;">
            <img src="https://img.shields.io/badge/Project-Page-blue?style=flat&logo=Google%20chrome&logoColor=blue" alt="Project Page">
        </a>
        <a href="https://dl.acm.org/doi/10.1145/3680528">
            <img src="https://img.shields.io/badge/Paper-red" alt="PDF">
        </a>
        <a href="https://arxiv.org/abs/2409.07984">
            <img src="https://img.shields.io/badge/Arxiv-red" alt="arxiv PDF">
        </a>
    </p>
    <p align="center">
        <img src="https://raw.githubusercontent.com/KelianB/SPARK/main/assets/teaser.webp" width="98%" />
    </p>
</p>

## 引用

如果您觉得我们的代码或论文有用，请引用：

```bibtex
@inproceedings{baert2024spark,
  title = {{SPARK}: Self-supervised Personalized Real-time Monocular Face Capture},
  author = {Baert, Kelian and Bharadwaj, Shrisha and Castan, Fabien and Maujean, Benoit and Christie, Marc and Abrevaya, Victoria and Boukhayma, Adnane},
  year = {2024},
  month = dec,
  booktitle = {SIGGRAPH Asia 2024 Conference Proceedings},
  articleno = {113},
  doi = {10.1145/3680528.3687704},
  isbn = {979-8-4007-1131-2/24/12},
  publisher = {Association for Computing Machinery},
  address = {New York, NY, USA},
  numpages = {12},
  url = {https://kelianb.github.io/SPARK/},
}
```

## 安装

<details>
    <summary>详情</summary>

- 使用 [setup.sh](https://raw.githubusercontent.com/KelianB/SPARK/main/./setup.sh) 创建环境。
- 运行 [TrackerAdaptation/setup_submodules.sh](https://raw.githubusercontent.com/KelianB/SPARK/main/./TrackerAdaptation/setup_submodules.sh)。这可能需要几分钟时间。
- 从 MultiFLARE 链接 FLAME 到 EMOCA：`ln TrackerAdaptation/submodules/EMOCA/assets/FLAME/geometry/generic_model.pkl MultiFLARE/assets/flame/flame2020.pkl`
    - 这相当于下载 [FLAME](https://flame.is.tue.mpg.de/download.php)（2020 版本），解压并将 `generic_model.pkl` 复制到 `./MultiFLARE/assets/flame/flame2020.pkl`。
- 获取适配到 FLAME 的 Basel 面部模型纹理空间。不幸的是，由于许可证限制，我们不能分发纹理空间。因此，请使用此 [仓库](https://github.com/TimoBolkart/BFM_to_FLAME) 中的工具将纹理空间转换为 FLAME。将生成的纹理模型文件放置在 `TrackerAdaptation/submodules/EMOCA/assets/FLAME/texture/FLAME_albedo_from_BFM.npz`。

SPARK 已在 NVIDIA RTX A5000（24GB）或 RTX A4000（16GB）GPU 上测试。通过减小批量大小，可以在内存较小的 GPU 上进行训练。

</details>

## 数据集

请参考 [MonoFaceCompute](https://github.com/KelianB/MonoFaceCompute) 仓库预处理您自己的数据。

## 使用方法

SPARK 是一个两阶段方法。首先，运行 [MultiFLARE](./MultiFLARE/) 从多个视频重建 3D 面部头像。然后，使用 [TrackerAdaptation](./TrackerAdaptation/) 通过迁移学习将现有的 3D 面部跟踪器适配到您的头像，实现实时跟踪。

<details>
    <summary>详情</summary>

### 1. MultiFLARE

```bash
cd MultiFLARE
python train.py --config configs/example.txt

# Export neutral mesh
python export_mesh.py --config configs/example.txt --resume 3000 --out_dir /tmp/example_mesh --tex_type albedo
```

我们建议从提供的示例配置开始，修改 `input_dir`、`train_dir` 和 `output_dir`。有关所有参数的列表，请参阅 [arguments.py](https://raw.githubusercontent.com/KelianB/SPARK/main/./MultiFLARE/arguments.py) 或运行 `python train.py --help` 的输出。参数可以在配置文件中传递，也可以作为命令行参数传递。

### 2. TrackerAdaptation

```bash
cd TrackerAdaptation
# DECA encoder + MultiFLARE decoder
python train.py --config configs/example_deca.txt
# EMOCA encoder + MultiFLARE decoder
python train.py --config configs/example_emoca.txt
# SMIRK encoder + MultiFLARE decoder (recommended!)
python train.py --config configs/example_smirk.txt
# EMOCA encoder + EMOCA decoder (baseline)
python train.py --config configs/example_emoca_baseline.txt

# Quantitative eval
python evaluate.py --config configs/example_smirk.txt --tracker_resume 3000 --frame_interval 5 --num_frames 64

# Visualization videos
python make_comparison_video.py --config configs/example_smirk.txt --tracker_resume 3000 --test_dirs 5 6 --n_frames 1000 --smooth_crops --framerate 24
python make_overlay_video.py --config configs/example_smirk.txt --tracker_resume 3000 --test_dirs 2 --out test_beard --texture /path/to/texture.png --n_frames 1000 --smooth_crops --framerate 24
```

</details>

## 许可信息

本仓库中的代码受多重许可约束。

1. **原始代码**（Technicolor Group & INRIA Rennes）  
   - 本仓库中所有代码，除另有说明外，均遵循[CC BY-NC-SA 许可](./LICENSE)。

2. **第三方代码**（马克斯·普朗克智能系统研究所）  
   - 位置：`./MultiFLARE/flame`，`./MultiFLARE/flare`，`./TrackerAdaptation/submodules`  
   - 这些目录包含马克斯·普朗克研究所的代码，并经过部分修改。请仔细阅读[MPI 许可](./LICENSE_MPI)，并注意该许可仅适用于**非商业科学研究用途**。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-19

---