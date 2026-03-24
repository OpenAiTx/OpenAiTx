## Sublime Self Patcher

이것은 Sublime Text 4 플러그인으로 Sublime Text와 Sublime Merge를 패치할 수 있습니다.

🔥 제3자 의존성이 필요 없습니다. 필요한 것은 Sublime Text뿐입니다.

## 지원 환경

| 기호 | 의미                                                                   |
| ---- | --------------------------------------------------------------------- |
| ✅   | 지원됨.                                                              |
| ⚠️   | 불안정한 패치 패턴입니다. 이 플러그인을 자주 업데이트해야 할 수 있습니다. |
| ☠️   | 죄송하지만 사용하지 않습니다.                                        |

|                   | Linux x64 | Windows x32 | Windows x64 | 기타    |
| ----------------- | --------- | ----------- | ----------- | ------ |
| **Sublime Text**  | ✅        | ✅          | ✅          | ☠️     |
| **Sublime Merge** | ✅⚠️      |             | ✅          | ☠️     |

Windows 7을 사용 중이라면 [Service Pack 2](https://answers.microsoft.com/en-us/windows/forum/all/how-to-obtain-and-install-windows-7-sp2/c2c7009f-3a10-4199-9c89-48e1e883051e)가 필요합니다.

## 다운로드

https://github.com/n6333373/sublime-self-patcher/archive/refs/heads/main.zip

## 설치

먼저 `Packages` 디렉터리를 찾아야 합니다.

- 포터블 버전의 Sublime Text를 사용하는 경우, `Data/Packages`입니다.
- 설치된 버전의 Sublime Text를 사용하는 경우,
  - Windows에서는 `%appdata%\Sublime Text\Packages`입니다.
  - Linux에서는 `$HOME/.config/sublime_text/Packages`입니다.

이제 (필요하면 압축을 풀고) 다운로드한 디렉터리를 `Packages` 디렉터리에 넣어
디렉터리 구조가 다음과 같이 보이도록 하십시오:

```text
Packages/
└── SelfPatcher/
    ├── boot.py
    ├── ...
```
그리고 실행 중이라면 Sublime Text를 재시작하세요.

## 사용법

### 자체 패치 (현재 Sublime Text)

- 등록되지 않은 개발자 빌드를 사용하는 경우, 이 플러그인은 시작 시 패치 팝업을 표시합니다.
- 안정화 빌드를 사용하는 경우, 메뉴에서 패치할 수 있습니다: `도움말 ⇒ 이 응용 프로그램 패치`

### 외부 Sublime Text/Merge 패치

응용 프로그램이 관리자/루트 권한이 필요한 위치에 설치된 경우,
이 플러그인을 사용하여 임시 디렉터리에 패치된 실행 파일을 생성할 수 있습니다.

메뉴에서 클릭하세요: `도움말 ⇒ 외부 Sublime Text/Merge 패치` 그리고 Sublime Text/Merge 실행 파일을 선택합니다.

## 질문과 답변

### Sublime Text/Merge 자동 업데이트를 비활성화하려면?

이 플러그인은 일반적으로 향후 Sublime Text/Merge 버전에서도 계속 작동합니다.
하지만 응용 프로그램 자동 업데이트를 비활성화하려면 다음 설정을 할 수 있습니다:


```jsonc
{
    "update_check": false, // this works only if you have registered
}
```

### 이 플러그인은 의심스럽습니다

제가 악의적인 행동을 하지 않는다고 생각하지만, 저를 신뢰할 필요는 없습니다. 당신은

- 가상 머신에서 패치를 적용하고 패치된 실행 파일을 꺼낼 수 있습니다.
- 직접 할 수도 있습니다. https://gist.github.com/maboloshi/feaa63c35f4c2baab24c9aaf9b3f4e47 를 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---