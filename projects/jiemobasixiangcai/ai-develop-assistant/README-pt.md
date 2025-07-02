# 🚀 MCP AI Assistente de Desenvolvimento

> Ferramenta MCP para auxiliar desenvolvedores de IA na análise inteligente de requisitos e no design de arquitetura

## ✨ Recursos Principais

- **Esclarecimento Inteligente de Requisitos**: Identifica automaticamente o tipo de projeto e gera perguntas direcionadas
- **Gestão de Ramo Sensível**: Acompanha objetivos do projeto, design de funcionalidades, preferências técnicas, design UI, etc.
- **Geração Automática de Arquitetura**: Gera soluções de arquitetura técnica com base nos requisitos completos
- **Armazenamento Persistente**: Salva automaticamente os resultados da análise e suporta exportação de documentos

## 📁 Configuração Rápida

### Configuração da Versão Antiga
1. **Clonar o Código**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Ambiente Virtual Recomendado**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Instalar Dependências**
   ```bash
   pip install -r requirements.txt
   ```

4. **Local do Arquivo de Configuração**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Adicionar Configuração**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Reinicie o Claude Desktop**

### Configuração da Nova Versão
#### 🔧 Ferramentas Principais
1. **start_new_project** - Iniciar novo projeto
2. **create_requirement_blueprint** - Criar blueprint de requisitos
3. **requirement_clarifier** - Obter dicas de esclarecimento de requisitos
4. **save_clarification_tasks** - Salvar tarefas de esclarecimento
5. **update_branch_status** - Atualizar status do ramo
6. **requirement_manager** - Gerenciador de documentação de requisitos
7. **check_architecture_prerequisites** - Verificar pré-requisitos de arquitetura
8. **get_architecture_design_prompt** - Obter dica de design de arquitetura
9. **save_generated_architecture** - Salvar design de arquitetura gerado
10. **export_final_document** - Exportar documento completo
11. **view_requirements_status** - Visualizar status dos requisitos

#### Configuração (copie para sua ferramenta, substitua MCP_STORAGE_DIR pelo seu diretório local)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 Fluxo de Utilização

### Passos Básicos

1. **Esclarecimento de Requisitos**
   ```
   requirement_clarifier("Quero criar uma plataforma de educação online")
   ```

2. **Gestão de Requisitos**
   ```
   requirement_manager("Usuários alvo: estudantes e professores", "Visão geral do projeto")
   ```

3. **Visualizar Status**
   ```
   view_requirements_status()
   ```
4. **Design de Arquitetura**
   ```
   architecture_designer("Arquitetura da Plataforma de Educação Online")
   ```

5. **Exportar Documento**
   ```
   export_final_document()
   ```

## 🚀 Comece a Usar

### Guia Rápido
1. **Configurar o Claude Desktop** (consulte o método de configuração acima)
2. **Reinicie o Claude Desktop**
3. **Comece a Análise Inteligente de Requisitos**:
   ```
   requirement_clarifier("Descreva sua ideia de projeto")
   ```
4. **Siga a orientação inteligente da IA**, aprimorando gradualmente cada ramificação dos requisitos
5. **Exporte o documento completo**:
   ```
   export_final_document()
   ```

### Melhores Práticas
- 💬 **Confie na gestão de ramificações da IA**: deixe a IA guiá-lo em todos os ramos de requisitos
- 🎯 **Expresse preferências claramente**: deixe claras suas preferências quanto à escolha de tecnologia, estilo de UI etc.
- 📊 **Verifique o status regularmente**: use `view_requirements_status` para acompanhar o progresso
- 🤖 **Autorize a IA quando necessário**: para partes incertas, diga "use a solução padrão"

---

**🎯 Agora você tem um verdadeiro assistente de desenvolvimento de IA inteligente, que lembrará de cada detalhe e irá guiá-lo na análise completa dos requisitos!**

## 💬 Grupo de Discussão

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="Grupo de Discussão">
<br>
Grupo de Discussão
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---