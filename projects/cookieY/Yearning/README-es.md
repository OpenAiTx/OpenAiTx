<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 Una plataforma robusta, desplegada localmente, diseñada para la detección fluida de SQL y la auditoría de consultas, adaptada específicamente para DBAs y desarrolladores. Centrada en la privacidad y la eficiencia, proporciona un entorno intuitivo y seguro para la auditoría de MYSQL.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Características

- **Asistente de IA**: Nuestro asistente de IA ofrece sugerencias de optimización SQL en tiempo real, mejorando el rendimiento de SQL. También soporta la conversión de texto a SQL, permitiendo a los usuarios introducir lenguaje natural y recibir sentencias SQL optimizadas.
  
- **Auditoría SQL**: Crea tickets de auditoría SQL con flujos de aprobación y comprobaciones automáticas de sintaxis. Valida sentencias SQL para corregir errores, seguridad y cumplimiento. Se generan automáticamente sentencias de reversión para operaciones DDL/DML, con un historial completo para trazabilidad.

- **Auditoría de Consultas**: Audita las consultas de los usuarios, restringe fuentes de datos y bases de datos, y anonimiza campos sensibles. Los registros de consultas se guardan para referencia futura.

- **Reglas de Comprobación**: Nuestro verificador automático de sintaxis soporta una amplia gama de reglas de comprobación, adecuado para la mayoría de los escenarios de verificación automática.

- **Enfoque en la Privacidad**: Yearning es una solución de código abierto y desplegable localmente que garantiza la seguridad de su base de datos y sentencias SQL. Incluye mecanismos de cifrado para proteger datos sensibles, asegurando que permanezcan seguros incluso en caso de accesos no autorizados.

- **RBAC (Control de Acceso Basado en Roles)**: Crea y gestiona roles con permisos específicos, restringiendo el acceso a órdenes de trabajo de consulta, funciones de auditoría y otras operaciones sensibles según los roles de usuario.

> \[!TIP]
> Para más información detallada, visite nuestra [Guía de Yearning](https://next.yearning.io)


## ⚙️ Instalación

Descargue la [última versión](https://github.com/cookieY/Yearning/releases/latest) y descomprímala. Asegúrese de haber configurado `./config.toml` antes de continuar.

### Instalación Manual

```bash
## Inicializar la base de datos
./Yearning install

## Iniciar Yearning
./Yearning run

## Ayuda
./Yearning --help
```

### 🚀 Despliegue con Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Inicializar la base de datos
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Iniciar Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 Asistencia de IA

Nuestro Asistente de IA utiliza un modelo de lenguaje grande para proporcionar sugerencias de optimización SQL y conversión de texto a SQL. Ya sea utilizando prompts predeterminados o personalizados, el Asistente de IA mejora el rendimiento de SQL optimizando sentencias y convirtiendo entradas en lenguaje natural en consultas SQL.

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Verificador Automático de SQL

El verificador automático de SQL evalúa las sentencias SQL según reglas y sintaxis predefinidas. Asegura que las sentencias cumplan con estándares de codificación específicos, buenas prácticas y requisitos de seguridad, proporcionando una robusta capa de validación.

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 Resaltado de Sintaxis SQL y Autocompletado

Mejore su eficiencia al escribir consultas con el resaltado de sintaxis SQL y el autocompletado. Estas funciones ayudan a los usuarios a distinguir visualmente los diferentes componentes de una consulta SQL, como palabras clave, nombres de tablas, nombres de columnas y operadores, facilitando la lectura y comprensión de la estructura de la consulta.

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Registro de Órdenes/Consultas

Nuestra plataforma soporta la auditoría de órdenes y sentencias de consulta de los usuarios. Esta función le permite rastrear y registrar todas las operaciones de consulta, incluidas las fuentes de datos, bases de datos y el manejo de campos sensibles, garantizando el cumplimiento de normativas y proporcionando trazabilidad para el historial de consultas.

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Al centrarse en estas características clave, Yearning mejora la experiencia del usuario, optimiza el rendimiento de SQL y garantiza un cumplimiento y trazabilidad sólidos en las operaciones de bases de datos.

## 🛠️ Herramientas Recomendadas

- [Spug - Plataforma de Automatización de Operaciones Ligera y de Código Abierto](https://github.com/openspug/spug)

## ☎️ Contacto

Para consultas, por favor envíe un correo a: henry@yearning.io
## 📋 Licencia

Yearning está licenciado bajo la licencia AGPL. Consulta [LICENSE](LICENSE) para más detalles.

2024 © Henry Yee

---

Con Yearning, experimenta un enfoque optimizado, seguro y eficiente para la auditoría y optimización de SQL.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---