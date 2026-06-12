<div align="right">
  <details>
    <summary >🌐 Język</summary>
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


YouTube kotlin multiplatform player.
Komponent `YouTubePlayer` pozwala na osadzenie odtwarzacza YouTube w Twojej aplikacji Jetpack Compose.

## Wsparcie
Jeśli chcesz mi podziękować lub wesprzeć rozwój projektu, możesz przekazać darowiznę. To pomaga mi bardziej skoncentrować się na projekcie.

[!["PayPal"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["Buy Me A Coffee"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

Możesz również zasubskrybować mnie na poniższych platformach, aby być na bieżąco z aktualizacjami moich tematów

[![medium](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![habr](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# Instalacja
Możesz dodać tę bibliotekę do swojego projektu za pomocą Gradle.

Multiplatform
Aby dodać do projektu multiplatformowego, dodaj zależność do wspólnego source-setu:

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

# Użytkowanie

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

Funkcja kompozycyjna ma następujące główne parametry:

* `options` - do budowania opcji odtwarzacza. Wszystkie parametry zawinięte z [oficjalnej dokumentacji iframe YouTube](https://developers.google.com/youtube/player_parameters#Parameters).
* `hostState` - kontroler do śledzenia stanu odtwarzacza YouTube i wykonywania jednorazowych poleceń

### YouTubePlayerHostState
Główny kontroler. Zawiera 2 główne publiczne komponenty:
* currentState - określa aktualny stan odtwarzacza YouTube na ekranie. Może być: Idle, Ready, Playing, Error
* executeCommand - funkcja zawieszająca do wykonywania poleceń odtwarzacza. Przyjmuje tylko jeden argument - <a name="YouTubeExecCommand">YouTubeExecCommand</a>. Posiada również dodatkowe funkcje pomocnicze, takie jak:
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
Stan odtwarzacza YouTube definiuje aktualny stan odtwarzacza YouTube na ekranie. Zawiera następujące możliwe stany:
* `Idle` - Stan bezczynności oznacza, że odtwarzacz nie został jeszcze zainicjowany
* `Ready` - Oznacza, że odtwarzacz jest gotowy do odtwarzania
* `Playing` - Odtwarzacz odtwarza wideo. Zawiera następujące parametry:
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `Error` - Definiuje stan błędu z komunikatem błędu wewnątrz.


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - załaduj wideo według identyfikatora YouTube. Możliwe rozpoczęcie od domyślnego przesunięcia czasu.

* `Play` - odtwarzaj wideo
* `Pause` - wstrzymaj wideo
* `SeekTo(val duration: Duration)` - przesuń wideo do określonego czasu
* `SeekBy(val duration: Duration)` - przesuń wideo o określony czas
* `Mute` - wycisz dźwięk
* `Unmute` - włącz dźwięk
* `SetVolume(val volumePercent: Int)` - ustaw głośność. Oczekiwana wartość argumentu od 0 do 100.
* `NextVideo` - przejdź do następnego wideo
* `PreviousVideo` - przejdź do poprzedniego wideo
* `SetLoop(val loop: Boolean)` - powtarzaj wideo. Zarządzane przez argument.
* `SetShuffle(val shuffle: Boolean)` - odtwarzaj losowo wideo. Zarządzane przez argument.

### <a name="YouTubeEvent">YouTubeEvent</a>

* `Ready` - wywoływane po zakończeniu inicjalizacji odtwarzacza YouTube
* `PlaybackQualityChange(val quality: Quality)` - wywoływane po zmianie jakości odtwarzania
* `Error(val error: String)` - zdarzenie obsługi błędu. Szczegóły w argumencie.
* `VideoDuration(val duration: Duration)` - wywoływane po zainicjowaniu długości wideo
* `StateChanged(val state: State)` - wywoływane po zmianie stanu wideo: `UNSTARTED`,`ENDED`, `PLAYING`, `PAUSED`, `BUFFERING`, `CUED`.
* `TimeChanged(val time: Duration)` - zmiana znacznika czasu
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - wywołanie zwrotne po załadowaniu wideo

# Przykład
![Sample](https://raw.githubusercontent.com/IlyaPavlovskii/YouTubePlayer/main/sample.png)

# LICENCJA

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