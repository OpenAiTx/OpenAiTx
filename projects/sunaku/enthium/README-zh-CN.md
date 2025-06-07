# Enthium - Engrammer 遇上 Hands Down Promethium

![我的 Glove80 键盘上 Enthium v7 的照片](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-photograph-Enthium.jpg
)

本项目对 [Engrammer] 和 [Hands Down Promethium] 键盘布局进行了改进，通过水平镜像恢复了与 [Arno's Engram 2.0] 布局（左手主键行为 CIEA，PF 与 WV 互换以更贴近 Engram）以及 [Dvorak] 布局（右手主键行 HTNS）的熟悉感，并在保留 Engrammer 布局精神的基础上优化了编程标点符号的位置，从而提升了其在键盘布局分析工具中的表现（见下文）。

值得注意的是，Engram/mer 与 Enthium 之间的差异极小，仅需大约 6 小时（分布在 2-3 天内，建议周五开始利用周末）即可完全切换，并在 [KeyBr] 训练中解锁所有字母。

另见：[我的博客]( https://sunaku.github.io/enthium-keyboard-layout.html )，记录了我开发此键盘布局时的一段“掉进兔子洞”的奇妙历程。

[Hands Down Promethium]: https://reddit.com/r/KeyboardLayouts/comments/1g66ivi
[Arno's Engram 2.0]:     https://engram.dev
[Engrammer]:             https://github.com/sunaku/engrammer
[Dvorak]:                https://www.dvzine.org
[KeyBr]:                 https://github.com/aradzie/keybr.com#readme

## 布局

      q y o u - x l d w z
    b c i e a , k h t n s v
      ' / = . ; j m g p f
                r

>![Enthium v7 在笔记本键盘上的渲染图。](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)
>![Enthium v7 在我的 Glove80 键盘上的渲染图。](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-diagram-Enthium.png
)

<!-- vim-markdown-toc GFM -->

* [设计原理](#rationale)
  * [差异：PF 和 WV](#deviation-pf-and-wv)
  * [差异：B 和 V](#deviation-b-and-v)
* [性能表现](#performance)
  * [Cyanophage 分析器](#cyanophage-analyzer)
  * [KeySolve 分析器](#keysolve-analyzer)
  * [Oxey's 分析器](#oxeys-analyzer)
  * [对比](#comparison)
* [安装](#installation)
  * [Linux 设置](#linux-setup)
  * [MacOS 设置](#macos-setup)
    * [安装](#installation-1)
    * [复杂映射](#complex-modification)
    * [卸载](#uninstallation)
* [许可证](#license)

<!-- vim-markdown-toc -->

## 设计原理

* Q 和 Z 被分置于不同的手上，以保持平衡和对称。

* B 和 V 被放置在主键行的最外侧小指键（CapsLock，Apostrophe），避免小手或[小指力量较弱]的人需要抬手去按。

* Apostrophe（撇号）被移到与 YOU 和 I 完全不同的手指上，可避免 `you'd` 和 `I'd` 这类同指二连。

* 逗号和分号被聚集在一起，便于 Vim 中循环 f/F/t/T 搜索，同时也对称了右手的 K 和 J。

* 尽管句号和逗号的 Shift 后符号 `>` 和 `<` 是反过来的，这种排列有助于减少横向拉伸二连，并在传统行错位键盘上纵向堆叠。

* 减号被放在食指（与逗号、句号、分号类似），统一了分隔词语/句子的标点责任，同时便于编程时频繁使用的 `_` 下划线，特别是在其位置顺应了左手食指自然伸展方向的行错位键盘上，减少了用力。

* 斜杠与句号排列，可便捷输入 `/.`、`./`、`../` 文件路径。

[weakened pinky fingers]: https://reddit.com/r/KeyboardLayouts/comments/1fy8nve/_/lqulnww/

### 差异：PF 和 WV

PF 与 WV 互换，以解决以下不便：

* WN 是一个阶梯上升的同指二连，我希望能下划而不是上划
* DW（2u 跳跃）在 Vim 中不像 Engram（两键相邻）那样方便
* FG（2u 跳跃）在 shell 后台作业（如 `bg`、`fg`）中不如 Engram 方便
* SW（半剪刀）内卷比起上伸（如 Engram）略显吃力
* FF（如单词 "stu*ff*"）小指在上排连敲两下稍感费劲

我原本并不想偏离 Hands Down Promethium 的标准布局（这个“Enthium”衍生本应只是简单的水平镜像和标点微调），但还是去键盘布局分析器 playgrounds 测试了 PF 与 WV 的互换对性能的影响——出乎意料的是，这一改动几乎不影响性能：

* Oxey's 分析器数据显示统计完全没有变化！
* KeySolve 分析器 FSB 从 0.14% 增至 0.37%，但其他指标反而更优：FSS 从 0.82% 降至 0.48%，HSB 从 6.05% 降至 5.64%，HSS 从 5.97% 降至 5.50%；其余保持一致。
* Cyanophage 分析器的总词努力值从 730.9 增至 735.9，其它统计保持不变！

我_非常高兴_这个实验成功了，因为它让实际使用更为舒适，也能进一步降低 Engrammer 用户切换到 Enthium 的门槛。:)

### 差异：B 和 V

B 和 V 从上排旋转到主键行两侧，目的是避免小手或[小指力量较弱]的人抬手。其原有位置则分配给英语中最少用的 Q 和 Z。

在 Cyanophage 分析器中，这一改动将小指/无名指剪刀二连从 0.49% 降至 0.35%（大幅下降！），2u 跳跃二连从 0.30% 降至 0.29%。其他分析器由于未完全考虑小指侧键，如每个分析器子标题顶部的说明，但 Oxey's 分析器显示 SFBs 从 0.829% 降至 0.818%。

## 性能表现

### [Cyanophage 分析器][cNT]

> **注意：** 该分析器目前仅支持将字母放在左拇指上，不能放在右拇指，因此分析时布局进行了水平镜像。镜像不影响结果。

![截图](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/cyanophage.png)

总体统计：
* 总词努力值：748.5
* 努力值：432.54

手指使用比例：
* 同指二连：0.55%
* 跳跃二连（2u）：0.29%
* 横向拉伸二连：0.23%
* 小指/无名指剪刀：0.34%

三连数据：
* 交替（alt）：37.45%
* 二连内卷：29.02%
* 二连外卷：14.67%
* 其他：8.28%
* 交替 SFS：5.10%
* 重定向：2.14%
* 内卷：1.71%
* 弱重定向：1.32%
* 外卷：0.31%

### [KeySolve 分析器](https://grassfedreeve.github.io/keysolve-web/)

> **注意：** 该分析器目前不支持在主键行外侧小指键（如 CapsLock 和撇号）放置字母，因此结果可能不够准确。例如，SFB 百分比这里假设 R B V 都由拇指打，而实际它们各在不同手指：R 右拇指，B 左小指，V 右小指。

![截图](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve1.png)
![截图](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve2.png)
![截图](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve3.png)

总体数据：

    BIGRAMS     SFB: 0.97%      LSB: 0.44%      HSB: 4.79%      FSB: 0.35%
    SKIPGRAMS   SFS: 6.99%      LSS: 0.92%      HSS: 4.66%      FSS: 0.38%
    TRIGRAMS    ALT: 41.24%     ROL: 40.71%     ONE: 2.47%      RED: 1.66%

手指分布：

    LEFT        LI: 13.91%      LM: 20.17%      LR: 8.70%       LP: 3.05%
    RIGHT       RI: 13.12%      RM: 14.59%      RR: 10.60%      RP: 7.94%
    TOTAL               LH: 45.83%                      RH: 54.17%

复制粘贴用自定义源码：

    q y o u - x l d w z
    c i e a , k h t n s
    ' / = . ; j m g p f
    r b v

### [Oxey's 分析器](https://oxey.dev/playground/index.html)

> **注意：** 该分析器目前不支持在主键行外侧小指键（如 CapsLock 和撇号）放置字母，因此结果可能不够准确。例如，SFB 百分比这里假设 B 和 V 由左拇指打，实际应分别由左小指和右小指负责。

![截图](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/oxey.png)

总体数据：
* Sfb:              0.811%
* Dsfb:             6.286%
* Lsb:              0.372%
* Inrolls:          29.442%
* Outrolls:         15.841%
* Total Rolls:      45.283%
* Onehands:         2.348%
* Alternates:       31.877%
* Alternates (sfs): 7.284%
* Total Alternates: 39.161%
* Redirects:        3.864%
* BadRedirects:     1.002%
* Total Redirects:  4.866%
* Other:            8.341%
* Invalid:          0.001%

手指分布：

    finger 0:   3.63%   finger 9:       8.60%
    finger 1:   9.08%   finger 8:       10.65%
    finger 2:   19.30%  finger 7:       14.56%
    finger 3:   13.28%  finger 6:       12.33%

    左手:   45.29%  右手:   46.14%
    左中:   1.384%  右中:   1.189%

    主键位使用率: 56.37%

各手指 Sfb%：

    finger 0:   0.011%  finger 9:       0.024%
    finger 1:   0.047%  finger 8:       0.100%
    finger 2:   0.122%  finger 7:       0.051%
    finger 3:   0.339%  finger 6:       0.114%

### 对比

> **注意：** Oxey's 分析器目前不支持在主键行外侧小指键（如 CapsLock 和撇号）放置字母，因此结果可能不够准确。例如，SFB 百分比这里假设 B 和 V 由左拇指打，实际应分别由左小指和右小指负责。建议参考 [Cyanophage 分析器的结果](#cyanophage-analyzer)，该分析器考虑了侧面小指键和一个拇指字母键。

[键盘布局社区][rKL] 通常推荐 [Pascal Getreuer 的指南和对比表][PGt] 作为探索布局的起点，你会发现 Enthium 是其中统计表现最优秀的布局之一：

* 0.811% SFBs —— 获🥈亚军，仅次于 Focal
* 0.372% LSBs —— 获🥇冠军，领先全表！
* 45.283% rolls —— 超越 Nerps、Gallium、MTGAP、Graphite、Dvorak、Halmak 等
* 4.866% redirects —— 优于 MTGAP、Sturdy、Recurva、APTv3、Canary、Colemak 等
* 2.80% 小指离位 _不含_ 侧键 —— 优于 Graphite、Canary、Gallium、MTGAP 等
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%)
* 5.35% 小指离位 _含_ 侧键 —— 优于 Engram、Halmak，仅次于其他布局
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%) + `B` (1.49%) + `V` (1.06%)

[rKL]: https://www.reddit.com/r/KeyboardLayouts/
[PGt]: https://getreuer.info/posts/keyboards/alt-layouts/index.html#which-alt-keyboard-layout-should-i-learn

为完整起见，我整理了[本布局及相关布局的全部统计数据](https://raw.githubusercontent.com/sunaku/enthium/main/stats/)：

[cNT]: https://cyanophage.github.io/playground.html?layout=zwdlx-uoyq%5Csnthk%2Caeicbfpgmj%3B.%3D%2F%27vr&mode=ergo&lan=english
[cPM]: https://cyanophage.github.io/playground.html?layout=fpdlx%3Buoybzsnthk%2Caeicqvwgmj-.%27%3D%2F%5Cr&mode=ergo&lan=english
[cNG]: https://cyanophage.github.io/playground.html?layout=byou%27%3Bldwvzciea%2C.htsnqgxjk-%2Frmfp%5C%5E&mode=ergo&lan=english
[cDV]: https://cyanophage.github.io/playground.html?layout=%27%2C.pyfgcrl%2Faoeuidhtns-%3Bqjkxbmwvz%5C%5E&mode=ergo&lan=english
[cCD]: https://cyanophage.github.io/playground.html?layout=qwfpbjluy%3B-arstgmneio%27zxcdvkh%2C.%2F%5C%5E&mode=ergo&lan=english

| 分析器   | 类别    | 指标                 | [Enthium][cNT] | [Promethium][cPM] | [Engrammer][cNG] | [Dvorak][cDV] | [Colemak-DH][cCD] |
|----------|---------|----------------------|----------------|-------------------|------------------|---------------|-------------------|
| Oxey's   | 二连    | SFB                  | 0.811%         | 0.868%            | 1.511%           | 2.779%        | 1.367%            |
| Oxey's   | 二连    | DSFB                 | 6.286%         | 6.761%            | 7.620%           | 6.979%        | 8.767%            |
| Oxey's   | 二连    | LSB                  | 0.372%         | 0.404%            | 0.671%           | 1.255%        | 1.975%            |
| Oxey's   | 三连    | Inrolls              | 29.442%        | 29.333%           | 28.273%          | 23.820%       | 25.173%           |
| Oxey's   | 三连    | Outrolls             | 15.841%        | 14.526%           | 14.050%          | 15.104%       | 20.940%           |
| Oxey's   | 三连    | Total Rolls          | 45.283%        | 43.858%           | 42.323%          | 38.924%       | 46.113%           |
| Oxey's   | 三连    | Onehands             | 2.348%         | 2.189%            | 2.146%           | 0.624%        | 2.484%            |
| Oxey's   | 三连    | Alternates           | 31.877%        | 33.770%           | 32.483%          | 35.769%       | 22.913%           |
| Oxey's   | 三连    | Alternates (SFS)     | 7.284%         | 8.205%            | 8.752%           | 8.787%        | 7.461%            |
| Oxey's   | 三连    | Total Alternates     | 39.161%        | 41.974%           | 41.235%          | 44.556%       | 30.375%           |
| Oxey's   | 三连    | Redirects            | 3.864%         | 2.273%            | 3.103%           | 2.639%        | 9.081%            |
| Oxey's   | 三连    | BadRedirects         | 1.002%         | 1.236%            | 1.386%           | 0.818%        | 1.498%            |
| Oxey's   | 三连    | Total Redirects      | 4.866%         | 3.509%            | 4.489%           | 3.458%        | 10.579%           |
| Oxey's   | 三连    | Other                | 8.341%         | 8.468%            | 9.806%           | 12.437%       | 9.202%            |
| Oxey's   | 三连    | Invalid              | 0.001%         | 0.001%            | 0.001%           | 0.001%        | 1.248%            |
| Oxey's   | 分布    | Finger 0             | 3.63%          | 9.56%             | 6.58%            | 8.50%         | 8.12%             |
| Oxey's   | 分布    | Finger 1             | 9.08%          | 10.65%            | 9.21%            | 8.72%         | 8.04%             |
| Oxey's   | 分布    | Finger 2             | 19.30%         | 14.56%            | 19.47%           | 12.99%        | 11.55%            |
| Oxey's   | 分布    | Finger 3             | 13.28%         | 12.33%            | 13.35%           | 14.95%        | 19.19%            |
| Oxey's   | 分布    | Finger 6             | 12.33%         | 13.28%            | 16.04%           | 16.33%        | 18.88%            |
| Oxey's   | 分布    | Finger 7             | 14.56%         | 19.77%            | 14.93%           | 13.73%        | 15.60%            |
| Oxey's   | 分布    | Finger 8             | 10.65%         | 9.01%             | 10.31%           | 13.84%        | 10.11%            |
| Oxey's   | 分布    | Finger 9             | 8.60%          | 4.62%             | 9.90%            | 10.59%        | 7.77%             |
| Oxey's   | 分布    | 左手                 | 45.29%         | 47.10%            | 48.61%           | 45.16%        | 46.89%            |
| Oxey's   | 分布    | 右手                 | 46.14%         | 46.68%            | 51.18%           | 54.49%        | 52.36%            |
| Oxey's   | 分布    | 左中                 | 1.384%         | 1.189%            | 1.765%           | 9.208%        | 4.592%            |
| Oxey's   | 分布    | 右中                 | 1.189%         | 1.384%            | 1.294%           | 7.257%        | 3.393%            |
| Oxey's   | 分布    | 主键位               | 56.37%         | 56.37%            | 56.37%           | 56.70%        | 62.31%            |
| Oxey's   | SFB%    | Finger 0             | 0.011%         | 0.028%            | 0.012%           | 0.020%        | 0.041%            |
| Oxey's   | SFB%    | Finger 1             | 0.047%         | 0.100%            | 0.089%           | 0.028%        | 0.047%            |
| Oxey's   | SFB%    | Finger 2             | 0.122%         | 0.051%            | 0.230%           | 0.253%        | 0.186%            |
| Oxey's   | SFB%    | Finger 3             | 0.339%         | 0.114%            | 0.591%           | 1.075%        | 0.219%            |
| Oxey's   | SFB%    | Finger 6             | 0.114%         | 0.339%            | 0.380%           | 0.433%        | 0.388%            |
| Oxey's   | SFB%    | Finger 7             | 0.051%         | 0.185%            | 0.053%           | 0.494%        | 0.341%            |
| Oxey's   | SFB%    | Finger 8             | 0.100%         | 0.040%            | 0.098%           | 0.256%        | 0.137%            |
| Oxey's   | SFB%    | Finger 9             | 0.024%         | 0.011%            | 0.058%           | 0.220%        | 0.007%            |
| KeySolve | 二连    | SFB                  | 0.97%          | 0.94%             | 1.56%            | 2.62%         | 1.49%             |
| KeySolve | 二连    | LSB                  | 0.44%          | 0.45%             | 0.98%            | 1.17%         | 2.21%             |
| KeySolve | 二连    | HSB                  | 4.79%          | 6.04%             | 3.02%            | 6.11%         | 5.93%             |
| KeySolve | 二连    | FSB                  | 0.35%          | 0.26%             | 0.30%            | 0.14%         | 0.37%             |
| KeySolve | 跳连    | SFS                  | 6.99%          | 7.02%             | 7.50%            | 7.00%         | 7.95%             |
| KeySolve | 跳连    | LSS                  | 0.92%          | 0.93%             | 1.34%            | 4.48%         | 1.75%             |
| KeySolve | 跳连    | HSS                  | 4.66%          | 6.11%             | 6.91%            | 8.56%         | 6.49%             |
| KeySolve | 跳连    | FSS                  | 0.38%          | 0.78%             | 0.81%            | 1.22%         | 0.78%             |
| KeySolve | 三连    | ALT                  | 41.24%         | 40.37%            | 39.59%           | 41.70%        | 27.58%            |
| KeySolve | 三连    | ROL                  | 40.71%         | 40.84%            | 39.35%           | 37.19%        | 42.78%            |
| KeySolve | 三连    | ONE                  | 2.47%          | 2.66%             | 2.65%            | 0.43%         | 2.45%             |
| KeySolve | 三连    | RED                  | 1.66%          | 1.78%             | 2.65%            | 2.25%         | 6.74%             |
| KeySolve | 分布    | LI                   | 13.91%         | 13.91%            | 13.91%           | 14.56%        | 18.82%            |
| KeySolve | 分布    | LM                   | 20.17%         | 20.92%            | 20.30%           | 13.96%        | 10.18%            |
| KeySolve | 分布    | LR                   | 8.70%          | 8.70%             | 8.83%            | 9.55%         | 7.83%             |
| KeySolve | 分布    | LP                   | 3.05%          | 3.64%             | 5.72%            | 8.24%         | 7.63%             |
| KeySolve | 分布    | RI                   | 13.12%         | 13.12%            | 16.52%           | 16.90%        | 20.00%            |
| KeySolve | 分布    | RM                   | 14.59%         | 14.59%            | 15.03%           | 13.35%        | 16.91%            |
| KeySolve | 分布    | RR                   | 10.60%         | 10.60%            | 10.08%           | 13.36%        | 10.46%            |
| KeySolve | 分布    | RP                   | 7.94%          | 8.95%             | 9.47%            | 10.08%        | 8.16%             |
| KeySolve | 总体    | LH                   | 45.83%         | 47.18%            | 48.75%           | 46.31%        | 44.46%            |
| KeySolve | 总体    | RH                   | 54.17%         | 52.82%            | 51.25%           | 53.69%        | 55.54%            |
| Cyanophage | 总结 | 总词努力值           | 748.5          | 732.3             | 899.8            | 1185.5        | 1048.2            |
| Cyanophage | 总结 | 努力值               | 432.54         | 398.07            | 457.44           | 769.78        | 535.05            |
| Cyanophage | 二连 | 同指二连             | 0.55%          | 0.58%             | 0.99%            | 1.87%         | 0.91%             |
| Cyanophage | 二连 | 跳跃二连（2u）       | 0.29%          | 0.36%             | 0.39%            | 0.45%         | 0.41%             |
| Cyanophage | 二连 | 横向拉伸二连         | 0.23%          | 0.24%             | 0.41%            | 0.80%         | 1.27%             |
| Cyanophage | 二连 | 小指/无名指剪刀      | 0.34%          | 0.42%             | 0.71%            | 0.40%         | 0.65%             |
| Cyanophage | 三连 | Alt                  | 37.45%         | 36.98%            | 35.62%           | 39.08%        | 25.43%            |
| Cyanophage | 三连 | Alt SFS              | 5.10%          | 5.27%             | 5.93%            | 5.85%         | 5.47%             |
| Cyanophage | 三连 | 内卷                 | 1.71%          | 1.37%             | 1.82%            | 0.86%         | 1.50%             |
| Cyanophage | 三连 | 外卷                 | 0.31%          | 0.11%             | 0.29%            | 0.27%         | 0.98%             |
| Cyanophage | 三连 | 二连内卷             | 29.02%         | 29.18%            | 28.14%           | 23.51%        | 25.18%            |
| Cyanophage | 三连 | 二连外卷             | 14.67%         | 14.56%            | 14.03%           | 15.14%        | 21.55%            |
| Cyanophage | 三连 | 重定向               | 2.14%          | 2.03%             | 3.05%            | 2.57%         | 9.22%             |
| Cyanophage | 三连 | 弱重定向             | 1.32%          | 1.30%             | 1.40%            | 0.28%         | 1.52%             |
| Cyanophage | 三连 | 其他                 | 8.28%          | 9.20%             | 9.72%            | 12.44%        | 9.17%             |

## 安装

### Linux 设置

>*图例:* QWERTY=白色；Engram=金色；Enthium=蓝/绿色；特殊=粉色。
>![该布局在行错位键盘上的渲染图。](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)

安装：

    cd linux/
    sudo make install
    echo 现在请重启你的图形界面会话。

激活：

    setxkbmap -layout us    -variant enthium         # 单一布局，无切换
    setxkbmap -layout us,us -variant enthium,basic   # 双布局切换

修复（例如系统 XKB 包升级后被还原时）：

    cd linux/
    sudo make reinstall
    echo 现在请重启你的图形界面会话。

卸载：

    cd linux/
    sudo make uninstall
    echo 现在请重启你的图形界面会话。

### MacOS 设置

#### 安装

要在 MacOS 上使用此布局，你需要安装 [Karabiner-Elements](https://karabiner-elements.pqrs.org/)。

你可以通过 [Homebrew](https://brew.sh/) 安装：

    brew install --cask karabiner-elements

或直接从 [Karabiner-Elements 官网](https://karabiner-elements.pqrs.org/) 下载。

下载完成后，按 [安装指南](https://karabiner-elements.pqrs.org/docs/getting-started/installation/) 操作即可。

#### 复杂映射

安装完成后，你可以通过 [复杂映射功能](https://karabiner-elements.pqrs.org/docs/manual/configuration/configure-complex-modifications/) 重新映射键位。

Enthium 复杂映射配置可在[这里](https://ke-complex-modifications.pqrs.org/?q=enthium)获取。

如需恢复基础布局，只需移除 Enthium 的复杂映射即可。

#### 卸载

* 使用 Brew：`brew uninstall --cask karabiner-elements`
* 手动：从应用程序文件夹删除 `Karabiner-Elements.app`。

## 许可证

遵循 [Arno's Engram 2.0] 键盘布局源码的相同条款发布：

> MIT 许可证
>
> 版权所有 2022 Ricard Figueroa <https://github.com/rfiga>  
> 版权所有 2021 Suraj Kurapati <https://github.com/sunaku>  
> 版权所有 2021 Arno Klein <https://github.com/binarybottle>  
>
> 特此免费授予任何获得本软件及相关文档文件（以下简称“软件”）副本的人无限制地处理本软件的权利，包括但不限于使用、复制、修改、合并、出版、分发、再许可和/或销售本软件的副本，并允许被提供本软件的人也这样做，条件是须包含上述版权声明和本许可声明在本软件的所有副本或重要部分中。
>
> 本软件是“按原样”提供的，不附带任何明示或暗示的保证，包括但不限于对适销性、特定用途适用性和非侵权的保证。在任何情况下，作者或版权持有人均不对因软件或软件的使用或其他交易而产生的任何索赔、损害或其他责任承担责任，无论是在合同、侵权或其他方面。

---------------------------------------------------------------------------
[Spare A Life]: https://sunaku.github.io/vegan-for-life.html
> 喜欢我的工作？👍 请[拯救一条生命]作为感谢！🐄🐖🐑🐔🐣🐟✨🙊✌  
> 为什么？为了💕伦理、🌎环境和💪健康；详见上方链接。🙇

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---