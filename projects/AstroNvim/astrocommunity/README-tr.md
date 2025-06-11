<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">AstroNvim Topluluk Deposu</h1>

AstroNvim'in topluluk deposu, AstroNvim için topluluk tarafından katkıda bulunulan eklenti yapılandırma spesifikasyonlarını içerir — NeoVim yapılandırması olan AstroNvim’de kullanılan çeşitli eklentileri yönetmeye yardımcı olan bir eklenti koleksiyonu. Bu spesifikasyonlar, AstroNvim'de kullanılan çeşitli eklentilerin yönetilmesine yardımcı olur.

## 📦 Kurulum

Topluluk eklentilerini entegre etmek için, sağlanan yapılandırmaları `plugins` ayarlarınıza ekleyin; tercihen kendi eklentilerinizi içe aktarmadan önce, böylece tüm AstroCommunity değişiklikleri kendi geçersiz kılmalarınızdan önce yüklenmiş olur. [AstroNvim Şablonu](https://github.com/AstroNvim/template) kullanıyorsanız, bu işlemi `lua/community.lua` dosyanızda yapabilirsiniz. Eklentileri yapılandırmaya aşina değilseniz, [AstroNvim dokümantasyonuna](https://docs.astronvim.com/configuration/customizing_plugins/) başvurmanızı öneririz.

### AstroCommunity Eklentilerini İçe Aktarma

Aşağıdaki içeriği `lua/community.lua` dosyanıza entegre edin:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/colorscheme/catppuccin" },
  -- ... topluluk tarafından katkıda bulunulan diğer eklentileri buraya ekleyin
}
```

### AstroCommunity Kurulumlarını Özelleştirme

`lua/community.lua` dosyanızda AstroCommunity içe aktarımları tanımladıktan sonra, kendi eklenti tanımlarınızda (genellikle `lua/plugins/` dizininde yapılır) kurulumları daha da özelleştirebilirsiniz. Aşağıda, yukarıda gösterildiği gibi Catppuccin yüklü olduğu varsayılarak bir örnek verilmiştir.

```lua
return {
  { -- topluluk tarafından ayarlanan seçenekleri daha da özelleştir
    "catppuccin",
    opts = {
      integrations = {
        sandwich = false,
        noice = true,
        mini = true,
        leap = true,
        markdown = true,
        neotest = true,
        cmp = true,
        overseer = true,
        lsp_trouble = true,
        rainbow_delimiters = true,
      },
    },
  },
}
```

**Notlar:**

- İçe aktarımları devre dışı bırakmak için `enabled` seçeneğini `false` olarak ayarlayın. Var olan bir eklentiyi değiştirmek için iki yönteminiz var: tam depo adını kullanmak (örneğin, "m4xshen/smartcolumn.nvim") veya modül adını kullanmak (örneğin, "catppuccin"). Unutmayın, modül adı klasör adından farklı olabilir.
- Bir eklentiyi özelleştirirken tam içe aktarma yolunu kullanmanız önerilir; sadece depo adının kısa yazımını kullanmayın.
- Topluluk eklentilerinin birçok yönünü, ayarları, bağımlılıkları ve sürümleri dahil olmak üzere geçersiz kılabilirsiniz. Mevcut seçenekler hakkında daha fazla bilgi için [lazy.nvim dokümantasyonuna](https://lazy.folke.io/) bakınız.

## Katkıda Bulunma

Bir eklenti yapılandırması yazdıysanız ve bunu AstroCommunity deposuna eklemek istiyorsanız, lütfen [Katkı Rehberimizi](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) takip edin ve bir çekme isteği (pull request) gönderin. Değişikliklerinizi göndermeden önce titizlikle test ettiğinizden emin olun. Bu resmi bir depo değildir, bu yüzden kararlılığı topluluk katkılarına bağlıdır. Bu projenin nasıl büyüyüp geliştiğini görmek için heyecanlıyız!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---