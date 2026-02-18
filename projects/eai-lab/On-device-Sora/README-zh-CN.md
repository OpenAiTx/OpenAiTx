# [arXiv] On-device Sora：实现基于扩散的移动设备文本到视频生成

* 代码基于 [Open-Sora](https://github.com/hpcaitech/Open-Sora) 的实现

**论文**：https://arxiv.org/abs/2502.04363

[arXiv] On-device Sora：实现基于扩散的移动设备文本到视频生成的代码实现。
参考基础代码 ->
Open-Sora：为所有人民主化高效视频制作

## 介绍

本仓库提供了*On-device Sora*的代码，这是论文*On-device Sora: Enabling Diffusion-Based Text-to-Video Generation for Mobile Devices*的开源实现。

### On-Device Sora
*On-device Sora* 应用了线性比例跃迁（LPL）、时间维度令牌合并（TDTM）和动态加载并发推理（CI-DL），以实现 iPhone 15 Pro 上高效的视频生成。

![On-Device_Sora](https://raw.githubusercontent.com/eai-lab/On-device-Sora/main/./Figures/overview.jpg)

### Open-Sora

[Open-Sora](https://github.com/hpcaitech/Open-Sora) 是 On-Device Sora 的基线模型，一个视频生成开源项目，是一个能够基于文本输入生成视频的 T2V 扩散模型。

## 如何将每个模型转换为 On-device Sora 的 MLPackage

## 依赖包

### 依赖

```
cd Device_conversion

conda create -n convert python=3.10

conda activate convert

pip install -r requirements/requirements-convert.txt

pip install -v .
```

## 转换

### T5 转换
```
cd t5
python3 export-t5.py
```

### STDiT 覆盖
```
cd stdit3
python3 export-stdit3.py
```

### VAE转换
当你运行`export-vae-spatial.py`时，会出现`Fatal Python error: PyEval_SaveThread`错误。
为了解决此错误，你应该每次只运行一个VAE部分的代码块。将其余部分注释掉。

```
cd vae

# for vae's temporal part
python3 export-vae-temporal.py

# for vae's spatial part
python3 export-vae-spatial.py
```

## 使用方法

### 必需条件
* 用于 xcode 的 Mac 设备
* 用于构建和启动应用的 Apple 账号
* iPhone：iPhone 15 pro 及以上
* iOS 版本：18 及以上
* 所有 MLPackage（T5、STDiT、VAE）

### 下载已转换的 MLPackage（如果您不想将每个模型转换为 MLPackage）

您可以从以下链接下载并使用已转换的模型。[[下载](https://drive.google.com/drive/folders/1L6pVi3KmyLygR_pvKofRL-21adKsEb4p?usp=sharing)]

### 运行应用
* 通过点击 On-device/On-device-Sora.xcodeproj 实现 xcode 项目
* 在 TARGETS/Signing&Capabilities 中更改 Team（None -> 您的 Apple 账号）
* 启动应用
### 示例效果
![On-device-Sora-Example1](https://raw.githubusercontent.com/eai-lab/On-device-Sora/main/./Figures/On-device-Sora-Example1.gif)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-18

---