[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![CI - Build and Test](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml)
[![Deploy to GitHub Pages](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml)

![](https://raw.githubusercontent.com/Tillman32/CleanArchitecture/master/./src/CleanArchitecture.WASM/Preview.png)

[LIVE DEMO - WASM on GitHub Pages](https://tillman32.github.io/CleanArchitecture/)

# 그 모든 것의 동기

이 모든 것의 목적은 무엇일까요? 음, Bob Ross를 보여주는 것 외에도... 저는 아키텍처를 이야기할 때 참조할 수 있는 "실제 세계" 애플리케이션이 있으면 좋겠다고 생각했습니다. 표준을 설정하고, 복제하고, 다음 모든 .Net Core 프로젝트에서 활용할 무언가가 필요했습니다. 모든 소프트웨어(그리고 와인처럼)처럼, 이것도 시간이 지나면서 개선될 것입니다.

또한 "Uncle Bob"(Robert C. Martin)과 이름이 비슷한 점이 적절하다고 생각했으며, 이 프로젝트는 그의 아키텍처를 [그의 웹사이트에 명시된 대로](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) 맞추려고 시도합니다.

이와 함께 작성한 블로그 글도 있습니다: [https://www.brandontillman.com/blog/clean-architecture-dotnet](https://www.brandontillman.com/blog/clean-architecture-dotnet)

# 핵심 포인트:

### :trident: N-계층 아키텍처

같은 핵심 비즈니스 기능/백엔드를 사용하는 여러 UI를 준비하기 위한 3계층 접근 방식입니다.

### :open_file_folder: 관심사의 분리

["단일 책임 원칙"](http://deviq.com/single-responsibility-principle/)과 밀접한 관련이 있는 관심사의 분리(Separation of Concerns, SoC)는 아이디어를 한 곳에 모으지 않음으로써 코드를 더 유지보수하기 쉽게 만듭니다. 변경이 있을 때 SoC는 변경이 기능 세트에만 국한되고 애플리케이션 전체로 확산되지 않도록 도와줍니다.

### :droplet: 누수 없는 추상화

인터페이스를 사용함으로써 누수되는 추상화를 피하고, 코드 사용 방식을 더 잘 제어할 수 있습니다. 반대로, 코드 사용자는 구현 세부사항을 알 필요 없이 인터페이스/클래스만 사용하면 됩니다.

### :microscope: 테스트 가능

강하게 결합된 코드를 테스트하는 것은 거의 불가능합니다. SOC 원칙을 따르고 인터페이스를 사용함으로써 코드를 더 쉽게 테스트할 수 있습니다.

### :electric_plug: 모듈화

코드는 미래에 수정하기 더 쉬워집니다. 그 이유는 여러 가지입니다. 관심사의 분리는 애플리케이션 전반에 걸친 변경/테스트를 줄여줍니다. 나머지 코드를 수정하지 않고도 특정 기능 세트 위에 구축할 수 있습니다.

### :wrench: 유지보수 가능

코드는 클린 아키텍처 패턴을 따름으로써 본질적으로 더 유지보수가 용이해집니다. 다른 개발자들도 깔끔한 분리의 이점을 보고 이를 따르게 될 것입니다.

# 주요 사용 기술

- [.Net](https://dotnet.microsoft.com/)
- [Blazor WASM](https://www.learnblazor.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [AutoMapper](https://automapper.org/)
- [NLog](https://nlog-project.org/)

### :star2: 별을 눌러주세요!  
이 프로젝트를 학습하거나 솔루션 시작에 사용 중이라면 별을 눌러주시길 부탁드립니다. 감사합니다!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---