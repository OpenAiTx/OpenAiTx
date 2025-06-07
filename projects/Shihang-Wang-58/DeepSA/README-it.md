[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: Un Predittore Basato sul Deep Learning per l’Accessibilità Sintetica dei Composti

Con il continuo sviluppo della tecnologia dell’intelligenza artificiale, sempre più modelli di generazione profonda vengono utilizzati per la generazione di molecole. Tuttavia, la maggior parte delle nuove molecole generate da questi modelli affronta spesso grandi sfide in termini di accessibilità sintetica.

DeepSA è stato proposto per prevedere l’accessibilità sintetica dei composti e presenta un tasso di arricchimento iniziale molto più elevato nel discriminare le molecole difficili da sintetizzare. Questo aiuta gli utenti a selezionare molecole meno costose da sintetizzare, riducendo così il tempo per la scoperta e lo sviluppo di farmaci. Puoi utilizzare DeepSA su un webserver all’indirizzo https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## Requisiti
Le dipendenze possono essere installate utilizzando il seguente comando:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# per la versione gpu
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Novità 🔔

* 2024-12, poiché [AutoGluon ha smesso di supportare la versione 3.8 di python](https://github.com/autogluon/autogluon/pull/4512) a partire da ottobre 2024. Pertanto, abbiamo aggiornato DeepSA per utilizzare la versione 3.12 di Python e aggiornato gli script di training e inferenza per adattarsi all’ultima versione di AutoGluon, grazie per il vostro interesse in DeepSA!

* 2023-7, DeepSA_v1.0 è stato rilasciato, siete invitati a fornire feedback sugli eventuali problemi!

## Dati
I dataset ampliati di training e test possono essere facilmente scaricati da https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing
## Utilizzo per Ricercatori
Se desideri addestrare il tuo modello, puoi eseguire dal terminale,

eseguendo:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Se desideri utilizzare il modello da noi proposto,

eseguendo:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Server Online

Abbiamo distribuito un modello pre-addestrato su un server dedicato, disponibile pubblicamente all’indirizzo https://bailab.siais.shanghaitech.edu.cn/deepsa, per facilitare l’uso di DeepSA da parte dei ricercatori biomedici nelle loro attività di ricerca.

Gli utenti possono caricare i propri file SMILES o csv sul server e ottenere rapidamente i risultati previsti.

## <span id="citelink">Citazione</span>
Se trovi utile questo repository nella tua ricerca, considera di citare il nostro articolo:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## Contatti
Per qualsiasi domanda, non esitare a contattare Shihang Wang (Email: wangshh12022@shanghaitech.edu.cn) o Lin Wang (Email: wanglin3@shanghaitech.edu.cn).

Le pull request sono fortemente benvenute!

## Ringraziamenti
Siamo grati per il supporto della HPC Platform della ShanghaiTech University.<br/>
Grazie a tutti per l’attenzione a questo lavoro.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---