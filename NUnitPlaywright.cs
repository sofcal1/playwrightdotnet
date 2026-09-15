using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace PlaywrightDemo;

 public class NUnitPlaywright : PageTest
 {
[SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("https://eaapp.somee.com/");
 
        
         
    }

    [Test]
    public async Task Test1()
    {
        await Page.ClickAsync("text=Login");
        await Page.FillAsync("#UserName", "admin");
        await Page.FillAsync("#Password", "password");
        await Page.ClickAsync("text=Sign In");
        await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync();
       
        
        
        var isExist = await Page.Locator("text='Employee Details'").IsVisibleAsync();
        Assert.That(isExist, Is.True);
        
        
    }
    
    
}
