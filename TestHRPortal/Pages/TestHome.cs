using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HRPortal.Pages;

namespace TestHRPortal
{
	[Collection("HRPortal")]
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbAvatarModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbListModule));
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
