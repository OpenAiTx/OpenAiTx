dwm.tmux
===
受[dwm](http://dwm.suckless.org/)启发的 Tmux 平铺窗格和窗口管理器。

![](https://raw.githubusercontent.com/saysjonathan/dwm.tmux/master/screenshot.png)

## 依赖
dwm.tmux 需要 tmux 版本 >= 3.2。

## 安装
### 通过 TPM（推荐）
添加到 `~/.tmux.conf`：

```sh
set -g @plugin 'saysjonathan/dwm.tmux'
```

重新加载并运行 `prefix-I` 以获取。

### 手动安装（传统方式）
要安装，请使用提供的 `Makefile`：

```sh
git clone https://github.com/saysjonathan/dwm.tmux.git
cd dwm.tmux
make
```
默认情况下，`dwm.tmux` 使用 `/usr/local` 作为其前缀。要更改前缀：


```sh
make PREFIX=$HOME
```

确保 `$PREFIX/bin` 在你的 `PATH` 中。

要使用，请加载 `dwm.tmux` tmux 配置：

```sh
echo 'source-file /usr/local/lib/dwm.tmux' >> $HOME/.tmux.conf
```
## 使用方法
`dwm.tmux` 定义了以下命令别名，每个都有默认快捷键绑定：

- `newpane` `Meta-n` 创建一个新窗格并将其放置在主窗格中
- `newpanecurdir` `Meta-w` 创建一个新窗格，起始目录与当前相同，并将其放置在主窗格中
- `killpane` `Meta-c` 关闭当前窗格。如果该窗格是主窗格，则关闭该窗格并将堆栈中的第一个窗格提升为主窗格
- `movepane[0-9]` `Meta-Shift-[0-9]` 将当前窗格移动到指定窗口
- `nextpane` `Meta-j` 选择下一个窗格（顺时针）；在单片模式下交换全屏窗格
- `prevpane` `Meta-k` 选择上一个窗格（逆时针）；在单片模式下交换全屏窗格
- `stackup` `Meta-J` 将聚焦窗格向上移动堆栈
- `stackdown` `Meta-K` 将聚焦窗格向下移动堆栈
- `rotateccw` `Meta-<` 逆时针旋转窗格
- `rotatecw` `Meta->` 顺时针旋转窗格
- `tile` `Meta-t` 返回平铺布局，退出单片模式（如果激活）
- `monocle` `Meta-Space` 切换单片模式（当前窗格全屏）
- `zoom` `Meta-Enter` 将选中窗格放置到主窗格中
- `decmfact` `Meta-h` 减小主窗格空间因子
- `incmfact` `Meta-l` 增大主窗格空间因子
- `window[0-9]` `Meta-[0-9]` 按 ID 选择目标窗口
- `newwindow` `Meta-N` 创建一个新窗口，起始目录与当前窗格相同
- `killwindow` `Meta-X` 删除当前活动窗口
- `popup` `Meta-p` 在当前窗格目录下显示一个浮动窗格弹出窗口
- `incpfact` `Meta-.` 相对于其他窗格，增加堆栈中聚焦窗格的大小
- `decpfact` `Meta-,` 相对于其他窗格，减少堆栈中聚焦窗格的大小
- `resetpfact` `Meta-=` 重置聚焦窗格的 pfact

还包括窗口切换的额外快捷键绑定：
- `Meta-[` 上一个窗口
- `Meta-]` 下一个窗口

还定义了调整行为的全局选项：

- `mfact` 主窗格空间因子，主窗格大小占窗口总大小的百分比
- `killlast` 如果值大于 `0`，即使是窗口中的最后一个窗格也会被关闭
- `monocle` 跟踪活动布局模式；0 为平铺，1 为单片。自动设置，但可读取以检查当前状态
- `pfact` 每个窗格的堆栈大小因子，范围 1-9，默认 5。值越大，该窗格在堆栈中占用的相对高度越大

### 自定义
快捷键绑定和默认值可以在配置文件中设置。使用 TPM 时，这些设置必须在 `~/.tmux.conf` 中的 `run '~/.tmux/plugins/tpm/tpm'` 语句之后进行。

示例：


```
setenv -g killlast 1 # kill pane even if it's the last
set-option -wg @mfact 60
set-option -wg @pfact 4
bind -n M-q killpane
bind -n M-w newpanecurdir
```

## 详情

类似于 dwm，窗口始终按以下方式组织：

```
 ====================================
|                 |        S1        |
|                 |==================
|      M(0)       |        S2        |
|                 |==================
|                 |        S3        |
 ====================================
```
屏幕左侧放置一个大型主面板，右侧放置一组较小的面板堆叠。主面板始终为面板0，而面板堆叠按顺序递增编号。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-03

---