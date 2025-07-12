# Git Smart Squash

Smetti di perdere tempo a riorganizzare manualmente i commit. Lascia che sia l'IA a farlo per te.

## Il Problema

Ci sei passato anche tu: 15 commit per una funzionalità, metà dei quali sono "fix", "typo" o "WIP". Ora devi ripulirli per la revisione della PR. Effettuare lo squash e la riscrittura manuale è noioso.

## La Soluzione

Git Smart Squash analizza le tue modifiche e le riorganizza in commit logici con messaggi appropriati:

```bash
# Prima: il tuo branch disordinato
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation
```
# Dopo: commit puliti e logici
* feat: implementa il sistema di autenticazione JWT
* test: aggiungi la copertura degli endpoint di autenticazione
```

## Avvio Rapido

### 1. Installazione

```bash
# Usando pip
pip install git-smart-squash

# Usando pipx (consigliato per installazioni isolate)
pipx install git-smart-squash

# Usando uv (gestore di pacchetti Python veloce)
uv tool install git-smart-squash
```
### 2. Configura l'IA

**Opzione A: Locale (Gratuito, Privato)**
```bash
# Installa Ollama da https://ollama.com
ollama pull devstral  # Modello predefinito
```

**Opzione B: Cloud (Risultati migliori)**
```bash
export OPENAI_API_KEY="la-tua-chiave"
export ANTHROPIC_API_KEY="la-tua-chiave"
export GEMINI_API_KEY="la-tua-chiave"
```

### 3. Esegui

```bash
cd your-repo
git-smart-squash
```
Ecco fatto. Rivedi il piano e approva.

## Parametri della riga di comando

| Parametro | Descrizione | Predefinito |
|-----------|-------------|-------------|
| `--base` | Branch di base da confrontare | File di configurazione o `main` |
| `--ai-provider` | Fornitore AI da utilizzare (openai, anthropic, local, gemini) | Configurato nelle impostazioni |
| `--model` | Modello AI specifico da utilizzare (vedi modelli consigliati sotto) | Predefinito del fornitore |
| `--config` | Percorso al file di configurazione personalizzato | `.git-smart-squash.yml` o `~/.git-smart-squash.yml` |
| `--auto-apply` | Applica il piano di commit senza richiesta di conferma | `false` |
| `--instructions`, `-i` | Istruzioni personalizzate per l'AI (es. "Raggruppa per area funzionale") | Nessuna |
| `--no-attribution` | Disabilita il messaggio di attribuzione nei commit | `false` |
| `--debug` | Abilita il logging di debug per informazioni dettagliate | `false` |

## Modelli consigliati

### Modelli predefiniti
- **OpenAI**: `gpt-4.1` (predefinito)
- **Anthropic**: `claude-sonnet-4-20250514` (predefinito)
- **Gemini**: `gemini-2.5-pro` (predefinito)
- **Locale/Ollama**: `devstral` (predefinito)

### Selezione del Modello
```bash
# Specifica un modello diverso
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# Per Ollama locale
git-smart-squash --ai-provider local --model llama-3.1
```

## Istruzioni Personalizzate

Il parametro `--instructions` ti permette di controllare come vengono organizzati i commit:

### Esempi
```bash
# Aggiungi prefissi dei ticket
git-smart-squash -i "Prefissa tutti i commit con [ABC-1234]"

# Separa per tipologia
git-smart-squash -i "Mantieni le modifiche backend e frontend in commit separati"
```
# Limitare il numero di commit
git-smart-squash -i "Crea al massimo 3 commit in totale"
```

### Suggerimenti per risultati migliori
- **Sii specifico**: "Raggruppa separatamente le migrazioni del database" funziona meglio di "organizza bene"
- **Un'istruzione alla volta**: Istruzioni complesse e multi-parti potrebbero essere parzialmente ignorate
- **Usa modelli migliori**: I modelli più grandi seguono le istruzioni in modo più affidabile rispetto a quelli più piccoli

