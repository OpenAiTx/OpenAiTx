
# Detail Daemon
这是[Stable Diffusion Web UI](https://github.com/AUTOMATIC1111/stable-diffusion-webui)的一个扩展，允许用户在采样步骤中调整图像的细节/平滑度。

它不使用LORA、ControlNet等，因此其性能不会偏向任何特定风格，也不会在生成中引入新的风格或语义特征。这也意味着它可以与任何模型和任何类型的图像一起使用。

<sub>*模型：SSD-1B*<br></sub>
![a close up portrait of a cyberpunk knight-1Lv-0](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/561c33d9-9a5d-4cfc-bee8-de9126b280c1)
*左：细节较少，中间：原图，右：细节更多*<br>

<sub>*模型：SD 1.5（微调版）*<br></sub>
![face of a cute cat love heart symbol-Zn6-0](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/9fbfb39f-81fb-4951-8f32-20eab410020a)
*左：细节较少，中间：原图，右：细节更多*<br>


## 工作原理
Detail Daemon通过根据可自定义的时间表，在每个采样步骤中调整原始噪声水平来工作。

### 理论上
噪声水平（sigmas，即噪声的标准差）告诉模型在每个去噪步骤中应预期多少噪声并尝试去除。某一步骤的较高sigma值意味着模型将在该步骤更积极地去噪，反之亦然。

使用常见的sigmas时间表，sigmas在去噪过程开始时非常高，然后快速下降到中间的低值，最后趋向非常低的值。这个曲线（以及时间步长时间表，另一个话题）使得图像的较大特征（低频）在较早步骤被定义，而过程结束时只能看到较小特征（高频）的细微变化。稍后我们会详细讲。

现在，如果我们传递一个比原始值更低的sigmas时间表，模型在每一步的去噪会减少，导致该步骤输出的潜变量更嘈杂。但随后模型会尽力将这额外噪声转换为图像特征。因此理论上，*适度进行*时，这会产生更细节丰富的图像。如果推得太过，模型将无法处理每步增加的额外噪声，最终结果会退化成纯噪声。所以适度是关键。

### 但实际上
适度只能走到一定程度！还有，图中那些是啥？如下面例子所示，你不可能在图像中添加太多细节，否则它要么崩溃，要么变成完全不同的东西。

<sub>*SD 1.5*<br></sub>
![Modesty](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/2f011a28-0948-48f8-b171-350add6fdd67)
原始sigmas（左）乘以0.9、0.85、0.8<br>

<sub>*SDXL*<br></sub>
![1](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/eff2356e-a6dd-4a4e-9c7e-861dec7713eb)
原始sigmas（左）乘以0.95、0.9、0.85、0.875、0.8<br>

这是因为：
1. 我们不断添加噪声，而不给模型足够时间去处理
2. 我们操纵的是早期步骤，那时图像的低频特征（颜色、构图等）正在定义

### 时间表登场
我们通常所说的“细节”属于中高频范围，分别对应采样过程的中后期步骤。所以如果我们跳过早期步骤以保持图像主要特征完整，再跳过后期步骤给模型时间将额外噪声转化为有用细节，我们会得到类似这样的效果：

![3](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/cd47e882-8b56-4321-8c47-c0d689562780)

然后我们可以让时间表更复杂一些，针对不同大小细节的特定步骤：

![4](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/ea5027d2-3359-4733-afb4-5ae4a1218f38)

哪个步骤对应哪个精确频率范围取决于你使用的模型、采样器、提示词（特别是如果使用提示词编辑等），可能还有其他很多因素。时间表还可以做更复杂的操作，比如将sigmas推得很低以添加大量额外噪声，再推得很高以清理多余噪声并留下漂亮细节。因此，你需要不断调整，找出每张生成图像的最佳时间表，或者至少针对需要调整细节级别的图像这样做。理想情况下，你应该花费无数小时为每张图像雕刻完美的细节调整时间表，因为这正是我们存在的意义。

我很快会提供针对不同场景的具体示例和一些我总结的技巧。（给自己记个笔记：把这些搬到wiki页面）

## 安装
打开SD WebUI > 进入扩展标签页 > 进入可用扩展标签页 > 点击加载来源： > 找到Detail Daemon > 点击安装

或者进入从URL安装标签页 > 在第一个输入框粘贴本仓库URL > 点击安装

或者进入你的WebUI文件夹，手动将本仓库克隆到extensions文件夹：

`git clone "https://github.com/muerrilla/sd-webui-detail-daemon" extensions/sd-webui-detail-daemon`

## 入门
安装后，你可以在txt2img和img2img标签页中找到该扩展。
![2024-07-08 01_43_21-011366](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/045574cb-465c-4991-83c4-d02f803a330b)
### 滑块：
滑块（还有那个复选框）设置调整幅度（正值→增加细节，负值→减少细节）以及应用调整的采样步骤（即时间表）。图表的X轴是采样步骤，归一化到(0,1)范围，Y轴是调整幅度。其他部分应该很直观。只需拖动滑块，观察图表变化即可。
### 数字输入：
底部的三个数字输入框提供了滑块最大/最小值有时过于限制时的调整手段。
### 模式：
`cond`和`uncond`模式仅影响各自的潜变量，而`both`模式同时影响两者（废话！）。`cond`和`uncond`模式强度较低，且允许在较早步骤应用调整而不会偏离原始生成太远，因为另一个潜变量保持不变。

还有一个小变化：在`both`模式下，如果“细节量”是正值，cond和uncond潜变量都会变得更细节化。更细节的cond潜变量会推动生成更细节化，而更细节的uncond潜变量会推动更少细节。这导致该模式下图像中出现更多新的特征/伪影。

### 提示：
我会尽快写些正式文档说明如何最佳设置参数。目前你需要自行调试滑块，了解时间表形状如何影响图像。我建议将实时预览更新周期设置为每帧或隔帧更新，这样你可以清楚看到采样过程每一步发生了什么，Detail Daemon如何影响它，直到你完全掌握它的工作原理。

## 注意事项：
- 不支持组合扩散（即AND语法）正确工作。特别是当批量大小>1或提示词中有负权重，且模式设置为`cond`或`uncond`时。
- 可能无法使用或难以控制少步模型（Turbo、Lightning等）。编辑：可以控制。
- 支持Forge（不支持`cond`和`uncond`模式）。
- 不同于AlignYourSteps、FreeU等。
- 功能类似于Haoming的[ReSharpen Extension](https://github.com/Haoming02/sd-webui-resharpen)（目的相似，方法不同）。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---