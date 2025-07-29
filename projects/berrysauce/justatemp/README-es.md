<h1 align="center">📮 Solo un Temp</h1>
<p align="center">El servicio gratuito de correo temporal impulsado por Cloudflare
  <br>
  </br>
  <img alt="CodeQL" src="https://github.com/berrysauce/justatemp/actions/workflows/github-code-scanning/codeql/badge.svg">
  <img alt="GitHub release (latest by date including pre-releases)" src="https://img.shields.io/github/v/release/berrysauce/junk.boats?color=blue&include_prereleases&label=latest%20release">
</p>

> ℹ️ Este servicio está 100% potenciado por [Cloudflare](https://www.cloudflare.com/)

> [!IMPORTANT]
> Este proyecto estuvo disponible anteriormente bajo el dominio "junk.boats".

### ¿Qué es justatemp.com?
justatemp.com es otro generador de correos temporales, gratuito, de código abierto y, por supuesto, respetuoso con la privacidad. Puedes usar justatemp.com para recibir correos de sitios a los que realmente no quieres dar tu email. Todos los correos recibidos se almacenan públicamente por 2 horas y luego se eliminan permanentemente.

<img alt="Captura de pantalla de Just A Temp" src="https://public-cdn.berrysauce.me/shared/justatemp-screenshot-yWtqO.png">

### ¿Y la privacidad?
justatemp.com solo almacena los correos recibidos. No se guarda ningún otro dato de usuario. Los correos se eliminan automáticamente después de 2 horas. Hasta entonces, cualquiera con la dirección receptora puede ver los correos que esa dirección recibió. Para analíticas, justatemp.com usa la analítica web anónima de Cloudflare.

### ¿Qué son collector, postmaster y postoffice?
- 📮 `mailbox` es un trabajador de correo de Cloudflare que recibe y almacena todos los correos entrantes
- 🚚 `postservice` es el distribuidor de correos en forma de API potenciado por un trabajador HonoJS de Cloudflare
- 🏤 `frontend` es el frontend en SvelteKit que muestra los correos recibidos al usuario

### ¿Cómo funciona justatemp.com?
Los correos entrantes van al trabajador de correo `mailbox`. Guarda el correo en una base de datos KV de Cloudflare. El frontend en Svelte genera una dirección de correo aleatoria y solicita todos los correos para esa dirección al `postservice`. Si hay correos disponibles, los muestra, ordenados por la marca de tiempo UNIX incluida en la entrada KV.

### Desarrollo
Más sobre eso pronto


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---