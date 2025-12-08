# React Native 페이드 그라데이션 래퍼

<p align="center">
  <img src="https://raw.githubusercontent.com/pioner92/rn-fade-wrapper/main/./assets/img.png" width="700" alt="React Native 페이드 그라데이션 래퍼 데모" />
</p>

**`rn-fade-wrapper`** 는 모든 콘텐츠의 가장자리에 부드럽고 사용자 정의 가능한 **페이드 그라데이션**을 추가하는 간단하면서도 고성능의 React Native 컴포넌트입니다. 스크롤 가능한 컨테이너, 리스트, 캐러셀, 모달 또는 넘치는 콘텐츠가 있는 모든 뷰에서 사용자 경험을 향상시키기에 완벽합니다.

<div align="center" style="max-width: 400px; margin: auto;">
  <a href="https://www.npmjs.com/package/rn-fade-wrapper">
    <img src="https://img.shields.io/npm/v/rn-fade-wrapper.svg" alt="npm 버전" />
  </a>
  <img src="https://img.shields.io/badge/platform-iOS-blue?logo=apple" alt="iOS" />
  <img src="https://img.shields.io/badge/platform-Android-green?logo=android" alt="Android" />
  <img src="https://img.shields.io/badge/types-TypeScript-blue?logo=typescript" alt="TypeScript" />
  <img src="https://img.shields.io/badge/license-MIT-yellow.svg" alt="MIT 라이선스" />
  <a href="https://bundlephobia.com/result?p=rn-fade-wrapper">
    <img src="https://img.shields.io/bundlephobia/minzip/rn-fade-wrapper" alt="번들 크기" />
  </a>
</div>

---

## ✨ 기능

- ⚡ **iOS** 및 **Android** 네이티브 렌더링 지원
- 🔁 **수직** 및 **수평** 그라데이션 방향 지원
- 🎨 완전한 **페이드 크기 및 색상 커스터마이징** (각 면별 또는 균일하게)
- ↕️ 바깥쪽이 아닌 콘텐츠 쪽으로 페이드하는 선택적 `inward` 모드
- 🧩 직관적인 props로 간단한 API: 바로 사용 가능한 래퍼
- 💪 낮은 오버헤드로 뛰어난 성능 — 스크롤 뷰 및 애니메이션에 이상적

---

## 📦 설치

```bash
yarn add rn-fade-wrapper
```

or

```bash
npm install rn-fade-wrapper
```
### Expo

이 라이브러리는 추가 구성 없이 Expo(`expo prebuild` 사용)에서 작동합니다.

---

## 📱 플랫폼 지원

| 플랫폼   | 구 아키텍처 | 패브릭 |
|----------|------------|--------|
| iOS      | ✅          | ✅      |
| Android  | ✅          | ✅      |

---

## 🚀 빠른 시작


```tsx
import { FadeWrapper } from 'rn-fade-wrapper';

const MyComponent = () => {
  return (
    <FadeWrapper
      color="#ffffff"
      size={24}
      orientation="vertical"
    >
      <ScrollView>
        <Text>Fading edges example</Text>
      </ScrollView>
    </FadeWrapper>
  );
};
```

---

## 🧩 Props

| Prop         | Type                       | Default                     | Description |
|--------------|----------------------------|----------------------|-------------|
| `color`      | `string`                   | `"#ffffff"`          | 페이드 색상 (유효한 색상 문자열 가능) |
| `size`       | `number`                   | `20`                 | 포인트 단위의 균일한 페이드 크기 |
| `style`      | `ViewStyle`                | `{ zIndex: 2 }`      | 래퍼 뷰에 적용되는 커스텀 스타일 |
| `inward`     | `boolean`                  | `false`              | 그라데이션을 바깥쪽이 아닌 안쪽(중앙 방향)으로 페이드 처리 |
| `sizes`      | `{ top?: number, right?: number, bottom?: number, left?: number }` | `undefined` | 각 가장자리별 특정 페이드 크기 (`size`와 `orientation`을 덮어씀) |
| `orientation`| `'horizontal' \| 'vertical'` | `'vertical'`       | 방향 프리셋: `size`를 상/하 또는 좌/우에 적용 |
| `children`   | `React.ReactNode`          | —                    | 래핑된 콘텐츠 |

> **참고:** `sizes`가 `size`와 `orientation`보다 우선 적용됩니다.

---

## 🎛 Examples

### 🎯 Custom sides + inward fade:
```tsx
<FadeWrapper
  color="black"
  inward
  sizes={{ top: 20, bottom: 30 }}
>
  <FlatList ... />
</FadeWrapper>
```

### 📜 수평 스크롤 페이드:
```tsx
<FadeWrapper
  color="rgba(0,0,0,0.5)"
  size={16}
  orientation="horizontal"
>
  <ScrollView horizontal>
    {/* content */}
  </ScrollView>
</FadeWrapper>
```

---

## 🛠 내부 구조

- **iOS:** 네이티브 `UIView` 내부에 `CAGradientLayer` 사용  
- **Android:** Canvas를 사용하여 커스텀 `ViewGroup`에 `LinearGradient` 그리기  
- 플랫폼별 로직으로 레이아웃 처리 및 재렌더링하여 일관성 유지

---

## 💡 UX 팁

`rn-fade-wrapper`를 사용해 콘텐츠 오버플로우를 은은하게 표시하세요 — 특히 캐러셀, 스크롤 뷰, 수평 슬라이더에서 유용합니다. 그라디언트는 사용자가 더 스크롤할 수 있음을 암시하여 참여도를 높입니다.

---

## 📘 라이선스

MIT — 자유롭게 사용, 개선 및 기여 가능 🎉



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-08

---