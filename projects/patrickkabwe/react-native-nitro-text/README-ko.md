<div align="center">
  <h1>react-native-nitro-text</h1>
</div>

<p align="center">
  iOS 및 Android 모두에서 훨씬 풍부하고 성능이 뛰어난 텍스트 컴포넌트입니다.
</p>


<div align="center">
  
https://github.com/user-attachments/assets/57f56b3f-3988-4235-af83-a5f2cfd82121

</div>

<div align="center">

[![npm version](https://img.shields.io/npm/v/react-native-nitro-text?style=for-the-badge)](https://www.npmjs.org/package/react-native-nitro-text)
[![Discord](https://img.shields.io/badge/Discord-Join%20Server-5865F2?style=for-the-badge&logo=discord&logoColor=white)](https://discord.gg/7KXUyHjz)
[![npm downloads](https://img.shields.io/npm/dt/react-native-nitro-text.svg?style=for-the-badge)](https://www.npmjs.org/package/react-native-nitro-text)
[![npm downloads](https://img.shields.io/npm/dm/react-native-nitro-text.svg?style=for-the-badge)](https://www.npmjs.org/package/react-native-nitro-text)
[![mit licence](https://img.shields.io/dub/l/vibe-d.svg?style=for-the-badge)](https://github.com/patrickkabwe/react-native-nitro-text/blob/main/LICENSE)

</div>

---

## 기능

- iOS와 Android 모두에서 작동(현재 Android에서는 RN `Text`로 대체)
- 부드러운 선택이 가능한 네이티브 iOS 렌더링.
- 중첩된 조각들이 단일 네이티브 텍스트 뷰로 병합됨
- 마크다운 및 HTML 렌더링(곧 지원 예정).
- 새로운 아키텍처만 지원

## 요구사항

- React Native v0.78.0 이상 (Fabric/Nitro Views)
- Node 18+ (Node 20+ 권장)

## 설치

```bash
yarn add react-native-nitro-text react-native-nitro-modules
```

iOS

```bash
cd ios && pod install && cd ..
```

이게 전부입니다. 이제 앱에서 `NitroText` 컴포넌트를 사용할 수 있습니다.

## 사용법

```tsx
import { NitroText as Text } from 'react-native-nitro-text'

export function Title() {
  return (
    <Text style={{ fontSize: 24, fontWeight: 'bold' }}>
      🚀 NitroText Showcase
    </Text>
  )
}
```

## 선택

iOS는 네이티브 선택을 사용합니다. Android에서 NitroText는 현재 React Native `Text`로 대체됩니다.

```tsx
import { NitroText as Text } from 'react-native-nitro-text'

export function SelectionExample() {
  return (
    <Text selectable style={{ fontSize: 16, lineHeight: 22 }}>
      Long-press to select this text. NitroText supports smooth selection,
      even with <Text style={{ fontWeight: '600' }}>inline styles</Text> and
      longer paragraphs.
    </Text>
  )
}
```

## HTML 렌더링

NitroText는 `renderer="html"`을 전달할 때 HTML 문자열 자식과 인라인 CSS를 구문 분석할 수 있습니다.

```tsx
import { NitroText } from 'react-native-nitro-text'

export function HtmlExample() {
  const html = `
    <div>
      <h2>Renderer demo</h2>
      <p>This text comes from <strong>HTML</strong> with <em>semantic</em> tags.</p>
      <p><span style="color: #ff6347; font-weight: bold;">Inline CSS works too.</span></p>
    </div>
  `

  return <NitroText renderer="html">{html}</NitroText>
}
```

## 사용자 정의 선택 메뉴

NitroText는 텍스트가 선택될 때 나타나는 사용자 정의 메뉴 항목을 지원합니다. `title`과 `action` 콜백을 포함하는 메뉴 항목 배열과 함께 `menus` 속성을 전달하세요.

```tsx
import { NitroText } from 'react-native-nitro-text'
import { useMemo } from 'react'

export function MenuExample() {
  const menus = useMemo(
    () => [
      { 
        title: 'Copy', 
        action: () => console.log('Copy action') 
      },
      { 
        title: 'Share', 
        action: () => console.log('Share action') 
      },
      { 
        title: 'Translate', 
        action: () => console.log('Translate action') 
      },
    ],
    []
  )

  return (
    <NitroText selectable menus={menus} style={{ fontSize: 16 }}>
      Select this text to see custom menu options appear in the selection menu.
    </NitroText>
  )
}
```

## 플랫폼 지원

- iOS
- Android - 현재 `NitroText`는 RN `Text`로 대체됩니다.

## 왜 NitroText인가?

최소한의 JS 오버헤드와 네이티브 iOS 선택 기능을 갖춘 맞춤 네이티브 텍스트 뷰입니다. 스타일이 복잡하거나 중첩된 텍스트 및 대용량 목록에 적합합니다. RN `Text` 컴포넌트의 드롭인 교체품입니다.

## 개발

- `bun run build` — 타입 검사 및 패키지 빌드
- `bun run codegen` — 코드 생성 출력 재생성
- `example/`에 예제 앱 있음

## 크레딧

[create-nitro-module](https://github.com/patrickkabwe/create-nitro-module)로 부트스트랩됨.

## 기여

PR 환영합니다! 주요 변경 사항은 먼저 이슈를 열어주세요.

> 💬 빠른 지원을 위해 [Discord 채널](https://discord.gg/7KXUyHjz)에 참여하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-13

---