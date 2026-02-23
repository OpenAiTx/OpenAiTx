# Chrome Debloat

A tool to generate policies for Chromium-based browsers (Chrome, Brave, and Edge) that disable unnecessary features, telemetry, and bloatware while enabling some quality-of-life improvements.

## Features

- Attempts to disable telemetry and usage reporting
- Removes unnecessary features and pre-installed bloatware
- Blocks promotional content and unnecessary UI elements
- Maintains browser functionality while reducing resource usage
- Pre-configures essential extensions:
  - uBlock Origin
  - Cookie AutoDelete
  - Don't f*** with paste
  - I still don't care about cookies
  - SponsorBlock
  - BlockTube
  - BlankTab
  - Decentraleyes

### Supported Browsers

| Browser | Windows | macOS | Linux |
|---------|---------|-------|-------|
| Google Chrome | ✅ | ✅ | ✅ |
| Microsoft Edge | ✅ | ✅ | ✅ |
| Brave | ✅ | ✅ | ✅ |

## Quick Start

### Windows
1.  Download the `.reg` file for your browser from [`generated/windows/`](./generated/windows/).
2.  Open the downloaded `.reg` file to add the settings to the Windows Registry.
3.  Restart your browser or go to `chrome://policy` (or `edge://policy`, `brave://policy`) and click "Reload policies".

### macOS
1.  Download the `.mobileconfig` file for your browser from [`generated/macos/`](./generated/macos/).
2.  Open the downloaded `.mobileconfig` file to start the profile installation.
3.  Go to `System Settings` > `Privacy & Security` > `Profiles` and approve the new profile.
4.  Restart your browser or go to `chrome://policy` (or `edge://policy`, `brave://policy`) and click "Reload policies".

### Linux
1.  Download the `.json` file for your browser from [`generated/linux/`](./generated/linux/).
2.  Move the downloaded file to the correct policy directory (create it if needed):
    *   **Chrome:** `/etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge:** `/etc/opt/edge/policies/managed/edge.json`
    *   **Brave:** `/etc/brave/policies/managed/brave.json`
    *   *Note: You might need `sudo` rights to do this.*
3.  Restart your browser or go to `chrome://policy` (or `edge://policy`, `brave://policy`) and click "Reload policies".

## Custom Configuration

If you want to customize the policies:

1. Clone this repository
2. Install dependencies:
   ```bash
   uv sync
   ```
3. Modify `policies.yaml` according to your needs
4. Generate new configuration files:
   ```bash
   uv run main.py
   ```
5. Find the generated files in `generated/` directory


### Uninstalling Policies

**Windows:**
1.  Navigate to the [`uninstall/windows/`](./uninstall/) directory in this repository.
2.  Run the `.reg` file corresponding to your browser (e.g., `uninstall_chrome.reg`). This will remove the registry keys added during installation.
3.  Restart your browser or go to `chrome://policy` (or `edge://policy`, `brave://policy`) and click "Reload policies".

**macOS:**
1.  Go to `System Settings` > `Privacy & Security` > `Profiles`.
2.  Select the profile associated with your browser (e.g., "Chrome Debloat Policies").
3.  Click the '-' (minus) button to remove the profile.
4.  Restart your browser or go to `chrome://policy` (or `edge://policy`, `brave://policy`) and click "Reload policies".

**Linux:**
1.  Remove the policy JSON file from the browser-specific directory (you might need `sudo` rights):
    *   **Chrome:** `sudo rm /etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge:** `sudo rm /etc/opt/edge/policies/managed/edge.json`
    *   **Brave:** `sudo rm /etc/brave/policies/managed/brave.json`
2.  Restart your browser or go to `chrome://policy` (or `edge://policy`, `brave://policy`) and click "Reload policies".

## Policy Documentation

- [Chrome Enterprise Policies](https://chromeenterprise.google/policies/)
- [Brave Policies](https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy)
- [Microsoft Edge Policies](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies)

## License

[Apache 2.0](./LICENSE)
