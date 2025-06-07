# mimotion
![刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Xiaomi Mi Fit actualización automática de pasos

> Xiaomi Mi Fit actualización automática de pasos

## Guía de despliegue con Github Actions

### 1. Haz un Fork de este repositorio

### 2. Configura usuario y contraseña
# Añadido el 2023-02-24
Agrega una variable llamada **CONFIG**: Settings-->Secrets-->New secret, configura múltiples cuentas con la siguiente plantilla JSON, soporta correo electrónico y número de teléfono.
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, si no tienes, déjalo vacío",
  "TG_USER_ID": "telegram TG_USER_ID, si no tienes, déjalo vacío",
  "SKEY": "skey de CoolPush, si no tienes, déjalo vacío",
  "SCKEY": "sckey de Server酱, si no tienes, déjalo vacío",
  "POSITION": "Si se activa el push de WeChat Work, si no tienes, déjalo vacío",
  "CORPID": "ID de empresa, inicia sesión en WeChat Work, revisa en Mi Empresa-->Información de la Empresa, si no tienes, déjalo vacío",
  "CORPSECRET": "Secreto de la aplicación personalizada en WeChat Work, cada aplicación tiene su propio secret, si no tienes, déjalo vacío",
  "AGENTID": "Introduce el ID de tu aplicación personalizada en WeChat Work, sin comillas, es un número entero, es el AgentId, si no tienes, déjalo vacío",
  "TOUSER": "Especifica los miembros que recibirán el mensaje, lista de ID de miembros (varios separados por ”&#166;”, máximo 1000). En caso especial: si es ”@all”, se enviará a todos los miembros de la aplicación. Si no tienes, déjalo vacío",
  "TOPARTY": "Especifica los departamentos que recibirán el mensaje, lista de ID de departamentos, varios separados por ”&#166;”, máximo 100. Si touser es ”@all”, escribe ”@all”. Si no tienes, déjalo vacío",
  "TOTAG": "Especifica las etiquetas que recibirán el mensaje, lista de ID de etiquetas, varios separados por ”&#166;”, máximo 100. Si touser es ”@all”, escribe ”@all”. Si no tienes, déjalo vacío",
  "OPEN_GET_WEATHER": "Activa la reducción de pasos según el clima local, si no tienes, déjalo vacío",
  "AREA": "Configura la región para obtener el clima (obligatorio si activas lo anterior), por ejemplo, Beijing. Si no tienes, déjalo vacío",
  "QWEATHER": "Introduce la Private KEY de QWeather, solicita en https://console.qweather.com/#/apps, si no tienes, déjalo vacío",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Para múltiples cuentas, introduce el máximo de pasos, consulta arriba",
      "min_step": "Para múltiples cuentas, introduce el mínimo de pasos, consulta arriba",
      "password": "Para múltiples cuentas, introduce la contraseña, consulta arriba",
      "user": "Para múltiples cuentas, introduce el teléfono, consulta arriba"
    }
  ]
}
```
> Agrega una variable llamada **PAT**: Settings-->Secrets-->New secret

| Secrets |  Formato  |
| ------- | --------- |
| PAT     |   El **PAT** debe solicitarse, su valor es el token de github, tutorial: https://www.jianshu.com/p/bb82b3ad1d11 , requiere permisos repo y workflow, este campo es obligatorio para evitar errores de permiso en git push. |

**Ejemplo de CONFIG**
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
      "max_step": "Para múltiples cuentas, introduce el máximo de pasos, consulta arriba",
      "min_step": "Para múltiples cuentas, introduce el mínimo de pasos, consulta arriba",
      "password": "Para múltiples cuentas, introduce la contraseña, consulta arriba",
      "user": "Para múltiples cuentas, introduce el teléfono, consulta arriba"
    }
  ]
}
```

### 3. Personaliza la hora de inicio

Edita **random_cron.sh**
Modifica la hora de comprobación en la sentencia **if** a la hora UTC, es decir, **hora de Beijing -8**. Por ejemplo, la hora de Beijing 8:00 es UTC 0:00. La hora de ejecución menos 8 es la hora UTC.



## Notas importantes

1. Se ejecuta siete veces al día, controlado por random_cron.sh, los minutos son aleatorios.

2. ¡¡El número de cuentas y contraseñas debe coincidir exactamente, de lo contrario no funcionará!!

3. ¡La hora de inicio debe estar en UTC!

4. Registro de Server酱 [haz clic aquí](https://sct.ftqq.com/)

5. Si Alipay no actualiza los pasos, entra a Mi Fit->Configuración->Cuenta->Cerrar sesión->Borrar datos, luego vuelve a iniciar sesión y enlaza de nuevo con terceros

6. Mi Fit no actualizará los pasos, ¡sólo los sincronizará si está enlazado con terceros!

7. Por favor, haz Fork de la [rama principal](https://github.com/xunichanghuan/mimotion-run/) para evitar errores innecesarios.

8. Atención, la cuenta no es la [cuenta Xiaomi], sino la cuenta de [Mi Fit].

## Historial de estrellas

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---