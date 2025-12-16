# 大树 Python 包

Python 的树结构实现及方法，集成了列表、字典、pandas 和 polars DataFrame。

它具有 Python 风格，易于学习并可扩展到多种工作流。

----

相关链接：
- [文档](https://bigtree.readthedocs.io/)
- [GitHub](https://github.com/kayjan/bigtree/)
- 社区
  - [问题](https://github.com/kayjan/bigtree/issues)
  / [讨论](https://github.com/kayjan/bigtree/discussions)
  / [更新日志](https://github.com/kayjan/bigtree/blob/master/CHANGELOG.md)
  / [贡献](https://bigtree.readthedocs.io/stable/home/contributing/)
- 包
  - [PyPI](https://pypi.org/project/bigtree/)
  / [Conda](https://anaconda.org/conda-forge/bigtree)
- 文章
  - [使用 BigTree 的 Python 树实现](https://medium.com/data-science/python-tree-implementation-with-bigtree-13cdabd77adc#245a-94ae81f0b3f1)
  - [Reingold-Tilford 算法讲解及演示](https://medium.com/data-science/reingold-tilford-algorithm-explained-with-walkthrough-be5810e8ed93?sk=2db8e10398cee76c486c4b06b0b33322)
- <div><p>如果你想支持 bigtree，<a href="https://www.buymeacoffee.com/kayjan"><img src="https://img.shields.io/badge/Buy_Me_A_Coffee-FFDD00?style=for-the-badge&logo=buy-me-a-coffee&logoColor=black" alt="Buy Me a Coffee" style="vertical-align:middle"></a></p></div>

-----

## 组件
Big Tree 由三部分组成：树（Tree）、二叉树（Binary Tree）和有向无环图（DAG）实现。

对于**树**的实现，有12个主要组件。

1. [**🌺 节点**](https://bigtree.readthedocs.io/stable/bigtree/node/node/)
   1. ``BaseNode``，可扩展类
   2. ``Node``，带节点名称属性的 BaseNode
2. [**🎄 树**](https://bigtree.readthedocs.io/stable/bigtree/tree/tree/)
   1. ``Tree``，Node 的包装器，提供构建、迭代、查询及导出整个树结构的高级 API
3. [**✨ 构建树**](https://bigtree.readthedocs.io/stable/bigtree/tree/construct/)
   1. 从 `Node`，使用父节点和子节点构造器
   2. 从 *str*，使用树形展示或 Newick 字符串表示法
   3. 从 *list*，使用路径或父子元组
   4. 从*嵌套字典*，使用路径-属性键值对或递归结构
   5. 从*pandas DataFrame*，使用路径或父子列
   6. 从*polars DataFrame*，使用路径或父子列
   7. 从*交互式UI*
   8. 使用路径字符串向现有树添加节点
   9. 使用*字典*、*pandas DataFrame*或*polars DataFrame*，通过路径向现有树添加节点和属性
   10. 使用*字典*、*pandas DataFrame*或*polars DataFrame*，通过节点名仅向现有树添加属性
4. [**➰ 遍历树**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. 先序遍历
   2. 后序遍历
   3. 层序遍历
   4. 层序分组遍历
   5. 之字形遍历
   6. 之字形分组遍历
5. [**🧩 解析树**](https://bigtree.readthedocs.io/stable/bigtree/tree/parsing/)
   1. 获取节点间的共同祖先
   2. 获取从一个节点到另一个节点的路径
6. [**📝 修改树**](https://bigtree.readthedocs.io/stable/bigtree/tree/modify/)
   1. 复制节点从某位置到目标位置
   2. 移动节点从某位置到目标位置
   3. 移动并替换节点从某位置到目标位置
   4. 从一棵树复制节点到另一棵树
   5. 复制并替换节点从一棵树到另一棵树
7. [**📌 查询树**](https://bigtree.readthedocs.io/stable/bigtree/tree/query/)
   1. 使用树查询语言过滤树
8. [**🔍 树搜索**](https://bigtree.readthedocs.io/stable/bigtree/tree/search/)
   1. 根据名称、部分路径、相对路径、属性值、用户定义条件查找多个节点
   2. 根据名称、部分路径、相对路径、完整路径、属性值、用户定义条件查找单个节点
   3. 根据用户定义条件查找多个子节点
   4. 根据名称、用户定义条件查找单个子节点
9. [**🔧 辅助函数**](https://bigtree.readthedocs.io/stable/bigtree/tree/helper/)
   1. 克隆树为另一种`Node`类型
   2. 获取子树（不同根的小树）
   3. 修剪树（相同根的小树）
   4. 获取两棵树之间的差异
10. [**📊 绘制树**](https://bigtree.readthedocs.io/stable/bigtree/utils/plot/)
   1. 增强Reingold-Tilford算法以获取树结构的(x, y)坐标
   2. 使用matplotlib绘制树（可选依赖）
11. [**🔨 导出树**](https://bigtree.readthedocs.io/stable/bigtree/tree/export/)
   1. 以垂直或水平方向打印到控制台
   2. 导出为 *Newick 字符串表示法*、*字典*、*嵌套字典*、*pandas DataFrame* 或 *polars DataFrame*
   3. 导出树为 *dot* 格式（可保存为 .dot、.png、.svg、.jpeg 文件）
   4. 导出树为 *Pillow*（可保存为 .png、.jpg）
   5. 导出树为 *Mermaid 流程图*（可在 .md 文件中显示）
   6. 导出树为 *Pyvis 网络*（可显示交互式 .html）
12. [**✔️ 工作流程**](https://bigtree.readthedocs.io/stable/bigtree/workflows/app_todo)
   1. 树演示的示例工作流程！

--------

对于 **二叉树** 实现，有 4 个主要组件。
二叉节点继承自节点，因此树实现中的组件在二叉树中也可用。

1. [**🌿 节点**](https://bigtree.readthedocs.io/stable/bigtree/node/binarynode)
   1. ``BinaryNode``，符合二叉树规则的节点
2. [**🎄 二叉树**](https://bigtree.readthedocs.io/stable/bigtree/binarytree/binarytree/)
   1. ``BinaryTree``，围绕 ``BinaryNode`` 的封装，提供构建、遍历、查询和导出整棵树的高级 API
3. [**✨ 构建二叉树**](https://bigtree.readthedocs.io/stable/bigtree/binarytree/construct/)
   1. 从 *列表* 构建，使用扁平化列表结构
4. [**➰ 遍历二叉树**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. 中序遍历

-----

对于 **有向无环图（DAG）** 实现，有 6 个主要组件。

1. [**🌼 节点**](https://bigtree.readthedocs.io/stable/bigtree/node/dagnode/)
   1. ``DAGNode``，用于构建有向无环图（DAG）的可扩展类
2. [**🎄 有向无环图**](https://bigtree.readthedocs.io/stable/bigtree/dag/dag/)
   1. ``DAG``，围绕 ``DAGNode`` 的封装，提供构建、导出和遍历整个 DAG 的高级 API
3. [**✨ 构建 DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/construct/)
   1. 从 *列表* 构建，包含父子元组
   2. 从 *嵌套字典* 构建
   3. 从 *pandas DataFrame* 构建
4. [**➰ 遍历 DAG**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. 通用遍历方法
5. [**🧩 解析 DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/parsing/)
   1. 获取从一个节点到另一个节点的可能路径
6. [**🔨 导出 DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/export/)
   1. 导出为 *列表*、*字典* 或 *pandas DataFrame*
   2. 将 DAG 导出为 *dot*（可以保存为 .dot、.png、.svg、.jpeg 文件）

-----

## 安装

`bigtree` 需要 Python 3.10 及以上版本。安装 `bigtree` 有两种方式，使用 pip（推荐）或 conda。

### a) 使用 pip 安装

#### 基本安装

要安装 `bigtree`，在命令提示符中运行以下命令：

```console
$ pip install bigtree
```

#### 安装可选依赖项

`bigtree` 有许多可选依赖项，可以使用 “extras” 语法安装。

```console
$ pip install 'bigtree[extra_1, extra_2]'
```
额外包的示例包括：

- `all`：包含所有可选依赖
- `image`：用于导出树为图片
- `matplotlib`：用于绘制树
- `pandas`：用于 pandas 方法
- `polars`：用于 polars 方法
- `query`：用于树查询方法
- `vis`：用于 pyvis 可视化

对于 `image` 额外依赖，您可能需要安装更多插件。


```console
$ brew install gprof2dot  # for MacOS
$ conda install graphviz  # for Windows
```

### b) 使用 conda 安装

要使用 conda 安装 `bigtree`，请在命令提示符中运行以下命令：

```console
$ conda install -c conda-forge bigtree
```

-----

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=kayjan/bigtree&type=Date)](https://star-history.com/#kayjan/bigtree&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---