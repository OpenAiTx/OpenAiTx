
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
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Italiano</a></p>
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

# Editor de Romances com IA

Editor de romances assistido por IA baseado em PyQt6, oferecendo ferramentas profissionais de escrita como autocompletar inteligente, gerenciamento de projetos e organização de conceitos.

## Instalação

1. Clone o projeto
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Criar ambiente virtual
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Instale as dependências
```bash
pip install -r requirements.txt
```

4. Execute o programa
```bash
python src/main.py
```

## Funcionalidades Principais

### Gerenciamento de Projetos
- Estrutura hierárquica de documentos (Obra > Capítulo > Cena)
- Importação e exportação de projetos (suporte a TEXT, MARKDOWN, DOCX, PDF, HTML)
- Backup automático e controle de versões
- Gerenciamento de múltiplos projetos

### Funcionalidade de Complementação por IA
- Três modos de complementação: complementação automática, complementação manual (recomenda-se pressionar TAB uma vez para acionar e novamente para aplicar), desabilitar complementação
- Três modos de contexto:
  - Modo rápido: contexto leve, resposta rápida
  - Modo equilibrado: contexto médio, equilíbrio entre qualidade e velocidade
  - Modo global: contexto completo do projeto, melhor desempenho
- Suporte a vários serviços de IA: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, etc.

### Gerenciamento de Esboço
- Estrutura visual em árvore para esboço
- Ordenação por arrastar e ajuste de hierarquia
- Navegação rápida pelo documento
- Análise de esboço e sugestões de otimização

### Configuração de API
- Centro unificado de configuração de IA
- Configurações predefinidas de vários provedores
- Função de teste de conexão
- Salvar e importar/exportar configurações

### Configurações de Complementação Inteligente
- Ajuste de atraso de ativação
- Limite de comprimento da complementação
- Configuração do comprimento de contexto
- Suporte a resposta em fluxo

### Edição de Prompt
- Diversos modelos de escrita integrados
- Modelos de prompt personalizáveis
- Gerenciamento de categorias de modelos
- Configuração de modelos específicos por modo

### Funcionalidades da Interface
- Tema duplo: claro e escuro
- Layout em três colunas (árvore de projetos, editor, painel de conceitos)
- Barra lateral recolhível
- Modo de escrita em tela cheia
- Modo de foco (frase, parágrafo, máquina de escrever, modo zen, modo imersivo)

### Busca e Substituição
- Busca de texto em todo o projeto
- Suporte a expressões regulares
- Função de substituição em massa
- Opções avançadas de pesquisa

### Gerenciamento de Conceitos
- Detecção automática de personagens, locais, itens
- Gerenciamento de relações de conceitos
- Sistema de etiquetas e categorias
- Inserção rápida de conceitos

## Atalhos de Teclado

- `Ctrl+N`: Novo projeto
- `Ctrl+O`: Abrir projeto
- `Ctrl+S`: Salvar documento
- `F11`: Modo tela cheia
- `Tab`: Acionar autocompletar IA manualmente (no modo manual)
- `Ctrl+F`: Localizar
- `Ctrl+H`: Localizar e substituir
- `Ctrl+Shift+H`: Localizar e substituir avançado


## Requisitos do Sistema

- Python 3.8+
- PyQt6
- Sistemas operacionais: Windows, macOS, Linux

## Autor

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---