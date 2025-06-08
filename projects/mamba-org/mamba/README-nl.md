# Mamba: De Snelle Cross-Platform Pakketbeheerder

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">onderdeel van mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">Pakketbeheerder <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">Pakketserver <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` is een herimplementatie van de conda pakketbeheerder in C++.

- parallel downloaden van repositorygegevens en pakketbestanden met multi-threading
- libsolv voor veel snellere afhankelijkheidsoplossing, een state-of-the-art bibliotheek gebruikt in de RPM pakketbeheerder van Red Hat, Fedora en OpenSUSE
- kernonderdelen van `mamba` zijn geïmplementeerd in C++ voor maximale efficiëntie

Tegelijkertijd maakt `mamba` gebruik van dezelfde command line parser, pakketinstallatie- en deïnstallatiecode en transactie-verificatieroutines als `conda` om zo compatibel mogelijk te blijven.

`mamba` is onderdeel van het [conda-forge](https://conda-forge.org/) ecosysteem, dat ook bestaat uit `quetz`, een open source `conda` pakketserver.

Je kunt onze [aankondigingsblogpost](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23) lezen.

## micromamba

`micromamba` is de statisch gelinkte versie van `mamba`.

Het kan geïnstalleerd worden als een op zichzelf staand uitvoerbaar bestand zonder afhankelijkheden, waardoor het perfect geschikt is voor CI/CD pipelines en gecontaineriseerde omgevingen.

Zie de [documentatie over `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) voor details.

## `mamba` v.s. `micromamba`

`mamba` heeft de voorkeur wanneer:

- `libmambapy` of `libmamba` gebruikt wordt door andere software in dezelfde omgeving.
- Scenario’s waarbij regelmatige updates van bibliotheken vereist zijn (vooral voor beveiliging).
- Omgevingen gericht zijn op het verminderen van schijfruimtegebruik voor afhankelijkheden.

`micromamba` heeft de voorkeur wanneer:

- Er afhankelijkheid is van een enkel, zelfvoorzienend uitvoerbaar bestand.
- Een miniforge-distributie niet aanwezig is.
- Gebruik minimale runtime vereist.

## Installatie

Raadpleeg de [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
en [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) installatiegids in de documentatie.

## Extra functies in Mamba en Micromamba

`mamba` en `micromamba` bieden extra functies bovenop standaard `conda`.

### `repoquery`

Om efficiënt repositories en pakketafhankelijkheden te raadplegen kun je `mamba repoquery` of `micromamba repoquery` gebruiken.

Zie de [repoquery documentatie](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) voor details.

### Installeren van lock-bestanden

`micromamba` kan gebruikt worden om lock-bestanden, gegenereerd door [conda-lock](https://conda.github.io/conda-lock/), te installeren zonder `conda-lock` zelf te hoeven installeren.

Roep eenvoudigweg `micromamba create` aan met de `-f` optie, met een environment lockfile waarvan de naam eindigt op
`-lock.yml` of `-lock.yaml`; bijvoorbeeld:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (vervanger voor setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) is een vervanging voor [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) die `micromamba` gebruikt.

Dit kan je CI installatietijd aanzienlijk verkorten door:

- Gebruik te maken van `micromamba`, dat ongeveer 1 seconde nodig heeft om te installeren.
- Het cachen van pakketdownloads.
- Het cachen van volledige `conda` omgevingen.

## Verschillen met `conda`

Hoewel `mamba` en `micromamba` over het algemeen een drop-in vervanging zijn voor `conda`, zijn er enkele verschillen:

- `mamba` en `micromamba` ondersteunen geen revisies (voor discussies, zie <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` en `micromamba` normaliseren `MatchSpec`-strings naar de eenvoudigste vorm, terwijl `conda` een meer uitgebreide vorm gebruikt.
  Dit kan leiden tot kleine verschillen in de uitvoer van `conda env export` en `mamba env export`.

## Ontwikkelaarsinstallatie

Raadpleeg de instructies gegeven in de [officiële documentatie](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html).

## API- en ABI-stabiliteit

Het Mamba-project gebruikt [semantische versiebeheer](https://semver.org/) in de vorm `MAJOR.MINOR.PATCH`.
Hoewel we proberen de zaken stabiel te houden voor gebruikers, moeten we soms brekende wijzigingen doorvoeren om
Mamba te verbeteren en technische schuld te verminderen.
Toekomstige versies van Mamba kunnen sterkere garanties geven.

### `libmamba` (C++)

We zijn niet op de hoogte van gebruikers van de C++ API, dus behouden we ruimte voor verbeteringen.
Voor `libmamba` wordt de term _achterwaarts compatibel_ als volgt begrepen:

- _ABI achterwaarts compatibel_ betekent dat je de binaire bibliotheekbestanden kunt vervangen zonder je code te hercompileren met de bijgewerkte headers.
  Het waargenomen gedrag zal hetzelfde zijn, behalve bij bugfixes (hopelijk verdwijnen deze) en prestaties.
- _API achterwaarts compatibel_ betekent dat je je code opnieuw moet compileren met de nieuwe bibliotheekversie, maar je hoeft je code niet te wijzigen, alleen opnieuw te bouwen.
  Dit geldt zolang je geen declaraties hebt gebruikt die als privé worden beschouwd, bijvoorbeeld
  in de `detail` sub-namespaces.
  Het waargenomen gedrag zal hetzelfde zijn, behalve bij bugfixes (hopelijk verdwijnen deze) en prestaties.
  Wanneer declaraties zijn gedepriciëerd maar niet verwijderd en nog steeds functioneel zijn, beschouwen we dit ook als achterwaarts compatibel, omdat alleen het gedrag tijdens compilatie verandert.

Met dit in gedachten biedt `libmamba` de volgende garanties:

- `PATCH` releases zijn API- en ABI-achterwaarts compatibel;
- `MINOR` releases zijn API-compatibel voor declaraties in `mamba/api`,
  Ze kunnen API elders en ABI overal breken;
- `MAJOR` releases geven geen garanties.

### `libmambapy` (Python)

Voor `libmambapy` betekent _API achterwaarts compatibel_ dat je Python-code op dezelfde manier werkt voor een nieuwere versie van `libmambapy` zolang je geen declaraties gebruikt die als privé worden beschouwd, bijvoorbeeld met een naam die begint met een `_`.
Het waargenomen gedrag zal hetzelfde zijn, behalve bij bugfixes (hopelijk verdwijnen deze) en prestaties.
Wanneer declaraties zijn gedepriciëerd maar niet verwijderd en nog steeds functioneel zijn, beschouwen we dit ook als achterwaarts compatibel, omdat het gedrag alleen merkbaar is bij het activeren van Python
`DeprecationWarning`, wat gewoonlijk alleen in ontwikkeling wordt geactiveerd.

Met dit in gedachten biedt `libmambapy` de volgende garanties:

- `PATCH` releases zijn API-achterwaarts compatibel;
- `MINOR` releases zijn API-achterwaarts compatibel;
- `MAJOR` releases geven geen garanties.

### `mamba` en `micromamba` (uitvoerbare bestanden)

Voor uitvoerbare bestanden betekent _achterwaarts compatibel_ dat het van toepassing is op programmeerbare invoer en uitvoer en betekent dat je code (inclusief shellscripts) werkt met nieuwere versies van het uitvoerbare bestand zonder aanpassingen.
Programmeebare invoer/uitvoer omvat uitvoerbare naam, command line argumenten, configuratiebestanden, omgevingsvariabelen, JSON-uitvoer van de command line, en aangemaakte bestanden.
Het _sluit uit_ mensleesbare output en foutmeldingen, en dus ook deprecatie-waarschuwingen die in de mensleesbare output worden geschreven.

Met dit in gedachten bieden `mamba` en `micromamba` de volgende garanties:

- `PATCH` releases zijn achterwaarts compatibel;
- `MINOR` releases zijn achterwaarts compatibel;
- `MAJOR` releases geven geen garanties.

## Steun ons

Alleen `mamba` en `micromamba` 2.0 en later worden ondersteund en actief ontwikkeld.

De `1.x` branch wordt alleen onderhouden voor het oplossen van beveiligingsproblemen zoals CVE's.

Voor vragen kun je ons ook vinden op de [QuantStack Chat](https://gitter.im/QuantStack/Lobby)
of op het [Conda kanaal](https://gitter.im/conda/conda) (let op: dit project is niet officieel verbonden aan `conda` of Anaconda Inc.).

## Licentie

We gebruiken een gedeeld copyrightmodel dat alle bijdragers in staat stelt het copyright op hun bijdragen te behouden.

Deze software is gelicentieerd onder de BSD-3-Clause licentie. Zie het [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE) bestand voor details.

---

### Tweewekelijkse Ontwikkelaarsbijeenkomst

We hebben om de twee weken videoconferentie-vergaderingen waarin we bespreken waar we aan gewerkt hebben en feedback geven aan elkaar.

Iedereen is welkom om deel te nemen, als je een onderwerp wilt bespreken of gewoon wilt luisteren.

- Wanneer: Dinsdag [16:00 CET (Europa)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- Waar: [Mamba jitsi](https://meet.jit.si/mamba-org)
- Wat: [Notulen](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---