<p align="center">
  <img src="https://raw.githubusercontent.com/kayasax/EasyPIM/main/docs/assets/logo_transparent.svg" alt="EasyPIM 로고" width="180">
  <h1 align="center">🛡️ EasyPIM</h1>
  <p align="center">
    <strong>Azure 특권 ID 관리용 PowerShell 자동화 도구입니다.</strong>
  </p>
  <p align="center">
    <a href="https://www.powershellgallery.com/packages/EasyPIM"><img src="https://img.shields.io/powershellgallery/v/easypim?label=Core&logo=powershell&color=blue" alt="Core 버전"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM.Orchestrator"><img src="https://img.shields.io/powershellgallery/v/EasyPIM.Orchestrator?label=Orchestrator&logo=powershell&color=blue" alt="Orchestrator 버전"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM"><img src="https://img.shields.io/powershellgallery/dt/easypim?label=Core%20Downloads&color=green" alt="Core 다운로드 수"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM.Orchestrator"><img src="https://img.shields.io/powershellgallery/dt/EasyPIM.Orchestrator?label=Orchestrator%20Downloads&color=green" alt="Orchestrator 다운로드 수"></a>
    <a href="https://github.com/kayasax/EasyPIM/stargazers"><img src="https://img.shields.io/github/stars/kayasax/EasyPIM?style=social" alt="GitHub 별"></a>
    <a href="https://github.com/kayasax/EasyPIM/blob/main/LICENSE"><img src="https://img.shields.io/github/license/kayasax/EasyPIM" alt="라이선스"></a>
  </p>
</p>

---

역할 정책을 대량 강화하세요. 역할 간 설정을 복제하세요. 할당을 내보내세요. 구성 변화를 감지하세요. 요청을 승인하거나 거부하세요. JSON에서 전체 PIM 모델을 배포하세요.

**Azure 리소스, Entra ID 역할 및 보안 그룹을 아우르는 단일 PowerShell 모듈** — 포털이 제공하지 못하는 cmdlet을 포함합니다. 통합 ARM 및 Graph API, 50개 이상의 명령어, 4개의 Azure 클라우드 지원.

