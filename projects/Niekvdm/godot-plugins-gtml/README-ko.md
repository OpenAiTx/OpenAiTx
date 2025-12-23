# GTML - Godot 마크업 언어

Godot 4.x용 애드온으로 HTML과 CSS를 사용해 UI를 구축할 수 있습니다. 친숙한 웹 기술로 게임 메뉴, HUD, 패널을 만드세요.

## 기능

- 20개 이상의 요소 유형을 가진 HTML 기반 UI 구조
- 80개 이상의 속성을 지원하는 외부 CSS 스타일링
- 에디터 내 라이브 리로드
- 플렉스박스 레이아웃 시스템
- SVG 렌더링 지원
- 시그널이 있는 폼 요소
- CSS 전환 및 의사 클래스 (:hover, :active, :focus)
- 그라데이션 배경 및 사용자 정의 폰트

## 빠른 시작

### 1. 설치

`addons/gtml/`을 프로젝트에 복사하고 **프로젝트 설정 → 플러그인**에서 활성화하세요.

### 2. 파일 생성

**menu.html:**
```html
<div class="menu">
    <h1>My Game</h1>
    <button @click="on_play">Play</button>
    <button @click="on_quit">Quit</button>
</div>
```

**menu.css:**
```css
.menu {
    display: flex;
    flex-direction: column;
    align-items: center;
    gap: 16px;
    padding: 32px;
    background-color: #1a1a2e;
}

h1 {
    font-size: 32px;
    color: #ffffff;
}

button {
    padding: 12px 24px;
    background-color: #00d4ff;
    border-radius: 4px;
    color: #000000;
    transition: background-color 200ms ease;
}

button:hover {
    background-color: #00a8cc;
}
```
### 3. GmlView 노드 추가

`GmlView` 노드를 추가하고 인스펙터에서 **Html Path**와 **Css Path**를 설정합니다.

### 4. 신호 연결하기


```gdscript
func _ready():
    $GmlView.button_clicked.connect(_on_button_clicked)

func _on_button_clicked(method_name: String):
    match method_name:
        "on_play":
            get_tree().change_scene_to_file("res://game.tscn")
        "on_quit":
            get_tree().quit()
```
## 문서

- [시작하기](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/getting-started.md) - 설치 및 기본 사용법
- [HTML 요소](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/html-elements.md) - 지원 태그 및 속성
- [CSS 속성](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-properties.md) - 전체 속성 참조
- [CSS 선택자](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-selectors.md) - 선택자 및 의사 클래스
- [폼 및 입력](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/forms-and-inputs.md) - 폼 요소 및 이벤트
- [SVG 지원](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/svg-support.md) - 벡터 그래픽
- [레이아웃 및 플렉스박스](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/layout-and-flexbox.md) - 레이아웃 시스템
- [전환 효과](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/transitions.md) - CSS 전환 효과
- [폰트 및 타이포그래피](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/fonts-and-typography.md) - 사용자 지정 폰트
- [GTML 확장](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/extending-gtml.md) - 새로운 기능 추가
- [제한 사항](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/limitations.md) - 알려진 제한 사항

## 예제

작동하는 데모는 `addons/gtml/examples/` 폴더를 확인하세요:
- `basic` - 간단한 메뉴
- `all_elements` - 모든 HTML 요소
- `css_features` - CSS 속성 쇼케이스
- `flex_layout` - 플렉스박스 레이아웃
- `transitions` - CSS 전환 효과

## 라이선스

MIT 라이선스



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---