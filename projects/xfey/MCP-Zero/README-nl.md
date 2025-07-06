## MCP-Zero: Actieve Hulpmiddelenontdekking voor Autonome LLM Agenten

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


Bedankt voor je interesse in MCP-Zero! 🤗

We hebben nu de code uit het paper open-source gemaakt. We zullen ons werk blijven updaten, de toepassing ervan in de industrie verkennen, en dit project blijven uitbreiden.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> MCP-Zero gebruiken om proactief toolchains te construeren voor "Een geweldige maaltijd maken"</p>
</div>


### Methode: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # experimenten: APIBank
├── experiment_mcptools.py      # experimenten: mcp_tools (needle test)
├── matcher.py                  # code voor similariteitsmatching
├── prompt_guide/               # prompts voor onze methode
├── reformatter.py              # json formatter voor toolomschrijving
├── sampler.py                  # sampler voor het selecteren van doelfunctie
├── test_cases.jsonl            # testcase voor de matcher
├── test_matcher.py             # unittest voor de matcher
└── utils.py                    # utils: grid_search
```

We hebben nu onze code voor het paper vrijgegeven. De code in het paper implementeert retrieval-mogelijkheden en behaalt concrete resultaten in experimenten.

In ons toekomstige werk zijn we toegewijd aan het toepassen van MCP-zero in de industrie, dus andere modules moeten nog worden betrokken, zoals de dynamische implementatie van MCP-servers, de omgevingsimplementatie voor de GAIA-test, enz. We zullen ons werk blijven verbeteren, en dank jullie allemaal voor de aandacht voor dit werk. Laat een ster🌟 achter om te laten weten dat je op de hoogte blijft :D



### Dataset: MCP-tools

- **Google Drive**: [Downloadlink](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface Link**: Binnenkort beschikbaar
- **Plaats het bestand in**: `./MCP-tools/mcp_tools_with_embedding.json`


**Introductie**: Een dataset met alle gefilterde tools (totaal 308 servers en 2.797 tools) uit de officiële MCP-repository.

**Datastructuur**:
```
{
  "server_name": string, // De naam van de MCP-server, geëxtraheerd of afgeleid uit de README
  "server_summary": string, // Een samenvatting van het doel en de mogelijkheden van de server, gebaseerd op alle relevante delen van de README.
  "server_description": string, // Beschrijving uit metadata.
  "description_embedding": float[3072], // De embedding van de serverbeschrijving uit text-embedding-3-large
  "summary_embedding": float[3072], // De embedding van de serversamenvatting uit text-embedding-3-large
  "tools": [
    {
      "name": string, // De functie/toolnaam
      "description": string, // Een beknopte beschrijving van wat de tool doet
      "description_embedding": float[3072], // De embedding van de toolbeschrijving uit text-embedding-3-large
      "parameter": { // Een dictionary van invoerparameters, indien expliciet gedefinieerd
        "param1": "(type) beschrijving1",
        "param2": "(Optioneel, type) beschrijving2"
      }
    }
  ]
}
```

**Bouw de dataset zelf**: Als je een aangepaste dataset voor MCP-servers wilt bouwen, kun je de code in de map `MCP-tools/build_data` volgen.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # code om structurele data uit de ReadMe van MCP-server te halen
│   ├── run_vllm.sh                 # de Qwen2.5-72B-Instruct model uitrollen met VLLM
│   └── server_summary.prompt       # de prompt voor het extraheren van de dataset
└── download_data.md
```


### Referentie

> Citeren maakt me gelukkig.
> 
>   --Shakespeare
>   ~~(gewoon voor de lol :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang en Zheng, Xiawu en Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
  jaar={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---