# RISC-V 向量基准测试

一组 RISC-V 向量（RVV）基准测试，帮助开发者编写可移植且高性能的 RVV 代码。

基准测试结果见：https://camel-cdr.github.io/rvv-bench-results

## 基准测试 ([./bench/](./bench/))

包含多个不同算法实现的基准测试集合。

## 指令周期计数 ([./instructions/](./instructions/))

通过展开并循环执行给定指令，测量 RVV 指令的周期计数。

## 入门指南

首先配置 [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk)，使 `make` 可用，且可选配置 [./run.sh](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./run.sh)，允许你通过 `make run` 编译并运行。

默认配置适用于所有近期的 clang 版本，无需完整的交叉编译工具链，因为它以 freestanding 模式构建。
这意味着它仅适用于 Linux 或兼容 Linux 系统调用的操作系统。

在近期的 Linux 版本中，性能计数器默认不开放，你可能需要执行 `echo 2 >/proc/sys/kernel/perf_user_access`，并在 [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk) 的 `CFLAGS=...` 行添加 `-DUSE_PERF_EVENT`（如果不行，尝试改为 `-DUSE_PERF_EVENT_SLOW`）。

你可以配置 [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk) 以构建托管版本或使用自定义工具链，添加 `-DCUSTOM_HOST` 宏定义，并在 [./nolibc.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./nolibc.h) 的 `#ifdef CUSTOM_HOST` 部分实现未实现的函数。

XTheadVector 已不再支持。

### 运行基准测试 ([./bench/](./bench/))

要运行基准测试，首先查看 ([./bench/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./bench/config.h)) 并根据你的处理器调整（例如设置 `HAS_E64`）。如果执行时间过长，尝试降低 `MAX_MEM`，该值用于缩放基准测试，并调整其他常量，直到执行时间合理且图表较平滑。

现在你可以在 ([./bench/](./bench/)) 目录下使用 `make run` 运行基准测试，或使用 `make` 仅构建可执行文件。

### 测量周期计数 ([./instructions/](./instructions/))

要运行周期计数测量，首先配置 [instructions/rvv/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/instructions/rvv/config.h) 以适配你的处理器。

现在你可以在 ([./instructions/rvv/](./instructions/rvv/)) 目录下使用 `make run` 运行测量，或使用 `make` 仅构建可执行文件。

XTheadVector 使用 ([./instructions/xtheadvector/](./instructions/xtheadvector/)) 目录（该部分已不再维护）。
## 贡献

以下是一些仍需完成的建议事项。

* 贡献一个新CPU的测量数据到：https://github.com/camel-cdr/rvv-bench-results \
  你只需创建一个包含所有拼接的 [./bench/](./bench/) 结果的单个json文件的issue。（在适当设置后，`make run > out.json` 应该可以完成此操作）。 \
* 实现非内存受限基准测试
* 实现更多基准测试
* 更好的周期计数测量：吞吐量与延迟（还有：我们能否弄清执行端口配置？）
* load/store的周期计数
* vsetvl的周期计数

## 许可证

本仓库采用MIT许可证，详见 [LICENSE](LICENSE)。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---