# AlphaEarth 基础模型

Google DeepMind 的 AlphaEarth 地理空间基础模型的 PyTorch 实现，生成用于全球环境监测和分析的地球嵌入向量。
随论文附带了一个从2017年到2024年的全球嵌入数据集，可通过 Earth Engine 获取。这些嵌入的目标是作为一种高度通用的地理空间表示，适用于大量下游应用，无需重新训练。

> [!注意]
> 该模型仍在开发中，实际上并未在完整数据集上训练，它只是一个为论文架构提供通用基础的框架。代码相较于 DeepMind 的实际实现（JAX）更为简化。

### 方法论的关键部分

- **连续时间支持**：首个支持连续时间的地球观测特征化方法，允许时间插值和外推。
- **时空精度（STP）架构**：多分辨率编码器，包含空间（1/16L）、时间（1/8L）和精度（1/2L）算子——设计用于保持局部化表示，同时建模跨时空的远距离关系。
- **冯·米塞斯-费舍尔嵌入**：64字节嵌入，分布在单位球 S^63 上，非常紧凑的表示。

## 架构

### 时空精度（STP）编码器

STP 编码器通过三个同时进行的算子处理多时态、多源数据：
- **空间算子**：类似 ViT 的空间自注意力（1/16L 分辨率）
- **时间算子**：时间轴向自注意力（1/8L 分辨率）
- **精度算子**：3x3 卷积（1/2L 分辨率）

### 教师-学生-文本框架

1. **教师视频嵌入模型**：带隐式解码器的主模型
2. **学生视频嵌入模型**：与教师共享参数，用于对比学习
3. **文本对齐模型**：实现文本-图像对比学习

## 数据源

模型训练使用多种数据源，包括：
- **光学**：Sentinel-2，Landsat 8/9。*注意：为简化起见，我的实现仅支持 Sentinel-2，但添加新数据集进行训练相对简单。*
- **雷达**：Sentinel-1，PALSAR2
- **激光雷达**：GEDI
- **环境**：GLO-30，ERA5-Land，GRACE
- **注释/文本**：NLCD，维基百科



## 安装

```bash
# Clone the repository
git clone https://github.com/brayden-zhang/alphaearth-foundations.git
cd alphaearth-foundations

# Install dependencies
uv pip install -r requirements.txt

# Install the package 
uv pip install -e .
```

如何运行训练步骤：
```
python -m alphaearth.run_train
```

## 论文引用

```bibtex
@misc{brown2025alphaearthfoundationsembeddingfield,
      title={AlphaEarth Foundations: An embedding field model for accurate and efficient global mapping from sparse label data}, 
      author={Christopher F. Brown and Michal R. Kazmierski and Valerie J. Pasquarella and William J. Rucklidge and Masha Samsikova and Chenhui Zhang and Evan Shelhamer and Estefania Lahera and Olivia Wiles and Simon Ilyushchenko and Noel Gorelick and Lihui Lydia Zhang and Sophia Alj and Emily Schechter and Sean Askay and Oliver Guinan and Rebecca Moore and Alexis Boukouvalas and Pushmeet Kohli},
      year={2025},
      eprint={2507.22291},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2507.22291}, 
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-01

---