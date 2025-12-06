# Azure-Runbooks 

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![PowerShell](https://img.shields.io/badge/PowerShell-7.2+-blue.svg)](https://github.com/PowerShell/PowerShell)
[![Microsoft 365](https://img.shields.io/badge/Microsoft_365-compatible-brightgreen.svg)](https://www.microsoft.com/microsoft-365)
[![Graph API](https://img.shields.io/badge/Microsoft_Graph-v1.0-blue.svg)](https://developer.microsoft.com/en-us/graph)
[![Azure](https://img.shields.io/badge/Azure_Automation-compatible-0089D6.svg)](https://azure.microsoft.com/en-us/products/automation)
[![GitHub release](https://img.shields.io/github/release/sargeschultz11/Azure-Runbooks.svg)](https://GitHub.com/sargeschultz11/Azure-Runbooks/releases/)
[![Maintenance](https://img.shields.io/badge/Maintained-yes-green.svg)](https://github.com/sargeschultz11/Azure-Runbooks)
[![Made with](https://img.shields.io/badge/Made%20with-PowerShell-1f425f.svg)](https://www.microsoft.com/powershell)

A collection of Azure Automation runbooks for Microsoft 365 and Intune management.

## Overview

This repository contains PowerShell scripts designed to be used as Azure Automation runbooks for automating various Microsoft 365 and Intune management tasks. These scripts help streamline administrative processes, maintain consistency across your environment, and reduce manual overhead.

## Repository Structure

The repository is organized into folders, with each folder containing a specific runbook solution:

```
Azure-Runbooks/
├── DeviceCategorySync/             # Sync device categories with user departments
├── Report-DiscoveredApps/          # Generate reports of discovered applications
├── Report-IntuneDeviceCompliance/  # Generate device compliance reports
├── Report-DevicesWithApp/          # Find devices with specific applications
├── Alert-DeviceSyncReminder/       # Send reminders for devices needing sync
├── Update-AutopilotDeviceGroupTags/ # Sync Autopilot group tags with Intune categories
├── Alert-IntuneAppleTokenMonitor/  # Monitor Apple token expirations
├── Report-UserManagers/            # Generate reports of users and their managers
├── Report-MissingSecurityUpdates/  # Report on devices missing security updates
├── Sync-IntuneDevices/             # Force sync all managed Intune devices
├── Report-DeviceSyncOverdue/       # Report on devices overdue for sync
├── Report-OneDriveSharedItems/     # Generate reports of shared items in OneDrive
├── Task-SetCompanyAttribute/       # Set company attribute for all users
├── Snipe-IT-UserSync/              # Sync Microsoft 365 users to Snipe-IT users
├── Sync-IntuneToAction1Categories/ # Sync Intune device categories to Action1 custom attributes
```
각 런북 폴더에는 다음이 포함되어 있습니다:  
- 메인 PowerShell 스크립트(`.ps1`)  
- 권한 설정을 위한 보조 스크립트(`Add-GraphPermissions.ps1`)  
- 상세 문서(`README.md`)  

## 인증  

이 저장소의 모든 런북은 Azure Automation의 시스템 할당 관리 ID(System-Assigned Managed Identity)를 사용하도록 설계되었으며, 이는 Azure Automation에서 권장되는 인증 방식입니다. 각 폴더에는 자동화 계정의 관리 ID에 필요한 Microsoft Graph API 권한을 할당하는 데 도움을 주는 `Add-GraphPermissions.ps1` 스크립트가 포함되어 있습니다.  

## 시작하기  

각 런북은 구현 및 사용에 대한 상세 문서를 포함하고 있습니다. 일반적으로 이 런북을 사용하려면:  

1. 스크립트를 Azure Automation 계정에 가져옵니다  
2. 자동화 계정에서 시스템 할당 관리 ID를 활성화합니다  
3. 포함된 `Add-GraphPermissions.ps1` 스크립트를 사용하여 필요한 Graph API 권한을 할당합니다  
4. 환경에 맞는 필요한 매개변수를 구성합니다  
5. 런북을 예약하거나 필요에 따라 즉시 실행합니다  

## 사용 가능한 런북  

### 보고서  
- **장치 준수 보고서**: Intune 관리 장치에 대한 포괄적인 준수 보고서를 생성합니다.  
- **발견된 앱 보고서**: 관리되는 장치에서 발견된 애플리케이션의 상세 보고서를 생성합니다.  
- **특정 앱이 설치된 장치 보고서**: 특정 애플리케이션이 설치된 모든 장치를 식별합니다.  
- **사용자 관리자 보고서**: 라이선스가 있는 내부 사용자와 그들의 관리자 정보를 포함한 보고서를 생성합니다.  
- **보안 업데이트 누락 보고서**: 여러 보안 업데이트가 누락된 Windows 장치를 식별하고 자동 보고합니다.  
- **장치 동기화 지연 보고서**: 지정된 임계값 내에서 동기화되지 않은 장치의 보고서를 생성합니다.  
- **OneDrive 공유 항목 보고서**: OneDrive for Business에서 외부에 공유된 항목의 보고서를 생성합니다.  

### 장치 관리  
- **장치 카테고리 동기화**: 사용자 부서 정보를 기반으로 Intune 장치 카테고리를 자동으로 동기화합니다.  
- **Autopilot 그룹 태그 동기화**: Intune 장치 카테고리와 Autopilot 장치 그룹 태그를 동기화 상태로 유지합니다.  
- **장치 동기화 강제 실행**: 배치 및 제한 보호 기능을 통해 모든 관리되는 Intune 장치에 동기화 명령을 시작합니다.  
- **Intune에서 Action1 카테고리 동기화**: 일련 번호를 일치시켜 Intune 장치 카테고리를 Action1 사용자 지정 속성에 동기화합니다.  

### 알림 및 통지  
- **장치 동기화 알림**: 최근에 동기화하지 않은 사용자에게 자동 이메일 알림을 전송합니다.  
- **Apple 토큰 모니터**: Apple 푸시 알림 인증서 및 토큰 만료를 모니터링하고 알림을 보냅니다.  

### 사용자 관리
- **회사 속성 설정**: Microsoft 365 테넌트 내 모든 사용자 계정에 일관된 회사 속성을 설정합니다.
- **Snipe-IT 사용자 동기화**: 이메일을 기준으로 Microsoft 365 테넌트에서 Snipe-IT 사용자를 생성하거나 업데이트하며, 새 사용자에게는 안전한 비밀번호를 설정하고 로그인/초대 옵션을 선택할 수 있습니다.

### 타사 통합
- **Action1 통합**: Intune 장치 카테고리를 Action1 RMM 사용자 정의 속성에 동기화하여 플랫폼 간 통합 장치 관리를 지원합니다.

## 브랜치 관리

이 저장소는 간소화된 Git 워크플로우를 따릅니다:

- `main` 브랜치는 안정적이며 프로덕션 준비가 완료된 스크립트를 포함합니다
- 새로운 기능 또는 주요 수정 작업을 위해 개발 브랜치가 생성됩니다
- 개발 작업이 `main`에 병합되면 개발 브랜치는 일반적으로 삭제됩니다
- 이 저장소를 클론한 사용자는 작업 완료 후 개발 브랜치가 사라질 수 있음을 유념하세요

특정 개발 브랜치에서 작업 중이라면, 브랜치 삭제 시 작업에 영향을 받지 않도록 자신의 포크를 생성하는 것을 고려하세요.

## v1.4.0의 신규 기능

### 신규 런북: Sync-IntuneToAction1Categories
이번 릴리스는 Action1 RMM과의 새로운 통합을 도입하여 Intune 장치 카테고리를 Action1 사용자 정의 속성으로 자동 동기화할 수 있습니다. 주요 기능은 다음과 같습니다:

- 일련번호를 사용하여 Intune과 Action1 간 장치 자동 매칭
- Intune 장치 카테고리를 구성 가능한 Action1 사용자 정의 속성에 동기화
- 여러 Action1 지역(북미, 유럽, 호주) 지원
- Azure Automation 암호화 변수로 안전한 자격 증명 관리
- 변경 없이 테스트 가능한 WhatIf 모드
- 포괄적인 로깅 및 통계 제공
- PSAction1 PowerShell 모듈 기반 구축

이 통합은 조직이 Microsoft Intune과 Action1 RMM 플랫폼 모두에서 일관된 장치 분류를 유지하도록 도와주어, 더 나은 보고, 정책 적용 및 장치 관리 워크플로우를 가능하게 합니다.

## 토론

이 저장소에 GitHub Discussions를 활성화하여 사용자 간 협업과 지원을 촉진하고 있습니다. 다음과 같은 내용을 논의하기에 가장 적합한 장소입니다:

* 특정 런북 구현에 관한 질문
* 성공 사례 및 구현 경험 공유

* 새로운 런북 아이디어나 개선 사항 제안
* Azure Automation 모범 사례 논의
* 문제 해결 지원 받기

대화에 참여하려면 [Discussions](https://github.com/sargeschultz11/Azure-Runbooks/discussions) 탭을 확인하세요. 일반 질문과 커뮤니티 상호작용은 Discussions를 사용하시고, 버그 신고나 스크립트의 특정 문제는 Issues를 사용하시길 권장합니다.

## 기여

이 스크립트들을 자신의 자동화 필요에 맞춘 출발점으로 자유롭게 사용하세요. 기여, 개선 및 제안은 언제나 환영합니다!

## 라이선스

이 프로젝트는 MIT 라이선스 하에 배포됩니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-06

---