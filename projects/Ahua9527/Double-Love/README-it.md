# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 Amore tra i frame, efficienza raddoppiata

[//]: # (Easter egg nascosto nel codice)
<!Double Love: ogni inquadratura nasconde il framerate che non ti ho mai detto -->

[English](./README.en.md) · 简体中文 · [Esperienza online](https://double-love.ahua.space)

</div>

Double Love fornisce un trattamento automatizzato e standardizzato dei metadati di clapboard. Supporta l'uso offline. Attraverso l'elaborazione batch e la gestione locale, realizza un'integrazione senza soluzione di continuità con Adobe Premiere, Silverstack, DTG Slate, assicurando la coerenza dei metadati. Migliora efficacemente l'efficienza del workflow di post-produzione.

## ✨ Caratteristiche principali

- 🎬 Supporto per i flussi di lavoro dell'industria cinematografica
- 📝 Trattamento intelligente e standardizzato dei metadati
- ⚡ Elaborazione locale a latenza zero
- 🧩 Integrazione perfetta con Adobe Premiere

## 🚀 Guida rapida

### Workflow di base

1. Registrazione clapboard: utilizzare DTG Slate per generare un foglio clapboard interattivo
2. Gestione dati: importare i dati clapboard tramite Silverstack Lab
3. Esportazione file: generare un XML per Adobe Premiere Pro
4. Trattamento standardizzato: ottimizzazione intelligente tramite Double Love

Esempio:
- xml in ingresso: `UnitA_304_20250127.xml`
- xml in uscita: `UnitA_304_20250127_Double_LOVE.xml`

### Esempi dettagliati

#### Ottimizzazione della denominazione dei file
- Il programma gestirà automaticamente il formato di numero scena, numero inquadratura e numero take
- Aggiunta automatica di zeri iniziali ai numeri
- Gestione automatica delle maiuscole e minuscole
- Pulizia automatica degli underscore superflui

#### Regole di denominazione dei segmenti

I nomi dei segmenti trattati seguono il formato:
```
{prefisso_progetto}{scena}_{inquadratura}_{take}{camera}{valutazione}
```

- `prefix`: prefisso personalizzato (opzionale)
- `scene`: numero scena (3 cifre, ad es. 001)
- `shot`: numero inquadratura (2 cifre, ad es. 01)
- `take`: numero take (2 cifre, ad es. 01)
- `camera`: identificativo camera (lettera minuscola, ad es. a)
- `Rating`: valutazione (ok/kp/ng)

#### Gestione delle valutazioni
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### Informazioni DIT
- Aggiunta automatica delle informazioni DIT: 'DIT: 哆啦Ahua 🌱'
- Se vuoi rimuoverlo, effettua il deploy in autonomia 😁😁

#### Esempio di prefisso personalizzato

1. Impostare il prefisso su "PROJECT_A_":
   - File in ingresso: `A304C007_250123G3`
   - File in uscita: `PROJECT_A_004_01_07a_kp`

2. Senza prefisso:
   - File in ingresso: `A304C007_250123G3`
   - File in uscita: `004_01_07a_kp`

#### Esempio di impostazione risoluzione sequenza

1. Risoluzione FHD (predefinita):
   - Larghezza: 1920
   - Altezza: 1080   
2. Risoluzione DCI 2K (personalizzata):
   - Larghezza: 2048
   - Altezza: 1080   

#### Esempio di elaborazione batch

1. Caricare più file contemporaneamente:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. Dopo l'elaborazione otterrai:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Stack tecnologico

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- Supporto PWA

## 📦 Installazione e utilizzo

1. Clona il progetto

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Installa le dipendenze

```bash
npm install
```

3. Sviluppo locale

```bash
npm run dev
```

4. Build del progetto

```bash
npm run build
```

## 🔒 Note sulla sicurezza

- Tutti i file vengono elaborati localmente nel browser, non vengono caricati su alcun server
- Supporta un limite massimo di 50MB per file
- Supporta solo file in formato XML

## 🌈 Note per sviluppatori

### Struttura del progetto

```
Double-Love/
├── src/
│   ├── components/     # Componenti React
│   ├── context/       # React Context
│   ├── utils/         # Funzioni di utilità
│   ├── styles/        # File di stile
│   └── App.tsx        # Componente principale dell'app
├── public/            # Risorse statiche
└── ...file di configurazione
```

## 📃 Licenza

[Licenza MIT](LICENSE)

## 🤝 Linee guida per i contributi

Sono benvenute Issue e Pull Request!

## 👨‍💻 Autore

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---