<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# مشغل اليوتيوب

[![Maven Central](https://img.shields.io/maven-central/v/io.github.ilyapavlovskii/youtubeplayer-compose.svg)](https://central.sonatype.com/artifact/io.github.ilyapavlovskii/youtubeplayer-compose)
[![Kotlin](https://img.shields.io/badge/kotlin-v2.3.0-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![Compose Multiplatform](https://img.shields.io/badge/Compose%20Multiplatform-v8.13.2-blue)](https://github.com/JetBrains/compose-multiplatform)

![badge-android](http://img.shields.io/badge/platform-android-6EDB8D.svg?style=flat)
![badge-ios](http://img.shields.io/badge/platform-ios-CDCDCD.svg?style=flat)


مشغل YouTube لمنصة كوتلن متعددة المنصات.
يتيح لك المركب `YouTubePlayer` تضمين مشغل فيديو YouTube في تطبيق Jetpack Compose الخاص بك.

## تبرع
إذا كنت ترغب في شكري أو المساهمة في تطوير قائمة المهام، يمكنك التبرع لي. هذا يساعدني على التركيز أكثر على المشروع.

[!["PayPal"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["Buy Me A Coffee"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

يمكنك أيضاً متابعتي على المنصات التالية لمتابعة أي تحديثات حول مواضيعي

[![medium](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![habr](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# التثبيت
يمكنك إضافة هذه المكتبة إلى مشروعك باستخدام Gradle.

متعددة المنصات
لإضافتها إلى مشروع متعدد المنصات، أضف الاعتمادية إلى مجموعة المصادر العامة:

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

# الاستخدام

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

الدالة المركبة تحتوي على المعاملات الرئيسية التالية:

* `options` - لمُنشئ خيارات المشغل. جميع المعاملات مأخوذة من [وثائق يوتيوب الرسمية لإطار العمل](https://developers.google.com/youtube/player_parameters#Parameters).
* `hostState` - وحدة التحكم لمتابعة حالة مشغل يوتيوب وتنفيذ الأوامر لمرة واحدة

### YouTubePlayerHostState
وحدة التحكم الرئيسية. تحتوي على مكونين عامين رئيسيين:
* currentState - يحدد الحالة الفعلية لمشغل يوتيوب على الشاشة. قد تكون: Idle، Ready، Playing، Error
* executeCommand - دالة معلقة لتنفيذ أوامر المشغل. تستقبل متغيراً واحداً فقط - <a name="YouTubeExecCommand">YouTubeExecCommand</a>. كما تحتوي على دوال إضافية مساعدة مثل:
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
حالة مشغل YouTube تحدد حالة مشغل YouTube الفعلية على الشاشة. تحتوي على الحالات الممكنة التالية:
* `Idle` - تعني أن المشغل غير مهيأ بعد
* `Ready` - تعني أن المشغل جاهز للتشغيل
* `Playing` - المشغل يقوم بتشغيل الفيديو. يحتوي على المعلمات التالية:
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `خطأ` - يعرّف حالة الخطأ مع رسالة الخطأ بداخله.


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - تحميل الفيديو بواسطة معرف يوتيوب. ممكن البدء مع وقت بداية افتراضي.

* `تشغيل` - تشغيل الفيديو
* `إيقاف مؤقت` - إيقاف الفيديو مؤقتاً
* `SeekTo(val duration: Duration)` - الانتقال إلى وقت محدد في الفيديو
* `SeekBy(val duration: Duration)` - الانتقال بمدة زمنية محددة في الفيديو
* `كتم الصوت` - كتم الصوت
* `إلغاء كتم الصوت` - إلغاء كتم الصوت
* `SetVolume(val volumePercent: Int)` - ضبط مستوى الصوت. القيم المتوقعة من 0 إلى 100.
* `NextVideo` - الانتقال إلى الفيديو التالي
* `PreviousVideo` - الانتقال إلى الفيديو السابق
* `SetLoop(val loop: Boolean)` - تكرار الفيديو. تتم الإدارة بواسطة الوسيطة.
* `SetShuffle(val shuffle: Boolean)` - تشغيل الفيديوهات بشكل عشوائي. تتم الإدارة بواسطة الوسيطة.

### <a name="YouTubeEvent">YouTubeEvent</a>

* `جاهز` - يتم الاستدعاء عند اكتمال تهيئة مشغل يوتيوب
* `PlaybackQualityChange(val quality: Quality)` - يتم الاستدعاء عند تغيير جودة المشغل
* `Error(val error: String)` - حدث التعامل مع الخطأ. راجع الوسيطة للتفاصيل.
* `VideoDuration(val duration: Duration)` - يتم الاستدعاء عند تهيئة مدة الفيديو
* `StateChanged(val state: State)` - يتم الاستدعاء عند تغيير حالة الفيديو: `UNSTARTED`,`ENDED`, `PLAYING`, `PAUSED`, `BUFFERING`, `CUED`.
* `TimeChanged(val time: Duration)` - تغير الطابع الزمني
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - معاودة الاتصال عند تحميل الفيديو

# مثال
![مثال](https://raw.githubusercontent.com/IlyaPavlovskii/YouTubePlayer/main/sample.png)

# الرخصة

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