# 🎫 BiliTickerStorm

## ⚙️ Descripción del servicio

| Nombre del servicio    | Descripción                       | Notas          |
| ---------------------- | --------------------------------- | -------------- |
| `ticket-master`        | Servicio principal, encargado de la gestión de tareas | Despliegue de una sola instancia |
| `ticket-worker`        | Worker de compra de entradas, escalable horizontalmente | Soporta múltiples instancias      |
| `gt-python`            | Servicio de procesamiento de captcha gráfico           | Despliegue de una sola instancia  |

---

## 🚀 Pasos rápidos de despliegue

> Para la construcción del clúster, consulte la [Guía de construcción de clústeres](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md).

<details> <summary><strong>📦 Instalación desde repositorio remoto (recomendado)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Instalar Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` es el directorio de archivos de configuración de compra de boletos, que se monta para el contenedor `ticket-master`. Los archivos de configuración se generan usando https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` es la configuración de pushplus; al configurarlo, puedes recibir notificaciones de los resultados de la compra de boletos.
> - `ticketWorker.ticketInterval` es el intervalo de compra de boletos en segundos, por defecto 300 milisegundos.
> - `ticketWorker.ticketTimeStart` es la hora de inicio programada, el formato es `2025-05-20T13:14`. Si no se completa, el contenedor iniciará la compra de boletos inmediatamente después de abrirse.

### 3. Actualizar Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 Instalación de Chart local</strong></summary>


### 1. Instalar Chart

```bash
# Clonar el repositorio
git clone https://github.com/mikumifa/biliTickerStorm
# Usar el paquete Chart local
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Actualizar Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 Comandos Generales</strong></summary>

### ⏹ Desinstalar
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Descargo de Responsabilidad

Este proyecto sigue la licencia MIT License y es solo para uso personal de aprendizaje e investigación. No utilice este proyecto para ningún propósito comercial ni para ningún tipo de compra automatizada, actividades ilegales o usos que violen las reglas de las plataformas involucradas. Todas las consecuencias derivadas de su uso correrán exclusivamente por cuenta del usuario, sin ninguna responsabilidad por parte del autor.

Si usted hace fork o utiliza este proyecto, asegúrese de cumplir con las leyes, regulaciones y las reglas de la plataforma objetivo.

## 💡 Sobre la Frecuencia de Acceso y el Control de Concurrencia

Este proyecto fue diseñado bajo el principio de "no intrusivo", evitando cualquier interferencia con los servidores objetivo (como Bilibili).

Todos los intervalos de las solicitudes de red son configurables por el usuario, con valores predeterminados que simulan la velocidad de operaciones manuales de un usuario normal. El programa se ejecuta por defecto en un solo hilo, sin tareas concurrentes. En caso de fallos en las solicitudes, el programa realizará un número limitado de reintentos, añadiendo retrasos apropiados entre cada intento para evitar accesos de alta frecuencia. El proyecto depende totalmente de interfaces públicas y la estructura web de la plataforma, sin incluir métodos destructivos como evasión de controles de riesgo o secuestro de API.
## 🛡️ Declaración de Respeto a la Plataforma

Este programa ha sido diseñado para controlar la frecuencia de las solicitudes tanto como sea posible, evitando causar cualquier carga o impacto evidente en los servidores de Bilibili. El proyecto es solo para fines de aprendizaje, no posee capacidad para operaciones a gran escala o alta concurrencia, ni tiene ninguna intención maliciosa o de interferencia con el servicio.

Si existe contenido en este proyecto que infrinja los derechos legales de la empresa Bilibili, por favor contácteme a través del correo electrónico [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com). Retiraré inmediatamente el contenido relevante y eliminaré este repositorio. Lamento profundamente cualquier inconveniente causado y agradezco su comprensión y tolerancia.

## 📄 Licencia

[Licencia MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---