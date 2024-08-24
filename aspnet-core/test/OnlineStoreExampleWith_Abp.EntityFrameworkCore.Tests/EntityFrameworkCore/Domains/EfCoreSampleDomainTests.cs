using OnlineStoreExampleWith_Abp.Samples;
using Xunit;

namespace OnlineStoreExampleWith_Abp.EntityFrameworkCore.Domains;

[Collection(OnlineStoreExampleWith_AbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OnlineStoreExampleWith_AbpEntityFrameworkCoreTestModule>
{

}
