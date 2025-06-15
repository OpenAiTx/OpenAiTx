# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 اگر پروژه ما را دوست دارید، لطفاً برای دریافت آخرین به‌روزرسانی‌ها به ما در گیت‌هاب ستاره ⭐ بدهید.</h5>
**MemoryOS** برای ارائه یک سیستم عامل حافظه به ایجنت‌های هوش مصنوعی شخصی‌سازی‌شده طراحی شده است تا تعاملاتی منسجم‌تر، شخصی‌تر و آگاه از زمینه را امکان‌پذیر کند. با الهام از اصول مدیریت حافظه در سیستم‌های عامل، این سیستم از معماری ذخیره‌سازی سلسله‌مراتبی با چهار ماژول اصلی: ذخیره‌سازی، به‌روزرسانی، بازیابی و تولید بهره می‌گیرد تا مدیریت حافظه جامع و کارآمدی را محقق سازد. در بنچمارک LoCoMo، مدل بهبود میانگین **49.11%** و **46.18%** را در امتیازات F1 و BLEU-1 بدست آورد.

## 📣 آخرین اخبار
*   *<mark>[جدید]</mark>* 🔥  **[2025-06-15]**:🛠️ نسخه متن‌باز **MemoryOS-MCP** منتشر شد! اکنون قابل پیکربندی روی کلاینت ایجنت برای ادغام و شخصی‌سازی یکپارچه. [👉 مشاهده](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: نسخه اولیه **MemoryOS** راه‌اندازی شد! دارای حافظه شخصیت کوتاه‌مدت، میان‌مدت و بلندمدت با به‌روزرسانی خودکار پروفایل کاربر و دانش.

## دمو
[![Watch the video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## معماری سیستم
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## ساختار پروژه

```
memoryos/
├── __init__.py            # مقداردهی اولیه پکیج MemoryOS
├── __pycache__/           # پوشه کش پایتون (خودکار ایجاد می‌شود)
├── long_term.py           # مدیریت حافظه شخصیت بلندمدت (پروفایل کاربر، دانش)
├── memoryos.py            # کلاس اصلی MemoryOS، هماهنگ‌کننده تمام کامپوننت‌ها
├── mid_term.py            # مدیریت حافظه میان‌مدت، ادغام تعاملات کوتاه‌مدت
├── prompts.py             # شامل پرامپت‌های استفاده شده برای تعامل با LLM (خلاصه‌سازی، تحلیل و غیره)
├── retriever.py           # بازیابی اطلاعات مرتبط از تمام لایه‌های حافظه
├── short_term.py          # مدیریت حافظه کوتاه‌مدت برای تعاملات اخیر
├── updater.py             # پردازش به‌روزرسانی‌های حافظه، شامل ارتقاء اطلاعات بین لایه‌ها
└── utils.py               # توابع کمکی مورد استفاده در سراسر کتابخانه
```

## نحوه کارکرد

1.  **مقداردهی اولیه:** `Memoryos` با شناسه کاربر و دستیار، کلیدهای API، مسیر ذخیره داده‌ها و تنظیمات ظرفیت/آستانه مختلف مقداردهی می‌شود. برای هر کاربر و دستیار، ذخیره‌سازی اختصاصی راه‌اندازی می‌گردد.
2.  **افزودن خاطرات:** ورودی‌های کاربر و پاسخ‌های ایجنت به صورت جفت‌های پرسش و پاسخ افزوده می‌شوند. این‌ها ابتدا در حافظه کوتاه‌مدت ذخیره می‌شوند.
3.  **پردازش حافظه کوتاه‌مدت به میان‌مدت:** وقتی حافظه کوتاه‌مدت پر می‌شود، ماژول `Updater` این تعاملات را پردازش کرده و آن‌ها را به بخش‌های معنادار ادغام نموده و در حافظه میان‌مدت ذخیره می‌کند.
4.  **تحلیل میان‌مدت و به‌روزرسانی LPM:** بخش‌های حافظه میان‌مدت براساس عواملی مانند فراوانی بازدید و طول تعامل، "گرما" جمع می‌کنند. وقتی گرمای یک بخش از آستانه عبور کند، محتوای آن تحلیل می‌شود:
    *   بینش‌های پروفایل کاربر استخراج و برای به‌روزرسانی پروفایل بلندمدت کاربر استفاده می‌شوند.
    *   حقایق خاص کاربر به دانش بلندمدت وی افزوده می‌شود.
    *   اطلاعات مرتبط برای دستیار به پایگاه دانش بلندمدت دستیار افزوده می‌گردد.
5.  **تولید پاسخ:** هنگام دریافت پرسش کاربر:
    *   ماژول `Retriever` زمینه مرتبط را از تاریخچه کوتاه‌مدت، بخش‌های حافظه میان‌مدت، پروفایل و دانش کاربر، و پایگاه دانش دستیار بازیابی می‌کند.
    *   این زمینه جامع همراه با پرسش کاربر برای تولید یک پاسخ منسجم و آگاهانه توسط LLM استفاده می‌شود.

## راه‌اندازی MemoryOS_PYPI

### پیش‌نیازها

*   پایتون >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### نصب

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### استفاده پایه

```python

import os
from memoryos import Memoryos

# --- تنظیمات پایه ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # کلید خود را جایگزین کنید
BASE_URL = ""  # اختیاری: اگر از نقطه پایانی OpenAI سفارشی استفاده می‌کنید
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("دموی ساده MemoryOS")
    
    # 1. مقداردهی اولیه MemoryOS
    print("در حال مقداردهی اولیه MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS با موفقیت مقداردهی شد!\n")
    except Exception as e:
        print(f"خطا: {e}")
        return

    # 2. افزودن برخی خاطرات پایه
    print("در حال افزودن برخی خاطرات...")
    
    memo.add_memory(
        user_input="سلام! من تام هستم، به عنوان دانشمند داده در سانفرانسیسکو کار می‌کنم.",
        agent_response="سلام تام! خوشبختم. علوم داده حوزه بسیار هیجان‌انگیزی است. با چه نوع داده‌ای کار می‌کنی؟"
    )
     
    test_query = "در مورد شغل من چه چیزی را به یاد داری؟"
    print(f"کاربر: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"دستیار: {response}")

if __name__ == "__main__":
    simple_demo()
```
## راه‌اندازی MemoryOS-MCP
### 🔧 ابزارهای اصلی

#### 1. `add_memory`
محتوای گفت‌وگوی میان کاربر و دستیار هوش مصنوعی را در سیستم حافظه ذخیره می‌کند تا سابقه گفتگو و زمینه را به شکل پایدار بسازد.

#### 2. `retrieve_memory`
براساس یک پرسش، گفتگوهای تاریخی مرتبط، ترجیحات کاربر و اطلاعات دانش را از سیستم حافظه بازیابی می‌کند تا دستیار هوش مصنوعی نیازها و پیش‌زمینه کاربر را بهتر درک کند.

#### 3. `get_user_profile`
پروفایل کاربری را که از تحلیل گفتگوهای تاریخی استخراج شده (شامل صفات شخصیتی، علایق و پیش‌زمینه دانش مرتبط کاربر) به دست می‌آورد.

### 1. نصب وابستگی‌ها
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. پیکربندی

ویرایش فایل `config.json`:
```json
{
  "user_id": "YOUR_USER_ID",
  "openai_api_key": "YOUR_OPENAI_API_KEY",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. اجرای سرور
```bash
python server_new.py --config config.json
```
### 4. تست
```bash
python test_comprehensive.py
```
### 5. پیکربندی روی Cline و سایر کلاینت‌ها
فایل mcp.json را کپی کنید و مطمئن شوید مسیر فایل صحیح است.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#این باید به مفسر پایتون محیط مجازی شما تغییر یابد
```
## مشارکت

مشارکت شما خوش‌آمد است! لطفاً آزادانه issue یا pull request ارسال کنید.

## استناد
اگر می‌خواهید جزئیات بیشتری بخوانید، اینجا را کلیک کنید: [مطالعه متن کامل مقاله](https://arxiv.org/abs/2506.06326)

اگر این پروژه برای شما مفید بود، لطفاً مقاله ما را استناد کنید:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## تماس با ما
百家AI گروه تحقیقاتی تحت هدایت دانشیار بای تینگ در دانشگاه پست و مخابرات پکن است که به ساخت مغزهایی با احساسات غنی و حافظه خارق‌العاده برای انسان‌های سیلیکونی اختصاص یافته است.<br>
همکاری و پیشنهادات: baiting@bupt.edu.cn<br>
خوشحال می‌شویم که به کانال رسمی 百家Agent و گروه وی‌چت ما بپیوندید و با هم تبادل نظر کنیم!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="کانال رسمی 百家Agent" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="کد QR گروه وی‌چت" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---