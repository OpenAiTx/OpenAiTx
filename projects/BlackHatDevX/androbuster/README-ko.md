# 🚀 AndroBuster

<div align="center">
  <img width="2808" height="699" alt="bannerfinal" src="https://github.com/user-attachments/assets/7f74539f-0af6-40d9-bafb-9207afd80af8" />

</div> 

<div align="center">

**🔒 펜테스팅을 쉽게**  
*Flutter로 제작된 강력한 디렉토리 및 서브도메인 열거 도구*

[![Download APK](https://img.shields.io/badge/Download-APK-blue?style=for-the-badge&logo=android)](https://github.com/BlackHatDevX/androbuster/releases)
[![GitHub stars](https://img.shields.io/github/stars/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub forks](https://img.shields.io/github/forks/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub issues](https://img.shields.io/github/issues/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster/issues)

</div>

---

## 📖 개요

AndroBuster는 GoBuster에서 영감을 받은 **오픈소스 보안 도구**로, 디렉토리 및 서브도메인 열거를 위한 현대적이고 크로스 플랫폼 인터페이스를 제공합니다. Flutter로 제작되어 전문 보안 도구에서 기대하는 강력함과 유연성을 유지하면서 깔끔하고 직관적인 사용자 경험을 제공합니다.

### 🎯 AndroBuster가 특별한 이유는?
- 🚀 **크로스 플랫폼**: Android, iOS, 데스크탑에서 작동
- 🔒 **보안 중심**: 침투 테스터를 위해 특별히 제작
- 💻 **모던 UI**: 아름다운 Flutter 기반 인터페이스
- ⚡ **고성능**: 효율적인 스레딩 및 메모리 관리
- 📱 **모바일 우선**: 모바일 보안 테스트에 최적화

---

## 🖼️ 스크린샷

<div align="center">

<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 24 AM" src="https://github.com/user-attachments/assets/e12ed93e-876f-408b-9e3d-4a849e8fe2a1" />
<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 34 AM" src="https://github.com/user-attachments/assets/17850561-cef9-46e2-8203-8ba29c223fe7" />
</div>

---



## ✨ 기능

### 🗂️ 디렉토리 열거 모드
- **대상 URL 입력**: 자동 후행 슬래시 제거를 통한 깔끔한 URL 처리
- **부정 상태 코드**: 원치 않는 HTTP 상태 코드 필터링 (기본값: 404)
- **부정 페이지 크기**: 콘텐츠 길이를 기준으로 응답 제외
- **워드리스트 지원**: 파일 가져오기 기능이 포함된 대용량 텍스트 입력
- **스레딩 제어**: 최적 성능을 위한 스레드 수 구성 가능
- **타임아웃 설정**: 밀리초 단위 사용자 지정 요청 타임아웃

### 🌐 서브도메인 열거 모드
- **도메인 입력**: 깔끔한 도메인 처리 (http/https 불필요)
- **서브도메인 워드리스트**: 서브도메인 탐색 전용 워드리스트 관리
- **프로토콜 테스트**: 자동 HTTPS/HTTP 폴백 테스트
- **서브도메인 검증**: RFC 1123 준수 서브도메인 이름 검증
- **전용 필터**: 서브도메인용 별도의 부정 상태 코드 및 페이지 크기
- **스레딩 및 타임아웃**: 디렉토리 모드와 독립적인 구성

### 📋 결과 관리
- **통합 결과 탭**: 디렉토리 및 서브도메인 스캔 결과 모두 보기
- **결과 형식화**: 경로, 상태 코드, 크기 및 URL 명확하게 표시
- **클립보드 복사**: 외부 분석용 결과 내보내기
- **결과 지우기**: 스캔 간 손쉬운 정리
- **결과 개수**: 디렉토리 및 서브도메인 결과 별도 추적

### 📁 파일 관리
- **워드리스트 가져오기**: 최대 50MB .txt 파일 지원
- **스마트 미리보기**: 파일 크기 인식 콘텐츠 표시
- **대용량 파일 처리**: 대규모 워드리스트 효율적 처리
- **포맷 지원**: 주석(#) 및 빈 줄 자동 처리

### 🚀 성능 및 신뢰성
- **백그라운드 실행**: 백그라운드 스캔 중에도 앱 계속 실행

- **메모리 최적화**: 대용량 워드리스트의 효율적 처리  
- **오류 처리**: 원활한 예외 처리 및 복구 메커니즘  
- **크로스 플랫폼**: Android와 iOS용 Flutter 기반 개발  


---

## 📱 설치

### 📦 릴리즈 빌드  
현재 Android APK 릴리즈만 제공됩니다. 최신 APK는 릴리즈 페이지에서 다운로드하세요.

<div align="center">

[![최신 릴리즈 다운로드](https://img.shields.io/badge/📥%20Download%20Latest%20Release-blue?style=for-the-badge)](https://github.com/BlackHatDevX/androbuster/releases)

</div>

### 🔧 소스 빌드  
소스 코드는 이제 공개되어 누구나 사용, 수정 및 기여할 수 있습니다.

---

## 📖 사용 가이드

### 🗂️ 디렉토리 열거  
1. "Dir" 탭으로 이동  
2. 대상 URL 입력  
3. 부정 상태 코드 및 페이지 크기 설정  
4. 워드리스트 붙여넣기 또는 가져오기  
5. 스레드 수 및 타임아웃 설정  
6. 스캔 시작 후 진행 상황 모니터링  

### 🌐 서브도메인 열거  
1. "Subdomain" 탭으로 이동  
2. 대상 도메인 입력 (http/https 제외)  
3. 서브도메인 전용 필터 설정  
4. 서브도메인 워드리스트 가져오기 또는 붙여넣기  
5. 스레딩 및 타임아웃 설정 조정

6. 하위 도메인 탐색 시작

### 📋 결과 관리
- "결과" 탭에서 모든 결과 보기
- 외부 분석을 위해 결과를 클립보드에 복사
- 다른 스캔 간 결과 지우기
- 스캔 진행 상황 및 완료 모니터링

---

## ⚙️ 설정

### ⚡ 스레드 수
- **권장**: 대부분의 경우 10-20 스레드
- **고스레드 경고**: 20 스레드 초과 시 알림
- **고려사항**: 높은 스레드는 속도 제한을 유발할 수 있음

### ⏱️ 타임아웃 설정
- **기본값**: 5000ms (5초)
- **조정**: 느린 네트워크는 증가, 빠른 응답은 감소
- **범위**: 1000ms에서 30000ms 지원

### 🚫 부정 필터
- **상태 코드**: 쉼표로 구분된 목록 (예: 404,403,500)
- **페이지 크기**: 쉼표로 구분된 목록 (예: 0,1234,5678)
- **목적**: 원하지 않는 응답을 결과에서 제외

---

## 🤝 기여

이 프로젝트는 **오픈 소스**이며 기여를 환영합니다! 소스 코드는 이제 공개되어 누구나 이용할 수 있습니다.

<div align="center">

[![저장소 별점](https://img.shields.io/badge/⭐%20Star%20Repository-yellow?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)

</div>

### 📋 기여 방법
1. **⭐ 저장소에 별표 표시** (선택 사항이지만 감사히 받습니다!)
2. **🍴 저장소를 포크**하세요
3. **🌿 기능 브랜치 생성**
4. **📤 풀 리퀘스트 제출**

---

## 🙏 크레딧 및 감사의 말씀

- **🎯 영감 받은 도구**: [GoBuster](https://github.com/OJ/gobuster) - 원본 디렉터리 열거 도구
- **🛠️ 사용 기술**: [Flutter](https://flutter.dev/) - 구글의 네이티브 컴파일 애플리케이션 UI 툴킷
- **🔒 보안 중점**: 침투 테스터 및 보안 연구자를 위해 설계됨
- **🌍 커뮤니티**: 모든 기여자와 후원자에게 감사드립니다

---

## 📄 라이선스

이 프로젝트는 **오픈 소스**이며 MIT 라이선스 하에 제공됩니다.

---

## ⚠️ 면책 조항

이 도구는 **승인된 보안 테스트** 및 **침투 테스트 목적**으로만 설계되었습니다. 사용자는 시스템 테스트 전에 적절한 승인을 받았는지 확인할 책임이 있습니다. 개발자는 이 도구의 오용에 대해 책임지지 않습니다.

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-24

---