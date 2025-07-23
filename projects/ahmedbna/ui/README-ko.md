
# BNA UI 🚀

![BNA UI Header](https://cdn.jsdelivr.net/gh/ahmedbna/bna-ui-demo/bna-ui-header.png)

**B**uild **N**ative **A**pps - 아름다운 UI 컴포넌트 라이브러리와 함께 Expo React Native 애플리케이션을 생성하는 강력한 CLI입니다.

## ✨ 기능

- 🎨 **아름다운 UI 컴포넌트** - 현대적인 디자인의 사전 제작 및 사용자 정의 가능한 컴포넌트
- 🌙 **테마 지원** - 원활한 전환이 가능한 내장 라이트/다크 모드
- 📱 **Expo Router 준비 완료** - 탭 및 스택 내비게이션을 포함한 완전한 내비게이션 설정
- 🎯 **TypeScript 우선** - 뛰어난 IntelliSense를 지원하는 완전한 TypeScript 지원
- 📦 **유연한 패키지 관리자** - npm, yarn, 또는 pnpm과 호환
- 🚀 **무설정** - 합리적인 기본값으로 몇 초 만에 시작 가능
- 🔧 **높은 사용자 정의 가능성** - 색상, 간격 및 컴포넌트를 쉽게 사용자 정의
- 📲 **크로스 플랫폼** - iOS와 Android 모두에서 완벽한 호환성
- ⚡ **성능 최적화** - 가볍고 빠른 컴포넌트
- 🎭 **애니메이션 준비 완료** - React Native Reanimated를 이용한 부드러운 애니메이션

## 📦 설치

```bash
# The fastest way to set up BNA UI in your Expo project:
npx bna-ui init

# Navigate to your Expo project
cd bna-app

# Start adding components
npx bna-ui add button
npx bna-ui add card
npx bna-ui add input
```
## 🎯 사용 예제


```tsx
import React from 'react';
import { Button } from '@/components/ui/button';
import { Card } from '@/components/ui/card';
import { Input } from '@/components/ui/input';
import { View } from '@/components/ui/view';

export default function HomeScreen() {
  return (
    <View style={{ flex: 1, padding: 20 }}>
      <Card>
        <Input placeholder='Enter your email' keyboardType='email-address' />
        <Button
          variant='success'
          onPress={() => console.log('Button pressed!')}
        >
          Get Started
        </Button>
      </Card>
    </View>
  );
}
```
## 🌙 테마 구성

BNA UI는 유연한 테마 시스템을 제공합니다:


```tsx
// theme/colors.ts
export const lightTheme = {
  colors: {
    background: '#FFFFFF',
    foreground: '#000000',
    card: '#F2F2F7',
    cardForeground: '#000000',
    popover: '#F2F2F7',
    popoverForeground: '#000000',
    primary: '#18181b',
    primaryForeground: '#FFFFFF',
    secondary: '#F2F2F7',
    secondaryForeground: '#18181b',
    muted: '#78788033',
    mutedForeground: '#71717a',
    // ... more colors
  },
};

export const darkTheme = {
  colors: {
    background: '#000000',
    foreground: '#FFFFFF',
    card: '#1C1C1E',
    cardForeground: '#FFFFFF',
    popover: '#18181b',
    popoverForeground: '#FFFFFF',
    primary: '#e4e4e7',
    primaryForeground: '#18181b',
    secondary: '#1C1C1E',
    secondaryForeground: '#FFFFFF',
    muted: '#78788033',
    mutedForeground: '#a1a1aa',
    // ... more colors
  },
};
```
## 📱 플랫폼 지원

- ✅ **iOS** - 완전한 네이티브 iOS 지원
- ✅ **Android** - 완전한 네이티브 Android 지원
- ✅ **Web** - 반응형 웹 지원
- ✅ **Expo Go** - Expo Go를 이용한 개발
- ✅ **EAS Build** - EAS를 이용한 프로덕션 빌드

## 🛠️ 개발


```bash
# Clone the repository
git clone https://github.com/ahmedbna/bna-ui.git
cd bna-ui

# Install dependencies
npm install

# Build for production
npm run build
```
## 🤝 기여하기

기여를 환영합니다! 자세한 내용은 [기여 가이드](https://raw.githubusercontent.com/ahmedbna/ui/main/CONTRIBUTING.md)를 참조하세요.

1. 저장소를 포크하세요
2. 기능 브랜치를 만드세요 (`git checkout -b feature/amazing-feature`)
3. 변경 사항을 커밋하세요 (`git commit -m 'Add some amazing feature'`)
4. 브랜치에 푸시하세요 (`git push origin feature/amazing-feature`)
5. 풀 리퀘스트를 열어주세요

## 📄 라이선스

이 프로젝트는 MIT 라이선스 하에 있습니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 🔗 링크

- 📚 **문서**: [https://ui.ahmedbna.com](https://ui.ahmedbna.com)
- 🐛 **버그 리포트**: [GitHub Issues](https://github.com/ahmedbna/ui/issues)
- 💬 **Linkedin**: [@ahmedbna](https://www.linkedin.com/in/ahmedbna/)
- 𝕏 **X**: [@ahmedbnaa](https://x.com/ahmedbnaa)

## ⭐ 지원

BNA UI가 도움이 되셨다면 GitHub에서 별을 눌러주세요! 큰 도움이 됩니다.

[![GitHub stars](https://img.shields.io/github/stars/ahmedbna/ui?style=social)](https://github.com/ahmedbna/ui)

## 📈 통계

![GitHub package.json version](https://img.shields.io/github/package-json/v/ahmedbna/ui)
![npm](https://img.shields.io/npm/v/bna-ui)
![npm](https://img.shields.io/npm/dm/bna-ui)
![GitHub](https://img.shields.io/github/license/ahmedbna/ui)

---

❤️ 와 함께 제작됨 by [Ahmed BNA](https://github.com/ahmedbna)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---