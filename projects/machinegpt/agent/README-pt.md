![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

Um framework de agente de IA Python autossuficiente e de alta velocidade que utiliza o SDK Python da OpenAI para interpretar comandos em linguagem natural, gerar e executar código dinamicamente e gerenciar seu ambiente de execução sem atrito. Possui instalação automatizada de dependências, configuração segura do ambiente, logging estruturado e uma interface minimalista de plugins para embutir ferramentas poderosas em Python—tudo sob a licença permissiva Apache 2.0.

## ⭐ Histórico de Estrelas

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 Configuração do Ambiente

### Ambiente Virtual Python
Antes de configurar o projeto, é recomendado criar um ambiente virtual. Siga estes passos:

Saiba mais sobre ambientes virtuais: [Guia de Empacotamento Python](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

Crie e ative um ambiente virtual:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### Configuração do Projeto
Este projeto requer uma chave da API da OpenAI para funcionar. Para fornecê-la, crie um arquivo .env no diretório raiz com o seguinte conteúdo:
```
OPENAI_API_KEY=
```
Alternativamente, você pode copiar o arquivo .env.example fornecido e atualizar a chave:
```
cp .env.example .env
```

## 🧠 Início
Para iniciar o agente, basta rodar:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ Contribuições

Contribuições, sugestões, relatos de bugs e correções são bem-vindos!

Para novas funcionalidades, componentes ou extensões, por favor, abra uma issue e discuta antes de enviar um PR.

## 💖 Este projeto existe em seu estado atual graças a todas as pessoas que contribuem
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---