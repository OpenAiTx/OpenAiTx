<!-- translated by https://openaitx.com please don't remove this remark, system needs this to check project status -->
<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

你好

欢迎  


在使用 Microsoft.AspNet.Server.Kestrel 时，有关闭（shutdown）功能吗？ASP.NET Core（前身为 ASP.NET vNext）显然有启动（Startup）流程，但没有提到关闭流程以及如何处理干净关闭。


   
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
在我的 `Startup` 文件中，我正在注册 OData 服务，构建模型并添加路由组件。假设 `ConfigureCommonServices` 函数是从 `Startup` 中调用的：


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
OData 控制器定义如下：


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
尽管 `odata/v1/$metadata` 显示 `UpdateRead` 和 `DeleteBulk` 已注册为操作，但当我访问 POST 地址 `.../odata/v1/NotificationEntry/NotificationService.Api.UpdateRead` 或 `DeleteBulk` 时却返回 404。

之前这是在 .net6 上实现的，升级到 .net8 后我为处理 OData 路由添加了很多代码。

我尝试启用 `RoutingAttributes` 选项，但没有帮助。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---