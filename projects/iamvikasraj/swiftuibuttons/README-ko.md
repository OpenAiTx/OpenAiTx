# jordansingerbutton

SwiftUI용 유리모픽 화살표 버튼과 부드러운 애니메이션을 특징으로 하는 아름답고 인터랙티브한 카운터 컴포넌트입니다.

## 📱 데모



## 🌿 브랜치

### `main` - 전체 앱
카운터 기능이 포함된 완전한 jordansingerbutton 앱입니다.

### `tutorial` - 화살표 버튼 컴포넌트
아름다운 화살표 버튼 컴포넌트만 집중한 깔끔한 독립 버전입니다. 학습 및 공유에 완벽합니다!

**튜토리얼 버전을 보려면:**
```bash
git checkout tutorial
```
## 🚀 빠른 시작

### 화살표 버튼 컴포넌트 사용하기

`ArrowButton`은 다음과 같은 특징을 가진 아름다운 글라스모픽 버튼을 생성하는 재사용 가능한 SwiftUI 컴포넌트입니다:
- 다중 레이어 스트로크가 적용된 금속성 강철 외관
- 흐려진 반사 효과
- 부드러운 애니메이션
- 사용자 정의 가능한 회전


```swift
import SwiftUI

ArrowButton(rotation: .degrees(0))  // Pointing down
ArrowButton(rotation: .degrees(180)) // Pointing up
ArrowButton(rotation: .degrees(90))  // Pointing left
ArrowButton(rotation: .degrees(270)) // Pointing right
```
### 전체 앱 사용법

전체 앱에는 "오늘", "내일", "어제" 레이블이 있는 날짜 탐색과 부드러운 날짜 전환이 포함되어 있습니다.

## 📁 프로젝트 구조


```
jordansingerbutton/
├── CounterView.swift          # Counter with arrow buttons (includes ArrowButton)
├── JordanSingerButtonApp.swift  # App entry point
└── Assets.xcassets/            # Arrow image asset
```
## 🎨 특징

- **글래스모픽 디자인**: 아름다운 금속 강철 외관  
- **부드러운 애니메이션**: 상호작용을 위한 스프링 기반 애니메이션  
- **접근성**: 완전한 VoiceOver 지원  
- **사용자 정의 가능**: 색상, 크기, 회전 쉽게 수정 가능  

## 📝 라이선스

프로젝트에 자유롭게 사용 및 수정 가능!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-12

---