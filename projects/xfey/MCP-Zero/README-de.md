## MCP-Zero: Aktive Werkzeugentdeckung für autonome LLM-Agenten

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


Vielen Dank für Ihr Interesse an MCP-Zero! 🤗

Wir haben nun den im Paper verwendeten Code als Open Source veröffentlicht. Wir werden unsere Arbeit weiterhin aktualisieren, ihre Anwendung in der Industrie erforschen und dieses Projekt weiter ausbauen.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> Verwendung von MCP-Zero zur proaktiven Konstruktion von Werkzeugketten für "Ein großartiges Essen zubereiten"</p>
</div>


### Methode: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # Experimente: APIBank
├── experiment_mcptools.py      # Experimente: mcp_tools (Needle-Test)
├── matcher.py                  # Code für Ähnlichkeitsabgleich
├── prompt_guide/               # Prompts für unsere Methode
├── reformatter.py              # JSON-Formatter für Werkzeugbeschreibung
├── sampler.py                  # Sampler zur Auswahl des Zielwerkzeugs
├── test_cases.jsonl            # Testfälle für den Matcher
├── test_matcher.py             # Unit-Test für den Matcher
└── utils.py                    # Utils: grid_search
```

Wir haben nun unseren Code zum Paper veröffentlicht. Der im Paper verwendete Code implementiert Abruffähigkeiten und erzielt konkrete Ergebnisse in den Experimenten.

In unserer zukünftigen Arbeit wollen wir MCP-zero in der Industrie anwenden, daher müssen noch weitere Module eingebunden werden, wie z.B. das dynamische Deployment von MCP-Servern, die Umgebungsbereitstellung für den GAIA-Test usw. Wir werden unsere Arbeit kontinuierlich verbessern und danken Ihnen allen für Ihre Aufmerksamkeit für dieses Projekt. Geben Sie einen Stern 🌟, damit ich weiß, dass Sie auf dem Laufenden bleiben :D



### Datensatz: MCP-tools

- **Google Drive**: [Download-Link](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface-Link**: Kommt bald
- **Datei ablegen unter**: `./MCP-tools/mcp_tools_with_embedding.json`


**Einführung**: Ein Datensatz, der alle gefilterten Werkzeuge (insgesamt 308 Server und 2.797 Werkzeuge) aus dem offiziellen MCP-Repository enthält.

**Datenstruktur**:
```
{
  "server_name": string, // Der Name des MCP-Servers, extrahiert oder abgeleitet aus der README
  "server_summary": string, // Eine Zusammenfassung des Serverzwecks und der Fähigkeiten, basierend auf allen relevanten Teilen der README.
  "server_description": string, // Beschreibung aus den Metadaten.
  "description_embedding": float[3072], // Das Embedding der Serverbeschreibung aus text-embedding-3-large
  "summary_embedding": float[3072], // Das Embedding der Serverzusammenfassung aus text-embedding-3-large
  "tools": [
    {
      "name": string, // Der Funktions-/Werkzeugname
      "description": string, // Eine kurze Beschreibung der Funktion des Werkzeugs
      "description_embedding": float[3072], // Das Embedding der Werkzeugbeschreibung aus text-embedding-3-large
      "parameter": { // Ein Dictionary der Eingabeparameter, sofern explizit definiert
        "param1": "(Typ) Beschreibung1",
        "param2": "(Optional, Typ) Beschreibung2"
      }
    }
  ]
}
```

**Datensatz selbst erstellen**: Wenn Sie einen eigenen Datensatz für MCP-Server erstellen möchten, können Sie dem Code im Ordner `MCP-tools/build_data` folgen.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # Code zum Extrahieren strukturierter Daten aus der ReadMe-Datei des MCP-Servers
│   ├── run_vllm.sh                 # Deployment des Qwen2.5-72B-Instruct-Modells mit VLLM
│   └── server_summary.prompt       # Prompt zum Extrahieren des Datensatzes
└── download_data.md
```


### Zitation

> Zitieren macht mich glücklich.
> 
>   --Shakespeare
>   ~~(nur zum Spaß :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang und Zheng, Xiawu und Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
``` 
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---