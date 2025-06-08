# Mamba: Der schnelle plattformübergreifende Paketmanager

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">Teil von mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">Paketmanager <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">Paketserver <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` ist eine Reimplementierung des conda-Paketmanagers in C++.

- Paralleles Herunterladen von Repository-Daten und Paketdateien mit Multi-Threading
- libsolv für eine viel schnellere Abhängigkeitsauflösung, eine moderne Bibliothek, die auch im RPM-Paketmanager von Red Hat, Fedora und OpenSUSE verwendet wird
- Zentrale Komponenten von `mamba` sind in C++ für maximale Effizienz implementiert

Gleichzeitig nutzt `mamba` den gleichen Kommandozeilenparser, Paketinstallations- und Deinstallationscode sowie Transaktionsüberprüfungsroutinen wie `conda`, um möglichst kompatibel zu bleiben.

`mamba` ist Teil des [conda-forge](https://conda-forge.org/) Ökosystems, das auch `quetz` umfasst, einen Open-Source `conda`-Paketserver.

Sie können unseren [Ankündigungs-Blogpost](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23) lesen.

## micromamba

`micromamba` ist die statisch gelinkte Version von `mamba`.

Es kann als eigenständige ausführbare Datei ohne jegliche Abhängigkeiten installiert werden, was es zur perfekten Lösung für CI/CD-Pipelines und containerisierte Umgebungen macht.

Siehe die [Dokumentation zu `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) für Details.

## `mamba` vs. `micromamba`

`mamba` sollte bevorzugt werden, wenn:

- `libmambapy` oder `libmamba` von anderer Software in derselben Umgebung verwendet wird.
- Szenarien, in denen regelmäßige Updates von Bibliotheken erforderlich sind (insbesondere aus Sicherheitsgründen).
- Umgebungen, die darauf ausgelegt sind, den Speicherplatzverbrauch durch Abhängigkeiten zu reduzieren.

`micromamba` sollte bevorzugt werden, wenn:

- Eine einzelne, in sich geschlossene ausführbare Datei benötigt wird.
- Keine miniforge-Distribution vorhanden ist.
- Die Nutzung minimale Laufzeit erfordert.

## Installation

Bitte beachten Sie die [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
und [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) Installationsanleitungen in der Dokumentation.

## Zusätzliche Funktionen in Mamba und Micromamba

`mamba` und `micromamba` bieten Funktionen, die über den Standard von `conda` hinausgehen.

### `repoquery`

Um effizient Repositories und Paketabhängigkeiten abzufragen, können Sie `mamba repoquery` oder `micromamba repoquery` verwenden.

Siehe die [repoquery Dokumentation](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) für Details.

### Installation von Lock-Dateien

Mit `micromamba` können Lock-Dateien, die von [conda-lock](https://conda.github.io/conda-lock/) erzeugt wurden, installiert werden, ohne dass `conda-lock` installiert werden muss.

Rufen Sie dazu einfach `micromamba create` mit der Option `-f` auf und geben Sie eine Lock-Datei an, deren Name mit
`-lock.yml` oder `-lock.yaml` endet; zum Beispiel:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (Ersatz für setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) ist ein Ersatz für [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda), der `micromamba` verwendet.

Es kann Ihre CI-Setup-Zeit erheblich verkürzen durch:

- Die Nutzung von `micromamba`, das etwa 1 Sekunde für die Installation benötigt.
- Caching von Paketdownloads.
- Caching ganzer `conda`-Umgebungen.

## Unterschiede zu `conda`

Obwohl `mamba` und `micromamba` im Allgemeinen ein Drop-in-Ersatz für `conda` sind, gibt es einige Unterschiede:

- `mamba` und `micromamba` unterstützen keine Revisionen (siehe Diskussionen unter <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` und `micromamba` normalisieren `MatchSpec`-Strings auf die einfachste Form, während `conda` eine ausführlichere Form verwendet.
  Dies kann zu leichten Unterschieden in der Ausgabe von `conda env export` und `mamba env export` führen.

## Entwicklung Installation

Bitte beachten Sie die Anweisungen in der [offiziellen Dokumentation](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html).

## API- und ABI-Stabilität

Das Mamba-Projekt verwendet [Semantic Versioning](https://semver.org/) im Format `MAJOR.MINOR.PATCH`.
Während wir versuchen, die Dinge für die Nutzer stabil zu halten, müssen wir manchmal auch Breaking Changes durchführen, um Mamba zu verbessern und technische Schulden abzubauen.
Zukünftige Versionen von Mamba könnten stärkere Garantien bieten.

### `libmamba` (C++)

Uns sind keine Nutzer der C++-API bekannt, daher behalten wir uns Verbesserungen vor.
Für `libmamba` wird _rückwärtskompatibel_ wie folgt verstanden:

- _ABI-rückwärtskompatibel_ bedeutet, dass Sie die Binärdateien der Bibliothek ersetzen können, ohne Ihren Code mit den aktualisierten Headern neu zu kompilieren.
  Das beobachtete Verhalten bleibt gleich, abgesehen von Fehlerkorrekturen (hoffentlich verschwinden diese) und Performance.
- _API-rückwärtskompatibel_ bedeutet, dass Sie Ihren Code mit der neuen Bibliotheksversion neu kompilieren müssen, Ihren Code aber nicht ändern müssen, sondern nur neu bauen.
  Dies gilt, solange Sie keine als privat verstandenen Deklarationen verwendet haben, z.B. im `detail`-Sub-Namespace.
  Das beobachtete Verhalten bleibt gleich, abgesehen von Fehlerkorrekturen (hoffentlich verschwinden diese) und Performance.
  Wenn Deklarationen als veraltet markiert, aber nicht entfernt und weiterhin funktionsfähig sind, betrachten wir dies ebenfalls als rückwärtskompatibel, da sich nur das Verhalten beim Kompilieren ändert.

Mit diesem Verständnis bietet `libmamba` folgende Garantien:

- `PATCH`-Releases sind API- und ABI-rückwärtskompatibel;
- `MINOR`-Releases sind API-kompatibel für Deklarationen in `mamba/api`,
  Sie können API außerhalb und ABI überall brechen;
- `MAJOR`-Releases geben keine Garantien.

### `libmambapy` (Python)

Für `libmambapy` bedeutet _API-rückwärtskompatibel_, dass Ihr Python-Code auch mit einer neueren Version von `libmambapy` funktioniert, solange Sie keine als privat verstandenen Deklarationen verwendet haben, z.B. solche, die mit einem `_` beginnen.
Das beobachtete Verhalten bleibt gleich, abgesehen von Fehlerkorrekturen (hoffentlich verschwinden diese) und Performance.
Wenn Deklarationen als veraltet markiert, aber nicht entfernt und weiterhin funktionsfähig sind, betrachten wir dies ebenfalls als rückwärtskompatibel, da das Verhalten nur sichtbar ist, wenn Python
`DeprecationWarning` aktiviert ist, was in der Regel nur in der Entwicklung der Fall ist.

Mit diesem Verständnis bietet `libmambapy` folgende Garantien:

- `PATCH`-Releases sind API-rückwärtskompatibel;
- `MINOR`-Releases sind API-rückwärtskompatibel;
- `MAJOR`-Releases geben keine Garantien.

### `mamba` und `micromamba` (ausführbare Dateien)

Für ausführbare Dateien bezieht sich _rückwärtskompatibel_ auf programmierbare Ein- und Ausgaben und bedeutet,
dass Ihr Code (einschließlich Shell-Skripte) auch mit neueren Versionen der ausführbaren Datei ohne
Änderungen funktioniert.
Programmierbare Ein-/Ausgaben umfassen den Namen der ausführbaren Datei, Kommandozeilenargumente, Konfigurationsdateien,
Umgebungsvariablen, JSON-Kommandozeilenausgaben und erzeugte Dateien.
Es _schließt_ menschenlesbare Ausgaben und Fehlermeldungen aus, und somit auch Deprecation-Warnungen, die im menschenlesbaren Output erscheinen.

Mit diesem Verständnis bieten `mamba` und `micromamba` folgende Garantien:

- `PATCH`-Releases sind rückwärtskompatibel;
- `MINOR`-Releases sind rückwärtskompatibel;
- `MAJOR`-Releases geben keine Garantien.

## Unterstützen Sie uns

Nur `mamba` und `micromamba` ab Version 2.0 werden unterstützt und aktiv weiterentwickelt.

Der `1.x`-Zweig wird nur noch zur Behebung von Sicherheitsproblemen wie CVEs gepflegt.

Für Fragen können Sie uns auch im [QuantStack Chat](https://gitter.im/QuantStack/Lobby)
oder auf dem [Conda-Kanal](https://gitter.im/conda/conda) erreichen (bitte beachten Sie, dass dieses Projekt nicht offiziell mit `conda` oder Anaconda Inc. verbunden ist).

## Lizenz

Wir verwenden ein geteiltes Copyright-Modell, das es allen Beitragenden ermöglicht, das Urheberrecht an ihren Beiträgen zu behalten.

Diese Software ist unter der BSD-3-Clause-Lizenz lizenziert. Details finden Sie in der [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE)-Datei.

---

### Zweiwöchentliches Entwickler-Meeting

Wir haben alle zwei Wochen Videokonferenz-Meetings, bei denen wir besprechen, woran wir gearbeitet haben und uns gegenseitig Feedback geben.

Jede:r ist willkommen teilzunehmen, um ein Thema zu diskutieren oder einfach nur zuzuhören.

- Wann: Dienstag [16:00 Uhr MEZ (Europa)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- Wo: [Mamba jitsi](https://meet.jit.si/mamba-org)
- Was: [Meeting-Notizen](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---