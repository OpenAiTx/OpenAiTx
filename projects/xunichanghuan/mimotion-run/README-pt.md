# mimotion
![刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Xiaomi Sports: Atualização automática de passos

> Atualização automática de passos no Xiaomi Sports

## Guia de implantação pelo Github Actions

### 1. Faça um Fork deste repositório

### 2. Configure usuário e senha
# Adição em 20230224
Adicione uma variável chamada **CONFIG**: Settings-->Secrets-->New secret, configure múltiplas contas usando o modelo json abaixo, suportando e-mail e número de telefone
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, se não tiver, deixe em branco",
  "TG_USER_ID": "telegram TG_USER_ID, se não tiver, deixe em branco",
  "SKEY": "skey do Cool Push, se não tiver, deixe em branco",
  "SCKEY": "sckey do Server酱, se não tiver, deixe em branco",
  "POSITION": "Ativar push pelo WeCom, se não tiver, deixe em branco",
  "CORPID": "ID da empresa, faça login no WeCom, veja em Minha Empresa-->Informações da Empresa, se não tiver, deixe em branco",
  "CORPSECRET": "Secret do aplicativo próprio no WeCom, cada aplicativo tem um secret próprio, se não tiver, deixe em branco",
  "AGENTID": "Preencha com o ID do aplicativo próprio no WeCom, sem aspas, número inteiro, ou AgentId, se não tiver, deixe em branco",
  "TOUSER": "ID dos usuários que receberão as mensagens, lista de IDs (vários separados por ”&#166;”, máximo 1000). Caso especial: ”@all” envia para todos, se não tiver, deixe em branco",
  "TOPARTY": "IDs dos departamentos para receber a mensagem, lista separada por ”&#166;”, máximo 100. Se touser for ”@all”, preencha com ”@all”, se não tiver, deixe em branco",
  "TOTAG": "IDs das tags para receber a mensagem, lista separada por ”&#166;”, máximo 100. Se touser for ”@all”, preencha com ”@all”, se não tiver, deixe em branco",
  "OPEN_GET_WEATHER": "Ativar ajuste de passos conforme clima local, se não tiver, deixe em branco",
  "AREA": "Defina a área para obter clima (obrigatório se ativado acima), ex: Beijing, se não tiver, deixe em branco",
  "QWEATHER": "Preencha com a Private KEY do QWeather, peça aqui: https://console.qweather.com/#/apps, se não tiver, deixe em branco",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Preencha o máximo de passos para múltiplas contas, veja acima",
      "min_step": "Preencha o mínimo de passos para múltiplas contas, veja acima",
      "password": "Preencha a senha para múltiplas contas, veja acima",
      "user": "Preencha o número para múltiplas contas, veja acima"
    }
  ]
}
```
> Adicione uma variável chamada **PAT**: Settings-->Secrets-->New secret

| Secrets |  Formato  |
| -------- | ----- |
| PAT |   O **PAT** deve ser solicitado, o valor é o token do github, tutorial: https://www.jianshu.com/p/bb82b3ad1d11 , precisa de permissões repo e workflow, obrigatório para evitar erro de permissão ao dar git push. |

**Exemplo de CONFIG**
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Preencha o máximo de passos para múltiplas contas, veja acima",
      "min_step": "Preencha o mínimo de passos para múltiplas contas, veja acima",
      "password": "Preencha a senha para múltiplas contas, veja acima",
      "user": "Preencha o número para múltiplas contas, veja acima"
    }
  ]
}
```

### 3. Personalize o horário de início

Edite **random_cron.sh**
Altere a hora na instrução **if** para o horário UTC, ou seja, **horário de Pequim -8**. Por exemplo, 8h em Pequim é 0h UTC, então o horário desejado -8 é o UTC.



## Observações

1. Executa sete vezes ao dia, controlado por random_cron.sh, minutos são valores aleatórios

2. O número de contas e senhas deve estar correto, senão não funcionará!!!

3. O horário de início deve ser UTC!

4. Cadastro do Server酱 [clique aqui](https://sct.ftqq.com/)

5. Se o Alipay não atualizar os passos, vá em Xiaomi Sports->Configurações->Conta->Sair da conta->Limpar dados, depois faça login novamente e vincule de novo o terceiro serviço

6. O Xiaomi Sports não atualizará os passos, só sincronizará para as contas vinculadas!!

7. Faça Fork do [branch principal](https://github.com/xunichanghuan/mimotion-run/) para evitar bugs desnecessários.

8. Atenção: a conta não é [Conta Xiaomi], é a conta do [Xiaomi Sports].

## Histórico de Estrelas

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---