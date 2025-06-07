# mimotion
![刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Xiaomi Mi Fit incremento automatico dei passi

> Xiaomi Mi Fit incremento automatico dei passi

## Guida al Deploy su Github Actions

### 1. Fork di questo repository

### 2. Impostazione di account e password
# Aggiornamento del 20230224
Aggiungere una variabile chiamata **CONFIG**: Settings-->Secrets-->New secret , configurare più account utilizzando il seguente modello json, supporta email e numero di telefono
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, se non presente lascia vuoto",
  "TG_USER_ID": "telegram TG_USER_ID, se non presente lascia vuoto",
  "SKEY": "Coolpush skey, se non presente lascia vuoto",
  "SCKEY": "server酱 sckey, se non presente lascia vuoto",
  "POSITION": "Abilitare la notifica su WeChat aziendale, se non presente lascia vuoto",
  "CORPID": "ID aziendale, effettua il login su WeChat aziendale, in La mia azienda-->Informazioni azienda, se non presente lascia vuoto",
  "CORPSECRET": "Secret dell'applicazione personalizzata di WeChat aziendale, ogni app ne ha una, se non presente lascia vuoto",
  "AGENTID": "Inserisci l'ID della tua applicazione personalizzata WeChat aziendale, senza virgolette, è un valore intero, ovvero AgentId, se non presente lascia vuoto",
  "TOUSER": "Specifica i membri destinatari del messaggio, elenco ID membri (più destinatari separati da '|' massimo 1000). Caso speciale: se impostato su '@all', invia a tutti i membri dell'applicazione aziendale. Se non presente lascia vuoto",
  "TOPARTY": "Specifica i reparti destinatari, elenco ID reparti, più destinatari separati da '|' massimo 100. Se touser è '@all' inserire '@all', se non presente lascia vuoto",
  "TOTAG": "Specifica i tag destinatari, elenco ID tag, più destinatari separati da '|' massimo 100. Se touser è '@all' inserire '@all', se non presente lascia vuoto",
  "OPEN_GET_WEATHER": "Abilita la riduzione dei passi in base al meteo della zona, se non presente lascia vuoto",
  "AREA": "Imposta la zona per ottenere il meteo (obbligatorio se sopra abilitato), ad esempio Pechino, se non presente lascia vuoto",
  "QWEATHER": "Inserisci qui la Private KEY di HeWeather, richiedila su https://console.qweather.com/#/apps, se non presente lascia vuoto",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Per più account inserire il massimo passi, vedi sopra",
      "min_step": "Per più account inserire il minimo passi, vedi sopra",
      "password": "Per più account inserire la password, vedi sopra",
      "user": "Per più account inserire il numero, vedi sopra"
    }
  ]
}
```
> Aggiungi una variabile chiamata **PAT**: Settings-->Secrets-->New secret

| Secrets |  Formato  |
| -------- | ----- |
| PAT |   Questo **PAT** deve essere richiesto, il valore è il token github, guida su: https://www.jianshu.com/p/bb82b3ad1d11 , sono necessari i permessi repo e workflow, questo campo è obbligatorio per evitare errori di permessi nel git push. |

**Esempio di CONFIG**
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
      "max_step": "Per più account inserire il massimo passi, vedi sopra",
      "min_step": "Per più account inserire il minimo passi, vedi sopra",
      "password": "Per più account inserire la password, vedi sopra",
      "user": "Per più account inserire il numero, vedi sopra"
    }
  ]
}
```

### 3. Personalizzazione dell'orario di avvio

Modifica **random_cron.sh**
Modifica l'orario della condizione **if** in tempo UTC, ovvero **orario Pechino -8**, ad esempio le 8:00 di Pechino sono le 0:00 UTC, l'orario desiderato -8 corrisponde all'orario UTC



## Note importanti

1. Si esegue 7 volte al giorno, controllato da random_cron.sh, i minuti sono valori casuali

2. Il numero di account e password deve corrispondere esattamente, altrimenti non funzionerà!!!

3. L'orario di avvio deve essere in UTC!

4. Registrazione server酱 [Clicca qui](https://sct.ftqq.com/)

5. Se su Alipay i passi non vengono aggiornati, vai su Xiaomi Mi Fit -> Impostazioni -> Account -> Esci -> Cancella dati, poi accedi di nuovo e ricollega le terze parti

6. Xiaomi Mi Fit non aggiornerà i passi, solo quelli associati verranno sincronizzati!!!!!!

7. Si consiglia di Forkare il [branch principale](https://github.com/xunichanghuan/mimotion-run/) per evitare bug indesiderati.

8. Attenzione, l'account non è quello [Xiaomi], ma quello di [Xiaomi Mi Fit].

## Numero di Star storici

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---