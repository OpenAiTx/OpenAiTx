# SinGAN

[项目](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [补充材料](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [报告 (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### 论文官方 pytorch 实现：“SinGAN: Learning a Generative Model from a Single Natural Image”
#### ICCV 2019 最佳论文奖（Marr 奖）


## 来自*单张*图像的随机样本
使用 SinGAN，你可以从单张自然图像训练生成模型，然后从该图像生成随机样本，例如：

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## SinGAN 的应用
SinGAN 还可以用于一系列图像操作任务，例如：
![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
通过将一张图像注入已训练好的模型实现。更多细节请参见我们[论文](https://arxiv.org/pdf/1905.01164.pdf)的第4节。


### 引用
如果你在研究中使用了本代码，请引用我们的论文：

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## 代码

### 安装依赖项

```
python -m pip install -r requirements.txt
```

本代码在 python 3.6, torch 1.4 下测试通过

请注意：由于优化方案，目前代码仅支持 torch 1.4 或更早版本。

对于更高版本的 torch，可以尝试此仓库：https://github.com/kligvasser/SinGAN（结果不一定与官方实现完全一致）。


### 训练
要在自己的图像上训练 SinGAN 模型，请将所需训练图像放入 Input/Images 目录下，并运行

```
python main_train.py --input_name <input_file_name>
```

这还会利用训练好的模型，从最粗尺度（n=0）开始生成随机样本。

如需在 CPU 机器上运行代码，调用 `main_train.py` 时加上 `--not_cuda` 参数

### 随机样本
要从任意起始生成尺度生成随机样本，请先按上述方式在目标图像上训练 SinGAN 模型，然后运行

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

注意：如需使用完整模型，将生成起始尺度指定为 0；如需从第二个尺度开始，指定为 1，依此类推。

### 任意尺寸的随机样本
要生成任意尺寸的随机样本，请先按上述方式在目标图像上训练 SinGAN 模型，然后运行

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

### 单张图片生成动画

要从单张图片生成短动画，运行

```
python animation.py --input_name <input_file_name> 
```

这会自动用噪声填充模式开始新的训练阶段。

### 协调（Harmonization）

要将粘贴的对象协调到一张图片中（见我们[论文](https://arxiv.org/pdf/1905.01164.pdf)中图13的示例），请先按上述方式在目标背景图像上训练 SinGAN 模型，然后将简单粘贴的参考图像及其二值掩码保存在 "Input/Harmonization" 目录下（可参考已保存图片示例）。运行命令

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

请注意，不同注入尺度会产生不同的协调效果。最粗的注入尺度为 1。

### 编辑

要编辑图片（见我们[论文](https://arxiv.org/pdf/1905.01164.pdf)中图12的示例），请先按上述方式在目标未编辑图像上训练 SinGAN 模型，然后将简单编辑的图片作为参考图像保存在 "Input/Editing" 目录下，并配以相应的二值图（可参考已保存图片示例）。运行命令

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
掩码和非掩码的输出都会被保存。
同样，不同的注入尺度会产生不同的编辑效果。最粗的注入尺度为1。

### 画作转图像

要将一幅画作转换为逼真的图像（参见[我们的论文](https://arxiv.org/pdf/1905.01164.pdf)中的图11示例），请首先在目标图像上训练SinGAN模型（如上所述），然后将你的画作保存在 "Input/Paint" 文件夹下，并运行以下命令：

```
python paint2image.py --input_name <training_image_file_name> --ref_name <paint_image_file_name> --paint_start_scale <scale to inject>
```
同样，不同的注入尺度会产生不同的编辑效果。最粗的注入尺度为1。

高级选项：将 quantization_flag 指定为 True，仅对模型的注入层进行重新训练，以便对上一尺度上采样生成图像的颜色进行量化。对于某些图像，这可能会带来更真实的结果。

### 超分辨率
要对图像进行超分辨率处理，请运行：
```
python SR.py --input_name <LR_image_file_name>
```
这将自动训练一个与4倍上采样因子对应的SinGAN模型（如果尚未存在）。
如需不同的超分辨率因子，请在调用函数时通过参数 `--sr_factor` 指定。
SinGAN在BSD100数据集上的结果可在 'Downloads' 文件夹中下载。

## 附加数据和功能

### 单图像Fréchet Inception距离（SIFID分数）
要计算真实图像与其对应的生成样本之间的SIFID分数，请运行：
```
python SIFID/sifid_score.py --path2real <real images path> --path2fake <fake images path> 
```  
请确保每个生成图像的文件名与其对应的真实图像文件名完全相同。图像应以 `.jpg` 格式保存。

### 超分辨率结果
SinGAN在BSD100数据集上的超分辨率结果可在 'Downloads' 文件夹中下载。

### 用户研究
用于用户研究的数据可在 Downloads 文件夹中找到。

real 文件夹：50张真实图像，随机选自 [places database](http://places.csail.mit.edu/)

fake_high_variance 文件夹：对每张真实图像从 n=N 开始的随机样本

fake_mid_variance 文件夹：对每张真实图像从 n=N-1 开始的随机样本

更多细节请参见我们[论文](https://arxiv.org/pdf/1905.01164.pdf)的第3.1节。
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---