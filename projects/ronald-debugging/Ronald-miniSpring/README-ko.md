# ronald-miniSpring 프레임워크

경량화된 Spring 프레임워크 구현체로, 핵심 Spring 원리와 메커니즘을 시연합니다. 이 프로젝트는 Spring의 필수 기능을 추출하고 단순화하면서도 기본 아키텍처를 유지하여 Spring 내부 구조를 이해하는 데 훌륭한 학습 자료가 됩니다.

## 🚀 주요 기능

- **IoC 컨테이너**: 의존성 주입과 제어의 역전을 완벽하게 구현
- **AOP 프레임워크**: 메서드 가로채기 및 향상을 지원하는 관점 지향 프로그래밍
- **빈 라이프사이클**: 빈 생성, 초기화, 소멸 등 포괄적인 라이프사이클 관리
- **리소스 관리**: 클래스패스 및 파일 시스템을 지원하는 유연한 리소스 로딩 시스템
- **이벤트 시스템**: 애플리케이션 이벤트를 위한 퍼블리시-서브스크라이브 패턴 구현
- **타입 변환**: 기본 및 사용자 정의 타입을 위한 강력한 타입 변환 시스템
- **XML 구성**: 네임스페이스 처리를 포함한 완전한 XML 구성 지원

## 💡 기술적 하이라이트

### 1. 순환 의존성 해결
순환 의존성을 처리하기 위해 정교한 3단계 캐시 메커니즘을 구현함:
```java
// Three-level cache structure
Map<String, Object> singletonObjects = new ConcurrentHashMap<>();      // Level 1: Fully initialized beans
Map<String, Object> earlySingletonObjects = new HashMap<>();           // Level 2: Early exposed beans
Map<String, ObjectFactory<?>> singletonFactories = new HashMap<>();    // Level 3: Bean factories
```
### 2. AOP 구현
- JDK 및 CGLIB를 이용한 동적 프록시 생성
- AspectJ 포인트컷 표현식 지원
- 유연한 어드바이스 타입 (Before, After, Around)

### 3. 빈 생명주기 관리
- 완전한 생명주기 후크 (InitializingBean, DisposableBean)
- 커스터마이징을 위한 BeanPostProcessor 지원
- Aware 인터페이스 계열 구현

## 🛠️ 기술 스택

- **언어**: Java 17
- **빌드 도구**: Maven 3.8.1
- **테스트**: JUnit 5
- **의존성**:
  - XML 파싱용 DOM4J
  - AOP 프록시용 CGLIB
  - 포인트컷 표현식용 AspectJ
  - 로깅용 Logback

## 📋 프로젝트 구조


```
src/main/java/com/minispring/
├── beans/          # IoC container implementation
├── context/        # Application context and event system
├── core/           # Core utilities and type conversion
├── aop/            # AOP framework implementation
└── web/            # Web-specific features
```
## 🎯 구현 세부 사항

### IoC 컨테이너
- 빈 정의 및 등록 시스템
- 의존성 주입(생성자 및 세터)
- 빈 스코프 관리(싱글톤, 프로토타입)
- 프로퍼티 값 처리

### AOP 프레임워크
- 포인트컷 표현식 파싱
- 동적 프록시 생성
- 메서드 가로채기 및 향상
- AspectJ 통합

### 리소스 관리
- 통합 리소스 추상화
- 클래스패스 및 파일 시스템 지원
- 리소스 로딩 전략

## 🏗️ 아키텍처

프레임워크는 관심사의 명확한 분리를 가진 모듈형 아키텍처를 따릅니다:
1. **코어 컨테이너**: 빈과 그 의존성을 관리
2. **AOP 모듈**: 관점 지향 프로그래밍 처리
3. **컨텍스트 모듈**: 애플리케이션 컨텍스트 및 이벤트 시스템 제공
4. **리소스 모듈**: 리소스 로딩 및 접근 관리

## 🚀 시작하기


```bash
# Clone the project
git clone https://github.com/ronald-debugging/Ronald-miniSpring.git

# Build the project
mvn clean install

# Run tests
mvn test
```
## 📚 학습 자료

- 스프링 프레임워크 공식 문서
- "스프링 리빌드"
- "스프링 소스 코드 심층 분석"

## 🔄 현재 상태

모든 핵심 기능이 구현되고 테스트되었습니다:
- ✅ IoC 컨테이너
- ✅ AOP 프레임워크
- ✅ 빈 라이프사이클
- ✅ 리소스 관리
- ✅ 이벤트 시스템
- ✅ 타입 변환
- ✅ XML 설정
- ✅ 순환 의존성 해결




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-02

---