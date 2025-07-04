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
Genie Sim è il framework di simulazione di AgiBot, che offre agli sviluppatori capacità efficienti di generazione dati e benchmark di valutazione per accelerare lo sviluppo dell'intelligenza incarnata. Genie Sim ha istituito una pipeline chiusa completa, che comprende generazione di traiettorie, addestramento dei modelli, benchmarking e validazione del deployment. Gli utenti possono validare rapidamente le prestazioni degli algoritmi e ottimizzare i modelli tramite questa efficiente catena di strumenti di simulazione. Sia per compiti di presa semplici che per operazioni complesse a lungo raggio, Genie Sim può fornire un ambiente di simulazione altamente realistico e metriche di valutazione precise, consentendo agli sviluppatori di completare in modo efficiente lo sviluppo e l’iterazione delle tecnologie robotiche.

Genie Sim Benchmark, come versione open-source di valutazione di Genie Sim, è dedicato a fornire test di prestazioni precisi e supporto per l’ottimizzazione dei modelli di AI incarnata.

# 2. Caratteristiche
- Configurazione e interfaccia di simulazione flessibili e user-friendly
- Benchmark di simulazione e task di valutazione per oltre 10 task di manipolazione
- Capacità di teleoperazione basata su VR e tastiera
- Registrazione e replay di tutte le pose delle giunzioni e dell'end effector
- Oltre 550 ambienti e asset 3D ad alta fedeltà e accuratezza fisica
- Metriche di valutazione standardizzate per quantificare le prestazioni dei modelli di AI incarnata
- I risultati di valutazione raggiungono meno del 5% di errore sim-to-real sul modello GO-1
- Supporto al modello baseline UniVLA nella valutazione in simulazione

# 3. Aggiornamenti
- [25/6/2025] v2.1
  - Aggiunti 10 task di manipolazione per Agibot World Challenge 2025 inclusi tutti gli asset di simulazione
  - Dataset sintetici open-source per 10 task di manipolazione su Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - Integrazione della policy UniVLA e supporto per la valutazione in simulazione dell’inferenza del modello
  - Aggiornamento SDK del risolutore IK che supporta la risoluzione cross-embodiment IK per altri robot
  - Ottimizzazione del framework di comunicazione e miglioramento della velocità di simulazione di 2x
  - Aggiornamento del framework di valutazione automatica per task a lungo raggio più complessi

# 4. Contenuti

## 4.1 Introduzione
I benchmark di simulazione dell’intelligenza incarnata in Genie Sim sono progettati per valutare e far progredire lo sviluppo dei modelli di AI incarnata. Questi benchmark forniscono ambienti realistici, compiti diversificati e metriche standardizzate per misurare le prestazioni dei sistemi di AI robotica, riducendo la necessità di costosi hardware fisici e test nel mondo reale, evitando scenari di test rischiosi e pericolosi e accelerando il processo di addestramento e valutazione degli agenti AI.

## 4.2 Per iniziare
Si prega di consultare [questa pagina](https://agibot-world.com/sim-evaluation/docs/#/v2) per installazione, guida utente e riferimento API

## 4.3 Supporto
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 TODO List
- [x] Rilascio di ulteriori benchmark di manipolazione a lungo termine
- [x] Più scenari e asset per ogni task di benchmark
- [x] Supporto al modello baseline Agibot World Challenge
- [ ] Toolkit per la generalizzazione del layout degli scenari e delle traiettorie di manipolazione

## 4.5 FAQ
- Come spegnere il server isaac sim quando si verificano errori che causano il mancato riscontro del processo?
  Terminare il processo nel terminale usando `pkill -9 -f raise_standalone_sim`
- Come scegliere diverse modalità di rendering?
  La modalità di rendering predefinita è `RaytracedLighting(RealTime)`. Per i compiti che contengono oggetti trasparenti, utilizzare `RealTimePathTracing(RealTime-2.0)` per la relazione prospettica degli oggetti

## 4.6 Licenza e Citazione
Tutti i dati e il codice all'interno di questo repository sono sotto Mozilla Public License 2.0
Si prega di considerare di citare il nostro lavoro in uno dei modi seguenti se è utile alla vostra ricerca.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 Riferimenti
1. PDDL Parser (2020). Versione 1.1. [Codice sorgente]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Versione 1.x.x [Codice sorgente]. https://github.com/StanfordVL/bddl
3. CUROBO [Codice sorgente]. https://github.com/NVlabs/curobo
4. Isaac Lab [Codice sorgente]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Codice sorgente]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---