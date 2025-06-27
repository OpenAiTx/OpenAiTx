<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="versión">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="actividad">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="colaboradores">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="seguridad">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="cobertura">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="construcción">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="licencia">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **Tabla de contenidos**
### 1. [**Acerca de**](#about)
### 2. [**Primeros pasos**](#getting-started)
>#### 2.1.   [**Requisitos**](#requirements)
>#### 2.2.  [**Instalación**](#installing-horusec)
### 3. [**Uso**](#usage)
>#### 3.1. [**Uso por CLI**](#cli-usage)
>#### 3.2. [**Uso con Docker**](#using-docker)
>#### 3.3. [**Versiones anteriores**](#older-versions)
>#### 3.4. [**Uso de la aplicación Horusec-Web**](#using-horusec-web-application)
>#### 3.5.  [**Uso con Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**Uso en la Pipeline**](#using-the-pipeline)
### 4. [**Documentación**](#documentation)       
### 5. [**Hoja de ruta**](#roadmap)
### 6. [**Contribuir**](#contributing)
### 7. [**Código de conducta**](#code-of-conduct)
### 8. [**Licencia**](#license)
### 9. [**Comunidad**](#community)



<br>
<br>
<br>

# **Acerca de**
Horusec es una herramienta de código abierto que realiza análisis estático de código para identificar fallos de seguridad durante el proceso de desarrollo. Actualmente, los lenguajes soportados para el análisis son C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx.
La herramienta tiene opciones para buscar fugas de claves y fallos de seguridad en todos los archivos de tu proyecto, así como en el historial de Git. Horusec puede ser utilizado por el desarrollador a través de la CLI y por el equipo de DevSecOps en los flujos CI/CD.

