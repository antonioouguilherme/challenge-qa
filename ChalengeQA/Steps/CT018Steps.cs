using System.Runtime;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class CT018Step : StepBase
{
   [Given("que o usuário esteja na tela que informe seus dados de acesso")] 
   public void DadoQueOUsuarioEstejaNaTelaQueInformeSeusDadosDeAcesso()
   {
       //Tela que informa os dados de acesso https://developer.grupoa.education/subscription/personal-data/confirmation
       driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/personal-data/confirmation");
   }
   
   [When("clicar em 'Acessar área do candidato'")]
    public void QuandoClicarEmAcessarAreaDoCandidato()
    {
         //Clique no botão de acessar área do candidato
         driver.FindElement(By.CssSelector("[data-testid='next-button']")).Click();
    }
    
    [Then("será direcionado para a tela de autenticação")]
    public void EntaoSeraDirecionadoParaATelaDeAutenticacao()
    {
        // Localizar o elemento com a mensagem
        var alertElement = driver.FindElement(By.CssSelector(".text-sm.text-muted-foreground"));

        // Verificar se o texto está correto 
        alertElement.Text.Should().Be("Faça login para acessar a área do candidato");
    }
}