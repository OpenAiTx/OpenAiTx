### PR Analitikleri: Hacim vs Başarı Oranı (otomatik güncellenir)

Bu istatistikler için [etkileşimli gösterge tablosunu](https://prarena.ai) görüntüleyin.

## Metrikleri Anlama

Farklı yapay zeka kodlama ajanları, pull request (PR) oluştururken farklı iş akışlarını takip ederler:

- **Tüm PR’lar**: Bir ajan tarafından oluşturulan tüm pull request’ler, TASLAK PR’lar dahil
- **Hazır PR’lar**: İnceleme ve birleştirme için hazır olan, taslak olmayan pull request’ler
- **Birleşmiş PR’lar**: Başarıyla kod tabanına birleştirilen pull request’ler

**Temel iş akışı farklılıkları**: **Codex** gibi bazı ajanlar, özel olarak yineleme yapar ve doğrudan hazır PR’lar oluşturur, bu da çok az taslak fakat yüksek birleştirme oranı ile sonuçlanır. **Copilot** ve **Codegen** gibi diğerleri ise önce taslak PR’lar oluşturur, inceleme için hazır hale getirmeden önce herkese açık yinelemeyi teşvik eder.

Aşağıdaki istatistikler, farklı iş akışları arasında ajanları adil şekilde karşılaştırmak için **yalnızca Hazır PR’lara** odaklanır ve her ajanın kodu birleştirilebilir şekilde üretme yeteneğini, ister taslaklarla herkese açık ister özel olarak yineleme yapsın, ölçer.

## Veri Kaynakları

Kullanılan GitHub arama sorgularını keşfedin:



- **Tüm Copilot PR’ları**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **Birleşmiş Copilot PR’ları**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Tüm Codex PR’ları**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **Birleşmiş Codex PR’ları**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Tüm Cursor PR’ları**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **Birleşmiş Cursor PR’ları**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Tüm Devin PR’ları**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **Birleşmiş Devin PR’ları**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Tüm Codegen PR’ları**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **Birleşmiş Codegen PR’ları**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## Güncel İstatistikler

| Proje   | Hazır PR’lar | Birleşmiş PR’lar | Başarı Oranı |
| ------- | ------------ | ---------------- | ------------ |
| Copilot | 16.355       | 15.073           | %92,16       |
| Codex   | 594.884      | 520.690          | %87,53       |
| Cursor  | 7.474        | 5.560            | %74,39       |
| Devin   | 29.168       | 19.221           | %65,9        |
| Codegen | 2.108        | 1.682            | %79,79       |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---