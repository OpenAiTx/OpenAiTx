# Pokemon Red (RL 版)

![测试](https://github.com/thatguy11325/pokemonred_puffer/actions/workflows/workflow.yml/badge.svg)

该仓库设计为用于 Pokemon Red RL 开发的库。它包含一些不应在库环境中使用的便利函数，建议进行分叉。未来，这些便利函数将被迁移，以避免需要分叉。

## 快速开始

### 安装

安装该库，你可以选择

1. 将仓库克隆到本地机器并安装。
2. 分叉仓库并将你的分叉克隆到本地机器。

例如，

```sh
pip3 install -e . 
```

### 运行

以下命令在某些情况下使用默认参数。如果您不确定如何使用与此仓库关联的命令行操作，请运行 `python3 -m pokemonred_puffer.train --help`。部分命令可能近期未经过测试，如有问题请提出 issue。

安装完成后，您可以通过运行以下命令开始训练：

```sh
# Run before training to test what num_envs value you should use
python3 -m pokemonred_puffer.train autotune
# Default
python3 -m pokemonred_puffer.train train
```

### 多节点超参数搜索（进行中）

如果您想运行超参数搜索，可以通过安装相关软件包并启动两个命令来实现：

```sh
pip3 install -e '.[sweep]'
python3 -m pokemonred_puffer.sweep launch-sweep
python3 -m pokemonred_puffer.sweep launch-agent <sweep-id>
```
在启动扫描时会打印扫描ID。要恢复扫描，您可以重新启动您的扫描，使用  


```sh
python3 -m pokemonred_puffer.sweep launch-sweep --sweep-id <sweep-id>
```

扫描可以通过扫描配置（默认为 `sweep-config.yaml`）和基础配置（默认为 `config.yaml`）进行配置。超参数扫描使用扫描配置设置边界，并将超参数以基础配置中的参数为中心。要了解更多关于超参数算法的信息，可以访问 [Imbue 的 CARBS 仓库](https://github.com/imbue-ai/carbs/tree/main)。

注意：目前不支持单节点扫描。如果这是一个需要的功能，请提交问题。

### 训练时的修改

所以你已经有一个运行了，但你想对其进行调整，该怎么办？

你有几个选项：

1. 开始修改 `config.yaml` 中的参数
2. 直接开始修改代码（稍后详细介绍）。
3. 将此仓库作为库使用，并制作你自己的封装。

### 调试
如果你想测试你的更改，你可以运行 

```sh
python3 -m pokemonred_puffer.train --config config.yaml --debug
```
在紧急情况下，建议从 `environment.py` 中移除 `send_input` 函数调用，这样你可以按照自己的时间测试奖励，而不是模型的时间。

## 目录结构

该仓库最终旨在用作一个库。所有源文件应位于 `pokemonred_puffer` 目录下。如果你想添加带有 `__main__` 的模块，可以，但必须在 `pokemonred_puffer` 目录下。之后，你应该能够通过 `python3 -m pokemonred_puffer.<your-module>` 来运行你的主程序。

在 `pokemonred_puffer` 目录中，有以下文件和目录：

- `policies`：用于运行模型的不同策略目录。
- `rewards`：包含为 `RedGymEnv`（宝可梦红版的 gym 环境）对象跟踪奖励的 `gym.Env` 类的目录。
- `wrappers`：你可能想使用的包装器目录，例如，日志记录到 [Pokemon Red Map Visualizer](https://pwhiddy.github.io/pokerl-map-viz/)。
- `cleanrl_puffer.py` - 负责实际训练逻辑的运行。
- `environment.py` - 宝可梦红版 Gym 环境的核心逻辑。
- `eval.py` - 用于训练过程中生成日志可视化。
- `kanto_map_dsv.png` - 关东地区的高清地图。
- `train.py` - 启动训练的脚本和入口。

## 变更说明

对于简单的更改，你可以直接更新 `config.yaml`。`config.yaml` 有几个重要规则。对于 `wrappers`、`rewards` 和 `policies`，包装器、奖励或策略 _必须_ 以 `module_name.class_name` 作为键。这些部分可以包含多种类型的 `wrappers`、`rewards` 或 `policies`。其通用布局为 `label : 类的参数`。这是在找到更少间接性更好方法之前的暂用方案。

### 添加包装器

要添加包装器，在 `wrappers` 目录下添加一个继承自 `gym.Wrapper` 的新类。然后更新 `config.yaml` 中的 `wrappers` 部分。包装器按顺序从上到下包裹基础环境。包装器列表 _不是_ 以类路径为键，而是一个唯一名称，用于区分包装器集合。

### 添加奖励

要添加奖励，在 `rewards` 目录下添加一个新类。然后更新 `config.yaml` 中的 `rewards` 部分。奖励部分以类路径为键。

### 添加策略

要添加策略，在 `policies` 目录下添加一个新类。然后更新 `config.yaml` 中的 `policies` 部分。策略部分以类路径为键。假定循环策略将与它所包装的策略位于同一模块中。

## 开发

该仓库使用 [pre-commit](https://pre-commit.com/) 来强制执行格式和代码检查。开发时，请安装此仓库：


```sh
pip3 install -e '.[dev]'
pre-commit install
```
如有任何更改，请提交 PR。

## 作者

[David Rubinstein](https://github.com/drubinstein), [Keelan Donovan](https://github.com/leanke), [Daniel Addis](https://github.com/xinpw8), Kyoung Whan Choe, [Joseph Suarez](https://puffer.ai/), [Peter Whidden](https://peterwhidden.webflow.io/)

<a href="https://star-history.com/#drubinstein/pokemonred_puffer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date" />
 </picture>
</a>

[![](https://raw.githubusercontent.com/drubinstein/pokemonred_puffer/main/assets/puffer.png)](https://puffer.ai)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-26

---