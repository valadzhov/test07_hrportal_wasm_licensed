using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HRPortal.Pages;

namespace TestHRPortal
{
	[Collection("HRPortal")]
	public class TestMy_Info
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbAvatarModule),
				typeof(IgbInputModule),
				typeof(IgbSelectModule));
			var componentUnderTest = ctx.RenderComponent<My_Info>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
