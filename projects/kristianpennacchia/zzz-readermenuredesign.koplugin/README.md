# zzz-readermenuredesign.koplugin

A redesign of the various reader menus in KOReader, including the Dictionary Quick Lookup popup and Reader Highlight menu.

<p align="left">
  <img src="https://github.com/user-attachments/assets/2d82282a-96c9-43b7-aaea-fb27a74d2f52" width=45%>
</p>

Includes an option to show 'unknown' buttons (buttons not changed by this plugin) in the Reader Highlight menu:

<p align="left">
  <img src="https://github.com/user-attachments/assets/162b8b8c-c6b5-4149-a8d9-b5e9bbeb64dd" width=45%>
  <img src="https://github.com/user-attachments/assets/9dbfec8c-88e0-4b91-9f13-7eb50f1f881c" width=45%>
</p>

This plugin also provides custom UI for other plugins, such as [WordReference plugin](https://github.com/kristianpennacchia/wordreference.koplugin) and [AI Assistant plugin](https://github.com/omer-faruq/assistant.koplugin).

<p align="left">
  <img src="https://github.com/user-attachments/assets/2a99493d-d86d-44f0-813f-4ee4ef1cd606" width=30%>
  <img src="https://github.com/user-attachments/assets/6c5650b4-6718-4b9b-8a0e-2cd8a6ed4f47" width=30%>
</p>

## Install

- Download the [latest release](https://github.com/kristianpennacchia/zzz-readermenuredesign.koplugin/releases/latest).
- Unzip `zzz-readermenuredesign.koplugin.zip`.
- Copy the `zzz-readermenuredesign.koplugin` folder to your KOReader `plugins` directory on the device.
- Restart KOReader.

#### Troubleshooting

- **All of the icons are hazard (⚠️) symbols.**
    - As of version v1.0.5, the icons should be installed automatically, however if you are still encountering this issue, try manually copying the icons from the `zzz-readermenuredesign.koplugin` folder and putting them into the KOReader icons folder `/koreader/resources/icons`.

- **Icons are not showing at all**.
    - This can happen on some devices with older versions of this plugin. Try deleting this plugins SVG icons from `/koreader/resources/icons/mdlight` and replace them with the PNG icons from the [latest release](https://github.com/kristianpennacchia/zzz-readermenuredesign.koplugin/releases/latest), then **restart KOReader**.

## Settings

- Reader Highlight menu:
    - Open Menu → Tools 🛠️ → More tools → Reader Menu Redesign → Show Unknown Buttons In Reader Highlight Menu.
    - This will toggle showing/hiding the 'unknown' buttons (buttons without special handling in this plugin) in the Reader Highlight menu.
- Dict Quick Lookup:
    - Open Menu → Tools 🛠️ → More tools → Reader Menu Redesign → Show Nav Buttons In Dict Quick Lookup.
    - This will toggle showing/hiding the 'nav' buttons in the Dict Quick Lookup to navigate between dictionaries, wikipedia entires, etc.
    - Alternatively: You can simply swipe left-to-right to navigate instead, but these buttons are more useful for PC/Mac.
