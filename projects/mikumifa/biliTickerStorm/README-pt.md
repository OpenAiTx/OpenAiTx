# 🎫 BiliTickerStorm

## ⚙️ Descrição do Serviço

| Nome do Serviço       | Descrição                     | Observações   |
| --------------------- | ---------------------------- | ------------- |
| `ticket-master`       | Serviço principal, responsável pelo agendamento de tarefas | Implantação em instância única |
| `ticket-worker`       | Worker de compra de ingressos, pode ser escalado horizontalmente | Suporta múltiplas instâncias |
| `gt-python`           | Serviço de processamento de captcha gráfico | Implantação em instância única |

---

## 🚀 Passos para Implantação Rápida

> Para a configuração do cluster, consulte o [Guia de Configuração de Cluster](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md).

<details> <summary><strong>📦 Instalação via Repositório Remoto (Recomendado)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Instalar o Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` é o diretório do arquivo de configuração de compra de ingressos, montado para uso pelo contêiner `ticket-master`. Para gerar o arquivo de configuração de compra de ingressos, utilize https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` é a configuração de push do pushplus, permitindo receber notificações do resultado da compra de ingressos após definido.
> - `ticketWorker.ticketInterval` é o intervalo em segundos entre tentativas de compra de ingressos, padrão de 300 milissegundos.
> - `ticketWorker.ticketTimeStart` é o horário de início agendado, no formato `2025-05-20T13:14`. Se não preenchido, ao iniciar o contêiner, a compra de ingressos será iniciada imediatamente.

### 3. Atualizar o Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 Instalação de Chart Local</strong></summary>


### 1. Instalar o Chart

```bash
# Clonar o repositório
git clone https://github.com/mikumifa/biliTickerStorm
# Usar o pacote Chart local
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/seu/caminho/de/dados/host \
  --set ticketWorker.pushplusToken="seu_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Atualizar o Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 Comandos Gerais</strong></summary>

### ⏹ Desinstalar
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Aviso Legal

Este projeto segue o acordo de licença MIT License, sendo destinado apenas para aprendizado e pesquisa pessoal. Não utilize este projeto para qualquer atividade comercial lucrativa, sendo também estritamente proibido o uso para qualquer forma de compra automatizada, atividades ilegais ou para fins que violem as regras das plataformas relacionadas. Todas as consequências decorrentes do uso são de responsabilidade exclusiva do usuário, não tendo relação com o autor.

Se você fizer fork ou utilizar este projeto, por favor, cumpra rigorosamente as leis, regulamentos e regras das plataformas-alvo.

## 💡 Sobre Frequência de Acesso e Controle de Concorrência
Este projeto foi projetado seguindo estritamente o princípio de "não intrusivo", evitando qualquer tipo de interferência nos servidores de destino (como o Bilibili).

Todos os intervalos de requisições de rede são configuráveis pelo usuário, sendo o valor padrão simulado para corresponder à velocidade de operação manual de um usuário comum. O programa executa por padrão em modo single-thread, sem tarefas concorrentes. Em caso de falha na requisição, o programa tentará novamente um número limitado de vezes, inserindo atrasos adequados entre as tentativas para evitar solicitações em alta frequência. O projeto depende integralmente de interfaces públicas e estruturas de página da plataforma, não incluindo métodos destrutivos como evasão de controle de risco ou sequestro de API.
## 🛡️ Declaração de Respeito à Plataforma

Este programa foi projetado para controlar a frequência de requisições tanto quanto possível, evitando causar qualquer carga ou impacto significativo nos servidores da Bilibili. O projeto é apenas para fins de aprendizado, não possui capacidade para operações em grande escala ou alta concorrência, e não tem qualquer intenção maliciosa ou de interferência nos serviços.

Caso este projeto contenha conteúdo que infrinja os direitos legais da empresa Bilibili, por favor entre em contato comigo pelo e-mail [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com). Removerei imediatamente o conteúdo relevante e excluirei este repositório. Peço desculpas por qualquer inconveniente causado e agradeço pela sua compreensão e tolerância.

## 📄 Licença

[Licença MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---