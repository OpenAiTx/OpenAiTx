# Discord GNOME 테마

Adwaita 스타일 및 GNOME 휴먼 인터페이스 가이드라인을 따르는 Discord용 GNOME 테마입니다 (Discord CSS에서 허용하는 범위 내에서).

## 요구 사항

1. Vesktop

   Windows 타이틀바를 활성화하기 위해 필요합니다.

2. 설정 > 언어 > "English (US)" 선택

   Discord에서 아이콘이 식별되는 방식 때문에 커스텀 아이콘을 사용할 수 있습니다. 테마를 [로컬라이즈](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss)할 수 있지만, 로컬라이제이션 노트를 참고하세요.

3. 설정 > 플러그인 > "ThemeAttributes" 활성화

   설정 대화상자에서 아이콘을 사용할 수 있게 해줍니다.

4. 설정 > Vesktop 설정 > "Discord Titlebar" 활성화

   선택 사항이지만, 타이틀바가 있을 경우 권장합니다.

### 선택적 추가 사항

1. Nitro 관련 요소 제거: https://github.com/CroissantDuNord/discord-adblock

## 테마 철학

### 휴먼 인터페이스 가이드라인

테마는 Discord의 CSS 또는 디자인 제한, 혹은 개인적인 선택으로 인해 HIG를 완전히 준수하지 않을 수 있습니다.

### 지원

다음은 지원되지 않습니다:

- Discord 실험 기능

  저는 Discord 직원이 아니므로, 해당 실험 기능이 변경, 폐기되는지 알 수 없습니다. 즉, 유지관리 부담이 있습니다 — 저는 여러 프로젝트를 관리하고 있습니다.

- Nitro

  예외 — FakeNitro 플러그인으로 접근 가능한 모든 것.

이 항목들에 대해 이슈를 제기할 수는 있지만, 쉬운 수정(예: 누락된 아이콘)인 경우에만 수정됩니다.

## 설치 방법

### 별도의 설정 없이 설치

Settings > Themes > Online Themes에 있는 텍스트 박스에 다음을 복사해 넣으세요:

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### 설정 포함 설치

[gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) 파일을 ~/.config/vesktop/themes에 넣으세요. 자동으로 업데이트됩니다.

## 미리보기

![first](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy second](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![third](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---