Consulta nuestra [**Documentación**](https://docs.horusec.io/docs/overview/), donde verás la lista completa de herramientas y lenguajes que Horusec analiza.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Ejemplo de salida:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Primeros pasos**

## **Requisitos**

- Docker

Necesitas tener Docker instalado en tu máquina para ejecutar Horusec con todas las herramientas que usamos.
Si no tienes Docker, contamos con una [**flag**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` que deshabilita la dependencia, pero también se pierde gran parte de la capacidad de análisis.
Recomendamos utilizarlo con Docker.

Si habilitas autores de commit `-G true`, también existe una dependencia de `git`.

## **Instalación de Horusec**
### **Mac o Linux**
```
make install
```

o

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **Verificar la instalación**
```bash
horusec version
```

### **Windows**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **Verificar la instalación**
```bash
./horusec.exe version
```

### **Y más**

- Puedes encontrar todos los binarios con versiones en nuestra [**página de releases**](https://github.com/ZupIT/horusec/releases).

- Para más detalles sobre cómo instalar, consulta la [**documentación**](https://docs.horusec.io/docs/cli/installation) 


## **Uso**
### **Uso por CLI**
Para usar horusec-cli y comprobar las vulnerabilidades de la aplicación, utiliza el siguiente comando:
```bash
horusec start -p .
```
> Cuando horusec inicia un análisis, crea una carpeta llamada **`.horusec`**. Esta carpeta sirve de base para no modificar tu código. Te recomendamos agregar la línea **`.horusec`** en tu archivo **`.gitignore`** para que esta carpeta no sea enviada a tu servidor git.

### **Uso con Docker**
Es posible usar Horusec a través de una imagen de docker **`horuszup/horusec-cli:latest`**.

Ejecuta el siguiente comando para hacerlo:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- Creamos un volumen que contiene el proyecto `-v $(pwd):/src`.

Con la imagen de docker terminamos teniendo dos rutas donde se puede encontrar el proyecto.

La flag `-p` representará la ruta del proyecto dentro del contenedor, en nuestro ejemplo `/src`.
La flag `-P` representará el proyecto fuera del contenedor, en nuestro ejemplo está representado por `$(pwd)`,
también será necesario pasar la ruta del proyecto para montar el volumen `-v $(pwd):/src`.

### **Versiones anteriores**

La versión v1 de Horusec sigue estando disponible.

**ADVERTENCIA:** El endpoint con v1 será descontinuado, por favor actualiza tu CLI a la v2. Consulta más detalles en la [**documentación**](https://docs.horusec.io/docs/migrate-v1-to-v2/). 

### **Mac o Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- Los binarios antiguos pueden encontrarse en este endpoint, incluyendo la última versión de v1 **`v1.10.3`**.
- A partir de la v2, los binarios ya no se distribuirán por este endpoint, y los puedes encontrar en la [**página de releases**](https://github.com/ZupIT/horusec/releases).

### **Uso de la aplicación Horusec-Web**
Gestiona tus vulnerabilidades a través de nuestra interfaz web. Puedes tener un panel de métricas sobre tus vulnerabilidades, control de falsos positivos, token de autorización, actualización de vulnerabilidades y mucho más.
Consulta la sección de la [**aplicación web**](https://github.com/ZupIT/horusec-platform) para seguir leyendo al respecto.

Consulta el siguiente ejemplo, está enviando un análisis a los servicios web de Horusec:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

Consulta el [**tutorial sobre cómo crear un token de autorización a través del Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**ADVERTENCIA:** Nuestros servicios web han sido movidos a un [**nuevo repositorio**](https://github.com/ZupIT/horusec-platform). Necesitas actualizar a la v2, consulta [**cómo migrar de v1 a v2**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **Uso con Visual Studio Code**
Puedes analizar tu proyecto utilizando la extensión de Horusec para Visual Studio Code.
Para más información, [**consulta la documentación**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Uso en la Pipeline**
Puedes realizar un análisis de tu proyecto antes de realizar un despliegue en tu entorno, garantizando la máxima seguridad en tu organización.
Para más información, [**consulta la documentación**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Características**
Ver abajo:
- Analiza simultáneamente 18 lenguajes con 20 herramientas de seguridad diferentes para aumentar la precisión;
- Busca en el historial de git secretos y otros contenidos expuestos;
- Tu análisis puede ser completamente configurable, [**consulta todos los recursos disponibles en CLI**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Documentación**
Puedes encontrar la documentación de Horusec en nuestro [**sitio web**](https://docs.horusec.io/docs/overview/).

## **Hoja de ruta**
Tenemos una [**hoja de ruta del proyecto**](ROADMAP.md), ¡puedes contribuir con nosotros!

Horusec tiene otros repositorios, échales un vistazo:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **Contribuyendo**

Siéntete libre de usar, recomendar mejoras o contribuir con nuevas implementaciones.

Consulta nuestra [**guía de contribución**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) para conocer nuestro proceso de desarrollo y cómo sugerir correcciones de errores y mejoras.

### **Certificado de Origen del Desarrollador - DCO**

Esta es una capa de seguridad para el proyecto y para los desarrolladores. Es obligatorio.

Sigue uno de estos dos métodos para agregar el DCO a tus commits:

**1. Línea de comandos**  
Sigue los pasos:  
**Paso 1:** Configura tu entorno local de git agregando el mismo nombre y correo electrónico que tienes configurado en tu cuenta de GitHub. Esto ayuda a firmar los commits manualmente durante revisiones y sugerencias.

```
git config --global user.name “Nombre”
git config --global user.email “correo@dominio.com.br”
```
**Paso 2:** Agrega la línea Signed-off-by con la opción `'-s'` en el comando git commit:

```
$ git commit -s -m "Este es mi mensaje de commit"
```
**2. Sitio web de GitHub**

También puedes firmar manualmente tus commits durante las revisiones y sugerencias en GitHub, sigue los pasos a continuación:

**Paso 1:** Cuando se abra la caja para cambiar el commit, escribe o pega manualmente tu firma en el cuadro de comentarios, ve el ejemplo:

```
Signed-off-by: Nombre < dirección de correo >
```

Para este método, tu nombre y correo electrónico deben ser los mismos que tienes registrados en tu cuenta de GitHub.

## **Código de Conducta**
Por favor, sigue el [**Código de Conducta**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) en todas tus interacciones con nuestro proyecto.

## **Licencia**
[**Licencia Apache 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Comunidad**

No dudes en comunicarte con nosotros en:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Si tienes alguna pregunta o idea, conversemos en nuestro [**Foro de Código Abierto de Zup**](https://forum.zup.com.br).


Este proyecto existe gracias a todos los colaboradores. ¡Ustedes son geniales! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---