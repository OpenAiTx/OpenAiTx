**이 GitHub 저장소(<https://github.com/Genymobile/scrcpy>)만이 이 프로젝트의 공식 소스입니다.  
`scrcpy`라는 이름이 포함되어 있더라도 임의의 웹사이트에서 릴리스를 다운로드하지 마십시오.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_발음은 "**scr**een **c**o**py**"_

이 애플리케이션은 USB 또는 [TCP/IP](doc/connection.md#tcpip-wireless)를 통해 연결된 안드로이드 기기(비디오 및 오디오)를 미러링하고, 컴퓨터의 키보드와 마우스를 사용하여 제어할 수 있도록 합니다.  
기기에서 _root_ 권한이나 별도의 앱 설치가 필요하지 않습니다.  
_Linux_, _Windows_, _macOS_에서 동작합니다.

![스크린샷](assets/screenshot-debian-600.jpg)

주요 특징:

 - **경량성**: 네이티브, 기기 화면만 표시
 - **성능**: 30~120fps, 기기에 따라 다름
 - **품질**: 1920×1080 이상
 - **저지연**: [35~70ms][lowlatency]
 - **빠른 시작**: 첫 화면 표시까지 약 1초
 - **비침투성**: 안드로이드 기기에 아무것도 설치되지 않음
 - **사용자 혜택**: 계정, 광고, 인터넷 불필요
 - **자유**: 무료 및 오픈 소스 소프트웨어

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

주요 기능:
 - [오디오 포워딩](doc/audio.md) (Android 11+)
 - [녹화](doc/recording.md)
 - [가상 디스플레이](doc/virtual_display.md)
 - [안드로이드 기기 화면 끄기](doc/device.md#turn-screen-off) 상태에서 미러링
 - [양방향 복사/붙여넣기](doc/control.md#copy-paste)
 - [화질 설정 가능](doc/video.md)
 - [카메라 미러링](doc/camera.md) (Android 12+)
 - [웹캠(V4L2) 미러링](doc/v4l2.md) (Linux 한정)
 - 물리적 [키보드][hid-keyboard], [마우스][hid-mouse] 시뮬레이션(HID)
 - [게임패드](doc/gamepad.md) 지원
 - [OTG 모드](doc/otg.md)
 - 그 외 다수…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation  
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## 사전 준비

안드로이드 기기는 최소 API 21(Android 5.0)이 필요합니다.

[오디오 포워딩](doc/audio.md)은 API >= 30(Android 11+)에서 지원됩니다.

기기에서 [USB 디버깅][enable-adb]을 활성화했는지 확인하세요.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

일부 기기(특히 샤오미)에서는 다음과 같은 오류가 발생할 수 있습니다:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

이 경우, 키보드와 마우스를 사용하여 제어하려면 [추가 옵션][control]인  
`USB 디버깅(보안 설정)`을 활성화해야 합니다(`USB 디버깅`과는 별도의 항목).  
이 옵션을 설정한 후에는 기기를 재부팅해야 합니다.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

[OTG 모드](doc/otg.md)에서는 USB 디버깅이 필요하지 않습니다.

## 앱 받기

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) ([실행 방법](doc/windows.md#run) 참고)
 - [macOS](doc/macos.md)

## 꼭 알아야 할 팁

 - [해상도 감소](doc/video.md#size)는 성능을 크게 향상시킬 수 있습니다 (`scrcpy -m1024`)
 - [_우클릭_](doc/mouse.md#mouse-bindings)은 `BACK` 동작
 - [_가운데 클릭_](doc/mouse.md#mouse-bindings)은 `HOME` 동작
 - <kbd>Alt</kbd>+<kbd>f</kbd>로 [전체화면 전환](doc/window.md#fullscreen)
 - 그 외 다양한 [단축키](doc/shortcuts.md) 제공

## 사용 예시

많은 옵션이 있으며, [별도의 페이지](#user-documentation)에 문서화되어 있습니다.  
여기 대표적인 예시를 소개합니다.

 - H.265(더 나은 화질)로 화면 캡처, 크기 1920 제한, 프레임레이트 60fps 제한, 오디오 비활성화, 물리 키보드 시뮬레이션으로 제어:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # 단축 버전
    ```

 - 새로운 가상 디스플레이에서 VLC 실행(기기 디스플레이와 분리):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - 기기 카메라를 H.265, 1920x1080(마이크 포함)으로 MP4 파일에 녹화:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - 기기 전면 카메라를 캡처하여 컴퓨터의 웹캠으로 노출(Linux):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - 미러링 없이 물리적 키보드와 마우스 시뮬레이션으로 기기 제어(USB 디버깅 불필요):

    ```bash
    scrcpy --otg
    ```

 - 컴퓨터에 연결된 게임패드 컨트롤러로 기기 제어:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # 단축 버전
    ```

## 사용자 문서

애플리케이션은 다양한 기능과 설정 옵션을 제공합니다.  
아래 페이지에서 문서화되어 있습니다:

 - [연결](doc/connection.md)
 - [비디오](doc/video.md)
 - [오디오](doc/audio.md)
 - [제어](doc/control.md)
 - [키보드](doc/keyboard.md)
 - [마우스](doc/mouse.md)
 - [게임패드](doc/gamepad.md)
 - [기기](doc/device.md)
 - [창](doc/window.md)
 - [녹화](doc/recording.md)
 - [가상 디스플레이](doc/virtual_display.md)
 - [터널](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [카메라](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [단축키](doc/shortcuts.md)

## 참고 자료

 - [FAQ](FAQ.md)
 - [번역][wiki] (항상 최신은 아닙니다)
 - [빌드 안내](doc/build.md)
 - [개발자](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki

## 기사

- [scrcpy 소개][article-intro]
- [scrcpy, 이제 무선 지원][article-tcpip]
- [오디오 지원 scrcpy 2.0][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## 연락처

버그 신고, 기능 요청, 일반 문의는 [이슈][issue]를 열어주세요.

버그 신고 전, [FAQ](FAQ.md)를 먼저 읽어보시면 바로 해결책을 찾을 수도 있습니다.

[issue]: https://github.com/Genymobile/scrcpy/issues

그 외에도 다음을 이용할 수 있습니다:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)

## 후원

저는 _scrcpy_의 저자이자 유지관리자인 [@rom1v](https://github.com/rom1v)입니다.

이 애플리케이션이 도움이 되었다면, [오픈 소스  
작업을 후원][donate]하실 수 있습니다:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## 라이선스

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---