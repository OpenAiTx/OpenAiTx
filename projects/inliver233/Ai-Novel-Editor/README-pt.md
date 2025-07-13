<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# Editor de Novelas com IA

Editor de novelas assistido por IA baseado em PyQt6, oferecendo ferramentas profissionais de escrita como autocompletar inteligente, gerenciamento de projetos, organização de conceitos e mais.

## Instalação

1. Clone o projeto
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Crie um ambiente virtual
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```
Usando uv
```bash
uv venv -p 3.11
```
3. Instalar dependências
```bash
pip install -r requirements.txt
```
Usando uv
```bash
uv sync
```


4. Executar o programa
```bash
python -m src
```

## Funcionalidades Principais

### Gerenciamento de Projetos
- Estrutura hierárquica de documentos (Obra > Capítulo > Cena)
- Importação e exportação de projetos (suporte a TEXT, MARKDOWN, DOCX, PDF, HTML)
- Backup automático e controle de versões
- Gerenciamento de múltiplos projetos
### Função de Autocompletar por IA
- Três modos de autocompletar: autocompletar automático, autocompletar manual (recomendado: pressione Tab uma vez para acionar, pressione Tab novamente para aplicar), desabilitar autocompletar
- Três modos de contexto:
  - Modo rápido: contexto leve, resposta rápida
  - Modo equilibrado: contexto intermediário, equilíbrio entre qualidade e velocidade
  - Modo global: contexto completo do projeto, melhor desempenho
- Suporte a vários serviços de IA: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, entre outros

### Gerenciamento de Sumário
- Estrutura visual de árvore do sumário
- Ordenação por arrastar e soltar e ajuste de hierarquia
- Navegação rápida pelo documento
- Análise do sumário e sugestões de otimização

### Configuração de API
- Centro unificado de configuração de IA
- Configurações predefinidas para vários provedores de serviço
- Função de teste de conexão
- Salvar, importar e exportar esquemas de configuração
### Configurações de Autocompletar Inteligente
- Atraso de disparo ajustável
- Limite de comprimento de autocompletar
- Configuração do comprimento do contexto
- Suporte a resposta em fluxo

### Edição de Prompt
- Diversos modelos de escrita integrados
- Modelos de prompt personalizados
- Gerenciamento de categorias de modelos
- Configuração de modelos específicos para modos

### Funcionalidades da Interface
- Tema duplo claro/escuro
- Layout de três colunas (árvore de projetos, editor, painel de conceitos)
- Barra lateral recolhível
- Modo de escrita em tela cheia
- Modo de foco (sentença, parágrafo, máquina de escrever, modo zen, modo imersivo)

### Buscar e Substituir
- Pesquisa de texto em todo o projeto
- Suporte a expressões regulares
- Função de substituição em massa
- Opções avançadas de pesquisa

### Gerenciamento de Conceitos
- Detecção automática de personagens, locais, itens
- Gerenciamento de relações de conceitos
- Sistema de tags e classificação
- Inserção rápida de conceitos

## Atalhos de Teclado

- `Ctrl+N`: Novo projeto
- `Ctrl+O`: Abrir projeto
- `Ctrl+S`: Salvar documento
- `F11`: Modo tela cheia
- `Tab`: Acionar autocompletar por IA manualmente (no modo manual)
- `Ctrl+F`: Localizar
- `Ctrl+H`: Localizar e substituir
- `Ctrl+Shift+H`: Localizar e substituir avançado
## Requisitos do Sistema

- Python 3.8+
- PyQt6
- Sistema Operacional: Windows, macOS, Linux

## Autor

**inliver**
- E-mail: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---