
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Terminara

[![Pergunte ao DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Suporte Python](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

Um jogo de simulação de IA baseado em terminal.

## Como usar

Você pode baixar o aplicativo executável na [última versão](https://github.com/luyiourwong/Terminara/releases/latest).

O arquivo compactado completo inclui o arquivo executável e o arquivo de configurações padrão do mundo. Você pode baixar apenas o arquivo executável se estiver atualizando o jogo para a versão mais recente.

| SO      | Versão                                            |
|---------|---------------------------------------------------|
| Windows | Windows 10, Windows 11                            |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS  |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26            |

<details>
<summary><strong>Execução manual</strong></summary>

### Instalação

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **Crie um ambiente virtual:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    No Windows, use `.venv\Scripts\activate`

3.  **Instale as dependências:**
    ```bash
    pip install -e .
    ```

### Método de Início 1: Usando o comando instalado (Recomendado)
Após a instalação, execute o jogo com:
```bash
terminara
```

### Método de Inicialização 2: Execução direta
Forma multiplataforma
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
No Windows, use `terminara\main.py`

para mais informações, veja [Guia de Contribuição & Desenvolvimento](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## Configuração de IA

Após iniciar o aplicativo, você precisa configurar as definições de IA no menu principal.

![Configurações de IA](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

Você deve preencher os seguintes campos: (API compatível com OpenAI)
- **Host**: O endpoint da API. Deixe em branco para usar o endpoint padrão do OpenAI.
- **API Key**: Sua chave de API para o serviço de IA.
- **Model**: O modelo que deseja utilizar.

Clique em "Aplicar" para salvar as configurações.

### Exemplos

#### 1. [OpenAI](https://platform.openai.com/) (Padrão)
- **Host**: (deixe em branco)
- **API Key**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## Configuração do Mundo

### Armazenamento de Configuração
As configurações do mundo são armazenadas no diretório `terminara/data/worlds`. (na versão completa)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Criando um novo mundo
Há um mundo de exemplo [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). Você pode seguir o [esquema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) para criar um novo mundo.

## Links

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [Repositório GitHub](https://github.com/luyiourwong/Terminara)
- [Guia de Contribuição & Desenvolvimento](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---