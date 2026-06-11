# MDE-troubleshooter
# 정보

이 도구는 로컬 엔드포인트에서 Defender for Endpoint 관련 문제를 분석하는 데 도움을 주기 위해 설계되었습니다. 보안 구성, 로그 파일, 업데이트에 대한 중앙 집중식 뷰를 제공하며 Performance Analyzer에 대한 접근을 제공합니다.

이 도구는 초기 버전임을 참고해 주십시오. 버그가 발견되거나 개선 제안이 있으시면 제 GitHub 페이지에 제출해 주시기 바랍니다. 귀하의 피드백과 보고는 매우 소중합니다.

<img width="1482" height="1041" alt="2026-03-09 10_40_30-MDE Troubleshooter v3 0" src="https://github.com/user-attachments/assets/34d80bab-525d-4bf2-ae10-ae8b0c62358d" />



# 전제 조건

스크립트는 모든 설정을 보기 위해 관리자 권한으로 실행되어야 합니다.

# 면책 조항

스크립트는 있는 그대로 제공됩니다. 사용은 사용자 책임입니다. 보증이나 보장은 제공되지 않습니다.

# 연락처
linkedin: https://www.linkedin.com/in/thomasvrhydn/
twitter:  @thomasvrhydn

# 기능  

Defender AV  
버전 정보 — AM 엔진, AM 제품, AM 서비스, NIS 엔진 버전, AM 실행 모드, 컴퓨터 상태  
서비스 상태 — AM 서비스, 안티바이러스, 안티스파이웨어, NIS 활성 상태, 가상 머신 감지, 컴퓨터 ID  
실시간 보호 — 실시간 보호, 접근 시 보호, 동작 모니터, IOAV 보호, 변조 방지 상태 및 출처  
스캔 정보 — 전체 및 빠른 스캔 경과 시간, 시작/종료 시간  
보호 설정 — 클라우드 차단 수준, 최초 발견 시 차단, 클라우드 타임아웃, 격리 정리 일수, 파일 해시 계산, 장치 제어 상태  
추가 정보 — 서명 대체 순서, NIS 서명 마지막 업데이트, 마지막 빠른 스캔 출처  

공격 표면 감소  
ASR 규칙 상태 — 현재 상태(활성화 / 감사 / 경고 / 비활성화)와 함께 19개 ASR 규칙 전체를 보고 상태별 필터링이 가능한 정렬 가능한 DataGrid 팝업  
ASR 규칙별 제외 — 레지스트리(HKLM:\...\Windows Defender Exploit Guard\ASR)에서 읽은 규칙별 및 전역 ASR 제외 목록을 규칙 이름별 필터링과 함께 보기  
익스플로잇 보호 — 익스플로잇 보호 XML 구성 내보내기 및 열기  

제외 항목  
Defender AV 제외 — 구성된 모든 제외 항목(경로, 확장자, 프로세스, IP 주소)을 검색 및 유형 필터링과 함께 팝업 DataGrid에서 보기  
레지스트리 키 정보 — ManagedDefenderProductType, EnrollmentStatus, HideExclusionsFromLocalAdmins, DisableLocalAdminMerge를 표시하며, 변조 방지 검증을 통해 관리 상태를 결정함(Intune 전용, ConfigMgr, 공동 관리 시나리오)  

업데이트  
현재 서명 정보 — AV 서명 버전/연령/최종 업데이트, 안티스파이웨어 서명 버전/연령, NIS 서명 버전  
최신 마이크로소프트 버전 — 비교를 위해 마이크로소프트 웹사이트에서 최신 엔진, 플랫폼, 서명 버전을 가져옴  
업데이트 작업 — UI에서 직접 MpCmdRun.exe를 통해 서명 업데이트를 트리거함  

로그  
SENSE 로그 — 텍스트 및 수준(정보/경고/오류)별 필터링과 선택 항목에 대한 세부 정보 창이 있는 EDR 센서 이벤트 로그(Microsoft-Windows-SENSE/Operational)를 확인  
Defender AV 로그 — 동일한 필터링 및 세부 기능과 함께 바이러스 백신 이벤트 로그(Microsoft-Windows-Windows Defender/Operational)를 확인  

성능  
성능 기록 — 스캔 활동을 ETL 파일에 캡처하는 Defender AV 성능 기록 세션(New-MpPerformanceRecording) 시작  
성능 보고서 — ETL 기록에서 보고서를 생성하며, 보고서 유형 선택 가능: 개요, 상위 10개 파일, 상위 10개 확장자, 상위 10개 프로세스, 상위 10개 스캔(여러 보고서를 별도 창에서 동시에 열 수 있음)  
예상 영향(MPlog) — 최신 MPlog 파일에서 EstimatedImpact 항목을 영향 값별로 정렬하여 높은 영향 스캔 대상을 식별  
클라이언트 분석기 다운로드 — 공식 Microsoft Defender 클라이언트 분석기 도구(MDEClientAnalyzer.zip)를 원하는 폴더에 다운로드  

프록시  
프록시 구성 — Defender에 구성된 현재 프록시 URL 및 프록시 PAC 표시  

방화벽  
프로필 상태 — 도메인, 개인, 공용 방화벽 프로필 설정 보기(사용, 기본 인바운드/아웃바운드 작업, 허용된 로그)  
방화벽 규칙 브라우저 — 검색, 방향, 작업, 사용 상태, 프로필 필터가 가능한 필터링 가능한 DataGrid에서 모든 Windows 방화벽 규칙 보기. 규칙 이름, 포트, 프로토콜, 프로그램 경로 표시  


# 참고 문헌

https://github.com/ugurkocde/Intune/blob/main/Defender%20for%20Endpoint/MDE%20-%20Update%20Tool/MDE_Update_Tool.ps1

https://github.com/directorcia/Office365/blob/master/win10-asr-get.ps1

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/overview-attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction-faq





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-11

---