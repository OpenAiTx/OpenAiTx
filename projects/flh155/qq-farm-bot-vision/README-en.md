# qq-farm-bot-vision
# QQ Classic Farm Bot (AI Vision Version)
## The initial version based on CV visual matching has been developed, the Alaph version has been released. Note: This is an early test version with incomplete features, still under continuous development and optimization, mainly to allow some users to try it out and assist in testing bugs and giving feedback.
## For the latest feature update logs, please check: [update_cv.txt](https://raw.githubusercontent.com/flh155/qq-farm-bot-vision/main/./update_cv.txt)
## If you encounter problems during the trial, you can submit issues: [issue section](https://github.com/flh155/qq-farm-bot-vision/issues)
## For technical communication, join Discord: [Farmer Communication Channel](https://discord.gg/xbpVKG9wKw)

## Below is the deployment and trial method for the CV version
### Note: Since this is a test version, there are many issues and missing features, so for now, no one-click installation methods like docker or exe are provided; only source code launch is offered for users with certain technical backgrounds willing to try. One-click deployment solutions will be provided after the version is optimized and stable. Thank you for your understanding.

## ❗ Please read before use:
- The current version requires the game window to always stay in the foreground, but it can be obscured
- The current version already has an initial GUI interface; if you want to use it, please start `python main_gui.py`
- The current version has implemented `auto harvest`, `auto weeding/pest removal/watering`, `auto planting (in testing)`, `auto stealing crops`, `auto help with weeding/pest removal/watering`, and `auto claiming daily free fertilizer` functions. These features are continuously tested and optimized.
- Image template matching may fail or mismatch due to various factors; you need to adjust related threshold parameters based on usage. For threshold adjustment methods, refer to: [threshold_adjust.txt](https://raw.githubusercontent.com/flh155/qq-farm-bot-vision/main/./threshold_adjust.txt)
- Key listening is set up for quick control of the bot. Hotkeys: `Ctrl+c` immediately stops and exits the bot, `p` temporarily pauses/resumes the bot inspection

---
## Branch Description
- ### ~~[silence-click branch](https://github.com/flh155/qq-farm-bot-vision/tree/silence-click): Changes the clicking mode to silent click, requires the game screen to remain in front but will not compete with the user for mouse clicks. Note: This mode may carry the risk of account bans, please decide whether to use it yourself. If used, please observe and provide feedback~~ (This branch has been merged into the main branch)
- ### [gui-pr branch](https://github.com/flh155/qq-farm-bot-vision/tree/gui-pr): This branch is provided for submitting GUI interface PRs. The default GUI interface of the project is relatively simple. If you have a good GUI design, you can submit a PR to this branch (currently no submissions)

---
## GUI Interface Display
![GUI](https://raw.githubusercontent.com/flh155/qq-farm-bot-vision/main/./assert/gui.jpg)

## System Requirements
- Windows 10 or above (Linux and other systems are not yet supported)
- Local Python installation (conda environment recommended), with Python version ≥ 3.9
- Installed NT architecture desktop QQ and able to open the farm page
## Deployment and Trial Procedure
- 1. `git clone` this project locally, open PC QQ and log in
- 2. Open a terminal in the project root directory (optional: switch conda environment), use the command `pip install -r requirement.txt` to install the project dependencies
- 3. Check the `config.ini` configuration file in the root directory and modify related parameters according to your needs
- 4. Use the command `python main.py` to start the bot and check if it starts successfully in the terminal (GUI startup command is `python main_gui.py`)
- 5. Open the farm game window (note the current version requires the game window to be unobstructed)
- 6. The program will automatically control the mouse to click relevant function buttons to achieve automation
---
# Future Development Plans
- ~~Initial version implements crop harvesting, pest control, and weeding functions based on CV image matching (quickly providing a simple version for everyone to transition)~~ (completed)
- ~~Added GUI interface for easier use~~ (Implemented)
- Optimized and enriched the CV matching version features, fixed existing issues (In progress)
- Collected screen data sets: cleaning, annotation, augmentation
- Trained target detection model based on YOLO neural network
- Used neural networks for more accurate and diverse recognition of various icons, enriching functions (planting, harvesting, stealing crops, farming, etc.)
# Your star⭐ is my motivation to update
---
## First of all, thank you very much for your attention and star⭐ to the project. However, since I usually work manual labor, I only have time to update and maintain the project during breaks and after work, and this project started from scratch, so the progress will be slower and the code quality might be slightly lower. I hope everyone can understand, and I also welcome experts from all fields to submit PRs and become project contributors. Finally, I will update the development progress in a timely manner, please be patient.

# Disclaimer ❗  
## This project is only for research, learning, and communication purposes regarding AI and computer vision technology applications. It is promised to be permanently open-source and free. Any direct or indirect secondary development, repackaging for sale, promotion, or other illegal uses of the project are strictly prohibited. Using this project may violate game service terms and result in account bans or other penalties. By using this project’s code, you acknowledge and agree to the above information. All consequences arising therefrom shall be borne by the user and have nothing to do with the author.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-11

---