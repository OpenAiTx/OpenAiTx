### PR Analytics: ปริมาณเทียบกับอัตราความสำเร็จ (อัปเดตอัตโนมัติ)

ดูสถิติเหล่านี้ได้ที่ [แดชบอร์ดแบบอินเตอร์แอคทีฟ](https://prarena.ai)

## ทำความเข้าใจตัวชี้วัด

เอเจนต์ AI เขียนโค้ดแต่ละตัวจะมีเวิร์กโฟลว์ต่างกันเมื่อสร้าง pull request:

- **All PRs**: ทุก pull request ที่สร้างโดยเอเจนต์ รวมถึง DRAFT PRs
- **Ready PRs**: pull request ที่ไม่ใช่ฉบับร่าง พร้อมสำหรับรีวิวและรวมโค้ด
- **Merged PRs**: pull request ที่รวมเข้ากับโค้ดเบสเรียบร้อยแล้ว

**ความแตกต่างของเวิร์กโฟลว์ที่สำคัญ**: เอเจนต์บางตัวอย่าง **Codex** จะวนซ้ำแบบส่วนตัวและสร้าง Ready PRs ทันที ทำให้มีร่างน้อยแต่มีอัตราการรวมสำเร็จสูง ในขณะที่เอเจนต์อย่าง **Copilot** และ **Codegen** จะสร้าง Draft PRs ก่อน เพื่อสนับสนุนการวนซ้ำแบบสาธารณะก่อนจะทำให้พร้อมสำหรับรีวิว

สถิติด้านล่างนี้จะเน้นที่ **Ready PRs เท่านั้น** เพื่อเปรียบเทียบเอเจนต์แต่ละตัวอย่างเป็นธรรมในแต่ละเวิร์กโฟลว์ โดยวัดความสามารถของแต่ละเอเจนต์ในการสร้างโค้ดที่สามารถ merge ได้ ไม่ว่าจะวนซ้ำแบบสาธารณะ (มี draft) หรือแบบส่วนตัว

## แหล่งข้อมูล

สำรวจ GitHub search query ที่ใช้ได้ที่:



- **All Copilot PRs**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **Merged Copilot PRs**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **All Codex PRs**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **Merged Codex PRs**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **All Cursor PRs**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **Merged Cursor PRs**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **All Devin PRs**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **Merged Devin PRs**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **All Codegen PRs**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **Merged Codegen PRs**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## สถิติล่าสุด

| โครงการ | Ready PRs | Merged PRs | อัตราความสำเร็จ |
| ------- | --------- | ---------- | ----------------- |
| Copilot | 16,355 | 15,073 | 92.16% |
| Codex | 594,884 | 520,690 | 87.53% |
| Cursor | 7,474 | 5,560 | 74.39% |
| Devin | 29,168 | 19,221 | 65.9% |
| Codegen | 2,108 | 1,682 | 79.79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---