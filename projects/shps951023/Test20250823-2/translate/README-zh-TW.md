<!-- translated by https://openaitx.com please don't remove this remark, system needs this to check project status -->
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="./translate/README.en.md">English</a>
        | <a href="./translate/README.zh-CN.md">简体中文</a>
        | <a href="./translate/README.zh-TW.md">繁體中文</a>
        | <a href="./translate/README.ja.md">日本語</a>
        | <a href="./translate/README.ko.md">한국어</a>
        | <a href="./translate/README.hi.md">हिन्दी</a>
        | <a href="./translate/README.th.md">ไทย</a>
        | <a href="./translate/README.fr.md">Français</a>
        | <a href="./translate/README.de.md">Deutsch</a>
        | <a href="./translate/README.es.md">Español</a>
        | <a href="./translate/README.it.md">Italiano</a>
        | <a href="./translate/README.ru.md">Русский</a>
        | <a href="./translate/README.pt.md">Português</a>
        | <a href="./translate/README.nl.md">Nederlands</a>
        | <a href="./translate/README.pl.md">Polski</a>
        | <a href="./translate/README.ar.md">العربية</a>
        | <a href="./translate/README.fa.md">فارسی</a>
        | <a href="./translate/README.tr.md">Türkçe</a>
        | <a href="./translate/README.vi.md">Tiếng Việt</a>
        | <a href="./translate/README.id.md">Bahasa Indonesia</a>
        | <a href="./translate/README.as.md">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# Test20250823-2

您好

歡迎  

使用 Microsoft.AspNet.Server.Kestrel 時，是否有關機功能？ASP.NET Core（前身為 ASP.NET vNext）明確有啟動流程，但未提及關機流程以及如何處理乾淨的關閉。



   
It begins fine, however only the top portion of image is actually converted and in the string is followed by thousands of repeating "A". Reconstructing the image just shows the top portion of the image. What am I doing wrong?

Currently I had not uploaded and redownloaded the string, it is all local until I can figure out what is wrong. I am using the imageString for the image source. I am using .net 6.0.



I have defined a model configuration to register `EntitySet` and `EntityTypes` for OData:

```
public class NotificationEntryModelConfiguration : IModelConfiguration
{
    /// <inheritdoc />
    public void Apply(ODataModelBuilder builder, ApiVersion apiVersion, string routePrefix)
    {
        builder.Namespace = "NotificationService.Api";
        builder.EntitySet<NotificationEntryDto>("NotificationEntry")
            .EntityType
            .HasKey(p => p.Id);
        ConfigureAlertDto(builder);
        builder.EntityType<NotificationEntryDto>()
            .Collection
            .Action("UpdateRead")
            .Parameter<NotificationReadRequestDto>("body");
        builder.EntityType<NotificationEntryDto>()
            .Collection
            .Action("DeleteBulk")
            .Parameter<NotificationBulkDeleteRequestDto>("body");
    }

    private static void ConfigureAlertDto(ODataModelBuilder builder)
    {
        builder.AddEnumType(typeof(NotificationComponent));
        builder.AddEnumType(typeof(NotificationSeverity));
        builder.AddEnumType(typeof(UserNotificationState));

        var entityType = builder.EntitySet<AlertDto>("Alerts").EntityType;
        entityType.HasKey(p => p.Id);
        entityType.Property(p => p.Id).Name = "Id";
        entityType.Property(p => p.NotificationName).Name = "NotificationName";
        entityType.Property(p => p.Data).Name = "Data";
        entityType.EnumProperty(p => p.Component).Name = "Component";
        entityType.EnumProperty(p => p.Severity).Name = "Severity";
        entityType.Property(p => p.CreationTime).Name = "CreationTime";
        entityType.EnumProperty(p => p.State).Name = "State";
        entityType.Property(p => p.UserNotificationId).Name = "UserNotificationId";
        entityType.Property(p => p.DeepLinkRelativeUrl).Name = "DeepLinkRelativeUrl";
    }
}
```
在我的 `Startup` 檔案中，我正在註冊 OData 服務、建立模型並新增路由元件。假設 `ConfigureCommonServices` 函式是從 `Startup` 被呼叫的：


