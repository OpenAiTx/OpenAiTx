# 偏差计
分析现实世界新闻，尝试以《命运石之门》中的术语估计当前世界的偏差值。
<div id="divergence-meter" style="cursor: pointer;">
  <img alt="数字 0" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="数字 1" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="数字 2" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="数字 3" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="数字 4" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="数字 5" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="数字 6" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="数字 7" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
</div>

- [网站](https://divergence.nyarchlinux.moe)
- [API 文档](https://divergence.nyarchlinux.moe/docs.html)
- [功能](#features)
- [截图](#screenshots)
- [世界线计算](#worldline-calculation)
- [Python 示例](https://github.com/FrancescoCaracciolo/DivergenceMeter/blob/main/src/client/client.py)
- [致谢](#credits)

## 功能

- <img alt="数字 0" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="5px" /> <img alt="数字 0" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="5px" /> 网站地址为 <a href="https://divergence.nyarchlinux.moe">https://divergence.nyarchlinux.moe</a>。
- 🔄 **自动更新**：计数器每15分钟自动更新一次
- 🗞 **新闻表**：查看我们的世界新闻如何影响时间线
- 📊 **图表**：显示世界线随时间的估计变化
- 🔉 **声音**：当世界线估计值变化时播放视觉小说中的声音
- 🪶 **精简模式**：<a href="https://divergence.nyarchlinux.moe/lite.html">提供精简模式</a>，不显示占用资源的图表
- 🛠 **免费且公开的API**：将我们的测量结果集成到您的项目中。创建自定义小部件、现实世界偏差计、应用程序等！  
偏差计每15分钟自动刷新一次。<a href="https://divergence.nyarchlinux.moe/docs.html">API 文档</a>
- ⏳ **分析间隔**：每15分钟分析当前世界新闻以估计当前世界线偏差

## 截图
**偏差计**
![image](https://github.com/user-attachments/assets/4dfacc07-6d5e-4e66-9450-ada057e17725)

**世界线状态报告**
![image](https://github.com/user-attachments/assets/2ee7c178-d182-4075-a9be-5e298bf83dbb)

**偏差图**
![image](https://github.com/user-attachments/assets/abe100b6-4d88-46de-838a-f2a8227be1aa)

## 世界线计算
在《命运石之门》中，偏差是通过世界线之间重力值的差异计算得出。
由于我没有“读取斯坦纳”（至少据我所知），也尚未穿越到任何世界线，世界线是通过
世界新闻**估算**得出的。新闻来自多个包含世界新闻、科学新闻和地方新闻的RSS源。

**剧透警告**：你将看到的方程基于对《混沌头》（Chaos;Head）中某些方程的解释。方程本身不是剧透，但搜索它们可能会导致对《混沌头》视觉小说的剧透。此外，其中一些概念可能对《命运石之门》视觉小说有轻微剧透。

**注意**：这里的一些理论是编造的，以使其与科学ADV系列保持一致。

#### 基础理论
**假设**：每个事件 $e$ 都有一个独立的偏差值 $d$。它是事件 $e$ 拥有最强吸引力的世界线。次要事件没有真正的吸引场，但会影响其他世界线。
例如，在《命运石之门》中，SERN的反乌托邦有一个独立偏差为0。世界线越接近0，越快达到那个结果。

#### 新闻分析
每条新闻记录了一个事件 $e$ 的发生。（新闻被发布本身也可以视为一个事件 $e$）。
每条新闻被归类到一个吸引场（例如 $\alpha$，$\beta$，...）中，基于它最可能属于哪个吸引场。同时，每条新闻赋予一个影响力 $Im$，表示该新闻对其吸引场的影响力，以及一个场吸引力 $Fa$，表示它距离吸引场中心的远近。

#### 独立偏差计算
1. 为了计算事件 $e$ 的独立偏差，我们从 $Ir2$ 方程开始：

$$Ir2 = fun^{10}*int^{40}$$

这是《混沌头》中导致世界分歧的基础方程。
在视觉小说中，这个方程的含义没有被解释（除了 Ir2 代表“眼睛是两个”这一点）。考虑到它与狄拉克海有关，可能的解释如下：
- $Ir$ 是真空区域的信息率。更高的信息率意味着更复杂、更动态的真空结构。
- $fun$ 是场的均匀度数。场的不均匀可能意味着更多的梯度、势能，从而有更多能量用于粒子生成和相互作用。
- $int$ 是狄拉克海状态的互联度。表示狄拉克海中负能态的关联或连接程度。

我们可以假设偏差 $d$ 是真空信息状态变化的结果，因为重力也受到影响。
因此，我们假设 $d \propto Ir$。存在一个常数 $k_1$ 使得：

$$d = k_1 * Ir2$$

2. 将给定的 $Ir2$ 表达式代入 $d$ 的定义：

  $$d = k_1 \cdot (fun^{10} * int^{40})$$

3. 现在，我们假设以下关系：
    *   **影响力 (`Im`) 和均匀度 (`fun`)：** 一个影响力很大的新闻事件 ($Im$) 会扰乱局部真空场，降低其均匀度 ($fun$)。我们可以将其建模为反比例关系：

        $$fun = \frac{C_f}{Im}$$

        其中 $C_f$ 是常数。
    *   **场吸引力 ($Fa$) 和互联度 ($int$)：** 强的吸引力 ($Fa$) 表明事件 $e$ 正在沿该方向在狄拉克海状态中创建有效通路，增加局部互联度 ($int$)。我们建模为正比例关系：

        $$int = C_i \cdot Fa$$

        其中 $C_i$ 是常数。

4. 将上述公式代入表达式
    将第3步中 $fun$ 和 $int$ 的表达式代入第2步中 $d$ 的公式：

    $$d = k_1 \cdot \left( \left( \frac{C_f}{Im} \right)^{10} \cdot (C_i \cdot Fa)^{40} \right)$$

5. 最后，我们合并常数，简化表达式：

    $$d = k_1 \cdot \left( \frac{C_f^{10}}{Im^{10}} \cdot C_i^{40} \cdot Fa^{40} \right)$$
    $$d = (k_1 \cdot C_f^{10} \cdot C_i^{40}) \cdot \frac{Fa^{40}}{Im^{10}}$$

6. 我们创建了一个新的常数，称为发散常数 $K_d = k_1 \cdot C_f^{10} \cdot C_i^{40}$
    计算独立发散度 $d$ 的最终公式为：
   
    $$d = K_d \frac{Fa^{40}}{Im^{10}}$$

#### 世界线更新
为了估计当前的世界线，我们必须在新闻到达时立即分析，并根据这些新闻的独立发散度更新当前发散度。
为此，使用了加权在线梯度下降的修改版本。

$$d(t) = d(t-1) - Im * \eta \nabla L(d(t-1))$$

## 致谢
- 感谢 [Steins;Gate Wiki](https://steins-gate.fandom.com/wiki/Steins;Gate_Wiki) 提供关于发散度的一些信息
- 感谢 [LuqueDaniel/Divergence-Meter](https://github.com/LuqueDaniel/Divergence-Meter/tree/master) 提供图片和动图
- 感谢 [SciAdv Series](https://wikipedia.org/wiki/Science_Adventure) 的卓越贡献

如果您想支持该项目，请留下一个 ⭐️

由 <a href="https://nyarchlinux.moe">Nyarch Linux</a> 主要开发者用 ❤️ 制作



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---