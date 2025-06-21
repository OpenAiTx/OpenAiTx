# KestrelApp
أمثلة تطبيقات برمجة الشبكات المبنية على Kestrel

### 1 نية المشروع
1. فهم أن برمجة الشبكات لم تعد بحاجة إلى البدء من Socket
2. فهم أن برمجة الشبكات لم تعد بحاجة إلى أطر عمل خارجية (بما في ذلك Dotnetty)
3. التعرف على برمجة الشبكات من نوع `telnet` عبر `websocket` عبر `tls` عبر `تشفير خاص xxx` عبر `tcp`
4. القدرة على تطوير تطبيقات شبكات مبنية على KestrelFramework

### 2 مستندات المشروع
**المستندات الداخلية**：[docs](docs)

**المستندات الخارجية**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
بعض المكتبات الأساسية الضرورية لبرمجة الشبكات باستخدام kestrel
1. واجهة ومُسجل الوسيط (Middleware) في Kestrel
2. System.Buffers: فئة عمليات إدارة الذاكرة المؤقتة
3. System.IO: فئة عمليات التدفق
4. System.IO.Pipelines: فئة عمليات الأنابيب المزدوجة
5. Middleware: بعض وسطاء kestrel

### 4 KestrelApp
تطبيقات Kestrel، وتشمل:
1. إعدادات نقطة النهاية (EndPoint) للمراقبة
2. إعدادات البروتوكول المستخدم في نقطة النهاية

### 5 KestrelApp.Middleware
مكتبة وسطاء KestrelApp
#### 5.1 Echo
مثال لبروتوكول تطبيق Echo بسيط

#### 5.2 FlowAnalyze
مثال لوسيط إحصاء حركة النقل في طبقة النقل

#### 5.3 FlowXor
مثال لوسيط معالجة حركة النقل بالـ XOR في طبقة النقل

#### 5.4 HttpProxy
مثال لتطبيق بروتوكول وكيل http

#### 5.5 Telnet
مثال لبروتوكول تطبيق Telnet بسيط

#### 5.6 TelnetProxy
مثال لإعادة توجيه الحركة إلى خادم telnet

#### 5.6 Redis
خادم بروتوكول redis، يوضح كيفية استخدام وسطاء التطبيقات كمثال

### مع البرمجيات مفتوحة المصدر تصبح الحياة أجمل
![التبرع](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---