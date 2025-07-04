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
Genie Sim to framework symulacyjny firmy AgiBot, który zapewnia deweloperom wydajne możliwości generowania danych oraz benchmarki ewaluacyjne, przyspieszające rozwój inteligencji ucieleśnionej. Genie Sim ustanowił kompleksowy zamknięty cykl, obejmujący generowanie trajektorii, trening modeli, benchmarking i walidację wdrożenia. Użytkownicy mogą szybko weryfikować wydajność algorytmów i optymalizować modele dzięki wydajnemu łańcuchowi narzędzi symulacyjnych. Zarówno w przypadku prostych zadań chwytania, jak i złożonych operacji na dużą skalę, Genie Sim zapewnia bardzo realistyczne środowisko symulacyjne oraz precyzyjne metryki oceny, umożliwiając deweloperom efektywne ukończenie rozwoju i iteracji technologii robotycznych.

Genie Sim Benchmark, jako open-source'owa wersja ewaluacyjna Genie Sim, dedykowana jest do zapewnienia precyzyjnych testów wydajności oraz wsparcia optymalizacyjnego dla modeli AI ucieleśnionej.

# 2. Funkcje
- Elastyczna i przyjazna dla użytkownika konfiguracja symulacji oraz interfejs
- Benchmarki symulacyjne i zadania oceny dla ponad 10 zadań manipulacyjnych
- Możliwość teleoperacji oparta na VR oraz klawiaturze
- Rejestrowanie i odtwarzanie wszystkich przegubów oraz pozycji efektora końcowego
- Ponad 550 środowisk symulacyjnych 3D o wysokiej wierności i dokładności fizycznej oraz zasobów
- Standaryzowane metryki oceny do ilościowego określania wydajności modeli AI ucieleśnionej
- Wyniki ewaluacyjne osiągają mniej niż 5% błędu przejścia z symulacji do rzeczywistości na modelu GO-1
- Wsparcie dla modelu bazowego UniVLA w ewaluacji symulacyjnej

# 3. Aktualizacje
- [25.06.2025] v2.1
  - Dodano 10 kolejnych zadań manipulacyjnych na Agibot World Challenge 2025 wraz ze wszystkimi zasobami symulacyjnymi
  - Udostępniono open-source'owe syntetyczne zbiory danych dla 10 zadań manipulacyjnych na Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - Integracja polityki UniVLA oraz wsparcie dla ewaluacji symulacyjnej wnioskowania modelu
  - Aktualizacja SDK rozwiązywania IK, obsługującego rozwiązywanie IK dla różnych robotów
  - Optymalizacja frameworka komunikacyjnego i zwiększenie szybkości działania symulacji 2x
  - Aktualizacja automatycznego frameworka oceny dla bardziej złożonych zadań długozasięgowych

# 4. Zawartość

## 4.1 Wprowadzenie
Benchmarki symulacji inteligencji ucieleśnionej w Genie Sim zostały zaprojektowane do oceny i rozwoju modeli AI ucieleśnionej. Benchmarki te zapewniają realistyczne środowiska, różnorodne zadania i standaryzowane metryki do pomiaru wydajności systemów AI robotycznej, co ogranicza konieczność stosowania drogiego sprzętu fizycznego i testów w rzeczywistych warunkach, unika ryzykownych i niebezpiecznych scenariuszy oraz przyspiesza proces treningu i oceny agentów AI.

## 4.2 Pierwsze kroki
Proszę zapoznać się z [tą stroną](https://agibot-world.com/sim-evaluation/docs/#/v2) w celu instalacji, przewodnika użytkownika oraz referencji API

## 4.3 Wsparcie
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 Lista TODO
- [x] Wydanie większej liczby długoterminowych benchmarkowych zadań manipulacyjnych
- [x] Więcej scen i zasobów dla każdego zadania benchmarkowego
- [x] Wsparcie dla modelu bazowego Agibot World Challenge
- [ ] Narzędzie do generalizacji układu scenariusza i trajektorii manipulacji

## 4.5 FAQ
- Jak zamknąć serwer isaac sim gdy wystąpią błędy powodujące brak reakcji procesu?
  Zakończ proces w terminalu używając `pkill -9 -f raise_standalone_sim`
- Jak wybrać różne tryby renderowania?
  Domyślny tryb renderowania to `RaytracedLighting(RealTime)`. Dla zadań zawierających przezroczyste obiekty, użyj `RealTimePathTracing(RealTime-2.0)` dla poprawnego odwzorowania relacji perspektywicznych obiektów

## 4.6 Licencja i cytowanie
Wszystkie dane i kod w tym repozytorium objęte są licencją Mozilla Public License 2.0
Prosimy o rozważenie cytowania naszej pracy w poniższy sposób, jeśli była pomocna w Twoich badaniach.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 Referencje
1. PDDL Parser (2020). Wersja 1.1. [Kod źródłowy]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Wersja 1.x.x [Kod źródłowy]. https://github.com/StanfordVL/bddl
3. CUROBO [Kod źródłowy]. https://github.com/NVlabs/curobo
4. Isaac Lab [Kod źródłowy]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Kod źródłowy]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---