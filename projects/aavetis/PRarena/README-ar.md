### تحليلات طلبات السحب (PR): الحجم مقابل معدل النجاح (تحديث تلقائي)

شاهد [لوحة البيانات التفاعلية](https://prarena.ai) لهذه الإحصائيات.

## فهم المقاييس

تتبع وكلاء البرمجة بالذكاء الاصطناعي مسارات عمل مختلفة عند إنشاء طلبات السحب:

- **جميع طلبات السحب (PRs)**: كل طلب سحب تم إنشاؤه بواسطة وكيل، بما في ذلك طلبات السحب في وضع المسودة (DRAFT PRs)
- **طلبات السحب الجاهزة (Ready PRs)**: طلبات السحب غير المسودة الجاهزة للمراجعة والدمج
- **طلبات السحب المدمجة (Merged PRs)**: طلبات السحب التي تم دمجها بنجاح في قاعدة الشيفرة البرمجية

**الاختلافات الرئيسية في سير العمل**: بعض الوكلاء مثل **Codex** يقومون بالتكرار بشكل خاص ويقومون بإنشاء طلبات سحب جاهزة مباشرة، مما ينتج عنه عدد قليل جدًا من المسودات ولكن معدلات دمج عالية. بينما وكلاء آخرون مثل **Copilot** و**Codegen** يقومون أولاً بإنشاء طلبات سحب مسودة، مما يشجع على التكرار العلني قبل وضعها كجاهزة للمراجعة.

تركز الإحصائيات أدناه على **طلبات السحب الجاهزة فقط** للمقارنة العادلة بين الوكلاء عبر مسارات عمل مختلفة، وقياس قدرة كل وكيل على إنتاج شيفرة قابلة للدمج بغض النظر عما إذا كانوا يكررون بشكل علني (مع مسودات) أو بشكل خاص.

## مصادر البيانات

استكشف استعلامات البحث في GitHub المستخدمة:



- **جميع طلبات Copilot**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **طلبات Copilot المدمجة**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **جميع طلبات Codex**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **طلبات Codex المدمجة**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **جميع طلبات Cursor**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **طلبات Cursor المدمجة**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **جميع طلبات Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **طلبات Devin المدمجة**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **جميع طلبات Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **طلبات Codegen المدمجة**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## الإحصائيات الحالية

| المشروع | طلبات السحب الجاهزة | طلبات السحب المدمجة | معدل النجاح |
| ------- | ------------------ | ------------------ | ----------- |
| Copilot | 16,355 | 15,073 | 92.16% |
| Codex | 594,884 | 520,690 | 87.53% |
| Cursor | 7,474 | 5,560 | 74.39% |
| Devin | 29,168 | 19,221 | 65.9% |
| Codegen | 2,108 | 1,682 | 79.79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---