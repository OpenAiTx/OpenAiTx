
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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
`YouTubePlayer` composable ช่วยให้คุณฝังเครื่องเล่นวิดีโอ YouTube ในแอป Jetpack Compose ของคุณได้

## บริจาค
หากคุณต้องการขอบคุณหรือสนับสนุนการพัฒนารายการ backlog คุณสามารถบริจาคให้ฉันได้ นั่นจะช่วยให้ฉันมีสมาธิกับโปรเจกต์มากขึ้น

[!["PayPal"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["Buy Me A Coffee"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

คุณยังสามารถติดตามฉันในแพลตฟอร์มต่อไปนี้เพื่อดูการอัปเดตในหัวข้อต่าง ๆ ของฉัน

[![medium](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![habr](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# การติดตั้ง
คุณสามารถเพิ่มไลบรารีนี้ลงในโปรเจกต์ของคุณได้โดยใช้ Gradle

มัลติแพลตฟอร์ม
หากต้องการเพิ่มในโปรเจกต์มัลติแพลตฟอร์ม ให้เพิ่ม dependency ใน common source-set:

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

# การใช้งาน

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
ฟังก์ชัน Composable มีพารามิเตอร์หลักดังต่อไปนี้:

* `options` - สำหรับตัวสร้างตัวเลือกของผู้เล่น ว่าพารามิเตอร์ทั้งหมดห่อหุ้มมาจาก [เอกสารประกอบ iframe ของ YouTube อย่างเป็นทางการ](https://developers.google.com/youtube/player_parameters#Parameters)
* `hostState` - ตัวควบคุมสำหรับติดตามสถานะของ YouTube player และดำเนินการคำสั่งแบบหนึ่งครั้ง

### YouTubePlayerHostState
ตัวควบคุมหลัก ประกอบด้วยส่วนประกอบสาธารณะหลัก 2 ส่วน:
* currentState - กำหนดสถานะปัจจุบันของ YouTube player บนหน้าจอ อาจเป็น: Idle, Ready, Playing, Error
* executeCommand - ฟังก์ชัน suspend สำหรับดำเนินการคำสั่งของ player โดยรับอาร์กิวเมนต์เดียวเท่านั้น คือ <a name="YouTubeExecCommand">YouTubeExecCommand</a> นอกจากนี้ยังมีฟังก์ชันเสริมเพิ่มเติม เช่น:

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
สถานะของ YouTube player กำหนดสถานะของเครื่องเล่น YouTube จริงบนหน้าจอ ประกอบด้วยสถานะที่เป็นไปได้ดังต่อไปนี้:
* `Idle` - สถานะ Idle หมายถึงเครื่องเล่นยังไม่ได้ถูกเริ่มต้นใช้งาน
* `Ready` - หมายถึงเครื่องเล่นพร้อมที่จะเล่นแล้ว
* `Playing` - เครื่องเล่นกำลังเล่นวิดีโออยู่ ประกอบด้วยพารามิเตอร์ต่อไปนี้:
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `Error` - กำหนดสถานะข้อผิดพลาดพร้อมข้อความข้อผิดพลาดภายใน


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - โหลดวิดีโอตามรหัส youtube สามารถเริ่มต้นด้วยค่า offset ของเวลาที่กำหนดได้

* `Play` - เล่นวิดีโอ
* `Pause` - หยุดชั่วคราววิดีโอ
* `SeekTo(val duration: Duration)` - เลื่อนวิดีโอไปยังเวลาที่กำหนด
* `SeekBy(val duration: Duration)` - เลื่อนวิดีโอไปตามเวลาที่กำหนด
* `Mute` - ปิดเสียง
* `Unmute` - เปิดเสียง
* `SetVolume(val volumePercent: Int)` - ตั้งค่าระดับเสียง ค่าพารามิเตอร์ระหว่าง 0 ถึง 100
* `NextVideo` - ไปยังวิดีโอต่อไป
* `PreviousVideo` - กลับไปยังวิดีโอก่อนหน้า
* `SetLoop(val loop: Boolean)` - วนซ้ำวิดีโอ จัดการโดยพารามิเตอร์
* `SetShuffle(val shuffle: Boolean)` - สุ่มลำดับวิดีโอ จัดการโดยพารามิเตอร์

### <a name="YouTubeEvent">YouTubeEvent</a>

* `Ready` - เรียกเมื่อการเริ่มต้น youtube player เสร็จสมบูรณ์
* `PlaybackQualityChange(val quality: Quality)` - เรียกเมื่อคุณภาพการเล่นเปลี่ยนแปลง
* `Error(val error: String)` - กิจกรรมจัดการข้อผิดพลาด ดูรายละเอียดในพารามิเตอร์
* `VideoDuration(val duration: Duration)` - เรียกเมื่อระยะเวลาวิดีโอถูกกำหนดค่าแล้ว
* `StateChanged(val state: State)` - เรียกเมื่อสถานะวิดีโอเปลี่ยน: `UNSTARTED`,`ENDED`, `PLAYING`, `PAUSED`, `BUFFERING`, `CUED`.
* `TimeChanged(val time: Duration)` - เปลี่ยนแปลงเวลาปัจจุบัน
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - callback เมื่อโหลดวิดีโอแล้ว

# ตัวอย่าง
![ตัวอย่าง](https://raw.githubusercontent.com/IlyaPavlovskii/YouTubePlayer/main/sample.png)

# ใบอนุญาต

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