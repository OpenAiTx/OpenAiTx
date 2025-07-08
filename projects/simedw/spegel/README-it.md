# Spegel – Rifletti il web attraverso l’IA

Riscrive automaticamente i siti web in markdown ottimizzato per la visualizzazione nel terminale.
Leggi l’articolo introduttivo [qui](https://simedw.com/2025/06/23/introducing-spegel/)

Questa è una prova di concetto, sono previsti bug ma sentiti libero di segnalare un problema o inviare una pull request.

##  Screenshot
A volte non vuoi leggere tutta la storia della vita di qualcuno solo per arrivare a una ricetta
![Esempio di Ricetta](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## Installazione

Richiede Python 3.11+

```
pip install spegel
```
oppure clona il repository e installalo in modalità modificabile

```bash
# Clona ed entra nella directory
$ git clone <repo-url>
$ cd spegel

# Installa le dipendenze e la CLI
$ pip install -e .
```

## Chiavi API
Attualmente Spegel supporta solo Gemini 2.5 Flash, per usarlo devi fornire la tua chiave API nell’ambiente

```
GEMINI_API_KEY=...
```


## Utilizzo

### Avvia il browser

```bash
spegel                # Avvia con la schermata di benvenuto
spegel bbc.com        # Apri subito un URL
```

Oppure, in modo equivalente:

```bash
python -m spegel      # Avvia con la schermata di benvenuto
python -m spegel bbc.com
```

### Comandi di base
- `/`         – Apri l’input URL
- `Tab`/`Shift+Tab` – Scorri i link
- `Enter`     – Apri il link selezionato
- `e`         – Modifica il prompt LLM per la vista corrente
- `b`         – Torna indietro
- `q`         – Esci

## Modifica delle impostazioni

Spegel carica le impostazioni da un file di configurazione TOML. Puoi personalizzare le viste, i prompt e le opzioni dell’interfaccia.

**Ordine di ricerca del file di configurazione:**
1. `./.spegel.toml` (directory corrente)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Per modificare le impostazioni:
1. Copia la configurazione di esempio:
   ```bash
   cp example_config.toml .spegel.toml
   # oppure crea ~/.spegel.toml
   ```
2. Modifica `.spegel.toml` con il tuo editor preferito.

Esempio di snippet:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Trasforma questa pagina web nella perfetta esperienza di navigazione da terminale! ..."
```

---

Per ulteriori informazioni, consulta il codice o apri una segnalazione!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---