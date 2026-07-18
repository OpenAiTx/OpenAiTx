# bevy_dev_console

`bevy_dev_console`는 [Bevy 게임 엔진](https://github.com/bevyengine/bevy)을 위한 Source 영감을 받은 개발자 콘솔 플러그인입니다.

![개발자 콘솔 이미지](https://raw.githubusercontent.com/doonv/bevy_dev_console/master/doc/console.png)

> [!경고]  
>
> `bevy_dev_console`는 현재 초기 개발 단계에 있습니다. 가까운 미래에 파괴적인 변경 사항이 있을 수 있으니 주의하세요 (특히 내장된 명령어 파서를 사용할 때). 이 이유로 현재는 git 패키지로만 제공됩니다.

## 기능

- 로그 보기
  - 로그 메시지 위에 마우스를 올리면 모든 숨겨진 데이터를 확인할 수 있습니다.
- `bevy_dev_console` 전용으로 만들어진 강력한 내장 파서 언어 ([문서](https://github.com/doonv/bevy_dev_console/wiki/Built%E2%80%90in-Parser))
  - 계산
  - 변수
    - 소유권과 빌림의 단순화된 버전을 사용
  - 표준 라이브러리 (현재는 많지 않음)
  - [사용자 정의 네이티브 함수](https://github.com/doonv/bevy_dev_console/blob/master/examples/custom_functions.rs) (`World` 접근 포함!)
  - [다양한 타입](https://github.com/doonv/bevy_dev_console/wiki/Built%E2%80%90in-Parser#types)
  - 리소스 보기 및 수정
    - 열거형
    - 구조체
  - ~~엔티티 쿼리~~ [*곧 출시 예정...*](https://github.com/doonv/bevy_dev_console/issues/3) (문법 제안 환영!)
  - ...그리고 더 많은 기능!

## 사용법

1. `bevy_dev_console` git 패키지를 추가하세요.

    ```bash
    cargo add --git https://github.com/doonv/bevy_dev_console.git
    ```
2. `prelude`를 가져옵니다.


    ```rust
    use bevy_dev_console::prelude::*;
    ```
3. 플러그인을 추가합니다.


    ```rust,no_run
    use bevy::{prelude::*, log::LogPlugin};
    use bevy_dev_console::prelude::*;

    App::new()
        .add_plugins((
            // Add the log plugin with the custom log layer
            DefaultPlugins.set(LogPlugin {
                custom_layer: custom_log_layer,
                ..default()
            }),
            // Add the dev console plugin itself.
            DevConsolePlugin,
        ))
        .run();
    ```
4. 이제 완료되었습니다! 키보드에서 `` ` `` / `~` 키를 누르면 콘솔이 열릴 것입니다!

## 토글 가능한 기능들

**(기본값)** `builtin-parser`는 기본 파서를 포함합니다. 이를 비활성화하면 내장 파서를 제거하고 자신만의 파서로 교체할 수 있습니다(또는 아무 것도 하지 않고 콘솔을 로그 리더로 만들 수도 있습니다).

## Bevy 호환성

| bevy   | bevy_dev_console |
| ------ | ---------------- |
| 0.14.* | git (master)     |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-18

---