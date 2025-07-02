# 🚀 MCP دستیار توسعه AI

> ابزار MCP برای کمک به توسعه‌دهندگان AI در تحلیل نیازمندی‌ها و طراحی معماری هوشمند

## ✨ ویژگی‌های کلیدی

- **توضیح هوشمند نیازمندی‌ها**: شناسایی خودکار نوع پروژه و تولید سوالات هدفمند
- **مدیریت شاخه آگاهانه**: پیگیری اهداف پروژه، طراحی عملکرد، ترجیحات فنی، طراحی UI و سایر ابعاد
- **تولید خودکار معماری**: تولید طرح معماری فنی بر اساس نیازمندی‌های کامل
- **ذخیره‌سازی پایدار**: ذخیره خودکار نتایج تحلیل و پشتیبانی از خروجی گرفتن سند

## 📁 پیکربندی سریع

### پیکربندی نسخه قدیمی
1. **کلون کردن کد**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **پیشنهاد استفاده از محیط مجازی**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **نصب وابستگی‌ها**
   ```bash
   pip install -r requirements.txt
   ```

4. **مکان فایل پیکربندی**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **افزودن پیکربندی**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **راه‌اندازی مجدد Claude Desktop**

### پیکربندی نسخه جدید
#### 🔧 ابزارهای کلیدی
1. **start_new_project** - شروع پروژه جدید
2. **create_requirement_blueprint** - ایجاد نقشه نیازمندی‌ها
3. **requirement_clarifier** - دریافت پیشنهادات توضیح نیازمندی
4. **save_clarification_tasks** - ذخیره وظایف توضیح نیازمندی‌ها
5. **update_branch_status** - به‌روزرسانی وضعیت شاخه‌ها
6. **requirement_manager** - مدیریت اسناد نیازمندی
7. **check_architecture_prerequisites** - بررسی پیش‌نیازهای معماری
8. **get_architecture_design_prompt** - دریافت پیشنهاد طراحی معماری
9. **save_generated_architecture** - ذخیره معماری تولیدشده
10. **export_final_document** - خروجی گرفتن سند کامل
11. **view_requirements_status** - مشاهده وضعیت نیازمندی‌ها

#### پیکربندی (اتصال مستقیم از راه دور، این تنظیم را در ابزار خود کپی کنید و MCP_STORAGE_DIR را با مسیر محلی خود جایگزین کنید)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 روند استفاده

### مراحل پایه

1. **توضیح نیازمندی**
   ```
   requirement_clarifier("می‌خواهم یک پلتفرم آموزش آنلاین بسازم")
   ```

2. **مدیریت نیازمندی**
   ```
   requirement_manager("کاربران هدف: دانش‌آموزان و معلمان", "خلاصه پروژه")
   ```

3. **مشاهده وضعیت**
   ```
   view_requirements_status()
   ```
4. **طراحی معماری**
   ```
   architecture_designer("معماری پلتفرم آموزش آنلاین")
   ```

5. **خروجی گرفتن از سند**
   ```
   export_final_document()
   ```

## 🚀 شروع استفاده

### شروع سریع
1. **پیکربندی Claude Desktop** (طبق روش پیکربندی بالا)
2. **راه‌اندازی مجدد Claude Desktop**
3. **شروع تحلیل هوشمند نیازمندی‌ها**:
   ```
   requirement_clarifier("ایده پروژه خود را توصیف کنید")
   ```
4. **گام به گام زیر نظر راهنمایی هوشمند AI**، هر شاخه نیازمندی را تکمیل کنید
5. **خروجی گرفتن از سند کامل**:
   ```
   export_final_document()
   ```

### بهترین شیوه‌ها
- 💬 **به مدیریت شاخه‌های AI اعتماد کنید**: اجازه دهید AI شما را در تکمیل تمام شاخه‌های نیازمندی هدایت کند
- 🎯 **ترجیحات خود را شفاف بیان کنید**: نسبت به انتخاب فناوری، سبک UI و غیره نظر خود را صریح بیان کنید
- 📊 **به‌طور منظم وضعیت را بررسی کنید**: با استفاده از `view_requirements_status` پیشرفت را مشاهده کنید
- 🤖 **در صورت نیاز اختیار را به AI بدهید**: در بخش‌هایی که مطمئن نیستید بگویید "از راه‌حل متداول استفاده کن"

---

**🎯 اکنون یک دستیار توسعه AI واقعاً هوشمند در اختیار دارید که هر جزئیاتی را به خاطر می‌سپارد و شما را تا تکمیل تحلیل نیازمندی‌ها راهنمایی می‌کند!**

## 💬 گروه گفت‌وگو

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="گروه گفت‌وگو">
<br>
گروه گفت‌وگو
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---