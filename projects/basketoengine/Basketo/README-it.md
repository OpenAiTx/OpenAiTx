<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Logo del Motore di Gioco Basketo" width="200"/>
</p>

<h2 align="center">Crea, Gioca, Ispira. Giochi che prendono vita. ✨</h2>

<h1 align="center">Motore di Gioco Basketo</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Sostituisci your_discord_server_id con il tuo vero server ID -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (precedentemente Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Benvenuto nel Motore Basketo - un progetto di passione in cui stiamo mettendo il massimo impegno per creare un motore straordinario e performante, con l'entusiasmante obiettivo di renderlo un motore di gioco AI-Nativo. Offre un'interfaccia dell'editor simile a Unity, integrazione con Gemini AI, un sistema avanzato di effetti multi-suono e una potente architettura ECS. Che tu sia qui per contribuire, suggerire idee o semplicemente osservare la sua crescita, fai parte del viaggio! 🚀
</p>
## 🚀 Stato Attuale del Motore
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Current State of Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>Scopri gli ultimi sviluppi e le funzionalità in azione!</em> 🎮
</p>

## ✨ Caratteristiche Principali

### 🎮 **Interfaccia Editor in stile Unity**
- **Impostazione a doppia finestra**: Editor della scena e visualizzazione del gioco affiancati
- **Modifica in tempo reale**: Modifica le scene mentre il gioco è in esecuzione
- **Pannello ispettore**: Modifica visiva dei componenti con drag-and-drop
- **Vista gerarchia**: Organizza e gestisci le entità
- **Browser delle risorse**: Gestione semplice di texture e audio

### 🤖 **Sviluppo AI-Nativo**
- **Integrazione Gemini AI**: Comandi in linguaggio naturale per lo sviluppo di giochi
- **Generazione intelligente di script**: Creazione di script Lua assistita dall’IA
- **Modifica delle entità**: Descrivi le modifiche in inglese semplice
- **Configurazione API facilitata**: Configurazione integrata della chiave API Gemini
### 🔊 **Sistema Audio Avanzato**
- **Effetti sonori multipli**: Suoni nominati multipli per entità (camminata, salto, attacco, ecc.)
- **Audio tradizionale**: Musica di sottofondo e suoni ambientali
- **Integrazione Lua**: Attiva suoni dagli script con `PlaySound(entity, "action")`
- **Editor visivo**: Gestione degli effetti sonori tramite l’ispettore

### 🎯 **Entity-Component-System (ECS)**
- **Alta prestazione**: Ottimizzato per grandi quantità di entità
- **Design modulare**: Componenti combinabili secondo necessità
- **Integrazione script**: Scripting Lua con pieno accesso all’ECS
- **Aggiornamenti in tempo reale**: Modifica live dei componenti

### 🎨 **Grafica & Animazione**
- **Rendering sprite**: Pipeline grafica 2D efficiente
- **Sistema di animazione**: Animazioni a fotogrammi con loop
- **Sistema di trasformazione**: Posizione, rotazione e scala
- **Sistema telecamera**: Supporto per più telecamere

### ⚡ **Fisica & Collisioni**
- **Rilevamento collisioni**: Collisioni AABB con ottimizzazione spaziale
- **Fisica rigidbody**: Gravità, velocità e forze
- **Callback collisioni**: Eventi di collisione accessibili da script
- **Partizionamento spaziale**: Ottimizzazione quadtree per le prestazioni
## 🎬 Clicca sull'immagine qui sotto per vedere una dimostrazione video:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## 🚀 Guida Rapida

### 1. **Ottieni la tua Gemini API Key** (Opzionale ma consigliato)
- Visita [Google AI Studio](https://aistudio.google.com/app/apikey)
- Accedi e crea una chiave API gratuita
- Questo abilita funzionalità AI come i comandi in linguaggio naturale

### 2. **Compila ed Esegui**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **Configura le Funzionalità AI**
- Nel motore, vai al pannello AI Prompt (in basso)
- Cerca "🤖 Configurazione Gemini AI"
- Inserisci la tua chiave API e clicca su "Salva"

### 4. **Inizia a Creare**
- Prova i comandi AI: `"crea un giocatore a 100 200"`
- Aggiungi effetti sonori alle entità nell'ispettore
- Scrivi script Lua o lascia che l'AI li generi
- Usa l'editor a doppia finestra per lo sviluppo live

## �🛠️ Compilazione del Motore (Linux) 🐧

### Prerequisiti
- È richiesto CMake 3.26.0 o superiore.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (per le funzionalità AI)
- nlohmann/json (incluso come submodulo)
- ImGui (incluso come submodulo)
### Passaggi di compilazione
```bash
# Clona il repository
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Esecuzione
```bash
./BasketoGameEngine

```
Se vuoi eseguire il test di fisica:
```bash
./PhysicsTest

```

## 🛠️ Compilazione del Motore (Windows) 💻

### Prerequisiti

1. **Visual Studio 2022 (Community Edition o superiore)**  
   Installa con i seguenti carichi di lavoro:
   - Sviluppo desktop con C++
   - Strumenti CMake per C++ su Windows
   - SDK di Windows 10 o 11

2. **CMake** (incluso con Visual Studio oppure scaricabile da https://cmake.org/download/)

3. **vcpkg** (utilizzato per installare le dipendenze)


---
### Installa le Dipendenze

```bash
# Apri un Developer Command Prompt per VS 2022 o PowerShell

# Clona vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Installa le librerie richieste
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Passaggi di Compilazione
```bash
# Clona il repository Basketo
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# Configura con CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# Sostituisci "C:/path/to/vcpkg" con il percorso completo della tua directory vcpkg

# Compila il motore
cmake --build . --config Release
```

---

### Esecuzione

```bash
# Dalla directory build/Release
```
./BasketoGameEngine.exe

# Per eseguire il test della fisica
./PhysicsTest.exe
```

## 📚 Documentazione

### Funzionalità Principali
- **[Sistema di Effetti Sonori](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: Guida completa agli effetti sonori multipli
- **[Configurazione API Gemini](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: Configurazione AI passo dopo passo
- **[Scripting Lua](assets/Scripts/)**: Script di esempio e riferimento API

### Esempio di Utilizzo

#### Sviluppo Basato su AI
```bash
# Comandi in linguaggio naturale
"crea un personaggio giocatore alla posizione 100 200"
"aggiungi il comportamento di salto al giocatore"
"fai muovere il nemico più velocemente"

# Generazione di script
gemini_script crea un controller platformer con doppio salto
```

#### Effetti sonori multipli
```lua
-- Nei tuoi script Lua
PlaySound(entity, "jump")    -- Riproduci suono di salto
PlaySound(entity, "walk")    -- Riproduci suono di camminata
PlaySound(entity, "attack")  -- Riproduci suono di attacco

-- Controlla se il suono esiste
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### Sistema a componenti
- **Transform**: Posizione, rotazione, scala
- **Sprite**: Rendering delle texture
- **Animation**: Animazioni basate su frame
- **Script**: Script di comportamento Lua
- **Collider**: Collisione fisica
- **Rigidbody**: Simulazione fisica
- **Audio**: Musica di sottofondo
- **SoundEffects**: Suoni multipli nominati
- **Camera**: Gestione della visuale
## 🤝 Partecipa

Amiamo i contributi dalla nostra community ❤️. Per dettagli su come contribuire o eseguire il progetto per lo sviluppo, consulta le nostre [Linee Guida per i Contributi](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md). <!-- Supponendo che tu abbia questo file -->

- 🐛 Hai trovato un bug? Apri una issue!
- ✨ Hai un’idea interessante per una funzionalità? Raccontacela!
- 💻 Vuoi contribuire? Fai un fork, scrivi il codice e crea una pull request!

Costruiamo insieme questo engine e rendiamo lo sviluppo di giochi divertente e facile per tutti. 🌍

## 👥 Community
Benvenuto con un grande abbraccio 🤗. Siamo super entusiasti dei contributi della community di ogni tipo - che si tratti di miglioramenti al codice 📝, aggiornamenti alla documentazione 📚, segnalazioni di problemi 🐞, richieste di funzionalità 💡, e discussioni sul nostro Discord 🗣️.

Unisciti alla nostra community qui:

- 👋 [Unisciti alla nostra community Discord](https://discord.gg/F3DswRMW)
- ⭐ [Dacci una stella su GitHub](https://github.com/basketoengine/Basketo)

## 🙏 Sostienici:
Stiamo migliorando costantemente e presto arriveranno nuove funzionalità ed esempi 🌟. Se ami questo progetto, lasciaci una stella ⭐ sul repository GitHub [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) per rimanere aggiornato e aiutarci a crescere. 🌱

---

Buona programmazione e buon divertimento nello sviluppo di giochi! 🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---