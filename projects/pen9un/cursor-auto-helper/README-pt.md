<h1 align="center">Bem-vindo ao&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Versão" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="Licença: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Versão do Cursor" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Ferramenta de continuação automática do Cursor, retry automático do Cursor, confirmação automática do Cursor, estatísticas de uso do Cursor, ferramenta de aprimoramento do Cursor, ferramenta auxiliar do Cursor, ferramenta de automação do Cursor, configuração de tema do Cursor, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor após 25 chamadas de ferramentas, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [Página Inicial](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper é uma ferramenta de automação aprimorada desenvolvida especialmente para o Cursor IDE, capaz de exibir o uso em tempo real, lidar automaticamente com o limite de 25 diálogos, falhas de conexão de rede, prompts de confirmação e outros cenários, proporcionando uma experiência de desenvolvimento mais fluida.

**Demonstração em vídeo:** [Vídeo de demonstração do Cursor Auto Helper](https://www.bilibili.com/video/BV1cajKzCEzv/)

Com prompts de alta qualidade e um bom planejamento de requisitos do projeto, este programa pode fazer com que o Cursor conclua um projeto automaticamente, sem intervenção humana.

> 🔒 **Compatibilidade de Versão**: Atualmente desenvolvido e testado nas versões Cursor 0.49.6 e Cursor 1.0.0, teoricamente compatível com as versões Cursor 0.48.x - 1.0.0.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖Registro de Atualizações

- 2025-06-01 Lançamento da versão v2.3, adição da função de configuração de tema do Cursor, otimização da estabilidade da injeção de código, correção da exibição do uso para estar consistente com o formato oficial
- 2025-05-21 Lançamento da versão v2.1, reestruturação da arquitetura, suporte multiplataforma, adição da função de exibição do uso em tempo real, etc.
- 2025-04-25 Conclusão da versão v1.0, tratamento automático do limite de 25 diálogos, falhas de conexão de rede, prompts de confirmação e outros cenários
- 2025-04-20 Início do projeto

## 🌟 Melhores Práticas do Cursor Auto Helper

Nota: Os documentos abaixo podem ser gerados por IA como o Cursor, mas precisam de verificação e ajuste manual.

**PASSO 1:** Design detalhado dos requisitos do sistema do projeto (quanto mais claros os requisitos, maior a qualidade do projeto), redija prompts de alta qualidade para o desenvolvimento do projeto em **SYSTEM.md**

**PASSO 2:** Com base em **SYSTEM.md**, gere um documento de proposta de design de sistema de alta qualidade **DESIGN.md**

**PASSO 3:** Com base em **SYSTEM.md** e **DESIGN.md**, gere um documento de plano de desenvolvimento de alta qualidade **TODOLIST.md**

**PASSO 4:** Use o **Cursor Auto Helper**, especifique **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md**, utilize prompts de feedback de continuação automática para que o Cursor execute o desenvolvimento do projeto de forma automatizada conforme o planejamento até a conclusão

**Prompt de feedback automático do Cursor Auto Helper:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Por favor, siga rigorosamente o plano de desenvolvimento do TODOLIST para o desenvolvimento das funcionalidades subsequentes e atualize o registro do TODOLIST em tempo real. Após a conclusão de cada tarefa, pergunte-me "Deseja continuar?" até que o projeto seja concluído, retornando "Projeto concluído".
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Instruções de Uso

Sinta-se à vontade para dar uma estrela ao projeto como apoio. Se houver dúvidas, por favor abra uma [Issue](https://github.com/pen9un/cursor-auto-helper/issues).

### 📝 Explicação do Arquivo de Configuração

O arquivo de configuração `config.ini` **é usado para personalizar o comportamento automatizado** (pode ser ajustado conforme necessário), suportando as seguintes opções:

#### Configuração Básica
```ini
[common]
log_enable = true     # Habilitar logs; se não quiser registrar logs, altere para false

[cursor]
path = C:\Path\To\Cursor.exe  # Caminho de instalação do Cursor IDE; o programa irá procurar automaticamente o caminho do Cursor, caso não seja encontrado, será exibido um aviso, basta alterar este item
```

#### Configuração de Ações Automáticas
Cada ação automática tem o prefixo `nome_da_ação.` e suporta os seguintes campos:

- `type`: Tipo de ação
  - `click`: Clicar no botão
  - `input_and_submit`: Inserir e enviar

- `text` / `text_list`: Conteúdo de texto a ser correspondido
  - `text`: String única
  - `text_list`: Várias strings separadas por |; se o conteúdo da página contiver qualquer um dos itens, será disparado

- `button_selector`: Seletor CSS do botão a ser clicado (necessário apenas para o tipo `click`)
- `button_text`: Texto do botão (opcional, restringe ainda mais o botão)
- `input_box_selector`: Seletor CSS da caixa de entrada (necessário para o tipo `input_and_submit`)
- `input_content`: Conteúdo a ser inserido automaticamente
- `submit_btn_selector`: Seletor CSS do botão de envio
- `delay`: Atraso antes da execução da ação (em milissegundos), pode ser usado para aguardar o carregamento da página

##### Exemplo de configuração
```ini
[auto_actions]
# Retry automático em caso de falha na conexão
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# após 25 chamadas de ferramentas
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "Por favor, continue"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_continue.delay = 1000

# Confirmação automática de continuação
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Atenção:**
> 1. O nome de cada action (como `action_retry`, `action_continue`) pode ser personalizado, mas todos os campos de um mesmo action devem ter o mesmo prefixo
> 2. Recomenda-se usar as ferramentas de desenvolvedor do navegador para localizar os seletores CSS, garantindo precisão
> 3. Após modificar o arquivo de configuração, é necessário reiniciar o programa para que as alterações tenham efeito

## 🎯 Cenários de Aplicação

### 💼 Desenvolvimento de Diálogos Longos
- Lida automaticamente com a limitação de 25 diálogos, suporta desenvolvimento de diálogos longos e contínuos, continua o fluxo automaticamente, aumentando a eficiência do desenvolvimento.

### 👥 Rede Instável
- Detecta automaticamente anomalias de rede, tenta reconectar de forma inteligente e restaura o diálogo automaticamente, garantindo continuidade no desenvolvimento.

### 🏢 Cenários de Confirmação
- Reconhece de forma inteligente situações de confirmação, lida automaticamente com prompts de confirmação, reduzindo a intervenção manual.

### 📚 Monitoramento de Uso
- Estatísticas em tempo real do número de diálogos, monitora o uso do Cursor, registra dados de utilização e otimiza a eficiência do uso.

Exibição de uso no terminal:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Exibição de uso no Cursor IDE:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟Descrição das Funcionalidades

### 🤖 Continuação Automática de Diálogos Longos
- Lida automaticamente com a limitação de 25 diálogos do Cursor, suporta múltiplos diálogos consecutivos.

### 🎨 Repetição Automática de Conexão
- Detecta automaticamente falhas de conexão de rede, tenta novamente de forma inteligente e monitora o status da conexão em tempo real.

### 📱 Confirmação Automática de Prompts
- Reconhece de forma inteligente vários cenários de confirmação, lida automaticamente com pop-ups de confirmação.
- Suporta personalização do conteúdo e resposta da confirmação, reduzindo a intervenção manual.
- Regras de configuração flexíveis, adaptando-se a processos de desenvolvimento diversificados.

### 🛍️ Estatísticas de Uso
- Estatísticas em tempo real do número de diálogos e uso, registro automático de dados.
- Visualização dos dados de uso, facilitando análise e otimização.
- Suporta exibição colorida de logs no terminal e painel de uso no IDE, aumentando a usabilidade.

### 💡 Sistema de Logs
- Logs em múltiplos níveis (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), saída colorida no terminal.
- Arquivos de log gerados automaticamente por data, suporte a registro em arquivo e exibição por arrastar para o painel.
- Painel em tempo real que facilita o monitoramento e rastreamento por desenvolvedores.

### 🔒 Compatibilidade de Versão e Otimização de Desempenho
- Desenvolvido com base no Cursor 0.49.6, funcionalidades principais completamente testadas.
- Otimização para versões específicas, acompanhamento contínuo das atualizações do Cursor.
- Alta estabilidade e compatibilidade, adequado para uso em ambientes de produção.

## 🔮Demonstração dos Resultados

### 🤖 Continuação Automática de Diálogo

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Demonstração de Auto-completar no Cursor

Do requisito do projeto à implementação completa, sem intervenção manual durante todo o processo:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝Autor

👤 **pen9un**

* Website: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️Apoio

Se você achou este projeto útil, por favor, deixe uma estrela gratuita ⭐️⭐️

## ✨Histórico de Stars

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Estatísticas de Acesso

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---