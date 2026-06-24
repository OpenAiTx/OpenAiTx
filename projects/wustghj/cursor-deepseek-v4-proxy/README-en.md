# 🧠 Cursor DeepSeek V4 Proxy

> **One-click fix for the `reasoning_content` error when using DeepSeek V4 in Cursor, say goodbye to `Rate limit exceeded`, and make AI Agent mode run stably.**

[![GitHub stars](https://img.shields.io/github/stars/你的用户名/cursor-deepseek-v4-proxy?style=social)](https://github.com/你的用户名/cursor-deepseek-v4-proxy)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 📌 What problems can this project solve for you?

If you frequently encounter any of the following errors when calling DeepSeek V4 (Pro / Flash) in Cursor:

* `Provider returned error: The reasoning_content in the thinking mode must be passed back to the API.`
* `User API Key Rate limit exceeded` (error despite plenty of quota left)
* `AI Model Not Found: deepseek-v4-pro` (background task reports invalid model name)
* The first round of chat works fine, but errors and interruptions start from the second round

**No need to struggle anymore, follow this guide and solve it completely in 5 minutes.**

> ⚠️  **Fixed on 2026-05-14**: Pure text models now automatically filter images, resolving 502 errors. See [Changelog](#changelog) for details.

---

## ✨ Core Features

* ✅ **Automatic caching & returning of reasoning chains**: no more errors caused by missing `reasoning_content`.
* ✅ **Intelligent rate limiting**: built-in token bucket to prevent burst concurrent requests from maxing out free quota.
* ✅ **Supports streaming output**: does not affect Cursor’s typewriter rendering effect.
* ✅ **One-click start script**: works on Windows / macOS / Linux, just double-click to run.
* ✅ **Transparent logs**: terminal shows request status in real-time for easy troubleshooting.
* ✅ **Zero intrusion**: no need to modify Cursor program files, only change one Base URL.

---

## 🖥️ Supported Environments

| Operating System | Support Status |
| :--- | :--- |
| **Windows 10 / 11** | ✅ Supported |
| **macOS** | ✅ Supported |
| **Linux** | ✅ Supported |

> **Only requirement**: Install **Python 3.8** or higher (be sure to check `Add Python to PATH` during installation).

---

## 🚀 Super Detailed Three-Step Getting Started (For Beginners)

### Step 1: Download the project and install dependencies

1.  Download the ZIP package of this project repository and extract it locally (**please do not include Chinese characters in the path**).
2.  Enter the extracted folder, type `cmd` in the folder address bar and press Enter to open the command prompt.
3.  Run the following command to install dependencies:
    ```bash
    pip install -r requirements.txt
    ```
    *If you see the prompt `pip is not an internal command`, please reinstall Python and check `Add to PATH`.*

### Step 2: Start Local Proxy + Tunnel

You need a tunnel to generate a public address (Cursor restricts access to localhost).

#### 🪟 Windows Users
1.  Make sure the folder contains `cloudflared-windows-amd64.exe` (if not, please download it from the [Cloudflare official site](https://github.com/cloudflare/cloudflared/releases)).
2.  Double-click to run **`start_proxy.bat`**.
3.  Two windows will pop up. In the **tunnel window**, find a URL like `https://xxx.trycloudflare.com` and **copy** it.

#### 🍎 macOS / Linux Users
1.  Open the terminal, navigate to the project directory, and run:
    ```bash
    bash start_proxy.sh
    ```
2.  Wait a moment, then copy the terminal output URL `https://xxx.trycloudflare.com`.

> ⚠️ **Note**: Do not close the window. The tunnel address changes each time it restarts, but it remains valid as long as the window stays open.

### Step 3: Configure Cursor

1.  Open Cursor settings: press `Ctrl+Shift+P` → type `Cursor Settings`.
2.  Go to the **Models** tab.
3.  In **"Override OpenAI Base URL"**, paste the copied address, and **add `/v1` at the end**:
    * For example: `https://xxxxxx.trycloudflare.com/v1`
4.  Enter your **DeepSeek API Key** in the API Key field.
5.  **Completely exit and restart Cursor**.

---

## 🛡️ Fix "Model name not valid" Error

If you encounter an error when running Apply or background tasks, follow these steps:

1.  Press `Ctrl+Shift+P`, type `Preferences: Open User Settings (JSON)` and press Enter.
2.  Add the following configuration inside the JSON braces `{}`:
    ```json
    "cursor.models": {
        "deepseek-v4-pro": {
            "provider": "openai",
            "apiBase": "[https://你的隧道地址.trycloudflare.com/v1](https://你的隧道地址.trycloudflare.com/v1)",
            "apiKey": "你的DeepSeek API Key"
        }
    }
    ```
3.  Save and restart Cursor.

---

## ❓ FAQ

<details>
<summary>🔁 What if the tunnel address changes?</summary>
A new address is generated every time the script restarts. You just need to retrieve it again and update the Base URL in Cursor.
</details>

<details>
<summary>💸 Still getting "Rate limit exceeded"?</summary>
DeepSeek's free tier has a very low frequency limit. You can edit `proxy.py` and reduce the `5` in `TokenBucket(rate=5/60.0, capacity=5)` (e.g., to `3`) to forcibly lower the request frequency.
</details>

<details>
<summary>🚫 Must I use a tunnel? Can I connect to localhost?</summary>
Cursor forbids direct connections to `localhost` for security reasons. Cloudflare Tunnel is currently the simplest, free, and registration-free penetration solution.
</details>

<details>
<summary>🧪 Does the proxy affect the model's intelligence?</summary>
In 99% of scenarios, it is imperceptible. The proxy only automatically completes when the model "forgets" to return the thought chain, ensuring the conversation is uninterrupted.
</details>

<details>
<summary>🧪 Why is there only 200k context, not 1M?</summary>
This is the default limitation of Cursor, not the proxy issue.

Cursor uses a 200k context window by default.
To enable the 1M context supported by the model, you need to turn on `Max Mode` in Cursor Chat.
Path:
Chat -> Model Selector -> Max Mode
</details>

---

## ⚙️ Advanced Customization

* **Change Upstream**: Modify the `UPSTREAM_URL` in `proxy.py`.  
* **Fixed Domain**: If you have your own domain, you can configure a Cloudflare Named Tunnel (Persistent Tunnel).  

<a name="changelog"></a>  
## 🆕 Changelog  

### 2026-05-14: Plain Text Model Image Compatibility Fix  

**Fix Details**  
When clients like Cursor send messages containing images to `deepseek-v4-pro` (plain text model), the proxy layer now automatically filters out the `image_url` content blocks, keeping only the text part. If a message consists entirely of images (no text), it is replaced with a prompt text to avoid the model receiving an empty message.  
This fix resolves the 502 error caused by DeepSeek API returning `"unknown variant image_url, expected text"`.  

**Additional Improvements**  

- Unified upstream error response format, so clients receive structured JSON errors (instead of raw error messages or blank pages).  
- Image compatibility logic does not affect inference cache (`reasoning_content`), and historical message handling remains normal.  

------  

### Acknowledgments  

Thanks to [@BG-ah](https://github.com/BG-ah) for reporting the rate limit issue in Issue [#4](https://github.com/wustghj/cursor-deepseek-v4-proxy/issues/4), and to [@CH-nolyn](https://github.com/CH-nolyn) for participating in the discussion. Your feedback directly drove this compatibility fix, making the proxy run more stably under the plain text model.  

------  

> 💡 **Tip**: If you want the model to truly understand image content, please change the `model` field in your request to the multimodal-supported `deepseek-chat`, and ensure your DeepSeek account has the corresponding permissions enabled.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---