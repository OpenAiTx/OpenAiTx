# YouTubePlayer

[![Maven Central](https://img.shields.io/maven-central/v/io.github.ilyapavlovskii/youtubeplayer-compose.svg)](https://central.sonatype.com/artifact/io.github.ilyapavlovskii/youtubeplayer-compose)
[![Kotlin](https://img.shields.io/badge/kotlin-v2.3.0-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![Compose Multiplatform](https://img.shields.io/badge/Compose%20Multiplatform-v8.13.2-blue)](https://github.com/JetBrains/compose-multiplatform)

![badge-android](http://img.shields.io/badge/platform-android-6EDB8D.svg?style=flat)
![badge-ios](http://img.shields.io/badge/platform-ios-CDCDCD.svg?style=flat)

YouTube kotlin マルチプラットフォームプレーヤー。  
`YouTubePlayer` コンポーザブルは、Jetpack Compose アプリに YouTube ビデオプレーヤーを埋め込むことを可能にします。

## 寄付
もし私に感謝したい、またはバックログの開発に貢献したい場合は、寄付をしていただけると助かります。  
それにより、プロジェクトにより集中することができます。

[!["PayPal"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/paypal.svg)](https://www.paypal.com/paypalme/ipavlovskii)
[!["Buy Me A Coffee"](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/buy_me_a_coffee.svg)](https://www.buymeacoffee.com/ipavlovskii)

また、次のプラットフォームで私をフォローして、私のトピックの最新情報を見ることもできます。

[![medium](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/medium.svg)](https://pavlovskiiilia.medium.com/)
[![habr](https://raw.githubusercontent.com/IlyaPavlovskii/IlyaPavlovskii/main/resources/habr.svg)](https://habr.com/ru/users/TranE91/posts/)

# インストール
このライブラリをプロジェクトに Gradle で追加できます。

マルチプラットフォーム  
マルチプラットフォームプロジェクトに追加するには、common ソースセットに依存関係を追加してください：
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

# 使用方法

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

Composable関数には次の主要なパラメータがあります：

* `options` - プレイヤーオプションビルダー。すべてのパラメータは[公式YouTube iframeドキュメント](https://developers.google.com/youtube/player_parameters#Parameters)からラップされています。
* `hostState` - YouTubeプレイヤーの状態を追跡し、一度だけコマンドを実行するためのコントローラー

### YouTubePlayerHostState
メインのコントローラー。2つの主要な公開コンポーネントを含みます：
* currentState - 画面上の実際のYouTubeプレイヤーの状態を定義します。Idle、Ready、Playing、Errorのいずれかです
* executeCommand - プレイヤーコマンドを実行するためのサスペンド関数。引数は1つだけ受け取ります - <a name="YouTubeExecCommand">YouTubeExecCommand</a>。また、以下のような追加の便利関数も備えています：
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
YouTubeプレーヤーの状態は、画面上の実際のYouTubeプレーヤーの状態を定義します。次の可能な状態を含みます：
* `Idle` - Idle状態はプレーヤーがまだ初期化されていないことを意味します
* `Ready` - プレーヤーが再生準備完了であることを意味します
* `Playing` - プレーヤーが動画を再生中です。次のパラメータを含みます：  
```kotlin
videoId: YouTubeVideoId - id of the video that is playing
duration: Duration - duration of the video
currentTime: Duration - current time of the video
quality: YouTubeEvent.PlaybackQualityChange.Quality - quality of the video, see [YouTubeEvent.PlaybackQualityChange.Quality]
isPlaying: Boolean - is video playing
```
* `Error` - エラーメッセージを含むエラー状態を定義します。


### <a name="YouTubeExecCommand">YouTubeExecCommand</a>

* `LoadVideo(val videoId: YouTubeVideoId,val startSeconds: Duration)` - YouTube IDで動画を読み込みます。デフォルトの開始時間オフセットを指定可能です。

* `Play` - 動画を再生します
* `Pause` - 動画を一時停止します
* `SeekTo(val duration: Duration)` - 指定した時間に動画をシークします
* `SeekBy(val duration: Duration)` - 指定した時間分だけ動画をシークします
* `Mute` - 音声をミュートします
* `Unmute` - ミュート解除します
* `SetVolume(val volumePercent: Int)` - 音量を設定します。引数は0から100の範囲を想定しています。
* `NextVideo` - 次の動画に移動します
* `PreviousVideo` - 前の動画に移動します
* `SetLoop(val loop: Boolean)` - 動画のリピートを設定します。引数で管理します。
* `SetShuffle(val shuffle: Boolean)` - 動画のシャッフルを設定します。引数で管理します。

### <a name="YouTubeEvent">YouTubeEvent</a>

* `Ready` - YouTubeプレイヤーの初期化完了時に呼ばれます
* `PlaybackQualityChange(val quality: Quality)` - プレイヤーの画質が変更された時に呼ばれます
* `Error(val error: String)` - エラー処理イベント。詳細は引数を参照してください。
* `VideoDuration(val duration: Duration)` - 動画の長さが初期化された時に呼ばれます
* `StateChanged(val state: State)` - 動画の状態が変化した時に呼ばれます：`UNSTARTED`,`ENDED`, `PLAYING`, `PAUSED`, `BUFFERING`, `CUED`。
* `TimeChanged(val time: Duration)` - タイムスタンプが変更されました
* `OnVideoIdHandled(val videoId: YouTubeVideoId)` - 動画の読み込みが完了した時のコールバック

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