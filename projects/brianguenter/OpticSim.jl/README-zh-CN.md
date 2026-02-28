<p align="center">
  <a href="https://microsoft.github.io/OpticSim.jl/dev/">
    <img src=docs/src/assets/logo.svg height=128px style="text-align:center">
  </a>
</p>

# OpticSim.jl

<table>
<thead>
  <tr>
    <th>文档</th>
    <th>构建状态</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td>
      <a href="https://brianguenter.github.io/OpticSim.jl/stable/">
        <img src="https://img.shields.io/badge/docs-stable-blue.svg" alt="docs stable">
      </a>
      <a href="https://brianguenter.github.io/OpticSim.jl/dev/">
        <img src="https://img.shields.io/badge/docs-dev-blue.svg" alt="docs dev">
      </a>
    </td>
    <td>
      <a href="https://github.com/brianguenter/OpticSim.jl/actions/workflows/CI.yml">
        <img src="https://github.com/brianguenter/OpticSim.jl/workflows/CI/badge.svg" alt="CI action">
      </a>
      <a href="https://codecov.io/gh/brianguenterOpticSim.jl">
        <img src="https://codecov.io/gh/brianguenter/OpticSim.jl/branch/main/graph/badge.svg?token=9QxvIHt5F5" alt="codecov">
      </a>
    </td>
  </tr>
</tbody>
</table>

OpticSim.jl 是一个用于几何光学的 [Julia](https://julialang.org/) 包。OpticSim 的设计目标之一是使创建光学系统的过程化操作变得简单。与 Zemax、Code V 或其他交互式光学设计系统不同，OpticSim.jl 对交互性的支持有限。

支持多种表面类型，并且可以通过构造实体几何（CSG）将这些表面组合成复杂的三维对象。通过 AGFFileReader 包提供了大量的光学材料目录。

### 软件包状态
该软件包目前正在进行重大重写。软件包的最新版本尚未具备完整功能。核心光线追踪功能（在`OpticSim`软件包中）可用，但玻璃目录下载、可视化及重复结构代码已移至独立软件包：`AGFFileReader`、`OpticSimVisualization`、`OpticSimRepeatingStructures`。后两个软件包尚未完全功能化。
## 贡献

[![ColPrac: Contributor's Guide on Collaborative Practices for Community Packages](https://img.shields.io/badge/ColPrac-Contributor's%20Guide-blueviolet)](https://github.com/SciML/ColPrac)

本项目欢迎贡献和建议。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---