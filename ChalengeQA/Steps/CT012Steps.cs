using System.Runtime;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class CT012Step : StepBase
{
    [Given("que o usuário esteja na tela de cadastro")]
    public void DadoQueOUsuarioEstejaNaTelaDeCadastro()
    {
        //Tela do cadastro https://developer.grupoa.education/subscription/personal-data
        driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/personal-data");
    }
    
    [When("clicar em 'Voltar'")]
    public void QuandoClicarEmVoltar()
    {
        //Clique no botão de voltar
        driver.FindElement(By.CssSelector("[data-testid='back-button']")).Click();
    }
    
    [Then("deverá voltar para a tela de seleção de curso")]
    public void EntaoDeveraVoltarParaATelaDeSelecaoDeCurso()
    {
        // Localizar o elemento com a mensagem
        var buttonElement = driver.FindElement(By.CssSelector("[data-testid='graduation-combo']"));

        // Verificar se o texto está correto
        buttonElement.Text.Should().Be("Selecione um curso...");
    }
}