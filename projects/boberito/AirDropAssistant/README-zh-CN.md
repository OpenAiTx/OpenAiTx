<div id="header" align="center">
  <img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/icon.png"/>
</div>

Air Drop Assistant (ADA) 比普通的 MDM 控制提供了更细粒度的 AirDrop 设置控制。

在 iOS 上，当将 AirDrop 切换到“所有人”时，10 分钟后会自动切换回“仅联系人”。

在 macOS 上，AirDrop 只能设置为关闭、仅联系人或所有人——您必须通过“系统设置 > 通用 > AirDrop 与接力”或控制中心菜单手动切换。

ADA 允许您设置 AirDrop 是否切换回“仅联系人”或关闭，以及切换的时间范围。

为什么您可能需要此功能？
- 您经常在公共场所使用电脑，不希望 AirDrop 设置为对所有人开放接收。
- 组织允许使用 AirDrop，但希望比苹果设备管理提供的控制更细致。

<div align="center">
    <img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/adamenu.png" /><img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/adaprefs.png" />
</div>

ADA 可以通过您的 MDM 部署的配置描述文件进行配置。

**域** `com.ttinc.Air-Drop-Assistant`

`airDropSetting` - **类型：字符串**
可接受值：**仅联系人** 或 **关闭**
- 设置后，ADA 会在定时结束后锁定 AirDrop 到该设置。

`timing` - **类型：整数**
可接受值：**0-1000**
- ADA 切换 AirDrop 到 `airDropSetting` 值之前的时间长度。

`hideMenuIcon` - **类型：布尔**
可接受值：**true** 或 **false**
- 隐藏菜单栏图标。

`icon_mode` - **类型：字符串**
可接受值：**colorful** 或 **bw**
- 使图标显示为彩色或黑白。

`afterFirstLaunch` - **类型：布尔值**  
可接受值：**true** 或 **false**  
- 隐藏首次启动时的问题。  

`disableUpdates` - **类型：布尔值**  
可接受值：**true** 或 **false**  
- 禁用启动时的更新检查并隐藏检查菜单项。  

ADA 也可以通过参数 register 注册为登录时加载，并且可以从登录项中移除。  

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/MacOS/Air\ Drop\ Assistant --register`  

和  

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/MacOS/Air\ Drop\ Assistant --unregister`  

MDM 可以配置 ADA AirDrop 的方向限制。  

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/Resources/ADA_PF_Helper_Script.sh -argument`  

- `-blockOut` 阻止发出 AirDrop  
- `-blockIn` 阻止接收 AirDrop  
- `-remove` 允许双向 AirDrop  

示例 mobileconfig

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

要配置通知，您需要创建一个包含这些键的 `com.apple.notificationsettings` 配置文件
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