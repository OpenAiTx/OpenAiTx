<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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


YouTube kotlin multiplatform oynatıcısı.
`YouTubePlayer` composable'ı, Jetpack Compose uygulamanıza bir YouTube video oynatıcısı yerleştirmenize olanak tanır.

## Bağış Yapın
Bana teşekkür etmek ya da geliştirme sürecine katkıda bulunmak isterseniz, bana bağış yapabilirsiniz. Bu, projeye daha fazla odaklanmamı sağlar.

[!["PayPal"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["Bana Bir Kahve Al"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

Ayrıca, konularımın herhangi bir güncellemesini görmek için aşağıdaki platformlarda da abone olabilirsiniz

[![medium](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![habr](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# Kurulum
Bu kütüphaneyi projenize Gradle kullanarak ekleyebilirsiniz.

Çoklu Platform
Çoklu platform projesine eklemek için, bağımlılığı ortak kaynak kümesine ekleyin:

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

# Kullanım

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

Bileşik fonksiyonun ana parametreleri şunlardır:

* `options` - oynatıcı seçenekleri oluşturucu. Tüm parametreler [resmi youtube iframe dokümantasyonu](https://developers.google.com/youtube/player_parameters#Parameters) üzerinden alınmıştır.
* `hostState` - youtube oynatıcı durumunu takip eden ve tek seferlik komutları yürüten denetleyici

### YouTubePlayerHostState
Ana denetleyici. 2 ana genel bileşen içerir:
* currentState - ekranda mevcut youtube oynatıcı durumunu tanımlar. Şu değerleri alabilir: Idle, Ready, Playing, Error
* executeCommand - oynatıcı komutlarını yürütmek için askıya alınan fonksiyon. Sadece bir argüman alır - <a name="YouTubeExecCommand">YouTubeExecCommand</a>. Ayrıca şu gibi ek kolaylaştırıcı fonksiyonlara sahiptir:
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
YouTube oynatıcı durumu, ekrandaki gerçek YouTube oynatıcı durumunu tanımlar. Aşağıdaki olası durumları içerir:
* `Idle` - Boşta durumu, oynatıcının henüz başlatılmadığı anlamına gelir
* `Ready` - Oynatıcının oynatmaya hazır olduğu anlamına gelir
* `Playing` - Oynatıcı video oynatıyor. Şu parametreleri içerir:  
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `Error` - Hata mesajı ile hata durumunu tanımlar.


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - youtube kimliği ile videoyu yükler. Varsayılan başlangıç zamanı ile başlatmak mümkündür.

* `Play` - videoyu oynat
* `Pause` - videoyu duraklat
* `SeekTo(val duration: Duration)` - videoyu belirtilen zamana sar
* `SeekBy(val duration: Duration)` - videoyu belirtilen süre kadar sar
* `Mute` - sesi kapat
* `Unmute` - sesi aç
* `SetVolume(val volumePercent: Int)` - ses seviyesini ayarla. Beklenen değer 0 ile 100 arasında olmalıdır.
* `NextVideo` - sonraki videoya geç
* `PreviousVideo` - önceki videoya geri dön
* `SetLoop(val loop: Boolean)` - videoyu tekrar et. Argüman ile yönetilir.
* `SetShuffle(val shuffle: Boolean)` - videoları karıştır. Argüman ile yönetilir.

### <a name="YouTubeEvent">YouTubeEvent</a>

* `Ready` - youtube oynatıcı başlatıldığında çağrılır
* `PlaybackQualityChange(val quality: Quality)` - oynatıcı kalitesi değiştiğinde çağrılır
* `Error(val error: String)` - hata işleme olayı. Ayrıntılar için argümana bakınız.
* `VideoDuration(val duration: Duration)` - video süresi başlatıldığında çağrılır
* `StateChanged(val state: State)` - video durumu değiştiğinde çağrılır: `UNSTARTED`,`ENDED`, `PLAYING`, `PAUSED`, `BUFFERING`, `CUED`.
* `TimeChanged(val time: Duration)` - zaman damgası değişti
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - video yüklendiğinde geri çağırma

# Örnek
![Örnek](https://raw.githubusercontent.com/IlyaPavlovskii/YouTubePlayer/main/sample.png)

# LİSANS

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