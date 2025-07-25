# OneTwoVLA: A Unified Vision-Language-Action Model with Adaptive Reasoning

[[Project Page]](https://one-two-vla.github.io/) [[Paper]](https://arxiv.org/abs/2505.11917) [[Processed Datasets]](https://huggingface.co/datasets/Richard-Nai/onetwovla-dataset)

[Fanqi Lin](https://fanqi-lin.github.io/)<sup>1,2,3,5\*</sup>,
[Ruiqian Nai](https://richard-coder-nai.github.io/)<sup>1,2,3,5\*</sup>,
[Yingdong Hu](https://yingdong-hu.github.io/)<sup>1,2,3\*</sup>,
[Jiacheng You](https://scholar.google.com/citations?user=FiP-TVUAAAAJ)<sup>1,2,3</sup>,
Junming Zhao<sup>1,4</sup>,
[Yang Gao](https://yang-gao.weebly.com/)<sup>1,2,3,5</sup>

<sup>1</sup>Tsinghua University,
<sup>2</sup>Shanghai Qi Zhi Institute,
<sup>3</sup>Shanghai AI Lab, 
<sup>4</sup>Fudan University,
<sup>5</sup>Spirit AI

<sup>\*</sup> indicates equal contributions


## 🛠️ Installation

We manage Python dependencies with [uv](https://docs.astral.sh/uv/). If you haven't installed `uv`, please follow [uv installation instructions](https://docs.astral.sh/uv/getting-started/installation/) to set it up. 

Run the following to set up the environment:

```bash
GIT_LFS_SKIP_SMUDGE=1 uv sync
GIT_LFS_SKIP_SMUDGE=1 uv pip install -e .
```

> NOTE: `GIT_LFS_SKIP_SMUDGE=1` is needed to pull LeRobot as a dependency.

For more details, refer to the original [openpi repository](https://github.com/Physical-Intelligence/openpi.git). 

## 🚀 Training OneTwoVLA
Download the dataset and place them under `$LEROBOT_HOME/umi/`.

To train a OneTwoVLA model, run:
```bash
bash train_scripts/train_<task_name>.sh
```
Available tasks are:
```bash
train_scripts
|-- train_onetwovla_cocktail.sh
|-- train_onetwovla_visual_grounding.sh
|-- train_pi0_cocktail.sh
|-- train_pi0_visual_grounding.sh
```

## 🦾 Real-World Deployment
We run inference using a policy server and a hardware client. The instructions for running the policy server can be found at [examples/umi/README.md](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/examples/umi/README.md), and we provide the UMI hardware client code in this [repository](https://github.com/Fanqi-Lin/OneTwoVLA-UMI-Client).

## 📷 Data
We provide access to the following datasets:

- `Robot Datasets`: Datasets for the `cocktail` and `open-world visual grounding` tasks.
- `Vision-Language Datasets`: Datasets containing synthetic images and annotated reasoning for the `open-world visual grounding` task.

All datasets are hosted on Hugging Face. You can find them [here](https://huggingface.co/datasets/Richard-Nai/onetwovla-dataset).

We provide code for converting UMI data format to LeRobot data format [here](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/examples/umi/convert_umi_data_to_lerobot.py).

### Synthetic Image Augmentation

To make the synthetic images more closely resemble real robot observations, we randomly apply several augmentations, including random fisheye distortion and compositing a robot gripper with adaptive brightness adjustments. The implementation is available in [scripts/augment_vl_data/augment.py](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/scripts/augment_vl_data/augment.py).

Here we show an example. From left to right, the images are: the original image, the image with fisheye distortion, the image compositing a robot gripper with adaptive brightness adjustments, and the image with both applied.

<img width="90%" src="https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/figures/fisheye-aug.png">

## 🙏 Acknowledgements
We express our sincere gratitude to the developers of the [openpi](https://github.com/Physical-Intelligence/openpi.git) for open-sourcing their code.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---