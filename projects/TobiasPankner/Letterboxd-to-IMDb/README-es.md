# Letterboxd-a-IMDb

[![GitHub stars](https://img.shields.io/github/stars/TobiasPankner/Letterboxd-to-IMDb.svg?style=social&label=Star)](https://GitHub.com/TobiasPankner/Letterboxd-to-IMDb/stargazers/)
[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=3TU2XDBK2JFU4&source=url)

- [Requisitos previos](#prerequisites)
- [Ejecutar el script](#run-the-script)
- [Obtener la cookie de IMDb](#getting-the-imdb-cookie)
- [Casos de uso comunes](#common-use-cases)
- [Opciones de línea de comandos](#command-line-options)

Script en Python para importar tus películas de Letterboxd a IMDb.  

Cómo funciona:  
El script primero "visita" todos los enlaces de Letterboxd en tu archivo zip y obtiene la página correspondiente en IMDb. De esta manera, se asegura que la película correcta sea valorada.  
Después, se usa tu cookie para autenticar una solicitud a la API interna de calificaciones GraphQL de IMDb.  

**Tutorial en video** sobre cómo usar esto: <https://www.youtube.com/watch?v=KF7cfdUTEgw>

## Ejecutar este script en línea (no se requiere Python)

[![Run Script](https://simple-script.com/api/badge/letterboxd-to-imdb)](https://simple-script.com/app/letterboxd-to-imdb)

## Requisitos previos  
  
- Python 3 ([Descargar](https://www.python.org/downloads/))
- Cuenta de [Letterboxd](https://letterboxd.com/)
- Cuenta de [IMDb](https://www.imdb.com/)

## Ejecutar el script

 1. Exporta tus valoraciones y lista de seguimiento de Letterboxd ([Cómo hacerlo](https://listy.is/help/how-to-export-letterboxd-watchlists-reviews/))
 2. [Obtén la cookie de IMDb](#getting-the-imdb-cookie) y guárdala como "cookie.txt" en la carpeta del script
 3. Instala las dependencias: `pip install -r requirements.txt`
 4. Ejecuta letterboxd2imdb.py: `python letterboxd2imdb.py -f <TU ARCHIVO ZIP>.zip`

[Casos de uso comunes](#common-use-cases)

## Obtener la cookie de IMDb

**¡Trata esta cookie como tu contraseña!**

  1. Inicia sesión en tu cuenta de IMDb
  2. Abre las herramientas de desarrollo de Chrome -> Red
  3. Filtra por Fetch/XHR
  4. Actualiza la página
  5. Copia la cookie de una de las solicitudes (clic derecho -> Copiar valor)
  
  ![Ejemplo](https://imgur.com/chRo9wj.jpg)  

## Casos de uso comunes

**Transfiere tus valoraciones y lista de seguimiento:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`

**Transfiere tus películas vistas con una valoración de 5/10:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 5`

**Crea una lista de IMDb para películas vistas sin calificar:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`

**Crea una lista de IMDb con nombre personalizado para películas vistas sin calificar:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "Mis Películas de Letterboxd"`

## Opciones de línea de comandos

```
usage: letterboxd2imdb.py [-h] -f ZIPFILE [-p PARALLEL] [-c] [-r RATING] [-w] [-l] [--list-name LIST_NAME]

Imports your Letterboxd ratings and watchlist into IMDb. Can also create custom lists for unrated movies.

required arguments:
  -f ZIPFILE            The exported zip file from letterboxd

options:
  -h, --help            show this help message and exit
  -p PARALLEL           Urls to be processed in parallel (valid: 1 to 20)
  -c                    Add this flag to disable the history
  -r RATING             The rating to give watched but unrated movies. By default they are ignored (valid: 1 to 10)
  -w                    Add this flag to also transfer your watchlist
  -l                    Create an IMDb list for watched but unrated movies instead of rating them
  --list-name LIST_NAME Name for the IMDb list to create for unrated movies (default: 'Watched on Letterboxd - Unrated')
```
`-p`: Puede usarse si desea acelerar el proceso, si lo configura demasiado alto podría recibir limitación de tasa. Predeterminado: 5  
`-c`: Si el historial causa problemas, puede agregar este indicador para desactivarlo.  
`-r`: Puede usarse para calificar películas vistas pero sin calificar. Debido a que IMDb no tiene una opción para "solo ver", debe especificarse una calificación predeterminada  
`-w`: Se usa también para transferir su lista de seguimiento  
`-l`: Crea una lista de IMDb para películas vistas pero sin calificar en lugar de asignarles calificaciones arbitrarias. Esto preserva datos limpios de calificación mientras se rastrean las películas vistas.  
`--list-name`: Especifica un nombre personalizado para la lista de IMDb creada con la opción `-l`. Predeterminado: "Watched on Letterboxd - Unrated"

**Nota:** Las opciones `-r` y `-l` son mutuamente excluyentes. Puede asignar calificaciones predeterminadas a películas sin calificar (`-r`) o crear una lista para ellas (`-l`), pero no ambas.
  
## Ejemplos de uso  
  
**Importación básica (solo calificaciones):**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip`  
*Importa solo tus películas calificadas de Letterboxd a IMDb. Las películas sin calificar se ignoran.*  
  
**Importar calificaciones y lista de seguimiento:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`  
*Transfiere tanto tus calificaciones de películas como tu lista de seguimiento de Letterboxd a IMDb.*  
  
**Asignar calificación predeterminada a películas sin calificar:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 7`  
*Importa tus calificaciones y asigna una calificación predeterminada de 7/10 a todas las películas vistas pero sin calificar.*  
  
**Crear una lista para películas sin calificar:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`  
*Crea una lista de IMDb llamada "Watched on Letterboxd - Unrated" para películas que has visto pero no has calificado.*  
  
**Crear una lista con nombre personalizado para películas sin calificar:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "My Letterboxd Backlog"`  
*Crea una lista de IMDb con un nombre personalizado para tus películas vistas sin calificar.*  
  
**Procesamiento rápido con mayor paralelización:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 15`  
*Procesa 15 películas en paralelo para una ejecución más rápida (ten cuidado con la limitación de tasa).*  
  
**Transferencia completa con configuraciones personalizadas:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -r 5 -w`  
*Procesamiento rápido (10 en paralelo), importa calificaciones y lista de seguimiento, asigna calificación 5/10 a películas sin calificar.*  
  

**Crear una lista personalizada con lista de seguimiento y procesamiento rápido:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -l --list-name "Mis Películas de Letterboxd" -w`  
*Procesa rápidamente, importa la lista de seguimiento y crea una lista con nombre personalizado para películas sin calificar.*  
  
**Desactivar historial (solución de problemas):**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -c`  
*Se ejecuta sin usar la función de historial, útil si tienes problemas con el archivo de historial.*  
  
**Enfoque conservador (lento pero seguro):**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 1 -w`  
*Procesa una película a la vez para evitar problemas de limitación de tasa mientras importa tanto calificaciones como lista de seguimiento.*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---