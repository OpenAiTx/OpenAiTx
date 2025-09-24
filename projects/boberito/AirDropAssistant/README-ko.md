<div id="header" align="center">
  <img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/icon.png"/>
</div>

Air Drop Assistant (ADA)는 일반 MDM 제어보다 AirDrop 설정을 더 세밀하게 제어할 수 있게 해줍니다.

iOS에서는 AirDrop을 모두에게로 전환하면 10분 후에 연락처만으로 다시 전환됩니다.

macOS에서는 AirDrop이 꺼짐, 연락처만, 모두에게 중 하나이며, 이 설정은 시스템 설정 > 일반 > AirDrop 및 Handoff 또는 제어 센터 메뉴 항목에서 수동으로 전환해야 합니다.

ADA를 사용하면 AirDrop이 연락처만 또는 꺼짐으로 전환되는 시점과 시간 프레임을 설정할 수 있습니다.

이 기능이 왜 필요할까요?
- 공공장소에서 컴퓨터를 자주 사용하며 AirDrop이 모두에게 열려 있는 상태로 두고 싶지 않을 때
- 조직에서 AirDrop 사용을 허용하지만 Apple의 기기 관리 기능보다 더 세밀한 제어를 원할 때


<div align="center">
    <img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/adamenu.png" /><img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/adaprefs.png" />
</div>

ADA는 MDM에서 배포하는 구성 프로파일로 설정할 수 있습니다.

**도메인** `com.ttinc.Air-Drop-Assistant`

`airDropSetting` - **유형: 문자열**
허용 값: **Contacts Only** 또는 **Off**
- 설정 시 ADA는 타이머 후에 AirDrop을 해당 설정으로 전환하도록 고정됩니다.

`timing` - **유형: 정수**
허용 값: **0-1000**
- ADA가 AirDrop을 `airDropSetting` 값으로 전환하기 전까지의 시간 길이

`hideMenuIcon` - **유형: 불리언**
허용 값: **true** 또는 **false**
- 메뉴 바 아이콘 숨기기

`icon_mode` - **유형: 문자열**
허용 값: **colorful** 또는 **bw**
- 아이콘을 컬러 또는 흑백으로 표시합니다.
`afterFirstLaunch` - **유형: Boolean**  
허용 값: **true** 또는 **false**  
- 첫 실행 질문을 숨깁니다.  

`disableUpdates` - **유형: Boolean**  
허용 값: **true** 또는 **false**  
- 실행 시 업데이트 확인을 비활성화하고 확인 메뉴 항목을 숨깁니다.  

ADA는 또한 register 인수를 사용하여 로그인 시 로드되도록 등록할 수 있으며 로그인 항목에서 제거할 수도 있습니다.  

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/MacOS/Air\ Drop\ Assistant --register`  

및  

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/MacOS/Air\ Drop\ Assistant --unregister`  

ADA AirDrop 방향 제한은 MDM으로 구성할 수 있습니다.  

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/Resources/ADA_PF_Helper_Script.sh -argument`  

- `-blockOut` 은 나가는 AirDrop을 차단합니다  
- `-blockIn` 은 들어오는 AirDrop을 차단합니다  
- `-remove` 은 양방향 AirDrop을 허용합니다  

예시 mobileconfig

```
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
    <key>PayloadContent</key>
    <array>
        <dict>
            <key>PayloadIdentifier</key>
            <string>ccom.ttinc.Air-Drop-Assistant.26F7424C-FEF3-4E94-8E78-2673B2B8CDD3</string>
            <key>PayloadType</key>
            <string>com.ttinc.Air-Drop-Assistant</string>
            <key>PayloadUUID</key>
            <string>26F7424C-FEF3-4E94-8E78-2673B2B8CDD3</string>
            <key>PayloadVersion</key>
            <integer>1</integer>
            <key>airDropSetting</key>
            <string>Contacts Only</string>
            <key>timing</key>
            <integer>5</integer>
            <key>hideMenuIcon</key>
            <true/>
            <key>icon_mode</key>
            <string>colorful</string>
            <key>afterFirstLaunch</key>
            <true/>
        </dict>
    </array>
    <key>PayloadDescription</key>
    <string>ADA Settings</string>
    <key>PayloadDisplayName</key>
    <string>ADA</string>
    <key>PayloadIdentifier</key>
    <string>com.ttinc.Air-Drop-Assistant</string>
    <key>PayloadOrganization</key>
    <string>BOB</string>
    <key>PayloadScope</key>
    <string>System</string>
    <key>PayloadType</key>
    <string>Configuration</string>
    <key>PayloadUUID</key>
    <string>1BBD23DE-7ED7-45DF-8126-5085A681ED83</string>
    <key>PayloadVersion</key>
    <integer>1</integer>
</dict>
</plist>
```
알림 구성을 위해 이러한 키를 포함하는 `com.apple.notificationsettings` 프로필을 생성해야 합니다

```
<!--- THIS KEY IS REQUIRED TO IDENTIFY WHAT APP -->
<key>BundleIdentifier</key>
	<string>com.ttinc.Air-Drop-Assistant</string>

<!--- IF YOU WANT ZERO NOTIFICATIONS SET THESE TWO TO FALSE -->
<key>NotificationsEnabled</key>
	<true/>
<key>CriticalAlertEnabled</key>
	<false/>

<!--- THIS CAN BE SET TO 0 (Off), 1 (Temporary), 2 (Persistent) -->
<key>AlertType</key>
	<integer>1</integer>
				
<key>ShowInLockScreen</key>
	<true/>
<key>ShowInNotificationCenter</key>
	<true/>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-24

---