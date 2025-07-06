## MCP-Zero: Scoperta Attiva di Strumenti per Agenti LLM Autonomi

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


Grazie per l’attenzione verso MCP-Zero! 🤗

Abbiamo ora reso open-source il codice coinvolto nell’articolo. Continueremo ad aggiornare il nostro lavoro, esplorare la sua applicazione nell’industria e ad espandere questo progetto.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> Utilizzo di MCP-Zero per costruire proattivamente toolchain per "Preparare un ottimo pasto"</p>
</div>


### Metodo: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # esperimenti: APIBank
├── experiment_mcptools.py      # esperimenti: mcp_tools (needle test)
├── matcher.py                  # codice per l’abbinamento di similarità
├── prompt_guide/               # prompt per il nostro metodo
├── reformatter.py              # json formatter per la descrizione degli strumenti
├── sampler.py                  # campionatore per selezionare lo strumento target
├── test_cases.jsonl            # testcase per il matcher
├── test_matcher.py             # unit test per il matcher
└── utils.py                    # utils: grid_search
```

Abbiamo ora rilasciato il nostro codice relativo all’articolo. Il codice nell’articolo implementa capacità di recupero ed ottiene risultati concreti negli esperimenti.

Nel nostro lavoro futuro, ci impegniamo ad applicare MCP-zero all’industria, quindi sono ancora necessari altri moduli, come il deployment dinamico dei server MCP, il deployment dell’ambiente per i test GAIA, ecc. Continueremo a migliorare il nostro lavoro, e grazie a tutti per l’attenzione a questo progetto. Lascia una stella🌟 per farmi sapere che resti aggiornato :D



### Dataset: MCP-tools

- **Google Drive**: [Link per il download](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface Link**: In arrivo
- **Inserisci il file in**: `./MCP-tools/mcp_tools_with_embedding.json`


**Introduzione**: Un dataset che contiene tutti gli strumenti filtrati (308 server e 2.797 strumenti in totale) dal repository ufficiale MCP.

**Struttura dei dati**:
```
{
  "server_name": string, // Il nome del server MCP, estratto o dedotto dal README
  "server_summary": string, // Un riassunto dello scopo e delle capacità del server, basato su tutte le parti rilevanti del README.
  "server_description": string, // Descrizione dai metadati.
  "description_embedding": float[3072], // L'embedding della descrizione del server da text-embedding-3-large
  "summary_embedding": float[3072], // L'embedding del riassunto del server da text-embedding-3-large
  "tools": [
    {
      "name": string, // Il nome della funzione/strumento
      "description": string, // Una descrizione concisa di ciò che fa lo strumento
      "description_embedding": float[3072], // L'embedding della descrizione dello strumento da text-embedding-3-large
      "parameter": { // Un dizionario dei parametri di input, incluso se esplicitamente definito
        "param1": "(type) description1",
        "param2": "(Optional, type) description2"
      }
    }
  ]
}
```

**Costruisci il dataset autonomamente**: Se vuoi costruire un dataset personalizzato per i server MCP, puoi seguire il codice nella cartella `MCP-tools/build_data`.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # codice per estrarre dati strutturali dal file ReadMe del server MCP
│   ├── run_vllm.sh                 # deployment del modello Qwen2.5-72B-Instruct con VLLM
│   └── server_summary.prompt       # il prompt per estrarre il dataset
└── download_data.md
```


### Citazione

> Citare mi rende felice.
> 
>   --Shakespeare
>   ~~(solo per divertimento :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang e Zheng, Xiawu e Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
anno={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---