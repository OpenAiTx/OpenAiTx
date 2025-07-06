## MCP-Zero: Aktywne Odkrywanie Narzędzi dla Autonomicznych Agentów LLM

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


Dziękujemy za zainteresowanie MCP-Zero! 🤗

Kod opisany w artykule został już otwartoźródłowo udostępniony. Będziemy nadal aktualizować nasze prace, badać ich zastosowanie w przemyśle oraz rozwijać ten projekt.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> Wykorzystanie MCP-Zero do proaktywnej konstrukcji łańcuchów narzędzi dla zadania "Zrobienie świetnego posiłku"</p>
</div>


### Metoda: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # eksperymenty: APIBank
├── experiment_mcptools.py      # eksperymenty: mcp_tools (needle test)
├── matcher.py                  # kod do dopasowania podobieństwa
├── prompt_guide/               # prompty dla naszej metody
├── reformatter.py              # formater json dla opisu narzędzi
├── sampler.py                  # sampler do wyboru docelowego narzędzia
├── test_cases.jsonl            # przypadki testowe dla matchera
├── test_matcher.py             # testy jednostkowe dla matchera
└── utils.py                    # narzędzia: grid_search
```

Kod opisany w artykule został już udostępniony. Kod zaimplementowany w publikacji zapewnia możliwości wyszukiwania i osiąga konkretne wyniki w eksperymentach.

W naszej przyszłej pracy zobowiązujemy się do zastosowania MCP-zero w przemyśle, dlatego konieczne jest uwzględnienie także innych modułów, takich jak dynamiczne wdrażanie serwerów MCP, środowisko do testów GAIA itp. Nadal będziemy rozwijać nasz projekt — dziękujemy za uwagę poświęconą tej pracy. Zostaw gwiazdkę🌟 jeśli chcesz być na bieżąco :D



### Zbiór danych: MCP-tools

- **Google Drive**: [Link do pobrania](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface Link**: Wkrótce
- **Umieść plik w**: `./MCP-tools/mcp_tools_with_embedding.json`


**Wprowadzenie**: Zbiór danych zawierający wszystkie przefiltrowane narzędzia (308 serwerów i 2 797 narzędzi łącznie) z oficjalnego repozytorium MCP.

**Struktura danych**:
```
{
  "server_name": string, // Nazwa serwera MCP, wyodrębniona lub wywnioskowana z README
  "server_summary": string, // Podsumowanie celu i możliwości serwera, na podstawie wszystkich istotnych części README.
  "server_description": string, // Opis z metadanych.
  "description_embedding": float[3072], // Embedding opisu serwera z text-embedding-3-large
  "summary_embedding": float[3072], // Embedding podsumowania serwera z text-embedding-3-large
  "tools": [
    {
      "name": string, // Nazwa funkcji/narzędzia
      "description": string, // Krótki opis działania narzędzia
      "description_embedding": float[3072], // Embedding opisu narzędzia z text-embedding-3-large
      "parameter": { // Słownik parametrów wejściowych, zawierany jeśli jawnie zdefiniowane
        "param1": "(typ) opis1",
        "param2": "(Opcjonalne, typ) opis2"
      }
    }
  ]
}
```

**Zbuduj zbiór danych samodzielnie**: Jeśli chcesz przygotować własny zbiór danych dla serwerów MCP, możesz skorzystać z kodu znajdującego się w folderze `MCP-tools/build_data`.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # kod do ekstrakcji danych strukturalnych z pliku ReadMe serwera MCP
│   ├── run_vllm.sh                 # wdrażanie modelu Qwen2.5-72B-Instruct z VLLM
│   └── server_summary.prompt       # prompt do ekstrakcji zbioru danych
└── download_data.md
```


### Cytowanie

> Cytowanie sprawia mi radość.
> 
>   --Szekspir
>   ~~(tak dla zabawy :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---