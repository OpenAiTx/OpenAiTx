<div align="left">
  <a href="https://github.com/microsoft/dotnet">
    <img src="https://img.shields.io/badge/-.NET-red">
  </a>
  <a href="https://avaloniaui.net/">
    <img src="https://img.shields.io/badge/Avalonia-8245A9">
  </a>
  <a href="https://dotnet.microsoft.com/zh-cn/languages/csharp">
    <img src="https://img.shields.io/badge/-C%23-yellow">
  </a>
  <a href="http://www.gnu.org/licenses/mit.en.html">
    <img src="https://img.shields.io/badge/License-MIT-green">
  </a>
</div>
<br/><br/>

![acss-brand](https://raw.githubusercontent.com/liwuqingxin/Avalonia.Css/main/img/AcssText.svg)

Avalonia Css, 또는 약칭 Acss는 표준 CSS (Cascading Style Sheets)를 따르지 않습니다. Avalonia UI의 **구조적 정의와 시각적 정의를 분리**하고 Avalonia가 **스타일을 빠르게 동적으로 수정할 수 있는 능력**을 부여하도록 설계되었습니다.

네, 이는 **Html+CSS**와 유사한 패턴을 따릅니다.

# 홍보

저는 최근 Ant Design 스타일을 따르는 Avalonia 컨트롤 라이브러리를 발견했는데, 매우 잘 만들어져 있습니다. 핵심 개발자와 이야기한 후, 상호 홍보를 통해 서로 지원하기로 합의했습니다. 관심이 있으시면 [여기](https://github.com/chinware/AtomUI)에서 확인해 보세요.

![](https://github.com/chinware/AtomUI/blob/develop/resources/images/readme/AtomUIOSS.png)


![](https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.svg)

Jet Brains가 [개발자 도구를 무료로 제공해주신 것](https://www.jetbrains.com/community/opensource/?utm_campaign=opensource&utm_content=approved&utm_medium=email&utm_source=newsletter&utm_term=jblogo#support)에 깊은 감사를 드립니다.

# 기능

- 구조와 스타일의 분리
- 구조 재사용
- 동적 로딩
- 핫 로딩
- 가로채기 및 필터링
- 동작 확장  
- 구문 확장  
- 스타일 디버깅  
- 사용자 지정 그리기  

# 문서  

문서는 [여기](https://docs.en.avalonia.css.nlnet.net/documentation/readme)에서 확인할 수 있습니다. 영어 문서는 중국어 문서를 DeepL로 번역한 것임을 참고해 주세요. 문제가 있다면 깃허브에서 직접 수정해 주셔도 됩니다.  

> 중국어 문서는 [여기](https://docs.avalonia.css.nlnet.net/documentation/readme)를 참조하십시오.  

# 사용법  

Acss 사용법은 [여기](https://docs.en.avalonia.css.nlnet.net/documentation/zhu-ti-bang-zhu/ru-he-shi-yong-acss)를 참고해 주세요.  

# 기여  

더 많은 관심 있는 파트너들이 Acss 개발에 참여하여 보다 활기차고 강력하게 만들길 바랍니다.  

참여에 관심이 있거나 아이디어, 제안, 피드백이 있다면 yangqi1990917@163.com 으로 이메일을 보내 주세요.  

# 쇼케이스  

Acss로 구현된 Avalonia 컨트롤을 위한 Fluent 테마를 제공합니다. 테마에 대한 자세한 내용은 [Acss.Fluent](https://docs.en.avalonia.css.nlnet.net/documentation/zhu-ti-bang-zhu/ru-he-shi-yong-acss.fluent)를 참조하세요.  

Acss 쇼케이스는 [bilibili](https://space.bilibili.com/1117754194/channel/seriesdetail?sid=3739599) 또는 [youtube](https://www.youtube.com/channel/UCYvEgvGj-JVYZrOrup3aoBQ)에서 더 볼 수 있습니다.  

<br/>  

![fluent ui](https://raw.githubusercontent.com/liwuqingxin/Avalonia.Css/main/./img/fluent-ui.png)  

# 왜 Acss를 사용하는가  

> 테마 = 구조 + 스타일  

표준 컨트롤 라이브러리가 있다고 가정해 보겠습니다. 그 컨트롤들의 기능은 템플릿 내 구조에 따라 달라집니다. 컨트롤의 외관을 수정하려면 보통 모든 ControlTheme을 다시 작성해야 합니다. 이는 컨트롤 구조와 스타일, 심지어 리소스까지 다시 작성해야 함을 의미합니다. 매우 번거로운 작업입니다.  

Acss 패턴을 사용하면, 컨트롤의 표준 테마에서 스타일을 분리하고 골격 구조인 ControlTemplate만 남깁니다. 어떤 라이브러리든 표준 구조를 기반으로 자신만의 Acss 라이브러리를 정의하여 원하는 컨트롤 외관을 구현할 수 있습니다. 라이브러리 제작자는 기존 ControlTheme 코드를 고통스럽게 복사할 필요가 없습니다. 컨트롤 템플릿이 올바른지 걱정할 필요도 없습니다. 오직 UI 디자인에 따라 스타일만 조정하면 됩니다!  

> 지속적인 집중은 우리의 작업을 더 매끄럽고 우아하며 효과적으로 만듭니다.
또 다른 경우는 새로운 페이지를 생성할 때, 전통적인 작업 흐름은 일반적으로 레이아웃, 콘텐츠 채우기, 비즈니스 로직 작성, 스타일 조정, UI 디자인에 따른 미세 조정을 포함합니다.  
이는 일반적으로 개발자의 작업이며, 페이지가 완성될 때까지 지속적인 주의가 필요합니다.  
이제 Acss 패턴을 사용하면, 기능 담당자가 페이지 콘텐츠를 채우고 비즈니스 로직을 작성한 후, 시각적 스타일을 조화시키는 시각 담당자에게 넘기는 접근 방식이 됩니다.  

# 우리가 제공하는 패키지  

- **Nlnet.Avalonia.Css**. Acss의 핵심입니다.  

- **Nlnet.Avalonia.Css.Controls**. 이 라이브러리는 Avalonia.Controls의 컨트롤에 대한 순수 구조를 제공합니다.  

- **Nlnet.Avalonia.Css.Fluent**. 이 라이브러리는 Avalonia.Controls, Nlnet.Avalonia.Senior 및 Nlnet.Avalonia.MessageBox를 위한 Fluent UI를 제공합니다.  

- **Nlnet.Avalonia.Css.Behaviors**. 이 라이브러리는 Acss를 위한 확장 동작을 제공합니다.  
- **Nlnet.Avalonia.Senior**. 이 라이브러리는 Avalonia.Controls가 제공하지 않는 **부드러운 스크롤링** 및 기타 고급 기능을 제공합니다.  
- **Nlnet.Avalonia.MessageBox**. 이 라이브러리는 WPF 표준 또는 Avalonia 표준을 따르는 MessageBox 컨트롤을 제공합니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---