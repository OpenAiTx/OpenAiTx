# YouTubePlayer

[![Maven Central](https://img.shields.io/maven-central/v/io.github.ilyapavlovskii/youtubeplayer-compose.svg)](https://central.sonatype.com/artifact/io.github.ilyapavlovskii/youtubeplayer-compose)
[![Kotlin](https://img.shields.io/badge/kotlin-v2.3.0-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![Compose Multiplatform](https://img.shields.io/badge/Compose%20Multiplatform-v8.13.2-blue)](https://github.com/JetBrains/compose-multiplatform)

![badge-android](http://img.shields.io/badge/platform-android-6EDB8D.svg?style=flat)
![badge-ios](http://img.shields.io/badge/platform-ios-CDCDCD.svg?style=flat)

Reproductor multiplataforma de YouTube en Kotlin.  
El composable `YouTubePlayer` te permite insertar un reproductor de video de YouTube en tu aplicación Jetpack Compose.

## Donar  
Si deseas agradecerme o contribuir al desarrollo del backlog, puedes donarme. Eso me ayuda a concentrarme más en el proyecto.

[!["PayPal"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["Buy Me A Coffee"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

También puedes suscribirte a mis plataformas para ver cualquier actualización de mis temas

[![medium](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![habr](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# Instalación  
Puedes agregar esta biblioteca a tu proyecto usando Gradle.

Multiplataforma  
Para agregarla a un proyecto multiplataforma, añade la dependencia al conjunto de código común (common source-set):

```gradle
repositories {
    mavenCentral()
}

kotlin {
    sourceSets {
        commonMain {
            dependencies {
                implementation("io.github.ilyapavlovskii:youtubeplayer-compose:${latest_version}")
            }
        }
    }
}
```

# Uso

```kotlin
val coroutineScope = rememberCoroutineScope()
val hostState = remember { YouTubePlayerHostState() }

when(val state = hostState.currentState) {
    is YouTubePlayerState.Error -> {
        Text(text = "Error: ${state.message}")
    }
    YouTubePlayerState.Idle -> {
        // Do nothing, waiting for initialization
    }
    is YouTubePlayerState.Playing -> {
        // Update UI button states
    }
    YouTubePlayerState.Ready -> coroutineScope.launch {
        hostState.loadVideo(YouTubeVideoId("ufKj1sBrC4Q"))
    }
}

YouTubePlayer(
    modifier = Modifier
        .fillMaxWidth()
        .height(300.dp)
        .gesturesDisabled(),
    hostState = hostState,
    options = SimpleYouTubePlayerOptionsBuilder.builder {
        autoplay(true)
        mute(true) // autoplay works only with mute for mobile devices
        controls(false)
        rel(false)
        ivLoadPolicy(false)
        ccLoadPolicy(false)
        fullscreen = true
    },
)
```

La función composable tiene los siguientes parámetros principales:

* `options` - para el constructor de opciones del reproductor. Todos los parámetros están tomados de la [documentación oficial del iframe de YouTube](https://developers.google.com/youtube/player_parameters#Parameters).
* `hostState` - controlador para rastrear el estado del reproductor de YouTube y ejecutar comandos de una sola vez

### YouTubePlayerHostState
El controlador principal. Contiene 2 componentes públicos principales:
* currentState - define el estado actual del reproductor de YouTube en la pantalla. Puede ser: Idle, Ready, Playing, Error
* executeCommand - función suspendida para ejecutar comandos del reproductor. Recibe solo un argumento - <a name="YouTubeExecCommand">YouTubeExecCommand</a>. También tiene funciones auxiliares adicionales como:
```kotlin
suspend fun loadVideo(videoId: YouTubeVideoId) = executeCommand(YouTubeExecCommand.LoadVideo(videoId))
suspend fun play() = executeCommand(YouTubeExecCommand.Play)
suspend fun pause() = executeCommand(YouTubeExecCommand.Pause)
suspend fun seekTo(duration: Duration) = executeCommand(YouTubeExecCommand.SeekTo(duration))
suspend fun seekBy(duration: Duration) = executeCommand(YouTubeExecCommand.SeekBy(duration))
suspend fun mute() = executeCommand(YouTubeExecCommand.Mute)
suspend fun unMute() = executeCommand(YouTubeExecCommand.Unmute)
suspend fun setVolume(volume: Int) = executeCommand(YouTubeExecCommand.SetVolume(volume))
suspend fun setPlaybackRate(rate: Float) = executeCommand(YouTubeExecCommand.SetPlaybackRate(rate))
suspend fun toggleFullScreen() = executeCommand(YouTubeExecCommand.ToggleFullscreen)
```

### <a name="YouTubePlayerState">EstadoDelReproductorYouTube</a>
El estado del reproductor de YouTube define el estado actual del reproductor de YouTube en la pantalla. Contiene los siguientes estados posibles:
* `Idle` - El estado Idle significa que el reproductor aún no está inicializado
* `Ready` - Significa que el reproductor está listo para reproducir
* `Playing` - el reproductor está reproduciendo video. Contiene los siguientes parámetros:  
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `Error` - Define el estado de error con un mensaje de error dentro.


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - cargar video por ID de YouTube. Posible comenzar con un tiempo de inicio por defecto.

* `Play` - reproducir video
* `Pause` - pausar video
* `SeekTo(val duration: Duration)` - buscar el video a un tiempo especificado
* `SeekBy(val duration: Duration)` - buscar el video por un tiempo especificado
* `Mute` - silenciar sonido
* `Unmute` - activar sonido
* `SetVolume(val volumePercent: Int)` - establecer volumen. Valor esperado del argumento de 0 a 100.
* `NextVideo` - navegar al siguiente video
* `PreviousVideo` - navegar al video anterior
* `SetLoop(val loop: Boolean)` - repetir video. Controlado por argumento.
* `SetShuffle(val shuffle: Boolean)` - mezclar videos. Controlado por argumento.

### <a name="YouTubeEvent">YouTubeEvent</a>

* `Ready` - se llama cuando la inicialización del reproductor de YouTube se completa
* `PlaybackQualityChange(val quality: Quality)` - se llama cuando cambia la calidad del reproductor
* `Error(val error: String)` - evento para manejar errores. Ver detalles en el argumento.
* `VideoDuration(val duration: Duration)` - se llama cuando se inicializa la duración del video
* `StateChanged(val state: State)` - se llama cuando cambia el estado del video: `UNSTARTED`,`ENDED`, `PLAYING`, `PAUSED`, `BUFFERING`, `CUED`.
* `TimeChanged(val time: Duration)` - cambia la marca de tiempo
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - callback cuando el video se carga

# Sample
![Sample](https://raw.githubusercontent.com/IlyaPavlovskii/YouTubePlayer/main/sample.png)

# LICENSE

```
Copyright 2026 Ilia Pavlovskii

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-30

---