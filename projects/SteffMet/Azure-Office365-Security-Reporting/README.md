# 🛡️ Azure & Office 365 Security Report

> **A comprehensive PowerShell 7 security auditing tool for Azure and Office 365 environments**

This project provides a modular, read-only security assessment script to help organizations identify security gaps, compliance issues, and cost optimization opportunities across Azure and Office 365 infrastructure.

<div align="center">
  
![Menu Layout Demo](https://raw.githubusercontent.com/SteffMet/Azure-Office365-Security-Reporting/main/MenuLayout.gif)
  
</div>

### 🛡️ New Security Reporting Modules
| Module | Description |
|--------|-------------|
| **Azure Storage Security** | Detects public blob containers, validates encryption, checks HTTPS enforcement, and analyzes network access rules. |
| **Azure Key Vault Security** | Monitors certificate expiration, analyzes access policies, validates network restrictions, and checks soft delete/purge protection. |
| **Network Security Groups (NSG)** | Identifies dangerous firewall rules, internet-exposed services, SSH/RDP exposure, and database port security. |
| **SharePoint & OneDrive Security** | Analyzes external sharing, OneDrive usage, Data Loss Prevention (DLP) policies, and guest access. |
| **Configuration Management** | Supports encrypted credential storage, auto-connect, customizable export paths, and configuration backup/restore. |
| **Teams Channel Membership Changes** | Reports current membership of all Teams channels, including users and guests. |
| **SharePoint Site Storage Usage** | Reports storage usage for all SharePoint sites, highlighting quota and usage trends. |
| **Azure Resource Tag Compliance** | Audits Azure resources for required tags and compliance with tagging policies. |
| **OneDrive Sharing Links Audit** | Audits OneDrive sharing links, reporting on externally shared files and access levels. |

### 📈 Enhanced Reporting
- 5 new timestamped CSV reports.
- Risk-based scoring (Critical/High/Medium/Low).
- Security recommendations for each finding.
- Executive summary dashboards.

  
## 🌟 Key Features

### 🔐 Azure Security Auditing
- **Identity & Access Management (IAM)**
  - Multi-Factor Authentication (MFA) status analysis
  - Guest user access review and reporting
  - Password expiry policy assessment
  - Conditional Access policy evaluation

- **🛡️ Data Protection**
  - Azure VM TLS configuration analysis (Azure Resource Graph)
  - Virtual Machine disk encryption status
  - Security compliance reporting

- **🏗️ Infrastructure Security**
  - Azure Storage Account security configuration
  - Public blob container detection
  - Azure Key Vault security assessment
  - Certificate expiration monitoring
  - Network Security Group (NSG) analysis
  - Dangerous firewall rules detection
  - Azure Resource Tag Compliance: Audit resources for required tags and compliance

### ☁️ Office 365 Security Auditing
- **📊 License Management**
  - Comprehensive license usage analysis
  - Cost optimization recommendations
  - Unassigned license detection and reporting

- **👤 User Account Security**
  - Inactive account detection (90+ days)
  - Licensed but inactive account identification
  - Security risk assessment

- **📧 Email Security**
  - Mailbox forwarding rule analysis
  - External email forwarding detection
  - Exchange Online security assessment

- **👥 Microsoft Teams Security**
  - External access configuration review
  - Teams with external users/guests reporting
  - Teams security posture assessment
  - Teams Channel Membership Changes: Report current membership of all Teams channels

- **📁 SharePoint & OneDrive Security**
  - SharePoint sharing settings analysis
  - SharePoint Site Storage Usage: Report storage usage for all SharePoint sites
  - OneDrive usage and security monitoring
  - Data Loss Prevention (DLP) policy guidance
  - External sharing detection
  - OneDrive Sharing Links Audit: Audit externally shared files and access levels

### ⚙️ Configuration Management
- **Settings & Credential Storage**
  - Azure Service Principal configuration
  - Secure credential storage for automation
  - Auto-connect functionality
  - Customizable export paths
  - Configuration management

---
### Read-Only Operations
- ✅ **No modifications** to any Azure or Office 365 configurations
- ✅ **Audit trail** - All actions logged with timestamps
- ✅ **Secure authentication** using modern authentication flows
- ✅ **Least privilege** - Only requires read permissions

### Data Privacy
- 🔒 No sensitive data stored or transmitted
- 🔒 Local CSV exports with configurable file paths
- 🔒 Comprehensive logging for compliance auditing
## 🚀 Quick Start

---
### Prerequisites

Ensure you have PowerShell 7.0+ installed:
```powershell
# Check PowerShell version
$PSVersionTable.PSVersion
```

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/SteffMet/Azure-Office365-Security-Reporting.git
   cd Azure-Office365-Security-Reporting
   ```

2. **Run the launcher script (Recommended):**
   ```powershell
   .\Start-AzureSecurityReport.ps1
   ```
   
   **Or run directly:**
   ```powershell
   # Modular version (recommended)
   .\AzureSecurityReport-Modular.ps1
   ```

## 🔑 Required Permissions

### Azure AD Roles
- **Recommended**: Global Reader or Security Reader
- **Minimum**: Directory Readers + specific object permissions

### Azure Subscription Permissions
- **Storage Security**: Storage Account Contributor (read-only)
- **Key Vault Security**: Key Vault Reader
- **Network Security**: Network Contributor (read-only)
- **VM Security**: Virtual Machine Contributor (read-only)

### Microsoft Graph API Permissions
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

### Office 365 Permissions
- **Exchange Online**: View-Only Organization Management
- **Microsoft Teams**: Teams Administrator (read-only operations)
- **SharePoint Online**: SharePoint Administrator (read-only operations)

--- 
## 🛠️ Troubleshooting

### Microsoft Graph Assembly Conflicts
If you encounter "Assembly with same name is already loaded" errors:

**🔧 Quick Fix Options:**

1. **Use the launcher script (Recommended)**:
   ```powershell
   .\Start-AzureSecurityReport.ps1
   ```

2. **Use the fix script**:
   ```powershell
   .\Fix-GraphModules.ps1
   ```

3. **Manual session restart**:
   ```powershell
   # Exit PowerShell completely
   exit
   
   # Start fresh PowerShell 7 session
   pwsh
   cd "path\to\Azure-Office365-Security-Reporting"
   .\AzureSecurityReport-Modular.ps1
   ```

4. **Automatic restart helper**:
   ```powershell
   .\Restart-PowerShellSession.ps1
   ```

**🔍 Why This Happens:**
Microsoft Graph PowerShell modules use .NET assemblies that can conflict when loaded multiple times in the same session. This is a known limitation of the Microsoft Graph SDK.

### Common Issues

| Issue | Solution |
|-------|----------|
| Module import errors | Run `Install-Module` as Administrator |
| Authentication failures | Verify account permissions and retry |
| CSV export errors | Check file path permissions |
| Graph API rate limits | Wait and retry after a few minutes |

---
<div align="center">

**⭐ If this project helps you, please consider giving it a star! ⭐**

Made with ❤️ by [SteffMet](https://github.com/SteffMet)

*Last Updated: June 28, 2025*

</div>


