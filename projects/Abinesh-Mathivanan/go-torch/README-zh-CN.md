# go-torch 

go-torch 是一个用纯 Go 从零构建的开源深度学习框架。它提供了一个模块化、类似 PyTorch 的 API，用于构建和训练神经网络，配备了稳定的自动微分引擎。

邮件 - abineshmathivanan31@gmail.com 

博客 - https://abinesh-mathivanan.vercel.app/en/posts/post-5/


## 功能 
- **动态计算图**：张量跟踪其历史，允许在反向传播时自动计算梯度。
- 可扩展的模块系统（nn.Layer，nn.Sequential）：使用灵活的类似 Keras 的顺序 API 构建复杂的模型架构。
- 层和函数库：包括 Conv2D、Linear、MaxPooling2D、Flatten、ReLU、CrossEntropyLoss 和 SGD
- **实时 TUI 仪表盘**：批次损失和周期验证准确率的实时图表，内存使用（堆/总分配）、GC 周期和活跃 goroutine 的监控，以及类似 keras 的摘要。
- 优化性能：使用 BLAS、go-routines 和拓扑自动微分 + 梯度累积

<br/>

**TUI 仪表盘**

![alt text](https://raw.githubusercontent.com/Abinesh-Mathivanan/go-torch/main/dashboard.png)


<br>

## 待办事项
- [ ] 添加对 RNN、LSTM、Transformers 的支持
- [ ] 实现带有 Ga-lore 和 LORA 技术的 Adam，RMSProp 等...
- [ ] model.load() 和 model.save() 无需 gob
- [ ] 支持构建 Transformers

<br/>

## 先决条件 
- Go 1.18 或更高版本。
- 推荐安装系统级 BLAS 库以获得最佳性能，但非必需。
- 部分待办事项写在文件内部。使用 “better comments” 扩展以获得最佳体验。

<br/>

## 使用方法 

### 克隆仓库
```bash
git clone https://github.com/abinesh-mathivanan/go-torch.git
cd go-torch
``` 
### 安装依赖项
``` bash
go mod tidy
```

### 执行 
运行 mnist 训练文件以测试功能。 
```bash
go run ./cnn_benchmark/go_bench.go
```

<br>

## 基准测试

| 基准详情                                | 128x128      | 512x512     | 1024x1024    |
|:------------------------------------------|:-------------|:------------|:-------------|
| **矩阵乘法**                             | 510.33 µs    | 13.54 ms    | 130.50 ms    |
| 元素逐一相加                            | 71.72 µs     | 1.29 ms     | 4.13 ms      |
| 元素逐一相乘                            | 47.83 µs     | 1.63 ms     | 3.91 ms      |
| ReLU 激活                              | 121.18 µs    | 1.75 ms     | 6.45 ms      |
| **线性层前向传播 (B32,I128,O10)**         | 71.93 µs     |             |              |
| **交叉熵损失 (B32,C10)**                  | 11.16 µs     |             |              |
| **完整前后传播 (网络:128-256-10, B32)**    | 4.02 ms      |             |              |


<br>
<br>

[![Star History Chart](https://api.star-history.com/svg?repos=Abinesh-Mathivanan/go-torch&type=Date)](https://www.star-history.com/#Abinesh-Mathivanan/go-torch&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-26

---