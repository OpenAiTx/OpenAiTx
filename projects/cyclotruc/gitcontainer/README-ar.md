![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**حوّل أي مستودع GitHub إلى حاوية Docker جاهزة للإنتاج عبر توليد ملف Dockerfile مدعوم بالذكاء الاصطناعي.**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer هو تطبيق ويب مدعوم بالذكاء الاصطناعي يقوم تلقائيًا بإنشاء ملفات Dockerfile جاهزة للإنتاج من خلال تحليل مستودعات GitHub. فقط الصق رابط GitHub واحصل على ملف Dockerfile مخصص مع اختيار ذكي لصورة الأساس، إدارة الاعتمادات، وأفضل ممارسات Docker.

## 🌟 وصول سريع

ببساطة استبدل `github.com` بـ `gitcontainer.com` في أي رابط مستودع GitHub للوصول مباشرة إلى صفحة توليد ملف Dockerfile لذلك المستودع.

على سبيل المثال:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ الميزات

- **🔄 وصول فوري عبر الرابط**: فقط استبدل 'github.com' بـ 'gitcontainer.com' في أي رابط GitHub
- **🤖 تحليل مدعوم بالذكاء الاصطناعي**: يستخدم OpenAI GPT-4 لتحليل بنية المستودع وتوليد ملفات Dockerfile ذكية
- **⚡ بث في الوقت الحقيقي**: شاهد الذكاء الاصطناعي ينشئ ملف Dockerfile الخاص بك مباشرة عبر بث WebSocket
- **🎯 كشف ذكي**: يكتشف تلقائيًا تقنيات البرمجة المستخدمة (Python، Node.js، Java، Go، إلخ)
- **🔧 جاهز للإنتاج**: ينشئ ملفات Dockerfile باتباع أفضل الممارسات مع الأمان المناسب، وبناء متعدد المراحل، وتحسين الأداء
- **📋 تعليمات إضافية**: أضف متطلبات مخصصة لبيئات متخصصة
- **📄 Docker Compose**: يقترح تلقائيًا ملف docker-compose.yml للتطبيقات المعقدة
- **🎨 واجهة عصرية**: واجهة نظيفة ومتجاوبة مع محرر Monaco لإبراز الصيغة البرمجية
- **📱 متوافق مع الجوال**: يعمل بسلاسة على أجهزة الكمبيوتر المكتبية والهواتف المحمولة

## 🚀 البدء السريع

### المتطلبات الأساسية

- Python 3.9 أو أعلى
- Git
- مفتاح واجهة برمجة تطبيقات OpenAI

### التثبيت

1. **استنساخ المستودع:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **تثبيت الاعتمادات:**
   ```bash
   pip install -r requirements.txt
   ```

3. **إعداد متغيرات البيئة:**
   ```bash
   # إنشاء ملف .env
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **تشغيل التطبيق:**
   ```bash
   python app.py
   ```

5. **فتح المتصفح:**
   انتقل إلى `http://localhost:8000`

## 🛠️ كيفية العمل

1. **معالجة الرابط**: الوصول إلى أي مستودع عبر استبدال 'github.com' بـ 'gitcontainer.com' في الرابط
2. **استنساخ المستودع**: يقوم Gitcontainer باستنساخ مستودع GitHub محليًا باستخدام Git
3. **تحليل الكود**: يستخدم [gitingest](https://github.com/cyclotruc/gitingest) لتحليل بنية المستودع واستخلاص المعلومات ذات الصلة
4. **توليد بالذكاء الاصطناعي**: يرسل التحليل إلى OpenAI GPT-4 مع مطالبات متخصصة لتوليد ملف Dockerfile
5. **تحسين ذكي**: يأخذ الذكاء الاصطناعي بعين الاعتبار:
   - كشف تقنيات البرمجة المستخدمة
   - إدارة الاعتمادات
   - أفضل ممارسات الأمان
   - البناء متعدد المراحل عند الحاجة
   - إعداد المنافذ
   - متغيرات البيئة
   - اختبارات الصحة

## 📁 هيكل المشروع

```
cyclotruc-gitcontainer/
├── app.py                 # التطبيق الرئيسي FastAPI
├── requirements.txt       # اعتمادات بايثون
├── .env                  # متغيرات البيئة (أنشئ هذا)
├── static/               # الملفات الثابتة (أيقونات، CSS)
├── templates/
│   └── index.jinja       # القالب الرئيسي HTML
└── tools/                # وحدات الوظائف الأساسية
    ├── __init__.py
    ├── create_container.py  # توليد Dockerfile بالذكاء الاصطناعي
    ├── git_operations.py    # استنساخ مستودعات GitHub
    └── gitingest.py        # تحليل المستودع
```
## 🔧 التكوين

### متغيرات البيئة

| المتغير | الوصف | مطلوب |
|----------|-------------|----------|
| `OPENAI_API_KEY` | مفتاح API الخاص بك في OpenAI | نعم |
| `PORT` | منفذ الخادم (الافتراضي: 8000) | لا |
| `HOST` | مضيف الخادم (الافتراضي: 0.0.0.0) | لا |

### الاستخدام المتقدم

يمكنك استخدام الأدوات برمجياً:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # استنساخ المستودع
    clone_result = await clone_repo_tool(github_url)
    
    # التحليل باستخدام gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # إنشاء Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# الاستخدام
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 التخصيص

### إضافة تعليمات مخصصة

استخدم ميزة "تعليمات إضافية" لتخصيص عملية التوليد:

- `"استخدم Alpine Linux للحصول على حجم صورة أصغر"`
- `"قم بتضمين Redis و PostgreSQL"`
- `"قم بتحسين الإعداد للنشر الإنتاجي"`
- `"أضف أدوات تطوير لأغراض التصحيح"`

## 📝 الرخصة

هذا المشروع مرخص بموجب رخصة MIT - راجع ملف [LICENSE](LICENSE) لمزيد من التفاصيل.

## 🙏 الشكر والتقدير

- **[OpenAI](https://openai.com/)** لتوفير واجهة GPT-4 API
- **[gitingest](https://github.com/cyclotruc/gitingest)** لقدرات تحليل المستودعات
- **[FastAPI](https://fastapi.tiangolo.com/)** لإطار العمل الرائع للويب
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** لتسليط الضوء على بناء الجملة البرمجية

## 🔗 الروابط

- **مستودع GitHub**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **عرض تجريبي**: جربه مباشرة مع مستودعات أمثلة
- **المشكلات**: [الإبلاغ عن الأخطاء أو طلب الميزات](https://github.com/cyclotruc/gitcontainer/issues)

---

**تم العمل عليه بمحبة ❤️ بواسطة [Romain Courtois](https://github.com/cyclotruc)**

*حوّل أي مستودع إلى حاوية خلال ثوانٍ!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---