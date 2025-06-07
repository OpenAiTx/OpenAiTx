# kkTerminal

> kkTerminal, un terminal para conexión SSH vía Web
>
> Autor: [zyyzyykk](https://github.com/zyyzyykk/)
>
> Código fuente: https://github.com/zyyzyykk/kkTerminal
>
> Dirección en Docker Hub: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> Vista previa: https://ssh.kkbpro.com/
>
> Fecha de actualización: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Integración rápida

Utiliza la etiqueta `iframe` en páginas web HTML para una integración rápida:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Despliegue con Docker

1. Descargar la imagen:

```bash
docker pull zyyzyykk/kkterminal
```

2. Crear y ejecutar un contenedor para el mapeo de puertos: `-p puerto:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Personalizar palabra artística: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Acceder desde el navegador: `http://server-ip:3000/`

### 🛸 Vista previa

Visita el siguiente sitio web: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**Más vistas previas de módulos**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Descripción de funciones

1. kkTerminal es un terminal para conexión SSH vía Web. Haz clic en el icono del terminal en la esquina superior izquierda y selecciona la configuración de conexión para establecer una conexión SSH

2. Soporta el uso de etiquetas `iframe` en páginas web para una integración rápida en sitios web de terceros

3. Soporta la personalización de la configuración del terminal mediante [Parámetros de URL](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. Soporta internacionalización y cambio de idioma entre chino e inglés

5. Soporta despliegue local en PC, abriendo automáticamente la ventana del navegador al iniciar

6. Soporta tamaño de ventana adaptable y entrada en chino

7. Soporta configuración personalizada de preferencias, permitiendo al usuario elegir el color de fondo/frente, tamaño de fuente, estilo de visualización del cursor, habilitar TCode para el terminal, etc.

8. Soporta reinicio: Se reiniciará automáticamente después de modificar la configuración de conexión SSH o las preferencias personalizadas, o se puede reiniciar manualmente tras desconectar la conexión SSH

9. Soporta copiar y pegar:

   - Copiar: Igual que el terminal de `Git`, al seleccionar texto se copia automáticamente

   - Pegar: Igual que el terminal de `Cmd`, clic derecho para pegar (requiere permiso de acceso del navegador)


9. Soporta gestión de archivos, abre el módulo de gestión de archivos para ver, descomprimir, subir y descargar archivos/carpetas

10. Soporta operaciones con teclas rápidas como selección múltiple/todos los archivos, copiar y pegar, cortar, cambiar selección, abrir, etc.

11. Soporta exploración y edición de archivos, modificar el archivo y guardarlo en el servidor remoto usando `ctrl+s`

12. Soporta [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md), que permite lograr flujos de trabajo automatizados similares a scripts Shell mediante TCode personalizado

13. Soporta funciones de grabación de operaciones y sincronización en la nube

14. Soporta funciones de Cooperar, Monitor y Docker

### 👨‍💻 Registros de actualización

##### zyyzyykk/kkterminal:3.6.0: latest

- Añadida función avanzada de Cooperar
- Añadida función avanzada de Monitor
- Añadida función avanzada de Docker
- Optimización del tamaño del paquete y de la visualización web

##### zyyzyykk/kkterminal:3.5.6: 

- Soporte para más parámetros de URL
- Añadido porcentaje de tamaño para texto e imagen en el editor
- Optimización de la visualización web

##### zyyzyykk/kkterminal:3.5.3: 

- Añadido parámetro de URL para personalizar la configuración del terminal
- Corregido bug de reinicio de múltiples ventanas
- Añadidas funciones de grabación de operaciones y sincronización en la nube
- Refactorización de parte de la lógica del código

[**Historial de actualizaciones**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Arquitectura

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| navegador | <===========> | kk Terminal | <========> | servidor remoto |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ Sobre este proyecto

Estimados usuarios,

Lamento anunciar que, debido a la falta de tiempo y energía, no podré seguir manteniendo `kkTerminal` en el futuro.

Si estás interesado en `kkTerminal` o deseas continuar con su mantenimiento, no dudes en contactarme o abrir un issue.

Si descubres errores o deseas desarrollar nuevas funciones, por favor también abre un issue.

Finalmente, gracias por tu apoyo a `kkTerminal` y espero sinceramente que `kkTerminal` pueda ayudarte.

Un cordial saludo,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Estrellas

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---