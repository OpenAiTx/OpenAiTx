<div id="header" align="center">
  <img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/icon.png"/>
</div>

Air Drop Assistant (ADA) は、通常のMDMコントロールよりも詳細にAirDrop設定を管理できます。

iOSでは、AirDropを「全員」に切り替えると、10分後に「連絡先のみ」に戻ります。

macOSでは、AirDropは「オフ」「連絡先のみ」「全員」のいずれかで、システム設定 > 一般 > AirDropとHandoff、またはコントロールセンターのメニューから手動で切り替える必要があります。

ADAを使うと、AirDropを「連絡先のみ」または「オフ」に切り替えるかどうかと、その切り替え時間を設定できます。

なぜこの機能が必要なのか？
- 公共の場で頻繁にコンピュータを使用し、「全員」からの受信を常に開いたままにしたくない場合。
- 組織ではAirDropを許可しているが、Appleのデバイス管理よりも詳細な制御を望む場合。


<div align="center">
    <img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/adamenu.png" /><img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/adaprefs.png" />
</div>

ADAは、MDMによって配布される構成プロファイルで設定できます。

**ドメイン** `com.ttinc.Air-Drop-Assistant`

`airDropSetting` - **タイプ: 文字列**
許容値: **連絡先のみ** または **オフ**
- 設定すると、ADAはタイマー後にAirDropをその設定に切り替えます。

`timing` - **タイプ: 整数**
許容値: **0-1000**
- ADAが`airDropSetting`の値にAirDropを切り替えるまでの時間（秒）

`hideMenuIcon` - **タイプ: ブール値**
許容値: **true** または **false**
- メニューバーのアイコンを非表示にします。

`icon_mode` - **タイプ: 文字列**
許容値: **colorful** または **bw**
- アイコンをカラフルまたはモノクロにします。
`afterFirstLaunch` - **タイプ: ブール値**
許容値: **true** または **false**
- 初回起動時の質問を非表示にします。

`disableUpdates` - **タイプ: ブール値**
許容値: **true** または **false**
- 起動時のアップデートチェックを無効にし、チェックメニュー項目を非表示にします。

ADAは引数registerを使ってログイン時に読み込むよう登録でき、ログイン項目からも削除できます。

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/MacOS/Air\ Drop\ Assistant --register`

および

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/MacOS/Air\ Drop\ Assistant --unregister`

ADAのAirDrop方向制限はMDMによって設定可能です。

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/Resources/ADA_PF_Helper_Script.sh -argument`

- `-blockOut` は送信AirDropをブロックします
- `-blockIn` は受信AirDropをブロックします
- `-remove` は両方向のAirDropを許可します

モバイルコンフィグの例

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
通知の設定を行うには、これらのキーを含む `com.apple.notificationsettings` プロファイルを作成する必要があります

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