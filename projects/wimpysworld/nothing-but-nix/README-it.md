
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**Trasforma il tuo runner di GitHub Actions in una potenza [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ eliminando senza pietà il software preinstallato superfluo.**

I runner di GitHub Actions hanno uno spazio su disco limitato per Nix - appena ~20GB.
*Nothing but Nix* **elimina brutalmente** i software non necessari, offrendoti **65GB fino a 130GB** per il tuo Nix store! 💪

## Utilizzo 🔧

Aggiungi questa azione **prima** di installare Nix nel tuo workflow:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### Requisiti ️✔️

- Supporta solo i runner ufficiali **Ubuntu** di GitHub Actions
- Deve essere eseguito **prima** che Nix venga installato
- **Runner macOS/Darwin**: questa azione verrà saltata con un avviso se eseguita su macOS. I runner macOS offrono già spazio sufficiente per Nix e non richiedono questa azione
- **Runner Windows**: questa azione verrà saltata con un avviso se eseguita su Windows. I runner Windows hanno layout e vincoli filesystem differenti

## Il Problema: Fare Spazio a Nix per Prosperare 🌱

I runner standard di GitHub Actions sono pieni di *"bloatware"* che non userai mai in un workflow Nix:

- 🌍 Browser web. Tanti. Bisogna averli tutti!
- 🐳 Immagini Docker che consumano gigabyte di prezioso spazio su disco
- 💻 Runtime di linguaggi inutili (.NET, Ruby, PHP, Java...)
- 📦 Gestori di pacchetti che accumulano polvere digitale
- 📚 Documentazione che nessuno leggerà mai

Questo bloat lascia solo ~20GB per il tuo Nix store - appena sufficienti per build Nix serie! 😞

## La Soluzione: Solo Nix ️❄️

**Solo Nix** adotta un approccio radicale ai runner GitHub Actions e recupera spazio disco senza pietà con un attacco in due fasi:

1. **Taglio Iniziale:** Crea istantaneamente un grande volume `/nix` (~65GB) reclamando spazio libero da `/mnt`
2. **Rastrellamento in Background:** Mentre il workflow prosegue, eliminiamo senza pietà software inutile per espandere il tuo volume `/nix` fino a ~130GB
   - Browser web? No ⛔
   - Immagini Docker? Sparite 🗑️
   - Runtime linguaggi? Annientati 💥
   - Gestori di pacchetti? Distrutti 💣
   - Documentazione? Vaporizzata ️👻

La pulizia del file system è alimentata da `rmz` (dal progetto [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - un'alternativa ad alte prestazioni a `rm` che rende il recupero dello spazio rapidissimo! ⚡
   - Prestazioni di un ordine di grandezza superiori a `rm` standard
   - Elimina in parallelo per la massima efficienza
   - **Recupera spazio disco in pochi secondi anziché minuti!** ️⏱️

Il risultato finale? Un runner GitHub Actions con **65GB fino a 130GB** di spazio pronto per Nix! 😁

### Crescita Dinamica del Volume

A differenza di altre soluzioni, **Nothing but Nix** espande dinamicamente il volume `/nix`:

1. **Creazione iniziale del volume (1-10 secondi):** (*a seconda del Protocollo Hatchet*)
   - Crea un dispositivo loop utilizzando spazio libero su `/mnt`
   - Configura un filesystem BTRFS in modalità RAID0
   - Monta con compressione e ottimizzazione delle prestazioni
   - Fornisce subito un `/nix` da 65GB, anche prima dell’inizio della pulizia

2. **Espansione in background (30-180 secondi):** (*a seconda del Protocollo Hatchet*)
   - Esegue operazioni di pulizia
   - Monitora lo spazio appena liberato man mano che il bloat viene eliminato
   - Aggiunge dinamicamente un disco di espansione al volume `/nix`
   - Ribilancia il filesystem per incorporare il nuovo spazio

Il volume `/nix` **si espande automaticamente durante l’esecuzione del workflow** 🎩🪄

### Scegli la tua arma: il Protocollo Hatchet 🪓

Controlla il livello di annientamento 💥 tramite l’input `hatchet-protocol`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### Confronto tra Protocolli ⚖️

| Protocollo | `/nix` | Descrizione                                      | Purga apt  | Purga docker | Purga snap | File system eliminati     |
|------------|--------|--------------------------------------------------|------------|--------------|------------|--------------------------|
| Holster    | ~65GB  | Tieni la scure nel fodero, usa spazio da `/mnt`  | No         | No           | No         | Nessuno                  |
| Carve      | ~85GB  | Combina e crea spazio libero da `/` e `/mnt`     | No         | No           | No         | Nessuno                  |
| Cleave     | ~115GB | Tagli potenti e decisi ai pacchetti più grandi   | Minima     | Sì           | Sì         | `/opt` e `/usr/local`    |
| Rampage    | ~130GB | Eliminazione implacabile e brutale di ogni bloat | Aggressiva | Sì           | Sì         | Muahahaha! 🔥🌎          |

Scegli con saggezza:
- **Holster** quando hai bisogno che gli strumenti del runner restino completamente funzionanti
- **Carve** per preservare gli strumenti funzionali del runner ma reclamare tutto lo spazio libero per Nix
- **Cleave** (*predefinito*) per un buon equilibrio tra spazio e funzionalità
- **Rampage** quando vuoi il massimo spazio per Nix e non ti importa cosa si rompe `#nix-is-life`

### Assisti al Massacro 🩸

Per impostazione predefinita, il processo di pulizia viene eseguito silenziosamente in background mentre il tuo workflow continua. Ma se vuoi guardare lo sterminio in tempo reale:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Personalizza le Zone Sicure 🛡️

Controlla quanto spazio riservare dal recupero di spazio del Nix store con dimensioni personalizzate delle zone sicure:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

Questi rifugi sicuri definiscono quanto spazio (in MB) verrà misericordiosamente risparmiato durante il recupero dello spazio:
- Il valore predefinito di `root-safe-haven` è 2048MB (2GB)
- Il valore predefinito di `mnt-safe-haven` è 1024MB (1GB)

Aumenta questi valori se hai bisogno di più margine sui tuoi filesystem, oppure diminuiscili per non mostrare alcuna pietà! 😈

### Concedi la proprietà utente di /nix (Editto sui permessi Nix) 🧑‍⚖️

Alcuni installer o configurazioni di Nix si aspettano che la directory `/nix` sia scrivibile dall’utente corrente. Di default, `/nix` è di proprietà di root. Se hai bisogno della proprietà utente (ad es. per alcuni script di installazione Nix che non usano `sudo` per tutte le operazioni all’interno di `/nix`), puoi abilitare `nix-permission-edict`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

Quando `nix-permission-edict` è impostato su `true`, l'azione eseguirà `sudo chown -R "$(id --user)":"$(id --group)" /nix` dopo aver montato `/nix`.

### Configurare Nix per usare /nix/build

Questa azione crea `/nix/build` affinché le build delle derivazioni Nix utilizzino lo spazio recuperato. Aggiungi `build-dir` alla tua configurazione di Nix:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

Oppure con DeterminateSystems:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```

Questo indica a Nix di eseguire le build sul grande volume BTRFS invece che sulla directory temporanea predefinita del sistema.

## Risoluzione dei problemi 🔍

### "Spazio esaurito sul dispositivo" durante build di grandi dimensioni

Se la tua build esaurisce lo spazio nonostante l'uso esclusivo di Nix, è probabile che la pulizia in background non sia stata completata prima che la build consumi lo spazio disponibile. Questo problema interessa comunemente:

- Test VM NixOS che assemblano grandi immagini disco
- Build con molte dipendenze non memorizzate nella cache
- Toolchain Rust e altre compilazioni di grandi dimensioni

**Soluzione:** Usa `witness-carnage: true` per forzare la pulizia sincrona. Questo garantisce che tutto lo spazio venga recuperato *prima* che inizi la build:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

Questo aggiunge 30-180 secondi alla configurazione del tuo workflow, ma garantisce che sia disponibile il massimo spazio quando il build inizia.

Ora vai e costruisci qualcosa di straordinario con tutto quello splendido spazio nello store Nix! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---