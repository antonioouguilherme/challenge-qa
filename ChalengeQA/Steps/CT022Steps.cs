using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace ChanlegeQA.Steps
{
    [Binding]
    public class CT022Steps : StepBase
    {
        [Given("que o usuário recuperou o usuário ou redefiniu a senha")]
        public void DadoQueOUsuarioRecuperouOUsuarioOuRedefiniuASenha()
        {
            //https://developer.grupoa.education/subscription/authentication/reset-password
            driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/authentication/reset-password");
        }
        
        [When("clicar em 'Voltar para a Home'")]
        public void QuandoClicarEmVoltarParaAHome()
        {
            // Simula o clique no botão de Voltar para a Home
            driver.FindElement(By.CssSelector("[data-testid='back-button']")).Click();
        }
        
        [Then("será redirecionado para a tela de autenticação")]
        public void EntaoSeraRedirecionadoParaATelaDeAutenticacao()
        {
            // Localizar o elemento com a mensagem " Faça login para acessar a área do candidato "
            var alertElement = driver.FindElement(By.CssSelector(".text-sm.text-muted-foreground"));

            // Verificar se o texto está correto
            alertElement.Text.Should().Be(" Faça login para acessar a área do candidato ");

        }
    }
}