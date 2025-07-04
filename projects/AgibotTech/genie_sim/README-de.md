![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim Benchmark
Genie Sim ist das Simulations-Framework von AgiBot, das Entwicklern effiziente Datengenerierung und Evaluations-Benchmarks zur Beschleunigung der Entwicklung verkörperter Intelligenz bietet. Genie Sim hat eine umfassende Closed-Loop-Pipeline etabliert, die Trajektoriengenerierung, Modelltraining, Benchmarking und Validierung der Bereitstellung umfasst. Nutzer können die Leistungsfähigkeit von Algorithmen schnell validieren und Modelle mit dieser effizienten Simulations-Toolchain optimieren. Ob für einfache Greifaufgaben oder komplexe Langstreckenoperationen – Genie Sim bietet eine hochrealistische Simulationsumgebung und präzise Bewertungsmetriken, sodass Entwickler die Entwicklung und Iteration robotischer Technologien effizient abschließen können.

Genie Sim Benchmark, die Open-Source-Evaluationsversion von Genie Sim, ist darauf ausgelegt, präzise Leistungstests und Optimierungsunterstützung für verkörperte KI-Modelle zu bieten.

# 2. Merkmale
- Flexible und benutzerfreundliche Simulationskonfiguration und Schnittstelle
- Simulations-Benchmarks und Evaluationsaufgaben für mehr als 10 Manipulationsaufgaben
- Teleoperationsfähigkeit auf Basis von VR und Tastatur
- Aufzeichnung und Wiedergabe aller Gelenke und Endeffektor-Posen
- Über 550 hochrealistische und physikalisch genaue 3D-Simulationsumgebungen und Assets
- Standardisierte Bewertungsmetriken zur Quantifizierung der Leistung von verkörperten KI-Modellen
- Evaluierungsergebnisse erreichen weniger als 5% Sim-to-Real-Evaluierungsfehler auf dem GO-1 Modell
- Unterstützung des UniVLA-Baseline-Modells in der Simulationsevaluierung

# 3. Updates
- [25.06.2025] v2.1
  - 10 weitere Manipulationsaufgaben für die Agibot World Challenge 2025 hinzugefügt, einschließlich aller Simulations-Assets
  - Open-Source-synthetische Datensätze für 10 Manipulationsaufgaben auf Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - UniVLA-Policy integriert und Unterstützung für Modellinferenz-Simulationsevaluierung
  - IK-Solver-SDK aktualisiert, der IK-Lösungen für verschiedene Roboter unterstützt
  - Kommunikationsframework optimiert und Simulationslaufzeit um das 2-fache verbessert
  - Automatisches Bewertungsframework für komplexere Langstreckenaufgaben aktualisiert

# 4. Inhalt

## 4.1 Einführung
Simulations-Benchmarks für verkörperte Intelligenz in Genie Sim sind darauf ausgelegt, die Entwicklung von verkörperten KI-Modellen zu bewerten und voranzutreiben. Diese Benchmarks bieten realistische Umgebungen, vielfältige Aufgaben und standardisierte Metriken zur Messung der Leistung robotischer KI-Systeme, wodurch die Notwendigkeit teurer physischer Hardware und realer Tests reduziert, riskante und gefährliche Testszenarien vermieden und der Trainings- sowie Bewertungsprozess von KI-Agenten beschleunigt wird.

## 4.2 Erste Schritte
Bitte beachten Sie [diese Seite](https://agibot-world.com/sim-evaluation/docs/#/v2) für Installation, Benutzerhandbuch und API-Referenz

## 4.3 Support
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 TODO-Liste
- [x] Veröffentlichung weiterer Langzeit-Benchmark-Manipulationsaufgaben
- [x] Mehr Szenen und Assets für jede Benchmark-Aufgabe
- [x] Unterstützung des Agibot World Challenge Baseline-Modells
- [ ] Szenarien-Layout- und Manipulationstrajektorien-Generalisationstoolkit

## 4.5 FAQ
- Wie kann man den Isaac Sim Server herunterfahren, wenn Fehler auftreten und der Prozess nicht mehr reagiert?
  Beenden Sie den Prozess im Terminal mit `pkill -9 -f raise_standalone_sim`
- Wie wählt man verschiedene Render-Modi aus?
  Der Standard-Render-Modus ist `RaytracedLighting(RealTime)`. Für Aufgaben mit transparenten Objekten verwenden Sie `RealTimePathTracing(RealTime-2.0)` für die perspektivische Beziehung der Objekte

## 4.6 Lizenz und Zitation
Alle Daten und der Code in diesem Repository stehen unter der Mozilla Public License 2.0.
Bitte ziehen Sie in Betracht, unsere Arbeit wie unten gezeigt zu zitieren, falls sie Ihre Forschung unterstützt.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 Referenzen
1. PDDL Parser (2020). Version 1.1. [Quellcode]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Version 1.x.x [Quellcode]. https://github.com/StanfordVL/bddl
3. CUROBO [Quellcode]. https://github.com/NVlabs/curobo
4. Isaac Lab [Quellcode]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Quellcode]. https://github.com/StanfordVL/OmniGibson


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---