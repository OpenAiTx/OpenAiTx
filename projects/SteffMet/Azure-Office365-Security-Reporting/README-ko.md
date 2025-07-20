<translate-content># 🛡️ Azure 및 Office 365 보안 보고서

> **Azure 및 Office 365 환경을 위한 종합 PowerShell 7 보안 감사 도구**

이 프로젝트는 Azure 및 Office 365 인프라 전반의 보안 격차, 컴플라이언스 문제 및 비용 최적화 기회를 식별하는 데 도움을 주는 모듈식 읽기 전용 보안 평가 스크립트를 제공합니다.

<div align="center">
  
![메뉴 레이아웃 데모](https://raw.githubusercontent.com/SteffMet/Azure-Office365-Security-Reporting/main/MenuLayout.gif)
  
</div>

### 🛡️ 새로운 보안 보고 모듈
| 모듈 | 설명 |
|--------|-------------|
| **Azure Storage 보안** | 공개 블롭 컨테이너 감지, 암호화 검증, HTTPS 적용 확인 및 네트워크 접근 규칙 분석을 수행합니다. |
| **Azure Key Vault 보안** | 인증서 만료 모니터링, 접근 정책 분석, 네트워크 제한 검증 및 소프트 삭제/영구 삭제 보호 확인을 수행합니다. |
| **네트워크 보안 그룹 (NSG)** | 위험한 방화벽 규칙, 인터넷 노출 서비스, SSH/RDP 노출 및 데이터베이스 포트 보안을 식별합니다. |
| **SharePoint 및 OneDrive 보안** | 외부 공유, OneDrive 사용 현황, 데이터 손실 방지(DLP) 정책 및 게스트 접근을 분석합니다. |
| **구성 관리** | 암호화된 자격 증명 저장, 자동 연결, 맞춤형 내보내기 경로 및 구성 백업/복원을 지원합니다. |
| **Teams 채널 멤버십 변경** | 모든 Teams 채널의 현재 멤버십(사용자 및 게스트 포함)을 보고합니다. |
| **SharePoint 사이트 저장소 사용량** | 모든 SharePoint 사이트의 저장소 사용량을 보고하며 할당량 및 사용 추세를 강조합니다. |
| **Azure 리소스 태그 컴플라이언스** | 필수 태그 및 태그 정책 준수 여부에 대해 Azure 리소스를 감사합니다. |
| **OneDrive 공유 링크 감사** | OneDrive 공유 링크를 감사하며 외부 공유 파일 및 접근 수준을 보고합니다. |

### 📈 향상된 보고
- 5개의 새로운 타임스탬프가 포함된 CSV 보고서
- 위험 기반 점수 매기기 (치명적/높음/중간/낮음)
- 각 발견 사항에 대한 보안 권고사항
- 경영진 요약 대시보드

  
## 🌟 주요 기능

### 🔐 Azure 보안 감사
- **아이덴티티 및 접근 관리 (IAM)**
  - 다중 인증(MFA) 상태 분석
  - 게스트 사용자 접근 검토 및 보고
  - 비밀번호 만료 정책 평가
  - 조건부 접근 정책 평가

- **🛡️ 데이터 보호**
  - Azure VM TLS 구성 분석 (Azure Resource Graph)
  - 가상 머신 디스크 암호화 상태
  - 보안 컴플라이언스 보고

- **🏗️ 인프라 보안**
  - Azure 저장소 계정 보안 구성
  - 공개 블롭 컨테이너 감지
  - Azure Key Vault 보안 평가
  - 인증서 만료 모니터링
  - 네트워크 보안 그룹(NSG) 분석
  - 위험한 방화벽 규칙 탐지
  - Azure 리소스 태그 컴플라이언스: 필수 태그 및 준수 여부 감사

### ☁️ Office 365 보안 감사
- **📊 라이선스 관리**
  - 종합 라이선스 사용 분석
  - 비용 최적화 권고
  - 미할당 라이선스 탐지 및 보고

- **👤 사용자 계정 보안**
  - 비활성 계정 탐지 (90일 이상)
  - 라이선스 보유 비활성 계정 식별
  - 보안 위험 평가

- **📧 이메일 보안**
  - 사서함 전달 규칙 분석
  - 외부 이메일 전달 탐지
  - Exchange Online 보안 평가

- **👥 Microsoft Teams 보안**
  - 외부 접근 구성 검토
  - 외부 사용자/게스트가 있는 Teams 보고
  - Teams 보안 상태 평가
  - Teams 채널 멤버십 변경: 모든 Teams 채널의 현재 멤버십 보고

- **📁 SharePoint 및 OneDrive 보안**
  - SharePoint 공유 설정 분석
  - SharePoint 사이트 저장소 사용량: 모든 SharePoint 사이트 저장소 사용량 보고
  - OneDrive 사용 및 보안 모니터링
  - 데이터 손실 방지(DLP) 정책 안내
  - 외부 공유 탐지
  - OneDrive 공유 링크 감사: 외부 공유 파일 및 접근 수준 감사

### ⚙️ 구성 관리
- **설정 및 자격 증명 저장**
  - Azure 서비스 주체 구성
  - 자동화를 위한 안전한 자격 증명 저장
  - 자동 연결 기능
  - 맞춤형 내보내기 경로
  - 구성 관리

---
### 읽기 전용 작업
- ✅ Azure 또는 Office 365 구성에 **전혀 변경 없음**
- ✅ **감사 추적** - 모든 작업은 타임스탬프와 함께 기록됨
- ✅ **안전한 인증** - 최신 인증 흐름 사용
- ✅ **최소 권한** - 읽기 권한만 필요함

### 데이터 프라이버시
- 🔒 민감한 데이터 저장 또는 전송 없음
- 🔒 구성 가능한 파일 경로를 가진 로컬 CSV 내보내기
- 🔒 컴플라이언스 감사를 위한 종합 로깅
## 🚀 빠른 시작

---
### 사전 요구 사항

PowerShell 7.0 이상이 설치되어 있는지 확인하세요:</translate-content>
```powershell
# Check PowerShell version
$PSVersionTable.PSVersion
```
### 설치

1. **저장소 복제:**

   ```bash
   git clone https://github.com/SteffMet/Azure-Office365-Security-Reporting.git
   cd Azure-Office365-Security-Reporting
   ```
2. **런처 스크립트 실행 (권장):**

   ```powershell
   .\Start-AzureSecurityReport.ps1
   ```
<translate-content>   
   **또는 직접 실행:**</translate-content>
   ```powershell
   # Modular version (recommended)
   .\AzureSecurityReport-Modular.ps1
   ```
## 🔑 필수 권한

### Azure AD 역할
- **권장**: 전체 관리자 읽기 권한 또는 보안 읽기 권한
- **최소**: 디렉터리 읽기 권한 + 특정 객체 권한

### Azure 구독 권한
- **스토리지 보안**: 스토리지 계정 기여자 (읽기 전용)
- **키 자격 증명 보안**: 키 자격 증명 읽기 권한자
- **네트워크 보안**: 네트워크 기여자 (읽기 전용)
- **가상 머신 보안**: 가상 머신 기여자 (읽기 전용)

### Microsoft Graph API 권한

```
User.Read.All
Directory.Read.All
Policy.Read.ConditionalAccess
UserAuthenticationMethod.Read.All
Organization.Read.All
Reports.Read.All
AuditLog.Read.All
Sites.Read.All
```
### Office 365 권한
- **Exchange Online**: 보기 전용 조직 관리
- **Microsoft Teams**: 팀 관리자 (읽기 전용 작업)
- **SharePoint Online**: SharePoint 관리자 (읽기 전용 작업)

--- 
## 🛠️ 문제 해결

### Microsoft Graph 어셈블리 충돌
"동일한 이름의 어셈블리가 이미 로드되었습니다" 오류가 발생하면:

**🔧 빠른 해결 방법:**

1. **런처 스크립트 사용 (권장)**:</translate-content>

   ```powershell
   .\Start-AzureSecurityReport.ps1
   ```
2. **수정 스크립트를 사용하세요**:

   ```powershell
   .\Fix-GraphModules.ps1
   ```
3. **수동 세션 재시작**:</translate-content>

   ```powershell
   # Exit PowerShell completely
   exit
   
   # Start fresh PowerShell 7 session
   pwsh
   cd "path\to\Azure-Office365-Security-Reporting"
   .\AzureSecurityReport-Modular.ps1
   ```
4. **자동 재시작 도우미**:</assistant__(/*!markdown
4. **자동 재시작 도우미**:</markdown>
   ```powershell
   .\Restart-PowerShellSession.ps1
   ```
**🔍 이런 현상이 발생하는 이유:**
Microsoft Graph PowerShell 모듈은 동일 세션에서 여러 번 로드될 때 충돌할 수 있는 .NET 어셈블리를 사용합니다. 이는 Microsoft Graph SDK의 알려진 제한 사항입니다.

### 일반적인 문제

| 문제 | 해결책 |
|-------|----------|
| 모듈 가져오기 오류 | `Install-Module`을 관리자 권한으로 실행 |
| 인증 실패 | 계정 권한을 확인하고 다시 시도 |
| CSV 내보내기 오류 | 파일 경로 권한 확인 |
| Graph API 호출 제한 | 몇 분 후 대기 후 재시도 |

---
<div align="center">

**⭐ 이 프로젝트가 도움이 되었다면, 별을 눌러주세요! ⭐**

❤️ [SteffMet](https://github.com/SteffMet)이 제작

*최종 업데이트: 2025년 6월 28일*

</div>





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---