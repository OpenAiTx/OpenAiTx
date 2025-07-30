# Ventoy CPIO

Ventoy 的替代 ramdisk。

文档可见 [这里](https://github.com/fnr1r/ventoy-meta/tree/main/docs)
发布版可见 [这里](https://github.com/fnr1r/ventoy-cpio/releases)。

注意：这只是我尝试为 Ventoy 添加一个合理（-ish）构建系统的一小部分。
所有与 Ventoy 相关项目的索引见
[这里](https://github.com/fnr1r/ventoy-meta)。

## 目标

制作一个 Ventoy 的替代 ramdisk

- [?] 具有更合理的构建系统
- [x] 可启动的
- [ ] 功能上相同的  
  （即能做与上游相同的事情）
- [x] 更小的

### 非目标

- ❌ 与官方完全二进制相同的 ramdisk
  - 按照给出的说明编译完全相同的二进制几乎不可能，且毫无意义
  - 但用该项目构建的 ramdisk 应该是可重现的

### 可能的未来改动

- 去掉二进制文件的后缀（它们只是烦人且不一致）  
  （不需要上游改动）
- 将 ramdisk 分为 x86 32 位和 64 位  
  （需要 grub 方面改动）
- 清理 ramdisk 中的 shell 脚本  
  （不需要上游改动）

## 进展

可以启动，但某些功能可能无法正常工作。

### ventoy.cpio

100%，因为它实际上只是对一堆文件进行 xz 压缩。

大小比例：

- du - 1 (64 / 64)
- ls -l - 1 (62976 / 62976)

### ventoy_ARCH.cpio

约 75%

所有工具都在这里（大部分），以各种方式编译完成。现在剩下的就是优化。

大小比例（x86）：

- du - 0.8540245566166439 (2504 / 2932)
- ls -l - 0.8624375107740045 (2561536 / 2970112)

大小比例（arm64）：

- du - 0.8159806295399516 (1348 / 1652)
- ls -l - 0.8159490600363857 (1377792 / 1688576)

大小比例（mips64）：

- du - 0.9816849816849817 (1072 / 1092)
- ls -l - 0.981642955484167 (1095168 / 1115648)

### vtloopex.cpio

待办：添加此项

## 使用

### 构建



```sh
docker compose build
```

```sh
docker compose up
```

提示：

如果您不想每次重建容器时都重新下载归档文件，
请进入 `docker/base/{dietlibc,musl,toolchains}`，查看安装脚本
并手动使用 `wget` 下载文件。

您也可以运行此命令进入容器：

```sh
docker run -it --rm \
  -v ".:/build" \
  ventoy-cpio-builder:latest \
  bash
```
### 设置

一旦你获得了 `ventoy*.cpio` 文件：

1. 挂载 Ventoy USB 上的第二个分区
1. !!! 备份原始的 `ventoy*.cpio` 文件 !!!
1. 复制你想尝试的 cpio 文件。（提示：如果你不知道是哪一个，
  那很可能是 `ventoy_x86.cpio`）

## 小任务清单

- 使用较旧版本的 Linux 头文件进行构建以提高兼容性

## 备注

- [在 GCC 术语中](https://gcc.gnu.org/onlinedocs/gccint/Configure-Terms.html)：
  - 构建假设为 x86_64 *nix
  - 主机（用于 ventoy 安装工具）假设为 x86_64
  - 目标为 x86_64、i386、aarch64 和 mips64el



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---