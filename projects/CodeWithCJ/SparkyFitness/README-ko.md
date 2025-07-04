# SparkyFitness - MyFitnessPal의 셀프호스팅 대안

SparkyFitness는 사용자가 영양, 운동, 신체 치수를 모니터링할 수 있도록 설계된 종합적인 피트니스 추적 및 관리 애플리케이션입니다. 일일 진행 상황 추적, 목표 설정, 인사이트가 담긴 보고서 등 건강한 라이프스타일을 지원하는 도구를 제공합니다.


## ✨ 주요 기능

### 🍎 영양 추적

* **일일 식단 기록**
* **사용자 지정 음식 및 카테고리 생성 및 관리**
* **요약 보기 및 대화형 차트로 트렌드 분석**

### 💪 운동 기록

* **운동 기록 저장**
* **포괄적인 운동 데이터베이스 탐색 및 검색**
* **시간에 따른 피트니스 진행 상황 추적**

### 💧 수분 섭취 관리

* **일일 수분 섭취 목표 추적**
* **간편하고 빠른 물 섭취 기록**

### 📏 신체 치수

* **신체 지표 기록** (예: 체중, 허리, 팔둘레 등)
* **사용자 정의 측정 항목 추가**
* **차트로 진행 상황 시각화**

### 🎯 목표 설정

* **피트니스 및 영양 목표 설정 및 관리**
* **시간에 따른 목표 달성도 추적**

### 🗓️ 일일 체크인

* **일일 활동 모니터링**
* **습관 추적으로 꾸준함 유지**

### 🤖 AI 영양 코치 (SparkyAI)

* **채팅을 통해 음식, 운동, 신체 통계, 걸음 수 기록**
* **음식 사진 업로드로 자동 식사 기록**
* **채팅 기록 및 개인별 맞춤 가이드 포함**

### 🔒 사용자 인증 및 프로필

* **보안 로그인 시스템**
* **사용자 프로필 간 전환**
* **가족 접근 및 관리 지원**

### 📊 종합 보고서

* **영양 및 신체 지표 요약 보고서 생성**
* **주/월 단위 장기 트렌드 추적**

### 🎨 맞춤형 테마

* **라이트/다크 모드 전환**
* **미니멀하고 집중을 방해하지 않는 인터페이스 디자인**

### 도움이 필요하신가요?
* **디스코드 참여**
  https://discord.gg/vcnMT5cPEA
* **토론에 글 남기기**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 시작하기

로컬 환경에서 SparkyFitness 애플리케이션을 실행하려면 다음 단계를 따르세요:

### 사전 준비

*   **Supabase 프로젝트**: Supabase 프로젝트가 필요합니다.
    *   **Supabase에서 새 프로젝트 생성**: [Supabase](https://app.supabase.com/)에 접속해 새 프로젝트를 만드세요. (원한다면 로컬 Supabase 프로젝트로 설정할 수도 있습니다.)
    *   프로젝트 설정(API 섹션)에서 Supabase 프로젝트 URL과 Anon Key를 확인하세요.
    *   **Supabase 인증 관련 중요 사항:** Supabase 인증 설정에서 URL 구성을 귀하의 도메인에 맞게 업데이트하세요. 이는 도메인이 정상 작동하고 회원가입 초대 이메일 수신을 위해 반드시 필요합니다. Supabase는 강력한 보안 기능과 외부 SSO 옵션도 제공하니, 프로젝트 요구에 맞게 구성하세요.
    *   Supabase 무료 버전 사용 시, 자동 DB 배포는 IPV4에서 작동하지 않습니다. 네트워크를 IPV6 연결로 설정해야 하며, 그렇지 않으면 DB 마이그레이션이 실패하고 수동 배포가 필요합니다.       


    

### 설치

1.  **환경 변수 설정:**
    private 폴더 아래에 `.env` 파일을 생성하세요. Portainer를 사용 중이라면 거기서 직접 생성할 수 있습니다. 
    Supabase 자격 정보를 추가하세요:
    ```
    VITE_SUPABASE_URL="YOUR_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="YOUR_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="YOUR_SUPABASE_PROJECT_REF"    
    ```

2.  **Docker Compose로 실행:**
    Docker 이미지를 받아와 서비스를 시작하세요:
    ```sh
    docker compose pull
    docker compose up -d
    ```

3.  **애플리케이션 접속:**
    서비스가 모두 실행되면, 웹 브라우저에서 SparkyFitness에 접속하세요:
    ```
    http://localhost:3000
    ```

4.  **AI 챗봇 - 선택적 구성:**
    AI 챗봇의 전체 기능(보안 API 키 저장 및 데이터베이스 접근 포함)을 활성화하려면 아래 단계를 따르세요:

    *   **`AI_API_ENCRYPTION_KEY` 구성:** "Supabase -> Edge Functions" -> "Environment Variables"에서 시크릿을 생성하세요. 이 키는 Supabase에 AI 키를 저장할 때 암호화하는 데 사용됩니다.

    *   **`SUPABASE_ACCESS_TOKEN` 생성:**
        1.  Docker 콘솔에 접속합니다.
        2.  `supabase login`을 실행하고 제공된 URL로 인증합니다.
        3.  `cat ~/.supabase/access-token` 명령어를 실행하여 액세스 토큰을 확인합니다.
        4.  해당 토큰을 `docker-compose.yml`이나 Portainer 설정에 업데이트하여 재배포합니다.
        5.  재배포 후, SparkyFitness에 로그인하여 선호하는 AI 제공업체로 AI 서비스를 구성합니다.
     

### Supabase에 DB 및 Functions 수동 배포
**방법 1:**  
**IPV6 네트워크 연결이 활성화되어 있지 않으면, Supabase 무료 버전이 IPV4 직접 연결을 지원하지 않으므로 DB 마이그레이션이 실패합니다.

   1. 최신 릴리스를 다운로드하여 PC에서 압축을 풉니다.
   2. 프로젝트 폴더로 이동합니다. Docker가 실행 중이어야 합니다.
   3. 아래 명령어를 실행합니다. (functions deploy는 AI 구성 시에만 필요합니다. ChatBOT이 필요 없다면 건너뛸 수 있습니다.)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Docker compose를 다시 실행하세요. 프론트엔드 앱이 정상적으로 동작합니다.

**방법 2:**  
   1. 최신 릴리스를 다운로드하여 PC에서 압축을 풉니다.  
   2. 프로젝트 폴더로 이동합니다.  
   3. supabase/migrations로 이동하여 SQL 구문들을 복사한 뒤, Supabase-->Project-->SQL Editor에서 하나씩 ASC 순서로 실행합니다.  
   4. [선택 사항] AI ChatBOT이 필요하다면, supabase/functions/chat에서도 동일하게 진행합니다. index.js를 복사해 Supabase-->Project-->Edge Function-->Deploy new function에서 실행합니다.  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---