## MCP-Zero: Descoberta Ativa de Ferramentas para Agentes Autônomos LLM

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


Obrigado pela sua atenção ao MCP-Zero! 🤗

Agora abrimos o código fonte envolvido no artigo. Continuaremos a atualizar nosso trabalho, explorar sua aplicação na indústria e expandir este projeto.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> Usando o MCP-Zero para construir proativamente cadeias de ferramentas para "Preparar uma ótima refeição"</p>
</div>


### Método: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # experimentos: APIBank
├── experiment_mcptools.py      # experimentos: mcp_tools (teste de agulha)
├── matcher.py                  # código para correspondência por similaridade
├── prompt_guide/               # prompts para nosso método
├── reformatter.py              # formatador json para descrição da ferramenta
├── sampler.py                  # amostrador para seleção da ferramenta alvo
├── test_cases.jsonl            # caso de teste para o matcher
├── test_matcher.py             # teste unitário para o matcher
└── utils.py                    # utilitários: grid_search
```

Agora liberamos nosso código do artigo. O código apresentado implementa capacidades de recuperação e obtém resultados concretos nos experimentos.

Em nosso trabalho futuro, estamos comprometidos em aplicar o MCP-zero na indústria, então outros módulos ainda precisam ser desenvolvidos, como a implantação dinâmica dos servidores MCP, implantação de ambiente para o teste GAIA, etc. Continuaremos a aprimorar nosso trabalho, e obrigado a todos pela atenção a este projeto. Deixe uma estrela🌟 para eu saber que você está acompanhando :D



### Conjunto de Dados: MCP-tools

- **Google Drive**: [Link para Download](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Link Huggingface**: Em breve
- **Coloque o arquivo em**: `./MCP-tools/mcp_tools_with_embedding.json`


**Introdução**: Um conjunto de dados contendo todas as ferramentas filtradas (308 servidores e 2.797 ferramentas no total) do repositório oficial do MCP.

**Estrutura dos dados**:
```
{
  "server_name": string, // O nome do servidor MCP, extraído ou inferido do README
  "server_summary": string, // Um resumo do propósito e capacidades do servidor, baseado em todas as partes relevantes do README.
  "server_description": string, // Descrição proveniente dos metadados.
  "description_embedding": float[3072], // O embedding da descrição do servidor, extraído do text-embedding-3-large
  "summary_embedding": float[3072], // O embedding do resumo do servidor, extraído do text-embedding-3-large
  "tools": [
    {
      "name": string, // O nome da função/ferramenta
      "description": string, // Uma descrição concisa do que a ferramenta faz
      "description_embedding": float[3072], // O embedding da descrição da ferramenta, extraído do text-embedding-3-large
      "parameter": { // Um dicionário dos parâmetros de entrada, incluídos se definidos explicitamente
        "param1": "(tipo) descrição1",
        "param2": "(Opcional, tipo) descrição2"
      }
    }
  ]
}
```

**Construa o conjunto de dados você mesmo**: Se você deseja construir um conjunto de dados personalizado para servidores MCP, pode seguir o código na pasta `MCP-tools/build_data`.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # código para extrair dados estruturais do arquivo ReadMe do servidor MCP
│   ├── run_vllm.sh                 # implanta o modelo Qwen2.5-72B-Instruct com VLLM
│   └── server_summary.prompt       # prompt para extração do conjunto de dados
└── download_data.md
```


### Citação

> Citação me deixa feliz.
> 
>   --Shakespeare
>   ~~(apenas por diversão :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
ano={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---