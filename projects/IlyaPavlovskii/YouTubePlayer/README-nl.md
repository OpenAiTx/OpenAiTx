<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# YouTubePlayer

[![Maven Central](https://img.shields.io/maven-central/v/io.github.ilyapavlovskii/youtubeplayer-compose.svg)](https://central.sonatype.com/artifact/io.github.ilyapavlovskii/youtubeplayer-compose)
[![Kotlin](https://img.shields.io/badge/kotlin-v2.3.0-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![Compose Multiplatform](https://img.shields.io/badge/Compose%20Multiplatform-v8.13.2-blue)](https://github.com/JetBrains/compose-multiplatform)

![badge-android](http://img.shields.io/badge/platform-android-6EDB8D.svg?style=flat)
![badge-ios](http://img.shields.io/badge/platform-ios-CDCDCD.svg?style=flat)


YouTube kotlin multiplatform speler.
De `YouTubePlayer` composable stelt je in staat om een YouTube videospeler in je Jetpack Compose-app te integreren.

## Doneren
Als je mij wilt bedanken of wilt bijdragen aan de ontwikkeling van de backlog, kun je mij een donatie geven. Dat helpt mij om meer op het project te focussen.

[!["PayPal"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["Buy Me A Coffee"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

Je kunt je ook op de volgende platformen abonneren om op de hoogte te blijven van updates over mijn onderwerpen

[![medium](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![habr](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# Installeren
Je kunt deze bibliotheek toevoegen aan je project via Gradle.

Multiplatform
Om toe te voegen aan een multiplatform-project, voeg je de dependency toe aan de common source-set:

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

# Gebruik

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

Composable functie heeft de volgende belangrijke parameters:

* `options` - voor de player options builder. Alle parameters zijn overgenomen uit de [officiële YouTube iframe documentatie](https://developers.google.com/youtube/player_parameters#Parameters).
* `hostState` - controller om de status van de YouTube-speler te volgen en eenmalige commando's uit te voeren

### YouTubePlayerHostState
De hoofdcontroller. Bevat 2 belangrijke publieke componenten:
* currentState - definieert de actuele status van de YouTube-speler op het scherm. Kan zijn: Idle, Ready, Playing, Error
* executeCommand - suspend functie om spelercommando's uit te voeren. Ontvangt slechts één argument - <a name="YouTubeExecCommand">YouTubeExecCommand</a>. Heeft ook enkele extra gemaksfuncties zoals:
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

### <a name="YouTubePlayerState">YouTubePlayerState</a>
YouTube-spelerstatus definieert de daadwerkelijke status van de YouTube-speler op het scherm. Bevat de volgende mogelijke statussen:
* `Idle` - Idle status betekent dat de speler nog niet is geïnitialiseerd
* `Ready` - Betekent dat de speler klaar is om af te spelen
* `Playing` - speler is video aan het afspelen. Bevat de volgende parameters:
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `Error` - Definieert foutstatus met foutmelding binnenin.


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - laad video via YouTube-id. Mogelijk om te starten met standaard starttijd-offset.

* `Play` - speel video af
* `Pause` - pauzeer video
* `SeekTo(val duration: Duration)` - spoel video naar een opgegeven tijd
* `SeekBy(val duration: Duration)` - spoel video vooruit/achteruit met een opgegeven tijd
* `Mute` - demp geluid
* `Unmute` - zet geluid aan
* `SetVolume(val volumePercent: Int)` - stel volume in. Verwachte waarde van 0 tot 100.
* `NextVideo` - ga naar volgende video
* `PreviousVideo` - ga naar vorige video
* `SetLoop(val loop: Boolean)` - herhaal video. Beheerd door argument.
* `SetShuffle(val shuffle: Boolean)` - shuffle video's. Beheerd door argument.

### <a name="YouTubeEvent">YouTubeEvent</a>

* `Ready` - wordt aangeroepen wanneer de initialisatie van de YouTube-speler voltooid is
* `PlaybackQualityChange(val quality: Quality)` - wordt aangeroepen bij verandering van afspeelkwaliteit
* `Error(val error: String)` - foutafhandelingsgebeurtenis. Zie argument voor details.
* `VideoDuration(val duration: Duration)` - wordt aangeroepen wanneer videoduur is geïnitialiseerd
* `StateChanged(val state: State)` - wordt aangeroepen wanneer videostatus verandert: `UNSTARTED`, `ENDED`, `PLAYING`, `PAUSED`, `BUFFERING`, `CUED`.
* `TimeChanged(val time: Duration)` - tijdstempel gewijzigd
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - callback wanneer video geladen is

# Voorbeeld
![Sample](https://raw.githubusercontent.com/IlyaPavlovskii/YouTubePlayer/main/sample.png)

# LICENTIE

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---