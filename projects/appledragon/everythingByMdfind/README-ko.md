[English](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README.md) | [中文](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_CN.md) | [한국어](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_KO.md) | [日本語](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_JP.md) | [Français](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_FR.md) | [Deutsch](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_DE.md) | [Español](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_ES.md)

<img width="3836" height="2026" alt="image" src="https://github.com/user-attachments/assets/d86c3d6b-6fd4-4cfe-b64f-67c465bb3d3c" /><img width="3832" height="2024" alt="image" src="https://github.com/user-attachments/assets/a91d2b13-07ac-4cae-ab33-506f1fa3bca6" />


# mdfind를 이용한 Everything

macOS의 네이티브 Spotlight 엔진을 활용하여 번개처럼 빠른 결과를 제공하는 강력하고 효율적인 파일 검색 도구입니다.

## 주요 기능

*   **초고속 검색:** macOS Spotlight 인덱스를 활용하여 거의 즉각적인 파일 검색을 지원합니다.
*   **유연한 검색 옵션:** 파일 이름 또는 내용으로 검색하여 필요한 파일을 빠르게 찾을 수 있습니다.
*   **고급 필터링:** 다양한 필터로 검색 결과를 세밀하게 조정할 수 있습니다:
    *   파일 크기 범위 (최소 및 최대 크기, 바이트 단위)
    *   특정 파일 확장자 (예: `pdf`, `docx`)
    *   대소문자 구분 매칭
    *   전체 또는 부분 일치 옵션
*   **디렉토리별 검색:** 특정 디렉토리로 검색 범위를 제한하여 집중된 결과를 얻을 수 있습니다.
*   **풍부한 미리보기:** 다양한 파일 유형을 애플리케이션 내에서 직접 미리보기할 수 있습니다:
    *   인코딩 감지 기능이 있는 텍스트 파일
    *   이미지 (JPEG, PNG, 애니메이션 지원 GIF, BMP, WEBP, HEIC)
    *   적절한 스케일링 및 중앙 정렬이 가능한 SVG 파일
    *   재생 제어 기능이 있는 비디오 파일
    *   오디오 파일
*   **통합 미디어 플레이어:**
    *   표준 제어가 가능한 비디오 및 오디오 재생
    *   미디어 파일용 독립 실행형 플레이어 창
    *   연속 재생 모드
    *   볼륨 조절 및 음소거 옵션
*   **북마크:** 자주 사용하는 검색에 빠르게 접근:
    *   대용량 파일 (>50MB)
    *   비디오 파일
    *   오디오 파일
    *   이미지
    *   압축 파일
    *   애플리케이션
*   **디스크 공간 분석:** 모든 디렉토리의 디스크 공간 사용량을 분석:
    *   원클릭 홈 디렉토리 공간 분석
    *   상위 공간 사용 폴더를 보여주는 인터랙티브 막대 차트 시각화
    *   검색 결과의 폴더에서 마우스 오른쪽 버튼 클릭하여 공간 사용량 분석
    *   차트 막대를 더블 클릭하여 하위 디렉토리 상세 분석
    *   색상 코드 차트로 하위 디렉토리 크기 시각적 분해
    *   크기별 자동 정렬로 가장 큰 폴더 식별
*   **정렬 가능한 결과:** 이름, 크기, 수정 날짜 또는 경로별로 검색 결과 정리.
*   **다중 파일 작업:** 여러 파일에 동시에 작업 수행:
    *   Shift 또는 Command (⌘) 키로 다중 선택
    *   일괄 작업: 열기, 삭제, 복사, 이동, 이름 변경
    *   추가 작업을 위한 컨텍스트 메뉴
*   **다중 탭 검색 인터페이스:** 여러 검색 세션 동시 작업:
    *   다른 검색 쿼리용 새 탭 생성
    *   마우스 오른쪽 버튼 메뉴로 탭 닫기, 재정렬 및 관리
    *   탭별 독립 검색 결과 및 설정
    *   많은 탭에 대한 스크롤 버튼이 있는 크롬 같은 탭 경험
*   **사용자 정의 가능한 인터페이스:**
    *   선택 가능한 6가지 아름다운 테마:
        *   라이트 & 다크 (시스템 기본)
        *   도쿄 나이트 & 도쿄 나이트 스톰
        *   치놀러 다크 & 치놀러 라이트 (중국 전통 색상)
    *   선택한 테마에 맞춘 시스템 타이틀 바 테마 적용
    *   미리보기 패널 표시/숨기기
    *   구성 가능한 검색 기록
*   **다중 형식 내보내기:** 여러 형식으로 검색 결과 내보내기:
    *   JSON - 구조화된 데이터 형식
    *   Excel (.xlsx) - 서식 있는 스프레드시트
    *   HTML - 웹용 테이블 형식
    *   Markdown - 문서 친화적 형식
    *   CSV - 전통적인 쉼표로 구분된 값
*   **지연 로딩:** 스크롤할 때 항목을 일괄로 로드하여 큰 결과 세트 효율적으로 처리.
*   **드래그 앤 드롭:** 파일을 외부 애플리케이션으로 직접 드래그.
*   **경로 작업:** 파일 경로, 디렉토리 경로 또는 파일 이름을 클립보드에 복사.

## 설치

1.  **전제 조건:**
    *   Python 3.6 이상
    *   PyQt6

2.  **저장소 복제:**

    ```bash
    git clone https://github.com/appledragon/everythingByMdfind
    cd everythingByMdfind
    ```
3.  **의존성 설치:**


    ```bash
    pip install -r requirements.txt
    ```

4.  **애플리케이션 실행:**

    ```bash
    python everything.py
    ```
## 미리 빌드된 애플리케이션 다운로드

준비된 macOS 애플리케이션(.dmg)을 [GitHub Releases](https://github.com/appledragon/everythingByMdfind/releases) 페이지에서 직접 다운로드할 수 있습니다.

## 기여

기여를 환영합니다! 버그 수정, 기능 요청 또는 일반적인 개선 사항에 대해 풀 리퀘스트를 제출하거나 이슈를 열어주세요.

## 라이선스

이 프로젝트는 Apache License 2.0 하에 라이선스가 부여되어 있습니다 - 자세한 내용은 [LICENSE.md](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/LICENSE.md) 파일을 참조하세요.

## 작성자

Apple Dragon

## 버전

1.4.2

## 감사의 글

*   강력하고 다재다능한 GUI 프레임워크를 제공해 준 PyQt6 팀에 감사드립니다.
*   다른 훌륭한 파일 검색 도구들로부터 영감을 받았습니다.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---