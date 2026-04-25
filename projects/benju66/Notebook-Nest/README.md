# NotebookLM Pro Tree

A Chrome extension that transforms Google's NotebookLM from a simple list into a robust Project Management Dashboard.

Stop scrolling through endless flat lists. Organize your sources into nested trees, manage complex projects with advanced tasks, multi-window workflows, and focus with Zen Mode.



## Critical Warnings ⚠️

Uninstalling Deletes Data: This extension uses Local Storage for privacy and speed. If you remove/uninstall the extension, your folders and tasks will be deleted instantly by Chrome.

Solution: Always use the Export button to save a backup JSON file before reinstalling or moving to a new computer.

Google Updates & Reliability: This extension works by "reading" the NotebookLM website. If Google updates their website, this extension may break.

Disclaimer: As this is a free, open-source project maintained in my spare time, I cannot guarantee immediate fixes if Google changes their code. Use this tool as a helpful enhancement, but keep your important data backed up.

## Project Status & Disclaimer 🚧
Please Read: I am a Construction Project Manager, not a professional software developer. I built this tool because I needed it for my own daily workflow.

"Works on My Machine": This update (v17.9) is stable for my personal use, but it has not been battle-tested on every possible browser configuration.

Experimental Features: The multi-window system and DOM observers are complex. You may encounter bugs I haven't seen.

Feedback: If you find a bug, please open an issue on GitHub!

## New in v17.9: The Productivity Suite 🚀
Transformed NotebookLM into a multi-window workspace. This update (consolidating v17.6–v17.9) brings major workflow improvements:

Pop-out Notes: Open any note in a floating window for side-by-side reference while you write. The pop-outs preserve formatting (read-only) and sync with your Light/Dark theme.

Smart Tasks & Quick Capture: Select text in any note to instantly see a "Create Task" button. This creates a task linked directly to that source note.

Advanced Task Management: Organize tasks into Custom Sections (collapsible groups), add Due Dates with quick-select options, and include rich Descriptions.

Graceful Stability: A new self-healing engine that disables specific broken features individually instead of crashing the whole extension if Google updates their code.

## Features
**Productivity & Workflow** 📋 

*   **Multi-Window Workflow** — Click the "Pop-out" icon on any note in the Studio panel to open it in a separate window. Perfect for dual-monitor setups.

*   **Integrated Task Manager** — A complete project management tool built right into the interface:
    *   **Sections:** Group tasks by phase (e.g., "Research," "Drafting," "Review").
    *   **Smart Links:** Tasks created from notes include a "Link" icon that filters your view to the original source.
    *   **Priorities:** Flag tasks (Red/Yellow/Blue) and sort by Priority or Due Date.

*   **"Zen Mode"** — Toggle the UI to hide the AI chat and sidebars for a distraction-free reading/writing studio.


 **Organization** 📂

*   **Nested Folders** — Create deep structures for Sources, Notes, and Generated Artifacts (Audio Overviews, FAQs, etc.).

*   **Pinning** — Keep critical contracts or specs pinned to the top of your lists.

*   **Color Coding** — Assign colors to folders for visual organization.

*   **Bulk Select** — Master checkboxes to select/deselect all sources in a folder or the entire notebook instantly.


**Deep Search** 🔍 

*   **Content Indexing** — Search the actual text inside your notes, not just the titles.

    > **Note:** Indexing happens passively when you open a note.

*   **Smart Compression** — Uses LZ-String compression to store up to 5MB of search index data locally without impacting performance.


**Reliability** 🛡️ 

*   **Local-First Architecture** — Zero network latency. All data lives on your device.

*   **Graceful Degradation** — If a feature fails due to a website update, the rest of the extension keeps working.

*   **Styled Dialogs** — Smooth, themed confirmation dialogs (no more jarring browser popups).

> **Note:** Each notebook has its own independent data. Tasks and Folders created in "Project A" won't clutter "Project B."


## Installation
### Load Unpacked (Developer Mode)

1.  Download or clone this repository.
2.  Open Chrome and go to `chrome://extensions`.
3.  Enable **Developer mode** (toggle in top right).
4.  Click **Load unpacked**.
5.  Select the folder containing these extension files.
6.  Navigate to NotebookLM and start organizing!

## Usage
Once installed, you'll see a new "Project Dashboard" interface injected into NotebookLM:

*   **Quick Capture:** Highlight text in any note -> click the floating + button to turn it into a task.

*   **Pop-out:** Hover over a note in the Studio panel -> click the New Window icon.

*   **Task Details:** Click the Description icon on a task to add notes or context.

*   **Bulk Actions:** Use the folder checkboxes to toggle multiple sources for the AI context window.

*   **Export/Import:** Use these buttons to backup your structure or move it to a new computer.

## Storage & Data Guide 💾 
**Where Your Data Lives**

Because v17.9 prioritizes speed and privacy, your data lives on your device:

*   **Local Storage:** Folders, Tasks, Settings, and Search Index.

*   **No Auto-Sync:** Folders do not sync automatically between computers.

*   **Moving Data:** To move your setup to a laptop, use the Export button to get a JSON file, then Import on the new machine.

> **Warning:** If you clear Chrome's "Site Data" or "Cookies," you will lose your folders. Export backups regularly.


## Privacy & Security
**This extension is Local-First:**

*   **All data is stored in your browser's local storage.**

*   **No analytics or usage data is sent to the developer.**

*   **Open Source:** You can inspect the code to verify no data leaves your machine.

See [PRIVACY_POLICY.md](https://raw.githubusercontent.com/benju66/Notebook-Nest/main/PRIVACY_POLICY.md) for details.

## Known Limitations

*   **Pop-out Editing:** Pop-out windows are currently Read-Only. You must use the main window to edit text.

*   **Underlining:** Underlining content in a note is not persistent (this is a Google NotebookLM issue, not the extension).

*   **Incognito:** The extension's memory system is disabled in Incognito mode.


## Contributing
Found a bug or have a feature request? Open an issue or submit a PR.

## Author
Benju66

## License
GPLv3 License

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.


Note: This ensures that any improvements made to this project must be shared back with the community.

