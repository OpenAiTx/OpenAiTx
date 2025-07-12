#寸止 🛑

> **L’“anti-eiaculazione precoce” dei dialoghi AI: lascia che la conversazione duri fino in fondo**

Sei ancora frustrato perché il tuo assistente AI termina sempre la conversazione troppo presto? Hai ancora tanto di cui parlare, ma lui ti chiede: "C’è qualcos’altro con cui posso aiutarti?" **寸止** è la soluzione a questo problema!

Quando l’AI vuole “liquidare la questione”, 寸止 fa comparire tempestivamente una finestra di dialogo che ti permette di continuare la conversazione in profondità, finché il problema non è davvero risolto.

## 🌟 Caratteristiche principali

- 🛑 **Intercettazione intelligente**: finestra automatica con opzioni per continuare quando l’AI vuole terminare
- 🧠 **Gestione della memoria**: memorizza norme di sviluppo e preferenze per progetto
- 🎨 **Interazione elegante**: supporto Markdown, vari metodi di input
- ⚡ **Pronto all’uso**: installazione in 3 secondi, supporto multipiattaforma

## 📸 Dai un’occhiata

### 🛑 Finestra di intercettazione intelligente
![寸止弹窗演示](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*Quando l’AI vuole terminare la conversazione, la finestra intelligente di 寸止 compare tempestivamente, offrendo opzioni predefinite per una scelta rapida e permettendo alla conversazione di continuare in profondità*
### ⚙️ Interfaccia di Gestione delle Impostazioni
![Interfaccia delle impostazioni di Cunzhi](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Interfaccia delle impostazioni elegante, supporta la gestione della memoria, interruttori delle funzionalità, cambio tema e generazione intelligente di prompt*

## 🚀 Iniziare a Usare

### Metodo 1: Installazione Rapida (Consigliato)

**Utenti macOS:**
```bash
# Installazione in 3 secondi, senza attesa per la compilazione
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Risoluzione dei problemi**: Se incontri un errore di download 404, esegui i seguenti passaggi:
>
> ```bash
> # Cancella la cache vecchia del tap
> brew untap imhuso/cunzhi
> # Reinstalla
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Esempio di errore comune:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> Questo solitamente è causato da un problema di cache della versione precedente che porta a una mancata corrispondenza delle versioni. Dopo aver cancellato il tap, reinstalla per risolvere il problema.

**Utenti Windows/Linux:**
Si consiglia di utilizzare il Metodo 2 per il download manuale, semplice e veloce!
### Metodo 2: Download manuale

1. Visita la [pagina delle Release](https://github.com/imhuso/cunzhi/releases)
2. Scarica la versione adatta al tuo sistema:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. Dopo l’estrazione, aggiungi `寸止` e `等一下` al PATH di sistema

## ⚡ Guida rapida

### Primo passo: Configurare il client MCP

Aggiungi al file di configurazione del tuo client MCP (come Claude Desktop):

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### Secondo passo: Aprire l’interfaccia delle impostazioni

```bash
# Esegui il comando delle impostazioni
Aspetta un attimo
```

### Terzo passo: Configurare le parole chiave suggerite

Nella scheda "Parole chiave di riferimento" dell’interfaccia delle impostazioni:
1. Visualizza le parole chiave generate automaticamente
2. Fai clic sul pulsante di copia
3. Aggiungi le parole chiave al tuo assistente AI

### Quarto passo: Inizia a utilizzare

Ora il tuo assistente AI dispone di funzioni di intercettazione intelligente, gestione della memoria e interazione tramite finestre popup!

> 💡 **Suggerimento**: puoi modificare le parole chiave generate per personalizzarle e creare un’esperienza di interazione AI su misura.
## 🤝 Partecipa e Contribuisci

Cunzhi è un progetto open source, accettiamo e incoraggiamo ogni tipo di contributo!

### 🐛 Hai trovato un problema?
- [Invia una Issue](https://github.com/imhuso/cunzhi/issues) per descrivere il problema
- Fornisci i passaggi per riprodurlo e le informazioni sull'ambiente

### 💡 Hai una buona idea?
- [Avvia una discussione](https://github.com/imhuso/cunzhi/discussions) per condividere la tua idea
- Invia una Pull Request per implementare nuove funzionalità

### 🛠️ Sviluppo locale
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Contattaci

- 🐛 **Segnalazione problemi**: [GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Discussione funzionalità**: [GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **Ti piace il progetto**: Supportaci con una Star!

## 📄 Licenza Open Source

Licenza MIT - Uso libero, contributi benvenuti!

---

<div align="center">

**Dì addio all’"eiaculazione precoce" nei dialoghi AI | Fai durare ogni conversazione fino alla fine**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 Segnala un bug](https://github.com/imhuso/cunzhi/issues) · [💡 Richiedi una funzionalità](https://github.com/imhuso/cunzhi/discussions)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---