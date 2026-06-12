
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

Trình phát YouTube Kotlin đa nền tảng.
Composable `YouTubePlayer` cho phép bạn nhúng trình phát video YouTube vào ứng dụng Jetpack Compose của bạn.

## Ủng hộ
Nếu bạn muốn cảm ơn tôi hoặc đóng góp cho việc phát triển các tính năng dự kiến, bạn có thể ủng hộ cho tôi. Điều đó giúp tôi tập trung hơn vào dự án.

[!["PayPal"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["Buy Me A Coffee"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

Bạn cũng có thể theo dõi tôi trên các nền tảng sau để nhận các cập nhật mới về chủ đề của tôi

[![medium](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![habr](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# Cài đặt
Bạn có thể thêm thư viện này vào dự án của bạn bằng Gradle.

Đa nền tảng
Để thêm vào dự án đa nền tảng, hãy thêm dependency vào common source-set:

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

# Sử dụng

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


Composable function có các tham số chính sau:

* `options` - để xây dựng các tùy chọn cho trình phát. Tất cả các tham số được đóng gói từ [tài liệu iframe youtube chính thức](https://developers.google.com/youtube/player_parameters#Parameters).
* `hostState` - bộ điều khiển để theo dõi trạng thái trình phát youtube và thực thi các lệnh một lần

### YouTubePlayerHostState
Bộ điều khiển chính. Chứa 2 thành phần công khai chính:
* currentState - xác định trạng thái thực tế của trình phát youtube trên màn hình. Có thể là: Idle, Ready, Playing, Error
* executeCommand - hàm treo để thực thi các lệnh trình phát. Chỉ nhận một đối số duy nhất - <a name="YouTubeExecCommand">YouTubeExecCommand</a>. Ngoài ra còn có các hàm bổ trợ như:
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
Trạng thái trình phát YouTube xác định trạng thái thực tế của trình phát YouTube trên màn hình. Bao gồm các trạng thái có thể sau:
* `Idle` - Trạng thái nhàn rỗi nghĩa là trình phát chưa được khởi tạo
* `Ready` - Nghĩa là trình phát đã sẵn sàng để phát
* `Playing` - trình phát đang phát video. Bao gồm các tham số sau:
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `Error` - Định nghĩa trạng thái lỗi với thông báo lỗi bên trong.


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - tải video bằng id youtube. Có thể bắt đầu với thời gian mặc định.
* `Play` - phát video
* `Pause` - tạm dừng video
* `SeekTo(val duration: Duration)` - tua đến thời gian xác định
* `SeekBy(val duration: Duration)` - tua video theo khoảng thời gian xác định
* `Mute` - tắt âm thanh
* `Unmute` - bật âm thanh
* `SetVolume(val volumePercent: Int)` - đặt mức âm lượng. Giá trị mong đợi từ 0 đến 100.
* `NextVideo` - chuyển sang video tiếp theo
* `PreviousVideo` - quay lại video trước
* `SetLoop(val loop: Boolean)` - lặp lại video. Quản lý bằng tham số.
* `SetShuffle(val shuffle: Boolean)` - phát ngẫu nhiên video. Quản lý bằng tham số.

### <a name="YouTubeEvent">YouTubeEvent</a>

* `Ready` - gọi khi quá trình khởi tạo trình phát youtube hoàn tất
* `PlaybackQualityChange(val quality: Quality)` - gọi khi chất lượng phát thay đổi
* `Error(val error: String)` - sự kiện xử lý lỗi. Xem tham số để biết chi tiết.
* `VideoDuration(val duration: Duration)` - gọi khi thời lượng video được khởi tạo
* `StateChanged(val state: State)` - gọi khi trạng thái video thay đổi: `UNSTARTED`,`ENDED`, `PLAYING`, `PAUSED`, `BUFFERING`, `CUED`.
* `TimeChanged(val time: Duration)` - dấu thời gian thay đổi
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - callback khi video đã tải

# Ví dụ
![Sample](https://raw.githubusercontent.com/IlyaPavlovskii/YouTubePlayer/main/sample.png)

# GIẤY PHÉP


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