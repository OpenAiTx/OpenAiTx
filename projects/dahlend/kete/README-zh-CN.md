<p align="center">
<img src="https://github.com/dahlend/kete/blob/main/docs/_static/kete.svg" style="width:20%">
</p> 

# *Kete*

预测小行星和彗星的大规模轨道。

参见 [arXiv 论文](http://arxiv.org/abs/2509.04666)。

![Github Actions](https://github.com/dahlend/kete/actions/workflows/test-lint.yml/badge.svg?branch=main)
[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.15259732.svg)](https://doi.org/10.5281/zenodo.15259732)
[![arXiv](https://img.shields.io/badge/arXiv-2509.04666-00ff00.svg)](http://arxiv.org/abs/2509.04666)

kete 工具旨在实现对全天空小行星巡天的模拟。包括多体物理轨道动力学、轨道确定与拟合、天体的热学和光学建模，以及视场和光延迟校正。这些工具结合小行星中心（MPC）和 JPL 已知小行星数据库，不仅可用于规划巡天，也可用于预测现有或过去巡天中可见的天体。

kete 的主要目标是实现一套工具，能够一次性处理整个 MPC 目录，无需针对特定天体进行查询。它已被用于模拟 NEO Surveyor 任务超过 10 年的巡天时间，涵盖 1000 万颗主带和近地小行星。

[文档](https://dahlend.github.io/kete/)  
   - [示例](https://dahlend.github.io/kete/auto_examples/index.html)
   - [教程](https://dahlend.github.io/kete/tutorials/index.html)


https://github.com/user-attachments/assets/a48491d8-9c15-4659-9022-1767a3aa1e94

以下是 ZTF 巡天在整个 2023 年期间的模拟观测结果。
这是每个编号小行星的每个位置，以及预期的 V 波段星等计算。
如果预期星等低于 ZTF 针对特定帧报告的星等极限，则该天体将以浅灰色闪烁显示。

该计算在一台台式机上耗时约 50 分钟，生成动画约 40 分钟。










Kete 可用于回答许多问题，例如，识别[给定图像](https://dahlend.github.io/kete/tutorials/kona.html)中所有已知的小行星。

Kete 也可以作为更有趣的可视化的后端，例如：

[Ketev](https://dahlend.github.io/ketev/) - 浏览器中的太阳系可视化工具


## 安装

Kete 可以通过 pip 安装：



``` bash
pip install kete
```

## 代码示例

这里是一个展示使用kete编程的小示例。  
该示例计算了小行星阿波菲斯在2029年4月  
非常接近地球时的最近距离。

关于此示例的更深入解析可见  
[此处](https://dahlend.github.io/kete/auto_examples/plot_close_approach.html)。

```python

      import kete
      import numpy as np

      # Date of impact +- 1 day in Julian Date
      jd_center = kete.Time.from_ymd(2029, 4, 13.9066).jd

      # Step the orbit every 1 minute for +- 1 day.
      step_size = 1 / 24 / 60
      jd_range = np.arange(-1, 1, step_size) + jd_center

      # load Apophis from JPL Horizons
      obj = kete.HorizonsProperties.fetch("Apophis")
      cur_state = obj.state

      # keep track the the closest approach
      closest_approach = [np.inf, 0]
      for jd in jd_range:
            # propagate the object, and include the massive main belt asteroids
            cur_state = kete.propagate_n_body(cur_state, jd, include_asteroids=True)

            # calculate position relative to earth
            earth_vec = cur_state.pos - kete.spice.get_state("Earth", cur_state.jd).pos
            earth_dist = earth_vec.r * kete.constants.AU_KM
            if earth_dist < closest_approach[0]:
                  closest_approach = [earth_dist, cur_state.jd]

      print("Closest approach is on:")
      print(kete.Time(closest_approach[1]).iso)
      print(f"At a distance of about {closest_approach[0]:0.0f} km")
      #  Closest approach is on:
      #  2029-04-13T21:45:30.239+00:00
      #  At a distance of about 38015 km

```
## 名称

'Kete' 源自古希腊神话，意为海怪，是鲸目动物（鲸鱼）的词根。

## 许可：

该代码的最初版本由原作者（Dar Dahlen）在加州理工学院IPAC工作期间开发。本仓库是该代码的一个分支，后续工作将作为个人项目继续进行。本分支与之前代码的区别采用BSD 3-Clause许可，但版权归Dar Dahlen及未来合作者所有。

### 单位与参考系

Kete 使用ICRF参考系作为基础坐标系，单位为天文单位（AU），时间采用带有重心动力时间（TDB）标度的儒略日（JD）。内部此参考系转换为黄道坐标系，该坐标系由JPL Horizons使用的黄赤交角定义，采用J2000框架下的IAU76/80模型。

      - https://en.wikipedia.org/wiki/Axial_tilt#Short_term
      - https://ssd.jpl.nasa.gov/horizons/manual.html#defs

JPL Horizons和小行星中心（MPC）均使用该坐标系，本质上等同于J2000黄道坐标。kete提供转换工具，可实现到赤道坐标系及多种时间系统的转换。

### 缓存目录

kete中许多操作会下载各种文件。这些文件会自动缓存，缓存目录可通过设置环境变量 `KETE_CACHE_DIR` 来指定。默认目录为 `~/.kete/`。













``` bash
export KETE_CACHE_DIR="~/.kete/"
```

### 与容器一起使用 - Docker/Podman

请注意，kete 在首次使用时会下载多个大型 SPICE 内核文件，
并将其保存到缓存目录中。

**Docker/Podman 重要提示：**
- 如果你在 Docker 构建过程中触发下载（例如，
  `RUN python -c "import kete"`），这些文件将被打包进镜像。
- 如果跳过此步骤，文件将在首次容器运行时下载，
  但除非你为缓存目录使用卷挂载，否则
  **容器停止时文件将丢失**。

**推荐的 Dockerfile 方案：**
```dockerfile
RUN pip install kete && \
    python -c "import kete"  # Triggers kernel downloads during build
```
这确保了 SPICE 内核是您镜像的一部分，无需重新下载。

# 开发者信息：

以下信息面向开发者，普通用户无需关注。

## 安装 - 从源码编译

如果从源码编译 kete，必须先安装 Rust 编译器。安装说明请参见：

https://www.rust-lang.org/learn/get-started

确保您的 Python 是最新版本，本代码支持 Python 3.9 及以上版本。


``` bash
python --version
```
确保你的 pip 是最新版本，版本应至少为 `22.0.0`。

``` bash
pip --version
```

这可以通过以下方式更新：
``` bash
python -m pip install "pip>=22.0.0" --upgrade
pip install setuptools --upgrade
```

### 开发

如果您计划进行开发，建议按以下方式安装：
``` bash
pip install '.[dev]'
```
该行中的 `[dev]` 已通过 pip 安装了许多可选依赖项，这些依赖项
对于开发非常有用。包括 pytest 和文档工具。

### 构建文档

为了构建文档，需要一些额外的 Python 库。
这些可以通过以下命令安装：
``` bash
pip install sphinx sphinx_gallery autodoc
```
安装完成后，可以在kete目录内运行命令来构建文档。

``` bash
(cd docs && make html && open html/index.html&)
```
一旦运行完成，打开文件 `kete/docs/html/index.html` 以访问 HTML 文档。

要清理之前的文档构建：

``` bash
(cd docs && make clean)
```

文档测试可以通过以下方式运行：
``` bash
(cd docs && make doctest)
```

### 运行测试

运行测试需要安装 `pytest` 和 `pytest-cov` 包。

在该文件夹的根目录打开终端，运行以下命令：
``` bash
pytest --cov-report term-missing --cov=kete   
```
另一种覆盖率报告类型是 HTML，这将生成一个名为 `htmlcov` 的文件夹  
在运行命令的目录中，然后你可以打开 `htmlcov/index.html` 文件。  
这是代码覆盖率的用户友好网站表示。

``` bash
pytest --cov-report html --cov=kete   
```

### 运行教程

教程是计算量较大的示例，更能反映典型的预期使用情况。由于这些示例运行成本较高，除非手动执行，否则不会运行。  
提供了一个便捷的 Python 脚本来专门完成此操作。


``` bash
cd docs
python utils.py
```

### 运行基准测试

kete 的 Rust 后端中有一套微基准测试。运行这些测试需要安装
`gnuplot`，可以使用以下命令运行：

``` bash
cargo bench
open target/criterion/report/index.html
```
此外，还可以使用以下方法生成火焰图：


``` bash
cargo bench --bench propagation -- --profile-time=5
cargo bench --bench spice -- --profile-time=5
cargo bench --bench thermal -- --profile-time=5
```
这些火焰图将被放置在 `target/criterion/*/profile/flamegraph.svg` 中。打开
这些文件的网页浏览器将显示基准测试期间正在使用的函数。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-27

---