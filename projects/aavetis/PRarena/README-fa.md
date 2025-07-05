### تحلیل PR: حجم در مقابل نرخ موفقیت (به‌روزرسانی خودکار)

برای مشاهده این آمارها، [داشبورد تعاملی](https://prarena.ai) را مشاهده کنید.

## درک معیارها

عامل‌های مختلف برنامه‌نویسی مبتنی بر هوش مصنوعی، هنگام ایجاد درخواست‌های pull (PR)، گردش‌کارهای متفاوتی را دنبال می‌کنند:

- **همه PRها**: هر درخواست pull ایجادشده توسط یک عامل، شامل PRهای DRAFT
- **PRهای آماده**: درخواست‌های pull غیرپیش‌نویس که آماده بررسی و ادغام هستند
- **PRهای ادغام‌شده**: درخواست‌های pull که با موفقیت در کدبیس ادغام شده‌اند

**تفاوت‌های کلیدی گردش‌کار**: برخی عامل‌ها مانند **Codex** به صورت خصوصی تکرار می‌کنند و مستقیماً PRهای آماده ایجاد می‌کنند، که منجر به پیش‌نویس‌های بسیار کم اما نرخ ادغام بالا می‌شود. سایر عامل‌ها مانند **Copilot** و **Codegen** ابتدا PRهای پیش‌نویس ایجاد می‌کنند و تکرار عمومی را قبل از علامت‌گذاری به عنوان آماده برای بررسی تشویق می‌کنند.

آمارهای زیر فقط بر **PRهای آماده** متمرکز هستند تا عامل‌ها را در گردش‌کارهای مختلف به طور منصفانه مقایسه کنند و توانایی هر عامل در تولید کد قابل ادغام را، صرف‌نظر از اینکه به صورت عمومی (با پیش‌نویس) یا خصوصی تکرار می‌کنند، اندازه‌گیری کنند.

## منابع داده

کوئری‌های جستجوی GitHub مورد استفاده را بررسی کنید:



- **همه PRهای Copilot**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **PRهای ادغام‌شده Copilot**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **همه PRهای Codex**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **PRهای ادغام‌شده Codex**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **همه PRهای Cursor**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **PRهای ادغام‌شده Cursor**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **همه PRهای Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **PRهای ادغام‌شده Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **همه PRهای Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **PRهای ادغام‌شده Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## آمار فعلی

| پروژه   | PRهای آماده | PRهای ادغام‌شده | نرخ موفقیت |
| ------- | ----------- | -------------- | ----------- |
| Copilot | 16,355      | 15,073         | 92.16%      |
| Codex   | 594,884     | 520,690        | 87.53%      |
| Cursor  | 7,474       | 5,560          | 74.39%      |
| Devin   | 29,168      | 19,221         | 65.9%       |
| Codegen | 2,108       | 1,682          | 79.79%      |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---