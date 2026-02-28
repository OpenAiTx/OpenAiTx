<p align="center">
  <a href="https://microsoft.github.io/OpticSim.jl/dev/">
    <img src=docs/src/assets/logo.svg height=128px style="text-align:center">
  </a>
</p>

# OpticSim.jl

<table>
<thead>
  <tr>
    <th>ドキュメント</th>
    <th>ビルド状況</th>
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

OpticSim.jlは[Julia](https://julialang.org/)の幾何光学向けパッケージです。OpticSimの設計目標の一つは、光学系を手続き的に簡単に作成できるようにすることです。Zemax、Code V、または他のインタラクティブな光学設計システムとは異なり、OpticSim.jlはインタラクティビティのサポートが限定的です。

多様な種類の面がサポートされており、これらは構成的ソリッドジオメトリ（CSG）を用いて複雑な3Dオブジェクトに組み合わせることができます。AGFFileReaderパッケージを通じて豊富な光学材料のカタログが提供されています。

### パッケージの状態
このパッケージは現在、大幅な書き換えが進行中です。パッケージの最新バージョンはまだ完全な機能を備えていません。コアのレイトレーシングは動作しています（パッケージ `OpticSim` 内）が、ガラスカタログのダウンロード、可視化、および繰り返し構造のコードは別のパッケージに移動されました：`AGFFileReader`、`OpticSimVisualization`、`OpticSimRepeatingStructures`。後者の2つのパッケージはまだ完全に機能していません。
## 貢献

[![ColPrac: コミュニティパッケージのための協働実践に関する貢献者ガイド](https://img.shields.io/badge/ColPrac-Contributor's%20Guide-blueviolet)](https://github.com/SciML/ColPrac)

このプロジェクトは貢献と提案を歓迎します。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---