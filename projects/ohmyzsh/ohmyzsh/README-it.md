<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh è un framework open source guidato dalla comunità per gestire la tua configurazione [zsh](https://www.zsh.org/).

Sembra noioso. Proviamo di nuovo.

**Oh My Zsh non ti renderà uno sviluppatore 10x... ma potresti sentirti come tale.**

Una volta installato, la tua shell del terminale diventerà l'argomento di conversazione della città _o ti restituiamo i soldi!_ Ad ogni pressione di tasto nel tuo prompt dei comandi, potrai sfruttare centinaia di potenti plugin e bellissimi temi. Degli sconosciuti si avvicineranno a te nei caffè e ti chiederanno: _"è incredibile! sei una specie di genio?"_

Finalmente, inizierai a ricevere l'attenzione che hai sempre pensato di meritare. ...o forse userai il tempo risparmiato per iniziare a usare più spesso il filo interdentale. 😬

Per saperne di più, visita [ohmyz.sh](https://ohmyz.sh), segui [@ohmyzsh](https://x.com/ohmyzsh) su X (precedentemente Twitter) e unisciti a noi su [Discord](https://discord.gg/ohmyzsh).

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>Indice</summary>

- [Introduzione](#getting-started)
  - [Compatibilità con i Sistemi Operativi](#operating-system-compatibility)
  - [Prerequisiti](#prerequisites)
  - [Installazione Base](#basic-installation)
    - [Ispezione Manuale](#manual-inspection)
- [Utilizzo di Oh My Zsh](#using-oh-my-zsh)
  - [Plugin](#plugins)
    - [Abilitare i Plugin](#enabling-plugins)
    - [Utilizzo dei Plugin](#using-plugins)
  - [Temi](#themes)
    - [Selezione di un Tema](#selecting-a-theme)
  - [FAQ](#faq)
- [Argomenti Avanzati](#advanced-topics)
  - [Installazione Avanzata](#advanced-installation)
    - [Cartella Personalizzata](#custom-directory)
    - [Installazione Non Interattiva](#unattended-install)
    - [Installazione da un Repository Forkato](#installing-from-a-forked-repository)
    - [Installazione Manuale](#manual-installation)
  - [Problemi di Installazione](#installation-problems)
  - [Plugin e Temi Personalizzati](#custom-plugins-and-themes)
  - [Abilita GNU ls su macOS e sistemi freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Ignora Alias](#skip-aliases)
  - [Prompt git asincrono](#async-git-prompt)
- [Aggiornamenti](#getting-updates)
  - [Verbosity degli Aggiornamenti](#updates-verbosity)
  - [Aggiornamenti Manuali](#manual-updates)
- [Disinstallare Oh My Zsh](#uninstalling-oh-my-zsh)
- [Come Contribuire a Oh My Zsh?](#how-do-i-contribute-to-oh-my-zsh)
  - [Non Inviare Temi](#do-not-send-us-themes)
- [Contributori](#contributors)
- [Seguici](#follow-us)
- [Merchandising](#merchandise)
- [Licenza](#license)
- [Info su Planet Argon](#about-planet-argon)

</details>

## Introduzione

### Compatibilità con i Sistemi Operativi

| O/S            | Stato |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### Prerequisiti

- [Zsh](https://www.zsh.org) deve essere installato (v4.3.9 o più recente va bene, ma preferiamo la 5.0.8 o superiore). Se non è preinstallato (esegui `zsh --version` per confermare), consulta le istruzioni del wiki: [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` o `wget` devono essere installati
- `git` deve essere installato (raccomandato v2.4.11 o superiore)

### Installazione Base

Oh My Zsh si installa eseguendo uno dei seguenti comandi nel tuo terminale. Puoi installarlo tramite riga di comando usando `curl`, `wget` o un altro strumento simile.

| Metodo    | Comando                                                                                           |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

In alternativa, l'installer è anche disponibile fuori da GitHub. Potrebbe essere necessario usare questo URL se ti trovi in un paese come la Cina o l'India (per alcuni ISP), che blocca `raw.githubusercontent.com`:

| Metodo    | Comando                                           |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_Nota che qualsiasi `.zshrc` precedente verrà rinominato in `.zshrc.pre-oh-my-zsh`. Dopo l’installazione puoi spostare la configurazione che vuoi preservare nel nuovo `.zshrc`._

#### Ispezione Manuale

È una buona idea ispezionare lo script di installazione di progetti che ancora non conosci. Puoi farlo scaricando prima lo script, esaminandolo per verificare che sia tutto normale, e poi eseguendolo:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Se l’URL sopra va in timeout o fallisce, potrebbe essere necessario sostituirlo con `https://install.ohmyz.sh` per ottenere lo script.

## Utilizzo di Oh My Zsh

### Plugin

Oh My Zsh include un sacco di plugin da cui puoi trarre vantaggio. Puoi dare un’occhiata alla cartella [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) e/o al [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) per vedere cosa è attualmente disponibile.

#### Abilitare i Plugin

Una volta trovato un plugin (o più) che vuoi usare con Oh My Zsh, dovrai abilitarli nel file `.zshrc`. Troverai il file zshrc nella tua directory `$HOME`. Aprilo con il tuo editor di testo preferito e vedrai un punto dove elencare tutti i plugin che vuoi caricare.

```sh
vi ~/.zshrc
```

Ad esempio, potrebbe iniziare a somigliare a questo:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Nota che i plugin sono separati da spazi bianchi (spazi, tabulazioni, nuove righe...). **Non** usare virgole tra di essi altrimenti si romperà tutto._

#### Utilizzo dei Plugin

Ogni plugin integrato include un **README** che lo documenta. Questo README dovrebbe mostrare gli alias (se il plugin ne aggiunge) e altre utilità incluse in quel particolare plugin.

### Temi

Lo ammettiamo. All’inizio del mondo di Oh My Zsh, ci siamo fatti un po’ prendere la mano con i temi. Ora ne abbiamo più di centocinquanta inclusi. La maggior parte ha [screenshot](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) sul wiki (Stiamo lavorando per aggiornarli!). Dai un’occhiata!

#### Selezione di un Tema

_Il tema di Robby è quello predefinito. Non è il più elegante. Non è il più semplice. È semplicemente quello giusto (per lui)._

Una volta trovato un tema che vuoi usare, dovrai modificare il file `~/.zshrc`. Vedrai una variabile d’ambiente (tutta in maiuscolo) che assomiglia a questa:

```sh
ZSH_THEME="robbyrussell"
```

Per usare un tema diverso, basta cambiare il valore con il nome del tema desiderato. Ad esempio:

```sh
ZSH_THEME="agnoster" # (questo è uno di quelli eleganti)
# vedi https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> Vedrai spesso degli screenshot di un tema zsh, lo proverai, e scoprirai che non appare uguale a come lo vedevi tu.
>
> Questo perché molti temi richiedono l’installazione di un [Powerline Font](https://github.com/powerline/fonts) o di un [Nerd Font](https://github.com/ryanoasis/nerd-fonts) per essere visualizzati correttamente. Senza di essi, questi temi mostreranno strani simboli nel prompt. Consulta [le FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) per maggiori informazioni.
>
> Inoltre, attenzione: i temi controllano solo l’aspetto del prompt, cioè il testo che vedi prima o dopo il cursore dove digiti i comandi. I temi non controllano cose come i colori della finestra del terminale (detto _schema colori_) o il font del terminale. Queste sono impostazioni che puoi cambiare nel tuo emulatore di terminale. Per maggiori informazioni, vedi [cos’è un tema zsh](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

Apri una nuova finestra del terminale e il tuo prompt dovrebbe assomigliare a questo:

![Tema Agnoster](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

Se non hai trovato un tema adatto alle tue esigenze, dai un’occhiata al wiki per [altri temi](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

Se ti senti avventuroso, puoi lasciare che il computer ne scelga uno casualmente ogni volta che apri una nuova finestra del terminale.

```sh
ZSH_THEME="random" # (...per favore che sia pie... per favore sia qualche pie..)
```

E se vuoi scegliere un tema casuale da una lista dei tuoi temi preferiti:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Se invece sai solo quali temi non ti piacciono, puoi aggiungerli analogamente a una lista di esclusione:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

Se hai altre domande o problemi, potresti trovare una soluzione nelle nostre [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## Argomenti Avanzati

Se sei il tipo a cui piace sporcarsi le mani, queste sezioni potrebbero interessarti.

### Installazione Avanzata

Alcuni utenti potrebbero voler installare Oh My Zsh manualmente, o cambiare il percorso predefinito o altre impostazioni che l’installer accetta (queste impostazioni sono anche documentate in cima allo script di installazione).

#### Cartella Personalizzata

La posizione predefinita è `~/.oh-my-zsh` (nascosta nella tua home directory, puoi accedervi con `cd ~/.oh-my-zsh`)

Se vuoi cambiare la directory di installazione con la variabile d’ambiente `ZSH`, puoi farlo eseguendo `export ZSH=/il/tuo/percorso` prima dell’installazione, o impostandola prima della fine della pipeline di installazione, così:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Installazione Non Interattiva

Se esegui lo script di installazione di Oh My Zsh come parte di un’installazione automatizzata, puoi passare l’opzione `--unattended` allo script `install.sh`. Questo impedirà di provare a cambiare la shell predefinita, e non verrà eseguito `zsh` alla fine dell’installazione.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Se sei in Cina, India o un altro paese che blocca `raw.githubusercontent.com`, potrebbe essere necessario sostituire l’URL con `https://install.ohmyz.sh` per installare.

#### Installazione da un Repository Forkato

Lo script di installazione accetta anche queste variabili per permettere l’installazione da un repository diverso:

- `REPO` (predefinito: `ohmyzsh/ohmyzsh`): prende la forma `proprietario/repository`. Se imposti questa variabile, l’installer cercherà un repository su `https://github.com/{proprietario}/{repository}`.

- `REMOTE` (predefinito: `https://github.com/${REPO}.git`): è l’URL completo del clone git del repository. Puoi usare questa impostazione se vuoi installare da un fork che non è su GitHub (GitLab, Bitbucket...) o se vuoi clonare via SSH invece che HTTPS (`git@github.com:user/project.git`).

  _NOTA: non è compatibile con l’impostazione della variabile `REPO`. Questa impostazione ha precedenza._

- `BRANCH` (predefinito: `master`): puoi usare questa impostazione se vuoi cambiare il ramo predefinito da clonare. Può essere utile per testare una Pull Request, o se vuoi usare un ramo diverso da `master`.

Per esempio:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Installazione Manuale

##### 1. Clona il Repository <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _Opzionalmente_, fai il backup del tuo file `~/.zshrc` esistente <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Crea un Nuovo File di Configurazione Zsh <!-- omit in toc -->

Puoi creare un nuovo file di configurazione zsh copiando il template incluso.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Cambia la tua Shell Predefinita <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Devi effettuare il logout dalla tua sessione utente e rientrare per vedere il cambiamento.

##### 5. Inizializza la Nuova Configurazione Zsh <!-- omit in toc -->

Quando apri una nuova finestra del terminale, dovrebbe caricare zsh con la configurazione di Oh My Zsh.

### Problemi di Installazione

Se hai dei problemi durante l’installazione, ecco alcune soluzioni comuni.

- Potresti _dover_ modificare il tuo `PATH` in `~/.zshrc` se non riesci a trovare alcuni comandi dopo il passaggio a `oh-my-zsh`.
- Se hai installato manualmente o cambiato la posizione di installazione, controlla la variabile d’ambiente `ZSH` in `~/.zshrc`.

### Plugin e Temi Personalizzati

Se vuoi sovrascrivere qualsiasi comportamento predefinito, basta aggiungere un nuovo file (che termina con `.zsh`) nella cartella `custom/`.

Se hai molte funzioni che stanno bene insieme, puoi metterle in un file `XYZ.plugin.zsh` nella cartella `custom/plugins/` e poi abilitare questo plugin.

Se vuoi sovrascrivere la funzionalità di un plugin distribuito con Oh My Zsh, crea un plugin con lo stesso nome nella cartella `custom/plugins/` e verrà caricato al posto di quello in `plugins/`.

### Abilita GNU ls su macOS e sistemi freeBSD

<a name="enable-gnu-ls"></a>

Il comportamento predefinito di Oh My Zsh è usare `ls` BSD su macOS e sistemi FreeBSD. Se è installato `ls` GNU (come comando `gls`), puoi scegliere di usarlo invece. Per farlo, puoi usare una configurazione basata su zstyle prima di eseguire `oh-my-zsh.sh`:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Nota: questa opzione non è compatibile con `DISABLE_LS_COLORS=true`_

### Ignora Alias

<a name="remove-directories-aliases"></a>

Se vuoi saltare gli alias predefiniti di Oh My Zsh (quelli definiti nei file `lib/*`) o quelli dei plugin, puoi usare le impostazioni seguenti nel tuo file `~/.zshrc`, **prima che Oh My Zsh venga caricato**. Nota che ci sono diversi modi per ignorare gli alias, a seconda delle tue esigenze.

```sh
# Salta tutti gli alias, sia nei file lib che nei plugin abilitati
zstyle ':omz:*' aliases no

# Salta tutti gli alias nei file lib
zstyle ':omz:lib:*' aliases no
# Salta solo gli alias definiti nel file lib directories.zsh
zstyle ':omz:lib:directories' aliases no

# Salta tutti gli alias dei plugin
zstyle ':omz:plugins:*' aliases no
# Salta solo gli alias del plugin git
zstyle ':omz:plugins:git' aliases no
```

Puoi combinare queste impostazioni in altri modi, tenendo conto che gli scope più specifici hanno precedenza:

```sh
# Salta tutti gli alias dei plugin, tranne quelli del plugin git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

Una versione precedente di questa funzionalità usava la seguente impostazione, che ora è stata rimossa:

```sh
zstyle ':omz:directories' aliases no
```

Ora puoi invece usare:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Avviso <!-- omit in toc -->

> Questa funzionalità è attualmente in fase di test e potrebbe essere soggetta a cambiamenti futuri. Inoltre, al momento non è compatibile con plugin manager come zpm o zinit, che non eseguono lo script di inizializzazione (`oh-my-zsh.sh`) dove questa funzione viene implementata.

> Inoltre, al momento non riconosce gli "alias" che sono definiti come funzioni. Esempi di questi sono le funzioni `gccd`, `ggf` o `ggl` dal plugin git.

### Prompt git asincrono

Le funzioni prompt asincrone sono una funzionalità sperimentale (inclusa dal 3 aprile 2024) che permette a Oh My Zsh di visualizzare informazioni del prompt in modo asincrono. Questo può migliorare le prestazioni del rendering del prompt, ma potrebbe non funzionare bene con alcune configurazioni. Speriamo non sia un problema, ma se riscontri problemi con questa nuova funzione, puoi disattivarla impostando nel tuo file .zshrc, prima che venga caricato Oh My Zsh:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Se il problema è che il prompt git ha smesso di apparire, puoi provare a forzarlo impostando la seguente configurazione prima che venga caricato `oh-my-zsh.sh`. Se ancora non funziona, apri una issue con il tuo caso.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## Aggiornamenti

Per impostazione predefinita, ti verrà chiesto di controllare la presenza di aggiornamenti ogni 2 settimane. Puoi scegliere altre modalità di aggiornamento aggiungendo una riga al tuo file `~/.zshrc`, **prima che Oh My Zsh venga caricato**:

1. Aggiornamento automatico senza richiesta di conferma:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Solo un promemoria ogni pochi giorni, se sono disponibili aggiornamenti:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Per disabilitare completamente gli aggiornamenti automatici:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

NOTA: puoi controllare la frequenza con cui Oh My Zsh controlla gli aggiornamenti con la seguente impostazione:

```sh
# Questo controllerà la presenza di aggiornamenti ogni 7 giorni
zstyle ':omz:update' frequency 7
# Questo controllerà la presenza di aggiornamenti ogni volta che apri il terminale (non raccomandato)
zstyle ':omz:update' frequency 0
```

### Verbosity degli Aggiornamenti

Puoi anche limitare la verbosità degli aggiornamenti con le seguenti impostazioni:

```sh
zstyle ':omz:update' verbose default # prompt di aggiornamento predefinito

zstyle ':omz:update' verbose minimal # solo poche righe

zstyle ':omz:update' verbose silent # solo errori
```

### Aggiornamenti Manuali

Se vuoi aggiornare in qualsiasi momento (magari qualcuno ha appena rilasciato un nuovo plugin e non vuoi aspettare una settimana?) ti basta eseguire:

```sh
omz update
```

> [!NOTE]
> Se vuoi automatizzare questo processo in uno script, dovresti chiamare direttamente lo script `upgrade`, così:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Vedi altre opzioni nelle [FAQ: Come aggiorno Oh My Zsh?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **L’USO DI `omz update --unattended` È STATO RIMOSSO, IN QUANTO AVEVA EFFETTI COLLATERALI**.

Magia! 🎉

## Disinstallare Oh My Zsh

Oh My Zsh non fa per tutti. Ci mancherai, ma vogliamo rendere questa separazione facile.

Se vuoi disinstallare `oh-my-zsh`, basta eseguire `uninstall_oh_my_zsh` dalla riga di comando. Verrà rimosso automaticamente e ripristinata la tua precedente configurazione di `bash` o `zsh`.

## Come Contribuire a Oh My Zsh?

Prima di partecipare alla nostra splendida comunità, leggi il [codice di condotta](CODE_OF_CONDUCT.md).

Non sono affatto un esperto di [Zsh](https://www.zsh.org/) e sospetto ci siano molti modi per migliorare – se hai idee su come rendere la configurazione più facile da mantenere (e più veloce), non esitare a fare fork e inviare pull request!

Abbiamo anche bisogno di persone che testino le pull request. Quindi dai un’occhiata a [gli issue aperti](https://github.com/ohmyzsh/ohmyzsh/issues) e aiuta dove puoi.

Vedi [Contributing](CONTRIBUTING.md) per maggiori dettagli.

### Non Inviare Temi

Abbiamo (più che) abbastanza temi per ora. Aggiungi il tuo tema alla pagina wiki dei [temi esterni](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

## Contributori

Oh My Zsh ha una comunità vibrante di utenti felici e collaboratori entusiasti. Senza tutto il tempo e l’aiuto dei nostri collaboratori, non sarebbe così fantastico.

Grazie di cuore!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Seguici

Siamo sui social media:

- [@ohmyzsh](https://x.com/ohmyzsh) su X (precedentemente Twitter). Dovresti seguirci.
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) scrivici.
- [Instagram](https://www.instagram.com/_ohmyzsh/) taggaci in un post che mostra Oh My Zsh!
- [Discord](https://discord.gg/ohmyzsh) per chattare con noi!

## Merchandising

Abbiamo a disposizione [adesivi, magliette e tazze da caffè](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github) per mostrare il tuo amore per Oh My Zsh. Ancora una volta, diventerai l’argomento di conversazione della città!

## Licenza

Oh My Zsh è rilasciato sotto [licenza MIT](LICENSE.txt).

## Info su Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh è stato avviato dal team di [Planet Argon](https://www.planetargon.com/?utm_source=github), una [agenzia di sviluppo Ruby on Rails](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github). Dai un’occhiata ai nostri [altri progetti open source](https://www.planetargon.com/open-source?utm_source=github).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---