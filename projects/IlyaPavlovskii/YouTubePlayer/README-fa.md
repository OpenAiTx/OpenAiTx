<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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

# پخش‌کننده یوتیوب

[![Maven Central](https://img.shields.io/maven-central/v/io.github.ilyapavlovskii/youtubeplayer-compose.svg)](https://central.sonatype.com/artifact/io.github.ilyapavlovskii/youtubeplayer-compose)
[![Kotlin](https://img.shields.io/badge/kotlin-v2.3.0-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![Compose Multiplatform](https://img.shields.io/badge/Compose%20Multiplatform-v8.13.2-blue)](https://github.com/JetBrains/compose-multiplatform)

![badge-android](http://img.shields.io/badge/platform-android-6EDB8D.svg?style=flat)
![badge-ios](http://img.shields.io/badge/platform-ios-CDCDCD.svg?style=flat)


پخش‌کننده چندسکویی یوتیوب با کاتلین.
کامپوزابل `YouTubePlayer` به شما اجازه می‌دهد یک پخش‌کننده ویدیوی یوتیوب را در اپلیکیشن Jetpack Compose خود جای دهید.

## حمایت مالی
اگر مایلید از من تشکر کنید یا در توسعه برنامه‌های آینده مشارکت داشته باشید، می‌توانید به من کمک مالی کنید. این کار به من کمک می‌کند تا بیشتر بر روی پروژه تمرکز کنم.

[!["پی‌پل"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["خرید یک قهوه"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

همچنین می‌توانید برای دریافت به‌روزرسانی‌های جدید من را در پلتفرم‌های زیر دنبال کنید

[![مدیوم](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![هبرا](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# نصب
شما می‌توانید این کتابخانه را با استفاده از Gradle به پروژه خود اضافه کنید.

چندسکویی
برای افزودن به یک پروژه چندسکویی، وابستگی را به سورس‌ست مشترک اضافه کنید:

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

# نحوه استفاده

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
تابع کامپوزبل پارامترهای اصلی زیر را دارد:

* `options` - برای ساخت گزینه‌های پخش‌کننده. تمامی پارامترها از [مستندات رسمی آیفریم یوتیوب](https://developers.google.com/youtube/player_parameters#Parameters) گرفته شده‌اند.
* `hostState` - کنترل‌کننده برای پیگیری وضعیت پخش‌کننده یوتیوب و اجرای دستورات یک‌باره

### YouTubePlayerHostState
کنترل‌کننده اصلی. شامل دو مؤلفه عمومی اصلی است:
* currentState - وضعیت فعلی پخش‌کننده یوتیوب روی صفحه را مشخص می‌کند. ممکن است یکی از این حالت‌ها باشد: Idle، Ready، Playing، Error
* executeCommand - تابع معلق برای اجرای دستورات پخش‌کننده. فقط یک آرگومان می‌گیرد - <a name="YouTubeExecCommand">YouTubeExecCommand</a>. همچنین توابع اضافی کمکی مانند:

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
وضعیت پخش‌کننده YouTube وضعیت واقعی پخش‌کننده یوتیوب را روی صفحه تعریف می‌کند. شامل حالات ممکن زیر است:
* `Idle` - حالت Idle به این معنی است که پخش‌کننده هنوز مقداردهی اولیه نشده است
* `Ready` - به این معنی است که پخش‌کننده آماده پخش است
* `Playing` - پخش‌کننده در حال پخش ویدیو است. شامل پارامترهای زیر می‌باشد:
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `Error` - حالت خطا را با پیام خطا درون خود تعریف می‌کند.


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - بارگذاری ویدیو با آیدی یوتیوب. امکان شروع با افست زمان پیش‌فرض وجود دارد.

* `Play` - پخش ویدیو
* `Pause` - توقف ویدیو
* `SeekTo(val duration: Duration)` - رفتن به زمان مشخصی از ویدیو
* `SeekBy(val duration: Duration)` - جابجایی ویدیو به میزان زمان مشخص
* `Mute` - بی‌صدا کردن صدا
* `Unmute` - فعال‌سازی صدا
* `SetVolume(val volumePercent: Int)` - تنظیم حجم صدا. مقدار ورودی مورد انتظار بین ۰ تا ۱۰۰.
* `NextVideo` - رفتن به ویدیوی بعدی
* `PreviousVideo` - رفتن به ویدیوی قبلی
* `SetLoop(val loop: Boolean)` - تکرار ویدیو. توسط آرگومان کنترل می‌شود.
* `SetShuffle(val shuffle: Boolean)` - پخش تصادفی ویدیوها. توسط آرگومان کنترل می‌شود.

### <a name="YouTubeEvent">YouTubeEvent</a>

* `Ready` - زمانی که مقداردهی اولیه پلیر یوتیوب کامل شد فراخوانی می‌شود
* `PlaybackQualityChange(val quality: Quality)` - هنگام تغییر کیفیت پلیر فراخوانی می‌شود
* `Error(val error: String)` - رویداد مدیریت خطا. برای جزئیات به آرگومان مراجعه کنید.
* `VideoDuration(val duration: Duration)` - هنگام مقداردهی اولیه مدت زمان ویدیو فراخوانی می‌شود
* `StateChanged(val state: State)` - هنگام تغییر وضعیت ویدیو فراخوانی می‌شود: `UNSTARTED`,`ENDED`, `PLAYING`, `PAUSED`, `BUFFERING`, `CUED`.
* `TimeChanged(val time: Duration)` - زمان فعلی تغییر کرد
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - کال‌بک زمانی که ویدیو بارگذاری شد

# نمونه
![نمونه](https://raw.githubusercontent.com/IlyaPavlovskii/YouTubePlayer/main/sample.png)

# مجوز

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