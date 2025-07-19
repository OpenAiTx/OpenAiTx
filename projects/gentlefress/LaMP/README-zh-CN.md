# :bulb: LaMP：用于动作生成、检索和描述的语言-动作预训练（ICLR 2025）
### [[项目页面]](https://aigc3d.github.io/LaMP/) [[论文]](https://arxiv.org/abs/2410.07093)
![teaser_image](https://github.com/gentlefress/LaMP/blob/main/teaser.png)

如果您觉得我们的代码或论文有帮助，请考虑为我们的仓库点赞并引用：
```
@article{li2024lamp,
  title={LaMP: Language-Motion Pretraining for Motion Generation, Retrieval, and Captioning},
  author={Li, Zhe and Yuan, Weihao and He, Yisheng and Qiu, Lingteng and Zhu, Shenhao and Gu, Xiaodong and Shen, Weichao and Dong, Yuan and Dong, Zilong and Yang, Laurence T},
  journal={arXiv preprint arXiv:2410.07093},
  year={2024}
}
```
<translate-content>
## :postbox: 新闻
📢 **2025-01-22** --- 🔥🔥🔥 祝贺！LaMP被ICLR 2025录用。

📢 **2025-4-28** --- 发布LaMP的代码和模型。包括训练/评估/生成脚本。

📢 **2025-4-28** --- 初始化网页和git项目。  


## :1st_place_medal: 准备就绪

<details>
  
### 1. Conda 环境</translate-content>
```
conda env create -f environment.yml
conda activate lamp
pip install git+https://github.com/openai/CLIP.git
```
我们在 Python 3.9.12 和 PyTorch 1.12.1 上测试我们的代码

### 2. 模型与依赖

#### 下载预训练模型
```
bash prepare/download_models.sh
```
#### 下载评估模型和手套  
仅供评估使用。

```
bash prepare/download_evaluator.sh
bash prepare/download_glove.sh
```
#### （可选）手动下载  
##### VQVAE 预训练权重：  
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/vq.tar  
##### LaMP 预训练权重：  
HumanML3D: https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/h3d-qformer.tar  

KIT-ML: https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/kit-qformer.tar  
##### LaMP-T2M 预训练权重：  
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/t2m.tar  
##### M2T-LaMP 预训练权重：  
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/m2t.pth  
### 3. 获取数据  

你有两个选择：  
* **跳过获取数据**，如果你只想使用*自己的*描述生成动作。  
* **获取完整数据**，如果你想*重新训练*和*评估*模型。  

**（a）完整数据（文本 + 动作）**  

**HumanML3D** - 按照 [HumanML3D](https://github.com/EricGuo5513/HumanML3D.git) 中的说明操作，然后将得到的数据集复制到我们的仓库：


```
cp -r ../HumanML3D/HumanML3D ./dataset/HumanML3D
```
**KIT**-从 [HumanML3D](https://github.com/EricGuo5513/HumanML3D.git) 下载，然后将结果放置在 `./dataset/KIT-ML`

#### 

</details>

## :fire: 演示
<details>

### (a) 从单个提示生成</details>
```
python gen_t2m.py --gpu_id 1 --ext exp1 --text_prompt "A person is running on a treadmill."
```
### (b) 从提示文件生成  
提示文件的示例见 `./assets/text_prompt.txt`。请遵循每行 `<文本描述>#<动作长度>` 的格式。动作长度表示姿势数量，必须是整数且将四舍五入为4的倍数。在我们的工作中，动作以20帧每秒为单位。  
如果你写 `<文本描述>#NA`，我们的模型将自动确定长度。注意，一旦有**一个**NA，其他的也将自动变为**NA**。  


```
python gen_t2m.py --gpu_id 1 --ext exp2 --text_path ./assets/text_prompt.txt
```
您可能感兴趣的几个参数：
* `--repeat_times`：生成的复制次数，默认值为 `1`。
* `--motion_length`：指定生成的姿势数量，仅适用于（a）。

输出文件存储在文件夹 `./generation/<ext>/` 下。它们包括：
* `numpy 文件`：生成的动作，形状为 (nframe, 22, 3)，存放在子文件夹 `./joints` 下。
* `视频文件`：mp4 格式的线条动画，存放在子文件夹 `./animation` 下。
* `bvh 文件`：生成动作的 bvh 文件，存放在子文件夹 `./animation` 下。

我们还对生成的动作应用了简单的脚部逆向运动学，查看带有后缀 `_ik` 的文件。有时效果良好，有时会失败。
  
</details>

## :basketball_man: 可视化
<details>

所有动画均在 Blender 中手动渲染。我们使用来自 [mixamo](https://www.mixamo.com/#/) 的角色。您需要下载带骨骼的 T 形姿势角色。

### 重定向
关于重定向，我们发现 rokoko 通常会导致脚部较大误差。另一方面，[keemap.rig.transfer](https://github.com/nkeeline/Keemap-Blender-Rig-ReTargeting-Addon/releases) 显示了更精确的重定向效果。您可以观看此处的[教程](https://www.youtube.com/watch?v=EG-VCMkVpxg)。

按照以下步骤操作：
* 从 GitHub 下载 keemap.rig.transfer，并在 Blender 中安装。
* 在 Blender 中导入动作文件（.bvh）和角色文件（.fbx）。
* `Shift + 选择` 源骨骼和目标骨骼。（无需处于静止姿势）
* 切换到 `Pose Mode`，然后展开视图窗口右上角的 `KeeMapRig` 工具。
* 对于 `bone mapping file`，指向 `./assets/mapping.json`（如果无效，则为 `mapping6.json`），点击 `Read In Bone Mapping File`。该文件由我们手动制作，适用于大多数 mixamo 角色。
* （可选）您可以手动填写骨骼映射并调整旋转，以适应您的角色。点击 `Save Bone Mapping File` 可以将映射配置保存到本地文件，路径由映射文件路径指定。
* 调整 `Number of Samples`、`Source Rig`、`Destination Rig Name`。
* 点击 `Transfer Animation from Source Destination`，等待几秒钟。

我们未尝试其他重定向工具。如果您发现其他更有用的工具，欢迎留言。

</details>

## :flashlight: 训练您自己的模型
<details>


**注意**：您必须先训练 VQ-VAE，**然后**才能训练掩码/残差变换器。后两者可以同时训练。

### 训练 VQ-VAE
您可能还需要下载评估模型以运行脚本。


```
python train_vq.py --name vq_name --gpu_id 1 --dataset_name t2m --batch_size 256  --max_epoch 50 --quantize_dropout_prob 0.2 --gamma 0.05
```
<translate-content>
### 训练 LaMP</translate-content>
```
python train_lamp.py --name lamp_name --gpu_id 2 --dataset_name t2m --batch_size 64 --vq_name vq_name
```
### 训练掩码变换器

```
python train_t2m_transformer.py --name mtrans_name --gpu_id 2 --dataset_name t2m --batch_size 64 --vq_name vq_name
```
* `--dataset_name`：动作数据集，HumanML3D 使用 `t2m`，KIT-ML 使用 `kit`。  
* `--name`：为你的模型命名。模型将保存在 `./checkpoints/<dataset_name>/<name>` 目录下。
* `--gpu_id`：GPU 编号。
* `--batch_size`：我们在 VQ 训练中使用 `512`。对于掩码/残差变换器，在 HumanML3D 上使用 `64`，在 KIT-ML 上使用 `16`。
* `--quantize_drop_prob`：量化丢弃比例，使用值为 `0.2`。
* `--vq_name`：训练掩码/残差变换器时，需要指定用于分词的 VQ 模型名称。
* `--cond_drop_prob`：条件丢弃比例，用于无分类器引导。使用值为 `0.2`。

所有预训练模型和中间结果将保存在路径 `./checkpoints/<dataset_name>/<name>` 中。

### 训练 M2T

```
python train_m2t.py --exp-name M2T --num-layers 12 --batch-size 80 --embed-dim-gpt 1024 --nb-code 512 --n-head-gpt 16 --block-size 51 --ff-rate 4 --drop-out-rate 0.1 --resume-pth your_own_vqvae --vq-name VQVAE --out-dir ./output --total-iter 150000 --lr-scheduler 75000 --lr 0.00005 --dataname kit --down-t 2 --depth 3 --quantizer ema_reset --eval-iter 10000 --pkeep 0.5 --dilation-growth-rate 3 --vq-act relu
```
</details>

## :artist: 评估
<details>

### 评估 VQ-VAE 重建：
HumanML3D:</details>

```
python eval_t2m_vq.py --gpu_id 0 --name  --dataset_name t2m

```
KIT-ML:
```
python eval_t2m_vq.py --gpu_id 0 --name  --dataset_name kit
```
### 评估 LaMP-T2M：  
HumanML3D：

```
python eval_t2m_trans_res.py --res_name mtrans_name --dataset_name t2m --name eval_name --gpu_id 1 --cond_scale 4 --time_steps 10 --ext evaluation
```
KIT-ML:
```
python eval_t2m_trans_res.py --res_name mtrans_name_k --dataset_name kit --name eval_name_k --gpu_id 0 --cond_scale 2 --time_steps 10 --ext evaluation
```
* `--res_name`：`残差变换器`的模型名称。  
* `--name`：`掩码变换器`的模型名称。  
* `--cond_scale`：无分类器引导的比例。  
* `--time_steps`：推理的迭代次数。  
* `--ext`：保存评估结果的文件名。  
* `--which_epoch`：`掩码变换器`的检查点名称。

最终评估结果将保存在 `./checkpoints/<dataset_name>/<name>/eval/<ext>.log`

### 评估 LaMP-M2T：

```
python M2T_eval.py --exp-name Test_M2T --num-layers 9 --batch-size 1 --embed-dim-gpt 1024 --nb-code 512 --n-head-gpt 16 --block-size 51 --ff-rate 4 --drop-out-rate 0.1 --resume-pth your_own_vqvae --vq-name VQVAE --out-dir ./output --total-iter 150000 --lr-scheduler 75000 --lr 0.0001 --dataname t2m --down-t 2 --depth 3 --quantizer ema_reset --eval-iter 10000 --pkeep 0.5 --dilation-growth-rate 3 --vq-act relu --resume-trans your_own_m2t
```
LaMP-BertScore 指标的计算首先通过 LaMP-M2T 生成合成动作的文本描述，然后计算生成的描述与真实文本之间的 BertScore。

</details>

## 致谢

我们衷心感谢以下开源项目，代码基于这些工作：

[T2M-GPT](https://github.com/Mael-zys/T2M-GPT) 和 [MoMask](https://github.com/EricGuo5513/momask-codes/tree/main)。

## 许可协议
本代码遵循 [MIT 许可协议](https://github.com/gentlefress/LaMP/blob/main/LICENSE.md) 进行分发。

请注意，我们的代码依赖于其他库，包括 SMPL、SMPL-X、PyTorch3D，并使用各自拥有独立许可协议的数据集，这些协议也必须遵守。

### 其他
如有进一步问题，请联系 keycharon0122@gmail.com。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---