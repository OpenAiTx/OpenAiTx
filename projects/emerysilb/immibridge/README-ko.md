<p align="center">
  <img src="https://raw.githubusercontent.com/emerysilb/immibridge/main/./assets/icon-transparent.png" alt="ImmiBridge" width="128">
</p>

<h1 align="center">ImmiBridge</h1>

<p align="center">
  <a href="https://opensource.org/licenses/MIT"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License: MIT"></a>
  <a href="https://www.apple.com/macos/"><img src="https://img.shields.io/badge/macOS-12.0+-blue.svg" alt="macOS"></a>
</p>

<p align="center">
  <a href="https://github.com/emerysilb/immibridge/releases/"><img src="https://img.shields.io/badge/Download-Latest%20Release-blue?style=for-the-badge" alt="Download latest release"></a>
</p>

Apple 사진 보관함을 촬영 날짜별로 정리된 폴더에 백업하거나, 직접 [Immich](https://immich.app) 서버로 백업하세요. 원본(라이브 포토 연동 비디오 포함) 및 선택적으로 렌더링된 편집본을 내보냅니다.

<p align="center">
  <img src="https://raw.githubusercontent.com/emerysilb/immibridge/main/./assets/screenshot.png" alt="ImmiBridge Screenshot" width="700">
</p>

## 기능

- 날짜별로 정리된 로컬 폴더로 사진 내보내기
- Immich 사진 서버로 직접 업로드
- 증분, 전체 또는 미러 백업 모드 지원
- 앨범, 미디어 유형 또는 날짜별 필터링
- 백업 일시 중지 및 재개
- 예약 자동 백업
- 메뉴 막대 통합
- 진행 상황 추적 가능한 iCloud 사진 다운로드
- 메타데이터 전용 동기화(파일 재업로드 없이 메타데이터만 업데이트)
- Sparkle을 통한 자동 업데이트

## 설치

### 다운로드 (권장)

1. [릴리스](../../releases) 페이지에서 `ImmiBridge-x.x.x.dmg` 파일 다운로드
2. DMG 파일을 열고 ImmiBridge를 응용 프로그램 폴더로 드래그하세요
3. 애플리케이션에서 ImmiBridge 실행  
4. 요청 시 사진 접근 권한 부여  

### 소스에서 빌드하기  

자세한 빌드 지침은 [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md)를 참조하세요.  

**빠른 시작:**

```bash
# Clone the repository
git clone https://github.com/emerysilb/immibridge.git
cd immibridge

# Open in Xcode
open ImmiBridge/ImmiBridge.xcodeproj
```
### 서명된 릴리스 빌드하기

배포용 공인된 DMG를 빌드하려면 Apple Developer ID 인증서($99/년)가 필요합니다. 자세한 내용은 [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md#creating-a-signed-release)를 참조하세요.

## 사용법

ImmiBridge를 실행하고 다음을 설정하세요:

1. **소스**: 사진 라이브러리 및/또는 사용자 지정 폴더 선택
2. **대상**: 로컬 폴더 및/또는 Immich 서버
3. **옵션**: 백업 모드, 필터, 스케줄링

### 백업 모드

| 모드 | 내보내기 | 매니페스트 사용 | 대상에서 삭제 |
|------|---------|---------------|--------------------------|
| **스마트 증분** | 새 파일/변경된 파일만 | 예 | 아니요 |
| **전체** | 모든 파일, 매번 | 아니요 | 아니요 |
| **미러** | 새 파일/변경된 파일만 | 예 | 예 (고아 파일) |

### Immich 통합

Immich 서버에 연결하려면:

1. **대상** 탭으로 이동
2. Immich 서버 URL 입력 (예: `http://192.168.1.100:2283`)
3. API 키 입력 (Immich에서 사용자 설정 → API 키에서 생성)
4. **연결 테스트** 클릭

**기능:**
- 중복 업로드 방지를 위해 SHA1 체크섬 사용
- 라이브 포토는 비디오 + 정지 이미지 쌍으로 업로드
- 앨범 동기화를 Immich에 지원

## 권한

최초 실행 시, macOS가 다음을 요청합니다:

- **사진 접근**: 사진 라이브러리 읽기 위해 필요

- **로컬 네트워크 접근**: Immich 서버가 로컬 네트워크에 있을 경우 필요합니다

권한을 거부한 경우 **시스템 설정 → 개인정보 보호 및 보안**에서 다시 활성화하세요.

## 기여

기여를 환영합니다! 지침은 [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md)를 참조하세요.

## 라이선스

MIT 라이선스 - 자세한 내용은 [LICENSE](LICENSE)를 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-11

---