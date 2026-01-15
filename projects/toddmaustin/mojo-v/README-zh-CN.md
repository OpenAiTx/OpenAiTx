<p align="center">
  <img src="https://raw.githubusercontent.com/toddmaustin/mojo-v/main/./docs/MojoV-logo1.png" alt="Mojo-V Logo" width="550"/>
</p>

# Mojo-V：面向RISC-V的秘密计算

**Mojo-V**（发音为*“mojo-five”*）是一种新的RISC-V扩展，旨在为RISC-V引入隐私导向的编程能力。Mojo-V实现了秘密计算，支持安全、高效且数据不可见的执行，无需依赖脆弱的软件和程序员信任。通过将敏感数据隔离在专用的秘密寄存器中，并在第三方密钥下对内存进行加密，Mojo-V防止信息泄露，并强制执行盲（无直接泄露）且静默（无侧信道泄露）的计算。该设计无缝集成到现有的RISC-V指令集架构，仅增加一个模式位和四条新指令，并完全在解码阶段强制执行。早期结果显示，Mojo-V几乎达到本地执行速度，同时相比完全同态加密（FHE）提供了超过5-7个数量级的性能提升，并且有明确的路线图以集成到CPU、GPU及专用加速器中。

了解更多...
- 这里有一个介绍Mojo-V的视频：https://www.youtube.com/watch?v=HUT46TcNyyM
- 介绍Mojo-V项目概览的幻灯片：https://drive.google.com/file/d/1VVzZqYHvQgnKMgXZjg7I_cX2GzF7awSN

当前Mojo-V ISA扩展规范（版本0.92）：
- [PDF格式。](https://drive.google.com/file/d/1pargKATFoQdy94i6bI3P_9mfNA_GsYSw)

联系Mojo-V开发者：
- 邮箱：[mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

# 🧩 Mojo-V参考平台 — 版本0.92发布

## 🚧 项目状态

Mojo-V参考平台版本0.92实现了使用固定对称密钥密码的秘密整数和浮点计算。Mojo-V支持三种加密模式：快速、强力和带证明载体。截止此版本，64位秘密计算已完全秘密化，该早期参考平台可用于软件开发和红队测试。未来版本将推出更多功能，包括PKI支持、LLVM编译器支持、32位RISC-V支持、VIP-Bench基准测试支持等。

**规范版本：** 0.92（2025年11月）  
**联系方式：** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

## 当前组件

1. **Mojo-V ISA规范 v0.92**  
   - 已发布于`doc/`目录  
2. **Spike（指令集模拟器）实现**  
   - Mojo-V集成到`riscv-isa-sim`，几乎功能完备  
   - 唯一缺失：公钥基础设施（PKI）支持（当前使用固定密钥及Simon-128密码）  
   - 启用Mojo-V扩展运行Spike时，请添加`--isa=rv64gc_zicond_zkmojov_zicntr`参数  
3. **Mojo-V Bringup-Bench基准测试**  
   - 手写示例（如冒泡排序）展示Mojo-V秘密计算功能  
   - 针对RV64GC+Mojo-V的完整安全测试套件

注意，Bringup-bench其余基准测试尚未移植到Mojo-V。

## ⚙️ 构建和运行 Mojo-V 参考平台

### A. 安装 RISC-V LLVM 编译器
您需要一个基于 LLVM 的 RISC-V 交叉编译器，能够生成 `RV64GC` 二进制文件。

这里是一个不错的起点：https://clang.llvm.org/get_started.html

### B. 克隆 Mojo-V 仓库
```bash
git clone https://github.com/toddmaustin/mojo-v.git
cd mojo-v
```

### C. 使用 Mojo-V 支持构建 RISC-V Spike 模拟器
```bash
sudo apt-get install device-tree-compiler libboost-regex-dev libboost-system-dev
cd riscv-isa-sim
mkdir build
cd build
../configure --prefix=$RISCV
make
```

### D. 构建并运行 Mojo-V Bringup-Bench 基准测试

1. **构建 Spike 设备驱动程序**

   ```bash
   cd bringup-bench/target
   make
   ```

2. **配置你的编译器**

   编辑 `../Makefile` 并为 `mojov` 目标设置 `TARGET_CC`，指向你的基于LVM的Clang RISC-V编译器的位置。

3. **构建并测试**

   ```bash
   cd ..                # go to the top-level bringup-bench directory
   make mojov-tests     # run all Mojo-V tests
   ```
作为替代方案，您可以进入相应基准测试的目录并运行以下命令来执行该基准测试。


   ```bash
   cd ../mojov-test
   make TARGET=mojov clean build test
   ```

## 🧪 Mojo-V Bringup-Bench 基准测试概览

| 程序 | 描述 |
|:---------|:-------------|
| `mojov-test` | 幻灯片中的入门示例 |
| `mojov-test1` | 秘密寄存器和加密内存语义测试 |
| `mojov-test2` | 手写数据不可知整数冒泡排序基准，使用 Mojo-V 快速加密 (int,fast) |
| `mojov-test3` | 手写数据不可知浮点冒泡排序基准，使用 Mojo-V 快速加密 (fp,fast) |
| `mojov-test4` | 手写数据不可知整数冒泡排序基准，使用 Mojo-V 强加密 (int,strong) |
| `mojov-test5` | 手写数据不可知浮点冒泡排序基准，使用 Mojo-V 强加密 (fp,strong) |
| `mojov-pctests` | 手写 RV64GC+Mojo-V 的完整性检查测试套件，包括 Mojo-V 证明携带加密格式的正负测试 (proofcarrying) |
| `mojov-sectests` | 手写 RV64GC+Mojo-V 的安全测试套件，包括 130 个正测试 + 245 个负测试，共计 375 个测试 (int,fp,fast,strong) |

所有测试基准都是手写汇编程序，展示 Mojo-V ISA 规则和安全语义。其他 Bringup-Bench 基准尚未移植到 Mojo-V。

---
## 代码许可
本仓库中所有 Mojo-V 相关代码均在其所修改工具的许可协议下发布（如 Spike、LLVM、Bringup-Bench）。详情请参阅各工具对应目录中的许可说明。

---

## 💬 问题与反馈
我们欢迎贡献、漏洞报告及建议！

📧 **邮箱：** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)  
🌐 **项目主页：** [https://github.com/toddmaustin/mojo-v](https://github.com/toddmaustin/mojo-v)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---