# YouTubePlayer

[![Maven Central](https://img.shields.io/maven-central/v/io.github.ilyapavlovskii/youtubeplayer-compose.svg)](https://central.sonatype.com/artifact/io.github.ilyapavlovskii/youtubeplayer-compose)
[![Kotlin](https://img.shields.io/badge/kotlin-v2.3.0-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![Compose Multiplatform](https://img.shields.io/badge/Compose%20Multiplatform-v8.13.2-blue)](https://github.com/JetBrains/compose-multiplatform)

![badge-android](http://img.shields.io/badge/platform-android-6EDB8D.svg?style=flat)
![badge-ios](http://img.shields.io/badge/platform-ios-CDCDCD.svg?style=flat)

YouTube kotlin 多平台播放器。
`YouTubePlayer` 组合式组件允许你在 Jetpack Compose 应用中嵌入一个 YouTube 视频播放器。

## 捐赠
如果你想感谢我或为项目开发做出贡献，可以捐赠给我。这有助于我更专注于项目。

[!["PayPal"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["Buy Me A Coffee"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

你也可以在以下平台关注我，以获取我主题的最新动态

[![medium](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![habr](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# 安装
你可以使用 Gradle 将此库添加到你的项目中。

多平台
要添加到多平台项目中，请将依赖项添加到 common 源代码集：

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

# 用法

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
可组合函数具有以下主要参数：

* `options` - 播放器选项构建器。所有参数均来自[官方YouTube iframe文档](https://developers.google.com/youtube/player_parameters#Parameters)。
* `hostState` - 用于跟踪YouTube播放器状态并执行一次性命令的控制器

### YouTubePlayerHostState
主要控制器。包含两个主要公共组件：
* currentState - 定义屏幕上实际的YouTube播放器状态。可能为：Idle、Ready、Playing、Error
* executeCommand - 用于执行播放器命令的挂起函数。仅接收一个参数 - <a name="YouTubeExecCommand">YouTubeExecCommand</a>。还具有一些附加的便捷函数，例如：

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
YouTube播放器状态定义屏幕上实际的YouTube播放器状态。包含以下可能的状态：
* `Idle` - 空闲状态表示播放器尚未初始化
* `Ready` - 表示播放器已准备好播放
* `Playing` - 播放器正在播放视频。包含以下参数：  
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `Error` - 定义错误状态，包含错误信息。


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - 通过 YouTube ID 加载视频。可以设置默认起始时间偏移。

* `Play` - 播放视频
* `Pause` - 暂停视频
* `SeekTo(val duration: Duration)` - 跳转视频到指定时间
* `SeekBy(val duration: Duration)` - 按指定时间跳转视频
* `Mute` - 静音
* `Unmute` - 取消静音
* `SetVolume(val volumePercent: Int)` - 设置音量。参数值应为0到100之间。
* `NextVideo` - 跳转到下一个视频
* `PreviousVideo` - 跳转到上一个视频
* `SetLoop(val loop: Boolean)` - 视频循环。由参数控制。
* `SetShuffle(val shuffle: Boolean)` - 视频随机播放。由参数控制。

### <a name="YouTubeEvent">YouTubeEvent</a>

* `Ready` - 当 YouTube 播放器初始化完成时调用
* `PlaybackQualityChange(val quality: Quality)` - 播放器质量改变时调用
* `Error(val error: String)` - 错误处理事件。详情见参数。
* `VideoDuration(val duration: Duration)` - 视频时长初始化时调用
* `StateChanged(val state: State)` - 视频状态改变时调用：`UNSTARTED`，`ENDED`，`PLAYING`，`PAUSED`，`BUFFERING`，`CUED`。
* `TimeChanged(val time: Duration)` - 时间戳变化
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - 视频加载完成回调

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