<p align="center">
  <a href="https://microsoft.github.io/OpticSim.jl/dev/">
    <img src=docs/src/assets/logo.svg height=128px style="text-align:center">
  </a>
</p>

# OpticSim.jl

<table>
<thead>
  <tr>
    <th>Documentación</th>
    <th>Estado de la compilación</th>
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

OpticSim.jl es un paquete de [Julia](https://julialang.org/) para óptica geométrica. Uno de los objetivos de diseño de OpticSim es facilitar la creación de sistemas ópticos de forma procedural. A diferencia de Zemax, Code V u otros sistemas interactivos de diseño óptico, OpticSim.jl tiene soporte limitado para la interactividad.

Se soporta una gran variedad de tipos de superficies, y estas pueden componerse en objetos 3D complejos mediante el uso de geometría sólida constructiva (CSG). Se proporciona un catálogo sustancial de materiales ópticos a través del paquete AGFFileReader.
### Estado del paquete  
Este paquete está actualmente en proceso de una reescritura significativa. Las versiones más recientes del paquete aún no tienen funcionalidad completa. El trazado de rayos principal funciona (en el paquete `OpticSim`), pero la descarga del catálogo de vidrio, la visualización y el código de estructuras repetitivas se han movido a paquetes separados: `AGFFileReader`, `OpticSimVisualization`, `OpticSimRepeatingStructures`. Los dos últimos paquetes aún no son completamente funcionales.  
## Contribuyendo  

[![ColPrac: Guía para colaboradores sobre prácticas colaborativas para paquetes comunitarios](https://img.shields.io/badge/ColPrac-Contributor's%20Guide-blueviolet)](https://github.com/SciML/ColPrac)  

Este proyecto recibe con gusto contribuciones y sugerencias.  




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---