## Casi d'Uso Comuni

### "Devo fare pulizia prima della revisione PR"
```bash
git-smart-squash              # Mostra il piano e chiede conferma
git-smart-squash --auto-apply # Applica automaticamente senza chiedere conferma
```

### "Lavoro con un ramo principale diverso"
```bash
git-smart-squash --base develop
```
### "Voglio usare un provider AI specifico"
```bash
git-smart-squash --ai-provider openai
```

## Sicurezza

**Il tuo codice è al sicuro:**
- Mostra il piano prima di apportare modifiche
- Crea un branch di backup automatico
- Richiede una directory di lavoro pulita
- Non esegue mai il push senza il tuo comando

**Se qualcosa va storto:**
```bash
# Trova il backup
git branch | grep backup

# Ripristina
git reset --hard your-branch-backup-[timestamp]
```

## Fornitori di AI

| Fornitore  | Costo   | Privacy |
|------------|---------|---------|
| **Ollama**     | Gratis  | Locale  |
| **OpenAI**     | ~0,01 $ | Cloud   |
| **Anthropic**  | ~0,01 $ | Cloud   |
| **Gemini**     | ~0,01 $ | Cloud   |

## Configurazione Avanzata (Opzionale)

Vuoi personalizzare? Crea un file di configurazione:

**Specifico per il progetto** (`.git-smart-squash.yml` nella tua repo):
```yaml
ai:
  provider: openai  # Usa OpenAI per questo progetto
base: develop       # Usa develop come branch di base per questo progetto
```
**Impostazione predefinita globale** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # Usa sempre l’AI locale per impostazione predefinita
base: main          # Branch base predefinito per tutti i progetti
```

## Risoluzione dei problemi

### Errore "JSON non valido"
Di solito significa che il modello AI non è riuscito a formattare correttamente la risposta:
- **Con Ollama**: Passa da `llama2` a `mistral` o `mixtral`
- **Soluzione**: `ollama pull mistral` poi riprova
- **Alternativa**: Usa un provider cloud con `--ai-provider openai`

### Il modello non segue le istruzioni
Alcuni modelli hanno difficoltà con istruzioni complesse:
- **Usa modelli migliori**: `--model gpt-4-turbo` oppure `--model claude-3-opus`
- **Semplifica le istruzioni**: Una direttiva chiara funziona meglio di più istruzioni
- **Sii esplicito**: "Prefissa con [ABC-123]" e non "aggiungi il numero del ticket"
### "Ollama non trovato" 
```bash
# Installa da https://ollama.com
ollama serve
ollama pull devstral  # Modello predefinito
```

### Raggruppamento dei Commit Scarso
Se l'IA crea troppi commit o non li raggruppa bene:
- **Modello insufficiente**: Usa un modello più grande
- **Aggiungi istruzioni**: `-i "Raggruppa le modifiche correlate, massimo 3 commit"`
- **Fornisci feedback**: Crea un issue su GitHub e facci sapere cosa è successo

### Problemi di Installazione (Mac)
Se non hai pip o preferisci installazioni isolate:
```bash
# Usando pipx (consigliato)
brew install pipx
pipx install git-smart-squash
```
### "Nessuna modifica da riorganizzare"
```bash
git log --oneline main..HEAD  # Controlla se hai commit
git diff main                 # Controlla se hai modifiche
```

### Diff di grandi dimensioni / Limiti di token
I modelli locali hanno un limite di ~32k token. Per modifiche di grandi dimensioni:
- Usa `--base` con un commit più recente
- Passa al cloud: `--ai-provider openai`
- Dividi in PR più piccole

### Hai bisogno di ulteriore assistenza?

Consulta la nostra [documentazione dettagliata](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) oppure apri una segnalazione!

## Licenza

Licenza MIT - vedi il file [LICENSE](LICENSE) per i dettagli.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---