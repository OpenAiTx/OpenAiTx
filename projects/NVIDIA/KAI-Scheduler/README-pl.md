[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler to solidny, wydajny i skalowalny [harmonogram Kubernetes](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) optymalizujący alokację zasobów GPU dla obciążeń związanych ze sztuczną inteligencją i uczeniem maszynowym.

Zaprojektowany do zarządzania dużymi klastrami GPU, obejmującymi tysiące węzłów oraz dużą przepustowością obciążeń, czyni KAI Scheduler idealnym rozwiązaniem dla rozległych i wymagających środowisk.
KAI Scheduler umożliwia administratorom klastrów Kubernetes dynamiczną alokację zasobów GPU do obciążeń.

KAI Scheduler obsługuje cały cykl życia AI, od małych, interaktywnych zadań wymagających minimalnych zasobów, po duże zadania treningowe i wnioskowania — wszystko w ramach jednego klastra.
Zapewnia optymalną alokację zasobów, jednocześnie utrzymując sprawiedliwość zasobów pomiędzy różnymi konsumentami.
Może działać równolegle z innymi harmonogramami zainstalowanymi w klastrze.

## Kluczowe funkcje
* [Harmonogram wsadowy](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md): Zapewnij, że wszystkie pody w grupie zostaną zaplanowane jednocześnie lub wcale.
* Upakowywanie binarne i rozproszone planowanie: Optymalizuj wykorzystanie węzłów poprzez minimalizowanie fragmentacji (bin-packing) lub zwiększanie odporności i równoważenia obciążenia (spread scheduling).
* [Priorytet obciążeń](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md): Efektywnie priorytetyzuj obciążenia w kolejkach.
* [Hierarchiczne kolejki](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md): Zarządzaj obciążeniami za pomocą dwupoziomowej hierarchii kolejek zapewniającej elastyczną kontrolę organizacyjną.
* [Dystrybucja zasobów](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm): Dostosuj limity, wagi ponadlimitu, limity oraz priorytety dla każdej kolejki.
* [Polityki sprawiedliwości](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies): Zapewnij sprawiedliwy podział zasobów, korzystając z Dominant Resource Fairness (DRF) oraz odzyskiwania zasobów między kolejkami.
* Konsolidacja obciążeń: Inteligentnie przenoś uruchomione obciążenia, by zmniejszyć fragmentację i zwiększyć wykorzystanie klastra.
* [Elastyczne obciążenia](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md): Dynamicznie skaluj obciążenia w określonym zakresie liczby podów.
* Dynamic Allocation of Resources (DRA): Obsługa zasobów sprzętowych specyficznych dla dostawcy za pomocą Kubernetes ResourceClaims (np. GPU od NVIDIA lub AMD).
* [Współdzielenie GPU](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md): Pozwól wielu obciążeniom efektywnie współdzielić jedną lub wiele kart GPU, maksymalizując wykorzystanie zasobów.
* Obsługa chmury i środowisk lokalnych: Pełna kompatybilność z dynamicznymi infrastrukturami chmurowymi (w tym auto-skalery jak Karpenter) oraz statycznymi wdrożeniami on-premise.

## Wymagania wstępne
Przed instalacją KAI Scheduler upewnij się, że masz:

- Działający klaster Kubernetes
- Zainstalowany [Helm](https://helm.sh/docs/intro/install) CLI
- Zainstalowany [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator), aby planować obciążenia wymagające zasobów GPU

## Instalacja
KAI Scheduler zostanie zainstalowany w przestrzeni nazw `kai-scheduler`. Podczas zgłaszania obciążeń upewnij się, że używasz dedykowanej przestrzeni nazw.

### Metody instalacji
KAI Scheduler można zainstalować:

- **Z produkcji (zalecane)**
- **Ze źródła (samodzielna kompilacja)**

#### Instalacja z produkcji
Znajdź najnowszą wersję w sekcji [releases](https://github.com/NVIDIA/KAI-Scheduler/releases).
Uruchom poniższe polecenie, zamieniając `<VERSION>` na żądaną wersję wydania:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Kompilacja ze źródła
Postępuj zgodnie z instrukcjami [tutaj](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md)

## Szybki start
Aby rozpocząć planowanie obciążeń z KAI Scheduler, przejdź do [przykładu szybkiego startu](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md)

## Plan działania (Roadmap)

### Najważniejsze priorytety na 2025
* Refaktoryzacja kodu w celu zwiększenia neutralności względem dostawców
* Wsparcie dla Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Badanie integracji z Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Dodanie wsparcia dla Topology Aware Scheduling dla pod-group https://github.com/NVIDIA/KAI-Scheduler/issues/66
* Obsługa minimalnego czasu działania na obciążenie
* Obsługa maksymalnego czasu działania na obciążenie (z opóźnionym ponownym wstawieniem do kolejki)
* Dodanie większej liczby PriorityClasses w ramach domyślnej instalacji KAI
* Obsługa JobSet
* Obsługa LWS (LeaderWorkerSet)
* Dodanie metryk dla preempcji podów i grup podów
* Rozdzielenie Priority i Preemption

### Cele długoterminowe
* Wsparcie dla czasu zaniku (decay) na kolejkę
* Usprawnienia hiper-skalowalności
* Wsparcie konsolidacji obciążeń inference dla defragmentacji klastra
* Obsługa n-poziomowych kolejek hierarchicznych
* Łagodna aktualizacja obciążeń inference (nowa rewizja przez tymczasowe przekroczenie limitu kolejki)

## Społeczność, dyskusja i wsparcie

Chętnie poznamy Twoje zdanie! Oto najlepsze sposoby kontaktu:

### Slack
Dołącz najpierw do [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf), a następnie odwiedź kanał [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler).

### Spotkanie społeczności co dwa tygodnie  
**Kiedy:** W każdy drugi poniedziałek o 17:00 CEST  
[Przelicz na swoją strefę czasową](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Dodaj do kalendarza](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Notatki i agenda spotkania](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Lista mailingowa  
Dołącz do [listy mailingowej kai-scheduler](https://groups.google.com/g/kai-scheduler), aby otrzymywać aktualizacje dotyczące spotkań co dwa tygodnie.

### Problemy techniczne i propozycje funkcji  
Prosimy o otwarcie [zgłoszenia na GitHubie](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) w przypadku błędów, sugestii funkcji lub pomocy technicznej. Pomaga nam to śledzić zgłoszenia i skutecznie odpowiadać.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---