# 3D Pressable Button

HTML, CSS, SVG로 제작된 현실감 있는 3D 버튼 컴포넌트로, 실제 버튼을 누르는 느낌을 시뮬레이션합니다. 이 버튼은 부드러운 애니메이션, 사용자 지정 가능한 색상, 반응형 인터랙션을 제공합니다.

제작자: [@BalintFerenczy](https://x.com/BalintFerenczy)

[Resend](https://resend.com/)의 놀라운 작업에서 영감을 받았습니다.

## 특징

- **현실감 있는 3D 외관** - 레이어드 SVG 그래픽 사용
- **부드러운 애니메이션** - 커스텀 이징 함수 적용
- **인터랙티브 상태** - 호버 및 누름 효과 제공
- **사용자 지정 색상** - CSS 변수로 색상 조정 가능
- **반응형 디자인** - 컨테이너 크기에 맞춰 자동 조정

## 데모
버튼은 사용자 상호작용에 따라 세 가지 뚜렷한 상태로 반응합니다:
- **Normal**: 버튼이 대기 중인 상태
- **Hover**: 마우스가 버튼 위에 있을 때 미묘하게 아래로 움직임
- **Active**: 버튼이 눌리거나 클릭될 때 크게 아래로 움직임

## 사용법

### 커스터마이즈

버튼은 CSS 커스텀 프로퍼티를 사용하여 쉽게 커스터마이즈할 수 있습니다:

```css
.frame {
    /* 버튼 크기 */
    width: 400px; 
    height: 400px; 

    /* 이동 거리 */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* 색상 커스터마이즈 */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* 트랜지션 설정 */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### 버튼 텍스트 변경

텍스트 내용을 간단히 수정하세요:

```html
<p class="text">클릭하세요!</p>
```

#### 버튼 크기 변경

프레임 크기를 조정하세요:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## 라이선스

이 프로젝트는 오픈 소스이며 MIT 라이선스 하에 제공됩니다.

## 기여

이 프로젝트를 자유롭게 포크하고 개선이나 새로운 기능을 위한 풀 리퀘스트를 제출해 주세요!

## 작성자

작성자: [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---