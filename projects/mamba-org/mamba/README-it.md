# Mamba: Il Veloce Gestore di Pacchetti Multipiattaforma

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">parte di mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">Gestore di Pacchetti <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">Server di Pacchetti <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` è una reimplementazione del gestore di pacchetti conda in C++.

- scaricamento parallelo dei dati dei repository e dei file dei pacchetti tramite multi-threading
- libsolv per una risoluzione delle dipendenze molto più veloce, una libreria all'avanguardia utilizzata nel gestore di pacchetti RPM di Red Hat, Fedora e OpenSUSE
- le parti core di `mamba` sono implementate in C++ per la massima efficienza

Allo stesso tempo, `mamba` utilizza lo stesso parser della riga di comando, codice di installazione e disinstallazione dei pacchetti e routine di verifica delle transazioni di `conda` per mantenere la massima compatibilità possibile.

`mamba` fa parte dell’ecosistema [conda-forge](https://conda-forge.org/), che comprende anche `quetz`, un server open source di pacchetti `conda`.

Puoi leggere il nostro [post di annuncio sul blog](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23).

## micromamba

`micromamba` è la versione statica e collegata di `mamba`.

Può essere installato come eseguibile standalone senza alcuna dipendenza, rendendolo perfetto per pipeline CI/CD e ambienti containerizzati.

Consulta la [documentazione su `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) per i dettagli.

## `mamba` vs. `micromamba`

Si deve preferire `mamba` quando:

- `libmambapy` o `libmamba` sono utilizzati da altri software nello stesso ambiente.
- Scenari in cui sono richiesti aggiornamenti regolari delle librerie (specialmente per motivi di sicurezza).
- Gli ambienti sono focalizzati sulla riduzione dell’uso dello spazio su disco per le dipendenze.

Si deve preferire `micromamba` quando:

- È richiesto affidarsi a un singolo eseguibile auto-contenuto.
- Una distribuzione miniforge non è presente.
- L’utilizzo richiede un runtime minimo.

## Installazione

Consulta la guida di installazione di [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
e [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) nella documentazione.

## Funzionalità aggiuntive in Mamba e Micromamba

`mamba` e `micromamba` offrono funzionalità aggiuntive rispetto alla versione base di `conda`.

### `repoquery`

Per interrogare efficientemente i repository e le dipendenze dei pacchetti puoi utilizzare `mamba repoquery` o `micromamba repoquery`.

Consulta la [documentazione di repoquery](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) per i dettagli.

### Installazione di lock file

`micromamba` può essere usato per installare lock file generati da [conda-lock](https://conda.github.io/conda-lock/) senza dover installare `conda-lock`.

Semplicemente esegui `micromamba create` con l’opzione `-f`, fornendo un environment lockfile il cui nome termina con
`-lock.yml` o `-lock.yaml`; per esempio:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (sostituto di setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) è un sostituto di [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) che utilizza `micromamba`.

Può ridurre significativamente il tempo di setup della tua CI:

- Usando `micromamba`, che impiega circa 1 s per l’installazione.
- Effettuando il caching dei download dei pacchetti.
- Effettuando il caching degli interi ambienti `conda`.

## Differenze con `conda`

Sebbene `mamba` e `micromamba` siano generalmente sostituti drop-in di `conda`, esistono alcune differenze:

- `mamba` e `micromamba` non supportano le revisioni (per discussioni, vedi <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` e `micromamba` normalizzano le stringhe `MatchSpec` nella forma più semplice, mentre `conda` usa una forma più verbosa
  Questo può portare a lievi differenze nell’output di `conda env export` e `mamba env export`.

## Installazione per lo sviluppo

Consulta le istruzioni fornite dalla [documentazione ufficiale](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html).

## Stabilità API e ABI

Il progetto Mamba utilizza la [versionatura semantica](https://semver.org/) nella forma `MAJOR.MINOR.PATCH`.
Sebbene cerchiamo di mantenere la stabilità per gli utenti, a volte dobbiamo introdurre cambiamenti non retrocompatibili per migliorare
Mamba e ridurre il debito tecnico.
Le versioni future di Mamba potrebbero offrire garanzie più forti.

### `libmamba` (C++)

Non siamo a conoscenza di utilizzatori dell’API C++, quindi ci riserviamo margine per miglioramenti.
Per `libmamba`, il termine _retrocompatibile_ è inteso come segue:

- _Retrocompatibile ABI_ significa che puoi sostituire i file binari della libreria senza ricompilare
  il tuo codice con le intestazioni aggiornate.
  Il comportamento osservato sarà lo stesso, eccetto per bug (che speriamo scompaiano) e performance.
- _Retrocompatibile API_ significa che devi ricompilare il tuo codice con la nuova versione della libreria,
  ma non dovrai cambiare il tuo codice, solo ricostruirlo.
  Ciò si applica finché non hai usato dichiarazioni considerate private, per esempio
  nei sotto-namespace `detail`.
  Il comportamento osservato sarà lo stesso, eccetto per bug (che speriamo scompaiano) e performance.
  Quando le dichiarazioni sono deprecate ma non rimosse e ancora funzionanti, le consideriamo
  comunque retrocompatibili, poiché solo il comportamento in compilazione cambia.

Tenendo conto di ciò, `libmamba` offre le seguenti garanzie:

- Le release `PATCH` sono retrocompatibili sia a livello di API che di ABI;
- Le release `MINOR` sono retrocompatibili a livello di API per le dichiarazioni in `mamba/api`,
  possono rompere API altrove e ABI ovunque;
- Le release `MAJOR` non forniscono garanzie.

### `libmambapy` (Python)

Per `libmambapy`, il termine _retrocompatibile API_ implica che il tuo codice Python funzionerà nello
stesso modo con una versione più recente di `libmambapy` finché non usi dichiarazioni considerate private,
ad esempio accessibili tramite nomi che iniziano con un `_`.
Il comportamento osservato sarà lo stesso, eccetto per bug (che speriamo scompaiano) e performance.
Quando le dichiarazioni sono deprecate ma non rimosse e ancora funzionanti, le consideriamo
comunque retrocompatibili, poiché il comportamento è osservabile solo attivando l’avviso di
`DeprecationWarning` di Python, che normalmente è attivo solo in sviluppo.

Tenendo conto di ciò, `libmambapy` offre le seguenti garanzie:

- Le release `PATCH` sono retrocompatibili a livello di API;
- Le release `MINOR` sono retrocompatibili a livello di API;
- Le release `MAJOR` non forniscono garanzie.

### `mamba` e `micromamba` (eseguibili)

Per gli eseguibili, il termine _retrocompatibile_ si applica agli input e output programmabili e significa
che il tuo codice (inclusi script shell) funzionerà con versioni più recenti dell’eseguibile senza
modifiche.
Gli input/output programmabili includono nome dell’eseguibile, argomenti della riga di comando, file di configurazione,
variabili d’ambiente, output JSON della riga di comando e file creati.
_Sono esclusi_ output leggibili dall’uomo e messaggi di errore, e quindi gli avvisi di deprecazione scritti
nell’output leggibile.

Tenendo conto di ciò, `mamba` e `micromamba` offrono le seguenti garanzie:

- Le release `PATCH` sono retrocompatibili;
- Le release `MINOR` sono retrocompatibili;
- Le release `MAJOR` non forniscono garanzie.

## Supportaci

Solo `mamba` e `micromamba` dalla versione 2.0 in poi sono supportati e attivamente sviluppati.

Il ramo `1.x` viene mantenuto solo per problemi di sicurezza come CVE.

Per domande, puoi anche unirti a noi sulla [QuantStack Chat](https://gitter.im/QuantStack/Lobby)
o sul [canale Conda](https://gitter.im/conda/conda) (nota che questo progetto non è ufficialmente affiliato con `conda` o Anaconda Inc.).

## Licenza

Utilizziamo un modello di copyright condiviso che consente a tutti i contributori di mantenere il copyright sui propri contributi.

Questo software è rilasciato sotto licenza BSD-3-Clause. Consulta il file [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE) per i dettagli.

---

### Riunione Dev quindicinale

Abbiamo videoconferenze ogni due settimane in cui discutiamo su cosa stiamo lavorando e riceviamo feedback reciproci.

Chiunque è il benvenuto a partecipare, se desidera discutere un argomento o semplicemente ascoltare.

- Quando: Martedì [16:00 CET (Europa)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- Dove: [Mamba jitsi](https://meet.jit.si/mamba-org)
- Cosa: [Note della riunione](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---