> 🌐 **여기서 시작하세요 →** **[EasyPIM 도입 허브](https://kayasax.github.io/EasyPIM/)**에서 설치부터 엔터프라이즈급 PIM 거버넌스까지 세 단계로 안내합니다.

## 🚀 빠른 시작

```powershell
Install-Module EasyPIM, EasyPIM.Orchestrator -Force

# Harden 3 Entra roles in one shot — try that in the portal
Set-PIMEntraRolePolicy -TenantID $tenantId `
    -RoleName "Global Administrator","Security Administrator","Exchange Administrator" `
    -ActivationRequirement "Justification","Ticketing","MultiFactorAuthentication" `
    -ActivationDuration "PT4H"

# Audit every eligible assignment across a subscription
Get-PIMAzureResourceEligibleAssignment -TenantID $tenantId -SubscriptionId $subId

# Deploy a full PIM model from JSON — Entra + Azure + Groups in one run
Invoke-EasyPIMOrchestrator -TenantId $tenantId -ConfigurationPath "./pim-config.json"
```

---

## ✨ 포털이 할 수 없는 것들

| | |
|---|---|
| ⚡ **역할 일괄 강화** | 한 명령어로 30개 역할에 MFA + 정당성 + 티켓팅 설정 |
| 🔄 **역할 설정 복제** | 강화된 정책을 다른 역할/사용자에게 복사 — 수동 재클릭 불필요 |
| 📊 **내보내기 & 가져오기** | 할당을 CSV로, 전체 구성을 JSON으로 — 몇 초 만에 감사 준비 완료 |
| 🔍 **정책 변동 감지** | 라이브 상태와 선언된 구성 비교, 차이 보고서 제공 |
| 🏢 **CI/CD 거버넌스** | GitHub Actions & Azure DevOps ([이벤트 기반 데모](https://github.com/kayasax/EasyPIM-EventDriven-Governance)) |
| ☁️ **멀티 클라우드** | 퍼블릭, 정부, 중국, 독일 — 어디서나 동일한 cmdlet |
| 🔗 **통합 ARM + Graph** | 하나의 모듈로 두 API 추상화 — 컨텍스트 전환 불필요 |

---

## 📦 설치

```powershell
Install-Module EasyPIM, EasyPIM.Orchestrator -Scope CurrentUser
```
| 요구사항 | 세부사항 |
|---|---|
| PowerShell | 5.1+ 또는 7.0+ |
| 모듈 | `Az.Accounts`, `Microsoft.Graph.Authentication` (자동 설치) |
| Azure 리소스 | 구독에 대한 `소유자` 또는 `사용자 액세스 관리자` 역할 |
| Entra ID / 그룹 | Graph 권한: `RoleManagement.ReadWrite.Directory`, `RoleManagementPolicy.ReadWrite.Directory`, 및 [기타](https://github.com/kayasax/EasyPIM/wiki/Documentation) |

---

## 📖 더 알아보기

| | |
|---|---|
| **[🌐 도입 허브](https://kayasax.github.io/EasyPIM/)** | **3단계 여정: 빠른 시작, 모범 사례, 엔터프라이즈 패턴** |
| [📋 전체 문서](https://github.com/kayasax/EasyPIM/wiki/Documentation) | 심층 가이드 및 API 참조 |
| [🎯 사용 사례 및 예제](https://github.com/kayasax/EasyPIM/wiki/Use-Cases) | 실제 구현 시나리오 |
| [🏗 오케스트레이터 가이드](https://github.com/kayasax/EasyPIM/wiki/Invoke%E2%80%90EasyPIMOrchestrator-step%E2%80%90by%E2%80%90step-guide) | JSON 기반 워크플로우 단계별 안내 |
| [🔄 마이그레이션 v1→v2](https://github.com/kayasax/EasyPIM/wiki/Module-Migration) | v1.x에서 업그레이드 |
| [📝 변경 로그](https://github.com/kayasax/EasyPIM/wiki/Changelog) | 버전 히스토리 |

---

## 🔧 두 개의 모듈, 하나의 플랫폼

| 모듈 | 목적 | 주요 명령어 |
|---|---|---|
| **EasyPIM** (핵심) | 직접 PIM API 관리 — 정책, 할당, 승인 | `Get-PIM*`, `Set-PIM*`, `New-PIM*` |
| **EasyPIM.Orchestrator** | JSON 워크플로우, 드리프트 감지, 비즈니스 규칙, CI/CD | `Invoke-EasyPIMOrchestrator`, `Test-PIMPolicyDrift` |

<details>
<summary>전체 cmdlet 목록 보기 (50개 이상)</summary>

### Azure 리소스 역할

| Cmdlet | 설명 |
|---|---|
| `Get-PIMAzureResourcePolicy` | 역할 정책 설정 가져오기 |
| `Set-PIMAzureResourcePolicy` | 활성화 요구사항, 기간, 승인자 구성 |
| `Get-PIMAzureResourceEligibleAssignment` | 적격 할당 목록 |

| `New-PIMAzureResourceEligibleAssignment` | 적격 할당 생성 |
| `Remove-PIMAzureResourceEligibleAssignment` | 적격 할당 제거 |
| `Get-PIMAzureResourceActiveAssignment` | 활성 할당 목록 |
| `New-PIMAzureResourceActiveAssignment` | 활성 할당 생성 |
| `Remove-PIMAzureResourceActiveAssignment` | 활성 할당 제거 |

### Entra ID 역할

| Cmdlet | 설명 |
|---|---|
| `Get-PIMEntraRolePolicy` | Entra 역할 정책 설정 가져오기 |
| `Set-PIMEntraRolePolicy` | 활성화 요구 사항, MFA, 승인자 구성 |
| `Get-PIMEntraRoleEligibleAssignment` | 적격 할당 목록 |
| `New-PIMEntraRoleEligibleAssignment` | 적격 할당 생성 |
| `Remove-PIMEntraRoleEligibleAssignment` | 적격 할당 제거 |
| `Get-PIMEntraRoleActiveAssignment` | 활성 할당 목록 |
| `New-PIMEntraRoleActiveAssignment` | 활성 할당 생성 |
| `Remove-PIMEntraRoleActiveAssignment` | 활성 할당 제거 |

### 그룹

| Cmdlet | 설명 |
|---|---|
| `Get-PIMGroupPolicy` | 그룹 PIM 정책 설정 가져오기 |
| `Set-PIMGroupPolicy` | 그룹 활성화 요구 사항 구성 |
| `Get-PIMGroupEligibleAssignment` | 적격 그룹 할당 목록 |
| `New-PIMGroupEligibleAssignment` | 적격 그룹 할당 생성 |
| `Remove-PIMGroupEligibleAssignment` | 적격 그룹 할당 제거 |
| `Get-PIMGroupActiveAssignment` | 활성 그룹 할당 목록 |
| `New-PIMGroupActiveAssignment` | 활성 그룹 할당 생성 |
| `Remove-PIMGroupActiveAssignment` | 활성 그룹 할당 제거 |

### 작업 및 유틸리티

| Cmdlet | 설명 |
|---|---|
| `Approve-PIMPendingRequest` | 대기 중인 활성화 요청 승인 |
| `Deny-PIMPendingRequest` | 대기 중인 활성화 요청 거부 |
| `Get-PIMReport` | PIM 활동 분석 및 감사 추적 |
| `Backup-PIMConfiguration` | 전체 PIM 상태 백업 |
| `Restore-PIMConfiguration` | 백업에서 복원 |
| `Copy-PIMRoleSettings` | 역할 간 설정 복제 |
| `Export-PIMAssignment` | 할당을 CSV로 내보내기 |
| `Import-PIMAssignment` | CSV에서 할당 가져오기 |

### Orchestrator

| Cmdlet | 설명 |
|---|---|
| `Invoke-EasyPIMOrchestrator` | JSON에서 전체 PIM 구성 배포 |
| `Test-PIMPolicyDrift` | 선언된 상태에 대한 정책 편차 감지 |
| `Test-PIMEndpointDiscovery` | 연결 및 권한 검증 |

</details>

---

## 🌐 적용 범위

**3개의 PIM 범위**: Azure 리소스(구독, 관리 그룹, 리소스 그룹) · Entra ID 역할 · 보안 그룹

**4개의 클라우드**: 퍼블릭 · 정부 · 중국 · 독일

---

## 🤝 관련 프로젝트

| | |
|---|---|
| **[EasyTCM](https://github.com/kayasax/EasyTCM)** | 테넌트 구성 모니터링 — Entra, Exchange, Intune, Teams 및 컴플라이언스 전반의 구성 편차 감지 |
| **[Event-Driven Governance](https://github.com/kayasax/EasyPIM-EventDriven-Governance)** | 프로덕션 CI/CD 데모: GitHub Actions + Azure DevOps + Event Grid |

---

## 🤝 기여하기

지침은 [CONTRIBUTING.md](https://raw.githubusercontent.com/kayasax/EasyPIM/main/CONTRIBUTING.md)를 참조하세요.

### 기여자들

- **[Loïc MICHEL](https://github.com/kayasax)** — 저자 및 유지 관리자
- **[AzureStackNerd](https://github.com/AzureStackNerd)** — Azure 리소스 할당에 대한 ABAC 조건 지원, 그래프 범위 최적화
- **[Chase Dafnis](https://github.com/CHDAFNI-MSFT)** — 멀티 클라우드 / Azure 환경 지원
- **[jeenvan](https://github.com/jeevanions)** — 오케스트레이터: 배열 형식 및 관리 그룹 범위 수정

---

<p align="center">
  Azure 관리자 커뮤니티를 위해 ❤️로 제작됨<br>
  <strong>저자의 다른 작품: <a href="https://github.com/kayasax/EasyTCM">EasyTCM</a> — M365 테넌트 구성 변동 감지</strong>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---