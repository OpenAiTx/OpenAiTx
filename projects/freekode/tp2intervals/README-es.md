[![Build branches](https://github.com/freekode/tp2intervals/actions/workflows/branch.yml/badge.svg)](https://github.com/freekode/tp2intervals/actions/workflows/branch.yml)
[![release](https://img.shields.io/github/release/freekode/tp2intervals)](https://github.com/freekode/tp2intervals/releases/latest)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/E1E6W6XZP)

# Third Party to Intervals.icu

Aplicación para sincronizar entrenamientos entre TrainingPeaks, TrainerRoad e Intervals.icu.

Funciona en MacOS (DMG), Windows (instalador EXE), Linux (AppImage). Alternativamente hay imagen Docker y JAR ejecutable.

Todos los archivos están disponibles para descargar en la [página de Releases](https://github.com/freekode/tp2intervals/releases/latest).

**Solo para fines educativos**

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tp.png?raw=true" width="25%"><img src="https://github.com/freekode/tp2intervals/blob/main/docs/tr.png?raw=true" width="25%">

* [Lista de características](#list-of-features)
* [Configuración](#configuration)
    + [Intervals.icu](#intervalsicu)
    + [TrainingPeaks](#trainingpeaks)
    + [TrainerRoad](#trainerroad)
* [Otras formas de ejecutar la app](#other-ways-to-run-the-app)
    + [JAR ejecutable](#executable-jar)
    + [Docker](#docker)
* [Preguntas frecuentes](#faq)
    + [General](#general)
    + [Información sobre la programación para el día siguiente con cuenta gratuita de TrainingPeaks](#info-regarding-scheduling-for-the-next-day-with-trainingpeaks-free-account)
* [Solución de problemas](#troubleshooting)
    + [Cómo obtener registros](#how-to-get-logs)
    + [Cómo grabar archivo HAR](#how-to-record-har-file)



**Nueva ubicación de la imagen Docker ⚠️**

**Nueva URL de la imagen: `ghcr.io/freekode/tp2intervals`**

URL antigua de la imagen: `ghcr.io/freekode/tp2intervals/tp2intervals`

**Actualizaciones de TrainerRoad**

Ya no tengo acceso a TrainerRoad. La cuenta que usaba canceló la suscripción. No uso la plataforma y es demasiado cara para tenerla solo para arreglos ocasionales.  
Para solucionar problemas solo puedo depender de los registros y archivos HAR que ustedes proporcionen.

## Lista de funciones

**TrainingPeaks**

Cuenta de atleta  
* Sincronizar entrenamientos planificados en el calendario entre Intervals.icu y TrainingPeaks (para hoy y mañana con cuenta gratuita de TP)  
* Copiar todo el plan de entrenamiento desde TrainingPeaks  
* Crear plan de entrenamiento o carpeta de entrenamientos en Intervals.icu desde entrenamientos planificados en TrainingPeaks  

Cuenta de entrenador  
* Copiar todo el plan de entrenamiento y biblioteca de entrenamientos desde TrainingPeaks  

**TrainerRoad**  
* Sincronizar entrenamientos planificados en el calendario desde TrainerRoad a TrainingPeaks o Intervals.icu  
* Copiar entrenamientos desde la biblioteca de TrainerRoad a Intervals  
* Crear plan de entrenamiento o carpeta de entrenamientos en Intervals.icu desde entrenamientos planificados en TrainerRoad  

Programar automáticamente los entrenamientos para hoy, revisando tu calendario cada 20 minutos.  
Para limpiar los trabajos programados solo reinicia la aplicación.  


## Configuración  
Antes de usar la aplicación necesitas configurar el acceso a las plataformas.  
Se requiere acceso a Intervals.icu, el acceso a otras plataformas es opcional.  

Después de reunir toda la configuración necesaria, puedes hacer clic en el botón Confirmar.  
Si todo está bien, serás redirigido a la página principal.  

Si tu configuración es incorrecta, verás un error que indica que no hay acceso a una plataforma en particular.  
Revisa todos tus valores y guarda la configuración nuevamente.  

### Intervals.icu  
Copia la clave API y el ID del atleta desde la [página de Configuración](https://intervals.icu/settings) en la sección de Configuración para desarrolladores en la página web de Intervals.icu.  

### TrainingPeaks
Para usar TrainingPeaks, copie todas las cookies de la solicitud `https://tpapi.trainingpeaks.com/users/v3/token` y colóquelas en la página de Configuración.  
La aplicación eliminará automáticamente las partes redundantes y solo quedará la cookie requerida. Siga la guía a continuación para saber cómo hacerlo.

La aplicación requiere la cookie `Production_tpAuth` (clave y valor, algo como `Production_tpAuth=cadena_muy_larga`).  
Otra guía está [disponible aquí](https://forum.intervals.icu/t/implemented-push-workout-to-wahoo/783/87)

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tp_guide.png?raw=true">

### TrainerRoad  
La configuración es muy similar a TrainingPeaks. Copie todas las cookies de la solicitud `https://tpapi.trainingpeaks.com/users/v3/token` y colóquelas en la página de Configuración.  
La aplicación eliminará automáticamente las partes redundantes y solo quedará la cookie requerida. Siga la guía a continuación para saber cómo hacerlo.

La cookie `SharedTrainerRoadAuth` (clave y valor, algo como `SharedTrainerRoadAuth=cadena_muy_larga`) es requerida para la aplicación.

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tr_guide.png?raw=true">

Tenga en cuenta que Firefox recorta cadenas largas en la ventana de Herramientas para desarrolladores. Copie el valor de la cookie con clic derecho -> Copiar valor.

## Otras formas de ejecutar la aplicación  
### JAR ejecutable  
El proyecto tiene un jar ejecutable con interfaz web. Requiere JDK 21. Para ejecutar el jar:
```shell
java -jar tp2intervals.jar
```
Por defecto, la interfaz de usuario está disponible en `http://localhost:8080`. Para cambiar el puerto, inicie el archivo jar con el parámetro:

```shell
java -Dserver.port=9090 -jar tp2intervals.jar
```

### Docker
También se construye una imagen de Docker para cada versión

```yaml
services:
  app:
    image: ghcr.io/freekode/tp2intervals:latest
    container_name: tp2intervals
    volumes:
      - ./tp2intervals.sqlite:/tp2intervals.sqlite
    ports:
      - '8080:8080'
```

## Preguntas Frecuentes

### General
* Los pasos de rampa en TrainerRoad no están soportados
* **MacOS arm64** Error: `"tp2intervals" está dañado y no se puede abrir.`
  Ejecute el comando en la terminal `xattr -d com.apple.quarantine /Applications/tp2intervals.app` y luego abra la aplicación nuevamente
* **MacOS** la aplicación no está firmada. Usualmente debe abrirla dos veces
* **Windows** La aplicación pedirá acceso a la red local e Internet, debe permitirlo. Después de todo, realiza solicitudes HTTP
* Más información puede encontrar en el foro https://forum.intervals.icu/t/tp2intervals-copy-trainingpeaks-and-trainerroad-workouts-plans-to-intervals/63375

### Información sobre la programación para el día siguiente con cuenta gratuita de TrainingPeaks
Oficialmente, si tiene una cuenta TP gratuita, no puede planificar entrenamientos para fechas futuras, pero prácticamente sí puede.
Puede planificar un entrenamiento para el día siguiente relativo al horario local del servidor de TrainingPeaks. El servidor está en zona horaria UTC-6. Veamos algunos ejemplos:

Ejemplo 1. Su zona horaria es UTC+2 y la fecha y hora local actual es 20.05.2024 06:00. Esto significa que en este momento la fecha y hora local del servidor TP es 19.05.2024 22:00.
Por lo tanto, puede planificar entrenamientos para el 20.05.2024. Pero no puede planificar entrenamientos para el 21.05.2024, podrá hacerlo en 2 horas, porque en 2 horas la hora local del servidor será 20.05.2024 00:00.

Ejemplo 2. Su zona horaria es UTC+12, fecha y hora local actual 20.05.2024 18:00. La hora local del servidor TP es 20.05.2024 00:00. En este momento, puede planificar entrenamientos para el 21.05.2024.

Diferencia horaria visible con [worldtimebuddy](https://www.worldtimebuddy.com/?pl=1&lid=206,100,756135,2193733&h=206&hf=0)

## Resolución de Problemas
Para identificar problemas con cualquier plataforma, los registros de los usuarios ayudan mucho.

Recoja los registros siguiendo la [guía a continuación](#how-to-get-logs). Y en caso de la plataforma TrainerRoad intente [grabar un archivo HAR](#how-to-record-har-file). Envíeme los archivos directamente.

#### Cómo obtener registros
1. Vaya a Configuración
2. En la sección General active el Modo Debug, haga clic en Confirmar
3. Reproduzca su problema
4. Encuentre el archivo de registro según su sistema

* Linux: ~/.config/tp2intervals/logs/main.log
* MacOS: ~/Library/Logs/tp2intervals/main.log
* Windows: %USERPROFILE%\AppData\Roaming\tp2intervals\logs\main.log
* JAR: ./tp2intervals.log

#### Cómo grabar un archivo HAR
1. Abra una nueva pestaña en su navegador
2. Abra las herramientas de desarrollo, marque Conservar registro (Firefox Engranaje -> Persistir registros)

   <img src="https://github.com/freekode/tp2intervals/blob/main/docs/har-1.png?raw=true" width="70%">
3. Los siguientes pasos son muy importantes, ya que simulan lo que hace la aplicación.
   Abra la página de TrainerRoad, abra la biblioteca de entrenamientos, encuentre cualquier entrenamiento, abra la página del entrenamiento (la página donde tiene el gráfico con los pasos del entrenamiento, descripción, alternativas, etc.)
4. En las herramientas de desarrollo, haga clic en Exportar HAR (Firefox - Engranaje -> Guardar todo como HAR), guarde el archivo y envíemelo

   <img src="https://github.com/freekode/tp2intervals/blob/main/docs/har-2.png?raw=true" width="70%">



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---