# Mamba：快速跨平台包管理器

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">mamba-org 组件</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">包管理器 <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">包服务器 <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` 是对 conda 包管理器的 C++ 重新实现。

- 使用多线程并行下载仓库数据和包文件
- 采用 libsolv 实现更快的依赖求解，该库是 Red Hat、Fedora 和 OpenSUSE 的 RPM 包管理器所采用的先进依赖库
- `mamba` 的核心部分以 C++ 实现，最大程度提升效率

同时，`mamba` 使用了与 `conda` 相同的命令行解析器、包安装和卸载代码以及事务校验流程，以实现尽可能高的兼容性。

`mamba` 是 [conda-forge](https://conda-forge.org/) 生态的一部分，该生态还包括开源的 `conda` 包服务器 `quetz`。

你可以阅读我们的[公告博客](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23)。

## micromamba

`micromamba` 是 `mamba` 的静态链接版本。

它可以作为独立可执行文件安装，无需任何依赖，非常适用于 CI/CD 流水线和容器化环境。

详见 [micromamba 文档](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html)。

## `mamba` 与 `micromamba` 的比较

应优先使用 `mamba` 的场景：

- 其他软件在同一环境中使用 `libmambapy` 或 `libmamba`。
- 场景需要对库进行常规更新（特别是出于安全考虑）。
- 环境关注减少依赖占用的磁盘空间。

应优先使用 `micromamba` 的场景：

- 需要依赖单一自包含可执行文件。
- 没有 miniforge 发行版。
- 运行时需求极低。

## 安装

请参考文档中的 [mamba 安装指南](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
和 [micromamba 安装指南](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html)。

## Mamba 与 Micromamba 的附加功能

`mamba` 和 `micromamba` 在原生 `conda` 基础上增加了一些功能。

### `repoquery`

为了高效查询仓库和包依赖关系，可以使用 `mamba repoquery` 或 `micromamba repoquery`。

详见 [repoquery 文档](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery)。

### 安装锁文件

`micromamba` 可用于安装由 [conda-lock](https://conda.github.io/conda-lock/) 生成的锁文件，无需安装 `conda-lock`。

只需使用 `micromamba create` 并带上 `-f` 选项，指定以
`-lock.yml` 或 `-lock.yaml` 结尾的环境锁文件，例如：

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba（setup-miniconda 替代品）

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) 是 [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) 的替代方案，使用 `micromamba`。

它可以显著缩短 CI 的设置时间，方式包括：

- 使用 `micromamba`，安装仅需约 1 秒。
- 缓存包下载。
- 缓存整个 `conda` 环境。

## 与 `conda` 的不同

虽然 `mamba` 和 `micromamba` 一般可以直接替换 `conda`，但仍有一些差异：

- `mamba` 和 `micromamba` 不支持修订版本（相关讨论见 <https://github.com/mamba-org/mamba/issues/803>）
- `mamba` 和 `micromamba` 会将 `MatchSpec` 字符串规范化为最简形式，而 `conda` 使用更详细的形式
  这可能导致 `conda env export` 和 `mamba env export` 输出略有不同。

## 开发环境安装

请参考[官方文档](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html)中的相关说明。

## API 和 ABI 稳定性

Mamba 项目采用 [语义化版本](https://semver.org/)，格式为 `MAJOR.MINOR.PATCH`。
我们会尽力保持用户端的稳定性，但也需要做一些重大更改以改进 Mamba 并减少技术债务。
后续版本的 Mamba 可能会给出更强的兼容性保证。

### `libmamba`（C++）

我们尚未发现 C++ API 的用户，因此保留改进空间。
对于 `libmamba`，_向后兼容_ 定义如下：

- _ABI 向后兼容_ 意味着你可以直接替换库二进制文件，无需用更新的头文件重新编译代码。
  行为表现将一致，除了 bug（希望会消失）和性能上的差异。
- _API 向后兼容_ 意味着你必须用新版本库代码重新编译，但无需更改代码，只需重新构建即可。
  只要你未使用被视为私有的声明（比如 `detail` 子命名空间）。
  行为表现将一致，除了 bug（希望会消失）和性能上的差异。
  当声明被弃用但未移除且仍可用时，我们也认为是向后兼容，因为仅在编译时的行为表现不同。

基于以上，`libmamba` 保证如下：

- `PATCH` 版本为 API 和 ABI 向后兼容；
- `MINOR` 版本对 `mamba/api` 内声明保持 API 向后兼容，
  其他地方的 API 及任意 ABI 可能发生变化；
- `MAJOR` 版本不做任何保证。

### `libmambapy`（Python）

对于 `libmambapy`，_API 向后兼容_ 意味着你的 Python 代码在不使用私有声明（如以下划线 `_` 开头的名称访问）时，可以在新版本 `libmambapy` 上正常运行。
行为表现将一致，除了 bug（希望会消失）和性能上的差异。
当声明被弃用但未移除且仍可用时，我们也认为是向后兼容，因为仅在启用 Python
`DeprecationWarning` 时有表现，这通常仅在开发时启用。

基于以上，`libmambapy` 保证如下：

- `PATCH` 版本为 API 向后兼容；
- `MINOR` 版本为 API 向后兼容；
- `MAJOR` 版本不做任何保证。

### `mamba` 和 `micromamba`（可执行文件）

对于可执行文件，_向后兼容_ 指可编程输入输出，即你的代码（包括 shell 脚本）可在新版本可执行文件上无需修改即可运行。
可编程输入/输出包括可执行文件名、命令行参数、配置文件、环境变量、JSON 命令行输出和生成文件。
不包括人类可读输出和错误信息，因此对于人类可读输出中的弃用警告不做保证。

基于以上，`mamba` 和 `micromamba` 保证如下：

- `PATCH` 版本向后兼容；
- `MINOR` 版本向后兼容；
- `MAJOR` 版本不做任何保证。

## 支持我们

仅支持并积极开发 `mamba` 和 `micromamba` 2.0 及以上版本。

`1.x` 分支仅用于修复如 CVE 等安全问题。

如有疑问，也可加入我们的 [QuantStack 聊天室](https://gitter.im/QuantStack/Lobby)
或 [Conda 频道](https://gitter.im/conda/conda)（请注意，本项目与 `conda` 或 Anaconda Inc. 官方无隶属关系）。

## 许可证

我们采用共享版权模式，允许所有贡献者保留其贡献的版权。

本软件遵循 BSD-3-Clause 许可证。详情见 [LICENSE](LICENSE) 文件。

---

### 双周开发会议

我们每两周举行一次视频会议，讨论近期工作进展，并相互交流反馈。

欢迎任何人参加，无论是想讨论话题还是只是旁听。

- 时间：[欧洲中部时间周二下午 4:00](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- 地点：[Mamba jitsi](https://meet.jit.si/mamba-org)
- 详情：[会议记录](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---