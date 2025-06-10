# AI Screenshot Translator (AI Screenshot Translator)

[![Versão do Python](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Versão de Lançamento](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Introdução

Esta ferramenta permite, por meio de **simples operações de captura de tela**, enviar imagens para um modelo de IA para reconhecimento e tradução de texto, exibindo o resultado traduzido em formato HTML interativo em uma janela independente.

A ferramenta suporta **atalhos de teclado personalizáveis, gerenciamento de múltiplas janelas de resultados e execução na bandeja do sistema**, aumentando consideravelmente a eficiência da tradução no trabalho e nos estudos diários.

**Características da ferramenta**: 1. Tradução por captura de tela, iniciada por atalho; 2. Captura de tela e tradução em patches, podendo ser movidos e redimensionados livremente, permitindo criar múltiplos patches de tradução; 3. Fórmulas podem alternar para texto original para facilitar a cópia; 4. Interface de API personalizada.

**Problemas que pretende resolver**: 1. As soluções atuais para tradução de documentos inteiros são pesadas e pouco práticas; 2. Ao copiar texto de PDFs para traduzir, fórmulas podem ficar desordenadas ou impossíveis de copiar; 3. PDFs digitalizados a partir de imagens não permitem a cópia de texto.

# Demonstração

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Exibição de Janelas

Janela de tradução:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Janela de configuração:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Para uma explicação mais detalhada das opções de configuração, consulte o próprio software ou veja na web em [Dicas](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# Instalação

Você pode baixar o código-fonte para executar ou acessar a página de [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) para baixar o executável.

### 1. Clonar o repositório

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Criar ambiente virtual e executar

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# Plano de Atualizações

- ~~Nova interface gráfica para configuração de API, otimizando a lógica de configuração manual do arquivo yaml para geração automática pelo software (concluído na v0.3.0)~~
- Novo sistema de armazenamento de imagens e fórmulas, facilitando consultas futuras (previsto para v0.4)
- (Sugestões de novas funcionalidades são bem-vindas via issues ou contribuições de PR)

# Outros

- O ícone do software é de [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Agradecimentos ao Gemini 2.5 Flash e DeepSeek-V3-0324 por ajudarem a encontrar bugs

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---