# Editor de Novelas com IA

Editor de novelas assistido por IA baseado em PyQt6, oferecendo ferramentas profissionais de escrita como autocompletar inteligente, gerenciamento de projetos, organização de conceitos, entre outros.

## Instalação

1. Clonar o projeto
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Criar ambiente virtual
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Instalar dependências
```bash
pip install -r requirements.txt
```
4. Executar o programa
```bash
python src/main.py
```

## Funcionalidades Principais

### Gerenciamento de Projetos
- Estrutura de documentos hierárquica (Obra > Capítulo > Cena)
- Importação e exportação de projetos (suporte aos formatos TEXT, MARKDOWN, DOCX, PDF, HTML)
- Backup automático e controle de versões
- Gerenciamento de múltiplos projetos

### Função de Autocompletar com IA
- Três modos de autocompletar: autocompletar automático, autocompletar manual (recomendado: pressione Tab uma vez para acionar, pressione Tab novamente para aplicar o complemento), desativar autocompletar
- Três modos de contexto:
  - Modo rápido: contexto leve, resposta rápida
  - Modo equilibrado: contexto médio, equilíbrio entre qualidade e velocidade
  - Modo global: contexto completo do projeto, melhor resultado
- Suporte a vários serviços de IA: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, etc.
### Gerenciamento de Tópicos
- Estrutura de árvore de tópicos visualizável
- Ordenação por arrastar e soltar e ajuste de hierarquia
- Navegação rápida pelo documento
- Análise de tópicos e sugestões de otimização

### Configuração de API
- Centro unificado de configuração de IA
- Configurações predefinidas para múltiplos provedores
- Função de teste de conexão
- Salvar, importar e exportar esquemas de configuração

### Configurações de Autocompletar Inteligente
- Atraso de disparo ajustável
- Limite de comprimento de autocompletar
- Configuração de comprimento de contexto
- Suporte a respostas em fluxo

### Edição de Prompt
- Diversos modelos de escrita integrados
- Modelos de prompt personalizados
- Gerenciamento de categorias de modelos
- Configuração de modelos específicos para cada modo
### Funcionalidades da Interface
- Tema duplo claro/escuro
- Layout em três colunas (árvore de projetos, editor, painel de conceitos)
- Barra lateral recolhível
- Modo de escrita em tela cheia
- Modo de foco (frase, parágrafo, máquina de escrever, modo zen, modo imersivo)

### Pesquisa e Substituição
- Pesquisa de texto em todo o projeto
- Suporte a expressões regulares
- Função de substituição em massa
- Opções avançadas de pesquisa

### Gerenciamento de Conceitos
- Detecção automática de personagens, locais e itens
- Gerenciamento de relações entre conceitos
- Sistema de etiquetas e categorias
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


## Requisitos do sistema

- Python 3.8+
- PyQt6
- Sistema operacional: Windows, macOS, Linux

## Autor

**inliver**
- E-mail: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---