<div id="header" align="center">
  <img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/icon.png"/>
</div>

Air Drop Assistant (ADA) te ofrece un control más granular sobre tus ajustes de AirDrop que los controles normales de MDM.

En iOS, al cambiar AirDrop a Todos, vuelve a Contactos solamente después de 10 minutos.

En macOS, AirDrop está ya sea Apagado, Solo Contactos o Todos, un ajuste que debes cambiar manualmente a través de Configuración del Sistema > General > AirDrop y Handoff o desde el menú del Centro de Control.

ADA te permite configurar si AirDrop pasa a Solo Contactos o Apagado y el intervalo de tiempo para cambiarlo.

¿Por qué podrías querer esta función?
- Usas tu computadora frecuentemente en espacios públicos y no quieres que AirDrop quede abierto para recibir de Todos.
- Las organizaciones permiten AirDrop pero desean un control más granular que el que ofrece la gestión de dispositivos de Apple.


<div align="center">
    <img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/adamenu.png" /><img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/adaprefs.png" />
</div>

ADA puede configurarse mediante un perfil de configuración desplegado por tu MDM.

**Dominio** `com.ttinc.Air-Drop-Assistant`

`airDropSetting` - **Tipo: Cadena**
Valor aceptable: **Solo Contactos** o **Apagado**
- Cuando se establece, ADA bloqueará para cambiar AirDrop a ese ajuste tras el temporizador.

`timing` - **Tipo: Entero**
Valor aceptable: **0-1000**
- Duración antes de que ADA cambie AirDrop al valor de `airDropSetting`

`hideMenuIcon` - **Tipo: Booleano**
Valor aceptable: **true** o **false**
- Oculta el icono de la barra de menú

`icon_mode` - **Tipo: Cadena**
Valor aceptable: **colorido** o **blanco y negro**
- Hace que el icono sea colorido o monocromo.
`afterFirstLaunch` - **Tipo: Booleano**  
Valor Aceptable: **true** o **false**  
- Oculta la pregunta del primer lanzamiento.  

`disableUpdates` - **Tipo: Booleano**  
Valor Aceptable: **true** o **false**  
- Desactiva la comprobación de actualizaciones al iniciar y oculta el elemento del menú para comprobarlas.  

ADA también puede registrarse para cargarse al inicio de sesión con el argumento register y eliminarse de los elementos de inicio.  

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/MacOS/Air\ Drop\ Assistant --register`  

y  

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/MacOS/Air\ Drop\ Assistant --unregister`  

La restricción direccional de ADA AirDrop puede ser configurada por MDM.  

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/Resources/ADA_PF_Helper_Script.sh -argument`  

- `-blockOut` bloquea AirDrop saliente  
- `-blockIn` bloquea AirDrop entrante  
- `-remove` permite AirDrop en ambas direcciones  

Ejemplo mobileconfig

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
Para configurar las notificaciones, querrá crear un perfil `com.apple.notificationsettings` que incluya estas claves

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