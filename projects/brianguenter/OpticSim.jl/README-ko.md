<p align="center">
  <a href="https://microsoft.github.io/OpticSim.jl/dev/">
    <img src=docs/src/assets/logo.svg height=128px style="text-align:center">
  </a>
</p>

# OpticSim.jl

<table>
<thead>
  <tr>
    <th>문서</th>
    <th>빌드 상태</th>
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

OpticSim.jl은 [Julia](https://julialang.org/) 패키지로 기하광학을 위한 도구입니다. OpticSim의 설계 목표 중 하나는 광학 시스템을 절차적으로 쉽게 생성할 수 있도록 하는 것입니다. Zemax, Code V 또는 기타 대화형 광학 설계 시스템과 달리 OpticSim.jl은 대화형 지원이 제한적입니다.

다양한 표면 유형을 지원하며, 이를 구성적 고체 기하학(CSG)을 통해 복잡한 3D 객체로 조합할 수 있습니다. AGFFileReader 패키지를 통해 상당한 분량의 광학 재료 카탈로그가 제공됩니다.
### 패키지 상태  
이 패키지는 현재 대대적인 재작성 작업 중에 있습니다. 최신 버전의 패키지는 아직 완전한 기능을 갖추지 못했습니다. 핵심 광선 추적 기능은 `OpticSim` 패키지에서 작동하지만, 유리 카탈로그 다운로드, 시각화 및 반복 구조 코드가 별도의 패키지인 `AGFFileReader`, `OpticSimVisualization`, `OpticSimRepeatingStructures`로 분리되었습니다. 마지막 두 패키지는 아직 완전한 기능을 갖추지 못했습니다.  
## 기여하기  

[![ColPrac: Contributor's Guide on Collaborative Practices for Community Packages](https://img.shields.io/badge/ColPrac-Contributor's%20Guide-blueviolet)](https://github.com/SciML/ColPrac)  

이 프로젝트는 기여와 제안을 환영합니다.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---