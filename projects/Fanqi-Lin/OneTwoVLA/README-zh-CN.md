# OneTwoVLA：一个具备自适应推理能力的统一视觉-语言-动作模型

[[项目主页]](https://one-two-vla.github.io/) [[论文]](https://arxiv.org/abs/2505.11917) [[处理后的数据集]](https://huggingface.co/datasets/Richard-Nai/onetwovla-dataset)

[Fanqi Lin](https://fanqi-lin.github.io/)<sup>1,2,3,5\*</sup>,
[Ruiqian Nai](https://richard-coder-nai.github.io/)<sup>1,2,3,5\*</sup>,
[Yingdong Hu](https://yingdong-hu.github.io/)<sup>1,2,3\*</sup>,
[Jiacheng You](https://scholar.google.com/citations?user=FiP-TVUAAAAJ)<sup>1,2,3</sup>,
Junming Zhao<sup>1,4</sup>,
[Yang Gao](https://yang-gao.weebly.com/)<sup>1,2,3,5</sup>

<sup>1</sup>清华大学，
<sup>2</sup>上海启智研究院，
<sup>3</sup>上海人工智能实验室，
<sup>4</sup>复旦大学，
<sup>5</sup>Spirit AI

<sup>\*</sup> 表示同等贡献


## 🛠️ 安装

我们使用 [uv](https://docs.astral.sh/uv/) 管理 Python 依赖。如果你尚未安装 `uv`，请按照[uv 安装说明](https://docs.astral.sh/uv/getting-started/installation/)进行安装。

运行以下命令以设置环境：

```bash
GIT_LFS_SKIP_SMUDGE=1 uv sync
GIT_LFS_SKIP_SMUDGE=1 uv pip install -e .
```

> 注意：拉取 LeRobot 作为依赖时需要设置 `GIT_LFS_SKIP_SMUDGE=1`。

更多详情请参考原始的 [openpi 仓库](https://github.com/Physical-Intelligence/openpi.git)。

## 🚀 训练 OneTwoVLA
下载数据集并放置于 `$LEROBOT_HOME/umi/` 下。

要训练 OneTwoVLA 模型，请运行：
```bash
bash train_scripts/train_<task_name>.sh
```
可用任务有：
```bash
train_scripts
|-- train_onetwovla_cocktail.sh
|-- train_onetwovla_visual_grounding.sh
|-- train_pi0_cocktail.sh
|-- train_pi0_visual_grounding.sh
```

## 🦾 真实世界部署
我们使用策略服务器和硬件客户端进行推理。运行策略服务器的说明可以在 [examples/umi/README.md](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/examples/umi/README.md) 找到，我们在此[仓库](https://github.com/Fanqi-Lin/OneTwoVLA-UMI-Client)中提供了 UMI 硬件客户端代码。

## 📷 数据
我们提供以下数据集的访问权限：

- `机器人数据集`：用于 `cocktail` 和 `开放世界视觉定位` 任务的数据集。
- `视觉-语言数据集`：包含合成图像和带注释推理的 `开放世界视觉定位` 任务数据集。

所有数据集均托管于 Hugging Face。您可以在[这里](https://huggingface.co/datasets/Richard-Nai/onetwovla-dataset)找到它们。

我们提供将 UMI 数据格式转换为 LeRobot 数据格式的代码[这里](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/examples/umi/convert_umi_data_to_lerobot.py)。

### 合成图像增强

为了使合成图像更接近真实机器人观测，我们随机应用多种增强，包括随机鱼眼畸变和通过自适应亮度调整合成机器人夹爪。实现代码见[scripts/augment_vl_data/augment.py](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/scripts/augment_vl_data/augment.py)。

这里展示一个示例。从左到右，图像依次为：原始图像、带鱼眼畸变的图像、合成机器人夹爪并进行自适应亮度调整的图像，以及同时应用两者的图像。

<img width="90%" src="https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/figures/fisheye-aug.png">

## 🙏 致谢
我们衷心感谢 [openpi](https://github.com/Physical-Intelligence/openpi.git) 开发者开源他们的代码。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---