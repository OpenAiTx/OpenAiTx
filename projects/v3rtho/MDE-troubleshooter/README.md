# MDE-troubleshooter
# INFO

This tool is designed to assist you in analyzing issues related to Defender for Endpoint on your local endpoint. It offers a centralized view of the security configuration, log files, updates, and provides access to the Performance Analyzer.

Please note that this is the initial version of the tool. If you encounter any bugs or have suggestions for enhancements, I encourage you to submit them on my GitHub page. Your feedback and reports are greatly appreciated.

<img width="1482" height="1041" alt="2026-03-09 10_40_30-MDE Troubleshooter v3 0" src="https://github.com/user-attachments/assets/34d80bab-525d-4bf2-ae10-ae8b0c62358d" />



# Prerequisites

Script need to run as admin to view all settings.

# Disclaimer

Script provided as is. Use at own risk. No guarantees or warranty provided.

# Contact
linkedin: https://www.linkedin.com/in/thomasvrhydn/
twitter:  @thomasvrhydn

# Features  

Defender AV  
Version Information — AM Engine, AM Product, AM Service, NIS Engine versions, AM Running Mode, Computer State  
Service Status — AM Service, Antivirus, Antispyware, NIS enabled states, Virtual Machine detection, Computer ID  
Real-Time Protection — RealTime Protection, OnAccess Protection, Behavior Monitor, IOAV Protection, Tamper Protection status and source  
Scan Information — Full and Quick scan age, start/end times  
Protection Settings — Cloud Block Level, Block at First Seen, Cloud Timeout, Quarantine purge days, File Hash Computation, Device Control state  
Additional Information — Signature Fallback Order, NIS Signature last updated, Last Quick Scan source   

Attack Surface Reduction  
ASR Rules Status — View all 19 ASR rules with their current state (Enabled / Audit / Warning / Not Enabled), with filtering by status in a sortable DataGrid popup  
ASR Per-Rule Exclusions — View per-rule and global ASR exclusions read from the registry (HKLM:\...\Windows Defender Exploit Guard\ASR), with filtering by rule name  
Exploit Protection — Export and open the Exploit Protection XML configuration  

Exclusions  
Defender AV Exclusions — View all configured exclusions (Path, Extension, Process, IP Address) with search and type filtering in a popup DataGrid  
Registry Key Information — Shows ManagedDefenderProductType, EnrollmentStatus, HideExclusionsFromLocalAdmins, DisableLocalAdminMerge, and determines management status with tamper protection validation (Intune-only, ConfigMgr, Co-managed scenarios)  

Updates  
Current Signature Information — AV Signature version/age/last updated, Antispyware Signature version/age, NIS Signature version  
Latest Microsoft Versions — Fetches the latest Engine, Platform, and Signature versions from Microsoft's website for comparison  
Update Actions — Trigger a signature update via MpCmdRun.exe directly from the UI  

Logs  
SENSE Logs — View EDR sensor event logs (Microsoft-Windows-SENSE/Operational) with filtering by text and level (Information/Warning/Error), plus a detail pane for selected entries  
Defender AV Logs — View antivirus event logs (Microsoft-Windows-Windows Defender/Operational) with the same filtering and detail capabilities  

Performance  
Performance Recording — Start a Defender AV performance recording session (New-MpPerformanceRecording) that captures scan activity to an ETL file  
Performance Reports — Generate reports from ETL recordings with selectable report types: Overview, Top 10 Files, Top 10 Extensions, Top 10 Processes, Top 10 Scans (multiple reports open simultaneously in separate windows)  
Estimated Impact (MPlog) — Parse the latest MPlog file for EstimatedImpact entries, sorted by impact value, to identify high-impact scan targets  
Client Analyzer Download — Download the official Microsoft Defender Client Analyzer tool (MDEClientAnalyzer.zip) to a folder of your choice  

Proxy  
Proxy Configuration — Displays the current Proxy URL and Proxy PAC configured for Defender  

Firewall  
Profile Status — View Domain, Private, and Public firewall profile settings (Enabled, Default Inbound/Outbound Action, Log Allowed)  
Firewall Rules Browser — View all Windows Firewall rules in a filterable DataGrid with search, direction, action, enabled state, and profile filters. Shows rule name, ports, protocol, and program path  


# References

https://github.com/ugurkocde/Intune/blob/main/Defender%20for%20Endpoint/MDE%20-%20Update%20Tool/MDE_Update_Tool.ps1

https://github.com/directorcia/Office365/blob/master/win10-asr-get.ps1

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/overview-attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction-faq



