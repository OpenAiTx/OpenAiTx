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
Genie Sim is het simulatieframework van AgiBot, dat ontwikkelaars efficiënte mogelijkheden biedt voor het genereren van data en evaluatiebenchmarks om de ontwikkeling van belichaamde intelligentie te versnellen. Genie Sim heeft een uitgebreide gesloten-lus pipeline opgezet, die trajectgeneratie, modeltraining, benchmarking en validatie van implementatie omvat. Gebruikers kunnen snel de prestaties van algoritmen valideren en modellen optimaliseren via deze efficiënte simulatie-toolchain. Of het nu gaat om eenvoudige grijpacties of complexe langeafstandsbewerkingen, Genie Sim biedt een zeer realistische simulatieomgeving en nauwkeurige evaluatiemaatstaven, waardoor ontwikkelaars efficiënt de ontwikkeling en iteratie van roboticatechnologieën kunnen voltooien.

Genie Sim Benchmark, als de open-source evaluatieversie van Genie Sim, is toegewijd aan het bieden van nauwkeurige prestatietests en optimalisatie-ondersteuning voor belichaamde AI-modellen.

# 2. Functies
- Flexibele en gebruiksvriendelijke simulatieconfiguratie en interface
- Simulatiebenchmarks en evaluatietaken voor meer dan 10 manipulatieopdrachten
- Teleoperatie mogelijkheid gebaseerd op VR en toetsenbord
- Opname en afspelen van alle gewrichten en eind-effectorposities
- Meer dan 550 high-fidelity en fysiek nauwkeurige 3D-simulatieomgevingen en assets
- Gestandaardiseerde evaluatiemaatstaven om de prestaties van belichaamde AI-modellen te kwantificeren
- Evaluatieresultaten behalen minder dan 5% simulatie-naar-werkelijkheid evaluatiefout op het GO-1 model
- Ondersteunt UniVLA-basismodel in simulatie-evaluatie

# 3. Updates
- [25/6/2025] v2.1
  - Voeg 10 extra manipulatieopdrachten toe voor de Agibot World Challenge 2025 inclusief alle simulatie-assets
  - Open-source synthetische datasets voor 10 manipulatieopdrachten op Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - Integreer UniVLA-policy en ondersteun modelinference simulatie-evaluatie
  - Update IK solver sdk die cross-embodiment IK-oplossingen ondersteunt voor andere robots
  - Optimaliseer communicatieframework en verbeter de simulatiesnelheid met 2x
  - Update automatisch evaluatieframework voor meer complexe langeafstandstaken

# 4. Inhoud

## 4.1 Introductie
Belichaamde intelligentie simulatiebenchmarks in Genie Sim zijn ontworpen om de ontwikkeling van belichaamde AI-modellen te evalueren en te bevorderen. Deze benchmarks bieden realistische omgevingen, diverse taken en gestandaardiseerde maatstaven om de prestaties van robot-AI-systemen te meten, waardoor de behoefte aan dure fysieke hardware en testen in de echte wereld wordt verminderd, risicovolle en gevaarlijke testsituaties worden vermeden, en het trainings- en evaluatieproces van AI-agenten wordt versneld.

## 4.2 Aan de slag
Raadpleeg [deze pagina](https://agibot-world.com/sim-evaluation/docs/#/v2) voor installatie, gebruikershandleiding en API-referentie

## 4.3 Ondersteuning
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 TODO-lijst
- [x] Meer long-horizon benchmark manipulatie taken uitbrengen
- [x] Meer scènes en assets voor elke benchmarktaak
- [x] Ondersteuning voor Agibot World Challenge basismodel
- [ ] Scenario-indeling en generalisatietoolkit voor manipulatie-trajecten

## 4.5 Veelgestelde vragen (FAQ)
- Hoe sluit je de isaac sim server af als er fouten optreden waardoor het proces niet meer reageert?
  Beëindig het proces in de terminal met `pkill -9 -f raise_standalone_sim`
- Hoe kies je verschillende render-modi?
  De standaard render-modus is `RaytracedLighting(RealTime)`. Voor taken met transparante objecten, gebruik `RealTimePathTracing(RealTime-2.0)` voor het perspectief van objecten

## 4.6 Licentie en Citeren
Alle data en code in deze repository vallen onder de Mozilla Public License 2.0
Overweeg om ons werk als volgt te citeren als het nuttig is voor uw onderzoek.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 Referenties
1. PDDL Parser (2020). Versie 1.1. [Broncode]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Versie 1.x.x [Broncode]. https://github.com/StanfordVL/bddl
3. CUROBO [Broncode]. https://github.com/NVlabs/curobo
4. Isaac Lab [Broncode]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Broncode]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---