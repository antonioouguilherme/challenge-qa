using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace ChanlegeQA.Steps
{
    [Binding]
    public class CT001Steps : StepBase
    {
        [Given(@"que o usuario esteja na pagina inicial do portal de inscricoes")]
        public void DadoQueOUsuarioEstejaNaPaginaInicialDoPortalDeInscricoes()
        {
            //https://developer.grupoa.education/subscription/
            driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/");
        }

        [When(@"clicar em Privacidade")]
        public void QuandoClicarEmPrivacidade()
        {
            driver.FindElement(By.LinkText("Privacidade")).Click();
        }

        [Then(@"sera redirecionado para a tela Politica de Privacidade")]
        public void EntaoSeraRedirecionadoParaATelaPoliticaDePrivacidade()
        {
            driver.Url.Should().Be("https://developer.grupoa.education/subscription/privacy-policy");
        }
    }
}