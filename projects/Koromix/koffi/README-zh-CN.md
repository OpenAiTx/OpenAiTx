<a href="https://buymeacoffee.com/koromix" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

# 概述

Koffi 是一个快速且易于使用的 Node.js C FFI 模块，特点包括：

* 低开销且性能快速（参见 [基准测试](https://koffi.dev/benchmarks)）
* 支持原始和聚合数据类型（结构体和定长数组），既支持引用（指针）也支持值传递
* JavaScript 函数可以作为 C 回调使用（自 1.2.0 版本起）
* 针对流行的操作系统/架构组合进行了充分测试的代码库

目前，以下操作系统和架构组合 __已被官方支持和测试__：

ISA / OS           | Windows     | Linux    | macOS       | FreeBSD     | OpenBSD
------------------ | ----------- | -------- | ----------- | ----------- | --------
x86 (IA32) [^1]    | ✅ 是       | ✅ 是    | ⬜️ *不适用* | ✅ 是       | ✅ 是
x86_64 (AMD64)     | ✅ 是       | ✅ 是    | ✅ 是       | ✅ 是       | ✅ 是
ARM32 LE [^2]      | ⬜️ *不适用* | ✅ 是    | ⬜️ *不适用* | 🟨 可能     | 🟨 可能
ARM64 (AArch64) LE | ✅ 是       | ✅ 是    | ✅ 是       | ✅ 是       | 🟨 可能
RISC-V 64 [^3]     | ⬜️ *不适用* | ✅ 是    | ⬜️ *不适用* | 🟨 可能     | 🟨 可能

[^1]: 支持以下调用约定：cdecl，stdcall，MS fastcall，thiscall。
[^2]: 预编译二进制文件使用硬浮点 ABI，并期望有 VFP 协处理器。若需使用不同 ABI（softfp，soft），请从源码构建 Koffi。
[^3]: 预编译二进制文件使用 LP64D（双精度浮点）ABI。理论上如果从源码构建 Koffi，支持 LP64 ABI，但未测试。LP64F ABI 不支持。

更多信息请访问以下链接：

- 文档：https://koffi.dev/
- 更新日志：https://koffi.dev/changelog
- 源代码：https://codeberg.org/Koromix/rygel/ （详见下文说明）

# 源代码

本仓库不包含 Koffi 的代码，仅作为一个前端存在。出于实际原因，我从 2018 年开始使用一个单一仓库管理我的所有项目，因为这样更便于管理。

源代码可在此处获得：https://codeberg.org/Koromix/rygel/ （位于 *src/koffi* 子目录）。

单仓库对我来说有两个杀手级特性：

* 跨项目重构
* 简化的依赖管理

您可以在这里找到更详细的理由：https://danluu.com/monorepo/

# 手动构建

Koffi 使用一个名为 CNoke 的自定义 CMake 包装器构建，该包装器也存在于单一代码库中。不要尝试手动运行 CMake，因为它会失败。

请按照[文档化的构建说明](https://koffi.dev/contribute#build-from-source)从源码构建 Koffi。

# 许可证

本程序是自由软件：您可以根据 **MIT 许可证** 的条款重新分发和/或修改它。

更多信息请参见：https://choosealicense.com/licenses/mit/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-21

---