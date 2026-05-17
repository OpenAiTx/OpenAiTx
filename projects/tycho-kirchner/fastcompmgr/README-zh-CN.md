# fastcompmgr

__fastcompmgr__ 是一个用于 X 的 _快速_ 合成器，是 __Compton__ 的早期版本的分支，
而 __Compton__ 又是 __xcompmgr-dana__ 的分支，后者又是 __xcompmgr__ 的分支。

我曾长期使用老牌的 xcompmgr，因为 compton 在移动/调整窗口大小或对网页进行动能滚动时
总感觉有些卡顿。测试了最新的 picom-10.2 后，情况似乎更糟（见下方基准测试）。
然而，xcompmgr 不会在 argb 窗口（例如某些终端）上绘制阴影，
且存在其他一些故障。这就是为什么我回到了 2011 年，
当时刚刚添加了这项功能，精心挑选了一些较新的 compton 提交，
以消除多余的段错误和内存泄漏，并基于性能分析使该版本更快。
例如，窗口移动和调整大小事件在事件数量上有限制，并以某种固定帧率渲染，
而滚动仍尽可能快地完成。遮挡的窗口不会被绘制，且大部分避免了内存分配/释放，
从而实现了更快的屏幕重绘。
缺点是，当前渐隐效果已损坏（我不使用它）。对此表示抱歉（;

## 基准测试
在我的 Dell Latitude E5570 上，窗口移动、调整大小和滚动
*感觉* 明显更快，同时也有一些数据支持这一观察。
在多个叠加的 chromium 窗口中，且没有窗口完全被遮挡的情况下，我 *手动* 执行了相关操作，
请注意该基准测试并不复杂。使用的触控板驱动为 `xserver-xorg-input-synaptics`，
支持动能滚动（谁要 Wayland？）。测得的 CPU 使用率如下：

| 合成器       | 移动  | 调整大小 | 滚动   |
| ------------- | ----- | ------- | ------ |
| fastcompmgr   | 6.7%  | 4.4%    | 1.5%   |
| xcompmgr      | 7.8%  | 4.9%    | 1.6%   |
| compton       | 26.4% | 6.8%    | 17.1%  |
| picom         | 29.3% | 8.1%    | 23.1%  |











工具使用了以下参数：
~~~
(v0.1) fastcompmgr -o 0.4 -r 12 -c -C
(v1.1.8 来自 Debian 11) xcompmgr -o 0.4 -r 12 -c -C
(v1 来自 Debian 11) compton --config /dev/null --backend xrender -o 0.4 -r 12 -c -C
(v10.2) picom --config /dev/null --backend xrender -o 0.4 -r 12 -c

# 使用以下命令计算平均值
$ fastcompmgr -o 0.4 -r 12 -c -C &  pid=$!; sleep 4; \
    top -b -n 20 -d 0.5 -p $pid | LC_ALL=C awk -v pid=$pid \
    '$1==PID {++PIDCOUNT} $1==pid && PIDCOUNT>1 {print $9}' |  \
    datamash mean 1; kill $pid
~~~



## 安装
如果你懒得动手，可以直接从[发布页面](https://github.com/tycho-kirchner/fastcompmgr/releases)下载二进制文件。

否则，请安装以下库的开发版本：
### 依赖项：

* libx11
* libxcomposite
* libxdamage
* libxfixes
* libxrender
* pkg-config
* make

构建方法：

~~~ bash
$ make
$ make install
~~~

## 使用方法

~~~ bash
$ fastcompmgr -o 0.4 -r 12 -c -C
~~~
所有选项（当前淡出功能不起作用）：
~~~
   -d 显示器
    要管理哪个显示器。
   -r 半径
    阴影的模糊半径。（默认 12）
   -o 透明度
    阴影的透明度。（默认 0.75）
   -l 左偏移
    阴影的左偏移。（默认 -15）
   -t 顶部偏移
    阴影的顶部偏移。（默认 -15）
   -m 透明度
    菜单的透明度。（默认 1.0）
   -c
    启用窗口的客户端阴影。
   -C
    避免在 dock/面板窗口上绘制阴影。
   -i 透明度
    非活动窗口的透明度。（0.1 - 1.0）
   -e 透明度
    窗口标题栏和边框的透明度。（0.1 - 1.0）
    --shadow-red 数值
    阴影的红色值（0.0 - 1.0，默认 0）。
    --shadow-green 数值
    阴影的绿色值（0.0 - 1.0，默认 0）。
    --shadow-blue 数值
    阴影的蓝色值（0.0 - 1.0，默认 0）。

~~~


## 许可证

xcompmgr 已被广泛使用。据我所知，这个
特定分支的传承大致如下：

* Keith Packard（原作者）
* Matthew Hawn
* ...
* Dana Jansens
* Christopher Jeffrey
* Tycho Kirchner

不包括期间数十个分叉该项目的人。

更多信息请参见许可证（LICENSE）。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-17

---