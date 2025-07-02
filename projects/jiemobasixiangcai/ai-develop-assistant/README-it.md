# 🚀 MCP Assistente di Sviluppo AI

> Strumento MCP per assistere gli sviluppatori AI nell'analisi intelligente dei requisiti e nella progettazione dell'architettura

## ✨ Caratteristiche principali

- **Chiarimento intelligente dei requisiti**: Identificazione automatica del tipo di progetto, generazione di domande mirate
- **Gestione ramificata consapevole**: Tracciamento degli obiettivi di progetto, progettazione delle funzionalità, preferenze tecniche, design UI e altro
- **Generazione automatica dell'architettura**: Generazione di soluzioni architetturali tecniche basate su requisiti completi
- **Memorizzazione persistente**: Salvataggio automatico dei risultati dell'analisi, supporto per l'esportazione dei documenti

## 📁 Configurazione rapida

### Configurazione versione precedente
1. **Clona il codice**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Ambiente virtuale consigliato**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Installa le dipendenze**
   ```bash
   pip install -r requirements.txt
   ```

4. **Posizione del file di configurazione**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Aggiungi configurazione**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Riavvia Claude Desktop**

### Configurazione nuova versione
#### 🔧 Strumenti principali
1. **start_new_project** - Avvia un nuovo progetto
2. **create_requirement_blueprint** - Crea un blueprint dei requisiti
3. **requirement_clarifier** - Ottieni suggerimenti per il chiarimento dei requisiti
4. **save_clarification_tasks** - Salva i task di chiarimento
5. **update_branch_status** - Aggiorna lo stato della branch
6. **requirement_manager** - Gestore dei documenti dei requisiti
7. **check_architecture_prerequisites** - Verifica i prerequisiti dell'architettura
8. **get_architecture_design_prompt** - Ottieni suggerimenti per la progettazione dell'architettura
9. **save_generated_architecture** - Salva la progettazione architetturale generata
10. **export_final_document** - Esporta il documento completo
11. **view_requirements_status** - Visualizza lo stato dei requisiti

#### Configurazione (collega direttamente in remoto nel tuo strumento, sostituisci MCP_STORAGE_DIR con la tua directory locale)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 Flusso di utilizzo

### Passaggi di base

1. **Chiarimento dei requisiti**
   ```
   requirement_clarifier("Voglio creare una piattaforma di educazione online")
   ```

2. **Gestione dei requisiti**
   ```
   requirement_manager("Utenti target: studenti e insegnanti", "Panoramica del progetto")
   ```

3. **Visualizza stato**
   ```
   view_requirements_status()
   ```
4. **Progettazione dell’architettura**
   ```
   architecture_designer("Architettura della piattaforma di educazione online")
   ```

5. **Esporta documento**
   ```
   export_final_document()
   ```

## 🚀 Inizia a usare

### Guida rapida
1. **Configura Claude Desktop** (consulta il metodo di configurazione sopra)
2. **Riavvia Claude Desktop**
3. **Avvia l’analisi intelligente dei requisiti**:
   ```
   requirement_clarifier("Descrivi la tua idea di progetto")
   ```
4. **Segui la guida intelligente dell’AI** per perfezionare gradualmente ogni ramo dei requisiti
5. **Esporta il documento completo**:
   ```
   export_final_document()
   ```

### Best practice
- 💬 **Fidati della gestione dei rami da parte dell’AI**: lascia che l’AI ti guidi nel completare tutti i rami dei requisiti
- 🎯 **Esprimi chiaramente le tue preferenze**: specifica chiaramente le preferenze per la scelta tecnologica, lo stile UI, ecc.
- 📊 **Controlla regolarmente lo stato**: usa `view_requirements_status` per monitorare i progressi
- 🤖 **Autorizza opportunamente l’AI**: per le parti incerte puoi dire "usa la soluzione convenzionale"

---

**🎯 Ora hai un vero assistente di sviluppo AI intelligente, che ricorderà ogni dettaglio e ti guiderà attraverso l’analisi completa dei requisiti!**

## 💬 Gruppo di discussione

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="Gruppo di discussione">
<br>
Gruppo di discussione
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---