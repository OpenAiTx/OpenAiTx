### PR Analytics: Volume vs Success Rate (pembaruan otomatis)

Lihat [dasbor interaktif](https://prarena.ai) untuk statistik ini.

## Memahami Metrik

Agen pengkodean AI yang berbeda mengikuti alur kerja yang berbeda saat membuat pull request:

- **All PRs**: Setiap pull request yang dibuat oleh agen, termasuk DRAFT PR
- **Ready PRs**: Pull request non-draft yang siap untuk ditinjau dan digabungkan
- **Merged PRs**: Pull request yang berhasil digabungkan ke dalam basis kode

**Perbedaan utama alur kerja**: Beberapa agen seperti **Codex** melakukan iterasi secara privat dan langsung membuat Ready PR, sehingga hanya sedikit draft tetapi tingkat penggabungan tinggi. Agen lain seperti **Copilot** dan **Codegen** membuat draft PR terlebih dahulu, mendorong iterasi publik sebelum menandainya siap untuk ditinjau.

Statistik di bawah ini hanya berfokus pada **Ready PRs** untuk membandingkan agen secara adil di berbagai alur kerja, mengukur kemampuan setiap agen untuk menghasilkan kode yang dapat digabungkan, terlepas dari apakah mereka melakukan iterasi secara publik (dengan draft) atau privat.

## Sumber data

Jelajahi kueri pencarian GitHub yang digunakan:



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

## Statistik Terkini

| Proyek   | Ready PRs | Merged PRs | Success Rate |
| -------- | --------- | ---------- | ------------ |
| Copilot  | 16.355    | 15.073     | 92,16%       |
| Codex    | 594.884   | 520.690    | 87,53%       |
| Cursor   | 7.474     | 5.560      | 74,39%       |
| Devin    | 29.168    | 19.221     | 65,9%        |
| Codegen  | 2.108     | 1.682      | 79,79%       |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---