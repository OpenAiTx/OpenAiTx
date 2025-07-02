# 🚀 مساعد تطوير الذكاء الاصطناعي MCP AI

> أداة MCP لمساعدة مطوري الذكاء الاصطناعي في تحليل الاحتياجات الذكية وتصميم البنية التحتية

## ✨ الخصائص الأساسية

- **توضيح الاحتياجات الذكي**: التعرف التلقائي على نوع المشروع، وتوليد أسئلة موجهة
- **إدارة الفروع بوعي**: تتبع أهداف المشروع، تصميم الوظائف، التفضيلات التقنية، تصميم واجهة المستخدم وغيرها
- **توليد البنية تلقائياً**: توليد خطة البنية التقنية بناءً على الاحتياجات الكاملة
- **تخزين دائم**: حفظ نتائج التحليل تلقائياً، دعم تصدير المستندات

## 📁 الإعداد السريع

### إعداد الإصدار القديم
1. **استنساخ الكود**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **بيئة افتراضية موصى بها**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **تثبيت الاعتماديات**
   ```bash
   pip install -r requirements.txt
   ```

4. **موقع ملف الإعداد**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **إضافة الإعداد**
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

3. **إعادة تشغيل Claude Desktop**

### إعداد الإصدار الجديد
#### 🔧 الأدوات الأساسية
1. **start_new_project** - بدء مشروع جديد
2. **create_requirement_blueprint** - إنشاء مخطط الاحتياجات
3. **requirement_clarifier** - الحصول على تلميحات توضيح الاحتياجات
4. **save_clarification_tasks** - حفظ مهام التوضيح
5. **update_branch_status** - تحديث حالة الفرع
6. **requirement_manager** - مدير مستندات الاحتياجات
7. **check_architecture_prerequisites** - التحقق من متطلبات البنية المسبقة
8. **get_architecture_design_prompt** - الحصول على تلميحات تصميم البنية
9. **save_generated_architecture** - حفظ تصميم البنية المولدة
10. **export_final_document** - تصدير المستند الكامل
11. **view_requirements_status** - عرض حالة الاحتياجات

#### الإعداد (انسخ الاتصال المباشر عن بُعد إلى أداتك، واستبدل MCP_STORAGE_DIR بمجلدك المحلي)
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

## 🎯 سير العمل

### الخطوات الأساسية

1. **توضيح الاحتياجات**
   ```
   requirement_clarifier("أريد إنشاء منصة تعليم إلكتروني")
   ```

2. **إدارة الاحتياجات**
   ```
   requirement_manager("المستخدمون المستهدفون: الطلاب والمعلمون", "ملخص المشروع")
   ```

3. **عرض الحالة**
   ```
   view_requirements_status()
   ```

4. **تصميم البنية المعمارية**
   ```
   architecture_designer("بنية منصة التعليم عبر الإنترنت")
   ```

5. **تصدير المستند**
   ```
   export_final_document()
   ```

## 🚀 البدء بالاستخدام

### البدء السريع
1. **تهيئة Claude Desktop** (راجع طريقة التهيئة أعلاه)
2. **أعد تشغيل Claude Desktop**
3. **ابدأ تحليل المتطلبات الذكي**:
   ```
   requirement_clarifier("صف فكرتك عن المشروع")
   ```
4. **اتبع الإرشادات الذكية للذكاء الاصطناعي**، وقم بتحسين كل فرع من المتطلبات خطوة بخطوة
5. **تصدير المستند الكامل**:
   ```
   export_final_document()
   ```

### أفضل الممارسات
- 💬 **ثق بإدارة الفروع بواسطة الذكاء الاصطناعي**: دع الذكاء الاصطناعي يوجهك لإكمال جميع فروع المتطلبات
- 🎯 **عبّر عن تفضيلاتك بوضوح**: عبّر بوضوح عن تفضيلاتك فيما يخص اختيار التقنية، أسلوب واجهة المستخدم، إلخ
- 📊 **راجع الحالة بشكل دوري**: استخدم `view_requirements_status` لمعرفة التقدم
- 🤖 **فوض الذكاء الاصطناعي عند الحاجة**: للأجزاء غير المؤكدة يمكنك قول "استخدم الحل التقليدي"

---

**🎯 الآن لديك مساعد تطوير ذكي فعلاً بالذكاء الاصطناعي، سيتذكر كل التفاصيل ويوجهك لإكمال تحليل المتطلبات بشكل كامل!**

## 💬 مجموعة النقاش

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="مجموعة النقاش">
<br>
مجموعة النقاش
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---