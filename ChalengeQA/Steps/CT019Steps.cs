using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace ChanlegeQA.Steps
{
    [Binding]
    public class CT019Steps: StepBase
    {
        [Given("que o usuário esteja na tela de autenticação")]
        public void DadoQueOUsuarioEstejaNaTelaDeAutenticacao()
        {
            //https://developer.grupoa.education/subscription/authentication/login
            driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/authentication/login");
        }
        
        [Given("não preencheu nenhum campo")]
        public void DadoNaoPreencheuNenhumCampo()
        {
            // Garantir que os campos de entrada estejam vazios
            driver.FindElement(By.Name("username")).GetAttribute("value").Should().BeEmpty();
            driver.FindElement(By.Id("password")).GetAttribute("value").Should().BeEmpty();

        }
        
        [When("clicar em 'Login'")]
        public void QuandoClicarEmLogin()
        {
            // Simula o clique no botão de login sem preencher os campos
            driver.FindElement(By.CssSelector("[data-testid='login-button']")).Click();
        }
        
        [Then("será informado que senha e usuário são inválidos")]
        public void EntaoSeraInformadoQueSenhaEUsuarioSaoInvalidos()
        {
            // Simula mais um clique para garantir que a mensagem de erro seja exibida
            driver.FindElement(By.CssSelector("[data-testid='login-button']")).Click();

            // Localizar o elemento com a mensagem de alerta
            var alertElement = driver.FindElement(By.Id("radix-100-form-item-message"));

            // Verificar se o texto está correto
            alertElement.Text.Should().Be("Senha inválida");
        }
    }
}