```
protected override void ConfigureCommonServices<TStartup>(IServiceCollection services) where TStartup : class
{
    base.ConfigureCommonServices<TStartup>(services);
    services.AddCustomHealthCheck(Configuration);
    services.AddCustomCors(Configuration);

    // Discover local OData model configurations if any
    var startupAssembly = typeof(TStartup).Assembly;
    var modelConfigTypes = startupAssembly
        .GetTypes()
        .Where(t => typeof(IModelConfiguration).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
        .ToArray();

    var controllersBuilder = services.AddControllers(options => options.Filters.Add(typeof(ValidatorActionFilter)))
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Converters.Add(new StringEnumConverter());
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

    // Always add API versioning (Swagger depends on IApiVersionDescriptionProvider)
    services.AddCustomVersioning();

    if (modelConfigTypes.Length > 0)
    {
        // Enable OData features
        controllersBuilder.AddOData(opt =>
        {
            opt.Select().Expand().Filter().OrderBy().SetMaxTop(1000).Count();
            opt.EnableQueryFeatures();
        });

        // Add OData integration to versioning now that controllersBuilder OData is registered
        services.AddODataApiVersioning();

        // Build versioned EDM models and register route components using discovered configurations
        services.AddOptions<Microsoft.AspNetCore.OData.ODataOptions>()
            .Configure<IODataApiVersionCollectionProvider>((options, versionProvider) =>
            {
                var configs = new List<IModelConfiguration>(modelConfigTypes.Length);
                foreach (var t in modelConfigTypes)
                {
                    if (Activator.CreateInstance(t) is IModelConfiguration cfg)
                    {
                        configs.Add(cfg);
                    }
                }
                var builder = new VersionedODataModelBuilder(versionProvider, configs);
                var models = builder.GetEdmModels();
                foreach (var model in models)
                {
                    options.AddRouteComponents("odata/v{version:apiVersion}", model);
                }
            });

        // Keep case-insensitive enum resolver
        services.AddSingleton<ODataUriResolver>(sp => new StringAsEnumResolver { EnableCaseInsensitive = true });
    }

    services.AddSwagger<TStartup>();
    services.AddAppInsightsTelemetry(Configuration);
    services.CisAuthentication(Configuration);
}
```
OData 控制器定義如下：


```
public class NotificationEntryController : ODataController
{
    private readonly IMediator mediator;

    public NotificationEntryController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Retrieves all inAppNotifications.
    /// </summary>
    /// <returns>All available products.</returns>
    /// <response code="200">Products successfully retrieved.</response>
    [UiPathAuthorize(Policy = Policies.UserContext)]
    // [DormantEnableQuery]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ODataValue<IEnumerable<NotificationEntryDto>>), Status200OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [EndpointSeverity(EndpointSeverity.CRITICAL)]
    public async Task<ActionResult<PageResult<NotificationEntryDto>>> Get(ODataQueryOptions<NotificationEntryDto> queryOptions)
    {
        if (!(queryOptions.Count == null || bool.TryParse(queryOptions.Count.RawValue, out _)))
        {
            return this.BuildErrorResponse(string.Format(NotificationServiceConstants.InvalidCountQueryOption, queryOptions.Count.RawValue), (int)HttpStatusCode.BadRequest);
        }

        var res = await mediator.Send(new NotificationQueryOption(queryOptions));

        return this.BuildGetPaginatedApiResponse(res);
    }

    /// <summary>
    /// Marks the passed notifications as read/unread.
    /// </summary>
    /// <param name="body">NotificationReadRequestDto object</param>
    /// <returns>NoContentResult</returns>
    [HttpPost]
    [ProducesDefaultResponseType]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [UiPathAuthorize(Policy = Policies.UserContext)]
    [EndpointSeverity(EndpointSeverity.HIGH)]
    public async Task<IActionResult> UpdateRead([FromBody] NotificationReadRequestDto body)
    {
        var res = await mediator.Send(body);
        return this.BuildPostApiResponse(res);
    }

    /// <summary>
    /// Deletes the notification entry
    /// </summary>
    /// <param name="body">Collection of notification ids</param>
    /// <returns>NoContentResult</returns>
    [HttpPost]
    [ProducesDefaultResponseType]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [UiPathAuthorize(Policy = Policies.UserContext)]
    [EndpointSeverity(EndpointSeverity.MEDIUM)]
    public async Task<IActionResult> DeleteBulkAsync([FromBody] NotificationBulkDeleteRequestDto body)
    {
        var ids = body.NotifcationIds;
        if (!ids.Any() && !body.DeleteAll)
        {
            return this.BuildErrorResponse(NotificationServiceConstants.InvalidBulkdDeleteRequest, (int)HttpStatusCode.BadRequest);
        }
        var res = await mediator.Send(body);
        return this.BuildPostApiResponse(res);
    }
}
```
即使 `odata/v1/$metadata` 顯示已將 `UpdateRead` 和 `DeleteBulk` 註冊為動作 (Actions)，當我訪問 POST url `.../odata/v1/NotificationEntry/NotificationService.Api.UpdateRead` 或 `DeleteBulk` 時，卻拋出 404 錯誤。

這之前是針對 .net6 實作的，在升級到 .net8 後，我新增了許多處理 OData 路由的程式碼。

我嘗試啟用 `RoutingAttributes` 選項，但沒有幫助。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---