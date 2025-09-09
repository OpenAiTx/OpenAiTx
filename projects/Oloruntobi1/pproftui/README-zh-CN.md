# pproftui：在终端中交互式 Go 性能分析

`pproftui` 是一个基于终端的 Go `pprof` 用户界面，使性能分析变得交互式、直观且快速。它旨在帮助您定位性能问题，无需切换到网页浏览器，并提供内置的性能分析概念解释。

![演示](https://raw.githubusercontent.com/Oloruntobi1/pproftui/main/./demo.gif)

---

## 为什么选择 `pproftui`？

标准的 `go tool pprof` 功能强大，但有时不够直观。您常常会困惑：
*   "`flat` 和 `cum` 究竟是什么意思？"
*   "这 100 个运行时函数中，哪个是*我的*代码？"
*   "我如何查找这个版本与上一个版本之间的变化？"
*   "为什么我必须不停地在浏览器和代码之间切换？"

`pproftui` 直接解决了这些问题：
*   **集成源码和调用图视图：** 查看任意函数的源代码或浏览其调用图，无需离开终端。
*   **聚焦您的代码：** 自动高亮项目中的函数。按 `p` 键即可立即隐藏所有运行时和第三方库的噪音。
*   **强大且直观的差异比较：** 比较两个性能分析报告，不仅看到*发生了什么*变化，还能了解*为什么*变化。界面帮助您通过调用栈追踪性能回退的根源。
*   **实时性能分析：** 指向正在运行的服务，实时观察其性能分析更新。
*   **内置帮助（F1）：** 在需要时，获得关于性能分析术语（`cpu`、`inuse_space`、`flat` 与 `cum`）的清晰简明解释。

---

## 快速入门

### 安装
```sh
go install github.com/Oloruntobi1/pproftui@latest
```

### 食谱：常见的性能分析工作流程

这里是使用 `pproftui` 解决常见性能问题的实用方案。

#### 方案 1：调查本地二进制文件的性能下降
你发现某个函数运行缓慢。让我们获取一个 CPU 性能分析并进行探索。

1.  **生成性能分析数据：**
    ```sh
    go test -bench=. -cpuprofile=cpu.prof
    ```

2.  **使用 `pproftui` 进行分析：**
    ```sh
    pproftui cpu.prof
    ```
    *   按 `c` 在源代码视图和调用者/被调用者图之间切换。
    *   如果不确定分析类型的含义，随时按 `F1`。

#### 方案 2：查找性能回归（差异工作流）
你怀疑最近的提交使性能变慢了。`pproftui` 的差异比较是它的超级能力。

1.  **从你的 `main` 分支获取分析数据：**
    ```sh
    git checkout main
    go test -bench=. -cpuprofile=main.prof
    ```

2.  **从您的功能分支获取配置文件：**
    ```sh
    git checkout your-feature-branch
    go test -bench=. -cpuprofile=feature.prof
    ```

3.  **比较它们的差异：**
    ```sh
    pproftui main.prof feature.prof
    ```
    `pproftui` 现在将显示 *增量*。绿色（`+`）表示在 `feature.prof` 中使用了更多资源，红色（`-`）表示使用较少。使用此功能浏览图表，找到引入新开销的确切函数。

#### 配方3：分析实时服务性能
您希望查看您的应用程序在预发布环境负载下的表现。

1.  **确保您的应用程序暴露了 pprof 端点。**（例如，通过导入 `net/http/pprof`）
2.  **以实时模式运行 `pproftui`：**
    ```sh
    # This will fetch a 5-second CPU profile every 10 seconds.
    pproftui -live="http://localhost:6060/debug/pprof/profile?seconds=5" -refresh=10s
    ```
    *   按 `space` 键暂停和恢复实时更新。

#### 方案 4：切入噪音核心
分析报告充满了运行时和库代码。以下是如何专注于重要内容：**你的代码。**

```sh
# Provide your project's go module path
pproftui --module-path="github.com/your/project" cpu.prof
```
*   您项目的函数现在将标记为 `★`。
*   按 `p` 切换“仅项目”模式，立即隐藏其他所有内容。

---

## 快捷键

| 键           | 操作                                                  |
| :---------- | :---------------------------------------------------- |
| `↑`/`↓`     | 在函数列表中导航                                      |
| `t`         | 切换配置文件类型（`inuse_space`，`alloc_objects`）    |
| `c`         | 在**代码**视图和**调用**图视图之间切换                |
| `p`         | 切换**仅项目**代码过滤器                              |
| `s`         | 循环切换**排序**顺序（`Self`，`Total`，`Name`）       |
| `f`         | 切换**火焰图**视图                                    |
| `Enter`     | *在火焰图中：* 放大选中的函数                         |
| `Esc`       | *在火焰图中：* 缩小视图                              |
| `F1`        | 显示详细的**帮助**和说明                              |
| `q` / `ctrl+c`| **退出**                                            |


---

## 许可证

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---