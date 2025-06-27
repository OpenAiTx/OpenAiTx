# خادم MCP

تم إنشاء ملف README هذا باستخدام قالب مشروع خادم MCP لـ .NET. يوضح كيف يمكنك بسهولة إنشاء خادم MCP باستخدام .NET ثم حزمه في حزمة NuGet.

راجع [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) للاطلاع على الدليل الكامل.

## قائمة التحقق قبل النشر على NuGet.org

- تحديث بيانات الحزمة الوصفية في ملف .csproj
- تحديث الملف `.mcp/server.json` لإعلان مدخلات خادم MCP الخاص بك
- اختبار خادم MCP محلياً باستخدام الخطوات أدناه

## استخدام خادم MCP في VS Code

بمجرد نشر حزمة خادم MCP على NuGet.org، يمكنك استخدام التكوين التالي في VS Code مع إعدادات المستخدم لتنزيل وتثبيت حزمة خادم MCP. راجع [استخدام خوادم MCP في VS Code (معاينة)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) لمزيد من المعلومات حول استخدام خوادم MCP في VS Code.

```json
{
  "mcp": {
    "servers": {
      "my-custom-mcp": {
        "type": "stdio",
        "command": "dotnet",
        "args": [
          "tool",
          "exec",
          "<معرف الحزمة الخاص بك هنا>",
          "--version",
          "<إصدار الحزمة الخاص بك هنا>",
          "--yes",
          "--",
          "start-mcp"
        ],
        "env": {
          "MAX_RANDOM_NUMBER": 100
        }
      }
    }
  }
}
```

يمكنك الآن أن تطلب من دردشة Copilot إعطاء رقم عشوائي، على سبيل المثال `أعطني 3 أرقام عشوائية`. يجب أن يقترح استخدام أداة `GetRandomNumber` على خادم MCP المسمى `my-custom-mcp` ويعرض لك النتائج.

## التطوير محلياً

لاختبار خادم MCP هذا من الشيفرة المصدرية (محلياً) دون استخدام حزمة خادم MCP مبنية، استخدم التكوين التالي في VS Code:

```json
{
  "mcp": {
    "servers": {
      "my-custom-mcp": {
        "type": "stdio",
        "command": "dotnet",
        "args": [
          "run",
          "--project",
          "<مسار مجلد المشروع>",
          "--",
          "start-mcp"
        ],
        "env": {
          "MAX_RANDOM_NUMBER": 100
        }
      }
    }
  }
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---