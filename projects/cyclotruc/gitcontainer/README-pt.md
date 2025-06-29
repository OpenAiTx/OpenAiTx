![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Transforme qualquer repositório do GitHub em um container Docker pronto para produção com geração de Dockerfile impulsionada por IA.**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

O Gitcontainer é uma aplicação web impulsionada por IA que gera automaticamente Dockerfiles prontos para produção ao analisar repositórios do GitHub. Basta colar uma URL do GitHub e obter um Dockerfile personalizado com seleção inteligente de imagem base, gerenciamento de dependências e melhores práticas Docker.

## 🌟 Acesso Rápido

Basta substituir `github.com` por `gitcontainer.com` em qualquer URL de repositório do GitHub para acessar instantaneamente a página de geração de Dockerfile para esse repositório.

Por exemplo:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ Funcionalidades

- **🔄 Acesso Instantâneo por URL**: Basta substituir 'github.com' por 'gitcontainer.com' em qualquer URL do GitHub
- **🤖 Análise com IA**: Utiliza OpenAI GPT-4 para analisar a estrutura do repositório e gerar Dockerfiles inteligentes
- **⚡ Streaming em Tempo Real**: Assista à IA gerar seu Dockerfile em tempo real com streaming via WebSocket
- **🎯 Detecção Inteligente**: Detecta automaticamente stacks de tecnologia (Python, Node.js, Java, Go, etc.)
- **🔧 Pronto para Produção**: Gera Dockerfiles seguindo as melhores práticas, com segurança adequada, builds multi-stage e otimização
- **📋 Instruções Adicionais**: Adicione requisitos personalizados para ambientes especializados
- **📄 Docker Compose**: Sugere automaticamente um docker-compose.yml para aplicações complexas
- **🎨 UI Moderna**: Interface limpa e responsiva com editor Monaco para destaque de sintaxe
- **📱 Mobile Friendly**: Funciona perfeitamente em dispositivos desktop e móveis

## 🚀 Início Rápido

### Pré-requisitos

- Python 3.9 ou superior
- Git
- Chave de API da OpenAI

### Instalação

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Instale as dependências:**
   ```bash
   pip install -r requirements.txt
   ```

3. **Configure as variáveis de ambiente:**
   ```bash
   # Crie o arquivo .env
   echo "OPENAI_API_KEY=sua_chave_de_api_openai_aqui" > .env
   ```

4. **Execute a aplicação:**
   ```bash
   python app.py
   ```

5. **Abra seu navegador:**
   Acesse `http://localhost:8000`

## 🛠️ Como Funciona

1. **Processamento de URL**: Acesse qualquer repositório substituindo 'github.com' por 'gitcontainer.com' na URL
2. **Clonagem do Repositório**: O Gitcontainer clona o repositório do GitHub localmente usando o Git
3. **Análise de Código**: Utiliza o [gitingest](https://github.com/cyclotruc/gitingest) para analisar a estrutura do repositório e extrair informações relevantes
4. **Geração com IA**: Envia a análise para o OpenAI GPT-4 com prompts especializados para geração de Dockerfile
5. **Otimização Inteligente**: A IA considera:
   - Detecção de stack tecnológico
   - Gerenciamento de dependências
   - Melhores práticas de segurança
   - Builds multi-stage quando benéfico
   - Configuração de portas
   - Variáveis de ambiente
   - Health checks

## 📁 Estrutura do Projeto

```
cyclotruc-gitcontainer/
├── app.py                 # Aplicação principal FastAPI
├── requirements.txt       # Dependências Python
├── .env                  # Variáveis de ambiente (crie este arquivo)
├── static/               # Arquivos estáticos (ícones, CSS)
├── templates/
│   └── index.jinja       # Template HTML principal
└── tools/                # Módulos de funcionalidade central
    ├── __init__.py
    ├── create_container.py  # Geração de Dockerfile com IA
    ├── git_operations.py    # Clonagem de repositórios GitHub
    └── gitingest.py        # Análise de repositório
```
## 🔧 Configuração

### Variáveis de Ambiente

| Variável | Descrição | Obrigatório |
|----------|-----------|-------------|
| `OPENAI_API_KEY` | Sua chave de API OpenAI | Sim |
| `PORT` | Porta do servidor (padrão: 8000) | Não |
| `HOST` | Host do servidor (padrão: 0.0.0.0) | Não |

### Uso Avançado

Você pode usar as ferramentas programaticamente:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Clonar repositório
    clone_result = await clone_repo_tool(github_url)
    
    # Analisar com gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Gerar Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Uso
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Customização

### Adicionando Instruções Personalizadas

Use o recurso "Instruções adicionais" para personalizar a geração:

- `"Use Alpine Linux para um tamanho de imagem menor"`
- `"Inclua Redis e PostgreSQL"`
- `"Otimize para implantação em produção"`
- `"Adicione ferramentas de desenvolvimento para depuração"`

## 📝 Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 🙏 Agradecimentos

- **[OpenAI](https://openai.com/)** por fornecer a API GPT-4
- **[gitingest](https://github.com/cyclotruc/gitingest)** pelas capacidades de análise de repositório
- **[FastAPI](https://fastapi.tiangolo.com/)** pelo excelente framework web
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** pelo realce de sintaxe de código

## 🔗 Links

- **Repositório GitHub**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Demo**: Experimente ao vivo com repositórios de exemplo
- **Issues**: [Reporte bugs ou solicite funcionalidades](https://github.com/cyclotruc/gitcontainer/issues)

---

**Feito com ❤️ por [Romain Courtois](https://github.com/cyclotruc)**

*Transforme qualquer repositório em um container em segundos!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---