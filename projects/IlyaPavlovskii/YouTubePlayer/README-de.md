
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=IlyaPavlovskii&project=YouTubePlayer&lang=vi">Tiếng Việt</a>
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

YouTube Kotlin Multiplatform Player.
Das `YouTubePlayer` Composable ermöglicht es Ihnen, einen YouTube-Videoplayer in Ihre Jetpack Compose App einzubetten.

## Spenden
Wenn Sie mir danken oder zur Entwicklung des Backlogs beitragen möchten, können Sie mir spenden. Das hilft mir, mich mehr auf das Projekt zu konzentrieren.

[!["PayPal"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["Buy Me A Coffee"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

Sie können mir auch auf den folgenden Plattformen folgen, um Updates zu meinen Themen zu erhalten

[![medium](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![habr](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# Installation
Sie können diese Bibliothek mit Gradle zu Ihrem Projekt hinzufügen.

Multiplattform
Um sie zu einem Multiplattform-Projekt hinzuzufügen, fügen Sie die Abhängigkeit zum gemeinsamen Source-Set hinzu:

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

# Verwendung

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

Die Composable-Funktion hat die folgenden Hauptparameter:

* `options` - für den Player-Options-Builder. Alle Parameter sind aus der [offiziellen YouTube-Iframe-Dokumentation](https://developers.google.com/youtube/player_parameters#Parameters) übernommen.
* `hostState` - Controller zur Überwachung des YouTube-Player-Status und zur Ausführung von Einmal-Befehlen

### YouTubePlayerHostState
Der Hauptcontroller. Enthält zwei wesentliche öffentliche Komponenten:
* currentState - definiert den aktuellen YouTube-Player-Status auf dem Bildschirm. Kann sein: Idle, Ready, Playing, Error
* executeCommand - suspendierbare Funktion zur Ausführung von Player-Befehlen. Erhält nur ein Argument - <a name="YouTubeExecCommand">YouTubeExecCommand</a>. Außerdem gibt es zusätzliche Komfortfunktionen wie:
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
Der YouTube-Player-Zustand definiert den aktuellen Zustand des YouTube-Players auf dem Bildschirm. Enthält die folgenden möglichen Zustände:
* `Idle` - Der Idle-Zustand bedeutet, dass der Player noch nicht initialisiert ist
* `Ready` - Bedeutet, dass der Player bereit zum Abspielen ist
* `Playing` - Der Player spielt ein Video ab. Enthält die folgenden Parameter:
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `Error` - Definiert den Fehlerzustand mit einer Fehlermeldung im Inneren.


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - lädt Video anhand der YouTube-ID. Es ist möglich, mit einer Standard-Startzeit zu beginnen.

* `Play` - Video abspielen
* `Pause` - Video pausieren
* `SeekTo(val duration: Duration)` - Video zu einer angegebenen Zeit springen
* `SeekBy(val duration: Duration)` - Video um eine angegebene Zeit springen
* `Mute` - Ton stummschalten
* `Unmute` - Ton wieder einschalten
* `SetVolume(val volumePercent: Int)` - Lautstärke einstellen. Erwarteter Wert von 0 bis 100.
* `NextVideo` - zum nächsten Video navigieren
* `PreviousVideo` - zum vorherigen Video navigieren
* `SetLoop(val loop: Boolean)` - Video wiederholen. Wird durch Argument gesteuert.
* `SetShuffle(val shuffle: Boolean)` - Videos zufällig wiedergeben. Wird durch Argument gesteuert.

### <a name="YouTubeEvent">YouTubeEvent</a>

* `Ready` - wird aufgerufen, wenn die Initialisierung des YouTube Players abgeschlossen ist
* `PlaybackQualityChange(val quality: Quality)` - wird aufgerufen, wenn sich die Qualität des Players ändert
* `Error(val error: String)` - Fehlerbehandlungsereignis. Siehe Argument für Details.
* `VideoDuration(val duration: Duration)` - wird aufgerufen, wenn die Videodauer initialisiert wurde
* `StateChanged(val state: State)` - wird aufgerufen, wenn sich der Videostatus ändert: `UNSTARTED`,`ENDED`, `PLAYING`, `PAUSED`, `BUFFERING`, `CUED`.
* `TimeChanged(val time: Duration)` - Zeitstempel geändert
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - Callback, wenn Video geladen wurde

# Beispiel
![Beispiel](https://raw.githubusercontent.com/IlyaPavlovskii/YouTubePlayer/main/sample.png)

# LIZENZ

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