using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace ChanlegeQA.Steps
{
    [Binding]
    public class CT023Steps : StepBase
    {
        [Given("que o usuário esteja na área do candidato")]
        public void DadoQueOUsuarioEstejaNaAreaDoCandidato()
        {
            //https:https://developer.grupoa.education/subscription/candidate
            driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/candidate");
        }
        
        [When("clicar em 'Minhas inscrições'")]
        public void QuandoClicarEmMinhasInscricoes()
        {
            // Simula o clique no botão de Minhas inscrições
            driver.FindElement(By.LinkText("Minhas inscrições")).Click();
        }
        
        [Then("será direcionado para onde se encontra as inscrições")]
        public void EntaoSeraDirecionadoParaOndeSeEncontraAsInscricoes()
        {
            // Localizar o elemento com a mensagem
            var alertElement = driver.FindElement(By.CssSelector(".text-sm.text-muted-foreground"));

            // Verificar se o texto está correto
            alertElement.Text.Should().Be("Verifique abaixo a lista de inscrições");
        }
    }
}