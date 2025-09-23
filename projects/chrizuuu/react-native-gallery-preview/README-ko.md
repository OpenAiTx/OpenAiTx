  
 # react-native-gallery-preview
  
  <div>
    <img align="right" height="720" src="https://raw.githubusercontent.com/chrizuuu/react-native-gallery-preview/main/example.gif">
  </div>

  **GalleryPreview**는 전체 제스처 지원을 갖춘 손쉬운 갤러리 미리보기를 위한 유연한 모달 컴포넌트입니다. `Reanimated`와 `React Native Gesture Handler`를 사용하여 iOS와 Android 모두에서 부드럽고 간단한 사용자 경험을 제공합니다.
  
  ### 특징
  
  * ⚡  **부드러운 제스처 상호작용 및 애니메이션:** 쾌적한 사용자 인터페이스를 위한 유동적이고 반응성 높은 애니메이션과 제스처를 경험하세요.
  * 🔍 **더블 탭 및 핀치 줌:** 사용자는 간단한 더블 탭과 핀치 제스처로 이미지를 쉽게 확대 및 축소할 수 있습니다.
  * 👆 **당겨서 닫기:** 갤러리 미리보기를 닫기 위한 직관적인 당기기 제스처로 원활한 내비게이션을 제공합니다.
  *  ↔️ **RTL 지원**
  * 📱 **`iOS` 및 `Android` 모두 지원:** iOS와 Android 기기 모두와 완벽히 호환되어 플랫폼 전반에 걸쳐 일관된 경험을 보장합니다.
  * 📱 **`Expo` 호환**
  ### 시작하기
  GalleryPreview를 사용하기 전에 react-native-reanimated와 react-native-gesture-handler를 설정해야 합니다. 자세한 설치 가이드는 아래 링크를 참조하세요:
  
  * [Reanimated 설정하기](https://docs.swmansion.com/react-native-reanimated/docs/fundamentals/getting-started/#installation)
  * [React Native Gesture Handler 설정하기](ht↔️tps://docs.swmansion.com/react-native-gesture-handler/docs/fundamentals/installation)

  의존성이 설치되면, 프로젝트에 react-native-gallery-preview를 추가할 수 있습니다:
  



  ```sh
  npm install react-native-gallery-preview
  # or
  yarn add react-native-gallery-preview
  
  ```
### 예제


```tsx
import React, { useState } from 'react';
import { Button, View } from 'react-native';
import GalleryPreview from 'react-native-gallery-preview';

export const App = () => {
  const [isVisible, setIsVisible] = useState(false);

  const images = [
    { uri: 'https://example.com/image1.jpg' },
    { uri: 'https://example.com/image2.jpg' },
    // Add more images here
  ];

  return (
    <View>
      <Button title="Open Gallery Preview" onPress={() => setIsVisible(true)} />
      <GalleryPreview
        isVisible={isVisible}
        onRequestClose={() => setIsVisible(false)}
        images={images}
      />
    </View>
  );
};
```
### Props

| Prop Name                  | Type                                      | Description                                                                                                                      | Default                                                                                                            |
|----------------------------|-------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------|
| `isVisible`                | `boolean`                                 | 이미지 뷰어 모달의 가시성을 제어합니다.                                                                                          | -                                                                                                                  |
| `onRequestClose`           | `() => void`                              | 이미지 뷰어 모달을 닫는 함수입니다.                                                                                              | -                                                                                                                  |
| `images`                   | `ImageItemURI[]`                          | 표시할 이미지 URI 배열입니다.                                                                                                     | -                                                                                                                  |
| `initialIndex?`             | `number`                                  | 뷰어가 열릴 때 표시할 초기 이미지 인덱스입니다.                                                                                 | `0`                                                                                                                |
| `gap?`                      | `number`                                  | 뷰어 내 이미지 간의 간격입니다.                                                                                                 | `24`                                                                                                               |
| `simultaneousRenderedImages?` | `number`                                  | 최적화를 위해 동시에 렌더링되는 이미지 수입니다.                                                                                | `6`                                                                                                                |                                                                                                           |
| `OverlayComponent?`          | `(props: GalleryOverlayProps) => React.ReactNode` | 이미지 뷰어 위에 렌더링할 선택적 컴포넌트입니다.                                                                  | -                                                                                                                  |
| `ImageComponent?`           | `(props: GalleryImageComponentProps) => React.JSX.Element` | 각 이미지를 렌더링할 선택적 맞춤 컴포넌트입니다.                                                                                   | -                                                                                                                  |
| `springConfig?`             | `SpringConfig`                            | 애니메이션을 위한 스프링 구성입니다.                                                                                            | `{ damping: 1000, mass: 1, stiffness: 250, restDisplacementThreshold: 0.02, restSpeedThreshold: 4 }`                |
| `doubleTabEnabled?`           | `boolean`                                        | 더블 탭 줌 기능을 활성화하거나 비활성화합니다.                                                                                  | `true`                                                                                                             |
| `pinchEnabled?`               | `boolean`                                        | 핀치 줌 기능을 활성화하거나 비활성화합니다.                                                                                     | `true`                                                                                                             |
| `swipeToCloseEnabled?`        | `boolean`                                        | 스와이프하여 닫기 기능을 활성화하거나 비활성화합니다.                                                                           | `true`                                                                                                             |
| `backgroundColor?`        | `string`                                        | 모달, DefaultHeader 및 StatusBar의 배경색입니다.                                                                                 | `#000`                                                                                                            |
| `headerTextColor?`        | `string`                                        | 헤더 내 텍스트 색상입니다.                                                                                                       | `#fff`                                                                                                            |




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-23

---