//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Aspire.Hosting
{
    public static partial class PapercutSmtpHostingExtension
    {
        public static ApplicationModel.IResourceBuilder<ApplicationModel.PapercutSmtpContainerResource> AddPapercutSmtp(this IDistributedApplicationBuilder builder, string name, int? httpPort = null, int? smtpPort = null) { throw null; }
    }
}

namespace Aspire.Hosting.ApplicationModel
{
    public partial class PapercutSmtpContainerResource : ContainerResource, IResourceWithConnectionString, IResource, IManifestExpressionProvider, IValueProvider, IValueWithReferences
    {
        public PapercutSmtpContainerResource(string name) : base(default!, default) { }

        public ReferenceExpression ConnectionStringExpression { get { throw null; } }
    }
}