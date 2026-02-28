<p align="center">
  <a href="https://microsoft.github.io/OpticSim.jl/dev/">
    <img src=docs/src/assets/logo.svg height=128px style="text-align:center">
  </a>
</p>

# OpticSim.jl

<table>
<thead>
  <tr>
    <th>Documentation</th>
    <th>Statut de la compilation</th>
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

OpticSim.jl est un paquet [Julia](https://julialang.org/) pour l’optique géométrique. L’un des objectifs de conception d’OpticSim est de faciliter la création procédurale de systèmes optiques. Contrairement à Zemax, Code V, ou d’autres systèmes interactifs de conception optique, OpticSim.jl offre un support limité pour l’interactivité.

Une grande variété de types de surfaces est prise en charge, et ceux-ci peuvent être combinés en objets 3D complexes via l’utilisation de la géométrie solide constructive (CSG). Un catalogue substantiel de matériaux optiques est fourni via le paquet AGFFileReader.

### Statut du paquet
Ce paquet est actuellement en cours de réécriture majeure. Les dernières versions du paquet ne disposent pas encore de toutes les fonctionnalités. Le traçage de rayons de base fonctionne (dans le paquet `OpticSim`) mais le téléchargement du catalogue de verre, la visualisation et le code des structures répétitives ont été déplacés dans des paquets séparés : `AGFFileReader`, `OpticSimVisualization`, `OpticSimRepeatingStructures`. Les deux derniers paquets ne sont pas encore pleinement fonctionnels.
## Contribution

[![ColPrac : Guide du contributeur sur les pratiques collaboratives pour les paquets communautaires](https://img.shields.io/badge/ColPrac-Contributor's%20Guide-blueviolet)](https://github.com/SciML/ColPrac)

Ce projet accueille les contributions et les suggestions.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---